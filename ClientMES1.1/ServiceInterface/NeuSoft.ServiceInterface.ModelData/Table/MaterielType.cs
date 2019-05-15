using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    /// <summary>
    /// 实体类MaterielType 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class MaterielType : Entity
    {
        public MaterielType() : base("MaterielType") { }

        #region Model
        private string _MaterielTypeGuid;
        private string _TypeCode;
        private string _TypeName;
        private string _TypeParentGuid;
        private bool? _IsDelete;
        private bool? _IsActive;
        private string _CreateBy;
        private string _UpdateBy;
        private DateTime? _CreateTime;
        private DateTime? _UpdateTime;
        private string _BusinessUnitGuid;
        private string _BusinessGroupGuid;
        private int? _VersionNum;
        /// <summary>
        /// 
        /// </summary>
        public string MaterielTypeGuid
        {
            get { return _MaterielTypeGuid; }
            set
            {
                this.OnPropertyValueChange(_.MaterielTypeGuid, _MaterielTypeGuid, value);
                this._MaterielTypeGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeCode
        {
            get { return _TypeCode; }
            set
            {
                this.OnPropertyValueChange(_.TypeCode, _TypeCode, value);
                this._TypeCode = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeName
        {
            get { return _TypeName; }
            set
            {
                this.OnPropertyValueChange(_.TypeName, _TypeName, value);
                this._TypeName = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TypeParentGuid
        {
            get { return _TypeParentGuid; }
            set
            {
                this.OnPropertyValueChange(_.TypeParentGuid, _TypeParentGuid, value);
                this._TypeParentGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsDelete
        {
            get { return _IsDelete; }
            set
            {
                this.OnPropertyValueChange(_.IsDelete, _IsDelete, value);
                this._IsDelete = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsActive
        {
            get { return _IsActive; }
            set
            {
                this.OnPropertyValueChange(_.IsActive, _IsActive, value);
                this._IsActive = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreateBy
        {
            get { return _CreateBy; }
            set
            {
                this.OnPropertyValueChange(_.CreateBy, _CreateBy, value);
                this._CreateBy = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateBy
        {
            get { return _UpdateBy; }
            set
            {
                this.OnPropertyValueChange(_.UpdateBy, _UpdateBy, value);
                this._UpdateBy = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            get { return _CreateTime; }
            set
            {
                this.OnPropertyValueChange(_.CreateTime, _CreateTime, value);
                this._CreateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            get { return _UpdateTime; }
            set
            {
                this.OnPropertyValueChange(_.UpdateTime, _UpdateTime, value);
                this._UpdateTime = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessUnitGuid
        {
            get { return _BusinessUnitGuid; }
            set
            {
                this.OnPropertyValueChange(_.BusinessUnitGuid, _BusinessUnitGuid, value);
                this._BusinessUnitGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessGroupGuid
        {
            get { return _BusinessGroupGuid; }
            set
            {
                this.OnPropertyValueChange(_.BusinessGroupGuid, _BusinessGroupGuid, value);
                this._BusinessGroupGuid = value;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? VersionNum
        {
            get { return _VersionNum; }
            set
            {
                this.OnPropertyValueChange(_.VersionNum, _VersionNum, value);
                this._VersionNum = value;
            }
        }
        #endregion

        #region Method
        /// <summary>
        /// 获取列信息
        /// </summary>
        public override Field[] GetFields()
        {
            return new Field[] {
                _.MaterielTypeGuid,
                _.TypeCode,
                _.TypeName,
                _.TypeParentGuid,
                _.IsDelete,
                _.IsActive,
                _.CreateBy,
                _.UpdateBy,
                _.CreateTime,
                _.UpdateTime,
                _.BusinessUnitGuid,
                _.BusinessGroupGuid,
                _.VersionNum};
        }
        /// <summary>
        /// 获取值信息
        /// </summary>
        public override object[] GetValues()
        {
            return new object[] {
                this._MaterielTypeGuid,
                this._TypeCode,
                this._TypeName,
                this._TypeParentGuid,
                this._IsDelete,
                this._IsActive,
                this._CreateBy,
                this._UpdateBy,
                this._CreateTime,
                this._UpdateTime,
                this._BusinessUnitGuid,
                this._BusinessGroupGuid,
                this._VersionNum};
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(IDataReader reader)
        {
            this._MaterielTypeGuid = DataUtils.ConvertValue<string>(reader["MaterielTypeGuid"]);
            this._TypeCode = DataUtils.ConvertValue<string>(reader["TypeCode"]);
            this._TypeName = DataUtils.ConvertValue<string>(reader["TypeName"]);
            this._TypeParentGuid = DataUtils.ConvertValue<string>(reader["TypeParentGuid"]);
            this._IsDelete = DataUtils.ConvertValue<bool?>(reader["IsDelete"]);
            this._IsActive = DataUtils.ConvertValue<bool?>(reader["IsActive"]);
            this._CreateBy = DataUtils.ConvertValue<string>(reader["CreateBy"]);
            this._UpdateBy = DataUtils.ConvertValue<string>(reader["UpdateBy"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(reader["CreateTime"]);
            this._UpdateTime = DataUtils.ConvertValue<DateTime?>(reader["UpdateTime"]);
            this._BusinessUnitGuid = DataUtils.ConvertValue<string>(reader["BusinessUnitGuid"]);
            this._BusinessGroupGuid = DataUtils.ConvertValue<string>(reader["BusinessGroupGuid"]);
            this._VersionNum = DataUtils.ConvertValue<int?>(reader["VersionNum"]);
        }
        /// <summary>
        /// 给当前实体赋值
        /// </summary>
        public override void SetPropertyValues(DataRow row)
        {
            this._MaterielTypeGuid = DataUtils.ConvertValue<string>(row["MaterielTypeGuid"]);
            this._TypeCode = DataUtils.ConvertValue<string>(row["TypeCode"]);
            this._TypeName = DataUtils.ConvertValue<string>(row["TypeName"]);
            this._TypeParentGuid = DataUtils.ConvertValue<string>(row["TypeParentGuid"]);
            this._IsDelete = DataUtils.ConvertValue<bool?>(row["IsDelete"]);
            this._IsActive = DataUtils.ConvertValue<bool?>(row["IsActive"]);
            this._CreateBy = DataUtils.ConvertValue<string>(row["CreateBy"]);
            this._UpdateBy = DataUtils.ConvertValue<string>(row["UpdateBy"]);
            this._CreateTime = DataUtils.ConvertValue<DateTime?>(row["CreateTime"]);
            this._UpdateTime = DataUtils.ConvertValue<DateTime?>(row["UpdateTime"]);
            this._BusinessUnitGuid = DataUtils.ConvertValue<string>(row["BusinessUnitGuid"]);
            this._BusinessGroupGuid = DataUtils.ConvertValue<string>(row["BusinessGroupGuid"]);
            this._VersionNum = DataUtils.ConvertValue<int?>(row["VersionNum"]);
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
            public readonly static Field All = new Field("*", "MaterielType");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field MaterielTypeGuid = new Field("MaterielTypeGuid", "MaterielType", "MaterielTypeGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TypeCode = new Field("TypeCode", "MaterielType", "TypeCode");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TypeName = new Field("TypeName", "MaterielType", "TypeName");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field TypeParentGuid = new Field("TypeParentGuid", "MaterielType", "TypeParentGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsDelete = new Field("IsDelete", "MaterielType", "IsDelete");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field IsActive = new Field("IsActive", "MaterielType", "IsActive");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateBy = new Field("CreateBy", "MaterielType", "CreateBy");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UpdateBy = new Field("UpdateBy", "MaterielType", "UpdateBy");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field CreateTime = new Field("CreateTime", "MaterielType", "CreateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field UpdateTime = new Field("UpdateTime", "MaterielType", "UpdateTime");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BusinessUnitGuid = new Field("BusinessUnitGuid", "MaterielType", "BusinessUnitGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field BusinessGroupGuid = new Field("BusinessGroupGuid", "MaterielType", "BusinessGroupGuid");
            /// <summary>
            /// 
            /// </summary>
            public readonly static Field VersionNum = new Field("VersionNum", "MaterielType", "VersionNum");
        }
        #endregion


    }


}
