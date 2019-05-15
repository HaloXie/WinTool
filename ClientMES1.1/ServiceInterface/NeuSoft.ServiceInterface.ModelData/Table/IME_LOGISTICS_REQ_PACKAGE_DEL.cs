using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类IME_LOGISTICS_REQ_PACKAGE_DEL 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class IME_LOGISTICS_REQ_PACKAGE_DEL : Entity
    {
        public IME_LOGISTICS_REQ_PACKAGE_DEL() : base("IME_LOGISTICS_REQ_PACKAGE_DEL") { }

        #region Model
        private string _GID;
        private string _PACK_GROUP_GID;
        private string _REQ_PACKAGE_GID;
        private string _MATERIAL_REQ_GID;
        private string _MATERIAL_CODE;
        private string _MATERIAL_NAME;
        private string _MATERIAL_UNIT;
        private decimal? _PLAN_QTY;
        private decimal? _REQ_QTY;
        private string _MATERIAL_GID;
        private decimal? _PACK_QTY;
        private DateTime? _PLAN_TIME;
        private DateTime? _SPECIFIED_TIME;
        private string _FACTORY_WORK_STATION;
        private decimal? _PACK_NUM;
        private string _ROUTE_OPEARTION_GID;
        private string _IME_PLAN_ORDER_GID;
        private string _IME_WORK_ORDER_GID;
        private string _ORDER_SEQ;
        private string _PRODUCT_SEQ;
        private string _BM_PRODUCTINFO_GID;
        private string _GENERATE_WAVE;
        private string _REMARKS;
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
        private string _COMBINATION_STANDARD;
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
        public string PACK_GROUP_GID
        {
            get { return _PACK_GROUP_GID; }
            set
            {
                this.OnPropertyValueChange(_.PACK_GROUP_GID, _PACK_GROUP_GID, value);
                this._PACK_GROUP_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REQ_PACKAGE_GID
        {
            get { return _REQ_PACKAGE_GID; }
            set
            {
                this.OnPropertyValueChange(_.REQ_PACKAGE_GID, _REQ_PACKAGE_GID, value);
                this._REQ_PACKAGE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_REQ_GID
        {
            get { return _MATERIAL_REQ_GID; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_REQ_GID, _MATERIAL_REQ_GID, value);
                this._MATERIAL_REQ_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_CODE
        {
            get { return _MATERIAL_CODE; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_CODE, _MATERIAL_CODE, value);
                this._MATERIAL_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_NAME
        {
            get { return _MATERIAL_NAME; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_NAME, _MATERIAL_NAME, value);
                this._MATERIAL_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MATERIAL_UNIT
        {
            get { return _MATERIAL_UNIT; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_UNIT, _MATERIAL_UNIT, value);
                this._MATERIAL_UNIT = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PLAN_QTY
        {
            get { return _PLAN_QTY; }
            set
            {
                this.OnPropertyValueChange(_.PLAN_QTY, _PLAN_QTY, value);
                this._PLAN_QTY = value;
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
        public decimal? PACK_QTY
        {
            get { return _PACK_QTY; }
            set
            {
                this.OnPropertyValueChange(_.PACK_QTY, _PACK_QTY, value);
                this._PACK_QTY = value;
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
        public string FACTORY_WORK_STATION
        {
            get { return _FACTORY_WORK_STATION; }
            set
            {
                this.OnPropertyValueChange(_.FACTORY_WORK_STATION, _FACTORY_WORK_STATION, value);
                this._FACTORY_WORK_STATION = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PACK_NUM
        {
            get { return _PACK_NUM; }
            set
            {
                this.OnPropertyValueChange(_.PACK_NUM, _PACK_NUM, value);
                this._PACK_NUM = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_OPEARTION_GID
        {
            get { return _ROUTE_OPEARTION_GID; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_OPEARTION_GID, _ROUTE_OPEARTION_GID, value);
                this._ROUTE_OPEARTION_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_PLAN_ORDER_GID
        {
            get { return _IME_PLAN_ORDER_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_PLAN_ORDER_GID, _IME_PLAN_ORDER_GID, value);
                this._IME_PLAN_ORDER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string IME_WORK_ORDER_GID
        {
            get { return _IME_WORK_ORDER_GID; }
            set
            {
                this.OnPropertyValueChange(_.IME_WORK_ORDER_GID, _IME_WORK_ORDER_GID, value);
                this._IME_WORK_ORDER_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ORDER_SEQ
        {
            get { return _ORDER_SEQ; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_SEQ, _ORDER_SEQ, value);
                this._ORDER_SEQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PRODUCT_SEQ
        {
            get { return _PRODUCT_SEQ; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCT_SEQ, _PRODUCT_SEQ, value);
                this._PRODUCT_SEQ = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BM_PRODUCTINFO_GID
        {
            get { return _BM_PRODUCTINFO_GID; }
            set
            {
                this.OnPropertyValueChange(_.BM_PRODUCTINFO_GID, _BM_PRODUCTINFO_GID, value);
                this._BM_PRODUCTINFO_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string GENERATE_WAVE
        {
            get { return _GENERATE_WAVE; }
            set
            {
                this.OnPropertyValueChange(_.GENERATE_WAVE, _GENERATE_WAVE, value);
                this._GENERATE_WAVE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string REMARKS
        {
            get { return _REMARKS; }
            set
            {
                this.OnPropertyValueChange(_.REMARKS, _REMARKS, value);
                this._REMARKS = value;
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
        public string COMBINATION_STANDARD
        {
            get { return _COMBINATION_STANDARD; }
            set
            {
                this.OnPropertyValueChange(_.COMBINATION_STANDARD, _COMBINATION_STANDARD, value);
                this._COMBINATION_STANDARD = value;
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
                _.PACK_GROUP_GID,
                _.REQ_PACKAGE_GID,
                _.MATERIAL_REQ_GID,
                _.MATERIAL_CODE,
                _.MATERIAL_NAME,
                _.MATERIAL_UNIT,
                _.PLAN_QTY,
                _.REQ_QTY,
                _.MATERIAL_GID,
                _.PACK_QTY,
                _.PLAN_TIME,
                _.SPECIFIED_TIME,
                _.FACTORY_WORK_STATION,
                _.PACK_NUM,
                _.ROUTE_OPEARTION_GID,
                _.IME_PLAN_ORDER_GID,
                _.IME_WORK_ORDER_GID,
                _.ORDER_SEQ,
                _.PRODUCT_SEQ,
                _.BM_PRODUCTINFO_GID,
                _.GENERATE_WAVE,
                _.REMARKS,
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
                _.COMBINATION_STANDARD};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._GID,
                this._PACK_GROUP_GID,
                this._REQ_PACKAGE_GID,
                this._MATERIAL_REQ_GID,
                this._MATERIAL_CODE,
                this._MATERIAL_NAME,
                this._MATERIAL_UNIT,
                this._PLAN_QTY,
                this._REQ_QTY,
                this._MATERIAL_GID,
                this._PACK_QTY,
                this._PLAN_TIME,
                this._SPECIFIED_TIME,
                this._FACTORY_WORK_STATION,
                this._PACK_NUM,
                this._ROUTE_OPEARTION_GID,
                this._IME_PLAN_ORDER_GID,
                this._IME_WORK_ORDER_GID,
                this._ORDER_SEQ,
                this._PRODUCT_SEQ,
                this._BM_PRODUCTINFO_GID,
                this._GENERATE_WAVE,
                this._REMARKS,
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
                this._COMBINATION_STANDARD};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._GID = DataUtils.ConvertValue<string>(reader["GID"]);
            this._PACK_GROUP_GID = DataUtils.ConvertValue<string>(reader["PACK_GROUP_GID"]);
            this._REQ_PACKAGE_GID = DataUtils.ConvertValue<string>(reader["REQ_PACKAGE_GID"]);
            this._MATERIAL_REQ_GID = DataUtils.ConvertValue<string>(reader["MATERIAL_REQ_GID"]);
            this._MATERIAL_CODE = DataUtils.ConvertValue<string>(reader["MATERIAL_CODE"]);
            this._MATERIAL_NAME = DataUtils.ConvertValue<string>(reader["MATERIAL_NAME"]);
            this._MATERIAL_UNIT = DataUtils.ConvertValue<string>(reader["MATERIAL_UNIT"]);
            this._PLAN_QTY = DataUtils.ConvertValue<decimal?>(reader["PLAN_QTY"]);
            this._REQ_QTY = DataUtils.ConvertValue<decimal?>(reader["REQ_QTY"]);
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(reader["MATERIAL_GID"]);
            this._PACK_QTY = DataUtils.ConvertValue<decimal?>(reader["PACK_QTY"]);
            this._PLAN_TIME = DataUtils.ConvertValue<DateTime?>(reader["PLAN_TIME"]);
            this._SPECIFIED_TIME = DataUtils.ConvertValue<DateTime?>(reader["SPECIFIED_TIME"]);
            this._FACTORY_WORK_STATION = DataUtils.ConvertValue<string>(reader["FACTORY_WORK_STATION"]);
            this._PACK_NUM = DataUtils.ConvertValue<decimal?>(reader["PACK_NUM"]);
            this._ROUTE_OPEARTION_GID = DataUtils.ConvertValue<string>(reader["ROUTE_OPEARTION_GID"]);
            this._IME_PLAN_ORDER_GID = DataUtils.ConvertValue<string>(reader["IME_PLAN_ORDER_GID"]);
            this._IME_WORK_ORDER_GID = DataUtils.ConvertValue<string>(reader["IME_WORK_ORDER_GID"]);
            this._ORDER_SEQ = DataUtils.ConvertValue<string>(reader["ORDER_SEQ"]);
            this._PRODUCT_SEQ = DataUtils.ConvertValue<string>(reader["PRODUCT_SEQ"]);
            this._BM_PRODUCTINFO_GID = DataUtils.ConvertValue<string>(reader["BM_PRODUCTINFO_GID"]);
            this._GENERATE_WAVE = DataUtils.ConvertValue<string>(reader["GENERATE_WAVE"]);
            this._REMARKS = DataUtils.ConvertValue<string>(reader["REMARKS"]);
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
            this._COMBINATION_STANDARD = DataUtils.ConvertValue<string>(reader["COMBINATION_STANDARD"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._GID = DataUtils.ConvertValue<string>(row["GID"]);
            this._PACK_GROUP_GID = DataUtils.ConvertValue<string>(row["PACK_GROUP_GID"]);
            this._REQ_PACKAGE_GID = DataUtils.ConvertValue<string>(row["REQ_PACKAGE_GID"]);
            this._MATERIAL_REQ_GID = DataUtils.ConvertValue<string>(row["MATERIAL_REQ_GID"]);
            this._MATERIAL_CODE = DataUtils.ConvertValue<string>(row["MATERIAL_CODE"]);
            this._MATERIAL_NAME = DataUtils.ConvertValue<string>(row["MATERIAL_NAME"]);
            this._MATERIAL_UNIT = DataUtils.ConvertValue<string>(row["MATERIAL_UNIT"]);
            this._PLAN_QTY = DataUtils.ConvertValue<decimal?>(row["PLAN_QTY"]);
            this._REQ_QTY = DataUtils.ConvertValue<decimal?>(row["REQ_QTY"]);
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(row["MATERIAL_GID"]);
            this._PACK_QTY = DataUtils.ConvertValue<decimal?>(row["PACK_QTY"]);
            this._PLAN_TIME = DataUtils.ConvertValue<DateTime?>(row["PLAN_TIME"]);
            this._SPECIFIED_TIME = DataUtils.ConvertValue<DateTime?>(row["SPECIFIED_TIME"]);
            this._FACTORY_WORK_STATION = DataUtils.ConvertValue<string>(row["FACTORY_WORK_STATION"]);
            this._PACK_NUM = DataUtils.ConvertValue<decimal?>(row["PACK_NUM"]);
            this._ROUTE_OPEARTION_GID = DataUtils.ConvertValue<string>(row["ROUTE_OPEARTION_GID"]);
            this._IME_PLAN_ORDER_GID = DataUtils.ConvertValue<string>(row["IME_PLAN_ORDER_GID"]);
            this._IME_WORK_ORDER_GID = DataUtils.ConvertValue<string>(row["IME_WORK_ORDER_GID"]);
            this._ORDER_SEQ = DataUtils.ConvertValue<string>(row["ORDER_SEQ"]);
            this._PRODUCT_SEQ = DataUtils.ConvertValue<string>(row["PRODUCT_SEQ"]);
            this._BM_PRODUCTINFO_GID = DataUtils.ConvertValue<string>(row["BM_PRODUCTINFO_GID"]);
            this._GENERATE_WAVE = DataUtils.ConvertValue<string>(row["GENERATE_WAVE"]);
            this._REMARKS = DataUtils.ConvertValue<string>(row["REMARKS"]);
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
            this._COMBINATION_STANDARD = DataUtils.ConvertValue<string>(row["COMBINATION_STANDARD"]);
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
            public readonly static Field All = new Field("*", "IME_LOGISTICS_REQ_PACKAGE_DEL");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACK_GROUP_GID = new Field("PACK_GROUP_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PACK_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REQ_PACKAGE_GID = new Field("REQ_PACKAGE_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "REQ_PACKAGE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_REQ_GID = new Field("MATERIAL_REQ_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "MATERIAL_REQ_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_CODE = new Field("MATERIAL_CODE", "IME_LOGISTICS_REQ_PACKAGE_DEL", "MATERIAL_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_NAME = new Field("MATERIAL_NAME", "IME_LOGISTICS_REQ_PACKAGE_DEL", "MATERIAL_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_UNIT = new Field("MATERIAL_UNIT", "IME_LOGISTICS_REQ_PACKAGE_DEL", "MATERIAL_UNIT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_QTY = new Field("PLAN_QTY", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PLAN_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REQ_QTY = new Field("REQ_QTY", "IME_LOGISTICS_REQ_PACKAGE_DEL", "REQ_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_GID = new Field("MATERIAL_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "MATERIAL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACK_QTY = new Field("PACK_QTY", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PACK_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_TIME = new Field("PLAN_TIME", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PLAN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SPECIFIED_TIME = new Field("SPECIFIED_TIME", "IME_LOGISTICS_REQ_PACKAGE_DEL", "SPECIFIED_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_WORK_STATION = new Field("FACTORY_WORK_STATION", "IME_LOGISTICS_REQ_PACKAGE_DEL", "FACTORY_WORK_STATION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PACK_NUM = new Field("PACK_NUM", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PACK_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_OPEARTION_GID = new Field("ROUTE_OPEARTION_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "ROUTE_OPEARTION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_PLAN_ORDER_GID = new Field("IME_PLAN_ORDER_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "IME_PLAN_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IME_WORK_ORDER_GID = new Field("IME_WORK_ORDER_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "IME_WORK_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORDER_SEQ = new Field("ORDER_SEQ", "IME_LOGISTICS_REQ_PACKAGE_DEL", "ORDER_SEQ");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCT_SEQ = new Field("PRODUCT_SEQ", "IME_LOGISTICS_REQ_PACKAGE_DEL", "PRODUCT_SEQ");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BM_PRODUCTINFO_GID = new Field("BM_PRODUCTINFO_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "BM_PRODUCTINFO_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GENERATE_WAVE = new Field("GENERATE_WAVE", "IME_LOGISTICS_REQ_PACKAGE_DEL", "GENERATE_WAVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REMARKS = new Field("REMARKS", "IME_LOGISTICS_REQ_PACKAGE_DEL", "REMARKS");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_LOGISTICS_REQ_PACKAGE_DEL", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_LOGISTICS_REQ_PACKAGE_DEL", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_LOGISTICS_REQ_PACKAGE_DEL", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_LOGISTICS_REQ_PACKAGE_DEL", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_LOGISTICS_REQ_PACKAGE_DEL", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_LOGISTICS_REQ_PACKAGE_DEL", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_LOGISTICS_REQ_PACKAGE_DEL", "UDA20");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field COMBINATION_STANDARD = new Field("COMBINATION_STANDARD", "IME_LOGISTICS_REQ_PACKAGE_DEL", "COMBINATION_STANDARD");
        }
        #endregion


    }

}
