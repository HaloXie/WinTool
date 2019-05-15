using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi
{
    public interface IProductInfoInterface : IBaseApi<ProductInfoDTO>
    {
        //这里写该领域的私有方法
        IEnumerable<ProductInfoDTO> GetListWithChild(Expression<Func<ProductInfoDTO, bool>> lambdaWhere);
        RtnEntity<int> CreateListWithChild(IEnumerable<ProductInfoDTO> listParam);
        RtnEntity<int> DeleteListWithChild(IEnumerable<ProductInfoDTO> listParam);
    }
}
