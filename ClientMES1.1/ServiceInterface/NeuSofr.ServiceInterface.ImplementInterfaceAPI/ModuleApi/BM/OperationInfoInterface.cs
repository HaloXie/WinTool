using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class OperationInfoInterface : AbsBaseApi<OperationInfoDTO, BM_OPERATION_INFO>, IOperationInfoInterface
    {
        private OperationStepInterface OperationStepInterface = new OperationStepInterface();
        //这里写该领域的私有方法
        public IEnumerable<OperationInfoDTO> GetListWithChild(Expression<Func<OperationInfoDTO, bool>> lambdaWhere)
        {
            var ListOperationInfo = this.GetListByExpr(lambdaWhere);
            if (ListOperationInfo == null) return null;
            foreach (var item in ListOperationInfo)
            {
                item.ListOperationStepDTO = OperationStepInterface.GetListByExpr(x => x.BM_OPERATION_GID == item.GID);
            }
            return ListOperationInfo;
        }

        public RtnEntity<int> CreateListWithChild(IEnumerable<OperationInfoDTO> listParam)
        {
            return BaseEvent.Exec<int>(() =>
            {
                if (listParam == null)
                    return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };
                //创建主表
                foreach (var item in listParam)
                {
                    int count = this.CreateWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建主表信息返回值是0" };
                    //创建子表
                    foreach (var childItem in item.ListOperationStepDTO ?? new List<OperationStepDTO>())
                    {
                        count = this.OperationStepInterface.CreateWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });
        }

        public RtnEntity<int> DeleteListWithChild(IEnumerable<OperationInfoDTO> listParam)
        {
            return BaseEvent.Exec<int>(() =>
            {
                if (listParam == null)
                    return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };
                //删除主表
                foreach (var item in listParam)
                {
                    int count = this.DeleteWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除主表信息返回值是0" };

                    //删除子表
                    foreach (var childItem in item.ListOperationStepDTO ?? new List<OperationStepDTO>())
                    {
                        count = this.OperationStepInterface.DeleteWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });

        }
    }
}
