
using Dos.ORM;
using NeuSoft.ClientDataService.CommonDataAccess.ModelData;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ClientDataService.CommonBusiness.ModelBusiness
{

    public class ProviderMaterielInfoBusiness
    {
        private ProviderMaterielInfoData providerMaterielInfoData = new ProviderMaterielInfoData();
        public MaterielInfo GetMaterielInfoModelByGuid(string MaterielInfoGuid)
        {

            return providerMaterielInfoData.GetMaterielInfoModelByGuid(MaterielInfoGuid);
        }
        public IList<MaterielInfo> GetMaterielInfoAllList()
        {
            return providerMaterielInfoData.GetMaterielInfoAllList();
        }
        public IList<MaterielInfo> GetMaterielInfoPageList(int pageIndex, int pageSize, WhereClipBuilder whereClipBuilder, Field orderByField, bool desc)
        {
            return providerMaterielInfoData.GetMaterielInfoPageList(pageIndex, pageSize, whereClipBuilder, orderByField, desc);
        }

        public IList<MaterielInfo> GetMaterielInfoList(Expression<Func<MaterielInfo, bool>> where)
        {
            return providerMaterielInfoData.GetMaterielInfoList(where);
        }
    }
}
