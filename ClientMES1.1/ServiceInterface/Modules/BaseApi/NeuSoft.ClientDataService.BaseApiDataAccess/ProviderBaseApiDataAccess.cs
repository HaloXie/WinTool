using Dos.ORM;
using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace NeuSoft.ClientDataService.BaseApiDataAccess
{
    public class ProviderBaseApiDataAccess<T> where T : Entity, new()
    {
        public ProviderBaseApiDataAccess()
        {

        }

        #region 创建

        public int Create(IEnumerable<T> ListParam)
        {
            return DbHelper.dbSession.Insert<T>(ListParam);
        }

        public int Create(T param)
        {
            return DbHelper.dbSession.Insert<T>(param);
        }

        #endregion

        #region 查询

        public IList<T> GetAllList()
        {
            return DbHelper.dbSession.From<T>().ToList(); 
        }

        public IList<T> GetListByExpr(Expression<Func<T, bool>> Param)
        {
            return DbHelper.dbSession.From<T>().Where(Param).ToList();
        }

        public IList<T> GetPageList(int pageIndex, int pageSize, Expression<Func<T, bool>> whereParam, Field orderByField, bool desc)
        {
            if (desc)
            {
                return whereParam == null ?
                    (
                    orderByField == null
                    ? DbHelper.dbSession.From<T>().Page(pageSize, pageIndex).ToList()
                    : DbHelper.dbSession.From<T>().OrderByDescending(orderByField).Page(pageSize, pageIndex).ToList()
                    ) :
                  (
                  orderByField == null
                    ? DbHelper.dbSession.From<T>().Where(whereParam).Page(pageSize, pageIndex).ToList()
                    : DbHelper.dbSession.From<T>().Where(whereParam).OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                    );
            }
            return whereParam == null ?
                      (
                      orderByField == null
                      ? DbHelper.dbSession.From<T>().Page(pageSize, pageIndex).ToList()
                      : DbHelper.dbSession.From<T>().OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                      ) :
                        orderByField == null
                      ? DbHelper.dbSession.From<T>().Where(whereParam).OrderBy(orderByField).Page(pageSize, pageIndex).ToList()
                      : DbHelper.dbSession.From<T>().Where(whereParam).OrderBy(orderByField).Page(pageSize, pageIndex).ToList();

        }

        public int GetCount(Expression<Func<T, bool>> lambdaWhere)
        {
            return DbHelper.dbSession.Count<T>(lambdaWhere);
        }

        #endregion

        #region 修改

        public int Update(T Param)
        {
            return DbHelper.dbSession.Update<T>(Param);
        }

        public int Update(T Param, Expression<Func<T, bool>> lambdaWhere)
        {
            return DbHelper.dbSession.Update<T>(Param, lambdaWhere);
        }

        public int Update(IEnumerable<T> ListParam)
        {
            return DbHelper.dbSession.Update<T>(ListParam);
        }

        #endregion

        #region 删除

        public int Delete(T Param)
        {
            return DbHelper.dbSession.Delete<T>(Param);
        }

        public int Delete(IEnumerable<T> ListParam)
        {
            return DbHelper.dbSession.Delete<T>(ListParam);
        }

        public int Delete(Expression<Func<T, bool>> lambdaWhere)
        {
            return DbHelper.dbSession.Delete<T>(lambdaWhere);
        }

        #endregion

    }
}
 