using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi
{
    public interface IMaterialUnitInterface : IBaseApi<MaterialUnitDTO>
    {
        //这里写该领域的私有方法
        RtnEntity<int> SetBasicUnit(MaterialUnitDTO param, Expression<Func<MaterialUnitDTO, bool>> lambdaWhere = null);
    }
}
