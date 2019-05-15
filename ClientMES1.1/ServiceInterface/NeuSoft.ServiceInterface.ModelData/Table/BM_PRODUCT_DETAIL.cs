using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类BM_PRODUCT_DETAIL 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class BM_PRODUCT_DETAIL : Entity
    {
        public BM_PRODUCT_DETAIL() : base("BM_PRODUCT_DETAIL") { }

        #region Model
        private string _GID;
        private string _MATERIAL_GID;
        private string _PARENT_MATERIAL_GID;
        private string _MATERIAL_UNIT;
        private decimal? _BOM_NUMBER;
        private string _SUBSTITUTE;
        private string _MD_ROUTE_OPERATION_GID;
        private string _FACTORY_STATION_GID;
        private string _SUB_TECHNICS_GID;
        private decimal? _REVIEW;
        private DateTime? _VALID_BEGIN_TIME;
        private DateTime? _VALID_END_TIME;
        private string _DOSAGE_SCHEME;
        private decimal? _DENO_NUMBER;
        private decimal? _MOLECULE_NUMBER;
        private decimal? _USE_NUMBER;
        private decimal? _LOSS_RATE;
        private string _PICK_WAY;
        private string _MD_PRODUCT_INFO_GID;
        private string _MD_ROUTE_OPERATION_CODE;
        private string _MD_ROUTE_OPERATION_NAME;
        private decimal? _PIVOTAL;
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
        public string PARENT_MATERIAL_GID
        {
            get { return _PARENT_MATERIAL_GID; }
            set
            {
                this.OnPropertyValueChange(_.PARENT_MATERIAL_GID, _PARENT_MATERIAL_GID, value);
                this._PARENT_MATERIAL_GID = value;
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
        public decimal? BOM_NUMBER
        {
            get { return _BOM_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.BOM_NUMBER, _BOM_NUMBER, value);
                this._BOM_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SUBSTITUTE
        {
            get { return _SUBSTITUTE; }
            set
            {
                this.OnPropertyValueChange(_.SUBSTITUTE, _SUBSTITUTE, value);
                this._SUBSTITUTE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MD_ROUTE_OPERATION_GID
        {
            get { return _MD_ROUTE_OPERATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.MD_ROUTE_OPERATION_GID, _MD_ROUTE_OPERATION_GID, value);
                this._MD_ROUTE_OPERATION_GID = value;
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
        public string SUB_TECHNICS_GID
        {
            get { return _SUB_TECHNICS_GID; }
            set
            {
                this.OnPropertyValueChange(_.SUB_TECHNICS_GID, _SUB_TECHNICS_GID, value);
                this._SUB_TECHNICS_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? REVIEW
        {
            get { return _REVIEW; }
            set
            {
                this.OnPropertyValueChange(_.REVIEW, _REVIEW, value);
                this._REVIEW = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? VALID_BEGIN_TIME
        {
            get { return _VALID_BEGIN_TIME; }
            set
            {
                this.OnPropertyValueChange(_.VALID_BEGIN_TIME, _VALID_BEGIN_TIME, value);
                this._VALID_BEGIN_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? VALID_END_TIME
        {
            get { return _VALID_END_TIME; }
            set
            {
                this.OnPropertyValueChange(_.VALID_END_TIME, _VALID_END_TIME, value);
                this._VALID_END_TIME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string DOSAGE_SCHEME
        {
            get { return _DOSAGE_SCHEME; }
            set
            {
                this.OnPropertyValueChange(_.DOSAGE_SCHEME, _DOSAGE_SCHEME, value);
                this._DOSAGE_SCHEME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DENO_NUMBER
        {
            get { return _DENO_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.DENO_NUMBER, _DENO_NUMBER, value);
                this._DENO_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? MOLECULE_NUMBER
        {
            get { return _MOLECULE_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.MOLECULE_NUMBER, _MOLECULE_NUMBER, value);
                this._MOLECULE_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? USE_NUMBER
        {
            get { return _USE_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.USE_NUMBER, _USE_NUMBER, value);
                this._USE_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? LOSS_RATE
        {
            get { return _LOSS_RATE; }
            set
            {
                this.OnPropertyValueChange(_.LOSS_RATE, _LOSS_RATE, value);
                this._LOSS_RATE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PICK_WAY
        {
            get { return _PICK_WAY; }
            set
            {
                this.OnPropertyValueChange(_.PICK_WAY, _PICK_WAY, value);
                this._PICK_WAY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MD_PRODUCT_INFO_GID
        {
            get { return _MD_PRODUCT_INFO_GID; }
            set
            {
                this.OnPropertyValueChange(_.MD_PRODUCT_INFO_GID, _MD_PRODUCT_INFO_GID, value);
                this._MD_PRODUCT_INFO_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MD_ROUTE_OPERATION_CODE
        {
            get { return _MD_ROUTE_OPERATION_CODE; }
            set
            {
                this.OnPropertyValueChange(_.MD_ROUTE_OPERATION_CODE, _MD_ROUTE_OPERATION_CODE, value);
                this._MD_ROUTE_OPERATION_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MD_ROUTE_OPERATION_NAME
        {
            get { return _MD_ROUTE_OPERATION_NAME; }
            set
            {
                this.OnPropertyValueChange(_.MD_ROUTE_OPERATION_NAME, _MD_ROUTE_OPERATION_NAME, value);
                this._MD_ROUTE_OPERATION_NAME = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PIVOTAL
        {
            get { return _PIVOTAL; }
            set
            {
                this.OnPropertyValueChange(_.PIVOTAL, _PIVOTAL, value);
                this._PIVOTAL = value;
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
                _.MATERIAL_GID,
                _.PARENT_MATERIAL_GID,
                _.MATERIAL_UNIT,
                _.BOM_NUMBER,
                _.SUBSTITUTE,
                _.MD_ROUTE_OPERATION_GID,
                _.FACTORY_STATION_GID,
                _.SUB_TECHNICS_GID,
                _.REVIEW,
                _.VALID_BEGIN_TIME,
                _.VALID_END_TIME,
                _.DOSAGE_SCHEME,
                _.DENO_NUMBER,
                _.MOLECULE_NUMBER,
                _.USE_NUMBER,
                _.LOSS_RATE,
                _.PICK_WAY,
                _.MD_PRODUCT_INFO_GID,
                _.MD_ROUTE_OPERATION_CODE,
                _.MD_ROUTE_OPERATION_NAME,
                _.PIVOTAL,
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
                this._MATERIAL_GID,
                this._PARENT_MATERIAL_GID,
                this._MATERIAL_UNIT,
                this._BOM_NUMBER,
                this._SUBSTITUTE,
                this._MD_ROUTE_OPERATION_GID,
                this._FACTORY_STATION_GID,
                this._SUB_TECHNICS_GID,
                this._REVIEW,
                this._VALID_BEGIN_TIME,
                this._VALID_END_TIME,
                this._DOSAGE_SCHEME,
                this._DENO_NUMBER,
                this._MOLECULE_NUMBER,
                this._USE_NUMBER,
                this._LOSS_RATE,
                this._PICK_WAY,
                this._MD_PRODUCT_INFO_GID,
                this._MD_ROUTE_OPERATION_CODE,
                this._MD_ROUTE_OPERATION_NAME,
                this._PIVOTAL,
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
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(reader["MATERIAL_GID"]);
            this._PARENT_MATERIAL_GID = DataUtils.ConvertValue<string>(reader["PARENT_MATERIAL_GID"]);
            this._MATERIAL_UNIT = DataUtils.ConvertValue<string>(reader["MATERIAL_UNIT"]);
            this._BOM_NUMBER = DataUtils.ConvertValue<decimal?>(reader["BOM_NUMBER"]);
            this._SUBSTITUTE = DataUtils.ConvertValue<string>(reader["SUBSTITUTE"]);
            this._MD_ROUTE_OPERATION_GID = DataUtils.ConvertValue<string>(reader["MD_ROUTE_OPERATION_GID"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(reader["FACTORY_STATION_GID"]);
            this._SUB_TECHNICS_GID = DataUtils.ConvertValue<string>(reader["SUB_TECHNICS_GID"]);
            this._REVIEW = DataUtils.ConvertValue<decimal?>(reader["REVIEW"]);
            this._VALID_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(reader["VALID_BEGIN_TIME"]);
            this._VALID_END_TIME = DataUtils.ConvertValue<DateTime?>(reader["VALID_END_TIME"]);
            this._DOSAGE_SCHEME = DataUtils.ConvertValue<string>(reader["DOSAGE_SCHEME"]);
            this._DENO_NUMBER = DataUtils.ConvertValue<decimal?>(reader["DENO_NUMBER"]);
            this._MOLECULE_NUMBER = DataUtils.ConvertValue<decimal?>(reader["MOLECULE_NUMBER"]);
            this._USE_NUMBER = DataUtils.ConvertValue<decimal?>(reader["USE_NUMBER"]);
            this._LOSS_RATE = DataUtils.ConvertValue<decimal?>(reader["LOSS_RATE"]);
            this._PICK_WAY = DataUtils.ConvertValue<string>(reader["PICK_WAY"]);
            this._MD_PRODUCT_INFO_GID = DataUtils.ConvertValue<string>(reader["MD_PRODUCT_INFO_GID"]);
            this._MD_ROUTE_OPERATION_CODE = DataUtils.ConvertValue<string>(reader["MD_ROUTE_OPERATION_CODE"]);
            this._MD_ROUTE_OPERATION_NAME = DataUtils.ConvertValue<string>(reader["MD_ROUTE_OPERATION_NAME"]);
            this._PIVOTAL = DataUtils.ConvertValue<decimal?>(reader["PIVOTAL"]);
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
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(row["MATERIAL_GID"]);
            this._PARENT_MATERIAL_GID = DataUtils.ConvertValue<string>(row["PARENT_MATERIAL_GID"]);
            this._MATERIAL_UNIT = DataUtils.ConvertValue<string>(row["MATERIAL_UNIT"]);
            this._BOM_NUMBER = DataUtils.ConvertValue<decimal?>(row["BOM_NUMBER"]);
            this._SUBSTITUTE = DataUtils.ConvertValue<string>(row["SUBSTITUTE"]);
            this._MD_ROUTE_OPERATION_GID = DataUtils.ConvertValue<string>(row["MD_ROUTE_OPERATION_GID"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(row["FACTORY_STATION_GID"]);
            this._SUB_TECHNICS_GID = DataUtils.ConvertValue<string>(row["SUB_TECHNICS_GID"]);
            this._REVIEW = DataUtils.ConvertValue<decimal?>(row["REVIEW"]);
            this._VALID_BEGIN_TIME = DataUtils.ConvertValue<DateTime?>(row["VALID_BEGIN_TIME"]);
            this._VALID_END_TIME = DataUtils.ConvertValue<DateTime?>(row["VALID_END_TIME"]);
            this._DOSAGE_SCHEME = DataUtils.ConvertValue<string>(row["DOSAGE_SCHEME"]);
            this._DENO_NUMBER = DataUtils.ConvertValue<decimal?>(row["DENO_NUMBER"]);
            this._MOLECULE_NUMBER = DataUtils.ConvertValue<decimal?>(row["MOLECULE_NUMBER"]);
            this._USE_NUMBER = DataUtils.ConvertValue<decimal?>(row["USE_NUMBER"]);
            this._LOSS_RATE = DataUtils.ConvertValue<decimal?>(row["LOSS_RATE"]);
            this._PICK_WAY = DataUtils.ConvertValue<string>(row["PICK_WAY"]);
            this._MD_PRODUCT_INFO_GID = DataUtils.ConvertValue<string>(row["MD_PRODUCT_INFO_GID"]);
            this._MD_ROUTE_OPERATION_CODE = DataUtils.ConvertValue<string>(row["MD_ROUTE_OPERATION_CODE"]);
            this._MD_ROUTE_OPERATION_NAME = DataUtils.ConvertValue<string>(row["MD_ROUTE_OPERATION_NAME"]);
            this._PIVOTAL = DataUtils.ConvertValue<decimal?>(row["PIVOTAL"]);
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
            public readonly static Field All = new Field("*", "BM_PRODUCT_DETAIL");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "BM_PRODUCT_DETAIL", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_GID = new Field("MATERIAL_GID", "BM_PRODUCT_DETAIL", "MATERIAL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PARENT_MATERIAL_GID = new Field("PARENT_MATERIAL_GID", "BM_PRODUCT_DETAIL", "PARENT_MATERIAL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_UNIT = new Field("MATERIAL_UNIT", "BM_PRODUCT_DETAIL", "MATERIAL_UNIT");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BOM_NUMBER = new Field("BOM_NUMBER", "BM_PRODUCT_DETAIL", "BOM_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SUBSTITUTE = new Field("SUBSTITUTE", "BM_PRODUCT_DETAIL", "SUBSTITUTE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_ROUTE_OPERATION_GID = new Field("MD_ROUTE_OPERATION_GID", "BM_PRODUCT_DETAIL", "MD_ROUTE_OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_STATION_GID = new Field("FACTORY_STATION_GID", "BM_PRODUCT_DETAIL", "FACTORY_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SUB_TECHNICS_GID = new Field("SUB_TECHNICS_GID", "BM_PRODUCT_DETAIL", "SUB_TECHNICS_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REVIEW = new Field("REVIEW", "BM_PRODUCT_DETAIL", "REVIEW");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VALID_BEGIN_TIME = new Field("VALID_BEGIN_TIME", "BM_PRODUCT_DETAIL", "VALID_BEGIN_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VALID_END_TIME = new Field("VALID_END_TIME", "BM_PRODUCT_DETAIL", "VALID_END_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DOSAGE_SCHEME = new Field("DOSAGE_SCHEME", "BM_PRODUCT_DETAIL", "DOSAGE_SCHEME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DENO_NUMBER = new Field("DENO_NUMBER", "BM_PRODUCT_DETAIL", "DENO_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MOLECULE_NUMBER = new Field("MOLECULE_NUMBER", "BM_PRODUCT_DETAIL", "MOLECULE_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field USE_NUMBER = new Field("USE_NUMBER", "BM_PRODUCT_DETAIL", "USE_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field LOSS_RATE = new Field("LOSS_RATE", "BM_PRODUCT_DETAIL", "LOSS_RATE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PICK_WAY = new Field("PICK_WAY", "BM_PRODUCT_DETAIL", "PICK_WAY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_PRODUCT_INFO_GID = new Field("MD_PRODUCT_INFO_GID", "BM_PRODUCT_DETAIL", "MD_PRODUCT_INFO_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_ROUTE_OPERATION_CODE = new Field("MD_ROUTE_OPERATION_CODE", "BM_PRODUCT_DETAIL", "MD_ROUTE_OPERATION_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MD_ROUTE_OPERATION_NAME = new Field("MD_ROUTE_OPERATION_NAME", "BM_PRODUCT_DETAIL", "MD_ROUTE_OPERATION_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PIVOTAL = new Field("PIVOTAL", "BM_PRODUCT_DETAIL", "PIVOTAL");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "BM_PRODUCT_DETAIL", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "BM_PRODUCT_DETAIL", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "BM_PRODUCT_DETAIL", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "BM_PRODUCT_DETAIL", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "BM_PRODUCT_DETAIL", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "BM_PRODUCT_DETAIL", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "BM_PRODUCT_DETAIL", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "BM_PRODUCT_DETAIL", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "BM_PRODUCT_DETAIL", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "BM_PRODUCT_DETAIL", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "BM_PRODUCT_DETAIL", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "BM_PRODUCT_DETAIL", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "BM_PRODUCT_DETAIL", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "BM_PRODUCT_DETAIL", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "BM_PRODUCT_DETAIL", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "BM_PRODUCT_DETAIL", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "BM_PRODUCT_DETAIL", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "BM_PRODUCT_DETAIL", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "BM_PRODUCT_DETAIL", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "BM_PRODUCT_DETAIL", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "BM_PRODUCT_DETAIL", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "BM_PRODUCT_DETAIL", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "BM_PRODUCT_DETAIL", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "BM_PRODUCT_DETAIL", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "BM_PRODUCT_DETAIL", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "BM_PRODUCT_DETAIL", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "BM_PRODUCT_DETAIL", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "BM_PRODUCT_DETAIL", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "BM_PRODUCT_DETAIL", "UDA20");
        }
        #endregion


    }

}
