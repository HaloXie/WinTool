
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.IME;

namespace NeuSoft.ServcieInterface.InterfaceAPI
{
    public interface IInterfaceFactory
    {

        #region BM

        /// <summary>
        /// 工步信息（主）
        /// </summary>
        IStepInfoInterface StepInfoInterface { get; }

        /// <summary>
        /// 工序信息（主）
        /// </summary>
        IOperationInfoInterface OperationInfoInterface { get; }

        /// <summary>
        /// 工步（子）
        /// </summary>
        IOperationStepInterface OperationStepInterface { get; }

        /// <summary>
        /// 工艺信息（主实体）
        /// </summary>
        IRouteLineInterface RouteLineInterface { get; }

        /// <summary>
        /// 工序（子）
        /// </summary>
        IRouteOperationInterface RouteOperationInterface { get; }

        /// <summary>
        /// 工步（孙）
        /// </summary>
        IRouteOperStepInterface RouteOperStepInterface { get; }

        /// <summary>
        /// 产品信息（主）
        /// </summary>
        IProductInfoInterface ProductInfoInterface { get; }

        /// <summary>
        /// 子物料（子）
        /// </summary>
        IProductDetailInterface ProductDetailInterface { get; }

        /// <summary>
        /// 物料信息（主）
        /// </summary>
        IMaterialInfoInterface MaterialInfoInterface { get; }

        /// <summary>
        /// 物料分类信息（主）
        /// </summary>
        IMaterialTypeInterface MaterialTypeInterface { get; }

        /// <summary>
        /// 计量单位信息（主）
        /// </summary>
        IMaterialUnitInterface MaterialUnitInterface { get; }

        #endregion

        #region IME

        /// <summary>
        /// 派检单信息（主实体）
        /// </summary>
        IQcQacBillInterface QcQacBillInterface { get; }

        /// <summary>
        ///  报检单信息（主实体）
        /// </summary>
        IQcQacRecordInterface QcQacRecordInterface { get; }

        /// <summary>
        /// 检验卡（子）
        /// </summary>
        IQcQacRecordCheckCardInterface QcQacRecordCheckCardInterface { get; }

        /// <summary>
        /// 缺陷信息（子）
        /// </summary>
        IQcQacRecCkDefectcardInterface qcQacRecCkDefectcardInterface { get; }

        IWorkSerialManagerInterface workSerialManagerInterface { get; }

        #endregion

        #region SM

        /// <summary>
        /// 部门（主）
        /// </summary>
        IDepartmentInterface DepartmentInterface { get; }

        /// <summary>
        /// 人员（主）
        /// </summary>
        IPersonnelInterface PersonnelInterface { get; }

        #endregion
    }
}
