using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.BM;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi.BM
{
    public class WarehouseInterface : AbsBaseApi<WarehouseDTO, BM_WAREHOUSE>, IWarehouseInterface
    {
    }
}
