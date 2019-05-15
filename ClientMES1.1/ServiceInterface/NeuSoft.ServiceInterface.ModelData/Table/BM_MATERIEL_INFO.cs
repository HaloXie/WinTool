using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类BM_MATERIEL_INFO 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class BM_MATERIEL_INFO : Entity
    {
        public BM_MATERIEL_INFO() : base("BM_MATERIEL_INFO") { }

        #region Model
        private string _GID;
        private string _CODE;
        private string _NAME;
        private string _BM_MEASUREMENT_UNIT_GID;
        private string _SPEC;
        private string _MODEL;
        private string _BM_WAREHOUSE_GID;
        private decimal? _HOMEMADE_PIECE;
        private decimal? _OUTSOURCING;
        private decimal? _PURCHASE_PARTS;
        private string _ABBREVIATION;
        private string _ALIAS;
        private string _VERSION_NUMBER;
        private string _FIGURE_NUMBER;
        private decimal? _EQUIPMENT;
        private decimal? _RESOURCES;
        private string _BM_TECHNICS_PROCESS_GID;
        private decimal? _SUBSTITUTE;
        private decimal? _REPLACEMENT_PART;
        private decimal? _BAR_CODE_MANAGEMENT;
        private decimal? _SERIAL_NUM_MANAGEMENT;
        private decimal? _PRODUCTION_PATH;
        private decimal? _TAKT_TIME;
        private decimal? _QUALITY_ASSURANCE;
        private string _INSPECTION_MODE;
        private string _INSPECTION_TYPE;
        private decimal? _TRACE_BACK;
        private string _MATERIAL_WAY;
        private decimal? _PRODUCTION_BATCH;
        private decimal? _DAILY_WORK_NUM;
        private decimal? _MIN_PRODUCTION_NUM;
        private string _PERSON_GID;
        private decimal? _PRODUCTION_MULTIPLE;
        private string _WORK_CENTER_GID;
        private decimal? _PIE_LOT;
        private string _DAILY_WORK_MODE;
        private string _DISPATCHING_MODE;
        private string _SEQUENTIAL_MODE;
        private string _MATERIEL_TYPE_GID;
        private string _PACK_WAY;
        private decimal? _PACK_NUMBER;
        private string _FILE_PATH;
        private string _REMARK1;
        private string _REMARK2;
        private decimal? _SPARE_PART;
        private decimal? _CONSUMPTIVE_PART;
        private decimal? _MAIN_BOM;
        private string _CREATE_BY;
        private DateTime? _CREATE_TIME;
        private string _UPDATE_BY;
        private DateTime? _UPDATE_TIME;
        private decimal? _IS_DELETE;
        private decimal? _IS_ACTIVE;
        private string _SM_BUSI_GROUP_GID;
        private string _SM_BUSI_UNIT_GID;
        private decimal? _VERSION_NUM;
        private string _UDA1;
        private string _UDA2;
        private string _UDA3;
        private string _UDA4;
        private string _UDA5;
        private string _UDA6;
        private string _UDA7;
        private string _UDA8;
        private string _UDA9;
        private string _UDA10;
        private string _UDA11;
        private string _UDA12;
        private string _UDA13;
        private string _UDA14;
        private string _UDA15;
        private string _UDA16;
        private string _UDA17;
        private string _UDA18;
        private string _UDA19;
        private string _UDA20;
        /// <summary>
        /// 
        /// </summary>
        public string GID
        {
            get { return _GID; }
            set
            {
                this.OnPropertyValueChange(_.GID, _GID, value);
                this._GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CODE
        {
            get { return _CODE; }
            set
            {
                this.OnPropertyValueChange(_.CODE, _CODE, value);
                this._CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string NAME
        {
            get { return _NAME; }
            set
            {
                this.OnPropertyValueChange(_.NAME, _NAME, value);
                this._NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_MEASUREMENT_UNIT_GID
        {
            get { return _BM_MEASUREMENT_UNIT_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_MEASUREMENT_UNIT_GID, _BM_MEASUREMENT_UNIT_GID, value);
                this._BM_MEASUREMENT_UNIT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SPEC
        {
            get { return _SPEC; }
            set
            {
                this.OnPropertyValueChange(_.SPEC, _SPEC, value);
                this._SPEC = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MODEL
        {
            get { return _MODEL; }
            set
            {
                this.OnPropertyValueChange(_.MODEL, _MODEL, value);
                this._MODEL = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_WAREHOUSE_GID
        {
            get { return _BM_WAREHOUSE_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_WAREHOUSE_GID, _BM_WAREHOUSE_GID, value);
                this._BM_WAREHOUSE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? HOMEMADE_PIECE
        {
            get { return _HOMEMADE_PIECE; }
            set
            {
                this.OnPropertyValueChange(_.HOMEMADE_PIECE, _HOMEMADE_PIECE, value);
                this._HOMEMADE_PIECE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OUTSOURCING
        {
            get { return _OUTSOURCING; }
            set
            {
                this.OnPropertyValueChange(_.OUTSOURCING, _OUTSOURCING, value);
                this._OUTSOURCING = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PURCHASE_PARTS
        {
            get { return _PURCHASE_PARTS; }
            set
            {
                this.OnPropertyValueChange(_.PURCHASE_PARTS, _PURCHASE_PARTS, value);
                this._PURCHASE_PARTS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ABBREVIATION
        {
            get { return _ABBREVIATION; }
            set
            {
                this.OnPropertyValueChange(_.ABBREVIATION, _ABBREVIATION, value);
                this._ABBREVIATION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ALIAS
        {
            get { return _ALIAS; }
            set
            {
                this.OnPropertyValueChange(_.ALIAS, _ALIAS, value);
                this._ALIAS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string VERSION_NUMBER
        {
            get { return _VERSION_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.VERSION_NUMBER, _VERSION_NUMBER, value);
                this._VERSION_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FIGURE_NUMBER
        {
            get { return _FIGURE_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.FIGURE_NUMBER, _FIGURE_NUMBER, value);
                this._FIGURE_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? EQUIPMENT
        {
            get { return _EQUIPMENT; }
            set
            {
                this.OnPropertyValueChange(_.EQUIPMENT, _EQUIPMENT, value);
                this._EQUIPMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? RESOURCES
        {
            get { return _RESOURCES; }
            set
            {
                this.OnPropertyValueChange(_.RESOURCES, _RESOURCES, value);
                this._RESOURCES = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_TECHNICS_PROCESS_GID
        {
            get { return _BM_TECHNICS_PROCESS_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_TECHNICS_PROCESS_GID, _BM_TECHNICS_PROCESS_GID, value);
                this._BM_TECHNICS_PROCESS_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SUBSTITUTE
        {
            get { return _SUBSTITUTE; }
            set
            {
                this.OnPropertyValueChange(_.SUBSTITUTE, _SUBSTITUTE, value);
                this._SUBSTITUTE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? REPLACEMENT_PART
        {
            get { return _REPLACEMENT_PART; }
            set
            {
                this.OnPropertyValueChange(_.REPLACEMENT_PART, _REPLACEMENT_PART, value);
                this._REPLACEMENT_PART = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? BAR_CODE_MANAGEMENT
        {
            get { return _BAR_CODE_MANAGEMENT; }
            set
            {
                this.OnPropertyValueChange(_.BAR_CODE_MANAGEMENT, _BAR_CODE_MANAGEMENT, value);
                this._BAR_CODE_MANAGEMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SERIAL_NUM_MANAGEMENT
        {
            get { return _SERIAL_NUM_MANAGEMENT; }
            set
            {
                this.OnPropertyValueChange(_.SERIAL_NUM_MANAGEMENT, _SERIAL_NUM_MANAGEMENT, value);
                this._SERIAL_NUM_MANAGEMENT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PRODUCTION_PATH
        {
            get { return _PRODUCTION_PATH; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCTION_PATH, _PRODUCTION_PATH, value);
                this._PRODUCTION_PATH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TAKT_TIME
        {
            get { return _TAKT_TIME; }
            set
            {
                this.OnPropertyValueChange(_.TAKT_TIME, _TAKT_TIME, value);
                this._TAKT_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? QUALITY_ASSURANCE
        {
            get { return _QUALITY_ASSURANCE; }
            set
            {
                this.OnPropertyValueChange(_.QUALITY_ASSURANCE, _QUALITY_ASSURANCE, value);
                this._QUALITY_ASSURANCE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INSPECTION_MODE
        {
            get { return _INSPECTION_MODE; }
            set
            {
                this.OnPropertyValueChange(_.INSPECTION_MODE, _INSPECTION_MODE, value);
                this._INSPECTION_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INSPECTION_TYPE
        {
            get { return _INSPECTION_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.INSPECTION_TYPE, _INSPECTION_TYPE, value);
                this._INSPECTION_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TRACE_BACK
        {
            get { return _TRACE_BACK; }
            set
            {
                this.OnPropertyValueChange(_.TRACE_BACK, _TRACE_BACK, value);
                this._TRACE_BACK = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_WAY
        {
            get { return _MATERIAL_WAY; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_WAY, _MATERIAL_WAY, value);
                this._MATERIAL_WAY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PRODUCTION_BATCH
        {
            get { return _PRODUCTION_BATCH; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCTION_BATCH, _PRODUCTION_BATCH, value);
                this._PRODUCTION_BATCH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DAILY_WORK_NUM
        {
            get { return _DAILY_WORK_NUM; }
            set
            {
                this.OnPropertyValueChange(_.DAILY_WORK_NUM, _DAILY_WORK_NUM, value);
                this._DAILY_WORK_NUM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? MIN_PRODUCTION_NUM
        {
            get { return _MIN_PRODUCTION_NUM; }
            set
            {
                this.OnPropertyValueChange(_.MIN_PRODUCTION_NUM, _MIN_PRODUCTION_NUM, value);
                this._MIN_PRODUCTION_NUM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERSON_GID
        {
            get { return _PERSON_GID; }
            set
            {
                this.OnPropertyValueChange(_.PERSON_GID, _PERSON_GID, value);
                this._PERSON_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PRODUCTION_MULTIPLE
        {
            get { return _PRODUCTION_MULTIPLE; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCTION_MULTIPLE, _PRODUCTION_MULTIPLE, value);
                this._PRODUCTION_MULTIPLE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WORK_CENTER_GID
        {
            get { return _WORK_CENTER_GID; }
            set
            {
                this.OnPropertyValueChange(_.WORK_CENTER_GID, _WORK_CENTER_GID, value);
                this._WORK_CENTER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PIE_LOT
        {
            get { return _PIE_LOT; }
            set
            {
                this.OnPropertyValueChange(_.PIE_LOT, _PIE_LOT, value);
                this._PIE_LOT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DAILY_WORK_MODE
        {
            get { return _DAILY_WORK_MODE; }
            set
            {
                this.OnPropertyValueChange(_.DAILY_WORK_MODE, _DAILY_WORK_MODE, value);
                this._DAILY_WORK_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DISPATCHING_MODE
        {
            get { return _DISPATCHING_MODE; }
            set
            {
                this.OnPropertyValueChange(_.DISPATCHING_MODE, _DISPATCHING_MODE, value);
                this._DISPATCHING_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SEQUENTIAL_MODE
        {
            get { return _SEQUENTIAL_MODE; }
            set
            {
                this.OnPropertyValueChange(_.SEQUENTIAL_MODE, _SEQUENTIAL_MODE, value);
                this._SEQUENTIAL_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIEL_TYPE_GID
        {
            get { return _MATERIEL_TYPE_GID; }
            set
            {
                this.OnPropertyValueChange(_.MATERIEL_TYPE_GID, _MATERIEL_TYPE_GID, value);
                this._MATERIEL_TYPE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PACK_WAY
        {
            get { return _PACK_WAY; }
            set
            {
                this.OnPropertyValueChange(_.PACK_WAY, _PACK_WAY, value);
                this._PACK_WAY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PACK_NUMBER
        {
            get { return _PACK_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.PACK_NUMBER, _PACK_NUMBER, value);
                this._PACK_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FILE_PATH
        {
            get { return _FILE_PATH; }
            set
            {
                this.OnPropertyValueChange(_.FILE_PATH, _FILE_PATH, value);
                this._FILE_PATH = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REMARK1
        {
            get { return _REMARK1; }
            set
            {
                this.OnPropertyValueChange(_.REMARK1, _REMARK1, value);
                this._REMARK1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REMARK2
        {
            get { return _REMARK2; }
            set
            {
                this.OnPropertyValueChange(_.REMARK2, _REMARK2, value);
                this._REMARK2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SPARE_PART
        {
            get { return _SPARE_PART; }
            set
            {
                this.OnPropertyValueChange(_.SPARE_PART, _SPARE_PART, value);
                this._SPARE_PART = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CONSUMPTIVE_PART
        {
            get { return _CONSUMPTIVE_PART; }
            set
            {
                this.OnPropertyValueChange(_.CONSUMPTIVE_PART, _CONSUMPTIVE_PART, value);
                this._CONSUMPTIVE_PART = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? MAIN_BOM
        {
            get { return _MAIN_BOM; }
            set
            {
                this.OnPropertyValueChange(_.MAIN_BOM, _MAIN_BOM, value);
                this._MAIN_BOM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CREATE_BY
        {
            get { return _CREATE_BY; }
            set
            {
                this.OnPropertyValueChange(_.CREATE_BY, _CREATE_BY, value);
                this._CREATE_BY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_TIME
        {
            get { return _CREATE_TIME; }
            set
            {
                this.OnPropertyValueChange(_.CREATE_TIME, _CREATE_TIME, value);
                this._CREATE_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UPDATE_BY
        {
            get { return _UPDATE_BY; }
            set
            {
                this.OnPropertyValueChange(_.UPDATE_BY, _UPDATE_BY, value);
                this._UPDATE_BY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UPDATE_TIME
        {
            get { return _UPDATE_TIME; }
            set
            {
                this.OnPropertyValueChange(_.UPDATE_TIME, _UPDATE_TIME, value);
                this._UPDATE_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? IS_DELETE
        {
            get { return _IS_DELETE; }
            set
            {
                this.OnPropertyValueChange(_.IS_DELETE, _IS_DELETE, value);
                this._IS_DELETE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? IS_ACTIVE
        {
            get { return _IS_ACTIVE; }
            set
            {
                this.OnPropertyValueChange(_.IS_ACTIVE, _IS_ACTIVE, value);
                this._IS_ACTIVE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SM_BUSI_GROUP_GID
        {
            get { return _SM_BUSI_GROUP_GID; }
            set
            {
                this.OnPropertyValueChange(_.SM_BUSI_GROUP_GID, _SM_BUSI_GROUP_GID, value);
                this._SM_BUSI_GROUP_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SM_BUSI_UNIT_GID
        {
            get { return _SM_BUSI_UNIT_GID; }
            set
            {
                this.OnPropertyValueChange(_.SM_BUSI_UNIT_GID, _SM_BUSI_UNIT_GID, value);
                this._SM_BUSI_UNIT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? VERSION_NUM
        {
            get { return _VERSION_NUM; }
            set
            {
                this.OnPropertyValueChange(_.VERSION_NUM, _VERSION_NUM, value);
                this._VERSION_NUM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA1
        {
            get { return _UDA1; }
            set
            {
                this.OnPropertyValueChange(_.UDA1, _UDA1, value);
                this._UDA1 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA2
        {
            get { return _UDA2; }
            set
            {
                this.OnPropertyValueChange(_.UDA2, _UDA2, value);
                this._UDA2 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA3
        {
            get { return _UDA3; }
            set
            {
                this.OnPropertyValueChange(_.UDA3, _UDA3, value);
                this._UDA3 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA4
        {
            get { return _UDA4; }
            set
            {
                this.OnPropertyValueChange(_.UDA4, _UDA4, value);
                this._UDA4 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA5
        {
            get { return _UDA5; }
            set
            {
                this.OnPropertyValueChange(_.UDA5, _UDA5, value);
                this._UDA5 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA6
        {
            get { return _UDA6; }
            set
            {
                this.OnPropertyValueChange(_.UDA6, _UDA6, value);
                this._UDA6 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA7
        {
            get { return _UDA7; }
            set
            {
                this.OnPropertyValueChange(_.UDA7, _UDA7, value);
                this._UDA7 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA8
        {
            get { return _UDA8; }
            set
            {
                this.OnPropertyValueChange(_.UDA8, _UDA8, value);
                this._UDA8 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA9
        {
            get { return _UDA9; }
            set
            {
                this.OnPropertyValueChange(_.UDA9, _UDA9, value);
                this._UDA9 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA10
        {
            get { return _UDA10; }
            set
            {
                this.OnPropertyValueChange(_.UDA10, _UDA10, value);
                this._UDA10 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA11
        {
            get { return _UDA11; }
            set
            {
                this.OnPropertyValueChange(_.UDA11, _UDA11, value);
                this._UDA11 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA12
        {
            get { return _UDA12; }
            set
            {
                this.OnPropertyValueChange(_.UDA12, _UDA12, value);
                this._UDA12 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA13
        {
            get { return _UDA13; }
            set
            {
                this.OnPropertyValueChange(_.UDA13, _UDA13, value);
                this._UDA13 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA14
        {
            get { return _UDA14; }
            set
            {
                this.OnPropertyValueChange(_.UDA14, _UDA14, value);
                this._UDA14 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA15
        {
            get { return _UDA15; }
            set
            {
                this.OnPropertyValueChange(_.UDA15, _UDA15, value);
                this._UDA15 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA16
        {
            get { return _UDA16; }
            set
            {
                this.OnPropertyValueChange(_.UDA16, _UDA16, value);
                this._UDA16 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA17
        {
            get { return _UDA17; }
            set
            {
                this.OnPropertyValueChange(_.UDA17, _UDA17, value);
                this._UDA17 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA18
        {
            get { return _UDA18; }
            set
            {
                this.OnPropertyValueChange(_.UDA18, _UDA18, value);
                this._UDA18 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA19
        {
            get { return _UDA19; }
            set
            {
                this.OnPropertyValueChange(_.UDA19, _UDA19, value);
                this._UDA19 = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UDA20
        {
            get { return _UDA20; }
            set
            {
                this.OnPropertyValueChange(_.UDA20, _UDA20, value);
                this._UDA20 = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取实体中的主键列
        /// </summary>
        public override Field[] GetPrimaryKeyFields()
        {
            return new Field[] {
                _.GID};
        }
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.GID,
                _.CODE,
                _.NAME,
                _.BM_MEASUREMENT_UNIT_GID,
                _.SPEC,
                _.MODEL,
                _.BM_WAREHOUSE_GID,
                _.HOMEMADE_PIECE,
                _.OUTSOURCING,
                _.PURCHASE_PARTS,
                _.ABBREVIATION,
                _.ALIAS,
                _.VERSION_NUMBER,
                _.FIGURE_NUMBER,
                _.EQUIPMENT,
                _.RESOURCES,
                _.BM_TECHNICS_PROCESS_GID,
                _.SUBSTITUTE,
                _.REPLACEMENT_PART,
                _.BAR_CODE_MANAGEMENT,
                _.SERIAL_NUM_MANAGEMENT,
                _.PRODUCTION_PATH,
                _.TAKT_TIME,
                _.QUALITY_ASSURANCE,
                _.INSPECTION_MODE,
                _.INSPECTION_TYPE,
                _.TRACE_BACK,
                _.MATERIAL_WAY,
                _.PRODUCTION_BATCH,
                _.DAILY_WORK_NUM,
                _.MIN_PRODUCTION_NUM,
                _.PERSON_GID,
                _.PRODUCTION_MULTIPLE,
                _.WORK_CENTER_GID,
                _.PIE_LOT,
                _.DAILY_WORK_MODE,
                _.DISPATCHING_MODE,
                _.SEQUENTIAL_MODE,
                _.MATERIEL_TYPE_GID,
                _.PACK_WAY,
                _.PACK_NUMBER,
                _.FILE_PATH,
                _.REMARK1,
                _.REMARK2,
                _.SPARE_PART,
                _.CONSUMPTIVE_PART,
                _.MAIN_BOM,
                _.CREATE_BY,
                _.CREATE_TIME,
                _.UPDATE_BY,
                _.UPDATE_TIME,
                _.IS_DELETE,
                _.IS_ACTIVE,
                _.SM_BUSI_GROUP_GID,
                _.SM_BUSI_UNIT_GID,
                _.VERSION_NUM,
                _.UDA1,
                _.UDA2,
                _.UDA3,
                _.UDA4,
                _.UDA5,
                _.UDA6,
                _.UDA7,
                _.UDA8,
                _.UDA9,
                _.UDA10,
                _.UDA11,
                _.UDA12,
                _.UDA13,
                _.UDA14,
                _.UDA15,
                _.UDA16,
                _.UDA17,
                _.UDA18,
                _.UDA19,
                _.UDA20};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GID,
                this._CODE,
                this._NAME,
                this._BM_MEASUREMENT_UNIT_GID,
                this._SPEC,
                this._MODEL,
                this._BM_WAREHOUSE_GID,
                this._HOMEMADE_PIECE,
                this._OUTSOURCING,
                this._PURCHASE_PARTS,
                this._ABBREVIATION,
                this._ALIAS,
                this._VERSION_NUMBER,
                this._FIGURE_NUMBER,
                this._EQUIPMENT,
                this._RESOURCES,
                this._BM_TECHNICS_PROCESS_GID,
                this._SUBSTITUTE,
                this._REPLACEMENT_PART,
                this._BAR_CODE_MANAGEMENT,
                this._SERIAL_NUM_MANAGEMENT,
                this._PRODUCTION_PATH,
                this._TAKT_TIME,
                this._QUALITY_ASSURANCE,
                this._INSPECTION_MODE,
                this._INSPECTION_TYPE,
                this._TRACE_BACK,
                this._MATERIAL_WAY,
                this._PRODUCTION_BATCH,
                this._DAILY_WORK_NUM,
                this._MIN_PRODUCTION_NUM,
                this._PERSON_GID,
                this._PRODUCTION_MULTIPLE,
                this._WORK_CENTER_GID,
                this._PIE_LOT,
                this._DAILY_WORK_MODE,
                this._DISPATCHING_MODE,
                this._SEQUENTIAL_MODE,
                this._MATERIEL_TYPE_GID,
                this._PACK_WAY,
                this._PACK_NUMBER,
                this._FILE_PATH,
                this._REMARK1,
                this._REMARK2,
                this._SPARE_PART,
                this._CONSUMPTIVE_PART,
                this._MAIN_BOM,
                this._CREATE_BY,
                this._CREATE_TIME,
                this._UPDATE_BY,
                this._UPDATE_TIME,
                this._IS_DELETE,
                this._IS_ACTIVE,
                this._SM_BUSI_GROUP_GID,
                this._SM_BUSI_UNIT_GID,
                this._VERSION_NUM,
                this._UDA1,
                this._UDA2,
                this._UDA3,
                this._UDA4,
                this._UDA5,
                this._UDA6,
                this._UDA7,
                this._UDA8,
                this._UDA9,
                this._UDA10,
                this._UDA11,
                this._UDA12,
                this._UDA13,
                this._UDA14,
                this._UDA15,
                this._UDA16,
                this._UDA17,
                this._UDA18,
                this._UDA19,
                this._UDA20};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._GID = DataUtils.ConvertValue<string>(reader["GID"]);
            this._CODE = DataUtils.ConvertValue<string>(reader["CODE"]);
            this._NAME = DataUtils.ConvertValue<string>(reader["NAME"]);
            this._BM_MEASUREMENT_UNIT_GID = DataUtils.ConvertValue<string>(reader["BM_MEASUREMENT_UNIT_GID"]);
            this._SPEC = DataUtils.ConvertValue<string>(reader["SPEC"]);
            this._MODEL = DataUtils.ConvertValue<string>(reader["MODEL"]);
            this._BM_WAREHOUSE_GID = DataUtils.ConvertValue<string>(reader["BM_WAREHOUSE_GID"]);
            this._HOMEMADE_PIECE = DataUtils.ConvertValue<decimal?>(reader["HOMEMADE_PIECE"]);
            this._OUTSOURCING = DataUtils.ConvertValue<decimal?>(reader["OUTSOURCING"]);
            this._PURCHASE_PARTS = DataUtils.ConvertValue<decimal?>(reader["PURCHASE_PARTS"]);
            this._ABBREVIATION = DataUtils.ConvertValue<string>(reader["ABBREVIATION"]);
            this._ALIAS = DataUtils.ConvertValue<string>(reader["ALIAS"]);
            this._VERSION_NUMBER = DataUtils.ConvertValue<string>(reader["VERSION_NUMBER"]);
            this._FIGURE_NUMBER = DataUtils.ConvertValue<string>(reader["FIGURE_NUMBER"]);
            this._EQUIPMENT = DataUtils.ConvertValue<decimal?>(reader["EQUIPMENT"]);
            this._RESOURCES = DataUtils.ConvertValue<decimal?>(reader["RESOURCES"]);
            this._BM_TECHNICS_PROCESS_GID = DataUtils.ConvertValue<string>(reader["BM_TECHNICS_PROCESS_GID"]);
            this._SUBSTITUTE = DataUtils.ConvertValue<decimal?>(reader["SUBSTITUTE"]);
            this._REPLACEMENT_PART = DataUtils.ConvertValue<decimal?>(reader["REPLACEMENT_PART"]);
            this._BAR_CODE_MANAGEMENT = DataUtils.ConvertValue<decimal?>(reader["BAR_CODE_MANAGEMENT"]);
            this._SERIAL_NUM_MANAGEMENT = DataUtils.ConvertValue<decimal?>(reader["SERIAL_NUM_MANAGEMENT"]);
            this._PRODUCTION_PATH = DataUtils.ConvertValue<decimal?>(reader["PRODUCTION_PATH"]);
            this._TAKT_TIME = DataUtils.ConvertValue<decimal?>(reader["TAKT_TIME"]);
            this._QUALITY_ASSURANCE = DataUtils.ConvertValue<decimal?>(reader["QUALITY_ASSURANCE"]);
            this._INSPECTION_MODE = DataUtils.ConvertValue<string>(reader["INSPECTION_MODE"]);
            this._INSPECTION_TYPE = DataUtils.ConvertValue<string>(reader["INSPECTION_TYPE"]);
            this._TRACE_BACK = DataUtils.ConvertValue<decimal?>(reader["TRACE_BACK"]);
            this._MATERIAL_WAY = DataUtils.ConvertValue<string>(reader["MATERIAL_WAY"]);
            this._PRODUCTION_BATCH = DataUtils.ConvertValue<decimal?>(reader["PRODUCTION_BATCH"]);
            this._DAILY_WORK_NUM = DataUtils.ConvertValue<decimal?>(reader["DAILY_WORK_NUM"]);
            this._MIN_PRODUCTION_NUM = DataUtils.ConvertValue<decimal?>(reader["MIN_PRODUCTION_NUM"]);
            this._PERSON_GID = DataUtils.ConvertValue<string>(reader["PERSON_GID"]);
            this._PRODUCTION_MULTIPLE = DataUtils.ConvertValue<decimal?>(reader["PRODUCTION_MULTIPLE"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["WORK_CENTER_GID"]);
            this._PIE_LOT = DataUtils.ConvertValue<decimal?>(reader["PIE_LOT"]);
            this._DAILY_WORK_MODE = DataUtils.ConvertValue<string>(reader["DAILY_WORK_MODE"]);
            this._DISPATCHING_MODE = DataUtils.ConvertValue<string>(reader["DISPATCHING_MODE"]);
            this._SEQUENTIAL_MODE = DataUtils.ConvertValue<string>(reader["SEQUENTIAL_MODE"]);
            this._MATERIEL_TYPE_GID = DataUtils.ConvertValue<string>(reader["MATERIEL_TYPE_GID"]);
            this._PACK_WAY = DataUtils.ConvertValue<string>(reader["PACK_WAY"]);
            this._PACK_NUMBER = DataUtils.ConvertValue<decimal?>(reader["PACK_NUMBER"]);
            this._FILE_PATH = DataUtils.ConvertValue<string>(reader["FILE_PATH"]);
            this._REMARK1 = DataUtils.ConvertValue<string>(reader["REMARK1"]);
            this._REMARK2 = DataUtils.ConvertValue<string>(reader["REMARK2"]);
            this._SPARE_PART = DataUtils.ConvertValue<decimal?>(reader["SPARE_PART"]);
            this._CONSUMPTIVE_PART = DataUtils.ConvertValue<decimal?>(reader["CONSUMPTIVE_PART"]);
            this._MAIN_BOM = DataUtils.ConvertValue<decimal?>(reader["MAIN_BOM"]);
            this._CREATE_BY = DataUtils.ConvertValue<string>(reader["CREATE_BY"]);
            this._CREATE_TIME = DataUtils.ConvertValue<DateTime?>(reader["CREATE_TIME"]);
            this._UPDATE_BY = DataUtils.ConvertValue<string>(reader["UPDATE_BY"]);
            this._UPDATE_TIME = DataUtils.ConvertValue<DateTime?>(reader["UPDATE_TIME"]);
            this._IS_DELETE = DataUtils.ConvertValue<decimal?>(reader["IS_DELETE"]);
            this._IS_ACTIVE = DataUtils.ConvertValue<decimal?>(reader["IS_ACTIVE"]);
            this._SM_BUSI_GROUP_GID = DataUtils.ConvertValue<string>(reader["SM_BUSI_GROUP_GID"]);
            this._SM_BUSI_UNIT_GID = DataUtils.ConvertValue<string>(reader["SM_BUSI_UNIT_GID"]);
            this._VERSION_NUM = DataUtils.ConvertValue<decimal?>(reader["VERSION_NUM"]);
            this._UDA1 = DataUtils.ConvertValue<string>(reader["UDA1"]);
            this._UDA2 = DataUtils.ConvertValue<string>(reader["UDA2"]);
            this._UDA3 = DataUtils.ConvertValue<string>(reader["UDA3"]);
            this._UDA4 = DataUtils.ConvertValue<string>(reader["UDA4"]);
            this._UDA5 = DataUtils.ConvertValue<string>(reader["UDA5"]);
            this._UDA6 = DataUtils.ConvertValue<string>(reader["UDA6"]);
            this._UDA7 = DataUtils.ConvertValue<string>(reader["UDA7"]);
            this._UDA8 = DataUtils.ConvertValue<string>(reader["UDA8"]);
            this._UDA9 = DataUtils.ConvertValue<string>(reader["UDA9"]);
            this._UDA10 = DataUtils.ConvertValue<string>(reader["UDA10"]);
            this._UDA11 = DataUtils.ConvertValue<string>(reader["UDA11"]);
            this._UDA12 = DataUtils.ConvertValue<string>(reader["UDA12"]);
            this._UDA13 = DataUtils.ConvertValue<string>(reader["UDA13"]);
            this._UDA14 = DataUtils.ConvertValue<string>(reader["UDA14"]);
            this._UDA15 = DataUtils.ConvertValue<string>(reader["UDA15"]);
            this._UDA16 = DataUtils.ConvertValue<string>(reader["UDA16"]);
            this._UDA17 = DataUtils.ConvertValue<string>(reader["UDA17"]);
            this._UDA18 = DataUtils.ConvertValue<string>(reader["UDA18"]);
            this._UDA19 = DataUtils.ConvertValue<string>(reader["UDA19"]);
            this._UDA20 = DataUtils.ConvertValue<string>(reader["UDA20"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._GID = DataUtils.ConvertValue<string>(row["GID"]);
            this._CODE = DataUtils.ConvertValue<string>(row["CODE"]);
            this._NAME = DataUtils.ConvertValue<string>(row["NAME"]);
            this._BM_MEASUREMENT_UNIT_GID = DataUtils.ConvertValue<string>(row["BM_MEASUREMENT_UNIT_GID"]);
            this._SPEC = DataUtils.ConvertValue<string>(row["SPEC"]);
            this._MODEL = DataUtils.ConvertValue<string>(row["MODEL"]);
            this._BM_WAREHOUSE_GID = DataUtils.ConvertValue<string>(row["BM_WAREHOUSE_GID"]);
            this._HOMEMADE_PIECE = DataUtils.ConvertValue<decimal?>(row["HOMEMADE_PIECE"]);
            this._OUTSOURCING = DataUtils.ConvertValue<decimal?>(row["OUTSOURCING"]);
            this._PURCHASE_PARTS = DataUtils.ConvertValue<decimal?>(row["PURCHASE_PARTS"]);
            this._ABBREVIATION = DataUtils.ConvertValue<string>(row["ABBREVIATION"]);
            this._ALIAS = DataUtils.ConvertValue<string>(row["ALIAS"]);
            this._VERSION_NUMBER = DataUtils.ConvertValue<string>(row["VERSION_NUMBER"]);
            this._FIGURE_NUMBER = DataUtils.ConvertValue<string>(row["FIGURE_NUMBER"]);
            this._EQUIPMENT = DataUtils.ConvertValue<decimal?>(row["EQUIPMENT"]);
            this._RESOURCES = DataUtils.ConvertValue<decimal?>(row["RESOURCES"]);
            this._BM_TECHNICS_PROCESS_GID = DataUtils.ConvertValue<string>(row["BM_TECHNICS_PROCESS_GID"]);
            this._SUBSTITUTE = DataUtils.ConvertValue<decimal?>(row["SUBSTITUTE"]);
            this._REPLACEMENT_PART = DataUtils.ConvertValue<decimal?>(row["REPLACEMENT_PART"]);
            this._BAR_CODE_MANAGEMENT = DataUtils.ConvertValue<decimal?>(row["BAR_CODE_MANAGEMENT"]);
            this._SERIAL_NUM_MANAGEMENT = DataUtils.ConvertValue<decimal?>(row["SERIAL_NUM_MANAGEMENT"]);
            this._PRODUCTION_PATH = DataUtils.ConvertValue<decimal?>(row["PRODUCTION_PATH"]);
            this._TAKT_TIME = DataUtils.ConvertValue<decimal?>(row["TAKT_TIME"]);
            this._QUALITY_ASSURANCE = DataUtils.ConvertValue<decimal?>(row["QUALITY_ASSURANCE"]);
            this._INSPECTION_MODE = DataUtils.ConvertValue<string>(row["INSPECTION_MODE"]);
            this._INSPECTION_TYPE = DataUtils.ConvertValue<string>(row["INSPECTION_TYPE"]);
            this._TRACE_BACK = DataUtils.ConvertValue<decimal?>(row["TRACE_BACK"]);
            this._MATERIAL_WAY = DataUtils.ConvertValue<string>(row["MATERIAL_WAY"]);
            this._PRODUCTION_BATCH = DataUtils.ConvertValue<decimal?>(row["PRODUCTION_BATCH"]);
            this._DAILY_WORK_NUM = DataUtils.ConvertValue<decimal?>(row["DAILY_WORK_NUM"]);
            this._MIN_PRODUCTION_NUM = DataUtils.ConvertValue<decimal?>(row["MIN_PRODUCTION_NUM"]);
            this._PERSON_GID = DataUtils.ConvertValue<string>(row["PERSON_GID"]);
            this._PRODUCTION_MULTIPLE = DataUtils.ConvertValue<decimal?>(row["PRODUCTION_MULTIPLE"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["WORK_CENTER_GID"]);
            this._PIE_LOT = DataUtils.ConvertValue<decimal?>(row["PIE_LOT"]);
            this._DAILY_WORK_MODE = DataUtils.ConvertValue<string>(row["DAILY_WORK_MODE"]);
            this._DISPATCHING_MODE = DataUtils.ConvertValue<string>(row["DISPATCHING_MODE"]);
            this._SEQUENTIAL_MODE = DataUtils.ConvertValue<string>(row["SEQUENTIAL_MODE"]);
            this._MATERIEL_TYPE_GID = DataUtils.ConvertValue<string>(row["MATERIEL_TYPE_GID"]);
            this._PACK_WAY = DataUtils.ConvertValue<string>(row["PACK_WAY"]);
            this._PACK_NUMBER = DataUtils.ConvertValue<decimal?>(row["PACK_NUMBER"]);
            this._FILE_PATH = DataUtils.ConvertValue<string>(row["FILE_PATH"]);
            this._REMARK1 = DataUtils.ConvertValue<string>(row["REMARK1"]);
            this._REMARK2 = DataUtils.ConvertValue<string>(row["REMARK2"]);
            this._SPARE_PART = DataUtils.ConvertValue<decimal?>(row["SPARE_PART"]);
            this._CONSUMPTIVE_PART = DataUtils.ConvertValue<decimal?>(row["CONSUMPTIVE_PART"]);
            this._MAIN_BOM = DataUtils.ConvertValue<decimal?>(row["MAIN_BOM"]);
            this._CREATE_BY = DataUtils.ConvertValue<string>(row["CREATE_BY"]);
            this._CREATE_TIME = DataUtils.ConvertValue<DateTime?>(row["CREATE_TIME"]);
            this._UPDATE_BY = DataUtils.ConvertValue<string>(row["UPDATE_BY"]);
            this._UPDATE_TIME = DataUtils.ConvertValue<DateTime?>(row["UPDATE_TIME"]);
            this._IS_DELETE = DataUtils.ConvertValue<decimal?>(row["IS_DELETE"]);
            this._IS_ACTIVE = DataUtils.ConvertValue<decimal?>(row["IS_ACTIVE"]);
            this._SM_BUSI_GROUP_GID = DataUtils.ConvertValue<string>(row["SM_BUSI_GROUP_GID"]);
            this._SM_BUSI_UNIT_GID = DataUtils.ConvertValue<string>(row["SM_BUSI_UNIT_GID"]);
            this._VERSION_NUM = DataUtils.ConvertValue<decimal?>(row["VERSION_NUM"]);
            this._UDA1 = DataUtils.ConvertValue<string>(row["UDA1"]);
            this._UDA2 = DataUtils.ConvertValue<string>(row["UDA2"]);
            this._UDA3 = DataUtils.ConvertValue<string>(row["UDA3"]);
            this._UDA4 = DataUtils.ConvertValue<string>(row["UDA4"]);
            this._UDA5 = DataUtils.ConvertValue<string>(row["UDA5"]);
            this._UDA6 = DataUtils.ConvertValue<string>(row["UDA6"]);
            this._UDA7 = DataUtils.ConvertValue<string>(row["UDA7"]);
            this._UDA8 = DataUtils.ConvertValue<string>(row["UDA8"]);
            this._UDA9 = DataUtils.ConvertValue<string>(row["UDA9"]);
            this._UDA10 = DataUtils.ConvertValue<string>(row["UDA10"]);
            this._UDA11 = DataUtils.ConvertValue<string>(row["UDA11"]);
            this._UDA12 = DataUtils.ConvertValue<string>(row["UDA12"]);
            this._UDA13 = DataUtils.ConvertValue<string>(row["UDA13"]);
            this._UDA14 = DataUtils.ConvertValue<string>(row["UDA14"]);
            this._UDA15 = DataUtils.ConvertValue<string>(row["UDA15"]);
            this._UDA16 = DataUtils.ConvertValue<string>(row["UDA16"]);
            this._UDA17 = DataUtils.ConvertValue<string>(row["UDA17"]);
            this._UDA18 = DataUtils.ConvertValue<string>(row["UDA18"]);
            this._UDA19 = DataUtils.ConvertValue<string>(row["UDA19"]);
            this._UDA20 = DataUtils.ConvertValue<string>(row["UDA20"]);
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
            public readonly static Field All = new Field("*", "BM_MATERIEL_INFO");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "BM_MATERIEL_INFO", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CODE = new Field("CODE", "BM_MATERIEL_INFO", "CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field NAME = new Field("NAME", "BM_MATERIEL_INFO", "NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_MEASUREMENT_UNIT_GID = new Field("BM_MEASUREMENT_UNIT_GID", "BM_MATERIEL_INFO", "BM_MEASUREMENT_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SPEC = new Field("SPEC", "BM_MATERIEL_INFO", "SPEC");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MODEL = new Field("MODEL", "BM_MATERIEL_INFO", "MODEL");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WAREHOUSE_GID = new Field("BM_WAREHOUSE_GID", "BM_MATERIEL_INFO", "BM_WAREHOUSE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field HOMEMADE_PIECE = new Field("HOMEMADE_PIECE", "BM_MATERIEL_INFO", "HOMEMADE_PIECE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OUTSOURCING = new Field("OUTSOURCING", "BM_MATERIEL_INFO", "OUTSOURCING");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PURCHASE_PARTS = new Field("PURCHASE_PARTS", "BM_MATERIEL_INFO", "PURCHASE_PARTS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ABBREVIATION = new Field("ABBREVIATION", "BM_MATERIEL_INFO", "ABBREVIATION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ALIAS = new Field("ALIAS", "BM_MATERIEL_INFO", "ALIAS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUMBER = new Field("VERSION_NUMBER", "BM_MATERIEL_INFO", "VERSION_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FIGURE_NUMBER = new Field("FIGURE_NUMBER", "BM_MATERIEL_INFO", "FIGURE_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EQUIPMENT = new Field("EQUIPMENT", "BM_MATERIEL_INFO", "EQUIPMENT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RESOURCES = new Field("RESOURCES", "BM_MATERIEL_INFO", "RESOURCES");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_TECHNICS_PROCESS_GID = new Field("BM_TECHNICS_PROCESS_GID", "BM_MATERIEL_INFO", "BM_TECHNICS_PROCESS_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SUBSTITUTE = new Field("SUBSTITUTE", "BM_MATERIEL_INFO", "SUBSTITUTE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REPLACEMENT_PART = new Field("REPLACEMENT_PART", "BM_MATERIEL_INFO", "REPLACEMENT_PART");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BAR_CODE_MANAGEMENT = new Field("BAR_CODE_MANAGEMENT", "BM_MATERIEL_INFO", "BAR_CODE_MANAGEMENT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SERIAL_NUM_MANAGEMENT = new Field("SERIAL_NUM_MANAGEMENT", "BM_MATERIEL_INFO", "SERIAL_NUM_MANAGEMENT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCTION_PATH = new Field("PRODUCTION_PATH", "BM_MATERIEL_INFO", "PRODUCTION_PATH");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TAKT_TIME = new Field("TAKT_TIME", "BM_MATERIEL_INFO", "TAKT_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field QUALITY_ASSURANCE = new Field("QUALITY_ASSURANCE", "BM_MATERIEL_INFO", "QUALITY_ASSURANCE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field INSPECTION_MODE = new Field("INSPECTION_MODE", "BM_MATERIEL_INFO", "INSPECTION_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field INSPECTION_TYPE = new Field("INSPECTION_TYPE", "BM_MATERIEL_INFO", "INSPECTION_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TRACE_BACK = new Field("TRACE_BACK", "BM_MATERIEL_INFO", "TRACE_BACK");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_WAY = new Field("MATERIAL_WAY", "BM_MATERIEL_INFO", "MATERIAL_WAY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCTION_BATCH = new Field("PRODUCTION_BATCH", "BM_MATERIEL_INFO", "PRODUCTION_BATCH");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DAILY_WORK_NUM = new Field("DAILY_WORK_NUM", "BM_MATERIEL_INFO", "DAILY_WORK_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MIN_PRODUCTION_NUM = new Field("MIN_PRODUCTION_NUM", "BM_MATERIEL_INFO", "MIN_PRODUCTION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PERSON_GID = new Field("PERSON_GID", "BM_MATERIEL_INFO", "PERSON_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCTION_MULTIPLE = new Field("PRODUCTION_MULTIPLE", "BM_MATERIEL_INFO", "PRODUCTION_MULTIPLE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_CENTER_GID = new Field("WORK_CENTER_GID", "BM_MATERIEL_INFO", "WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PIE_LOT = new Field("PIE_LOT", "BM_MATERIEL_INFO", "PIE_LOT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DAILY_WORK_MODE = new Field("DAILY_WORK_MODE", "BM_MATERIEL_INFO", "DAILY_WORK_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DISPATCHING_MODE = new Field("DISPATCHING_MODE", "BM_MATERIEL_INFO", "DISPATCHING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SEQUENTIAL_MODE = new Field("SEQUENTIAL_MODE", "BM_MATERIEL_INFO", "SEQUENTIAL_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIEL_TYPE_GID = new Field("MATERIEL_TYPE_GID", "BM_MATERIEL_INFO", "MATERIEL_TYPE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACK_WAY = new Field("PACK_WAY", "BM_MATERIEL_INFO", "PACK_WAY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACK_NUMBER = new Field("PACK_NUMBER", "BM_MATERIEL_INFO", "PACK_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FILE_PATH = new Field("FILE_PATH", "BM_MATERIEL_INFO", "FILE_PATH");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REMARK1 = new Field("REMARK1", "BM_MATERIEL_INFO", "REMARK1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REMARK2 = new Field("REMARK2", "BM_MATERIEL_INFO", "REMARK2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SPARE_PART = new Field("SPARE_PART", "BM_MATERIEL_INFO", "SPARE_PART");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CONSUMPTIVE_PART = new Field("CONSUMPTIVE_PART", "BM_MATERIEL_INFO", "CONSUMPTIVE_PART");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MAIN_BOM = new Field("MAIN_BOM", "BM_MATERIEL_INFO", "MAIN_BOM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "BM_MATERIEL_INFO", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BM_MATERIEL_INFO", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "BM_MATERIEL_INFO", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "BM_MATERIEL_INFO", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "BM_MATERIEL_INFO", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "BM_MATERIEL_INFO", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "BM_MATERIEL_INFO", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "BM_MATERIEL_INFO", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "BM_MATERIEL_INFO", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "BM_MATERIEL_INFO", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "BM_MATERIEL_INFO", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "BM_MATERIEL_INFO", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "BM_MATERIEL_INFO", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "BM_MATERIEL_INFO", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "BM_MATERIEL_INFO", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "BM_MATERIEL_INFO", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "BM_MATERIEL_INFO", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "BM_MATERIEL_INFO", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "BM_MATERIEL_INFO", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "BM_MATERIEL_INFO", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "BM_MATERIEL_INFO", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "BM_MATERIEL_INFO", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "BM_MATERIEL_INFO", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "BM_MATERIEL_INFO", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "BM_MATERIEL_INFO", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "BM_MATERIEL_INFO", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "BM_MATERIEL_INFO", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "BM_MATERIEL_INFO", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "BM_MATERIEL_INFO", "UDA20");
        }
        #endregion


    }

}
