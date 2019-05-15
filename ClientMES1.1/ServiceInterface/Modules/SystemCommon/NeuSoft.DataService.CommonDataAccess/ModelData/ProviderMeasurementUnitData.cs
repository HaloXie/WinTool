using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table; 
using System.Collections.Generic; 

namespace NeuSoft.ClientDataService.CommonDataAccess.ModelData
{
    public class ProviderMeasurementUnitData
    {
        //DbHelper dataBase = new DbHelper();
        public MeasurementUnit GetMeasurementUnitModelByGuid(string MeasurementUnitGuid)
        {
            #region ado处理方式
            //string sqlCommandText = @"select * from MeasurementUnit where  MeasurementUnitGuid=@MeasurementUnitGuid";
            //MeasurementUnit measurementUnit = new MeasurementUnit();
            //SQLiteParameter[] sqliteParameters = new SQLiteParameter[] {
            //    new SQLiteParameter ("@MeasurementUnitGuid",MeasurementUnitGuid)
            //};
            //using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameters))
            //{
            //    if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //    {
            //        return measurementUnit;
            //    }
            //    while (sqliteDataReader.Read())
            //    {
            //        measurementUnit.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? measurementUnit.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //        measurementUnit.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? measurementUnit.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //        measurementUnit.Code = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Code")) == true ? measurementUnit.Code : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Code"));
            //        measurementUnit.ConversionFactor = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("ConversionFactor")) == true ? measurementUnit.ConversionFactor : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("ConversionFactor"));
            //        measurementUnit.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? measurementUnit.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //        measurementUnit.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? measurementUnit.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //        measurementUnit.DecimalDigit = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DecimalDigit")) == true ? measurementUnit.DecimalDigit : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("DecimalDigit"));
            //        measurementUnit.EnglishName = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("EnglishName")) == true ? measurementUnit.EnglishName : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("EnglishName"));
            //        measurementUnit.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? measurementUnit.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //        measurementUnit.IsBasicUnit = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsBasicUnit")) == true ? measurementUnit.IsBasicUnit : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsBasicUnit"));
            //        measurementUnit.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? measurementUnit.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //        measurementUnit.MeasurementUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MeasurementUnitGuid")) == true ? measurementUnit.MeasurementUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MeasurementUnitGuid"));
            //        measurementUnit.Name = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Name")) == true ? measurementUnit.Name : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Name"));
            //        measurementUnit.Type = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Type")) == true ? measurementUnit.Type : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Type"));
            //        measurementUnit.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? measurementUnit.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //        measurementUnit.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? measurementUnit.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //        measurementUnit.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? measurementUnit.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //    }
            //}
            //return measurementUnit; 
            #endregion
            MeasurementUnit measurementUnit = DbHelper.dbSession.From<MeasurementUnit>().Where(m => m.MeasurementUnitGuid == MeasurementUnitGuid).ToFirstDefault();

            return measurementUnit;
        }
        public IList<MeasurementUnit> GetMeasurementUnitAllList()
        {
            #region ado方式
            //string sqlCommandText = @"select * from MeasurementUnit ";
            //IList<MeasurementUnit> list = new List<MeasurementUnit>();
            //using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText))
            //{
            //    if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //    {
            //        return list;
            //    }
            //    while (sqliteDataReader.Read())
            //    {
            //        MeasurementUnit measurementUnit = new MeasurementUnit();
            //        measurementUnit.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? measurementUnit.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //        measurementUnit.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? measurementUnit.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //        measurementUnit.Code = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Code")) == true ? measurementUnit.Code : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Code"));
            //        measurementUnit.ConversionFactor = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("ConversionFactor")) == true ? measurementUnit.ConversionFactor : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("ConversionFactor"));
            //        measurementUnit.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? measurementUnit.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //        measurementUnit.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? measurementUnit.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //        measurementUnit.DecimalDigit = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DecimalDigit")) == true ? measurementUnit.DecimalDigit : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("DecimalDigit"));
            //        measurementUnit.EnglishName = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("EnglishName")) == true ? measurementUnit.EnglishName : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("EnglishName"));
            //        measurementUnit.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? measurementUnit.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //        measurementUnit.IsBasicUnit = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsBasicUnit")) == true ? measurementUnit.IsBasicUnit : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsBasicUnit"));
            //        measurementUnit.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? measurementUnit.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //        measurementUnit.MeasurementUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MeasurementUnitGuid")) == true ? measurementUnit.MeasurementUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MeasurementUnitGuid"));
            //        measurementUnit.Name = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Name")) == true ? measurementUnit.Name : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Name"));
            //        measurementUnit.Type = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Type")) == true ? measurementUnit.Type : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Type"));
            //        measurementUnit.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? measurementUnit.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //        measurementUnit.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? measurementUnit.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //        measurementUnit.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? measurementUnit.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //        list.Add(measurementUnit);
            //    }
            //}  
            //return list;
            #endregion
            IList<MeasurementUnit> list = DbHelper.dbSession.From<MeasurementUnit>().ToList();
            return list;
        }


    }
}
