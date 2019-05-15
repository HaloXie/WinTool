using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace NeuSoft.DataService.ProduceDataAccess
{
    /// <summary>
    /// 无切换数据库的意思，无需编写接口继承
    /// </summary>
    public class ProviderProduceData
    {
        public List<ProduceOrderInfo> GetProduceOrderInfoList(int SourceProduceOrderID)
        {
            List<ProduceOrderInfo> list = new List<ProduceOrderInfo>();
            //此处*不要优化，以防后期DTO修改dto，无需修改代码，后期确定了字段在优化也不迟
            string sqlCommandText = @"select * from ProduceOrderInfo where SourceProduceOrderID = @SourceProduceOrderID";
            SQLiteParameter[] sqliteParameter = new SQLiteParameter[] {
                new SQLiteParameter ("@SourceProduceOrderID",SourceProduceOrderID)
        };
            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameter))
            {
                if (sqliteDataReader != null && sqliteDataReader.HasRows)
                {
                    while (sqliteDataReader.Read())
                    {
                        ProduceOrderInfo produceOrderInfo = new ProduceOrderInfo();
                        produceOrderInfo.ProduceOrderID = sqliteDataReader.GetInt32(0);
                        produceOrderInfo.SourceProduceOrderID = sqliteDataReader.GetInt32(1);
                        produceOrderInfo.OrderGuid = sqliteDataReader.GetString(2);
                        produceOrderInfo.OrderCode = sqliteDataReader.GetString(3);
                        produceOrderInfo.CalculateBeginTime = sqliteDataReader.GetDateTime(4);
                        produceOrderInfo.CalculateEndTime = sqliteDataReader.GetDateTime(5);
                        produceOrderInfo.OrderStatus = sqliteDataReader.GetInt32(6);
                        produceOrderInfo.PlanBeginTime = sqliteDataReader.GetDateTime(7);
                        produceOrderInfo.PlanEndTime = sqliteDataReader.GetDateTime(8);
                        produceOrderInfo.PlanQuantity = sqliteDataReader.GetInt32(9);
                        produceOrderInfo.ProcessName = sqliteDataReader.GetString(10);
                        produceOrderInfo.ProcessCode = sqliteDataReader.GetString(11);
                        produceOrderInfo.MaterialCode = sqliteDataReader.GetString(12);
                        produceOrderInfo.MaterialName = sqliteDataReader.GetString(13);
                        list.Add(produceOrderInfo);
                    }
                }
            }
            return list;
        }

        public List<ProduceOrderInfo> GetProduceOrderInfoAllList()
        {
            List<ProduceOrderInfo> list = new List<ProduceOrderInfo>();
            //此处*不要优化，以防后期DTO修改dto，无需修改代码，后期确定了字段在优化也不迟
            string sqlCommandText = @"select * from ProduceOrderInfo ";
            //    SQLiteParameter[] sqliteParameter = new SQLiteParameter[] {
            //        new SQLiteParameter ("@SourceProduceOrderID",SourceProduceOrderID)
            //};
            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText))
            {
                if (sqliteDataReader != null && sqliteDataReader.HasRows)
                {
                    while (sqliteDataReader.Read())
                    {
                        ProduceOrderInfo produceOrderInfo = new ProduceOrderInfo();
                        produceOrderInfo.ProduceOrderID = sqliteDataReader.GetInt32(0);
                        produceOrderInfo.SourceProduceOrderID = sqliteDataReader.GetInt32(1);
                        produceOrderInfo.OrderGuid = sqliteDataReader.GetString(2);
                        produceOrderInfo.OrderCode = sqliteDataReader.GetString(3);
                        produceOrderInfo.CalculateBeginTime = sqliteDataReader.GetDateTime(4);
                        produceOrderInfo.CalculateEndTime = sqliteDataReader.GetDateTime(5);
                        produceOrderInfo.OrderStatus = sqliteDataReader.GetInt32(6);
                        produceOrderInfo.PlanBeginTime = sqliteDataReader.GetDateTime(7);
                        produceOrderInfo.PlanEndTime = sqliteDataReader.GetDateTime(8);
                        produceOrderInfo.PlanQuantity = sqliteDataReader.GetInt32(9);
                        produceOrderInfo.ProcessName = sqliteDataReader.GetString(10);
                        produceOrderInfo.ProcessCode = sqliteDataReader.GetString(11);
                        produceOrderInfo.MaterialCode = sqliteDataReader.GetString(12);
                        produceOrderInfo.MaterialName = sqliteDataReader.GetString(13);
                        list.Add(produceOrderInfo);
                    }
                }
            }
            return list;
        }

        public SourceProduceOrderInfo GetSourceProduceOrderInfo(string SourceGuid)
        {
            string sqlCommandText = @"select * from SourceProduceOrderInfo where OrderGuid=@OrderGuid";
            SQLiteParameter[] sqliteParameter = new SQLiteParameter[] {
                new SQLiteParameter ("@OrderGuid",SourceGuid)
            };
            SourceProduceOrderInfo sourceProduceOrderInfo = new SourceProduceOrderInfo();
            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText, System.Data.CommandType.Text, sqliteParameter))
            {
                if (sqliteDataReader != null && sqliteDataReader.HasRows)
                {

                    while (sqliteDataReader.Read())
                    {
                        sourceProduceOrderInfo.SourceProduceOrderID = sqliteDataReader.GetInt32(0);
                        sourceProduceOrderInfo.ActualQuantity = sqliteDataReader.GetInt32(1);
                        sourceProduceOrderInfo.BusinessActivityType = sqliteDataReader.GetString(2);
                        sourceProduceOrderInfo.SourceCode = sqliteDataReader.GetString(3);
                        sourceProduceOrderInfo.CreateStatus = sqliteDataReader.GetInt32(4);
                        sourceProduceOrderInfo.DeliverTime = sqliteDataReader.GetDateTime(5);
                        sourceProduceOrderInfo.SourceProduceOrderGuid = sqliteDataReader.GetString(6);
                        sourceProduceOrderInfo.IsCreateKeyParts = sqliteDataReader.GetInt32(7);
                        sourceProduceOrderInfo.IsCreateProduceOrder = sqliteDataReader.GetInt32(8);
                        sourceProduceOrderInfo.MeasureBeginTime = sqliteDataReader.GetDateTime(9);
                        sourceProduceOrderInfo.MeasureEndTime = sqliteDataReader.GetDateTime(10);
                        sourceProduceOrderInfo.PlanQuantity = sqliteDataReader.GetInt32(11);
                        sourceProduceOrderInfo.OrderGuid = sqliteDataReader.GetString(12);
                        sourceProduceOrderInfo.PriorityLevel = sqliteDataReader.GetString(13);
                        sourceProduceOrderInfo.ProcessStatus = sqliteDataReader.GetInt32(14);
                        sourceProduceOrderInfo.SourceProduceOrderPlanStartTime = sqliteDataReader.GetDateTime(15);
                        sourceProduceOrderInfo.SourceProduceOrderPlanEndTime = sqliteDataReader.GetDateTime(16);
                        sourceProduceOrderInfo.SourceProduceOrderBomStatusGuid = sqliteDataReader.GetString(17);
                        sourceProduceOrderInfo.SourceProduceOrderStatusGuid = sqliteDataReader.GetString(18);
                    }
                    return sourceProduceOrderInfo;
                }
            }
            return sourceProduceOrderInfo;
        }

        public List<SourceProduceOrderInfo> GetSourceProduceOrderInfoAllList()
        {
            string sqlCommandText = @"select * from SourceProduceOrderInfo ";

            SourceProduceOrderInfo sourceProduceOrderInfo = new SourceProduceOrderInfo();
            List<SourceProduceOrderInfo> list = new List<SourceProduceOrderInfo>();
            using (SQLiteDataReader sqliteDataReader = SqlHelper.ExecuteReader(sqlCommandText))
            {
                if (sqliteDataReader != null && sqliteDataReader.HasRows)
                {

                    while (sqliteDataReader.Read())
                    {
                        sourceProduceOrderInfo = new SourceProduceOrderInfo();
                        sourceProduceOrderInfo.SourceProduceOrderID = sqliteDataReader.GetInt32(0);
                        sourceProduceOrderInfo.ActualQuantity = sqliteDataReader.GetInt32(1);
                        sourceProduceOrderInfo.BusinessActivityType = sqliteDataReader.GetString(2);
                        sourceProduceOrderInfo.SourceCode = sqliteDataReader.GetString(3);
                        sourceProduceOrderInfo.CreateStatus = sqliteDataReader.GetInt32(4);
                        sourceProduceOrderInfo.DeliverTime = sqliteDataReader.GetDateTime(5);
                        sourceProduceOrderInfo.SourceProduceOrderGuid = sqliteDataReader.GetString(6);
                        sourceProduceOrderInfo.IsCreateKeyParts = sqliteDataReader.GetInt32(7);
                        sourceProduceOrderInfo.IsCreateProduceOrder = sqliteDataReader.GetInt32(8);
                        sourceProduceOrderInfo.MeasureBeginTime = sqliteDataReader.GetDateTime(9);
                        sourceProduceOrderInfo.MeasureEndTime = sqliteDataReader.GetDateTime(10);
                        sourceProduceOrderInfo.PlanQuantity = sqliteDataReader.GetInt32(11);
                        sourceProduceOrderInfo.OrderGuid = sqliteDataReader.GetString(12);
                        sourceProduceOrderInfo.PriorityLevel = sqliteDataReader.GetString(13);
                        sourceProduceOrderInfo.ProcessStatus = sqliteDataReader.GetInt32(14);
                        sourceProduceOrderInfo.SourceProduceOrderPlanStartTime = sqliteDataReader.GetDateTime(15);
                        sourceProduceOrderInfo.SourceProduceOrderPlanEndTime = sqliteDataReader.GetDateTime(16);
                        sourceProduceOrderInfo.SourceProduceOrderBomStatusGuid = sqliteDataReader.GetString(17);
                        sourceProduceOrderInfo.SourceProduceOrderStatusGuid = sqliteDataReader.GetString(18);
                        list.Add(sourceProduceOrderInfo);
                    }
                }
            }
            return list;
        }
    }
}
