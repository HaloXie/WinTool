using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_REPORT_ORDER_STEPS 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_REPORT_ORDER_STEPS : Entity
    {
        public IME_REPORT_ORDER_STEPS() : base("IME_REPORT_ORDER_STEPS") { }

        #region Model
        private string _GID;
        private string _RESOURCE_ORDER_GID;
        private string _TRACK_ORDER_GID;
        private string _OPERATION_GID;
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
        private decimal? _MATERIAL_CAN_FINISH;
        private decimal? _OFFLINE_QTY;
        private decimal? _ONLINE_QTY;
        private decimal? _FINISH_QTY;
        private string _STATUS;
        private string _OPERATION_PERSON;
        private string _EXECUTION_PERSON;
        private decimal? _OPERATION_STEP_FINISH_FLAG;
        private decimal? _RHYTHM_COUNT;
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
        public string TRACK_ORDER_GID
        {
            get { return _TRACK_ORDER_GID; }
            set
            {
                this.OnPropertyValueChange(_.TRACK_ORDER_GID, _TRACK_ORDER_GID, value);
                this._TRACK_ORDER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OPERATION_GID
        {
            get { return _OPERATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.OPERATION_GID, _OPERATION_GID, value);
                this._OPERATION_GID = value;
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
        public decimal? MATERIAL_CAN_FINISH
        {
            get { return _MATERIAL_CAN_FINISH; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_CAN_FINISH, _MATERIAL_CAN_FINISH, value);
                this._MATERIAL_CAN_FINISH = value;
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
        public decimal? FINISH_QTY
        {
            get { return _FINISH_QTY; }
            set
            {
                this.OnPropertyValueChange(_.FINISH_QTY, _FINISH_QTY, value);
                this._FINISH_QTY = value;
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
        public string ROW_NUMBER
        {
            get { return _ROW_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.ROW_NUMBER, _ROW_NUMBER, value);
                this._ROW_NUMBER = value;
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
                _.RESOURCE_ORDER_GID,
                _.TRACK_ORDER_GID,
                _.OPERATION_GID,
                _.CODE,
                _.NAME,
                _.TYPE,
                _.CATEGORY,
                _.FACTORY_STATION_GID,
                _.WORK_CENTER_GID,
                _.FACTORY_LINE_GID,
                _.WORK_UNIT_GID,
                _.PROCESSING_MODE,
                _.PROCESS_TEST,
                _.WORKSHEET_GENARATION_MODE,
                _.BUSINESS_MODE,
                _.RHYTHM,
                _.RHYTHM_TYPE,
                _.MATERIAL_CAN_FINISH,
                _.OFFLINE_QTY,
                _.ONLINE_QTY,
                _.FINISH_QTY,
                _.STATUS,
                _.OPERATION_PERSON,
                _.EXECUTION_PERSON,
                _.OPERATION_STEP_FINISH_FLAG,
                _.RHYTHM_COUNT,
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
                _.ROW_NUMBER};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GID,
                this._RESOURCE_ORDER_GID,
                this._TRACK_ORDER_GID,
                this._OPERATION_GID,
                this._CODE,
                this._NAME,
                this._TYPE,
                this._CATEGORY,
                this._FACTORY_STATION_GID,
                this._WORK_CENTER_GID,
                this._FACTORY_LINE_GID,
                this._WORK_UNIT_GID,
                this._PROCESSING_MODE,
                this._PROCESS_TEST,
                this._WORKSHEET_GENARATION_MODE,
                this._BUSINESS_MODE,
                this._RHYTHM,
                this._RHYTHM_TYPE,
                this._MATERIAL_CAN_FINISH,
                this._OFFLINE_QTY,
                this._ONLINE_QTY,
                this._FINISH_QTY,
                this._STATUS,
                this._OPERATION_PERSON,
                this._EXECUTION_PERSON,
                this._OPERATION_STEP_FINISH_FLAG,
                this._RHYTHM_COUNT,
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
                this._ROW_NUMBER};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._GID = DataUtils.ConvertValue<string>(reader["GID"]);
            this._RESOURCE_ORDER_GID = DataUtils.ConvertValue<string>(reader["RESOURCE_ORDER_GID"]);
            this._TRACK_ORDER_GID = DataUtils.ConvertValue<string>(reader["TRACK_ORDER_GID"]);
            this._OPERATION_GID = DataUtils.ConvertValue<string>(reader["OPERATION_GID"]);
            this._CODE = DataUtils.ConvertValue<string>(reader["CODE"]);
            this._NAME = DataUtils.ConvertValue<string>(reader["NAME"]);
            this._TYPE = DataUtils.ConvertValue<string>(reader["TYPE"]);
            this._CATEGORY = DataUtils.ConvertValue<string>(reader["CATEGORY"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(reader["FACTORY_STATION_GID"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(reader["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(reader["WORK_UNIT_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(reader["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(reader["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(reader["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(reader["BUSINESS_MODE"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(reader["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(reader["RHYTHM_TYPE"]);
            this._MATERIAL_CAN_FINISH = DataUtils.ConvertValue<decimal?>(reader["MATERIAL_CAN_FINISH"]);
            this._OFFLINE_QTY = DataUtils.ConvertValue<decimal?>(reader["OFFLINE_QTY"]);
            this._ONLINE_QTY = DataUtils.ConvertValue<decimal?>(reader["ONLINE_QTY"]);
            this._FINISH_QTY = DataUtils.ConvertValue<decimal?>(reader["FINISH_QTY"]);
            this._STATUS = DataUtils.ConvertValue<string>(reader["STATUS"]);
            this._OPERATION_PERSON = DataUtils.ConvertValue<string>(reader["OPERATION_PERSON"]);
            this._EXECUTION_PERSON = DataUtils.ConvertValue<string>(reader["EXECUTION_PERSON"]);
            this._OPERATION_STEP_FINISH_FLAG = DataUtils.ConvertValue<decimal?>(reader["OPERATION_STEP_FINISH_FLAG"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(reader["RHYTHM_COUNT"]);
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
            this._ROW_NUMBER = DataUtils.ConvertValue<string>(reader["ROW_NUMBER"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._GID = DataUtils.ConvertValue<string>(row["GID"]);
            this._RESOURCE_ORDER_GID = DataUtils.ConvertValue<string>(row["RESOURCE_ORDER_GID"]);
            this._TRACK_ORDER_GID = DataUtils.ConvertValue<string>(row["TRACK_ORDER_GID"]);
            this._OPERATION_GID = DataUtils.ConvertValue<string>(row["OPERATION_GID"]);
            this._CODE = DataUtils.ConvertValue<string>(row["CODE"]);
            this._NAME = DataUtils.ConvertValue<string>(row["NAME"]);
            this._TYPE = DataUtils.ConvertValue<string>(row["TYPE"]);
            this._CATEGORY = DataUtils.ConvertValue<string>(row["CATEGORY"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(row["FACTORY_STATION_GID"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(row["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(row["WORK_UNIT_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(row["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(row["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(row["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(row["BUSINESS_MODE"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(row["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(row["RHYTHM_TYPE"]);
            this._MATERIAL_CAN_FINISH = DataUtils.ConvertValue<decimal?>(row["MATERIAL_CAN_FINISH"]);
            this._OFFLINE_QTY = DataUtils.ConvertValue<decimal?>(row["OFFLINE_QTY"]);
            this._ONLINE_QTY = DataUtils.ConvertValue<decimal?>(row["ONLINE_QTY"]);
            this._FINISH_QTY = DataUtils.ConvertValue<decimal?>(row["FINISH_QTY"]);
            this._STATUS = DataUtils.ConvertValue<string>(row["STATUS"]);
            this._OPERATION_PERSON = DataUtils.ConvertValue<string>(row["OPERATION_PERSON"]);
            this._EXECUTION_PERSON = DataUtils.ConvertValue<string>(row["EXECUTION_PERSON"]);
            this._OPERATION_STEP_FINISH_FLAG = DataUtils.ConvertValue<decimal?>(row["OPERATION_STEP_FINISH_FLAG"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(row["RHYTHM_COUNT"]);
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
            this._ROW_NUMBER = DataUtils.ConvertValue<string>(row["ROW_NUMBER"]);
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
            public readonly static Field All = new Field("*", "IME_REPORT_ORDER_STEPS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_REPORT_ORDER_STEPS", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RESOURCE_ORDER_GID = new Field("RESOURCE_ORDER_GID", "IME_REPORT_ORDER_STEPS", "RESOURCE_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TRACK_ORDER_GID = new Field("TRACK_ORDER_GID", "IME_REPORT_ORDER_STEPS", "TRACK_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_GID = new Field("OPERATION_GID", "IME_REPORT_ORDER_STEPS", "OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CODE = new Field("CODE", "IME_REPORT_ORDER_STEPS", "CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field NAME = new Field("NAME", "IME_REPORT_ORDER_STEPS", "NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TYPE = new Field("TYPE", "IME_REPORT_ORDER_STEPS", "TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CATEGORY = new Field("CATEGORY", "IME_REPORT_ORDER_STEPS", "CATEGORY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_STATION_GID = new Field("FACTORY_STATION_GID", "IME_REPORT_ORDER_STEPS", "FACTORY_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_CENTER_GID = new Field("WORK_CENTER_GID", "IME_REPORT_ORDER_STEPS", "WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_LINE_GID = new Field("FACTORY_LINE_GID", "IME_REPORT_ORDER_STEPS", "FACTORY_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_UNIT_GID = new Field("WORK_UNIT_GID", "IME_REPORT_ORDER_STEPS", "WORK_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESSING_MODE = new Field("PROCESSING_MODE", "IME_REPORT_ORDER_STEPS", "PROCESSING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESS_TEST = new Field("PROCESS_TEST", "IME_REPORT_ORDER_STEPS", "PROCESS_TEST");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORKSHEET_GENARATION_MODE = new Field("WORKSHEET_GENARATION_MODE", "IME_REPORT_ORDER_STEPS", "WORKSHEET_GENARATION_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BUSINESS_MODE = new Field("BUSINESS_MODE", "IME_REPORT_ORDER_STEPS", "BUSINESS_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM = new Field("RHYTHM", "IME_REPORT_ORDER_STEPS", "RHYTHM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_TYPE = new Field("RHYTHM_TYPE", "IME_REPORT_ORDER_STEPS", "RHYTHM_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_CAN_FINISH = new Field("MATERIAL_CAN_FINISH", "IME_REPORT_ORDER_STEPS", "MATERIAL_CAN_FINISH");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OFFLINE_QTY = new Field("OFFLINE_QTY", "IME_REPORT_ORDER_STEPS", "OFFLINE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ONLINE_QTY = new Field("ONLINE_QTY", "IME_REPORT_ORDER_STEPS", "ONLINE_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FINISH_QTY = new Field("FINISH_QTY", "IME_REPORT_ORDER_STEPS", "FINISH_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STATUS = new Field("STATUS", "IME_REPORT_ORDER_STEPS", "STATUS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_PERSON = new Field("OPERATION_PERSON", "IME_REPORT_ORDER_STEPS", "OPERATION_PERSON");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EXECUTION_PERSON = new Field("EXECUTION_PERSON", "IME_REPORT_ORDER_STEPS", "EXECUTION_PERSON");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_STEP_FINISH_FLAG = new Field("OPERATION_STEP_FINISH_FLAG", "IME_REPORT_ORDER_STEPS", "OPERATION_STEP_FINISH_FLAG");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_COUNT = new Field("RHYTHM_COUNT", "IME_REPORT_ORDER_STEPS", "RHYTHM_COUNT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_REPORT_ORDER_STEPS", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_REPORT_ORDER_STEPS", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_REPORT_ORDER_STEPS", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_REPORT_ORDER_STEPS", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_REPORT_ORDER_STEPS", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_REPORT_ORDER_STEPS", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_REPORT_ORDER_STEPS", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_REPORT_ORDER_STEPS", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_REPORT_ORDER_STEPS", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_REPORT_ORDER_STEPS", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_REPORT_ORDER_STEPS", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_REPORT_ORDER_STEPS", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_REPORT_ORDER_STEPS", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_REPORT_ORDER_STEPS", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_REPORT_ORDER_STEPS", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_REPORT_ORDER_STEPS", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_REPORT_ORDER_STEPS", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_REPORT_ORDER_STEPS", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_REPORT_ORDER_STEPS", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_REPORT_ORDER_STEPS", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_REPORT_ORDER_STEPS", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_REPORT_ORDER_STEPS", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_REPORT_ORDER_STEPS", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_REPORT_ORDER_STEPS", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_REPORT_ORDER_STEPS", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_REPORT_ORDER_STEPS", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_REPORT_ORDER_STEPS", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_REPORT_ORDER_STEPS", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_REPORT_ORDER_STEPS", "UDA20");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROW_NUMBER = new Field("ROW_NUMBER", "IME_REPORT_ORDER_STEPS", "ROW_NUMBER");
        }
        #endregion


    }

}
