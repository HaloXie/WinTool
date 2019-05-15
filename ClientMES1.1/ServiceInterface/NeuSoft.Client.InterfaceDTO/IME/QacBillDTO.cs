using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO
{
    [Serializable]
    public class QacBillDTO
    {
        private string _GID;
        private string _CODE;
        private string _MD_PRODUCT_INFO_GID;
        private decimal? _QC_HAS_DISPATCHED_QTY;
        private decimal? _QC_DISPATCHED_QTY;
        private decimal? _QC_HAS_INSPECTION_QTY;
        private string _QC_DISPATCHED_PERSON_GID;
        private string _SURVEYOR;
        private string _MD_FACTORY_WORK_STATION_GID;
        private string _IME_QC_QUALITY_WAY_GID;
        private DateTime? _QC_LAST_DISPATCHED_TIME;
        private DateTime? _CHECK_BEGIN_TIME;
        private DateTime? _CHECK_END_TIME;
        private decimal? _QC_INSPECTION_STATUS;
        private string _REMARKS;
        private string _IME_QC_QAC_GID;
        private string _IME_QC_QAC_CODE;
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
        private string _MD_MATERIAL_GID;

        public string GID { get => _GID; set => _GID = value; }
        public string CODE { get => _CODE; set => _CODE = value; }
        public string MD_PRODUCT_INFO_GID { get => _MD_PRODUCT_INFO_GID; set => _MD_PRODUCT_INFO_GID = value; }
        public decimal? QC_HAS_DISPATCHED_QTY { get => _QC_HAS_DISPATCHED_QTY; set => _QC_HAS_DISPATCHED_QTY = value; }
        public decimal? QC_DISPATCHED_QTY { get => _QC_DISPATCHED_QTY; set => _QC_DISPATCHED_QTY = value; }
        public decimal? QC_HAS_INSPECTION_QTY { get => _QC_HAS_INSPECTION_QTY; set => _QC_HAS_INSPECTION_QTY = value; }
        public string QC_DISPATCHED_PERSON_GID { get => _QC_DISPATCHED_PERSON_GID; set => _QC_DISPATCHED_PERSON_GID = value; }
        public string SURVEYOR { get => _SURVEYOR; set => _SURVEYOR = value; }
        public string MD_FACTORY_WORK_STATION_GID { get => _MD_FACTORY_WORK_STATION_GID; set => _MD_FACTORY_WORK_STATION_GID = value; }
        public string IME_QC_QUALITY_WAY_GID { get => _IME_QC_QUALITY_WAY_GID; set => _IME_QC_QUALITY_WAY_GID = value; }
        public DateTime? QC_LAST_DISPATCHED_TIME { get => _QC_LAST_DISPATCHED_TIME; set => _QC_LAST_DISPATCHED_TIME = value; }
        public DateTime? CHECK_BEGIN_TIME { get => _CHECK_BEGIN_TIME; set => _CHECK_BEGIN_TIME = value; }
        public DateTime? CHECK_END_TIME { get => _CHECK_END_TIME; set => _CHECK_END_TIME = value; }
        public decimal? QC_INSPECTION_STATUS { get => _QC_INSPECTION_STATUS; set => _QC_INSPECTION_STATUS = value; }
        public string REMARKS { get => _REMARKS; set => _REMARKS = value; }
        public string IME_QC_QAC_GID { get => _IME_QC_QAC_GID; set => _IME_QC_QAC_GID = value; }
        public string IME_QC_QAC_CODE { get => _IME_QC_QAC_CODE; set => _IME_QC_QAC_CODE = value; }
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
        public string MD_MATERIAL_GID { get => _MD_MATERIAL_GID; set => _MD_MATERIAL_GID = value; }
    }
}
