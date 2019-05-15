using Dos.ORM;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_QC_QAC_RECORD_CHECKCARD 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_QC_QAC_RECORD_CHECKCARD : Entity
    {
        public IME_QC_QAC_RECORD_CHECKCARD() : base("IME_QC_QAC_RECORD_CHECKCARD") { }

        #region Model
        private string _GID;
        private string _CHECK_RESULT;
        private string _INDEX_TYPE;
        private string _IS_OK;
        private string _IME_QC_QAC_RECORD_GID;
        private string _IME_QC_QAC_RECORD_CODE;
        private string _IME_QC_QAC_BILL_GID;
        private string _IME_QC_QAC_BILL_CODE;
        private string _IME_QC_QAC_GID;
        private string _IME_QC_QAC_CODE;
        private string _IME_QC_QAC_BILL_DETAIL_GID;
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
        public string CHECK_RESULT
        {
            get { return _CHECK_RESULT; }
            set
            {
                this.OnPropertyValueChange(_.CHECK_RESULT, _CHECK_RESULT, value);
                this._CHECK_RESULT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string INDEX_TYPE
        {
            get { return _INDEX_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.INDEX_TYPE, _INDEX_TYPE, value);
                this._INDEX_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IS_OK
        {
            get { return _IS_OK; }
            set
            {
                this.OnPropertyValueChange(_.IS_OK, _IS_OK, value);
                this._IS_OK = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_RECORD_GID
        {
            get { return _IME_QC_QAC_RECORD_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_RECORD_GID, _IME_QC_QAC_RECORD_GID, value);
                this._IME_QC_QAC_RECORD_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_RECORD_CODE
        {
            get { return _IME_QC_QAC_RECORD_CODE; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_RECORD_CODE, _IME_QC_QAC_RECORD_CODE, value);
                this._IME_QC_QAC_RECORD_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_BILL_GID
        {
            get { return _IME_QC_QAC_BILL_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_BILL_GID, _IME_QC_QAC_BILL_GID, value);
                this._IME_QC_QAC_BILL_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_BILL_CODE
        {
            get { return _IME_QC_QAC_BILL_CODE; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_BILL_CODE, _IME_QC_QAC_BILL_CODE, value);
                this._IME_QC_QAC_BILL_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_GID
        {
            get { return _IME_QC_QAC_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_GID, _IME_QC_QAC_GID, value);
                this._IME_QC_QAC_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_CODE
        {
            get { return _IME_QC_QAC_CODE; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_CODE, _IME_QC_QAC_CODE, value);
                this._IME_QC_QAC_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_QC_QAC_BILL_DETAIL_GID
        {
            get { return _IME_QC_QAC_BILL_DETAIL_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_QC_QAC_BILL_DETAIL_GID, _IME_QC_QAC_BILL_DETAIL_GID, value);
                this._IME_QC_QAC_BILL_DETAIL_GID = value;
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
                _.CHECK_RESULT,
                _.INDEX_TYPE,
                _.IS_OK,
                _.IME_QC_QAC_RECORD_GID,
                _.IME_QC_QAC_RECORD_CODE,
                _.IME_QC_QAC_BILL_GID,
                _.IME_QC_QAC_BILL_CODE,
                _.IME_QC_QAC_GID,
                _.IME_QC_QAC_CODE,
                _.IME_QC_QAC_BILL_DETAIL_GID,
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
                this._CHECK_RESULT,
                this._INDEX_TYPE,
                this._IS_OK,
                this._IME_QC_QAC_RECORD_GID,
                this._IME_QC_QAC_RECORD_CODE,
                this._IME_QC_QAC_BILL_GID,
                this._IME_QC_QAC_BILL_CODE,
                this._IME_QC_QAC_GID,
                this._IME_QC_QAC_CODE,
                this._IME_QC_QAC_BILL_DETAIL_GID,
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
            this._CHECK_RESULT = DataUtils.ConvertValue<string>(reader["CHECK_RESULT"]);
            this._INDEX_TYPE = DataUtils.ConvertValue<string>(reader["INDEX_TYPE"]);
            this._IS_OK = DataUtils.ConvertValue<string>(reader["IS_OK"]);
            this._IME_QC_QAC_RECORD_GID = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_RECORD_GID"]);
            this._IME_QC_QAC_RECORD_CODE = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_RECORD_CODE"]);
            this._IME_QC_QAC_BILL_GID = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_BILL_GID"]);
            this._IME_QC_QAC_BILL_CODE = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_BILL_CODE"]);
            this._IME_QC_QAC_GID = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_GID"]);
            this._IME_QC_QAC_CODE = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_CODE"]);
            this._IME_QC_QAC_BILL_DETAIL_GID = DataUtils.ConvertValue<string>(reader["IME_QC_QAC_BILL_DETAIL_GID"]);
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
            this._CHECK_RESULT = DataUtils.ConvertValue<string>(row["CHECK_RESULT"]);
            this._INDEX_TYPE = DataUtils.ConvertValue<string>(row["INDEX_TYPE"]);
            this._IS_OK = DataUtils.ConvertValue<string>(row["IS_OK"]);
            this._IME_QC_QAC_RECORD_GID = DataUtils.ConvertValue<string>(row["IME_QC_QAC_RECORD_GID"]);
            this._IME_QC_QAC_RECORD_CODE = DataUtils.ConvertValue<string>(row["IME_QC_QAC_RECORD_CODE"]);
            this._IME_QC_QAC_BILL_GID = DataUtils.ConvertValue<string>(row["IME_QC_QAC_BILL_GID"]);
            this._IME_QC_QAC_BILL_CODE = DataUtils.ConvertValue<string>(row["IME_QC_QAC_BILL_CODE"]);
            this._IME_QC_QAC_GID = DataUtils.ConvertValue<string>(row["IME_QC_QAC_GID"]);
            this._IME_QC_QAC_CODE = DataUtils.ConvertValue<string>(row["IME_QC_QAC_CODE"]);
            this._IME_QC_QAC_BILL_DETAIL_GID = DataUtils.ConvertValue<string>(row["IME_QC_QAC_BILL_DETAIL_GID"]);
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
            public readonly static Field All = new Field("*", "IME_QC_QAC_RECORD_CHECKCARD");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_QC_QAC_RECORD_CHECKCARD", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CHECK_RESULT = new Field("CHECK_RESULT", "IME_QC_QAC_RECORD_CHECKCARD", "CHECK_RESULT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field INDEX_TYPE = new Field("INDEX_TYPE", "IME_QC_QAC_RECORD_CHECKCARD", "INDEX_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_OK = new Field("IS_OK", "IME_QC_QAC_RECORD_CHECKCARD", "IS_OK");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_RECORD_GID = new Field("IME_QC_QAC_RECORD_GID", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_RECORD_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_RECORD_CODE = new Field("IME_QC_QAC_RECORD_CODE", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_RECORD_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_BILL_GID = new Field("IME_QC_QAC_BILL_GID", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_BILL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_BILL_CODE = new Field("IME_QC_QAC_BILL_CODE", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_BILL_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_GID = new Field("IME_QC_QAC_GID", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_CODE = new Field("IME_QC_QAC_CODE", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_QC_QAC_BILL_DETAIL_GID = new Field("IME_QC_QAC_BILL_DETAIL_GID", "IME_QC_QAC_RECORD_CHECKCARD", "IME_QC_QAC_BILL_DETAIL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_QC_QAC_RECORD_CHECKCARD", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_QC_QAC_RECORD_CHECKCARD", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_QC_QAC_RECORD_CHECKCARD", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_QC_QAC_RECORD_CHECKCARD", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_QC_QAC_RECORD_CHECKCARD", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_QC_QAC_RECORD_CHECKCARD", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_QC_QAC_RECORD_CHECKCARD", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_QC_QAC_RECORD_CHECKCARD", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_QC_QAC_RECORD_CHECKCARD", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_QC_QAC_RECORD_CHECKCARD", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_QC_QAC_RECORD_CHECKCARD", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_QC_QAC_RECORD_CHECKCARD", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_QC_QAC_RECORD_CHECKCARD", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_QC_QAC_RECORD_CHECKCARD", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_QC_QAC_RECORD_CHECKCARD", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_QC_QAC_RECORD_CHECKCARD", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_QC_QAC_RECORD_CHECKCARD", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_QC_QAC_RECORD_CHECKCARD", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_QC_QAC_RECORD_CHECKCARD", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_QC_QAC_RECORD_CHECKCARD", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_QC_QAC_RECORD_CHECKCARD", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_QC_QAC_RECORD_CHECKCARD", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_QC_QAC_RECORD_CHECKCARD", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_QC_QAC_RECORD_CHECKCARD", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_QC_QAC_RECORD_CHECKCARD", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_QC_QAC_RECORD_CHECKCARD", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_QC_QAC_RECORD_CHECKCARD", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_QC_QAC_RECORD_CHECKCARD", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_QC_QAC_RECORD_CHECKCARD", "UDA20");
        }
        #endregion


    }

}
