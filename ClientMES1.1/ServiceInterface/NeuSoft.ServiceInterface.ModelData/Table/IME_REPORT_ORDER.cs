using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_REPORT_ORDER 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_REPORT_ORDER : Entity
    {
        public IME_REPORT_ORDER() : base("IME_REPORT_ORDER") { }

        #region Model
        private string _GID;
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
        private string _OPERATION_CODE;
        private string _OPERATION_NAME;
        private string _TYPE;
        private string _CATEGORY;
        private string _FACTORY_STATION_GID;
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
        private string _REPORT_CATEGORY;
        private string _RECEIVE_PERSONNEL_GID;
        private string _START_PERSONNEL_GID;
        private string _FINISH_PERSONNEL_GID;
        private decimal? _QUALIFIED_QTY;
        private decimal? _OPERATION_STEP_FINISH_FLAG;
        private decimal? _RHYTHM_COUNT;
        private string _RESOURCE_ORDER_OPERATION_GID;
        private decimal? _TRACK_QTY;
        private decimal? _TOTAL_TRACK_QTY;
        private decimal? _CUR_TRACK_QTY;
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
        private string _ORIGIN_WORK_GID;
        private string _ORIGIN_TRACK_GID;
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
        public decimal? CUR_REPORT_QTY
        {
            get { return _CUR_REPORT_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_REPORT_QTY, _CUR_REPORT_QTY, value);
                this._CUR_REPORT_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_REPORT_QTY
        {
            get { return _TOTAL_REPORT_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_REPORT_QTY, _TOTAL_REPORT_QTY, value);
                this._TOTAL_REPORT_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CUR_QUALIFIED_QTY
        {
            get { return _CUR_QUALIFIED_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_QUALIFIED_QTY, _CUR_QUALIFIED_QTY, value);
                this._CUR_QUALIFIED_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_QUALIFIED_QTY
        {
            get { return _TOTAL_QUALIFIED_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_QUALIFIED_QTY, _TOTAL_QUALIFIED_QTY, value);
                this._TOTAL_QUALIFIED_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CUR_DEFECTIVE_QTY
        {
            get { return _CUR_DEFECTIVE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_DEFECTIVE_QTY, _CUR_DEFECTIVE_QTY, value);
                this._CUR_DEFECTIVE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_DEFECTIVE_QTY
        {
            get { return _TOTAL_DEFECTIVE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_DEFECTIVE_QTY, _TOTAL_DEFECTIVE_QTY, value);
                this._TOTAL_DEFECTIVE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CUR_WASTE_QTY
        {
            get { return _CUR_WASTE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_WASTE_QTY, _CUR_WASTE_QTY, value);
                this._CUR_WASTE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_WASTE_QTY
        {
            get { return _TOTAL_WASTE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_WASTE_QTY, _TOTAL_WASTE_QTY, value);
                this._TOTAL_WASTE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CUR_REPAIR_QTY
        {
            get { return _CUR_REPAIR_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_REPAIR_QTY, _CUR_REPAIR_QTY, value);
                this._CUR_REPAIR_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_REPAIR_QTY
        {
            get { return _TOTAL_REPAIR_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_REPAIR_QTY, _TOTAL_REPAIR_QTY, value);
                this._TOTAL_REPAIR_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION_CODE
        {
            get { return _OPERATION_CODE; }
            set
            {
                this.OnPropertyValueChange(_.OPERATION_CODE, _OPERATION_CODE, value);
                this._OPERATION_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION_NAME
        {
            get { return _OPERATION_NAME; }
            set
            {
                this.OnPropertyValueChange(_.OPERATION_NAME, _OPERATION_NAME, value);
                this._OPERATION_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TYPE
        {
            get { return _TYPE; }
            set
            {
                this.OnPropertyValueChange(_.TYPE, _TYPE, value);
                this._TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CATEGORY
        {
            get { return _CATEGORY; }
            set
            {
                this.OnPropertyValueChange(_.CATEGORY, _CATEGORY, value);
                this._CATEGORY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FACTORY_STATION_GID
        {
            get { return _FACTORY_STATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.FACTORY_STATION_GID, _FACTORY_STATION_GID, value);
                this._FACTORY_STATION_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PROCESSING_MODE
        {
            get { return _PROCESSING_MODE; }
            set
            {
                this.OnPropertyValueChange(_.PROCESSING_MODE, _PROCESSING_MODE, value);
                this._PROCESSING_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PROCESS_TEST
        {
            get { return _PROCESS_TEST; }
            set
            {
                this.OnPropertyValueChange(_.PROCESS_TEST, _PROCESS_TEST, value);
                this._PROCESS_TEST = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WORKSHEET_GENARATION_MODE
        {
            get { return _WORKSHEET_GENARATION_MODE; }
            set
            {
                this.OnPropertyValueChange(_.WORKSHEET_GENARATION_MODE, _WORKSHEET_GENARATION_MODE, value);
                this._WORKSHEET_GENARATION_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BUSINESS_MODE
        {
            get { return _BUSINESS_MODE; }
            set
            {
                this.OnPropertyValueChange(_.BUSINESS_MODE, _BUSINESS_MODE, value);
                this._BUSINESS_MODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? RHYTHM
        {
            get { return _RHYTHM; }
            set
            {
                this.OnPropertyValueChange(_.RHYTHM, _RHYTHM, value);
                this._RHYTHM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RHYTHM_TYPE
        {
            get { return _RHYTHM_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.RHYTHM_TYPE, _RHYTHM_TYPE, value);
                this._RHYTHM_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OFFLINE_QTY
        {
            get { return _OFFLINE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.OFFLINE_QTY, _OFFLINE_QTY, value);
                this._OFFLINE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? ONLINE_QTY
        {
            get { return _ONLINE_QTY; }
            set
            {
                this.OnPropertyValueChange(_.ONLINE_QTY, _ONLINE_QTY, value);
                this._ONLINE_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STATUS
        {
            get { return _STATUS; }
            set
            {
                this.OnPropertyValueChange(_.STATUS, _STATUS, value);
                this._STATUS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION_PERSON
        {
            get { return _OPERATION_PERSON; }
            set
            {
                this.OnPropertyValueChange(_.OPERATION_PERSON, _OPERATION_PERSON, value);
                this._OPERATION_PERSON = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string EXECUTION_PERSON
        {
            get { return _EXECUTION_PERSON; }
            set
            {
                this.OnPropertyValueChange(_.EXECUTION_PERSON, _EXECUTION_PERSON, value);
                this._EXECUTION_PERSON = value;
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
        public string RESOURCE_ORDER_GID
        {
            get { return _RESOURCE_ORDER_GID; }
            set
            {
                this.OnPropertyValueChange(_.RESOURCE_ORDER_GID, _RESOURCE_ORDER_GID, value);
                this._RESOURCE_ORDER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RESOURCE_ORDER_TYPE
        {
            get { return _RESOURCE_ORDER_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.RESOURCE_ORDER_TYPE, _RESOURCE_ORDER_TYPE, value);
                this._RESOURCE_ORDER_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_TYPE
        {
            get { return _ORDER_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_TYPE, _ORDER_TYPE, value);
                this._ORDER_TYPE = value;
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
        public string FACTORY_LINE_GID
        {
            get { return _FACTORY_LINE_GID; }
            set
            {
                this.OnPropertyValueChange(_.FACTORY_LINE_GID, _FACTORY_LINE_GID, value);
                this._FACTORY_LINE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WORK_UNIT_GID
        {
            get { return _WORK_UNIT_GID; }
            set
            {
                this.OnPropertyValueChange(_.WORK_UNIT_GID, _WORK_UNIT_GID, value);
                this._WORK_UNIT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_GID
        {
            get { return _MATERIAL_GID; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_GID, _MATERIAL_GID, value);
                this._MATERIAL_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_VERSION
        {
            get { return _MATERIAL_VERSION; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_VERSION, _MATERIAL_VERSION, value);
                this._MATERIAL_VERSION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCT_GID
        {
            get { return _PRODUCT_GID; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCT_GID, _PRODUCT_GID, value);
                this._PRODUCT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BOM_VERSION
        {
            get { return _BOM_VERSION; }
            set
            {
                this.OnPropertyValueChange(_.BOM_VERSION, _BOM_VERSION, value);
                this._BOM_VERSION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? WORK_ORDER_QTY
        {
            get { return _WORK_ORDER_QTY; }
            set
            {
                this.OnPropertyValueChange(_.WORK_ORDER_QTY, _WORK_ORDER_QTY, value);
                this._WORK_ORDER_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? WORK_ORDER_FINISH_QTY
        {
            get { return _WORK_ORDER_FINISH_QTY; }
            set
            {
                this.OnPropertyValueChange(_.WORK_ORDER_FINISH_QTY, _WORK_ORDER_FINISH_QTY, value);
                this._WORK_ORDER_FINISH_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PLAN_BEGIN_TIME
        {
            get { return _PLAN_BEGIN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.PLAN_BEGIN_TIME, _PLAN_BEGIN_TIME, value);
                this._PLAN_BEGIN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PLAN_END_TIME
        {
            get { return _PLAN_END_TIME; }
            set
            {
                this.OnPropertyValueChange(_.PLAN_END_TIME, _PLAN_END_TIME, value);
                this._PLAN_END_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CALCULATE_BEGIN_TIME
        {
            get { return _CALCULATE_BEGIN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.CALCULATE_BEGIN_TIME, _CALCULATE_BEGIN_TIME, value);
                this._CALCULATE_BEGIN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CALCULATE_END_TIME
        {
            get { return _CALCULATE_END_TIME; }
            set
            {
                this.OnPropertyValueChange(_.CALCULATE_END_TIME, _CALCULATE_END_TIME, value);
                this._CALCULATE_END_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ACTUAL_BEGIN_TIME
        {
            get { return _ACTUAL_BEGIN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.ACTUAL_BEGIN_TIME, _ACTUAL_BEGIN_TIME, value);
                this._ACTUAL_BEGIN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? ACTUAL_END_TIME
        {
            get { return _ACTUAL_END_TIME; }
            set
            {
                this.OnPropertyValueChange(_.ACTUAL_END_TIME, _ACTUAL_END_TIME, value);
                this._ACTUAL_END_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_LINE_GID
        {
            get { return _ROUTE_LINE_GID; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_LINE_GID, _ROUTE_LINE_GID, value);
                this._ROUTE_LINE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_LINE_VERSION
        {
            get { return _ROUTE_LINE_VERSION; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_LINE_VERSION, _ROUTE_LINE_VERSION, value);
                this._ROUTE_LINE_VERSION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_STATUS
        {
            get { return _ORDER_STATUS; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_STATUS, _ORDER_STATUS, value);
                this._ORDER_STATUS = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? BATCH_NUM
        {
            get { return _BATCH_NUM; }
            set
            {
                this.OnPropertyValueChange(_.BATCH_NUM, _BATCH_NUM, value);
                this._BATCH_NUM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REPORT_CATEGORY
        {
            get { return _REPORT_CATEGORY; }
            set
            {
                this.OnPropertyValueChange(_.REPORT_CATEGORY, _REPORT_CATEGORY, value);
                this._REPORT_CATEGORY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RECEIVE_PERSONNEL_GID
        {
            get { return _RECEIVE_PERSONNEL_GID; }
            set
            {
                this.OnPropertyValueChange(_.RECEIVE_PERSONNEL_GID, _RECEIVE_PERSONNEL_GID, value);
                this._RECEIVE_PERSONNEL_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string START_PERSONNEL_GID
        {
            get { return _START_PERSONNEL_GID; }
            set
            {
                this.OnPropertyValueChange(_.START_PERSONNEL_GID, _START_PERSONNEL_GID, value);
                this._START_PERSONNEL_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string FINISH_PERSONNEL_GID
        {
            get { return _FINISH_PERSONNEL_GID; }
            set
            {
                this.OnPropertyValueChange(_.FINISH_PERSONNEL_GID, _FINISH_PERSONNEL_GID, value);
                this._FINISH_PERSONNEL_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? QUALIFIED_QTY
        {
            get { return _QUALIFIED_QTY; }
            set
            {
                this.OnPropertyValueChange(_.QUALIFIED_QTY, _QUALIFIED_QTY, value);
                this._QUALIFIED_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OPERATION_STEP_FINISH_FLAG
        {
            get { return _OPERATION_STEP_FINISH_FLAG; }
            set
            {
                this.OnPropertyValueChange(_.OPERATION_STEP_FINISH_FLAG, _OPERATION_STEP_FINISH_FLAG, value);
                this._OPERATION_STEP_FINISH_FLAG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? RHYTHM_COUNT
        {
            get { return _RHYTHM_COUNT; }
            set
            {
                this.OnPropertyValueChange(_.RHYTHM_COUNT, _RHYTHM_COUNT, value);
                this._RHYTHM_COUNT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RESOURCE_ORDER_OPERATION_GID
        {
            get { return _RESOURCE_ORDER_OPERATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.RESOURCE_ORDER_OPERATION_GID, _RESOURCE_ORDER_OPERATION_GID, value);
                this._RESOURCE_ORDER_OPERATION_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TRACK_QTY
        {
            get { return _TRACK_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TRACK_QTY, _TRACK_QTY, value);
                this._TRACK_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_TRACK_QTY
        {
            get { return _TOTAL_TRACK_QTY; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_TRACK_QTY, _TOTAL_TRACK_QTY, value);
                this._TOTAL_TRACK_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? CUR_TRACK_QTY
        {
            get { return _CUR_TRACK_QTY; }
            set
            {
                this.OnPropertyValueChange(_.CUR_TRACK_QTY, _CUR_TRACK_QTY, value);
                this._CUR_TRACK_QTY = value;
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
        /// <summary>
        /// 
        /// </summary>
        public string ORIGIN_WORK_GID
        {
            get { return _ORIGIN_WORK_GID; }
            set
            {
                this.OnPropertyValueChange(_.ORIGIN_WORK_GID, _ORIGIN_WORK_GID, value);
                this._ORIGIN_WORK_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORIGIN_TRACK_GID
        {
            get { return _ORIGIN_TRACK_GID; }
            set
            {
                this.OnPropertyValueChange(_.ORIGIN_TRACK_GID, _ORIGIN_TRACK_GID, value);
                this._ORIGIN_TRACK_GID = value;
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
                _.CUR_REPORT_QTY,
                _.TOTAL_REPORT_QTY,
                _.CUR_QUALIFIED_QTY,
                _.TOTAL_QUALIFIED_QTY,
                _.CUR_DEFECTIVE_QTY,
                _.TOTAL_DEFECTIVE_QTY,
                _.CUR_WASTE_QTY,
                _.TOTAL_WASTE_QTY,
                _.CUR_REPAIR_QTY,
                _.TOTAL_REPAIR_QTY,
                _.OPERATION_CODE,
                _.OPERATION_NAME,
                _.TYPE,
                _.CATEGORY,
                _.FACTORY_STATION_GID,
                _.PROCESSING_MODE,
                _.PROCESS_TEST,
                _.WORKSHEET_GENARATION_MODE,
                _.BUSINESS_MODE,
                _.RHYTHM,
                _.RHYTHM_TYPE,
                _.OFFLINE_QTY,
                _.ONLINE_QTY,
                _.STATUS,
                _.OPERATION_PERSON,
                _.EXECUTION_PERSON,
                _.CODE,
                _.RESOURCE_ORDER_GID,
                _.RESOURCE_ORDER_TYPE,
                _.ORDER_TYPE,
                _.WORK_CENTER_GID,
                _.FACTORY_LINE_GID,
                _.WORK_UNIT_GID,
                _.MATERIAL_GID,
                _.MATERIAL_VERSION,
                _.PRODUCT_GID,
                _.BOM_VERSION,
                _.WORK_ORDER_QTY,
                _.WORK_ORDER_FINISH_QTY,
                _.PLAN_BEGIN_TIME,
                _.PLAN_END_TIME,
                _.CALCULATE_BEGIN_TIME,
                _.CALCULATE_END_TIME,
                _.ACTUAL_BEGIN_TIME,
                _.ACTUAL_END_TIME,
                _.ROUTE_LINE_GID,
                _.ROUTE_LINE_VERSION,
                _.ORDER_STATUS,
                _.BATCH_NUM,
                _.REPORT_CATEGORY,
                _.RECEIVE_PERSONNEL_GID,
                _.START_PERSONNEL_GID,
                _.FINISH_PERSONNEL_GID,
                _.QUALIFIED_QTY,
                _.OPERATION_STEP_FINISH_FLAG,
                _.RHYTHM_COUNT,
                _.RESOURCE_ORDER_OPERATION_GID,
                _.TRACK_QTY,
                _.TOTAL_TRACK_QTY,
                _.CUR_TRACK_QTY,
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
                _.UDA20,
                _.ORIGIN_WORK_GID,
                _.ORIGIN_TRACK_GID};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GID,
                this._CUR_REPORT_QTY,
                this._TOTAL_REPORT_QTY,
                this._CUR_QUALIFIED_QTY,
                this._TOTAL_QUALIFIED_QTY,
                this._CUR_DEFECTIVE_QTY,
                this._TOTAL_DEFECTIVE_QTY,
                this._CUR_WASTE_QTY,
                this._TOTAL_WASTE_QTY,
                this._CUR_REPAIR_QTY,
                this._TOTAL_REPAIR_QTY,
                this._OPERATION_CODE,
                this._OPERATION_NAME,
                this._TYPE,
                this._CATEGORY,
                this._FACTORY_STATION_GID,
                this._PROCESSING_MODE,
                this._PROCESS_TEST,
                this._WORKSHEET_GENARATION_MODE,
                this._BUSINESS_MODE,
                this._RHYTHM,
                this._RHYTHM_TYPE,
                this._OFFLINE_QTY,
                this._ONLINE_QTY,
                this._STATUS,
                this._OPERATION_PERSON,
                this._EXECUTION_PERSON,
                this._CODE,
                this._RESOURCE_ORDER_GID,
                this._RESOURCE_ORDER_TYPE,
                this._ORDER_TYPE,
                this._WORK_CENTER_GID,
                this._FACTORY_LINE_GID,
                this._WORK_UNIT_GID,
                this._MATERIAL_GID,
                this._MATERIAL_VERSION,
                this._PRODUCT_GID,
                this._BOM_VERSION,
                this._WORK_ORDER_QTY,
                this._WORK_ORDER_FINISH_QTY,
                this._PLAN_BEGIN_TIME,
                this._PLAN_END_TIME,
                this._CALCULATE_BEGIN_TIME,
                this._CALCULATE_END_TIME,
                this._ACTUAL_BEGIN_TIME,
                this._ACTUAL_END_TIME,
                this._ROUTE_LINE_GID,
                this._ROUTE_LINE_VERSION,
                this._ORDER_STATUS,
                this._BATCH_NUM,
                this._REPORT_CATEGORY,
                this._RECEIVE_PERSONNEL_GID,
                this._START_PERSONNEL_GID,
                this._FINISH_PERSONNEL_GID,
                this._QUALIFIED_QTY,
                this._OPERATION_STEP_FINISH_FLAG,
                this._RHYTHM_COUNT,
                this._RESOURCE_ORDER_OPERATION_GID,
                this._TRACK_QTY,
                this._TOTAL_TRACK_QTY,
                this._CUR_TRACK_QTY,
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
                this._UDA20,
                this._ORIGIN_WORK_GID,
                this._ORIGIN_TRACK_GID};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._GID = DataUtils.ConvertValue<string>(reader["GID"]);
            this._CUR_REPORT_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_REPORT_QTY"]);
            this._TOTAL_REPORT_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_REPORT_QTY"]);
            this._CUR_QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_QUALIFIED_QTY"]);
            this._TOTAL_QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_QUALIFIED_QTY"]);
            this._CUR_DEFECTIVE_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_DEFECTIVE_QTY"]);
            this._TOTAL_DEFECTIVE_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_DEFECTIVE_QTY"]);
            this._CUR_WASTE_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_WASTE_QTY"]);
            this._TOTAL_WASTE_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_WASTE_QTY"]);
            this._CUR_REPAIR_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_REPAIR_QTY"]);
            this._TOTAL_REPAIR_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_REPAIR_QTY"]);
            this._OPERATION_CODE = DataUtils.ConvertValue<string>(reader["OPERATION_CODE"]);
            this._OPERATION_NAME = DataUtils.ConvertValue<string>(reader["OPERATION_NAME"]);
            this._TYPE = DataUtils.ConvertValue<string>(reader["TYPE"]);
            this._CATEGORY = DataUtils.ConvertValue<string>(reader["CATEGORY"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(reader["FACTORY_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(reader["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(reader["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(reader["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(reader["BUSINESS_MODE"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(reader["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(reader["RHYTHM_TYPE"]);
            this._OFFLINE_QTY = DataUtils.ConvertValue<decimal?>(reader["OFFLINE_QTY"]);
            this._ONLINE_QTY = DataUtils.ConvertValue<decimal?>(reader["ONLINE_QTY"]);
            this._STATUS = DataUtils.ConvertValue<string>(reader["STATUS"]);
            this._OPERATION_PERSON = DataUtils.ConvertValue<string>(reader["OPERATION_PERSON"]);
            this._EXECUTION_PERSON = DataUtils.ConvertValue<string>(reader["EXECUTION_PERSON"]);
            this._CODE = DataUtils.ConvertValue<string>(reader["CODE"]);
            this._RESOURCE_ORDER_GID = DataUtils.ConvertValue<string>(reader["RESOURCE_ORDER_GID"]);
            this._RESOURCE_ORDER_TYPE = DataUtils.ConvertValue<string>(reader["RESOURCE_ORDER_TYPE"]);
            this._ORDER_TYPE = DataUtils.ConvertValue<string>(reader["ORDER_TYPE"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(reader["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(reader["WORK_UNIT_GID"]);
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(reader["MATERIAL_GID"]);
            this._MATERIAL_VERSION = DataUtils.ConvertValue<string>(reader["MATERIAL_VERSION"]);
            this._PRODUCT_GID = DataUtils.ConvertValue<string>(reader["PRODUCT_GID"]);
            this._BOM_VERSION = DataUtils.ConvertValue<string>(reader["BOM_VERSION"]);
            this._WORK_ORDER_QTY = DataUtils.ConvertValue<decimal?>(reader["WORK_ORDER_QTY"]);
            this._WORK_ORDER_FINISH_QTY = DataUtils.ConvertValue<decimal?>(reader["WORK_ORDER_FINISH_QTY"]);
            this._PLAN_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(reader["PLAN_BEGIN_TIME"]);
            this._PLAN_END_TIME = DataUtils.ConvertValue<DateTime?>(reader["PLAN_END_TIME"]);
            this._CALCULATE_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(reader["CALCULATE_BEGIN_TIME"]);
            this._CALCULATE_END_TIME = DataUtils.ConvertValue<DateTime?>(reader["CALCULATE_END_TIME"]);
            this._ACTUAL_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(reader["ACTUAL_BEGIN_TIME"]);
            this._ACTUAL_END_TIME = DataUtils.ConvertValue<DateTime?>(reader["ACTUAL_END_TIME"]);
            this._ROUTE_LINE_GID = DataUtils.ConvertValue<string>(reader["ROUTE_LINE_GID"]);
            this._ROUTE_LINE_VERSION = DataUtils.ConvertValue<string>(reader["ROUTE_LINE_VERSION"]);
            this._ORDER_STATUS = DataUtils.ConvertValue<string>(reader["ORDER_STATUS"]);
            this._BATCH_NUM = DataUtils.ConvertValue<decimal?>(reader["BATCH_NUM"]);
            this._REPORT_CATEGORY = DataUtils.ConvertValue<string>(reader["REPORT_CATEGORY"]);
            this._RECEIVE_PERSONNEL_GID = DataUtils.ConvertValue<string>(reader["RECEIVE_PERSONNEL_GID"]);
            this._START_PERSONNEL_GID = DataUtils.ConvertValue<string>(reader["START_PERSONNEL_GID"]);
            this._FINISH_PERSONNEL_GID = DataUtils.ConvertValue<string>(reader["FINISH_PERSONNEL_GID"]);
            this._QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(reader["QUALIFIED_QTY"]);
            this._OPERATION_STEP_FINISH_FLAG = DataUtils.ConvertValue<decimal?>(reader["OPERATION_STEP_FINISH_FLAG"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(reader["RHYTHM_COUNT"]);
            this._RESOURCE_ORDER_OPERATION_GID = DataUtils.ConvertValue<string>(reader["RESOURCE_ORDER_OPERATION_GID"]);
            this._TRACK_QTY = DataUtils.ConvertValue<decimal?>(reader["TRACK_QTY"]);
            this._TOTAL_TRACK_QTY = DataUtils.ConvertValue<decimal?>(reader["TOTAL_TRACK_QTY"]);
            this._CUR_TRACK_QTY = DataUtils.ConvertValue<decimal?>(reader["CUR_TRACK_QTY"]);
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
            this._ORIGIN_WORK_GID = DataUtils.ConvertValue<string>(reader["ORIGIN_WORK_GID"]);
            this._ORIGIN_TRACK_GID = DataUtils.ConvertValue<string>(reader["ORIGIN_TRACK_GID"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._GID = DataUtils.ConvertValue<string>(row["GID"]);
            this._CUR_REPORT_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_REPORT_QTY"]);
            this._TOTAL_REPORT_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_REPORT_QTY"]);
            this._CUR_QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_QUALIFIED_QTY"]);
            this._TOTAL_QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_QUALIFIED_QTY"]);
            this._CUR_DEFECTIVE_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_DEFECTIVE_QTY"]);
            this._TOTAL_DEFECTIVE_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_DEFECTIVE_QTY"]);
            this._CUR_WASTE_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_WASTE_QTY"]);
            this._TOTAL_WASTE_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_WASTE_QTY"]);
            this._CUR_REPAIR_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_REPAIR_QTY"]);
            this._TOTAL_REPAIR_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_REPAIR_QTY"]);
            this._OPERATION_CODE = DataUtils.ConvertValue<string>(row["OPERATION_CODE"]);
            this._OPERATION_NAME = DataUtils.ConvertValue<string>(row["OPERATION_NAME"]);
            this._TYPE = DataUtils.ConvertValue<string>(row["TYPE"]);
            this._CATEGORY = DataUtils.ConvertValue<string>(row["CATEGORY"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(row["FACTORY_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(row["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(row["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(row["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(row["BUSINESS_MODE"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(row["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(row["RHYTHM_TYPE"]);
            this._OFFLINE_QTY = DataUtils.ConvertValue<decimal?>(row["OFFLINE_QTY"]);
            this._ONLINE_QTY = DataUtils.ConvertValue<decimal?>(row["ONLINE_QTY"]);
            this._STATUS = DataUtils.ConvertValue<string>(row["STATUS"]);
            this._OPERATION_PERSON = DataUtils.ConvertValue<string>(row["OPERATION_PERSON"]);
            this._EXECUTION_PERSON = DataUtils.ConvertValue<string>(row["EXECUTION_PERSON"]);
            this._CODE = DataUtils.ConvertValue<string>(row["CODE"]);
            this._RESOURCE_ORDER_GID = DataUtils.ConvertValue<string>(row["RESOURCE_ORDER_GID"]);
            this._RESOURCE_ORDER_TYPE = DataUtils.ConvertValue<string>(row["RESOURCE_ORDER_TYPE"]);
            this._ORDER_TYPE = DataUtils.ConvertValue<string>(row["ORDER_TYPE"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(row["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(row["WORK_UNIT_GID"]);
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(row["MATERIAL_GID"]);
            this._MATERIAL_VERSION = DataUtils.ConvertValue<string>(row["MATERIAL_VERSION"]);
            this._PRODUCT_GID = DataUtils.ConvertValue<string>(row["PRODUCT_GID"]);
            this._BOM_VERSION = DataUtils.ConvertValue<string>(row["BOM_VERSION"]);
            this._WORK_ORDER_QTY = DataUtils.ConvertValue<decimal?>(row["WORK_ORDER_QTY"]);
            this._WORK_ORDER_FINISH_QTY = DataUtils.ConvertValue<decimal?>(row["WORK_ORDER_FINISH_QTY"]);
            this._PLAN_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(row["PLAN_BEGIN_TIME"]);
            this._PLAN_END_TIME = DataUtils.ConvertValue<DateTime?>(row["PLAN_END_TIME"]);
            this._CALCULATE_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(row["CALCULATE_BEGIN_TIME"]);
            this._CALCULATE_END_TIME = DataUtils.ConvertValue<DateTime?>(row["CALCULATE_END_TIME"]);
            this._ACTUAL_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(row["ACTUAL_BEGIN_TIME"]);
            this._ACTUAL_END_TIME = DataUtils.ConvertValue<DateTime?>(row["ACTUAL_END_TIME"]);
            this._ROUTE_LINE_GID = DataUtils.ConvertValue<string>(row["ROUTE_LINE_GID"]);
            this._ROUTE_LINE_VERSION = DataUtils.ConvertValue<string>(row["ROUTE_LINE_VERSION"]);
            this._ORDER_STATUS = DataUtils.ConvertValue<string>(row["ORDER_STATUS"]);
            this._BATCH_NUM = DataUtils.ConvertValue<decimal?>(row["BATCH_NUM"]);
            this._REPORT_CATEGORY = DataUtils.ConvertValue<string>(row["REPORT_CATEGORY"]);
            this._RECEIVE_PERSONNEL_GID = DataUtils.ConvertValue<string>(row["RECEIVE_PERSONNEL_GID"]);
            this._START_PERSONNEL_GID = DataUtils.ConvertValue<string>(row["START_PERSONNEL_GID"]);
            this._FINISH_PERSONNEL_GID = DataUtils.ConvertValue<string>(row["FINISH_PERSONNEL_GID"]);
            this._QUALIFIED_QTY = DataUtils.ConvertValue<decimal?>(row["QUALIFIED_QTY"]);
            this._OPERATION_STEP_FINISH_FLAG = DataUtils.ConvertValue<decimal?>(row["OPERATION_STEP_FINISH_FLAG"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(row["RHYTHM_COUNT"]);
            this._RESOURCE_ORDER_OPERATION_GID = DataUtils.ConvertValue<string>(row["RESOURCE_ORDER_OPERATION_GID"]);
            this._TRACK_QTY = DataUtils.ConvertValue<decimal?>(row["TRACK_QTY"]);
            this._TOTAL_TRACK_QTY = DataUtils.ConvertValue<decimal?>(row["TOTAL_TRACK_QTY"]);
            this._CUR_TRACK_QTY = DataUtils.ConvertValue<decimal?>(row["CUR_TRACK_QTY"]);
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
            this._ORIGIN_WORK_GID = DataUtils.ConvertValue<string>(row["ORIGIN_WORK_GID"]);
            this._ORIGIN_TRACK_GID = DataUtils.ConvertValue<string>(row["ORIGIN_TRACK_GID"]);
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
            public readonly static Field All = new Field("*", "IME_REPORT_ORDER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_REPORT_ORDER", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_REPORT_QTY = new Field("CUR_REPORT_QTY", "IME_REPORT_ORDER", "CUR_REPORT_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_REPORT_QTY = new Field("TOTAL_REPORT_QTY", "IME_REPORT_ORDER", "TOTAL_REPORT_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_QUALIFIED_QTY = new Field("CUR_QUALIFIED_QTY", "IME_REPORT_ORDER", "CUR_QUALIFIED_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_QUALIFIED_QTY = new Field("TOTAL_QUALIFIED_QTY", "IME_REPORT_ORDER", "TOTAL_QUALIFIED_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_DEFECTIVE_QTY = new Field("CUR_DEFECTIVE_QTY", "IME_REPORT_ORDER", "CUR_DEFECTIVE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_DEFECTIVE_QTY = new Field("TOTAL_DEFECTIVE_QTY", "IME_REPORT_ORDER", "TOTAL_DEFECTIVE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_WASTE_QTY = new Field("CUR_WASTE_QTY", "IME_REPORT_ORDER", "CUR_WASTE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_WASTE_QTY = new Field("TOTAL_WASTE_QTY", "IME_REPORT_ORDER", "TOTAL_WASTE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_REPAIR_QTY = new Field("CUR_REPAIR_QTY", "IME_REPORT_ORDER", "CUR_REPAIR_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_REPAIR_QTY = new Field("TOTAL_REPAIR_QTY", "IME_REPORT_ORDER", "TOTAL_REPAIR_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_CODE = new Field("OPERATION_CODE", "IME_REPORT_ORDER", "OPERATION_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_NAME = new Field("OPERATION_NAME", "IME_REPORT_ORDER", "OPERATION_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TYPE = new Field("TYPE", "IME_REPORT_ORDER", "TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CATEGORY = new Field("CATEGORY", "IME_REPORT_ORDER", "CATEGORY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_STATION_GID = new Field("FACTORY_STATION_GID", "IME_REPORT_ORDER", "FACTORY_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESSING_MODE = new Field("PROCESSING_MODE", "IME_REPORT_ORDER", "PROCESSING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESS_TEST = new Field("PROCESS_TEST", "IME_REPORT_ORDER", "PROCESS_TEST");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORKSHEET_GENARATION_MODE = new Field("WORKSHEET_GENARATION_MODE", "IME_REPORT_ORDER", "WORKSHEET_GENARATION_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BUSINESS_MODE = new Field("BUSINESS_MODE", "IME_REPORT_ORDER", "BUSINESS_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM = new Field("RHYTHM", "IME_REPORT_ORDER", "RHYTHM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_TYPE = new Field("RHYTHM_TYPE", "IME_REPORT_ORDER", "RHYTHM_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OFFLINE_QTY = new Field("OFFLINE_QTY", "IME_REPORT_ORDER", "OFFLINE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ONLINE_QTY = new Field("ONLINE_QTY", "IME_REPORT_ORDER", "ONLINE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STATUS = new Field("STATUS", "IME_REPORT_ORDER", "STATUS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_PERSON = new Field("OPERATION_PERSON", "IME_REPORT_ORDER", "OPERATION_PERSON");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EXECUTION_PERSON = new Field("EXECUTION_PERSON", "IME_REPORT_ORDER", "EXECUTION_PERSON");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CODE = new Field("CODE", "IME_REPORT_ORDER", "CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RESOURCE_ORDER_GID = new Field("RESOURCE_ORDER_GID", "IME_REPORT_ORDER", "RESOURCE_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RESOURCE_ORDER_TYPE = new Field("RESOURCE_ORDER_TYPE", "IME_REPORT_ORDER", "RESOURCE_ORDER_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORDER_TYPE = new Field("ORDER_TYPE", "IME_REPORT_ORDER", "ORDER_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_CENTER_GID = new Field("WORK_CENTER_GID", "IME_REPORT_ORDER", "WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_LINE_GID = new Field("FACTORY_LINE_GID", "IME_REPORT_ORDER", "FACTORY_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_UNIT_GID = new Field("WORK_UNIT_GID", "IME_REPORT_ORDER", "WORK_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_GID = new Field("MATERIAL_GID", "IME_REPORT_ORDER", "MATERIAL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_VERSION = new Field("MATERIAL_VERSION", "IME_REPORT_ORDER", "MATERIAL_VERSION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCT_GID = new Field("PRODUCT_GID", "IME_REPORT_ORDER", "PRODUCT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BOM_VERSION = new Field("BOM_VERSION", "IME_REPORT_ORDER", "BOM_VERSION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_ORDER_QTY = new Field("WORK_ORDER_QTY", "IME_REPORT_ORDER", "WORK_ORDER_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_ORDER_FINISH_QTY = new Field("WORK_ORDER_FINISH_QTY", "IME_REPORT_ORDER", "WORK_ORDER_FINISH_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_BEGIN_TIME = new Field("PLAN_BEGIN_TIME", "IME_REPORT_ORDER", "PLAN_BEGIN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_END_TIME = new Field("PLAN_END_TIME", "IME_REPORT_ORDER", "PLAN_END_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CALCULATE_BEGIN_TIME = new Field("CALCULATE_BEGIN_TIME", "IME_REPORT_ORDER", "CALCULATE_BEGIN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CALCULATE_END_TIME = new Field("CALCULATE_END_TIME", "IME_REPORT_ORDER", "CALCULATE_END_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ACTUAL_BEGIN_TIME = new Field("ACTUAL_BEGIN_TIME", "IME_REPORT_ORDER", "ACTUAL_BEGIN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ACTUAL_END_TIME = new Field("ACTUAL_END_TIME", "IME_REPORT_ORDER", "ACTUAL_END_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_LINE_GID = new Field("ROUTE_LINE_GID", "IME_REPORT_ORDER", "ROUTE_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_LINE_VERSION = new Field("ROUTE_LINE_VERSION", "IME_REPORT_ORDER", "ROUTE_LINE_VERSION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORDER_STATUS = new Field("ORDER_STATUS", "IME_REPORT_ORDER", "ORDER_STATUS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BATCH_NUM = new Field("BATCH_NUM", "IME_REPORT_ORDER", "BATCH_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REPORT_CATEGORY = new Field("REPORT_CATEGORY", "IME_REPORT_ORDER", "REPORT_CATEGORY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RECEIVE_PERSONNEL_GID = new Field("RECEIVE_PERSONNEL_GID", "IME_REPORT_ORDER", "RECEIVE_PERSONNEL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field START_PERSONNEL_GID = new Field("START_PERSONNEL_GID", "IME_REPORT_ORDER", "START_PERSONNEL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FINISH_PERSONNEL_GID = new Field("FINISH_PERSONNEL_GID", "IME_REPORT_ORDER", "FINISH_PERSONNEL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field QUALIFIED_QTY = new Field("QUALIFIED_QTY", "IME_REPORT_ORDER", "QUALIFIED_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_STEP_FINISH_FLAG = new Field("OPERATION_STEP_FINISH_FLAG", "IME_REPORT_ORDER", "OPERATION_STEP_FINISH_FLAG");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_COUNT = new Field("RHYTHM_COUNT", "IME_REPORT_ORDER", "RHYTHM_COUNT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RESOURCE_ORDER_OPERATION_GID = new Field("RESOURCE_ORDER_OPERATION_GID", "IME_REPORT_ORDER", "RESOURCE_ORDER_OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TRACK_QTY = new Field("TRACK_QTY", "IME_REPORT_ORDER", "TRACK_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_TRACK_QTY = new Field("TOTAL_TRACK_QTY", "IME_REPORT_ORDER", "TOTAL_TRACK_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CUR_TRACK_QTY = new Field("CUR_TRACK_QTY", "IME_REPORT_ORDER", "CUR_TRACK_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_REPORT_ORDER", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_REPORT_ORDER", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_REPORT_ORDER", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_REPORT_ORDER", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_REPORT_ORDER", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_REPORT_ORDER", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_REPORT_ORDER", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_REPORT_ORDER", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_REPORT_ORDER", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_REPORT_ORDER", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_REPORT_ORDER", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_REPORT_ORDER", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_REPORT_ORDER", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_REPORT_ORDER", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_REPORT_ORDER", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_REPORT_ORDER", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_REPORT_ORDER", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_REPORT_ORDER", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_REPORT_ORDER", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_REPORT_ORDER", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_REPORT_ORDER", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_REPORT_ORDER", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_REPORT_ORDER", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_REPORT_ORDER", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_REPORT_ORDER", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_REPORT_ORDER", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_REPORT_ORDER", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_REPORT_ORDER", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_REPORT_ORDER", "UDA20");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORIGIN_WORK_GID = new Field("ORIGIN_WORK_GID", "IME_REPORT_ORDER", "ORIGIN_WORK_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORIGIN_TRACK_GID = new Field("ORIGIN_TRACK_GID", "IME_REPORT_ORDER", "ORIGIN_TRACK_GID");
        }
        #endregion


    }

}
