using NeuSoft.ClientDataService.ProduceDataAccess.ModelData;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ClientDataService.ProduceBusiness.ModelBusiness
{
    public class ProviderIME_TRACK_ORDERBusiness
    {
        ProviderIME_TRACK_ORDERDataAccess providerIME_TRACK_ORDERDataAccess = new ProviderIME_TRACK_ORDERDataAccess();
        public IME_TRACK_ORDER GetIME_TRACK_ORDERModelByGuid(string guid)
        {
            return providerIME_TRACK_ORDERDataAccess.GetIME_TRACK_ORDERModelByGuid(guid);
        }
    }
}
