using NeuSoft.ClientDataService.CommonDataAccess.ModelData; 
using NeuSoft.ServiceInterface.ModelData.Table; 
using System.Collections.Generic; 

namespace NeuSoft.ClientDataService.CommonBusiness.ModelBusiness
{
    public class ProviderMeasurementUnitBusiness
    {
        private ProviderMeasurementUnitData providerMeasurementUnitData = new ProviderMeasurementUnitData();
        public MeasurementUnit GetMeasurementUnitModelByGuid(string MeasurementUnitGuid)
        {
            return providerMeasurementUnitData.GetMeasurementUnitModelByGuid(MeasurementUnitGuid);
        }
        public IList<MeasurementUnit> GetMeasurementUnitAllList()
        {
            return providerMeasurementUnitData.GetMeasurementUnitAllList();
        }
    }
}
