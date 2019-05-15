using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class ProductInfoInterface : AbsBaseApi<ProductInfoDTO, BM_PRODUCT_INFO>, IProductInfoInterface
    {
        //这里写该领域的私有方法        
        private ProductDetailInterface ChildInterface = new ProductDetailInterface();

        //这里写该领域的私有方法
        public IEnumerable<ProductInfoDTO> GetListWithChild(Expression<Func<ProductInfoDTO, bool>> lambdaWhere)
        {
            var list = this.GetListByExpr(lambdaWhere);
            if (list == null) return null;
            foreach (var item in list)
            {
                item.ListProductDetailDTO = ChildInterface.GetListByExpr(x => x.MD_PRODUCT_INFO_GID == item.GID);
            }
            return list;
        }

        public RtnEntity<int> CreateListWithChild(IEnumerable<ProductInfoDTO> listParam)
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
                    foreach (var childItem in item.ListProductDetailDTO ?? new List<ProductDetailDTO>())
                    {
                        count = this.ChildInterface.CreateWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });
        }

        public RtnEntity<int> DeleteListWithChild(IEnumerable<ProductInfoDTO> listParam)
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
                    var tempChild = item.ListProductDetailDTO as List<ProductDetailDTO>;
                    if (tempChild != null && tempChild.Count > 0)
                    {
                        count = this.ChildInterface.DeleteWithOutTran(tempChild);
                        if (count == 0 || count != tempChild.Count)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });

        }
    }
}
