using Dos.ORM;
using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ClientDataService.CommonDataAccess.ModelData
{
    public class ProviderMaterielInfoData
    {
      
        public MaterielInfo GetMaterielInfoModelByGuid(string MaterielInfoGuid)
        {
            #region ADO方式
            //            MaterielInfo materielInfo = new MaterielInfo();
            //            string sqlCommandText = @"select * from MaterielInfo where 1=1 and MaterielInfoGuid = @MaterielInfoGuid";
            //            SQLiteParameter[] sqliteParameter = new SQLiteParameter[] {
            //                new SQLiteParameter ("@MaterielInfoGuid",MaterielInfoGuid)
            //            };
            //            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameter))
            //            {
            //                if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //                {
            //                    return materielInfo;
            //                }
            //                while (sqliteDataReader.Read())
            //                {
            //#warning 后期记得此处优化封装一下改为反射赋值，前提下产品数据库表字段成熟确定后
            //                    materielInfo.Abbreviation = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Abbreviation")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Abbreviation"));
            //                    materielInfo.Alias = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Alias")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Alias"));
            //                    materielInfo.Code = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Code")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Code"));
            //                    materielInfo.DailyWorkMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkMode")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("DailyWorkMode"));
            //                    materielInfo.DailyWorkNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkNum")) == true ? materielInfo.DailyWorkNum : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("DailyWorkNum"));
            //                    materielInfo.DispatchingMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkNum")) == true ? materielInfo.DispatchingMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("DispatchingMode"));
            //                    materielInfo.FigureNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("FigureNumber")) == true ? materielInfo.FigureNumber : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("FigureNumber"));
            //                    materielInfo.FilePath = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("FilePath")) == true ? materielInfo.FilePath : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("FilePath"));
            //                    materielInfo.HomeMadePiece = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("HomeMadePiece")) == true ? materielInfo.HomeMadePiece : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("HomeMadePiece"));
            //                    materielInfo.InspectionMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("InspectionMode")) == true ? materielInfo.InspectionMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("InspectionMode"));
            //                    materielInfo.InspectionType = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("InspectionType")) == true ? materielInfo.InspectionType : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("InspectionType"));
            //                    materielInfo.IsCodeManagement = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsCodeManagement")) == true ? materielInfo.IsCodeManagement : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsCodeManagement"));
            //                    materielInfo.IsConsumptivePart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsConsumptivePart")) == true ? materielInfo.IsConsumptivePart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsConsumptivePart"));
            //                    materielInfo.IsEquipment = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsEquipment")) == true ? materielInfo.IsEquipment : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsEquipment"));
            //                    materielInfo.IsMainBom = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsMainBom")) == true ? materielInfo.IsMainBom : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsMainBom"));
            //                    materielInfo.IsProductionBatch = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsProductionBatch")) == true ? materielInfo.IsProductionBatch : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsProductionBatch"));
            //                    materielInfo.IsProductionPath = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsProductionPath")) == true ? materielInfo.IsProductionPath : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsProductionPath"));
            //                    materielInfo.IsQualityAssurance = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsQualityAssurance")) == true ? materielInfo.IsQualityAssurance : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsQualityAssurance"));
            //                    materielInfo.IsReplacementPart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsReplacementPart")) == true ? materielInfo.IsReplacementPart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsReplacementPart"));
            //                    materielInfo.IsResources = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsResources")) == true ? materielInfo.IsResources : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsResources"));
            //                    materielInfo.IsSparePart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsSparePart")) == true ? materielInfo.IsSparePart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsSparePart"));
            //                    materielInfo.IsSubstitute = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsSubstitute")) == true ? materielInfo.IsSubstitute : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsSubstitute"));
            //                    materielInfo.IsTraceBack = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsTraceBack")) == true ? materielInfo.IsTraceBack : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsTraceBack"));
            //                    materielInfo.MaterialWay = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterialWay")) == true ? materielInfo.MaterialWay : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterialWay"));
            //                    materielInfo.MaterielInfoGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielInfoGuid")) == true ? materielInfo.MaterielInfoGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielInfoGuid"));
            //                    materielInfo.MaterielTypeGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielTypeGuid")) == true ? materielInfo.MaterielTypeGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielTypeGuid"));
            //                    materielInfo.MeasurementUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MeasurementUnitGuid")) == true ? materielInfo.MeasurementUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MeasurementUnitGuid"));
            //                    materielInfo.MinProductionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MinProductionNum")) == true ? materielInfo.MinProductionNum : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("MinProductionNum"));
            //                    materielInfo.Model = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Model")) == true ? materielInfo.Model : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Model"));
            //                    materielInfo.Name = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Name")) == true ? materielInfo.Name : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Name"));
            //                    materielInfo.OutSourcing = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("OutSourcing")) == true ? materielInfo.OutSourcing : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("OutSourcing"));
            //                    materielInfo.PackNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PackNumber")) == true ? materielInfo.PackNumber : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("PackNumber"));
            //                    materielInfo.PackWay = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PackWay")) == true ? materielInfo.PackWay : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("PackWay"));
            //                    materielInfo.PersonGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PersonGuid")) == true ? materielInfo.PersonGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("PersonGuid"));
            //                    materielInfo.PieLot = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PieLot")) == true ? materielInfo.PieLot : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("PieLot"));
            //                    materielInfo.ProductionMultiple = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("ProductionMultiple")) == true ? materielInfo.ProductionMultiple : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("ProductionMultiple"));
            //                    materielInfo.PurchaseParts = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PurchaseParts")) == true ? materielInfo.PurchaseParts : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("PurchaseParts"));
            //                    materielInfo.Remark1 = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Remark1")) == true ? materielInfo.Remark1 : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Remark1"));
            //                    materielInfo.Remark2 = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Remark2")) == true ? materielInfo.Remark2 : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Remark2"));
            //                    materielInfo.SequentialMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("SequentialMode")) == true ? materielInfo.SequentialMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("SequentialMode"));
            //                    materielInfo.Specifications = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Specifications")) == true ? materielInfo.Specifications : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Specifications"));
            //                    materielInfo.TaktTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TaktTime")) == true ? materielInfo.TaktTime : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("TaktTime"));
            //                    materielInfo.TechnicsProcessGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TechnicsProcessGuid")) == true ? materielInfo.TechnicsProcessGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TechnicsProcessGuid"));
            //                    materielInfo.VersionNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNumber")) == true ? materielInfo.VersionNumber : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("VersionNumber"));
            //                    materielInfo.WarehouseGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("WarehouseGuid")) == true ? materielInfo.WarehouseGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("WarehouseGuid"));
            //                    materielInfo.WorkCenterGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("WorkCenterGuid")) == true ? materielInfo.WorkCenterGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("WorkCenterGuid"));
            //                    materielInfo.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? materielInfo.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //                    materielInfo.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? materielInfo.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //                    materielInfo.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? materielInfo.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //                    materielInfo.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? materielInfo.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //                    materielInfo.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? materielInfo.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //                    materielInfo.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? materielInfo.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //                    materielInfo.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? materielInfo.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //                    materielInfo.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? materielInfo.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //                    materielInfo.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? materielInfo.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //                }
            //            }
            //            return materielInfo; 
            #endregion

            return DbHelper.dbSession.From<MaterielInfo>().Where(m => m.MaterielInfoGuid == MaterielInfoGuid).ToFirstDefault();
        }
        public IList<MaterielInfo> GetMaterielInfoAllList()
        {
            #region ado方式
            //            List<MaterielInfo> list = new List<MaterielInfo>();
            //            string sqlCommandText = @"select * from MaterielInfo where 1=1";
            //            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText))
            //            {
            //                if (sqliteDataReader == null || !sqliteDataReader.HasRows)
            //                {
            //                    return list;
            //                }
            //                while (sqliteDataReader.Read())
            //                {
            //                    MaterielInfo materielInfo = new MaterielInfo();
            //#warning 后期记得此处优化封装一下改为反射赋值，前提下产品数据库表字段成熟确定后
            //                    materielInfo.Abbreviation = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Abbreviation")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Abbreviation"));
            //                    materielInfo.Alias = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Alias")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Alias"));
            //                    materielInfo.Code = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Code")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Code"));
            //                    materielInfo.DailyWorkMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkMode")) == true ? null : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("DailyWorkMode"));
            //                    materielInfo.DailyWorkNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkNum")) == true ? materielInfo.DailyWorkNum : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("DailyWorkNum"));
            //                    materielInfo.DispatchingMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("DailyWorkNum")) == true ? materielInfo.DispatchingMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("DispatchingMode"));
            //                    materielInfo.FigureNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("FigureNumber")) == true ? materielInfo.FigureNumber : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("FigureNumber"));
            //                    materielInfo.FilePath = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("FilePath")) == true ? materielInfo.FilePath : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("FilePath"));
            //                    materielInfo.HomeMadePiece = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("HomeMadePiece")) == true ? materielInfo.HomeMadePiece : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("HomeMadePiece"));
            //                    materielInfo.InspectionMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("InspectionMode")) == true ? materielInfo.InspectionMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("InspectionMode"));
            //                    materielInfo.InspectionType = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("InspectionType")) == true ? materielInfo.InspectionType : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("InspectionType"));
            //                    materielInfo.IsCodeManagement = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsCodeManagement")) == true ? materielInfo.IsCodeManagement : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsCodeManagement"));
            //                    materielInfo.IsConsumptivePart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsConsumptivePart")) == true ? materielInfo.IsConsumptivePart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsConsumptivePart"));
            //                    materielInfo.IsEquipment = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsEquipment")) == true ? materielInfo.IsEquipment : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsEquipment"));
            //                    materielInfo.IsMainBom = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsMainBom")) == true ? materielInfo.IsMainBom : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsMainBom"));
            //                    materielInfo.IsProductionBatch = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsProductionBatch")) == true ? materielInfo.IsProductionBatch : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsProductionBatch"));
            //                    materielInfo.IsProductionPath = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsProductionPath")) == true ? materielInfo.IsProductionPath : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsProductionPath"));
            //                    materielInfo.IsQualityAssurance = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsQualityAssurance")) == true ? materielInfo.IsQualityAssurance : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsQualityAssurance"));
            //                    materielInfo.IsReplacementPart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsReplacementPart")) == true ? materielInfo.IsReplacementPart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsReplacementPart"));
            //                    materielInfo.IsResources = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsResources")) == true ? materielInfo.IsResources : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsResources"));
            //                    materielInfo.IsSparePart = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsSparePart")) == true ? materielInfo.IsSparePart : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsSparePart"));
            //                    materielInfo.IsSubstitute = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsSubstitute")) == true ? materielInfo.IsSubstitute : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsSubstitute"));
            //                    materielInfo.IsTraceBack = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsTraceBack")) == true ? materielInfo.IsTraceBack : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsTraceBack"));
            //                    materielInfo.MaterialWay = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterialWay")) == true ? materielInfo.MaterialWay : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterialWay"));
            //                    materielInfo.MaterielInfoGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielInfoGuid")) == true ? materielInfo.MaterielInfoGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielInfoGuid"));
            //                    materielInfo.MaterielTypeGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MaterielTypeGuid")) == true ? materielInfo.MaterielTypeGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MaterielTypeGuid"));
            //                    materielInfo.MeasurementUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MeasurementUnitGuid")) == true ? materielInfo.MeasurementUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("MeasurementUnitGuid"));
            //                    materielInfo.MinProductionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("MinProductionNum")) == true ? materielInfo.MinProductionNum : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("MinProductionNum"));
            //                    materielInfo.Model = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Model")) == true ? materielInfo.Model : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Model"));
            //                    materielInfo.Name = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Name")) == true ? materielInfo.Name : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Name"));
            //                    materielInfo.OutSourcing = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("OutSourcing")) == true ? materielInfo.OutSourcing : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("OutSourcing"));
            //                    materielInfo.PackNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PackNumber")) == true ? materielInfo.PackNumber : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("PackNumber"));
            //                    materielInfo.PackWay = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PackWay")) == true ? materielInfo.PackWay : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("PackWay"));
            //                    materielInfo.PersonGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PersonGuid")) == true ? materielInfo.PersonGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("PersonGuid"));
            //                    materielInfo.PieLot = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PieLot")) == true ? materielInfo.PieLot : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("PieLot"));
            //                    materielInfo.ProductionMultiple = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("ProductionMultiple")) == true ? materielInfo.ProductionMultiple : sqliteDataReader.GetDecimal(sqliteDataReader.GetOrdinal("ProductionMultiple"));
            //                    materielInfo.PurchaseParts = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("PurchaseParts")) == true ? materielInfo.PurchaseParts : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("PurchaseParts"));
            //                    materielInfo.Remark1 = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Remark1")) == true ? materielInfo.Remark1 : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Remark1"));
            //                    materielInfo.Remark2 = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Remark2")) == true ? materielInfo.Remark2 : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Remark2"));
            //                    materielInfo.SequentialMode = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("SequentialMode")) == true ? materielInfo.SequentialMode : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("SequentialMode"));
            //                    materielInfo.Specifications = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("Specifications")) == true ? materielInfo.Specifications : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("Specifications"));
            //                    materielInfo.TaktTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TaktTime")) == true ? materielInfo.TaktTime : sqliteDataReader.GetInt64(sqliteDataReader.GetOrdinal("TaktTime"));
            //                    materielInfo.TechnicsProcessGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("TechnicsProcessGuid")) == true ? materielInfo.TechnicsProcessGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("TechnicsProcessGuid"));
            //                    materielInfo.VersionNumber = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNumber")) == true ? materielInfo.VersionNumber : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("VersionNumber"));
            //                    materielInfo.WarehouseGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("WarehouseGuid")) == true ? materielInfo.WarehouseGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("WarehouseGuid"));
            //                    materielInfo.WorkCenterGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("WorkCenterGuid")) == true ? materielInfo.WorkCenterGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("WorkCenterGuid"));
            //                    materielInfo.IsDelete = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsDelete")) == true ? materielInfo.IsDelete : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsDelete"));
            //                    materielInfo.IsActive = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("IsActive")) == true ? materielInfo.IsActive : sqliteDataReader.GetBoolean(sqliteDataReader.GetOrdinal("IsActive"));
            //                    materielInfo.CreateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateBy")) == true ? materielInfo.CreateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("CreateBy"));
            //                    materielInfo.UpdateBy = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateBy")) == true ? materielInfo.UpdateBy : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("UpdateBy"));
            //                    materielInfo.CreateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("CreateTime")) == true ? materielInfo.CreateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("CreateTime"));
            //                    materielInfo.UpdateTime = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("UpdateTime")) == true ? materielInfo.UpdateTime : sqliteDataReader.GetDateTime(sqliteDataReader.GetOrdinal("UpdateTime"));
            //                    materielInfo.BusinessUnitGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessUnitGuid")) == true ? materielInfo.BusinessUnitGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessUnitGuid"));
            //                    materielInfo.BusinessGroupGuid = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("BusinessGroupGuid")) == true ? materielInfo.BusinessGroupGuid : sqliteDataReader.GetString(sqliteDataReader.GetOrdinal("BusinessGroupGuid"));
            //                    materielInfo.VersionNum = sqliteDataReader.IsDBNull(sqliteDataReader.GetOrdinal("VersionNum")) == true ? materielInfo.VersionNum : sqliteDataReader.GetInt32(sqliteDataReader.GetOrdinal("VersionNum"));
            //                    list.Add(materielInfo);
            //                }
            //            }
            //            return list; 
            #endregion

            //设置缓存300秒

            var a = DbHelper.dbSession.From<MaterielInfo>();
            return a.ToList();
        }

        public IList<MaterielInfo> GetMaterielInfoPageList(int pageIndex, int pageSize, WhereClipBuilder whereClipBuilder, Field orderByField, bool desc)
        {
#warning 后期看改框架运行机制，若与ef等orm框架不一样当延迟加载当tolist在查询的话，就这样，如不是，那就这段代码修改一下，减少代码代码沉余代码
             
            if (desc)
            {
                return whereClipBuilder == null ?
                    (
                    orderByField == null
                    ? DbHelper.dbSession.From<MaterielInfo>().Page(pageSize, pageIndex).ToList()
                    : DbHelper.dbSession.From<MaterielInfo>().OrderByDescending(orderByField).Page(pageSize, pageIndex).ToList()
                    ) :
                  (
                  orderByField == null
                    ? DbHelper.dbSession.From<MaterielInfo>().Where(whereClipBuilder.ToWhereClip()).Page(pageSize, pageIndex).ToList()
                    : DbHelper.dbSession.From<MaterielInfo>().Where(whereClipBuilder.ToWhereClip()).OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                    );
            }
            return whereClipBuilder == null ?
                      (
                      orderByField == null
                      ? DbHelper.dbSession.From<MaterielInfo>().Page(pageSize, pageIndex).ToList()
                      : DbHelper.dbSession.From<MaterielInfo>().OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                      ) :
                        orderByField == null
                      ? DbHelper.dbSession.From<MaterielInfo>().Where(whereClipBuilder.ToWhereClip()).OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                      : DbHelper.dbSession.From<MaterielInfo>().Where(whereClipBuilder.ToWhereClip()).OrderBy(orderByField).Page(pageSize, pageIndex).ToList();
        }
        public IList<MaterielInfo> GetMaterielInfoList(Expression<Func<MaterielInfo, bool>> where)
        {
            return DbHelper.dbSession.From<MaterielInfo>().Where(where).ToList();
        } 
    }
}
