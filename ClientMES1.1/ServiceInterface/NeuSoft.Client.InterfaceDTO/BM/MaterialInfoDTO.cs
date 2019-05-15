using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO
{
    [Serializable]
    public class MaterialInfoDTO
    {
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

        public string GID { get => _GID; set => _GID = value; }
        public string CODE { get => _CODE; set => _CODE = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string BM_MEASUREMENT_UNIT_GID { get => _BM_MEASUREMENT_UNIT_GID; set => _BM_MEASUREMENT_UNIT_GID = value; }
        public string SPEC { get => _SPEC; set => _SPEC = value; }
        public string MODEL { get => _MODEL; set => _MODEL = value; }
        public string BM_WAREHOUSE_GID { get => _BM_WAREHOUSE_GID; set => _BM_WAREHOUSE_GID = value; }
        public decimal? HOMEMADE_PIECE { get => _HOMEMADE_PIECE; set => _HOMEMADE_PIECE = value; }
        public decimal? OUTSOURCING { get => _OUTSOURCING; set => _OUTSOURCING = value; }
        public decimal? PURCHASE_PARTS { get => _PURCHASE_PARTS; set => _PURCHASE_PARTS = value; }
        public string ABBREVIATION { get => _ABBREVIATION; set => _ABBREVIATION = value; }
        public string ALIAS { get => _ALIAS; set => _ALIAS = value; }
        public string VERSION_NUMBER { get => _VERSION_NUMBER; set => _VERSION_NUMBER = value; }
        public string FIGURE_NUMBER { get => _FIGURE_NUMBER; set => _FIGURE_NUMBER = value; }
        public decimal? EQUIPMENT { get => _EQUIPMENT; set => _EQUIPMENT = value; }
        public decimal? RESOURCES { get => _RESOURCES; set => _RESOURCES = value; }
        public string BM_TECHNICS_PROCESS_GID { get => _BM_TECHNICS_PROCESS_GID; set => _BM_TECHNICS_PROCESS_GID = value; }
        public decimal? SUBSTITUTE { get => _SUBSTITUTE; set => _SUBSTITUTE = value; }
        public decimal? REPLACEMENT_PART { get => _REPLACEMENT_PART; set => _REPLACEMENT_PART = value; }
        public decimal? BAR_CODE_MANAGEMENT { get => _BAR_CODE_MANAGEMENT; set => _BAR_CODE_MANAGEMENT = value; }
        public decimal? SERIAL_NUM_MANAGEMENT { get => _SERIAL_NUM_MANAGEMENT; set => _SERIAL_NUM_MANAGEMENT = value; }
        public decimal? PRODUCTION_PATH { get => _PRODUCTION_PATH; set => _PRODUCTION_PATH = value; }
        public decimal? TAKT_TIME { get => _TAKT_TIME; set => _TAKT_TIME = value; }
        public decimal? QUALITY_ASSURANCE { get => _QUALITY_ASSURANCE; set => _QUALITY_ASSURANCE = value; }
        public string INSPECTION_MODE { get => _INSPECTION_MODE; set => _INSPECTION_MODE = value; }
        public string INSPECTION_TYPE { get => _INSPECTION_TYPE; set => _INSPECTION_TYPE = value; }
        public decimal? TRACE_BACK { get => _TRACE_BACK; set => _TRACE_BACK = value; }
        public string MATERIAL_WAY { get => _MATERIAL_WAY; set => _MATERIAL_WAY = value; }
        public decimal? PRODUCTION_BATCH { get => _PRODUCTION_BATCH; set => _PRODUCTION_BATCH = value; }
        public decimal? DAILY_WORK_NUM { get => _DAILY_WORK_NUM; set => _DAILY_WORK_NUM = value; }
        public decimal? MIN_PRODUCTION_NUM { get => _MIN_PRODUCTION_NUM; set => _MIN_PRODUCTION_NUM = value; }
        public string PERSON_GID { get => _PERSON_GID; set => _PERSON_GID = value; }
        public decimal? PRODUCTION_MULTIPLE { get => _PRODUCTION_MULTIPLE; set => _PRODUCTION_MULTIPLE = value; }
        public string WORK_CENTER_GID { get => _WORK_CENTER_GID; set => _WORK_CENTER_GID = value; }
        public decimal? PIE_LOT { get => _PIE_LOT; set => _PIE_LOT = value; }
        public string DAILY_WORK_MODE { get => _DAILY_WORK_MODE; set => _DAILY_WORK_MODE = value; }
        public string DISPATCHING_MODE { get => _DISPATCHING_MODE; set => _DISPATCHING_MODE = value; }
        public string SEQUENTIAL_MODE { get => _SEQUENTIAL_MODE; set => _SEQUENTIAL_MODE = value; }
        public string MATERIEL_TYPE_GID { get => _MATERIEL_TYPE_GID; set => _MATERIEL_TYPE_GID = value; }
        public string PACK_WAY { get => _PACK_WAY; set => _PACK_WAY = value; }
        public decimal? PACK_NUMBER { get => _PACK_NUMBER; set => _PACK_NUMBER = value; }
        public string FILE_PATH { get => _FILE_PATH; set => _FILE_PATH = value; }
        public string REMARK1 { get => _REMARK1; set => _REMARK1 = value; }
        public string REMARK2 { get => _REMARK2; set => _REMARK2 = value; }
        public decimal? SPARE_PART { get => _SPARE_PART; set => _SPARE_PART = value; }
        public decimal? CONSUMPTIVE_PART { get => _CONSUMPTIVE_PART; set => _CONSUMPTIVE_PART = value; }
        public decimal? MAIN_BOM { get => _MAIN_BOM; set => _MAIN_BOM = value; }
        public string CREATE_BY { get => _CREATE_BY; set => _CREATE_BY = value; }
        public DateTime? CREATE_TIME { get => _CREATE_TIME; set => _CREATE_TIME = value; }
        public string UPDATE_BY { get => _UPDATE_BY; set => _UPDATE_BY = value; }
        public DateTime? UPDATE_TIME { get => _UPDATE_TIME; set => _UPDATE_TIME = value; }
        public decimal? IS_DELETE { get => _IS_DELETE; set => _IS_DELETE = value; }
        public decimal? IS_ACTIVE { get => _IS_ACTIVE; set => _IS_ACTIVE = value; }
        public string SM_BUSI_GROUP_GID { get => _SM_BUSI_GROUP_GID; set => _SM_BUSI_GROUP_GID = value; }
        public string SM_BUSI_UNIT_GID { get => _SM_BUSI_UNIT_GID; set => _SM_BUSI_UNIT_GID = value; }
        public decimal? VERSION_NUM { get => _VERSION_NUM; set => _VERSION_NUM = value; }
        public string UDA1 { get => _UDA1; set => _UDA1 = value; }
        public string UDA2 { get => _UDA2; set => _UDA2 = value; }
        public string UDA3 { get => _UDA3; set => _UDA3 = value; }
        public string UDA4 { get => _UDA4; set => _UDA4 = value; }
        public string UDA5 { get => _UDA5; set => _UDA5 = value; }
        public string UDA6 { get => _UDA6; set => _UDA6 = value; }
        public string UDA7 { get => _UDA7; set => _UDA7 = value; }
        public string UDA8 { get => _UDA8; set => _UDA8 = value; }
        public string UDA9 { get => _UDA9; set => _UDA9 = value; }
        public string UDA10 { get => _UDA10; set => _UDA10 = value; }
        public string UDA11 { get => _UDA11; set => _UDA11 = value; }
        public string UDA12 { get => _UDA12; set => _UDA12 = value; }
        public string UDA13 { get => _UDA13; set => _UDA13 = value; }
        public string UDA14 { get => _UDA14; set => _UDA14 = value; }
        public string UDA15 { get => _UDA15; set => _UDA15 = value; }
        public string UDA16 { get => _UDA16; set => _UDA16 = value; }
        public string UDA17 { get => _UDA17; set => _UDA17 = value; }
        public string UDA18 { get => _UDA18; set => _UDA18 = value; }
        public string UDA19 { get => _UDA19; set => _UDA19 = value; }
        public string UDA20 { get => _UDA20; set => _UDA20 = value; }
    }
}
