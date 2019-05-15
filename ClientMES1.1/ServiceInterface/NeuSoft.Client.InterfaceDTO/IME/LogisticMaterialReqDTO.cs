using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO.IME
{
  public   class LogisticMaterialReqDTO
    {
        private string _GID;
        private decimal? _PACK_NUMBER;
        private string _PACK_GROUP_GID;
        private string _STANDARD_UNIT;
        private string _CODE;
        private string _MATERIAL_GID;
        private string _MEASUREMENT_UNIT_GID;
        private decimal? _PLAN_QTY;
        private decimal? _REQ_QTY;
        private DateTime? _PLAN_TIME;
        private DateTime? _SPECIFIED_TIME;
        private string _WAREHOUSE_GID;
        private string _FACTORY_LINE_GID;
        private string _FACTORY_STATION_GID;
        private decimal? _STANDARD_QTY;
        private string _STATUS;
        private string _ROUTE_OPEARTION_GID;
        private string _ROUTE_OPERATION_CODE;
        private string _ORIGINAL_CODE;
        private string _GENERATE_WAVE;
        private string _REMARKS;
        private string _COMBINATION_STANDARD;
        private string _COMBINATION_CONTAINER;
        private decimal? _BOM_NUM;
        private string _PACK_GROUP_CODE;
        private string _PACK_GROUP_NAME;
        private decimal? _DISTRIBUTION_NUMBER;
        private decimal? _RECEIPT_NUMBER;
        private decimal? _PACK_QTY;
        private decimal? _WORK_ORDER_QTY;
        private string _IME_PLAN_ORDER_GID;
        private string _IME_PLAN_ORDER_CODE;
        private string _IME_WORK_ORDER_GID;
        private string _IME_WORK_ORDER_CODE;
        private string _ORDER_SEQ;
        private string _PRODUCT_SEQ;
        private string _BM_PRODUCTINFO_GID;
        private string _SUPPLY_OWNER;
        private string _OREDER_RULE_GID;
        private string _ROUTE_OPERATION_NAME;
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
        public decimal? PACK_NUMBER { get => _PACK_NUMBER; set => _PACK_NUMBER = value; }
        public string PACK_GROUP_GID { get => _PACK_GROUP_GID; set => _PACK_GROUP_GID = value; }
        public string STANDARD_UNIT { get => _STANDARD_UNIT; set => _STANDARD_UNIT = value; }
        public string CODE { get => _CODE; set => _CODE = value; }
        public string MATERIAL_GID { get => _MATERIAL_GID; set => _MATERIAL_GID = value; }
        public string MEASUREMENT_UNIT_GID { get => _MEASUREMENT_UNIT_GID; set => _MEASUREMENT_UNIT_GID = value; }
        public decimal? PLAN_QTY { get => _PLAN_QTY; set => _PLAN_QTY = value; }
        public decimal? REQ_QTY { get => _REQ_QTY; set => _REQ_QTY = value; }
        public DateTime? PLAN_TIME { get => _PLAN_TIME; set => _PLAN_TIME = value; }
        public DateTime? SPECIFIED_TIME { get => _SPECIFIED_TIME; set => _SPECIFIED_TIME = value; }
        public string WAREHOUSE_GID { get => _WAREHOUSE_GID; set => _WAREHOUSE_GID = value; }
        public string FACTORY_LINE_GID { get => _FACTORY_LINE_GID; set => _FACTORY_LINE_GID = value; }
        public string FACTORY_STATION_GID { get => _FACTORY_STATION_GID; set => _FACTORY_STATION_GID = value; }
        public decimal? STANDARD_QTY { get => _STANDARD_QTY; set => _STANDARD_QTY = value; }
        public string STATUS { get => _STATUS; set => _STATUS = value; }
        public string ROUTE_OPEARTION_GID { get => _ROUTE_OPEARTION_GID; set => _ROUTE_OPEARTION_GID = value; }
        public string ROUTE_OPERATION_CODE { get => _ROUTE_OPERATION_CODE; set => _ROUTE_OPERATION_CODE = value; }
        public string ORIGINAL_CODE { get => _ORIGINAL_CODE; set => _ORIGINAL_CODE = value; }
        public string GENERATE_WAVE { get => _GENERATE_WAVE; set => _GENERATE_WAVE = value; }
        public string REMARKS { get => _REMARKS; set => _REMARKS = value; }
        public string COMBINATION_STANDARD { get => _COMBINATION_STANDARD; set => _COMBINATION_STANDARD = value; }
        public string COMBINATION_CONTAINER { get => _COMBINATION_CONTAINER; set => _COMBINATION_CONTAINER = value; }
        public decimal? BOM_NUM { get => _BOM_NUM; set => _BOM_NUM = value; }
        public string PACK_GROUP_CODE { get => _PACK_GROUP_CODE; set => _PACK_GROUP_CODE = value; }
        public string PACK_GROUP_NAME { get => _PACK_GROUP_NAME; set => _PACK_GROUP_NAME = value; }
        public decimal? DISTRIBUTION_NUMBER { get => _DISTRIBUTION_NUMBER; set => _DISTRIBUTION_NUMBER = value; }
        public decimal? RECEIPT_NUMBER { get => _RECEIPT_NUMBER; set => _RECEIPT_NUMBER = value; }
        public decimal? PACK_QTY { get => _PACK_QTY; set => _PACK_QTY = value; }
        public decimal? WORK_ORDER_QTY { get => _WORK_ORDER_QTY; set => _WORK_ORDER_QTY = value; }
        public string IME_PLAN_ORDER_GID { get => _IME_PLAN_ORDER_GID; set => _IME_PLAN_ORDER_GID = value; }
        public string IME_PLAN_ORDER_CODE { get => _IME_PLAN_ORDER_CODE; set => _IME_PLAN_ORDER_CODE = value; }
        public string IME_WORK_ORDER_GID { get => _IME_WORK_ORDER_GID; set => _IME_WORK_ORDER_GID = value; }
        public string IME_WORK_ORDER_CODE { get => _IME_WORK_ORDER_CODE; set => _IME_WORK_ORDER_CODE = value; }
        public string ORDER_SEQ { get => _ORDER_SEQ; set => _ORDER_SEQ = value; }
        public string PRODUCT_SEQ { get => _PRODUCT_SEQ; set => _PRODUCT_SEQ = value; }
        public string BM_PRODUCTINFO_GID { get => _BM_PRODUCTINFO_GID; set => _BM_PRODUCTINFO_GID = value; }
        public string SUPPLY_OWNER { get => _SUPPLY_OWNER; set => _SUPPLY_OWNER = value; }
        public string OREDER_RULE_GID { get => _OREDER_RULE_GID; set => _OREDER_RULE_GID = value; }
        public string ROUTE_OPERATION_NAME { get => _ROUTE_OPERATION_NAME; set => _ROUTE_OPERATION_NAME = value; }
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
