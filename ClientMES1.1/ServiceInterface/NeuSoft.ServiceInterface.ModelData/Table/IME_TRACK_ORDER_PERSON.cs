using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_TRACK_ORDER_PERSON 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_TRACK_ORDER_PERSON : Entity
    {
        public IME_TRACK_ORDER_PERSON() : base("IME_TRACK_ORDER_PERSON") { }

        #region Model
        private string _GID;
        private string _WORK_ORDER_GID;
        private string _TRACK_ORDER_GID;
        private string _OPERATION_GID;
        private string _STEPS_GID;
        private string _PERSON_GID;
        private string _FACTORY_STATION_GID;
        private string _WORK_CENTER_GID;
        private string _FACTORY_LINE_GID;
        private string _WORK_UNIT_GID;
        private string _PROCESSING_MODE;
        private string _EQUIPMENT_GID;
        private decimal? _PERSON_NUMBER;
        private decimal? _PERSON_CAPACITY_EFFECTIVE;
        private decimal? _TOTAL_EFFECTIVE;
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
        public string WORK_ORDER_GID
        {
            get { return _WORK_ORDER_GID; }
            set
            {
                this.OnPropertyValueChange(_.WORK_ORDER_GID, _WORK_ORDER_GID, value);
                this._WORK_ORDER_GID = value;
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
        public string STEPS_GID
        {
            get { return _STEPS_GID; }
            set
            {
                this.OnPropertyValueChange(_.STEPS_GID, _STEPS_GID, value);
                this._STEPS_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PERSON_GID
        {
            get { return _PERSON_GID; }
            set
            {
                this.OnPropertyValueChange(_.PERSON_GID, _PERSON_GID, value);
                this._PERSON_GID = value;
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
        public string EQUIPMENT_GID
        {
            get { return _EQUIPMENT_GID; }
            set
            {
                this.OnPropertyValueChange(_.EQUIPMENT_GID, _EQUIPMENT_GID, value);
                this._EQUIPMENT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PERSON_NUMBER
        {
            get { return _PERSON_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.PERSON_NUMBER, _PERSON_NUMBER, value);
                this._PERSON_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PERSON_CAPACITY_EFFECTIVE
        {
            get { return _PERSON_CAPACITY_EFFECTIVE; }
            set
            {
                this.OnPropertyValueChange(_.PERSON_CAPACITY_EFFECTIVE, _PERSON_CAPACITY_EFFECTIVE, value);
                this._PERSON_CAPACITY_EFFECTIVE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? TOTAL_EFFECTIVE
        {
            get { return _TOTAL_EFFECTIVE; }
            set
            {
                this.OnPropertyValueChange(_.TOTAL_EFFECTIVE, _TOTAL_EFFECTIVE, value);
                this._TOTAL_EFFECTIVE = value;
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
                _.WORK_ORDER_GID,
                _.TRACK_ORDER_GID,
                _.OPERATION_GID,
                _.STEPS_GID,
                _.PERSON_GID,
                _.FACTORY_STATION_GID,
                _.WORK_CENTER_GID,
                _.FACTORY_LINE_GID,
                _.WORK_UNIT_GID,
                _.PROCESSING_MODE,
                _.EQUIPMENT_GID,
                _.PERSON_NUMBER,
                _.PERSON_CAPACITY_EFFECTIVE,
                _.TOTAL_EFFECTIVE,
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
                _.UDA20};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GID,
                this._WORK_ORDER_GID,
                this._TRACK_ORDER_GID,
                this._OPERATION_GID,
                this._STEPS_GID,
                this._PERSON_GID,
                this._FACTORY_STATION_GID,
                this._WORK_CENTER_GID,
                this._FACTORY_LINE_GID,
                this._WORK_UNIT_GID,
                this._PROCESSING_MODE,
                this._EQUIPMENT_GID,
                this._PERSON_NUMBER,
                this._PERSON_CAPACITY_EFFECTIVE,
                this._TOTAL_EFFECTIVE,
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
                this._UDA20};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._GID = DataUtils.ConvertValue<string>(reader["GID"]);
            this._WORK_ORDER_GID = DataUtils.ConvertValue<string>(reader["WORK_ORDER_GID"]);
            this._TRACK_ORDER_GID = DataUtils.ConvertValue<string>(reader["TRACK_ORDER_GID"]);
            this._OPERATION_GID = DataUtils.ConvertValue<string>(reader["OPERATION_GID"]);
            this._STEPS_GID = DataUtils.ConvertValue<string>(reader["STEPS_GID"]);
            this._PERSON_GID = DataUtils.ConvertValue<string>(reader["PERSON_GID"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(reader["FACTORY_STATION_GID"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(reader["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(reader["WORK_UNIT_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(reader["PROCESSING_MODE"]);
            this._EQUIPMENT_GID = DataUtils.ConvertValue<string>(reader["EQUIPMENT_GID"]);
            this._PERSON_NUMBER = DataUtils.ConvertValue<decimal?>(reader["PERSON_NUMBER"]);
            this._PERSON_CAPACITY_EFFECTIVE = DataUtils.ConvertValue<decimal?>(reader["PERSON_CAPACITY_EFFECTIVE"]);
            this._TOTAL_EFFECTIVE = DataUtils.ConvertValue<decimal?>(reader["TOTAL_EFFECTIVE"]);
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
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._GID = DataUtils.ConvertValue<string>(row["GID"]);
            this._WORK_ORDER_GID = DataUtils.ConvertValue<string>(row["WORK_ORDER_GID"]);
            this._TRACK_ORDER_GID = DataUtils.ConvertValue<string>(row["TRACK_ORDER_GID"]);
            this._OPERATION_GID = DataUtils.ConvertValue<string>(row["OPERATION_GID"]);
            this._STEPS_GID = DataUtils.ConvertValue<string>(row["STEPS_GID"]);
            this._PERSON_GID = DataUtils.ConvertValue<string>(row["PERSON_GID"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(row["FACTORY_STATION_GID"]);
            this._WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["WORK_CENTER_GID"]);
            this._FACTORY_LINE_GID = DataUtils.ConvertValue<string>(row["FACTORY_LINE_GID"]);
            this._WORK_UNIT_GID = DataUtils.ConvertValue<string>(row["WORK_UNIT_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(row["PROCESSING_MODE"]);
            this._EQUIPMENT_GID = DataUtils.ConvertValue<string>(row["EQUIPMENT_GID"]);
            this._PERSON_NUMBER = DataUtils.ConvertValue<decimal?>(row["PERSON_NUMBER"]);
            this._PERSON_CAPACITY_EFFECTIVE = DataUtils.ConvertValue<decimal?>(row["PERSON_CAPACITY_EFFECTIVE"]);
            this._TOTAL_EFFECTIVE = DataUtils.ConvertValue<decimal?>(row["TOTAL_EFFECTIVE"]);
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
            public readonly static Field All = new Field("*", "IME_TRACK_ORDER_PERSON");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_TRACK_ORDER_PERSON", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_ORDER_GID = new Field("WORK_ORDER_GID", "IME_TRACK_ORDER_PERSON", "WORK_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TRACK_ORDER_GID = new Field("TRACK_ORDER_GID", "IME_TRACK_ORDER_PERSON", "TRACK_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OPERATION_GID = new Field("OPERATION_GID", "IME_TRACK_ORDER_PERSON", "OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEPS_GID = new Field("STEPS_GID", "IME_TRACK_ORDER_PERSON", "STEPS_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PERSON_GID = new Field("PERSON_GID", "IME_TRACK_ORDER_PERSON", "PERSON_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_STATION_GID = new Field("FACTORY_STATION_GID", "IME_TRACK_ORDER_PERSON", "FACTORY_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_CENTER_GID = new Field("WORK_CENTER_GID", "IME_TRACK_ORDER_PERSON", "WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_LINE_GID = new Field("FACTORY_LINE_GID", "IME_TRACK_ORDER_PERSON", "FACTORY_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_UNIT_GID = new Field("WORK_UNIT_GID", "IME_TRACK_ORDER_PERSON", "WORK_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESSING_MODE = new Field("PROCESSING_MODE", "IME_TRACK_ORDER_PERSON", "PROCESSING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field EQUIPMENT_GID = new Field("EQUIPMENT_GID", "IME_TRACK_ORDER_PERSON", "EQUIPMENT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PERSON_NUMBER = new Field("PERSON_NUMBER", "IME_TRACK_ORDER_PERSON", "PERSON_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PERSON_CAPACITY_EFFECTIVE = new Field("PERSON_CAPACITY_EFFECTIVE", "IME_TRACK_ORDER_PERSON", "PERSON_CAPACITY_EFFECTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TOTAL_EFFECTIVE = new Field("TOTAL_EFFECTIVE", "IME_TRACK_ORDER_PERSON", "TOTAL_EFFECTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_TRACK_ORDER_PERSON", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_TRACK_ORDER_PERSON", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_TRACK_ORDER_PERSON", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_TRACK_ORDER_PERSON", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_TRACK_ORDER_PERSON", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_TRACK_ORDER_PERSON", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_TRACK_ORDER_PERSON", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_TRACK_ORDER_PERSON", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_TRACK_ORDER_PERSON", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_TRACK_ORDER_PERSON", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_TRACK_ORDER_PERSON", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_TRACK_ORDER_PERSON", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_TRACK_ORDER_PERSON", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_TRACK_ORDER_PERSON", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_TRACK_ORDER_PERSON", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_TRACK_ORDER_PERSON", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_TRACK_ORDER_PERSON", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_TRACK_ORDER_PERSON", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_TRACK_ORDER_PERSON", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_TRACK_ORDER_PERSON", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_TRACK_ORDER_PERSON", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_TRACK_ORDER_PERSON", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_TRACK_ORDER_PERSON", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_TRACK_ORDER_PERSON", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_TRACK_ORDER_PERSON", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_TRACK_ORDER_PERSON", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_TRACK_ORDER_PERSON", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_TRACK_ORDER_PERSON", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_TRACK_ORDER_PERSON", "UDA20");
        }
        #endregion


    }

}
