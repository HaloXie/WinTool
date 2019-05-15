using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
	/// 实体类BM_ROUTE_OPERATION 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public class BM_ROUTE_OPERATION : Entity
    {
        public BM_ROUTE_OPERATION() : base("BM_ROUTE_OPERATION") { }

        #region Model
        private string _GID;
        private string _BM_WORK_CENTER_GID;
        private string _BM_WORK_LINE_GID;
        private string _BM_WORK_UNIT_GID;
        private string _BM_WORK_STATION_GID;
        private string _PROCESSING_MODE;
        private decimal? _PROCESS_TEST;
        private string _WORKSHEET_GENARATION_MODE;
        private string _BUSINESS_MODE;
        private string _MD_ROUTE_LINE_GID;
        private string _MD_DEF_OPERATION_GID;
        private decimal? _RUNNING_TIME;
        private string _RUNNING_TIME_TYPE;
        private decimal? _PREPARATION_TIME;
        private string _PREPARATION_TIME_TYPE;
        private decimal? _SORT_NUM;
        private decimal? _RHYTHM;
        private string _RHYTHM_TYPE;
        private decimal? _RHYTHM_COUNT;
        private decimal? _MAT_END_POINT;
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
        public string MD_ROUTE_LINE_GID
        {
            get { return _MD_ROUTE_LINE_GID; }
            set
            {
                this.OnPropertyValueChange(_.MD_ROUTE_LINE_GID, _MD_ROUTE_LINE_GID, value);
                this._MD_ROUTE_LINE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MD_DEF_OPERATION_GID
        {
            get { return _MD_DEF_OPERATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.MD_DEF_OPERATION_GID, _MD_DEF_OPERATION_GID, value);
                this._MD_DEF_OPERATION_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? RUNNING_TIME
        {
            get { return _RUNNING_TIME; }
            set
            {
                this.OnPropertyValueChange(_.RUNNING_TIME, _RUNNING_TIME, value);
                this._RUNNING_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RUNNING_TIME_TYPE
        {
            get { return _RUNNING_TIME_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.RUNNING_TIME_TYPE, _RUNNING_TIME_TYPE, value);
                this._RUNNING_TIME_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PREPARATION_TIME
        {
            get { return _PREPARATION_TIME; }
            set
            {
                this.OnPropertyValueChange(_.PREPARATION_TIME, _PREPARATION_TIME, value);
                this._PREPARATION_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PREPARATION_TIME_TYPE
        {
            get { return _PREPARATION_TIME_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.PREPARATION_TIME_TYPE, _PREPARATION_TIME_TYPE, value);
                this._PREPARATION_TIME_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? SORT_NUM
        {
            get { return _SORT_NUM; }
            set
            {
                this.OnPropertyValueChange(_.SORT_NUM, _SORT_NUM, value);
                this._SORT_NUM = value;
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
        public decimal? MAT_END_POINT
        {
            get { return _MAT_END_POINT; }
            set
            {
                this.OnPropertyValueChange(_.MAT_END_POINT, _MAT_END_POINT, value);
                this._MAT_END_POINT = value;
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
                _.BM_WORK_CENTER_GID,
                _.BM_WORK_LINE_GID,
                _.BM_WORK_UNIT_GID,
                _.BM_WORK_STATION_GID,
                _.PROCESSING_MODE,
                _.PROCESS_TEST,
                _.WORKSHEET_GENARATION_MODE,
                _.BUSINESS_MODE,
                _.MD_ROUTE_LINE_GID,
                _.MD_DEF_OPERATION_GID,
                _.RUNNING_TIME,
                _.RUNNING_TIME_TYPE,
                _.PREPARATION_TIME,
                _.PREPARATION_TIME_TYPE,
                _.SORT_NUM,
                _.RHYTHM,
                _.RHYTHM_TYPE,
                _.RHYTHM_COUNT,
                _.MAT_END_POINT,
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
                this._BM_WORK_CENTER_GID,
                this._BM_WORK_LINE_GID,
                this._BM_WORK_UNIT_GID,
                this._BM_WORK_STATION_GID,
                this._PROCESSING_MODE,
                this._PROCESS_TEST,
                this._WORKSHEET_GENARATION_MODE,
                this._BUSINESS_MODE,
                this._MD_ROUTE_LINE_GID,
                this._MD_DEF_OPERATION_GID,
                this._RUNNING_TIME,
                this._RUNNING_TIME_TYPE,
                this._PREPARATION_TIME,
                this._PREPARATION_TIME_TYPE,
                this._SORT_NUM,
                this._RHYTHM,
                this._RHYTHM_TYPE,
                this._RHYTHM_COUNT,
                this._MAT_END_POINT,
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
            this._BM_WORK_CENTER_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_CENTER_GID"]);
            this._BM_WORK_LINE_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_LINE_GID"]);
            this._BM_WORK_UNIT_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_UNIT_GID"]);
            this._BM_WORK_STATION_GID = DataUtils.ConvertValue<string>(reader["BM_WORK_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(reader["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(reader["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(reader["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(reader["BUSINESS_MODE"]);
            this._MD_ROUTE_LINE_GID = DataUtils.ConvertValue<string>(reader["MD_ROUTE_LINE_GID"]);
            this._MD_DEF_OPERATION_GID = DataUtils.ConvertValue<string>(reader["MD_DEF_OPERATION_GID"]);
            this._RUNNING_TIME = DataUtils.ConvertValue<decimal?>(reader["RUNNING_TIME"]);
            this._RUNNING_TIME_TYPE = DataUtils.ConvertValue<string>(reader["RUNNING_TIME_TYPE"]);
            this._PREPARATION_TIME = DataUtils.ConvertValue<decimal?>(reader["PREPARATION_TIME"]);
            this._PREPARATION_TIME_TYPE = DataUtils.ConvertValue<string>(reader["PREPARATION_TIME_TYPE"]);
            this._SORT_NUM = DataUtils.ConvertValue<decimal?>(reader["SORT_NUM"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(reader["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(reader["RHYTHM_TYPE"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(reader["RHYTHM_COUNT"]);
            this._MAT_END_POINT = DataUtils.ConvertValue<decimal?>(reader["MAT_END_POINT"]);
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
            this._BM_WORK_CENTER_GID = DataUtils.ConvertValue<string>(row["BM_WORK_CENTER_GID"]);
            this._BM_WORK_LINE_GID = DataUtils.ConvertValue<string>(row["BM_WORK_LINE_GID"]);
            this._BM_WORK_UNIT_GID = DataUtils.ConvertValue<string>(row["BM_WORK_UNIT_GID"]);
            this._BM_WORK_STATION_GID = DataUtils.ConvertValue<string>(row["BM_WORK_STATION_GID"]);
            this._PROCESSING_MODE = DataUtils.ConvertValue<string>(row["PROCESSING_MODE"]);
            this._PROCESS_TEST = DataUtils.ConvertValue<decimal?>(row["PROCESS_TEST"]);
            this._WORKSHEET_GENARATION_MODE = DataUtils.ConvertValue<string>(row["WORKSHEET_GENARATION_MODE"]);
            this._BUSINESS_MODE = DataUtils.ConvertValue<string>(row["BUSINESS_MODE"]);
            this._MD_ROUTE_LINE_GID = DataUtils.ConvertValue<string>(row["MD_ROUTE_LINE_GID"]);
            this._MD_DEF_OPERATION_GID = DataUtils.ConvertValue<string>(row["MD_DEF_OPERATION_GID"]);
            this._RUNNING_TIME = DataUtils.ConvertValue<decimal?>(row["RUNNING_TIME"]);
            this._RUNNING_TIME_TYPE = DataUtils.ConvertValue<string>(row["RUNNING_TIME_TYPE"]);
            this._PREPARATION_TIME = DataUtils.ConvertValue<decimal?>(row["PREPARATION_TIME"]);
            this._PREPARATION_TIME_TYPE = DataUtils.ConvertValue<string>(row["PREPARATION_TIME_TYPE"]);
            this._SORT_NUM = DataUtils.ConvertValue<decimal?>(row["SORT_NUM"]);
            this._RHYTHM = DataUtils.ConvertValue<decimal?>(row["RHYTHM"]);
            this._RHYTHM_TYPE = DataUtils.ConvertValue<string>(row["RHYTHM_TYPE"]);
            this._RHYTHM_COUNT = DataUtils.ConvertValue<decimal?>(row["RHYTHM_COUNT"]);
            this._MAT_END_POINT = DataUtils.ConvertValue<decimal?>(row["MAT_END_POINT"]);
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
            public readonly static Field All = new Field("*", "BM_ROUTE_OPERATION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "BM_ROUTE_OPERATION", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_CENTER_GID = new Field("BM_WORK_CENTER_GID", "BM_ROUTE_OPERATION", "BM_WORK_CENTER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_LINE_GID = new Field("BM_WORK_LINE_GID", "BM_ROUTE_OPERATION", "BM_WORK_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_UNIT_GID = new Field("BM_WORK_UNIT_GID", "BM_ROUTE_OPERATION", "BM_WORK_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_WORK_STATION_GID = new Field("BM_WORK_STATION_GID", "BM_ROUTE_OPERATION", "BM_WORK_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESSING_MODE = new Field("PROCESSING_MODE", "BM_ROUTE_OPERATION", "PROCESSING_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PROCESS_TEST = new Field("PROCESS_TEST", "BM_ROUTE_OPERATION", "PROCESS_TEST");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORKSHEET_GENARATION_MODE = new Field("WORKSHEET_GENARATION_MODE", "BM_ROUTE_OPERATION", "WORKSHEET_GENARATION_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BUSINESS_MODE = new Field("BUSINESS_MODE", "BM_ROUTE_OPERATION", "BUSINESS_MODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_ROUTE_LINE_GID = new Field("MD_ROUTE_LINE_GID", "BM_ROUTE_OPERATION", "MD_ROUTE_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_DEF_OPERATION_GID = new Field("MD_DEF_OPERATION_GID", "BM_ROUTE_OPERATION", "MD_DEF_OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RUNNING_TIME = new Field("RUNNING_TIME", "BM_ROUTE_OPERATION", "RUNNING_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RUNNING_TIME_TYPE = new Field("RUNNING_TIME_TYPE", "BM_ROUTE_OPERATION", "RUNNING_TIME_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PREPARATION_TIME = new Field("PREPARATION_TIME", "BM_ROUTE_OPERATION", "PREPARATION_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PREPARATION_TIME_TYPE = new Field("PREPARATION_TIME_TYPE", "BM_ROUTE_OPERATION", "PREPARATION_TIME_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SORT_NUM = new Field("SORT_NUM", "BM_ROUTE_OPERATION", "SORT_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM = new Field("RHYTHM", "BM_ROUTE_OPERATION", "RHYTHM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_TYPE = new Field("RHYTHM_TYPE", "BM_ROUTE_OPERATION", "RHYTHM_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field RHYTHM_COUNT = new Field("RHYTHM_COUNT", "BM_ROUTE_OPERATION", "RHYTHM_COUNT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MAT_END_POINT = new Field("MAT_END_POINT", "BM_ROUTE_OPERATION", "MAT_END_POINT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "BM_ROUTE_OPERATION", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BM_ROUTE_OPERATION", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "BM_ROUTE_OPERATION", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "BM_ROUTE_OPERATION", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "BM_ROUTE_OPERATION", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "BM_ROUTE_OPERATION", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "BM_ROUTE_OPERATION", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "BM_ROUTE_OPERATION", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "BM_ROUTE_OPERATION", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "BM_ROUTE_OPERATION", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "BM_ROUTE_OPERATION", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "BM_ROUTE_OPERATION", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "BM_ROUTE_OPERATION", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "BM_ROUTE_OPERATION", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "BM_ROUTE_OPERATION", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "BM_ROUTE_OPERATION", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "BM_ROUTE_OPERATION", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "BM_ROUTE_OPERATION", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "BM_ROUTE_OPERATION", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "BM_ROUTE_OPERATION", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "BM_ROUTE_OPERATION", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "BM_ROUTE_OPERATION", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "BM_ROUTE_OPERATION", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "BM_ROUTE_OPERATION", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "BM_ROUTE_OPERATION", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "BM_ROUTE_OPERATION", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "BM_ROUTE_OPERATION", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "BM_ROUTE_OPERATION", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "BM_ROUTE_OPERATION", "UDA20");
        }
        #endregion


    }

}
