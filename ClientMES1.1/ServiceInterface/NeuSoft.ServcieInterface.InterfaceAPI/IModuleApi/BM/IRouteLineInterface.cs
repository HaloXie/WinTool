using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi
{
    public interface IRouteLineInterface : IBaseApi<RouteLineDTO>
    {
        //这里写该领域的私有方法
        IEnumerable<RouteLineDTO> GetListWithChild(Expression<Func<RouteLineDTO, bool>> lambdaWhere);

        RtnEntity<int> CreateListWithChild(IEnumerable<RouteLineDTO> listParam);

        RtnEntity<int> DeleteListWithChild(IEnumerable<RouteLineDTO> listParam);
    }
}
