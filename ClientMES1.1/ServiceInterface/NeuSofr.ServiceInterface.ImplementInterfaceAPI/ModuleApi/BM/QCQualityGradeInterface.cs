﻿using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.BM;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class QCQualityGradeInterface : AbsBaseApi<QCQualityGradeDTO, BM_QC_QUALITY_GRADE>, IQCQualityGradeInterface
    {
    }
}
