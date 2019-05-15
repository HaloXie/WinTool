using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class RouteLineInterface : AbsBaseApi<RouteLineDTO, BM_ROUTE_LINE>, IRouteLineInterface
    {
        //这里写该领域的私有方法        
        private RouteOperationInterface ChildInterface = new RouteOperationInterface();
        private RouteOperStepInterface ChildChildInterface = new RouteOperStepInterface();

        //这里写该领域的私有方法
        public IEnumerable<RouteLineDTO> GetListWithChild(Expression<Func<RouteLineDTO, bool>> lambdaWhere)
        {
            var list = this.GetListByExpr(lambdaWhere);
            if (list == null) return null;
            foreach (var item in list)
            {
                item.ListRouteOperationDTO = ChildInterface.GetListByExpr(x => x.MD_ROUTE_LINE_GID == item.GID);
                foreach (var itemChild in item.ListRouteOperationDTO ?? new List<RouteOperationDTO>())
                {
                    itemChild.ListRouteOperStepDTO = ChildChildInterface.GetListByExpr(x => x.BM_OPERATION_GID == itemChild.GID);
                }
            }
            return list;
        }

        public RtnEntity<int> CreateListWithChild(IEnumerable<RouteLineDTO> listParam)
        {
            if (listParam == null)
                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };

            return BaseEvent.Exec<int>(() =>
            {
                //创建主表
                foreach (var item in listParam)
                {
                    int count = this.CreateWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建主表信息返回值是0" };
                    //创建子表
                    foreach (var childItem in item.ListRouteOperationDTO ?? new List<RouteOperationDTO>())
                    {
                        count = this.ChildInterface.CreateWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };

                        //创建孙表
                        var tempChildChild = childItem.ListRouteOperStepDTO as List<RouteOperStepDTO>;
                        if (tempChildChild == null || tempChildChild.Count == 0) continue;
                        count = this.ChildChildInterface.BatchCreateWithOutTran(tempChildChild);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });
        }

        public RtnEntity<int> DeleteListWithChild(IEnumerable<RouteLineDTO> listParam)
        {
            if (listParam == null)
                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };

            return BaseEvent.Exec<int>(() =>
            {
                //删除主表
                foreach (var item in listParam)
                {
                    int count = this.DeleteWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除主表信息返回值是0" };

                    //删除子表
                    foreach (var childItem in item.ListRouteOperationDTO ?? new List<RouteOperationDTO>())
                    {
                        count = this.ChildInterface.DeleteWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除子表信息返回值是0" };

                        //删除孙表
                        var tempChildChild = childItem.ListRouteOperStepDTO as List<RouteOperStepDTO>;
                        if (tempChildChild != null && tempChildChild.Count > 0)
                        {
                            count = this.ChildChildInterface.DeleteWithOutTran(tempChildChild);
                            if (count == 0 || count != tempChildChild.Count)
                                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除孙表信息返回值是0" };
                        }
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });

        }
    }
}
