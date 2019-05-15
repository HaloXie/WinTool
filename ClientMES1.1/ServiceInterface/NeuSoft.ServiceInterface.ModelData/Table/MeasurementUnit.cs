using Dos.ORM;
using System; 
using System.Data; 

namespace NeuSoft.ServiceInterface.ModelData.Table
{
/// <summary>
	/// 实体类MeasurementUnit 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class MeasurementUnit : Entity 
	{
		public MeasurementUnit():base("MeasurementUnit") {}

		#region Model
		private string _MeasurementUnitGuid;
		private string _Code;
		private string _Name;
		private string _EnglishName;
		private string _Type;
		private bool? _IsBasicUnit;
		private decimal? _ConversionFactor;
		private long? _DecimalDigit;
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
		public string MeasurementUnitGuid
		{
			get{ return _MeasurementUnitGuid; }
			set
			{
				this.OnPropertyValueChange(_.MeasurementUnitGuid,_MeasurementUnitGuid,value);
				this._MeasurementUnitGuid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			get{ return _Code; }
			set
			{
				this.OnPropertyValueChange(_.Code,_Code,value);
				this._Code=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			get{ return _Name; }
			set
			{
				this.OnPropertyValueChange(_.Name,_Name,value);
				this._Name=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnglishName
		{
			get{ return _EnglishName; }
			set
			{
				this.OnPropertyValueChange(_.EnglishName,_EnglishName,value);
				this._EnglishName=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			get{ return _Type; }
			set
			{
				this.OnPropertyValueChange(_.Type,_Type,value);
				this._Type=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsBasicUnit
		{
			get{ return _IsBasicUnit; }
			set
			{
				this.OnPropertyValueChange(_.IsBasicUnit,_IsBasicUnit,value);
				this._IsBasicUnit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ConversionFactor
		{
			get{ return _ConversionFactor; }
			set
			{
				this.OnPropertyValueChange(_.ConversionFactor,_ConversionFactor,value);
				this._ConversionFactor=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? DecimalDigit
		{
			get{ return _DecimalDigit; }
			set
			{
				this.OnPropertyValueChange(_.DecimalDigit,_DecimalDigit,value);
				this._DecimalDigit=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsDelete
		{
			get{ return _IsDelete; }
			set
			{
				this.OnPropertyValueChange(_.IsDelete,_IsDelete,value);
				this._IsDelete=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsActive
		{
			get{ return _IsActive; }
			set
			{
				this.OnPropertyValueChange(_.IsActive,_IsActive,value);
				this._IsActive=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateBy
		{
			get{ return _CreateBy; }
			set
			{
				this.OnPropertyValueChange(_.CreateBy,_CreateBy,value);
				this._CreateBy=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UpdateBy
		{
			get{ return _UpdateBy; }
			set
			{
				this.OnPropertyValueChange(_.UpdateBy,_UpdateBy,value);
				this._UpdateBy=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			get{ return _CreateTime; }
			set
			{
				this.OnPropertyValueChange(_.CreateTime,_CreateTime,value);
				this._CreateTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			get{ return _UpdateTime; }
			set
			{
				this.OnPropertyValueChange(_.UpdateTime,_UpdateTime,value);
				this._UpdateTime=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessUnitGuid
		{
			get{ return _BusinessUnitGuid; }
			set
			{
				this.OnPropertyValueChange(_.BusinessUnitGuid,_BusinessUnitGuid,value);
				this._BusinessUnitGuid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BusinessGroupGuid
		{
			get{ return _BusinessGroupGuid; }
			set
			{
				this.OnPropertyValueChange(_.BusinessGroupGuid,_BusinessGroupGuid,value);
				this._BusinessGroupGuid=value;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? VersionNum
		{
			get{ return _VersionNum; }
			set
			{
				this.OnPropertyValueChange(_.VersionNum,_VersionNum,value);
				this._VersionNum=value;
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
				_.MeasurementUnitGuid,
				_.Code,
				_.Name,
				_.EnglishName,
				_.Type,
				_.IsBasicUnit,
				_.ConversionFactor,
				_.DecimalDigit,
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
				this._MeasurementUnitGuid,
				this._Code,
				this._Name,
				this._EnglishName,
				this._Type,
				this._IsBasicUnit,
				this._ConversionFactor,
				this._DecimalDigit,
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
			this._MeasurementUnitGuid = DataUtils.ConvertValue<string>(reader["MeasurementUnitGuid"]);
			this._Code = DataUtils.ConvertValue<string>(reader["Code"]);
			this._Name = DataUtils.ConvertValue<string>(reader["Name"]);
			this._EnglishName = DataUtils.ConvertValue<string>(reader["EnglishName"]);
			this._Type = DataUtils.ConvertValue<string>(reader["Type"]);
			this._IsBasicUnit = DataUtils.ConvertValue<bool?>(reader["IsBasicUnit"]);
			this._ConversionFactor = DataUtils.ConvertValue<decimal?>(reader["ConversionFactor"]);
			this._DecimalDigit = DataUtils.ConvertValue<long?>(reader["DecimalDigit"]);
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
			this._MeasurementUnitGuid = DataUtils.ConvertValue<string>(row["MeasurementUnitGuid"]);
			this._Code = DataUtils.ConvertValue<string>(row["Code"]);
			this._Name = DataUtils.ConvertValue<string>(row["Name"]);
			this._EnglishName = DataUtils.ConvertValue<string>(row["EnglishName"]);
			this._Type = DataUtils.ConvertValue<string>(row["Type"]);
			this._IsBasicUnit = DataUtils.ConvertValue<bool?>(row["IsBasicUnit"]);
			this._ConversionFactor = DataUtils.ConvertValue<decimal?>(row["ConversionFactor"]);
			this._DecimalDigit = DataUtils.ConvertValue<long?>(row["DecimalDigit"]);
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
			public readonly static Field All = new Field("*","MeasurementUnit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field MeasurementUnitGuid = new Field("MeasurementUnitGuid","MeasurementUnit","MeasurementUnitGuid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Code = new Field("Code","MeasurementUnit","Code");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Name = new Field("Name","MeasurementUnit","Name");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field EnglishName = new Field("EnglishName","MeasurementUnit","EnglishName");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field Type = new Field("Type","MeasurementUnit","Type");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsBasicUnit = new Field("IsBasicUnit","MeasurementUnit","IsBasicUnit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field ConversionFactor = new Field("ConversionFactor","MeasurementUnit","ConversionFactor");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field DecimalDigit = new Field("DecimalDigit","MeasurementUnit","DecimalDigit");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsDelete = new Field("IsDelete","MeasurementUnit","IsDelete");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field IsActive = new Field("IsActive","MeasurementUnit","IsActive");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateBy = new Field("CreateBy","MeasurementUnit","CreateBy");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpdateBy = new Field("UpdateBy","MeasurementUnit","UpdateBy");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field CreateTime = new Field("CreateTime","MeasurementUnit","CreateTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field UpdateTime = new Field("UpdateTime","MeasurementUnit","UpdateTime");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BusinessUnitGuid = new Field("BusinessUnitGuid","MeasurementUnit","BusinessUnitGuid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field BusinessGroupGuid = new Field("BusinessGroupGuid","MeasurementUnit","BusinessGroupGuid");
			/// <summary>
			/// 
			/// </summary>
			public readonly static Field VersionNum = new Field("VersionNum","MeasurementUnit","VersionNum");
		}
		#endregion


	}


}
