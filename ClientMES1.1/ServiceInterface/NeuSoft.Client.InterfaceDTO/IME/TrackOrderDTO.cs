using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO.IME
{
    [Serializable]
    public class TrackOrderDTO
    {
        private string _GID;
        private string _CODE;
        private string _RESOURCE_ORDER_GID;
        private string _RESOURCE_ORDER_TYPE;
        private string _ORDER_TYPE;
        private string _WORK_CENTER_GID;
        private string _FACTORY_LINE_GID;
        private string _WORK_UNIT_GID;
        private string _MATERIAL_GID;
        private string _MATERIAL_VERSION;
        private string _PRODUCT_GID;
        private string _BOM_VERSION;
        private decimal? _WORK_ORDER_QTY;
        private decimal? _WORK_ORDER_FINISH_QTY;
        private DateTime? _PLAN_BEGIN_TIME;
        private DateTime? _PLAN_END_TIME;
        private DateTime? _CALCULATE_BEGIN_TIME;
        private DateTime? _CALCULATE_END_TIME;
        private DateTime? _ACTUAL_BEGIN_TIME;
        private DateTime? _ACTUAL_END_TIME;
        private string _ROUTE_LINE_GID;
        private string _ROUTE_LINE_VERSION;
        private string _ORDER_STATUS;
        private decimal? _BATCH_NUM;
        private string _TRACK_CATEGORY;
        private string _RECEIVE_PERSONNEL_GID;
        private string _START_PERSONNEL_GID;
        private string _FINISH_PERSONNEL_GID;
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
        public string RESOURCE_ORDER_GID { get => _RESOURCE_ORDER_GID; set => _RESOURCE_ORDER_GID = value; }
        public string RESOURCE_ORDER_TYPE { get => _RESOURCE_ORDER_TYPE; set => _RESOURCE_ORDER_TYPE = value; }
        public string ORDER_TYPE { get => _ORDER_TYPE; set => _ORDER_TYPE = value; }
        public string WORK_CENTER_GID { get => _WORK_CENTER_GID; set => _WORK_CENTER_GID = value; }
        public string FACTORY_LINE_GID { get => _FACTORY_LINE_GID; set => _FACTORY_LINE_GID = value; }
        public string WORK_UNIT_GID { get => _WORK_UNIT_GID; set => _WORK_UNIT_GID = value; }
        public string MATERIAL_GID { get => _MATERIAL_GID; set => _MATERIAL_GID = value; }
        public string MATERIAL_VERSION { get => _MATERIAL_VERSION; set => _MATERIAL_VERSION = value; }
        public string PRODUCT_GID { get => _PRODUCT_GID; set => _PRODUCT_GID = value; }
        public string BOM_VERSION { get => _BOM_VERSION; set => _BOM_VERSION = value; }
        public decimal? WORK_ORDER_QTY { get => _WORK_ORDER_QTY; set => _WORK_ORDER_QTY = value; }
        public decimal? WORK_ORDER_FINISH_QTY { get => _WORK_ORDER_FINISH_QTY; set => _WORK_ORDER_FINISH_QTY = value; }
        public DateTime? PLAN_BEGIN_TIME { get => _PLAN_BEGIN_TIME; set => _PLAN_BEGIN_TIME = value; }
        public DateTime? PLAN_END_TIME { get => _PLAN_END_TIME; set => _PLAN_END_TIME = value; }
        public DateTime? CALCULATE_BEGIN_TIME { get => _CALCULATE_BEGIN_TIME; set => _CALCULATE_BEGIN_TIME = value; }
        public DateTime? CALCULATE_END_TIME { get => _CALCULATE_END_TIME; set => _CALCULATE_END_TIME = value; }
        public DateTime? ACTUAL_BEGIN_TIME { get => _ACTUAL_BEGIN_TIME; set => _ACTUAL_BEGIN_TIME = value; }
        public DateTime? ACTUAL_END_TIME { get => _ACTUAL_END_TIME; set => _ACTUAL_END_TIME = value; }
        public string ROUTE_LINE_GID { get => _ROUTE_LINE_GID; set => _ROUTE_LINE_GID = value; }
        public string ROUTE_LINE_VERSION { get => _ROUTE_LINE_VERSION; set => _ROUTE_LINE_VERSION = value; }
        public string ORDER_STATUS { get => _ORDER_STATUS; set => _ORDER_STATUS = value; }
        public decimal? BATCH_NUM { get => _BATCH_NUM; set => _BATCH_NUM = value; }
        public string TRACK_CATEGORY { get => _TRACK_CATEGORY; set => _TRACK_CATEGORY = value; }
        public string RECEIVE_PERSONNEL_GID { get => _RECEIVE_PERSONNEL_GID; set => _RECEIVE_PERSONNEL_GID = value; }
        public string START_PERSONNEL_GID { get => _START_PERSONNEL_GID; set => _START_PERSONNEL_GID = value; }
        public string FINISH_PERSONNEL_GID { get => _FINISH_PERSONNEL_GID; set => _FINISH_PERSONNEL_GID = value; }
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
