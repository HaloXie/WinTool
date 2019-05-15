using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类BM_STEP_INFO 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class BM_STEP_INFO : Entity
    {
        public BM_STEP_INFO() : base("BM_STEP_INFO") { }

        #region Model
        private string _GID;
        private string _STEP_NAME;
        private string _STEP_CODE;
        private decimal? _STEP_RHYTHM;
        private string _STEP_RHYTHM_TYPE;
        private string _STEP_TYPE;
        private string _BM_WORK_CENTER_GID;
        private string _BM_WORK_LINE_GID;
        private string _BM_WORK_UNIT_GID;
        private string _BM_WORK_STATION_GID;
        private string _PROCESSING_MODE;
        private decimal? _PROCESS_TEST;
        private string _WORKSHEET_GENARATION_MODE;
        private string _BUSINESS_MODE;
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
        public string STEP_NAME
        {
            get { return _STEP_NAME; }
            set
            {
                this.OnPropertyValueChange(_.STEP_NAME, _STEP_NAME, value);
                this._STEP_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STEP_CODE
        {
            get { return _STEP_CODE; }
            set
            {
                this.OnPropertyValueChange(_.STEP_CODE, _STEP_CODE, value);
                this._STEP_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? STEP_RHYTHM
        {
            get { return _STEP_RHYTHM; }
            set
            {
                this.OnPropertyValueChange(_.STEP_RHYTHM, _STEP_RHYTHM, value);
                this._STEP_RHYTHM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STEP_RHYTHM_TYPE
        {
            get { return _STEP_RHYTHM_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.STEP_RHYTHM_TYPE, _STEP_RHYTHM_TYPE, value);
                this._STEP_RHYTHM_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STEP_TYPE
        {
            get { return _STEP_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.STEP_TYPE, _STEP_TYPE, value);
                this._STEP_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_WORK_CENTER_GID
        {
            get { return _BM_WORK_CENTER_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_WORK_CENTER_GID, _BM_WORK_CENTER_GID, value);
                this._BM_WORK_CENTER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_WORK_LINE_GID
        {
            get { return _BM_WORK_LINE_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_WORK_LINE_GID, _BM_WORK_LINE_GID, value);
                this._BM_WORK_LINE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_WORK_UNIT_GID
        {
            get { return _BM_WORK_UNIT_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_WORK_UNIT_GID, _BM_WORK_UNIT_GID, value);
                this._BM_WORK_UNIT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_WORK_STATION_GID
        {
            get { return _BM_WORK_STATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_WORK_STATION_GID, _BM_WORK_STATION_GID, value);
                this._BM_WORK_STATION_GID = value;
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
                _.STEP_NAME,
                _.STEP_CODE,
                _.STEP_RHYTHM,
                _.STEP_RHYTHM_TYPE,
                _.STEP_TYPE,
                _.BM_WORK_CENTER_GID,
                _.BM_WORK_LINE_GID,
                _.BM_WORK_UNIT_GID,
                _.BM_WORK_STATION_GID,
                _.PROCESSING_MODE,
                _.PROCESS_TEST,
                _.WORKSHEET_GENARATION_MODE,
                _.BUSINESS_MODE,
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
                this._STEP_NAME,
                this._STEP_CODE,
                this._STEP_RHYTHM,
                this._STEP_RHYTHM_TYPE,
                this._STEP_TYPE,
                this._BM_WORK_CENTER_GID,
                this._BM_WORK_LINE_GID,
                this._BM_WORK_UNIT_GID,
                this._BM_WORK_STATION_GID,
                this._PROCESSING_MODE,
                this._PROCESS_TEST,
                this._WORKSHEET_GENARATION_MODE,
                this._BUSINESS_MODE,
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
            this._STEP_NAME = DataUtils.ConvertValue<string>(reader["STEP_NAME"]);
            this._STEP_CODE = DataUtils.ConvertValue<string>(reader["STEP_CODE"]);
            this._STEP_RHYTHM = DataUtils.ConvertValue<decimal?>(reader["STEP_RHYTHM"]);
            this._STEP_RHYTHM_TYPE = DataUtils.ConvertValue<string>(reader["STEP_RHYTHM_TYPE"]);
            this._STEP_TYPE = DataUtils.ConvertValue<string>(reader["STEP_TYPE"]);
            this._BM_WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_CENTER_GID"]);
            this._BM_WORK_LINE_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_LINE_GID"]);
            this._BM_WORK_UNIT_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_UNIT_GID"]);
            this._BM_WORK_STATION_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(reader["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(reader["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(reader["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(reader["BUSINESS_MODE"]);
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
            this._STEP_NAME = DataUtils.ConvertValue<string>(row["STEP_NAME"]);
            this._STEP_CODE = DataUtils.ConvertValue<string>(row["STEP_CODE"]);
            this._STEP_RHYTHM = DataUtils.ConvertValue<decimal?>(row["STEP_RHYTHM"]);
            this._STEP_RHYTHM_TYPE = DataUtils.ConvertValue<string>(row["STEP_RHYTHM_TYPE"]);
            this._STEP_TYPE = DataUtils.ConvertValue<string>(row["STEP_TYPE"]);
            this._BM_WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["BM_WORK_CENTER_GID"]);
            this._BM_WORK_LINE_GID = DataUtils.ConvertValue<string>(row["BM_WORK_LINE_GID"]);
            this._BM_WORK_UNIT_GID = DataUtils.ConvertValue<string>(row["BM_WORK_UNIT_GID"]);
            this._BM_WORK_STATION_GID = DataUtils.ConvertValue<string>(row["BM_WORK_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(row["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(row["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(row["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(row["BUSINESS_MODE"]);
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
            public readonly static Field All = new Field("*", "BM_STEP_INFO");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "BM_STEP_INFO", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEP_NAME = new Field("STEP_NAME", "BM_STEP_INFO", "STEP_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEP_CODE = new Field("STEP_CODE", "BM_STEP_INFO", "STEP_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEP_RHYTHM = new Field("STEP_RHYTHM", "BM_STEP_INFO", "STEP_RHYTHM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEP_RHYTHM_TYPE = new Field("STEP_RHYTHM_TYPE", "BM_STEP_INFO", "STEP_RHYTHM_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STEP_TYPE = new Field("STEP_TYPE", "BM_STEP_INFO", "STEP_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_CENTER_GID = new Field("BM_WORK_CENTER_GID", "BM_STEP_INFO", "BM_WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_LINE_GID = new Field("BM_WORK_LINE_GID", "BM_STEP_INFO", "BM_WORK_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_UNIT_GID = new Field("BM_WORK_UNIT_GID", "BM_STEP_INFO", "BM_WORK_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_STATION_GID = new Field("BM_WORK_STATION_GID", "BM_STEP_INFO", "BM_WORK_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESSING_MODE = new Field("PROCESSING_MODE", "BM_STEP_INFO", "PROCESSING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESS_TEST = new Field("PROCESS_TEST", "BM_STEP_INFO", "PROCESS_TEST");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORKSHEET_GENARATION_MODE = new Field("WORKSHEET_GENARATION_MODE", "BM_STEP_INFO", "WORKSHEET_GENARATION_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BUSINESS_MODE = new Field("BUSINESS_MODE", "BM_STEP_INFO", "BUSINESS_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "BM_STEP_INFO", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BM_STEP_INFO", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "BM_STEP_INFO", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "BM_STEP_INFO", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "BM_STEP_INFO", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "BM_STEP_INFO", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "BM_STEP_INFO", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "BM_STEP_INFO", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "BM_STEP_INFO", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "BM_STEP_INFO", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "BM_STEP_INFO", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "BM_STEP_INFO", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "BM_STEP_INFO", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "BM_STEP_INFO", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "BM_STEP_INFO", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "BM_STEP_INFO", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "BM_STEP_INFO", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "BM_STEP_INFO", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "BM_STEP_INFO", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "BM_STEP_INFO", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "BM_STEP_INFO", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "BM_STEP_INFO", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "BM_STEP_INFO", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "BM_STEP_INFO", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "BM_STEP_INFO", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "BM_STEP_INFO", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "BM_STEP_INFO", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "BM_STEP_INFO", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "BM_STEP_INFO", "UDA20");
        }
        #endregion


    }

}
