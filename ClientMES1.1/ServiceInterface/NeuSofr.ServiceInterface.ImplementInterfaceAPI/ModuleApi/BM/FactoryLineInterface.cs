﻿using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class FactoryLineInterface : AbsBaseApi<FactoryLineDTO, BM_FACTORY_LINE>, IFactoryLineInterface
    {
    }
}
