using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ClientDataService.ProduceDataAccess.ModelData
{
    public class ProviderIME_TRACK_ORDERDataAccess
    {
        public IME_TRACK_ORDER GetIME_TRACK_ORDERModelByGuid(string guid)
        {
            return DbHelper.dbSession.From<IME_TRACK_ORDER>().Where(s => s.GID == guid).ToFirstDefault();
        }
    }
}
