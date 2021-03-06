﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO
{
    [Serializable]
    public  class QCKeyModuleDTO
    {
        private string _GID;
        private string _MD_PRODUCT_INFO_GID;
        private string _MD_PRODUCT_INFO_CODE;
        private string _MD_PRODUCT_INFO_NAME;
        private string _MD_MEASUREMENT_UNIT_GID;
        private string _MD_MEASUREMENT_UNIT_NAME;
        private string _MD_ROUTE_LINE_GID;
        private string _MD_ROUTE_LINE_CODE;
        private string _MD_ROUTE_LINE_NAME;
        private string _IME_WORK_ORDER_GID;
        private string _IME_WORK_ORDER_CODE;
        private string _MD_ROUTE_OPERATION_GID;
        private string _MD_ROUTE_OPERATION_CODE;
        private string _MD_ROUTE_OPERATION_NAME;

        private IList<QCKeyModuleInfoDTO> _QCkeyModelInfoLst;

        private string _BAR_CODE;
        private int? _AMOUNT;
        private int? _STATUS;
        private string _CREATE_BY;
        private object _CREATE_TIME;
        private string _UPDATE_BY;
        private object _UPDATE_TIME;
        private int? _IS_DELETE;
        private int? _IS_ACTIVE;
        private string _SM_BUSI_GROUP_GID;
        private string _SM_BUSI_UNIT_GID;
        private int? _VERSION_NUM;
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
        private string _MD_MATERIEL_GID;
        private int? _PLAN_ACQ_QTY;
        private int? _HAS_ACQ_QTY;

        public string GID { get => _GID; set => _GID = value; }
        public string MD_PRODUCT_INFO_GID { get => _MD_PRODUCT_INFO_GID; set => _MD_PRODUCT_INFO_GID = value; }
        public string MD_PRODUCT_INFO_CODE { get => _MD_PRODUCT_INFO_CODE; set => _MD_PRODUCT_INFO_CODE = value; }
        public string MD_PRODUCT_INFO_NAME { get => _MD_PRODUCT_INFO_NAME; set => _MD_PRODUCT_INFO_NAME = value; }
        public string MD_MEASUREMENT_UNIT_GID { get => _MD_MEASUREMENT_UNIT_GID; set => _MD_MEASUREMENT_UNIT_GID = value; }
        public string MD_MEASUREMENT_UNIT_NAME { get => _MD_MEASUREMENT_UNIT_NAME; set => _MD_MEASUREMENT_UNIT_NAME = value; }
        public string MD_ROUTE_LINE_GID { get => _MD_ROUTE_LINE_GID; set => _MD_ROUTE_LINE_GID = value; }
        public string MD_ROUTE_LINE_CODE { get => _MD_ROUTE_LINE_CODE; set => _MD_ROUTE_LINE_CODE = value; }
        public string MD_ROUTE_LINE_NAME { get => _MD_ROUTE_LINE_NAME; set => _MD_ROUTE_LINE_NAME = value; }
        public string IME_WORK_ORDER_GID { get => _IME_WORK_ORDER_GID; set => _IME_WORK_ORDER_GID = value; }
        public string IME_WORK_ORDER_CODE { get => _IME_WORK_ORDER_CODE; set => _IME_WORK_ORDER_CODE = value; }
        public string MD_ROUTE_OPERATION_GID { get => _MD_ROUTE_OPERATION_GID; set => _MD_ROUTE_OPERATION_GID = value; }
        public string MD_ROUTE_OPERATION_CODE { get => _MD_ROUTE_OPERATION_CODE; set => _MD_ROUTE_OPERATION_CODE = value; }
        public string MD_ROUTE_OPERATION_NAME { get => _MD_ROUTE_OPERATION_NAME; set => _MD_ROUTE_OPERATION_NAME = value; }
        public string BAR_CODE { get => _BAR_CODE; set => _BAR_CODE = value; }
        public int? AMOUNT { get => _AMOUNT; set => _AMOUNT = value; }
        public int? STATUS { get => _STATUS; set => _STATUS = value; }
        public string CREATE_BY { get => _CREATE_BY; set => _CREATE_BY = value; }
        public object CREATE_TIME { get => _CREATE_TIME; set => _CREATE_TIME = value; }
        public string UPDATE_BY { get => _UPDATE_BY; set => _UPDATE_BY = value; }
        public object UPDATE_TIME { get => _UPDATE_TIME; set => _UPDATE_TIME = value; }
        public int? IS_DELETE { get => _IS_DELETE; set => _IS_DELETE = value; }
        public int? IS_ACTIVE { get => _IS_ACTIVE; set => _IS_ACTIVE = value; }
        public string SM_BUSI_GROUP_GID { get => _SM_BUSI_GROUP_GID; set => _SM_BUSI_GROUP_GID = value; }
        public string SM_BUSI_UNIT_GID { get => _SM_BUSI_UNIT_GID; set => _SM_BUSI_UNIT_GID = value; }
        public int? VERSION_NUM { get => _VERSION_NUM; set => _VERSION_NUM = value; }
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
        public string MD_MATERIEL_GID { get => _MD_MATERIEL_GID; set => _MD_MATERIEL_GID = value; }
        public int? PLAN_ACQ_QTY { get => _PLAN_ACQ_QTY; set => _PLAN_ACQ_QTY = value; }
        public int? HAS_ACQ_QTY { get => _HAS_ACQ_QTY; set => _HAS_ACQ_QTY = value; }
        public IList<QCKeyModuleInfoDTO> QCkeyModelInfoLst { get => _QCkeyModelInfoLst; set => _QCkeyModelInfoLst = value; }
    }
}
