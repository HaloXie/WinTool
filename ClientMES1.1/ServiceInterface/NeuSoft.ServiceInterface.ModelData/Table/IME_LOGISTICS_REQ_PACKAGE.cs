using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_LOGISTICS_REQ_PACKAGE 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_LOGISTICS_REQ_PACKAGE : Entity
    {
        public IME_LOGISTICS_REQ_PACKAGE() : base("IME_LOGISTICS_REQ_PACKAGE") { }

        #region Model
        private string _GID;
        private string _PARENT_GID;
        private string _PACKAGE_SCHEME;
        private string _REQ_ORG;
        private string _OFFER_ORG;
        private string _CODE;
        private string _DESCRIBE;
        private DateTime? _PLAN_TIME;
        private DateTime? _SPECIFIED_TIME;
        private string _PACKAGE_STANDARD;
        private string _STANDARD_UNIT;
        private string _STANDARD_CAP;
        private decimal? _REQ_QTY;
        private string _STATE;
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
        public string PARENT_GID
        {
            get { return _PARENT_GID; }
            set
            {
                this.OnPropertyValueChange(_.PARENT_GID, _PARENT_GID, value);
                this._PARENT_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PACKAGE_SCHEME
        {
            get { return _PACKAGE_SCHEME; }
            set
            {
                this.OnPropertyValueChange(_.PACKAGE_SCHEME, _PACKAGE_SCHEME, value);
                this._PACKAGE_SCHEME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REQ_ORG
        {
            get { return _REQ_ORG; }
            set
            {
                this.OnPropertyValueChange(_.REQ_ORG, _REQ_ORG, value);
                this._REQ_ORG = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OFFER_ORG
        {
            get { return _OFFER_ORG; }
            set
            {
                this.OnPropertyValueChange(_.OFFER_ORG, _OFFER_ORG, value);
                this._OFFER_ORG = value;
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
        public string DESCRIBE
        {
            get { return _DESCRIBE; }
            set
            {
                this.OnPropertyValueChange(_.DESCRIBE, _DESCRIBE, value);
                this._DESCRIBE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? PLAN_TIME
        {
            get { return _PLAN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.PLAN_TIME, _PLAN_TIME, value);
                this._PLAN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? SPECIFIED_TIME
        {
            get { return _SPECIFIED_TIME; }
            set
            {
                this.OnPropertyValueChange(_.SPECIFIED_TIME, _SPECIFIED_TIME, value);
                this._SPECIFIED_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PACKAGE_STANDARD
        {
            get { return _PACKAGE_STANDARD; }
            set
            {
                this.OnPropertyValueChange(_.PACKAGE_STANDARD, _PACKAGE_STANDARD, value);
                this._PACKAGE_STANDARD = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STANDARD_UNIT
        {
            get { return _STANDARD_UNIT; }
            set
            {
                this.OnPropertyValueChange(_.STANDARD_UNIT, _STANDARD_UNIT, value);
                this._STANDARD_UNIT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STANDARD_CAP
        {
            get { return _STANDARD_CAP; }
            set
            {
                this.OnPropertyValueChange(_.STANDARD_CAP, _STANDARD_CAP, value);
                this._STANDARD_CAP = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? REQ_QTY
        {
            get { return _REQ_QTY; }
            set
            {
                this.OnPropertyValueChange(_.REQ_QTY, _REQ_QTY, value);
                this._REQ_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string STATE
        {
            get { return _STATE; }
            set
            {
                this.OnPropertyValueChange(_.STATE, _STATE, value);
                this._STATE = value;
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
                _.PARENT_GID,
                _.PACKAGE_SCHEME,
                _.REQ_ORG,
                _.OFFER_ORG,
                _.CODE,
                _.DESCRIBE,
                _.PLAN_TIME,
                _.SPECIFIED_TIME,
                _.PACKAGE_STANDARD,
                _.STANDARD_UNIT,
                _.STANDARD_CAP,
                _.REQ_QTY,
                _.STATE,
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
                this._PARENT_GID,
                this._PACKAGE_SCHEME,
                this._REQ_ORG,
                this._OFFER_ORG,
                this._CODE,
                this._DESCRIBE,
                this._PLAN_TIME,
                this._SPECIFIED_TIME,
                this._PACKAGE_STANDARD,
                this._STANDARD_UNIT,
                this._STANDARD_CAP,
                this._REQ_QTY,
                this._STATE,
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
            this._PARENT_GID = DataUtils.ConvertValue<string>(reader["PARENT_GID"]);
            this._PACKAGE_SCHEME = DataUtils.ConvertValue<string>(reader["PACKAGE_SCHEME"]);
            this._REQ_ORG = DataUtils.ConvertValue<string>(reader["REQ_ORG"]);
            this._OFFER_ORG = DataUtils.ConvertValue<string>(reader["OFFER_ORG"]);
            this._CODE = DataUtils.ConvertValue<string>(reader["CODE"]);
            this._DESCRIBE = DataUtils.ConvertValue<string>(reader["DESCRIBE"]);
            this._PLAN_TIME = DataUtils.ConvertValue<DateTime?>(reader["PLAN_TIME"]);
            this._SPECIFIED_TIME = DataUtils.ConvertValue<DateTime?>(reader["SPECIFIED_TIME"]);
            this._PACKAGE_STANDARD = DataUtils.ConvertValue<string>(reader["PACKAGE_STANDARD"]);
            this._STANDARD_UNIT = DataUtils.ConvertValue<string>(reader["STANDARD_UNIT"]);
            this._STANDARD_CAP = DataUtils.ConvertValue<string>(reader["STANDARD_CAP"]);
            this._REQ_QTY = DataUtils.ConvertValue<decimal?>(reader["REQ_QTY"]);
            this._STATE = DataUtils.ConvertValue<string>(reader["STATE"]);
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
            this._PARENT_GID = DataUtils.ConvertValue<string>(row["PARENT_GID"]);
            this._PACKAGE_SCHEME = DataUtils.ConvertValue<string>(row["PACKAGE_SCHEME"]);
            this._REQ_ORG = DataUtils.ConvertValue<string>(row["REQ_ORG"]);
            this._OFFER_ORG = DataUtils.ConvertValue<string>(row["OFFER_ORG"]);
            this._CODE = DataUtils.ConvertValue<string>(row["CODE"]);
            this._DESCRIBE = DataUtils.ConvertValue<string>(row["DESCRIBE"]);
            this._PLAN_TIME = DataUtils.ConvertValue<DateTime?>(row["PLAN_TIME"]);
            this._SPECIFIED_TIME = DataUtils.ConvertValue<DateTime?>(row["SPECIFIED_TIME"]);
            this._PACKAGE_STANDARD = DataUtils.ConvertValue<string>(row["PACKAGE_STANDARD"]);
            this._STANDARD_UNIT = DataUtils.ConvertValue<string>(row["STANDARD_UNIT"]);
            this._STANDARD_CAP = DataUtils.ConvertValue<string>(row["STANDARD_CAP"]);
            this._REQ_QTY = DataUtils.ConvertValue<decimal?>(row["REQ_QTY"]);
            this._STATE = DataUtils.ConvertValue<string>(row["STATE"]);
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
            public readonly static Field All = new Field("*", "IME_LOGISTICS_REQ_PACKAGE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_LOGISTICS_REQ_PACKAGE", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PARENT_GID = new Field("PARENT_GID", "IME_LOGISTICS_REQ_PACKAGE", "PARENT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACKAGE_SCHEME = new Field("PACKAGE_SCHEME", "IME_LOGISTICS_REQ_PACKAGE", "PACKAGE_SCHEME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REQ_ORG = new Field("REQ_ORG", "IME_LOGISTICS_REQ_PACKAGE", "REQ_ORG");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field OFFER_ORG = new Field("OFFER_ORG", "IME_LOGISTICS_REQ_PACKAGE", "OFFER_ORG");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CODE = new Field("CODE", "IME_LOGISTICS_REQ_PACKAGE", "CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DESCRIBE = new Field("DESCRIBE", "IME_LOGISTICS_REQ_PACKAGE", "DESCRIBE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_TIME = new Field("PLAN_TIME", "IME_LOGISTICS_REQ_PACKAGE", "PLAN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SPECIFIED_TIME = new Field("SPECIFIED_TIME", "IME_LOGISTICS_REQ_PACKAGE", "SPECIFIED_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACKAGE_STANDARD = new Field("PACKAGE_STANDARD", "IME_LOGISTICS_REQ_PACKAGE", "PACKAGE_STANDARD");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STANDARD_UNIT = new Field("STANDARD_UNIT", "IME_LOGISTICS_REQ_PACKAGE", "STANDARD_UNIT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STANDARD_CAP = new Field("STANDARD_CAP", "IME_LOGISTICS_REQ_PACKAGE", "STANDARD_CAP");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REQ_QTY = new Field("REQ_QTY", "IME_LOGISTICS_REQ_PACKAGE", "REQ_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field STATE = new Field("STATE", "IME_LOGISTICS_REQ_PACKAGE", "STATE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_LOGISTICS_REQ_PACKAGE", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_LOGISTICS_REQ_PACKAGE", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_LOGISTICS_REQ_PACKAGE", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_LOGISTICS_REQ_PACKAGE", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_LOGISTICS_REQ_PACKAGE", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_LOGISTICS_REQ_PACKAGE", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_LOGISTICS_REQ_PACKAGE", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_LOGISTICS_REQ_PACKAGE", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_LOGISTICS_REQ_PACKAGE", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_LOGISTICS_REQ_PACKAGE", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_LOGISTICS_REQ_PACKAGE", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_LOGISTICS_REQ_PACKAGE", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_LOGISTICS_REQ_PACKAGE", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_LOGISTICS_REQ_PACKAGE", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_LOGISTICS_REQ_PACKAGE", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_LOGISTICS_REQ_PACKAGE", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_LOGISTICS_REQ_PACKAGE", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_LOGISTICS_REQ_PACKAGE", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_LOGISTICS_REQ_PACKAGE", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_LOGISTICS_REQ_PACKAGE", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_LOGISTICS_REQ_PACKAGE", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_LOGISTICS_REQ_PACKAGE", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_LOGISTICS_REQ_PACKAGE", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_LOGISTICS_REQ_PACKAGE", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_LOGISTICS_REQ_PACKAGE", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_LOGISTICS_REQ_PACKAGE", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_LOGISTICS_REQ_PACKAGE", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_LOGISTICS_REQ_PACKAGE", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_LOGISTICS_REQ_PACKAGE", "UDA20");
        }
        #endregion


    }

}
