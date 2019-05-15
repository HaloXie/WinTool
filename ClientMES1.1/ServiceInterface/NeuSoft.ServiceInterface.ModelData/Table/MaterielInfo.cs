using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类MaterielInfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class MaterielInfo : Entity
    {
        public MaterielInfo() : base("MaterielInfo") { }

        #region Model
        private string _MaterielInfoGuid;
        private string _Code;
        private string _Name;
        private string _MeasurementUnitGuid;
        private string _Specifications;
        private string _Model;
        private string _WarehouseGuid;
        private bool? _HomeMadePiece;
        private bool? _OutSourcing;
        private bool? _PurchaseParts;
        private string _Abbreviation;
        private string _Alias;
        private string _VersionNumber;
        private string _FigureNumber;
        private bool? _IsEquipment;
        private bool? _IsResources;
        private string _TechnicsProcessGuid;
        private bool? _IsSubstitute;
        private bool? _IsReplacementPart;
        private bool? _IsCodeManagement;
        private bool? _IsProductionPath;
        private long? _TaktTime;
        private bool? _IsQualityAssurance;
        private string _InspectionMode;
        private string _InspectionType;
        private bool? _IsTraceBack;
        private string _MaterialWay;
        private bool? _IsProductionBatch;
        private long? _DailyWorkNum;
        private long? _MinProductionNum;
        private string _PersonGuid;
        private decimal? _ProductionMultiple;
        private string _WorkCenterGuid;
        private long? _PieLot;
        private string _DailyWorkMode;
        private string _DispatchingMode;
        private string _SequentialMode;
        private string _MaterielTypeGuid;
        private string _PackWay;
        private decimal? _PackNumber;
        private string _FilePath;
        private string _Remark1;
        private string _Remark2;
        private bool? _IsSparePart;
        private bool? _IsConsumptivePart;
        private bool? _IsMainBom;
        private bool? _IsDelete;
        private bool? _IsActive;
        private string _CreateBy;
        private string _UpdateBy;
        private DateTime? _CreateTime;
        private DateTime? _UpdateTime;
        private string _BusinessUnitGuid;
        private string _BusinessGroupGuid;
        private int? _VersionNum;
        /// <summary>
        /// 
        /// </summary>
        public string MaterielInfoGuid
        {
            get { return _MaterielInfoGuid; }
            set
            {
                this.OnPropertyValueChange(_.MaterielInfoGuid, _MaterielInfoGuid, value);
                this._MaterielInfoGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Code
        {
            get { return _Code; }
            set
            {
                this.OnPropertyValueChange(_.Code, _Code, value);
                this._Code = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set
            {
                this.OnPropertyValueChange(_.Name, _Name, value);
                this._Name = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MeasurementUnitGuid
        {
            get { return _MeasurementUnitGuid; }
            set
            {
                this.OnPropertyValueChange(_.MeasurementUnitGuid, _MeasurementUnitGuid, value);
                this._MeasurementUnitGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Specifications
        {
            get { return _Specifications; }
            set
            {
                this.OnPropertyValueChange(_.Specifications, _Specifications, value);
                this._Specifications = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Model
        {
            get { return _Model; }
            set
            {
                this.OnPropertyValueChange(_.Model, _Model, value);
                this._Model = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WarehouseGuid
        {
            get { return _WarehouseGuid; }
            set
            {
                this.OnPropertyValueChange(_.WarehouseGuid, _WarehouseGuid, value);
                this._WarehouseGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? HomeMadePiece
        {
            get { return _HomeMadePiece; }
            set
            {
                this.OnPropertyValueChange(_.HomeMadePiece, _HomeMadePiece, value);
                this._HomeMadePiece = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? OutSourcing
        {
            get { return _OutSourcing; }
            set
            {
                this.OnPropertyValueChange(_.OutSourcing, _OutSourcing, value);
                this._OutSourcing = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? PurchaseParts
        {
            get { return _PurchaseParts; }
            set
            {
                this.OnPropertyValueChange(_.PurchaseParts, _PurchaseParts, value);
                this._PurchaseParts = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Abbreviation
        {
            get { return _Abbreviation; }
            set
            {
                this.OnPropertyValueChange(_.Abbreviation, _Abbreviation, value);
                this._Abbreviation = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Alias
        {
            get { return _Alias; }
            set
            {
                this.OnPropertyValueChange(_.Alias, _Alias, value);
                this._Alias = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VersionNumber
        {
            get { return _VersionNumber; }
            set
            {
                this.OnPropertyValueChange(_.VersionNumber, _VersionNumber, value);
                this._VersionNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FigureNumber
        {
            get { return _FigureNumber; }
            set
            {
                this.OnPropertyValueChange(_.FigureNumber, _FigureNumber, value);
                this._FigureNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsEquipment
        {
            get { return _IsEquipment; }
            set
            {
                this.OnPropertyValueChange(_.IsEquipment, _IsEquipment, value);
                this._IsEquipment = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsResources
        {
            get { return _IsResources; }
            set
            {
                this.OnPropertyValueChange(_.IsResources, _IsResources, value);
                this._IsResources = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TechnicsProcessGuid
        {
            get { return _TechnicsProcessGuid; }
            set
            {
                this.OnPropertyValueChange(_.TechnicsProcessGuid, _TechnicsProcessGuid, value);
                this._TechnicsProcessGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsSubstitute
        {
            get { return _IsSubstitute; }
            set
            {
                this.OnPropertyValueChange(_.IsSubstitute, _IsSubstitute, value);
                this._IsSubstitute = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsReplacementPart
        {
            get { return _IsReplacementPart; }
            set
            {
                this.OnPropertyValueChange(_.IsReplacementPart, _IsReplacementPart, value);
                this._IsReplacementPart = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsCodeManagement
        {
            get { return _IsCodeManagement; }
            set
            {
                this.OnPropertyValueChange(_.IsCodeManagement, _IsCodeManagement, value);
                this._IsCodeManagement = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsProductionPath
        {
            get { return _IsProductionPath; }
            set
            {
                this.OnPropertyValueChange(_.IsProductionPath, _IsProductionPath, value);
                this._IsProductionPath = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long? TaktTime
        {
            get { return _TaktTime; }
            set
            {
                this.OnPropertyValueChange(_.TaktTime, _TaktTime, value);
                this._TaktTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsQualityAssurance
        {
            get { return _IsQualityAssurance; }
            set
            {
                this.OnPropertyValueChange(_.IsQualityAssurance, _IsQualityAssurance, value);
                this._IsQualityAssurance = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InspectionMode
        {
            get { return _InspectionMode; }
            set
            {
                this.OnPropertyValueChange(_.InspectionMode, _InspectionMode, value);
                this._InspectionMode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string InspectionType
        {
            get { return _InspectionType; }
            set
            {
                this.OnPropertyValueChange(_.InspectionType, _InspectionType, value);
                this._InspectionType = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsTraceBack
        {
            get { return _IsTraceBack; }
            set
            {
                this.OnPropertyValueChange(_.IsTraceBack, _IsTraceBack, value);
                this._IsTraceBack = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterialWay
        {
            get { return _MaterialWay; }
            set
            {
                this.OnPropertyValueChange(_.MaterialWay, _MaterialWay, value);
                this._MaterialWay = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsProductionBatch
        {
            get { return _IsProductionBatch; }
            set
            {
                this.OnPropertyValueChange(_.IsProductionBatch, _IsProductionBatch, value);
                this._IsProductionBatch = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long? DailyWorkNum
        {
            get { return _DailyWorkNum; }
            set
            {
                this.OnPropertyValueChange(_.DailyWorkNum, _DailyWorkNum, value);
                this._DailyWorkNum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long? MinProductionNum
        {
            get { return _MinProductionNum; }
            set
            {
                this.OnPropertyValueChange(_.MinProductionNum, _MinProductionNum, value);
                this._MinProductionNum = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PersonGuid
        {
            get { return _PersonGuid; }
            set
            {
                this.OnPropertyValueChange(_.PersonGuid, _PersonGuid, value);
                this._PersonGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ProductionMultiple
        {
            get { return _ProductionMultiple; }
            set
            {
                this.OnPropertyValueChange(_.ProductionMultiple, _ProductionMultiple, value);
                this._ProductionMultiple = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WorkCenterGuid
        {
            get { return _WorkCenterGuid; }
            set
            {
                this.OnPropertyValueChange(_.WorkCenterGuid, _WorkCenterGuid, value);
                this._WorkCenterGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public long? PieLot
        {
            get { return _PieLot; }
            set
            {
                this.OnPropertyValueChange(_.PieLot, _PieLot, value);
                this._PieLot = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DailyWorkMode
        {
            get { return _DailyWorkMode; }
            set
            {
                this.OnPropertyValueChange(_.DailyWorkMode, _DailyWorkMode, value);
                this._DailyWorkMode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DispatchingMode
        {
            get { return _DispatchingMode; }
            set
            {
                this.OnPropertyValueChange(_.DispatchingMode, _DispatchingMode, value);
                this._DispatchingMode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SequentialMode
        {
            get { return _SequentialMode; }
            set
            {
                this.OnPropertyValueChange(_.SequentialMode, _SequentialMode, value);
                this._SequentialMode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MaterielTypeGuid
        {
            get { return _MaterielTypeGuid; }
            set
            {
                this.OnPropertyValueChange(_.MaterielTypeGuid, _MaterielTypeGuid, value);
                this._MaterielTypeGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PackWay
        {
            get { return _PackWay; }
            set
            {
                this.OnPropertyValueChange(_.PackWay, _PackWay, value);
                this._PackWay = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PackNumber
        {
            get { return _PackNumber; }
            set
            {
                this.OnPropertyValueChange(_.PackNumber, _PackNumber, value);
                this._PackNumber = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FilePath
        {
            get { return _FilePath; }
            set
            {
                this.OnPropertyValueChange(_.FilePath, _FilePath, value);
                this._FilePath = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark1
        {
            get { return _Remark1; }
            set
            {
                this.OnPropertyValueChange(_.Remark1, _Remark1, value);
                this._Remark1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark2
        {
            get { return _Remark2; }
            set
            {
                this.OnPropertyValueChange(_.Remark2, _Remark2, value);
                this._Remark2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsSparePart
        {
            get { return _IsSparePart; }
            set
            {
                this.OnPropertyValueChange(_.IsSparePart, _IsSparePart, value);
                this._IsSparePart = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsConsumptivePart
        {
            get { return _IsConsumptivePart; }
            set
            {
                this.OnPropertyValueChange(_.IsConsumptivePart, _IsConsumptivePart, value);
                this._IsConsumptivePart = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsMainBom
        {
            get { return _IsMainBom; }
            set
            {
                this.OnPropertyValueChange(_.IsMainBom, _IsMainBom, value);
                this._IsMainBom = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsDelete
        {
            get { return _IsDelete; }
            set
            {
                this.OnPropertyValueChange(_.IsDelete, _IsDelete, value);
                this._IsDelete = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsActive
        {
            get { return _IsActive; }
            set
            {
                this.OnPropertyValueChange(_.IsActive, _IsActive, value);
                this._IsActive = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreateBy
        {
            get { return _CreateBy; }
            set
            {
                this.OnPropertyValueChange(_.CreateBy, _CreateBy, value);
                this._CreateBy = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateBy
        {
            get { return _UpdateBy; }
            set
            {
                this.OnPropertyValueChange(_.UpdateBy, _UpdateBy, value);
                this._UpdateBy = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange(_.CreateTime, _CreateTime, value);
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return _UpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.UpdateTime, _UpdateTime, value);
                this._UpdateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessUnitGuid
        {
            get { return _BusinessUnitGuid; }
            set
            {
                this.OnPropertyValueChange(_.BusinessUnitGuid, _BusinessUnitGuid, value);
                this._BusinessUnitGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessGroupGuid
        {
            get { return _BusinessGroupGuid; }
            set
            {
                this.OnPropertyValueChange(_.BusinessGroupGuid, _BusinessGroupGuid, value);
                this._BusinessGroupGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VersionNum
        {
            get { return _VersionNum; }
            set
            {
                this.OnPropertyValueChange(_.VersionNum, _VersionNum, value);
                this._VersionNum = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.MaterielInfoGuid,
                _.Code,
                _.Name,
                _.MeasurementUnitGuid,
                _.Specifications,
                _.Model,
                _.WarehouseGuid,
                _.HomeMadePiece,
                _.OutSourcing,
                _.PurchaseParts,
                _.Abbreviation,
                _.Alias,
                _.VersionNumber,
                _.FigureNumber,
                _.IsEquipment,
                _.IsResources,
                _.TechnicsProcessGuid,
                _.IsSubstitute,
                _.IsReplacementPart,
                _.IsCodeManagement,
                _.IsProductionPath,
                _.TaktTime,
                _.IsQualityAssurance,
                _.InspectionMode,
                _.InspectionType,
                _.IsTraceBack,
                _.MaterialWay,
                _.IsProductionBatch,
                _.DailyWorkNum,
                _.MinProductionNum,
                _.PersonGuid,
                _.ProductionMultiple,
                _.WorkCenterGuid,
                _.PieLot,
                _.DailyWorkMode,
                _.DispatchingMode,
                _.SequentialMode,
                _.MaterielTypeGuid,
                _.PackWay,
                _.PackNumber,
                _.FilePath,
                _.Remark1,
                _.Remark2,
                _.IsSparePart,
                _.IsConsumptivePart,
                _.IsMainBom,
                _.IsDelete,
                _.IsActive,
                _.CreateBy,
                _.UpdateBy,
                _.CreateTime,
                _.UpdateTime,
                _.BusinessUnitGuid,
                _.BusinessGroupGuid,
                _.VersionNum};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._MaterielInfoGuid,
                this._Code,
                this._Name,
                this._MeasurementUnitGuid,
                this._Specifications,
                this._Model,
                this._WarehouseGuid,
                this._HomeMadePiece,
                this._OutSourcing,
                this._PurchaseParts,
                this._Abbreviation,
                this._Alias,
                this._VersionNumber,
                this._FigureNumber,
                this._IsEquipment,
                this._IsResources,
                this._TechnicsProcessGuid,
                this._IsSubstitute,
                this._IsReplacementPart,
                this._IsCodeManagement,
                this._IsProductionPath,
                this._TaktTime,
                this._IsQualityAssurance,
                this._InspectionMode,
                this._InspectionType,
                this._IsTraceBack,
                this._MaterialWay,
                this._IsProductionBatch,
                this._DailyWorkNum,
                this._MinProductionNum,
                this._PersonGuid,
                this._ProductionMultiple,
                this._WorkCenterGuid,
                this._PieLot,
                this._DailyWorkMode,
                this._DispatchingMode,
                this._SequentialMode,
                this._MaterielTypeGuid,
                this._PackWay,
                this._PackNumber,
                this._FilePath,
                this._Remark1,
                this._Remark2,
                this._IsSparePart,
                this._IsConsumptivePart,
                this._IsMainBom,
                this._IsDelete,
                this._IsActive,
                this._CreateBy,
                this._UpdateBy,
                this._CreateTime,
                this._UpdateTime,
                this._BusinessUnitGuid,
                this._BusinessGroupGuid,
                this._VersionNum};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._MaterielInfoGuid = DataUtils.ConvertValue<string>(reader["MaterielInfoGuid"]);
            this._Code = DataUtils.ConvertValue<string>(reader["Code"]);
            this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
            this._MeasurementUnitGuid = DataUtils.ConvertValue<string>(reader["MeasurementUnitGuid"]);
            this._Specifications = DataUtils.ConvertValue<string>(reader["Specifications"]);
            this._Model = DataUtils.ConvertValue<string>(reader["Model"]);
            this._WarehouseGuid = DataUtils.ConvertValue<string>(reader["WarehouseGuid"]);
            this._HomeMadePiece = DataUtils.ConvertValue<bool?>(reader["HomeMadePiece"]);
            this._OutSourcing = DataUtils.ConvertValue<bool?>(reader["OutSourcing"]);
            this._PurchaseParts = DataUtils.ConvertValue<bool?>(reader["PurchaseParts"]);
            this._Abbreviation = DataUtils.ConvertValue<string>(reader["Abbreviation"]);
            this._Alias = DataUtils.ConvertValue<string>(reader["Alias"]);
            this._VersionNumber = DataUtils.ConvertValue<string>(reader["VersionNumber"]);
            this._FigureNumber = DataUtils.ConvertValue<string>(reader["FigureNumber"]);
            this._IsEquipment = DataUtils.ConvertValue<bool?>(reader["IsEquipment"]);
            this._IsResources = DataUtils.ConvertValue<bool?>(reader["IsResources"]);
            this._TechnicsProcessGuid = DataUtils.ConvertValue<string>(reader["TechnicsProcessGuid"]);
            this._IsSubstitute = DataUtils.ConvertValue<bool?>(reader["IsSubstitute"]);
            this._IsReplacementPart = DataUtils.ConvertValue<bool?>(reader["IsReplacementPart"]);
            this._IsCodeManagement = DataUtils.ConvertValue<bool?>(reader["IsCodeManagement"]);
            this._IsProductionPath = DataUtils.ConvertValue<bool?>(reader["IsProductionPath"]);
            this._TaktTime = DataUtils.ConvertValue<long?>(reader["TaktTime"]);
            this._IsQualityAssurance = DataUtils.ConvertValue<bool?>(reader["IsQualityAssurance"]);
            this._InspectionMode = DataUtils.ConvertValue<string>(reader["InspectionMode"]);
            this._InspectionType = DataUtils.ConvertValue<string>(reader["InspectionType"]);
            this._IsTraceBack = DataUtils.ConvertValue<bool?>(reader["IsTraceBack"]);
            this._MaterialWay = DataUtils.ConvertValue<string>(reader["MaterialWay"]);
            this._IsProductionBatch = DataUtils.ConvertValue<bool?>(reader["IsProductionBatch"]);
            this._DailyWorkNum = DataUtils.ConvertValue<long?>(reader["DailyWorkNum"]);
            this._MinProductionNum = DataUtils.ConvertValue<long?>(reader["MinProductionNum"]);
            this._PersonGuid = DataUtils.ConvertValue<string>(reader["PersonGuid"]);
            this._ProductionMultiple = DataUtils.ConvertValue<decimal?>(reader["ProductionMultiple"]);
            this._WorkCenterGuid = DataUtils.ConvertValue<string>(reader["WorkCenterGuid"]);
            this._PieLot = DataUtils.ConvertValue<long?>(reader["PieLot"]);
            this._DailyWorkMode = DataUtils.ConvertValue<string>(reader["DailyWorkMode"]);
            this._DispatchingMode = DataUtils.ConvertValue<string>(reader["DispatchingMode"]);
            this._SequentialMode = DataUtils.ConvertValue<string>(reader["SequentialMode"]);
            this._MaterielTypeGuid = DataUtils.ConvertValue<string>(reader["MaterielTypeGuid"]);
            this._PackWay = DataUtils.ConvertValue<string>(reader["PackWay"]);
            this._PackNumber = DataUtils.ConvertValue<decimal?>(reader["PackNumber"]);
            this._FilePath = DataUtils.ConvertValue<string>(reader["FilePath"]);
            this._Remark1 = DataUtils.ConvertValue<string>(reader["Remark1"]);
            this._Remark2 = DataUtils.ConvertValue<string>(reader["Remark2"]);
            this._IsSparePart = DataUtils.ConvertValue<bool?>(reader["IsSparePart"]);
            this._IsConsumptivePart = DataUtils.ConvertValue<bool?>(reader["IsConsumptivePart"]);
            this._IsMainBom = DataUtils.ConvertValue<bool?>(reader["IsMainBom"]);
            this._IsDelete = DataUtils.ConvertValue<bool?>(reader["IsDelete"]);
            this._IsActive = DataUtils.ConvertValue<bool?>(reader["IsActive"]);
            this._CreateBy = DataUtils.ConvertValue<string>(reader["CreateBy"]);
            this._UpdateBy = DataUtils.ConvertValue<string>(reader["UpdateBy"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(reader["CreateTime"]);
            this._UpdateTime = DataUtils.ConvertValue<DateTime?>(reader["UpdateTime"]);
            this._BusinessUnitGuid = DataUtils.ConvertValue<string>(reader["BusinessUnitGuid"]);
            this._BusinessGroupGuid = DataUtils.ConvertValue<string>(reader["BusinessGroupGuid"]);
            this._VersionNum = DataUtils.ConvertValue<int?>(reader["VersionNum"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._MaterielInfoGuid = DataUtils.ConvertValue<string>(row["MaterielInfoGuid"]);
            this._Code = DataUtils.ConvertValue<string>(row["Code"]);
            this._Name = DataUtils.ConvertValue<string>(row["Name"]);
            this._MeasurementUnitGuid = DataUtils.ConvertValue<string>(row["MeasurementUnitGuid"]);
            this._Specifications = DataUtils.ConvertValue<string>(row["Specifications"]);
            this._Model = DataUtils.ConvertValue<string>(row["Model"]);
            this._WarehouseGuid = DataUtils.ConvertValue<string>(row["WarehouseGuid"]);
            this._HomeMadePiece = DataUtils.ConvertValue<bool?>(row["HomeMadePiece"]);
            this._OutSourcing = DataUtils.ConvertValue<bool?>(row["OutSourcing"]);
            this._PurchaseParts = DataUtils.ConvertValue<bool?>(row["PurchaseParts"]);
            this._Abbreviation = DataUtils.ConvertValue<string>(row["Abbreviation"]);
            this._Alias = DataUtils.ConvertValue<string>(row["Alias"]);
            this._VersionNumber = DataUtils.ConvertValue<string>(row["VersionNumber"]);
            this._FigureNumber = DataUtils.ConvertValue<string>(row["FigureNumber"]);
            this._IsEquipment = DataUtils.ConvertValue<bool?>(row["IsEquipment"]);
            this._IsResources = DataUtils.ConvertValue<bool?>(row["IsResources"]);
            this._TechnicsProcessGuid = DataUtils.ConvertValue<string>(row["TechnicsProcessGuid"]);
            this._IsSubstitute = DataUtils.ConvertValue<bool?>(row["IsSubstitute"]);
            this._IsReplacementPart = DataUtils.ConvertValue<bool?>(row["IsReplacementPart"]);
            this._IsCodeManagement = DataUtils.ConvertValue<bool?>(row["IsCodeManagement"]);
            this._IsProductionPath = DataUtils.ConvertValue<bool?>(row["IsProductionPath"]);
            this._TaktTime = DataUtils.ConvertValue<long?>(row["TaktTime"]);
            this._IsQualityAssurance = DataUtils.ConvertValue<bool?>(row["IsQualityAssurance"]);
            this._InspectionMode = DataUtils.ConvertValue<string>(row["InspectionMode"]);
            this._InspectionType = DataUtils.ConvertValue<string>(row["InspectionType"]);
            this._IsTraceBack = DataUtils.ConvertValue<bool?>(row["IsTraceBack"]);
            this._MaterialWay = DataUtils.ConvertValue<string>(row["MaterialWay"]);
            this._IsProductionBatch = DataUtils.ConvertValue<bool?>(row["IsProductionBatch"]);
            this._DailyWorkNum = DataUtils.ConvertValue<long?>(row["DailyWorkNum"]);
            this._MinProductionNum = DataUtils.ConvertValue<long?>(row["MinProductionNum"]);
            this._PersonGuid = DataUtils.ConvertValue<string>(row["PersonGuid"]);
            this._ProductionMultiple = DataUtils.ConvertValue<decimal?>(row["ProductionMultiple"]);
            this._WorkCenterGuid = DataUtils.ConvertValue<string>(row["WorkCenterGuid"]);
            this._PieLot = DataUtils.ConvertValue<long?>(row["PieLot"]);
            this._DailyWorkMode = DataUtils.ConvertValue<string>(row["DailyWorkMode"]);
            this._DispatchingMode = DataUtils.ConvertValue<string>(row["DispatchingMode"]);
            this._SequentialMode = DataUtils.ConvertValue<string>(row["SequentialMode"]);
            this._MaterielTypeGuid = DataUtils.ConvertValue<string>(row["MaterielTypeGuid"]);
            this._PackWay = DataUtils.ConvertValue<string>(row["PackWay"]);
            this._PackNumber = DataUtils.ConvertValue<decimal?>(row["PackNumber"]);
            this._FilePath = DataUtils.ConvertValue<string>(row["FilePath"]);
            this._Remark1 = DataUtils.ConvertValue<string>(row["Remark1"]);
            this._Remark2 = DataUtils.ConvertValue<string>(row["Remark2"]);
            this._IsSparePart = DataUtils.ConvertValue<bool?>(row["IsSparePart"]);
            this._IsConsumptivePart = DataUtils.ConvertValue<bool?>(row["IsConsumptivePart"]);
            this._IsMainBom = DataUtils.ConvertValue<bool?>(row["IsMainBom"]);
            this._IsDelete = DataUtils.ConvertValue<bool?>(row["IsDelete"]);
            this._IsActive = DataUtils.ConvertValue<bool?>(row["IsActive"]);
            this._CreateBy = DataUtils.ConvertValue<string>(row["CreateBy"]);
            this._UpdateBy = DataUtils.ConvertValue<string>(row["UpdateBy"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(row["CreateTime"]);
            this._UpdateTime = DataUtils.ConvertValue<DateTime?>(row["UpdateTime"]);
            this._BusinessUnitGuid = DataUtils.ConvertValue<string>(row["BusinessUnitGuid"]);
            this._BusinessGroupGuid = DataUtils.ConvertValue<string>(row["BusinessGroupGuid"]);
            this._VersionNum = DataUtils.ConvertValue<int?>(row["VersionNum"]);
        }
        #endregion

        #region _Field
        /// <summary>
        /// 字段信息
        /// </summary>
        public class _
        {
            /// <summary>
            /// * 
            /// </summary>
            public readonly static Field All = new Field("*", "MaterielInfo");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaterielInfoGuid = new Field("MaterielInfoGuid", "MaterielInfo", "MaterielInfoGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Code = new Field("Code", "MaterielInfo", "Code");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Name = new Field("Name", "MaterielInfo", "Name");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MeasurementUnitGuid = new Field("MeasurementUnitGuid", "MaterielInfo", "MeasurementUnitGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Specifications = new Field("Specifications", "MaterielInfo", "Specifications");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Model = new Field("Model", "MaterielInfo", "Model");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WarehouseGuid = new Field("WarehouseGuid", "MaterielInfo", "WarehouseGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HomeMadePiece = new Field("HomeMadePiece", "MaterielInfo", "HomeMadePiece");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OutSourcing = new Field("OutSourcing", "MaterielInfo", "OutSourcing");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PurchaseParts = new Field("PurchaseParts", "MaterielInfo", "PurchaseParts");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Abbreviation = new Field("Abbreviation", "MaterielInfo", "Abbreviation");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Alias = new Field("Alias", "MaterielInfo", "Alias");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VersionNumber = new Field("VersionNumber", "MaterielInfo", "VersionNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FigureNumber = new Field("FigureNumber", "MaterielInfo", "FigureNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsEquipment = new Field("IsEquipment", "MaterielInfo", "IsEquipment");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsResources = new Field("IsResources", "MaterielInfo", "IsResources");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TechnicsProcessGuid = new Field("TechnicsProcessGuid", "MaterielInfo", "TechnicsProcessGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsSubstitute = new Field("IsSubstitute", "MaterielInfo", "IsSubstitute");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsReplacementPart = new Field("IsReplacementPart", "MaterielInfo", "IsReplacementPart");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsCodeManagement = new Field("IsCodeManagement", "MaterielInfo", "IsCodeManagement");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsProductionPath = new Field("IsProductionPath", "MaterielInfo", "IsProductionPath");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TaktTime = new Field("TaktTime", "MaterielInfo", "TaktTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsQualityAssurance = new Field("IsQualityAssurance", "MaterielInfo", "IsQualityAssurance");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field InspectionMode = new Field("InspectionMode", "MaterielInfo", "InspectionMode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field InspectionType = new Field("InspectionType", "MaterielInfo", "InspectionType");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsTraceBack = new Field("IsTraceBack", "MaterielInfo", "IsTraceBack");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaterialWay = new Field("MaterialWay", "MaterielInfo", "MaterialWay");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsProductionBatch = new Field("IsProductionBatch", "MaterielInfo", "IsProductionBatch");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DailyWorkNum = new Field("DailyWorkNum", "MaterielInfo", "DailyWorkNum");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MinProductionNum = new Field("MinProductionNum", "MaterielInfo", "MinProductionNum");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PersonGuid = new Field("PersonGuid", "MaterielInfo", "PersonGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ProductionMultiple = new Field("ProductionMultiple", "MaterielInfo", "ProductionMultiple");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WorkCenterGuid = new Field("WorkCenterGuid", "MaterielInfo", "WorkCenterGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PieLot = new Field("PieLot", "MaterielInfo", "PieLot");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DailyWorkMode = new Field("DailyWorkMode", "MaterielInfo", "DailyWorkMode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DispatchingMode = new Field("DispatchingMode", "MaterielInfo", "DispatchingMode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SequentialMode = new Field("SequentialMode", "MaterielInfo", "SequentialMode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaterielTypeGuid = new Field("MaterielTypeGuid", "MaterielInfo", "MaterielTypeGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PackWay = new Field("PackWay", "MaterielInfo", "PackWay");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PackNumber = new Field("PackNumber", "MaterielInfo", "PackNumber");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FilePath = new Field("FilePath", "MaterielInfo", "FilePath");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Remark1 = new Field("Remark1", "MaterielInfo", "Remark1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field Remark2 = new Field("Remark2", "MaterielInfo", "Remark2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsSparePart = new Field("IsSparePart", "MaterielInfo", "IsSparePart");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsConsumptivePart = new Field("IsConsumptivePart", "MaterielInfo", "IsConsumptivePart");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsMainBom = new Field("IsMainBom", "MaterielInfo", "IsMainBom");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsDelete = new Field("IsDelete", "MaterielInfo", "IsDelete");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsActive = new Field("IsActive", "MaterielInfo", "IsActive");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateBy = new Field("CreateBy", "MaterielInfo", "CreateBy");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UpdateBy = new Field("UpdateBy", "MaterielInfo", "UpdateBy");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "MaterielInfo", "CreateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UpdateTime = new Field("UpdateTime", "MaterielInfo", "UpdateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BusinessUnitGuid = new Field("BusinessUnitGuid", "MaterielInfo", "BusinessUnitGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BusinessGroupGuid = new Field("BusinessGroupGuid", "MaterielInfo", "BusinessGroupGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VersionNum = new Field("VersionNum", "MaterielInfo", "VersionNum");
        }
        #endregion


    }

}
