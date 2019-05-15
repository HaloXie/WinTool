using NeuSoft.ServcieInterface.InterfaceAPI;
using NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi;
using NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi.IME;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.IME;
using System;

namespace NeuSofr.ServiceInterface.ImplementInterfaceAPI
{
    public class InterfaceFactory : IInterfaceFactory
    {
        #region BM
        /// <summary>
        /// 质检方式信息（主）BM_QC_QUALITY_WAY
        /// </summary>
        public IQCQualityWayInterface QCQualityWayInterface
        {
            get
            {
                try
                {
                    return new QCQualityWayInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 质量等级信息（主）BM_QC_QUALITY_GRADE
        /// </summary>
        public IQCQualityGradeInterface QCQualityGradeInterface
        {
            get
            {
                try
                {
                    return new QCQualityGradeInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        ///缺陷信息（主） BM_QC_DEFECT
        /// </summary>
        public IQCDefectInterface QCDefectInterface
        {
            get
            {
                try
                {
                    return new QCDefectInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }


        /// <summary>
        /// 工作单元信息（主）BM_FACTORY_WORK_UNIT
        /// </summary>
        public IFactoryWorkUnitInterface FactoryWorkUnitInterface
        {
            get
            {
                try
                {
                    return new FactoryWorkUnitInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工位信息（主）BM_FACTORY_WORK_STATION
        /// </summary>
        public IFactoryWorkStationInterface FactoryWorkStationInterface
        {
            get
            {
                try
                {
                    return new FactoryWorkStationInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工作中心信息（主）BM_FACTORY_WORK_CENTER
        /// </summary>
        public IFactoryWorkCenterInterface FactoryWorkCenterInterface
        {
            get
            {
                try
                {
                    return new FactoryWorkCenterInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 产线信息（主）BM_FACTORY_LINE
        /// </summary>
        public IFactoryLineInterface IFactoryLineInterface
        {
            get
            {
                try
                {
                    return new FactoryLineInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工步信息（主）
        /// </summary>
        public IStepInfoInterface StepInfoInterface
        {
            get
            {
                try
                {
                    return new StepInfoInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工序信息（主）
        /// </summary>
        public IOperationInfoInterface OperationInfoInterface
        {
            get
            {
                try
                {
                    return new OperationInfoInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工步（子）
        /// </summary>
        public IOperationStepInterface OperationStepInterface
        {
            get
            {
                try
                {
                    return new OperationStepInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工艺信息（主实体）
        /// </summary>
        public IRouteLineInterface RouteLineInterface
        {
            get
            {
                try
                {
                    return new RouteLineInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工序（子）
        /// </summary>
        public IRouteOperationInterface RouteOperationInterface
        {
            get
            {
                try
                {
                    return new RouteOperationInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 工步（孙）
        /// </summary>
        public IRouteOperStepInterface RouteOperStepInterface
        {
            get
            {
                try
                {
                    return new RouteOperStepInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 产品信息（主）
        /// </summary>
        public IProductInfoInterface ProductInfoInterface
        {
            get
            {
                try
                {
                    return new ProductInfoInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 子物料（子）
        /// </summary>
        public IProductDetailInterface ProductDetailInterface
        {
            get
            {
                try
                {
                    return new ProductDetailInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 物料信息（主）
        /// </summary>
        public IMaterialInfoInterface MaterialInfoInterface
        {
            get
            {
                try
                {
                    return new MaterialInfoInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 物料分类信息（主）
        /// </summary>
        public IMaterialTypeInterface MaterialTypeInterface
        {
            get
            {
                try
                {
                    return new MaterialTypeInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 计量单位信息（主）
        /// </summary>
        public IMaterialUnitInterface MaterialUnitInterface
        {
            get
            {
                try
                {
                    return new MaterialUnitInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        #endregion

        #region IME
        /// <summary>
        /// 生产报工对象
        /// </summary>
        public IReportOrderInterface ReportOrderInterface
        {
            get
            {
                try
                {
                    return new ReportOrderInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 报工工步
        /// </summary>
        public IReportOrderStepsInterface ReportOrderStepsInterface
        {
            get
            {
                try
                {
                    return new ReportOrderStepsInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 派工单对象主表
        /// </summary>
        public ITrackOrderInterface TrackOrderInterface
        {
            get
            {
                try
                {
                    return new TrackOrderInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 工序工位子表
        /// </summary>
        public ITrackOrderOperationInterface TrackOrderOperationInterface
        {
            get
            {
                try
                {
                    return new TrackOrderOperationInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        ///  派工单工序人员资源（主实体）
        /// </summary>
        public ITrackOrderPersonInterface TrackOrderPersonInterface
        {
            get
            {
                try
                {
                    return new TrackOrderPersonInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 工序工步子表
        /// </summary>
        public ITrackOrderStepsInterface TrackOrderStepsInterface
        {
            get
            {
                try
                {
                    return new TrackOrderStepsInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 工单（主实体）
        /// </summary>
        public IWorkOrderBomInterface WorkOrderBomInterface
        {
            get
            {
                try
                {
                    return new WorkOrderBomInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 产品子物料（子）
        /// </summary>
        public IWorkSerialManagerInterface WorkSerialManagerInterface
        {
            get
            {
                try
                {
                    return new WorkSerialManagerInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 物料需求实体
        /// </summary>
        public ILogisticMaterialReqInterface LogisticMaterialReqInterface
        {
            get
            {
                try
                {
                    return new LogisticMaterialReqInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 收货实体
        /// </summary>
        public ILogisticReceiveInterface LogisticReceiveInterface
        {
            get
            {
                try
                {
                    return new LogisticReceiveInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 需求包明细子表
        /// </summary>
        public ILogisticReqPackageDetailInterface LogisticReqPackageDetailInterface
        {
            get
            {
                try
                {
                    return new LogisticReqPackageDetailInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 需求宝主表
        /// </summary>
        public ILogisticReqPackageInterface LogisticReqPackageInterface
        {
            get
            {
                try
                {
                    return new LogisticReqPackageInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 收货对象明细子表
        /// </summary>
        public ILogisticReceiveDetailInterface LogisticReceiveDetailInterface
        {
            get
            {
                try
                {
                    return new LogisticReceiveDetailInterface();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 关键件信息（主实体）IME_QC_KEY_MODULE
        /// </summary>
        public IQCKeyModuleInterface QCKeyModuleInterface
        {
            get
            {
                try
                {
                    return new QCKeyModuleInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 子物料（子）IME_QC_KEY_MODULE_INFO
        /// </summary>
        public IQCKeyModuleInfoInterface QCKeyModuleInfoInterface
        {
            get
            {
                try
                {
                    return new QCKeyModuleInfoInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 检具量具信息（主）
        /// </summary>
        public IQCCheckingToolInterface QCCheckingToolInterface
        {
            get
            {
                try
                {
                    return new QCCheckingToolInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 派检单信息（主实体）
        /// </summary>
        public IQcQacBillInterface QcQacBillInterface
        {
            get
            {
                try
                {
                    return new QcQacBillInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        ///  报检单信息（主实体）
        /// </summary>
        public IQcQacRecordInterface QcQacRecordInterface
        {
            get
            {
                try
                {
                    return new QcQacRecordInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 检验卡（子）
        /// </summary>
        public IQcQacRecordCheckCardInterface QcQacRecordCheckCardInterface
        {
            get
            {
                try
                {
                    return new QcQacRecordCheckCardInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 缺陷信息（子）
        /// </summary>
        public IQcQacRecCkDefectcardInterface qcQacRecCkDefectcardInterface
        {
            get
            {
                try
                {
                    return new QcQacRecCkDefectcardInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public IWorkSerialManagerInterface workSerialManagerInterface
        {
            get
            {
                try
                {
                    return new WorkSerialManagerInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        #endregion

        #region SM

        /// <summary>
        /// 业务单元（主）
        /// </summary>
        public IBusiUnitInterface BusiUnitInterface
        {
            get
            {
                try
                {
                    return new BusiUnitInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 部门（主）
        /// </summary>
        public IDepartmentInterface DepartmentInterface
        {
            get
            {
                try
                {
                    return new DepartmentInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// 人员（主）
        /// </summary>
        public IPersonnelInterface PersonnelInterface
        {
            get
            {
                try
                {
                    return new PersonnelInterface();
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        #endregion
    }
}
