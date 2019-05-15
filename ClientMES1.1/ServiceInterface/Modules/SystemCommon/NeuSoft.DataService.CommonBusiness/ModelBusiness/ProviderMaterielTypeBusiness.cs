using NeuSoft.ClientDataService.CommonDataAccess.ModelData;
using NeuSoft.ServiceInterface.ModelData.Table;
using System.Collections.Generic;

namespace NeuSoft.ClientDataService.CommonBusiness.ModelBusiness
{
    public class ProviderMaterielTypeBusiness
    {
        private ProviderMaterielTypeData providerMaterielTypeData = new ProviderMaterielTypeData();
        public IList<MaterielType> GetMaterielTypeTheChildListByParentGuid(string parentGuid)
        {
            return providerMaterielTypeData.GetMaterielTypeTheChildListByParentGuid(parentGuid);
        }
        public IList<MaterielType> GetMaterielTypeAllList()
        {
            return providerMaterielTypeData.GetMaterielTypeAllList();
        }
        public MaterielType GetMaterielTypeModel(string MaterielTypeGuid)
        {
            return providerMaterielTypeData.GetMaterielTypeModel(MaterielTypeGuid);
        }
    }
}
