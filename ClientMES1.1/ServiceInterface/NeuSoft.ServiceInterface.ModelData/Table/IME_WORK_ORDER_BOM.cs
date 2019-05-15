﻿using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
	/// 实体类IME_WORK_ORDER_BOM 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
    public class IME_WORK_ORDER_BOM : Entity
    {
        public IME_WORK_ORDER_BOM() : base("IME_WORK_ORDER_BOM") { }

        #region Model
        private string _GID;
        private string _WORK_ORDER_GID;
        private string _MATERIAL_GID;
        private decimal? _MATERIAL_NUMBER;
        private decimal? _PRODUCT_NUMBER;
        private decimal? _PLAN_QTY;
        private decimal? _ORDER_QTY;
        private string _PICKING_TYPE;
        private string _WAREHOUSE_GID;
        private string _ROUTE_OPERATION_GID;
        private string _ROUTE_OPERATION_CODE;
        private string _ROUTE_OPERATION_NAME;
        private string _FACTORY_STATION_GID;
        private string _ROUTE_LINE_GID;
        private decimal? _REVIEW_GID;
        private decimal? _DEDUCTION_QTY;
        private decimal? _DELIVERED_QTY;
        private string _ROW_NUMBER;
        private string _PRODUCT_GID;
        private string _BOM_VERSION;
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
        public decimal? MATERIAL_NUMBER
        {
            get { return _MATERIAL_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.MATERIAL_NUMBER, _MATERIAL_NUMBER, value);
                this._MATERIAL_NUMBER = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? PRODUCT_NUMBER
        {
            get { return _PRODUCT_NUMBER; }
            set
            {
                this.OnPropertyValueChange(_.PRODUCT_NUMBER, _PRODUCT_NUMBER, value);
                this._PRODUCT_NUMBER = value;
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
        public decimal? ORDER_QTY
        {
            get { return _ORDER_QTY; }
            set
            {
                this.OnPropertyValueChange(_.ORDER_QTY, _ORDER_QTY, value);
                this._ORDER_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string PICKING_TYPE
        {
            get { return _PICKING_TYPE; }
            set
            {
                this.OnPropertyValueChange(_.PICKING_TYPE, _PICKING_TYPE, value);
                this._PICKING_TYPE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string WAREHOUSE_GID
        {
            get { return _WAREHOUSE_GID; }
            set
            {
                this.OnPropertyValueChange(_.WAREHOUSE_GID, _WAREHOUSE_GID, value);
                this._WAREHOUSE_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_OPERATION_GID
        {
            get { return _ROUTE_OPERATION_GID; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_OPERATION_GID, _ROUTE_OPERATION_GID, value);
                this._ROUTE_OPERATION_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_OPERATION_CODE
        {
            get { return _ROUTE_OPERATION_CODE; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_OPERATION_CODE, _ROUTE_OPERATION_CODE, value);
                this._ROUTE_OPERATION_CODE = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ROUTE_OPERATION_NAME
        {
            get { return _ROUTE_OPERATION_NAME; }
            set
            {
                this.OnPropertyValueChange(_.ROUTE_OPERATION_NAME, _ROUTE_OPERATION_NAME, value);
                this._ROUTE_OPERATION_NAME = value;
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
        public decimal? REVIEW_GID
        {
            get { return _REVIEW_GID; }
            set
            {
                this.OnPropertyValueChange(_.REVIEW_GID, _REVIEW_GID, value);
                this._REVIEW_GID = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DEDUCTION_QTY
        {
            get { return _DEDUCTION_QTY; }
            set
            {
                this.OnPropertyValueChange(_.DEDUCTION_QTY, _DEDUCTION_QTY, value);
                this._DEDUCTION_QTY = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? DELIVERED_QTY
        {
            get { return _DELIVERED_QTY; }
            set
            {
                this.OnPropertyValueChange(_.DELIVERED_QTY, _DELIVERED_QTY, value);
                this._DELIVERED_QTY = value;
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
                _.MATERIAL_GID,
                _.MATERIAL_NUMBER,
                _.PRODUCT_NUMBER,
                _.PLAN_QTY,
                _.ORDER_QTY,
                _.PICKING_TYPE,
                _.WAREHOUSE_GID,
                _.ROUTE_OPERATION_GID,
                _.ROUTE_OPERATION_CODE,
                _.ROUTE_OPERATION_NAME,
                _.FACTORY_STATION_GID,
                _.ROUTE_LINE_GID,
                _.REVIEW_GID,
                _.DEDUCTION_QTY,
                _.DELIVERED_QTY,
                _.ROW_NUMBER,
                _.PRODUCT_GID,
                _.BOM_VERSION,
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
                this._MATERIAL_GID,
                this._MATERIAL_NUMBER,
                this._PRODUCT_NUMBER,
                this._PLAN_QTY,
                this._ORDER_QTY,
                this._PICKING_TYPE,
                this._WAREHOUSE_GID,
                this._ROUTE_OPERATION_GID,
                this._ROUTE_OPERATION_CODE,
                this._ROUTE_OPERATION_NAME,
                this._FACTORY_STATION_GID,
                this._ROUTE_LINE_GID,
                this._REVIEW_GID,
                this._DEDUCTION_QTY,
                this._DELIVERED_QTY,
                this._ROW_NUMBER,
                this._PRODUCT_GID,
                this._BOM_VERSION,
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
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(reader["MATERIAL_GID"]);
            this._MATERIAL_NUMBER = DataUtils.ConvertValue<decimal?>(reader["MATERIAL_NUMBER"]);
            this._PRODUCT_NUMBER = DataUtils.ConvertValue<decimal?>(reader["PRODUCT_NUMBER"]);
            this._PLAN_QTY = DataUtils.ConvertValue<decimal?>(reader["PLAN_QTY"]);
            this._ORDER_QTY = DataUtils.ConvertValue<decimal?>(reader["ORDER_QTY"]);
            this._PICKING_TYPE = DataUtils.ConvertValue<string>(reader["PICKING_TYPE"]);
            this._WAREHOUSE_GID = DataUtils.ConvertValue<string>(reader["WAREHOUSE_GID"]);
            this._ROUTE_OPERATION_GID = DataUtils.ConvertValue<string>(reader["ROUTE_OPERATION_GID"]);
            this._ROUTE_OPERATION_CODE = DataUtils.ConvertValue<string>(reader["ROUTE_OPERATION_CODE"]);
            this._ROUTE_OPERATION_NAME = DataUtils.ConvertValue<string>(reader["ROUTE_OPERATION_NAME"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(reader["FACTORY_STATION_GID"]);
            this._ROUTE_LINE_GID = DataUtils.ConvertValue<string>(reader["ROUTE_LINE_GID"]);
            this._REVIEW_GID = DataUtils.ConvertValue<decimal?>(reader["REVIEW_GID"]);
            this._DEDUCTION_QTY = DataUtils.ConvertValue<decimal?>(reader["DEDUCTION_QTY"]);
            this._DELIVERED_QTY = DataUtils.ConvertValue<decimal?>(reader["DELIVERED_QTY"]);
            this._ROW_NUMBER = DataUtils.ConvertValue<string>(reader["ROW_NUMBER"]);
            this._PRODUCT_GID = DataUtils.ConvertValue<string>(reader["PRODUCT_GID"]);
            this._BOM_VERSION = DataUtils.ConvertValue<string>(reader["BOM_VERSION"]);
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
            this._MATERIAL_GID = DataUtils.ConvertValue<string>(row["MATERIAL_GID"]);
            this._MATERIAL_NUMBER = DataUtils.ConvertValue<decimal?>(row["MATERIAL_NUMBER"]);
            this._PRODUCT_NUMBER = DataUtils.ConvertValue<decimal?>(row["PRODUCT_NUMBER"]);
            this._PLAN_QTY = DataUtils.ConvertValue<decimal?>(row["PLAN_QTY"]);
            this._ORDER_QTY = DataUtils.ConvertValue<decimal?>(row["ORDER_QTY"]);
            this._PICKING_TYPE = DataUtils.ConvertValue<string>(row["PICKING_TYPE"]);
            this._WAREHOUSE_GID = DataUtils.ConvertValue<string>(row["WAREHOUSE_GID"]);
            this._ROUTE_OPERATION_GID = DataUtils.ConvertValue<string>(row["ROUTE_OPERATION_GID"]);
            this._ROUTE_OPERATION_CODE = DataUtils.ConvertValue<string>(row["ROUTE_OPERATION_CODE"]);
            this._ROUTE_OPERATION_NAME = DataUtils.ConvertValue<string>(row["ROUTE_OPERATION_NAME"]);
            this._FACTORY_STATION_GID = DataUtils.ConvertValue<string>(row["FACTORY_STATION_GID"]);
            this._ROUTE_LINE_GID = DataUtils.ConvertValue<string>(row["ROUTE_LINE_GID"]);
            this._REVIEW_GID = DataUtils.ConvertValue<decimal?>(row["REVIEW_GID"]);
            this._DEDUCTION_QTY = DataUtils.ConvertValue<decimal?>(row["DEDUCTION_QTY"]);
            this._DELIVERED_QTY = DataUtils.ConvertValue<decimal?>(row["DELIVERED_QTY"]);
            this._ROW_NUMBER = DataUtils.ConvertValue<string>(row["ROW_NUMBER"]);
            this._PRODUCT_GID = DataUtils.ConvertValue<string>(row["PRODUCT_GID"]);
            this._BOM_VERSION = DataUtils.ConvertValue<string>(row["BOM_VERSION"]);
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
            public readonly static Field All = new Field("*", "IME_WORK_ORDER_BOM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field GID = new Field("GID", "IME_WORK_ORDER_BOM", "GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WORK_ORDER_GID = new Field("WORK_ORDER_GID", "IME_WORK_ORDER_BOM", "WORK_ORDER_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_GID = new Field("MATERIAL_GID", "IME_WORK_ORDER_BOM", "MATERIAL_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MATERIAL_NUMBER = new Field("MATERIAL_NUMBER", "IME_WORK_ORDER_BOM", "MATERIAL_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCT_NUMBER = new Field("PRODUCT_NUMBER", "IME_WORK_ORDER_BOM", "PRODUCT_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PLAN_QTY = new Field("PLAN_QTY", "IME_WORK_ORDER_BOM", "PLAN_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ORDER_QTY = new Field("ORDER_QTY", "IME_WORK_ORDER_BOM", "ORDER_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PICKING_TYPE = new Field("PICKING_TYPE", "IME_WORK_ORDER_BOM", "PICKING_TYPE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field WAREHOUSE_GID = new Field("WAREHOUSE_GID", "IME_WORK_ORDER_BOM", "WAREHOUSE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_OPERATION_GID = new Field("ROUTE_OPERATION_GID", "IME_WORK_ORDER_BOM", "ROUTE_OPERATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_OPERATION_CODE = new Field("ROUTE_OPERATION_CODE", "IME_WORK_ORDER_BOM", "ROUTE_OPERATION_CODE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_OPERATION_NAME = new Field("ROUTE_OPERATION_NAME", "IME_WORK_ORDER_BOM", "ROUTE_OPERATION_NAME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field FACTORY_STATION_GID = new Field("FACTORY_STATION_GID", "IME_WORK_ORDER_BOM", "FACTORY_STATION_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROUTE_LINE_GID = new Field("ROUTE_LINE_GID", "IME_WORK_ORDER_BOM", "ROUTE_LINE_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field REVIEW_GID = new Field("REVIEW_GID", "IME_WORK_ORDER_BOM", "REVIEW_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DEDUCTION_QTY = new Field("DEDUCTION_QTY", "IME_WORK_ORDER_BOM", "DEDUCTION_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field DELIVERED_QTY = new Field("DELIVERED_QTY", "IME_WORK_ORDER_BOM", "DELIVERED_QTY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field ROW_NUMBER = new Field("ROW_NUMBER", "IME_WORK_ORDER_BOM", "ROW_NUMBER");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field PRODUCT_GID = new Field("PRODUCT_GID", "IME_WORK_ORDER_BOM", "PRODUCT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BOM_VERSION = new Field("BOM_VERSION", "IME_WORK_ORDER_BOM", "BOM_VERSION");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_BY = new Field("CREATE_BY", "IME_WORK_ORDER_BOM", "CREATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CREATE_TIME = new Field("CREATE_TIME", "IME_WORK_ORDER_BOM", "CREATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_BY = new Field("UPDATE_BY", "IME_WORK_ORDER_BOM", "UPDATE_BY");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UPDATE_TIME = new Field("UPDATE_TIME", "IME_WORK_ORDER_BOM", "UPDATE_TIME");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_DELETE = new Field("IS_DELETE", "IME_WORK_ORDER_BOM", "IS_DELETE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IS_ACTIVE = new Field("IS_ACTIVE", "IME_WORK_ORDER_BOM", "IS_ACTIVE");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_GROUP_GID = new Field("SM_BUSI_GROUP_GID", "IME_WORK_ORDER_BOM", "SM_BUSI_GROUP_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field SM_BUSI_UNIT_GID = new Field("SM_BUSI_UNIT_GID", "IME_WORK_ORDER_BOM", "SM_BUSI_UNIT_GID");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VERSION_NUM = new Field("VERSION_NUM", "IME_WORK_ORDER_BOM", "VERSION_NUM");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA1 = new Field("UDA1", "IME_WORK_ORDER_BOM", "UDA1");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA2 = new Field("UDA2", "IME_WORK_ORDER_BOM", "UDA2");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA3 = new Field("UDA3", "IME_WORK_ORDER_BOM", "UDA3");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA4 = new Field("UDA4", "IME_WORK_ORDER_BOM", "UDA4");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA5 = new Field("UDA5", "IME_WORK_ORDER_BOM", "UDA5");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA6 = new Field("UDA6", "IME_WORK_ORDER_BOM", "UDA6");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA7 = new Field("UDA7", "IME_WORK_ORDER_BOM", "UDA7");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA8 = new Field("UDA8", "IME_WORK_ORDER_BOM", "UDA8");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA9 = new Field("UDA9", "IME_WORK_ORDER_BOM", "UDA9");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA10 = new Field("UDA10", "IME_WORK_ORDER_BOM", "UDA10");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA11 = new Field("UDA11", "IME_WORK_ORDER_BOM", "UDA11");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA12 = new Field("UDA12", "IME_WORK_ORDER_BOM", "UDA12");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA13 = new Field("UDA13", "IME_WORK_ORDER_BOM", "UDA13");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA14 = new Field("UDA14", "IME_WORK_ORDER_BOM", "UDA14");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA15 = new Field("UDA15", "IME_WORK_ORDER_BOM", "UDA15");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA16 = new Field("UDA16", "IME_WORK_ORDER_BOM", "UDA16");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA17 = new Field("UDA17", "IME_WORK_ORDER_BOM", "UDA17");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA18 = new Field("UDA18", "IME_WORK_ORDER_BOM", "UDA18");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA19 = new Field("UDA19", "IME_WORK_ORDER_BOM", "UDA19");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UDA20 = new Field("UDA20", "IME_WORK_ORDER_BOM", "UDA20");
        }
        #endregion


    }

}
