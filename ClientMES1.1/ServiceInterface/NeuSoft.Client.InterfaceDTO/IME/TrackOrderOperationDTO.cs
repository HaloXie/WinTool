using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.Client.InterfaceDTO.IME
{
    public class TrackOrderOperationDTO
    {
        private string _GID;
        private decimal? _TRACK_QTY;
        private decimal? _TOTAL_TRACK_QTY;
        private decimal? _CUR_TRACK_QTY;
        private decimal? _CUR_REPORT_QTY;
        private decimal? _TOTAL_REPORT_QTY;
        private decimal? _CUR_QUALIFIED_QTY;
        private decimal? _TOTAL_QUALIFIED_QTY;
        private decimal? _CUR_DEFECTIVE_QTY;
        private decimal? _TOTAL_DEFECTIVE_QTY;
        private decimal? _CUR_WASTE_QTY;
        private decimal? _TOTAL_WASTE_QTY;
        private decimal? _CUR_REPAIR_QTY;
        private decimal? _TOTAL_REPAIR_QTY;
        private string _WORK_ORDER_GID;
        private string _TRACK_ORDER_GID;
        private string _CODE;
        private string _NAME;
        private string _TYPE;
        private string _CATEGORY;
        private string _FACTORY_STATION_GID;
        private string _WORK_CENTER_GID;
        private string _FACTORY_LINE_GID;
        private string _WORK_UNIT_GID;
        private string _PROCESSING_MODE;
        private decimal? _PROCESS_TEST;
        private string _WORKSHEET_GENARATION_MODE;
        private string _BUSINESS_MODE;
        private decimal? _RHYTHM;
        private string _RHYTHM_TYPE;
        private decimal? _OFFLINE_QTY;
        private decimal? _ONLINE_QTY;
        private string _STATUS;
        private string _OPERATION_PERSON;
        private string _EXECUTION_PERSON;
        private decimal? _OPERATION_STEP_FINISH_FLAG;
        private decimal? _RHYTHM_COUNT;
        private string _WORK_ORDER_OPERATION_GID;
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
        private string _ROW_NUMBER;
        private decimal? _RUNNING_TIME;
        private string _RUNNING_TIME_TYPE;
        private decimal? _PREPARATION_TIME;
        private string _PREPARATION_TIME_TYPE;
        private decimal? _RUNNING_TIME_COUNT;
        private decimal? _PREPARATION_TIME_COUNT;
        private decimal? _MAT_END_POINT;
        private string _DEF_OPERATION_GID;

        public string GID { get => _GID; set => _GID = value; }
        public decimal? TRACK_QTY { get => _TRACK_QTY; set => _TRACK_QTY = value; }
        public decimal? TOTAL_TRACK_QTY { get => _TOTAL_TRACK_QTY; set => _TOTAL_TRACK_QTY = value; }
        public decimal? CUR_TRACK_QTY { get => _CUR_TRACK_QTY; set => _CUR_TRACK_QTY = value; }
        public decimal? CUR_REPORT_QTY { get => _CUR_REPORT_QTY; set => _CUR_REPORT_QTY = value; }
        public decimal? TOTAL_REPORT_QTY { get => _TOTAL_REPORT_QTY; set => _TOTAL_REPORT_QTY = value; }
        public decimal? CUR_QUALIFIED_QTY { get => _CUR_QUALIFIED_QTY; set => _CUR_QUALIFIED_QTY = value; }
        public decimal? TOTAL_QUALIFIED_QTY { get => _TOTAL_QUALIFIED_QTY; set => _TOTAL_QUALIFIED_QTY = value; }
        public decimal? CUR_DEFECTIVE_QTY { get => _CUR_DEFECTIVE_QTY; set => _CUR_DEFECTIVE_QTY = value; }
        public decimal? TOTAL_DEFECTIVE_QTY { get => _TOTAL_DEFECTIVE_QTY; set => _TOTAL_DEFECTIVE_QTY = value; }
        public decimal? CUR_WASTE_QTY { get => _CUR_WASTE_QTY; set => _CUR_WASTE_QTY = value; }
        public decimal? TOTAL_WASTE_QTY { get => _TOTAL_WASTE_QTY; set => _TOTAL_WASTE_QTY = value; }
        public decimal? CUR_REPAIR_QTY { get => _CUR_REPAIR_QTY; set => _CUR_REPAIR_QTY = value; }
        public decimal? TOTAL_REPAIR_QTY { get => _TOTAL_REPAIR_QTY; set => _TOTAL_REPAIR_QTY = value; }
        public string WORK_ORDER_GID { get => _WORK_ORDER_GID; set => _WORK_ORDER_GID = value; }
        public string TRACK_ORDER_GID { get => _TRACK_ORDER_GID; set => _TRACK_ORDER_GID = value; }
        public string CODE { get => _CODE; set => _CODE = value; }
        public string NAME { get => _NAME; set => _NAME = value; }
        public string TYPE { get => _TYPE; set => _TYPE = value; }
        public string CATEGORY { get => _CATEGORY; set => _CATEGORY = value; }
        public string FACTORY_STATION_GID { get => _FACTORY_STATION_GID; set => _FACTORY_STATION_GID = value; }
        public string WORK_CENTER_GID { get => _WORK_CENTER_GID; set => _WORK_CENTER_GID = value; }
        public string FACTORY_LINE_GID { get => _FACTORY_LINE_GID; set => _FACTORY_LINE_GID = value; }
        public string WORK_UNIT_GID { get => _WORK_UNIT_GID; set => _WORK_UNIT_GID = value; }
        public string PROCESSING_MODE { get => _PROCESSING_MODE; set => _PROCESSING_MODE = value; }
        public decimal? PROCESS_TEST { get => _PROCESS_TEST; set => _PROCESS_TEST = value; }
        public string WORKSHEET_GENARATION_MODE { get => _WORKSHEET_GENARATION_MODE; set => _WORKSHEET_GENARATION_MODE = value; }
        public string BUSINESS_MODE { get => _BUSINESS_MODE; set => _BUSINESS_MODE = value; }
        public decimal? RHYTHM { get => _RHYTHM; set => _RHYTHM = value; }
        public string RHYTHM_TYPE { get => _RHYTHM_TYPE; set => _RHYTHM_TYPE = value; }
        public decimal? OFFLINE_QTY { get => _OFFLINE_QTY; set => _OFFLINE_QTY = value; }
        public decimal? ONLINE_QTY { get => _ONLINE_QTY; set => _ONLINE_QTY = value; }
        public string STATUS { get => _STATUS; set => _STATUS = value; }
        public string OPERATION_PERSON { get => _OPERATION_PERSON; set => _OPERATION_PERSON = value; }
        public string EXECUTION_PERSON { get => _EXECUTION_PERSON; set => _EXECUTION_PERSON = value; }
        public decimal? OPERATION_STEP_FINISH_FLAG { get => _OPERATION_STEP_FINISH_FLAG; set => _OPERATION_STEP_FINISH_FLAG = value; }
        public decimal? RHYTHM_COUNT { get => _RHYTHM_COUNT; set => _RHYTHM_COUNT = value; }
        public string WORK_ORDER_OPERATION_GID { get => _WORK_ORDER_OPERATION_GID; set => _WORK_ORDER_OPERATION_GID = value; }
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
        public string ROW_NUMBER { get => _ROW_NUMBER; set => _ROW_NUMBER = value; }
        public decimal? RUNNING_TIME { get => _RUNNING_TIME; set => _RUNNING_TIME = value; }
        public string RUNNING_TIME_TYPE { get => _RUNNING_TIME_TYPE; set => _RUNNING_TIME_TYPE = value; }
        public decimal? PREPARATION_TIME { get => _PREPARATION_TIME; set => _PREPARATION_TIME = value; }
        public string PREPARATION_TIME_TYPE { get => _PREPARATION_TIME_TYPE; set => _PREPARATION_TIME_TYPE = value; }
        public decimal? RUNNING_TIME_COUNT { get => _RUNNING_TIME_COUNT; set => _RUNNING_TIME_COUNT = value; }
        public decimal? PREPARATION_TIME_COUNT { get => _PREPARATION_TIME_COUNT; set => _PREPARATION_TIME_COUNT = value; }
        public decimal? MAT_END_POINT { get => _MAT_END_POINT; set => _MAT_END_POINT = value; }
        public string DEF_OPERATION_GID { get => _DEF_OPERATION_GID; set => _DEF_OPERATION_GID = value; }
    }
}
