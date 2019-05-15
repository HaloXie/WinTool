using NeuSoft.DataService.ProduceDataAccess;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.DataService.ProduceBusiness
{
    public class ProviderProduceService
    {

        private ProviderProduceData providerProduceData = new ProviderProduceData();
        public List<ProduceOrderInfo> GetProduceOrderInfoList(int SourceProduceOrderID)
        {
            return providerProduceData.GetProduceOrderInfoList(SourceProduceOrderID);
        }
        public SourceProduceOrderInfo GetSourceProduceOrderInfo(string SourceGuid)
        {
            return providerProduceData.GetSourceProduceOrderInfo(SourceGuid);
        }

        public List<SourceProduceOrderInfo> GetSourceProduceOrderInfoAllList()
        {
             return providerProduceData.GetSourceProduceOrderInfoAllList();
        }
    }
}
