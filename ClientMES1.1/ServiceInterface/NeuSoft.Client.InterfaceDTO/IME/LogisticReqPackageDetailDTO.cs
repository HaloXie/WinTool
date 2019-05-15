using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO.IME
{
    public class LogisticReqPackageDetailDTO
    {
        private string _GID;
        private string _PACK_GROUP_GID;
        private string _REQ_PACKAGE_GID;
        private string _MATERIAL_REQ_GID;
        private string _MATERIAL_CODE;
        private string _MATERIAL_NAME;
        private string _MATERIAL_UNIT;
        private decimal? _PLAN_QTY;
        private decimal? _REQ_QTY;
        private string _MATERIAL_GID;
        private decimal? _PACK_QTY;
        private DateTime? _PLAN_TIME;
        private DateTime? _SPECIFIED_TIME;
        private string _FACTORY_WORK_STATION;
        private decimal? _PACK_NUM;
        private string _ROUTE_OPEARTION_GID;
        private string _IME_PLAN_ORDER_GID;
        private string _IME_WORK_ORDER_GID;
        private string _ORDER_SEQ;
        private string _PRODUCT_SEQ;
        private string _BM_PRODUCTINFO_GID;
        private string _GENERATE_WAVE;
        private string _REMARKS;
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
        private string _COMBINATION_STANDARD;

        public string GID { get => _GID; set => _GID = value; }
        public string PACK_GROUP_GID { get => _PACK_GROUP_GID; set => _PACK_GROUP_GID = value; }
        public string REQ_PACKAGE_GID { get => _REQ_PACKAGE_GID; set => _REQ_PACKAGE_GID = value; }
        public string MATERIAL_REQ_GID { get => _MATERIAL_REQ_GID; set => _MATERIAL_REQ_GID = value; }
        public string MATERIAL_CODE { get => _MATERIAL_CODE; set => _MATERIAL_CODE = value; }
        public string MATERIAL_NAME { get => _MATERIAL_NAME; set => _MATERIAL_NAME = value; }
        public string MATERIAL_UNIT { get => _MATERIAL_UNIT; set => _MATERIAL_UNIT = value; }
        public decimal? PLAN_QTY { get => _PLAN_QTY; set => _PLAN_QTY = value; }
        public decimal? REQ_QTY { get => _REQ_QTY; set => _REQ_QTY = value; }
        public string MATERIAL_GID { get => _MATERIAL_GID; set => _MATERIAL_GID = value; }
        public decimal? PACK_QTY { get => _PACK_QTY; set => _PACK_QTY = value; }
        public DateTime? PLAN_TIME { get => _PLAN_TIME; set => _PLAN_TIME = value; }
        public DateTime? SPECIFIED_TIME { get => _SPECIFIED_TIME; set => _SPECIFIED_TIME = value; }
        public string FACTORY_WORK_STATION { get => _FACTORY_WORK_STATION; set => _FACTORY_WORK_STATION = value; }
        public decimal? PACK_NUM { get => _PACK_NUM; set => _PACK_NUM = value; }
        public string ROUTE_OPEARTION_GID { get => _ROUTE_OPEARTION_GID; set => _ROUTE_OPEARTION_GID = value; }
        public string IME_PLAN_ORDER_GID { get => _IME_PLAN_ORDER_GID; set => _IME_PLAN_ORDER_GID = value; }
        public string IME_WORK_ORDER_GID { get => _IME_WORK_ORDER_GID; set => _IME_WORK_ORDER_GID = value; }
        public string ORDER_SEQ { get => _ORDER_SEQ; set => _ORDER_SEQ = value; }
        public string PRODUCT_SEQ { get => _PRODUCT_SEQ; set => _PRODUCT_SEQ = value; }
        public string BM_PRODUCTINFO_GID { get => _BM_PRODUCTINFO_GID; set => _BM_PRODUCTINFO_GID = value; }
        public string GENERATE_WAVE { get => _GENERATE_WAVE; set => _GENERATE_WAVE = value; }
        public string REMARKS { get => _REMARKS; set => _REMARKS = value; }
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
        public string COMBINATION_STANDARD { get => _COMBINATION_STANDARD; set => _COMBINATION_STANDARD = value; }
    }
}
