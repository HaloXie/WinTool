using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table;
using System.Collections.Generic;

namespace NeuSoft.ClientDataService.CommonDataAccess.ModelData
{
    public class ProviderMaterielTypeData
    {
       
        public IList<MaterielType> GetMaterielTypeTheChildListByParentGuid(string parentGuid)
        {
            #region ado方式
            //    IList<MaterielType> list = new List<MaterielType>();
            //    string sqlCommandText = @"select * from MaterielType  where TypeParentGuid=@TypeParentGuid";
            //    SQLiteParameter[] sqliteParameter = new SQLiteParameter[] {
            //        new SQLiteParameter ("@TypeParentGuid",parentGuid)
            //};
            //    using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameter))
            //    {
            //        if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //        {
            //            return list;
            //        }
            //        while (sqliteDataReader.Read())
            //        {
            //            MaterielType materielType = new MaterielType();
            //            materielType.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? materielType.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //            materielType.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? materielType.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //            materielType.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? materielType.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //            materielType.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? materielType.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //            materielType.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? materielType.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //            materielType.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? materielType.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //            materielType.MaterielTypeGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielTypeGuid")) == true ? materielType.MaterielTypeGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielTypeGuid"));
            //            materielType.TypeCode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeCode")) == true ? materielType.TypeCode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeCode"));
            //            materielType.TypeParentGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeParentGuid")) == true ? materielType.TypeParentGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeParentGuid"));
            //            materielType.TypeName = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeName")) == true ? materielType.TypeName : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeName"));
            //            materielType.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? materielType.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //            materielType.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? materielType.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //            materielType.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? materielType.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //            list.Add(materielType);
            //        }
            //    }
            //    return list; 
            #endregion
            IList<MaterielType> list = DbHelper.dbSession.From<MaterielType>().Where(m => m.TypeParentGuid == parentGuid).ToList();
            return list;
        }

        public MaterielType GetMaterielTypeModel(string MaterielTypeGuid)
        {
            #region ado方式
            //MaterielType materielType = new MaterielType();
            //string sqlCommandText = @"select * from MaterielType where  MaterielTypeGuid=@MaterielTypeGuid";
            //SQLiteParameter[] sqliteParameters = new SQLiteParameter[] {
            //    new SQLiteParameter ("@MaterielTypeGuid",MaterielTypeGuid)
            //};
            //using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameters))
            //{
            //    if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //    {
            //        return materielType;
            //    }
            //    while (sqliteDataReader.Read())
            //    {
            //        materielType.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? materielType.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //        materielType.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? materielType.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //        materielType.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? materielType.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //        materielType.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? materielType.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //        materielType.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? materielType.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //        materielType.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? materielType.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //        materielType.MaterielTypeGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielTypeGuid")) == true ? materielType.MaterielTypeGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielTypeGuid"));
            //        materielType.TypeCode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeCode")) == true ? materielType.TypeCode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeCode"));
            //        materielType.TypeParentGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeParentGuid")) == true ? materielType.TypeParentGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeParentGuid"));
            //        materielType.TypeName = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeName")) == true ? materielType.TypeName : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeName"));
            //        materielType.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? materielType.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //        materielType.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? materielType.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //        materielType.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? materielType.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //    }
            //}
            //return materielType; 
            #endregion
            MaterielType materielType = DbHelper.dbSession.From<MaterielType>().Where(m => m.MaterielTypeGuid == MaterielTypeGuid).ToFirstDefault();
            return materielType;
        }
        public IList<MaterielType> GetMaterielTypeAllList()
        {
            #region ADO方式
            //IList<MaterielType> list = new List<MaterielType>();
            //string sqlCommandText = @"select * from MaterielType ";
            //using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText))
            //{
            //    if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //    {
            //        return list;
            //    }
            //    while (sqliteDataReader.Read())
            //    {
            //        MaterielType materielType = new MaterielType();
            //        materielType.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? materielType.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //        materielType.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? materielType.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //        materielType.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? materielType.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //        materielType.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? materielType.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //        materielType.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? materielType.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //        materielType.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? materielType.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //        materielType.MaterielTypeGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielTypeGuid")) == true ? materielType.MaterielTypeGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielTypeGuid"));
            //        materielType.TypeCode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeCode")) == true ? materielType.TypeCode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeCode"));
            //        materielType.TypeParentGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeParentGuid")) == true ? materielType.TypeParentGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeParentGuid"));
            //        materielType.TypeName = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TypeName")) == true ? materielType.TypeName : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TypeName"));
            //        materielType.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? materielType.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //        materielType.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? materielType.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //        materielType.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? materielType.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //        list.Add(materielType);
            //    }
            //}
            //return list; 
            #endregion
            IList<MaterielType> list = DbHelper.dbSession.From<MaterielType>().ToList();
            return list;
        }
    }
}