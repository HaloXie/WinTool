using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO.IME
{
    [Serializable]
    public class WorkOrderBomDTO
    {
        private string _GID;
        private string _WORK_ORDER_GID;
        private string _MATERIAL_GID;
        private decimal? _MATERIAL_NUMBER;
        private decimal? _PRODUCT_NUMBER;
        private decimal? _PLAN_QTY;
        private decimal? _ORDER_QTY;
        private string _PICKING_TYPE;
        private string _WAREHOUSE_GID;
        private string _ROUTE_OPERATION_GID;
        private string _ROUTE_OPERATION_CODE;
        private string _ROUTE_OPERATION_NAME;
        private string _FACTORY_STATION_GID;
        private string _ROUTE_LINE_GID;
        private decimal? _REVIEW_GID;
        private decimal? _DEDUCTION_QTY;
        private decimal? _DELIVERED_QTY;
        private string _ROW_NUMBER;
        private string _PRODUCT_GID;
        private string _BOM_VERSION;
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
        public string WORK_ORDER_GID { get => _WORK_ORDER_GID; set => _WORK_ORDER_GID = value; }
        public string MATERIAL_GID { get => _MATERIAL_GID; set => _MATERIAL_GID = value; }
        public decimal? MATERIAL_NUMBER { get => _MATERIAL_NUMBER; set => _MATERIAL_NUMBER = value; }
        public decimal? PRODUCT_NUMBER { get => _PRODUCT_NUMBER; set => _PRODUCT_NUMBER = value; }
        public decimal? PLAN_QTY { get => _PLAN_QTY; set => _PLAN_QTY = value; }
        public decimal? ORDER_QTY { get => _ORDER_QTY; set => _ORDER_QTY = value; }
        public string PICKING_TYPE { get => _PICKING_TYPE; set => _PICKING_TYPE = value; }
        public string WAREHOUSE_GID { get => _WAREHOUSE_GID; set => _WAREHOUSE_GID = value; }
        public string ROUTE_OPERATION_GID { get => _ROUTE_OPERATION_GID; set => _ROUTE_OPERATION_GID = value; }
        public string ROUTE_OPERATION_CODE { get => _ROUTE_OPERATION_CODE; set => _ROUTE_OPERATION_CODE = value; }
        public string ROUTE_OPERATION_NAME { get => _ROUTE_OPERATION_NAME; set => _ROUTE_OPERATION_NAME = value; }
        public string FACTORY_STATION_GID { get => _FACTORY_STATION_GID; set => _FACTORY_STATION_GID = value; }
        public string ROUTE_LINE_GID { get => _ROUTE_LINE_GID; set => _ROUTE_LINE_GID = value; }
        public decimal? REVIEW_GID { get => _REVIEW_GID; set => _REVIEW_GID = value; }
        public decimal? DEDUCTION_QTY { get => _DEDUCTION_QTY; set => _DEDUCTION_QTY = value; }
        public decimal? DELIVERED_QTY { get => _DELIVERED_QTY; set => _DELIVERED_QTY = value; }
        public string ROW_NUMBER { get => _ROW_NUMBER; set => _ROW_NUMBER = value; }
        public string PRODUCT_GID { get => _PRODUCT_GID; set => _PRODUCT_GID = value; }
        public string BOM_VERSION { get => _BOM_VERSION; set => _BOM_VERSION = value; }
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
