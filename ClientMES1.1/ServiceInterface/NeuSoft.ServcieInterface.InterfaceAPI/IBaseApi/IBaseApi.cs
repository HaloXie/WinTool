using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.InterfaceAPI
{
    public interface IBaseApi<T> where T : new()
    {

        RtnEntity<int> BatchCreate(IEnumerable<T> listParam);


        RtnEntity<int> Create(T param);


        IEnumerable<T> GetAllList();


        IEnumerable<T> GetListByExpr(Expression<Func<T, bool>> lambdaWhere);


        RtnEntity<int> DeleteList(IEnumerable<T> ListParam);


        RtnEntity<int> Delete(T Param);


        RtnEntity<int> DeleteByExpr(Expression<Func<T, bool>> lambdaWhere = null);

        RtnEntity<int> UpdateList(IEnumerable<T> paramList);

        RtnEntity<int> Update(T Param, Expression<Func<T, bool>> lambdaWhere = null);


        T GetModelByGid(string Gid);

        IEnumerable<T> GetPageList(int pageIndex, int pageSize, Expression<Func<T, bool>> lambdaWhere, string orderByField, bool desc);

        int GetCount(Expression<Func<T, bool>> lambdaWhere);
    }
}
