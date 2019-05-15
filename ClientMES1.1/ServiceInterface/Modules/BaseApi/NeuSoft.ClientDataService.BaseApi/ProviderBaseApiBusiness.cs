using Dos.ORM;
using NeuSoft.ClientDataService.BaseApiDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ClientDataService.BaseApiBusiness
{
    public class ProviderBaseApiBusiness<T> where T : Entity, new()
    {
        private ProviderBaseApiDataAccess<T> provider = new ProviderBaseApiDataAccess<T>();

        #region 创建

        public int Create(IEnumerable<T> ListParam)
        {
            return provider.Create(ListParam);
        }

        public int Create(T Param)
        {
            return provider.Create(Param);
        }

        #endregion

        #region 查询

        public IList<T> GetAllList()
        {
            return provider.GetAllList();
        }

        public IList<T> GetListByExpr(Expression<Func<T, bool>> Param)
        {
            return provider.GetListByExpr(Param);
        }

        public IList<T> GetPageList(int pageIndex, int pageSize, Expression<Func<T, bool>> whereParam, Field orderByField, bool desc)
        {
            return provider.GetPageList(pageIndex, pageSize, whereParam, orderByField, desc);
        }

        public int GetCount(Expression<Func<T, bool>> lambdaWhere)
        {
            return provider.GetCount(lambdaWhere);
        }

        #endregion

        #region 修改

        public int Update(T Param, Expression<Func<T, bool>> lambdaWhere = null)
        {
            if (lambdaWhere == null)
                return provider.Update(Param);
            else
                return provider.Update(Param, lambdaWhere);
        }

        public int Update(IEnumerable<T> ListParam)
        {
            return provider.Update(ListParam);
        }

        #endregion

        #region 删除

        public int Delete(T Param)
        {
            return provider.Delete(Param);
        }

        public int Delete(IEnumerable<T> ListParam)
        {
            return provider.Delete(ListParam);
        }

        public int Delete(Expression<Func<T, bool>> lambdaWhere)
        {
            return provider.Delete(lambdaWhere);
        }

        #endregion
    }
}
