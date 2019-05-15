using System;
using System.Linq.Expressions;
using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class MaterialUnitInterface : AbsBaseApi<MaterialUnitDTO, BM_MEASUREMENT_UNIT>, IMaterialUnitInterface
    {
        //这里写该领域的私有方法
        public RtnEntity<int> SetBasicUnit(MaterialUnitDTO param, Expression<Func<MaterialUnitDTO, bool>> lambdaWhere = null)
        {
            if (param == null || string.IsNullOrEmpty(param.TYPE))
                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为空" };
            return this.Update(param, lambdaWhere);
        }
    }
}
