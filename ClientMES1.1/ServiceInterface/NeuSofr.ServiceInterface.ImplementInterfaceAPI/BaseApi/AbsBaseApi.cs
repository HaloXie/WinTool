using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ClientDataService.BaseApiBusiness;
using NeuSoft.ServiceInterface.Common.Helper;
using NeuSoft.ServiceInterface.InterfaceAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TDTO">DTO对象</typeparam>
    /// <typeparam name="T">数据库对象</typeparam>
    public abstract class AbsBaseApi<TDTO, T> : IBaseApi<TDTO> where TDTO : new() where T : Dos.ORM.Entity, new()
    {
        #region 公共

        public ProviderBaseApiBusiness<T> provider = new ProviderBaseApiBusiness<T>();
        
        private T Convert2Delete(T param)
        {
            var prop = typeof(T).GetProperty("IS_DELETE");  // 0是未删除  1是删除
            prop.SetValue(param, decimal.Parse("1"), null);
            return param;
        }

        #endregion

        #region 带有事务

        public RtnEntity<int> BatchCreate(IEnumerable<TDTO> listParam)
        {
            return BaseEvent.Exec(() =>
            {
                var prop = typeof(TDTO).GetProperty("GID");
                foreach (var item in listParam)
                {
                    if (string.IsNullOrEmpty(prop.GetValue(item, null).ToString()))
                        prop.SetValue(item, System.Guid.NewGuid().ToString(), null);
                }

                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Create(listParam.Select<TDTO, T>(TypeHelper.SetNewObjectModel<T, TDTO>))
                };
            }
            );
        }

        public RtnEntity<int> Create(TDTO param)
        {
            return BaseEvent.Exec(() =>
            {
                var prop = typeof(TDTO).GetProperty("GID");
                if (string.IsNullOrEmpty(prop.GetValue(param, null).ToString()))
                    prop.SetValue(param, System.Guid.NewGuid().ToString(), null);

                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Create(TypeHelper.SetNewObjectModel<T, TDTO>(param))
                };
            });
        }

        public IEnumerable<TDTO> GetAllList()
        {
            return provider.GetAllList().Select<T, TDTO>(TypeHelper.SetNewObjectModel<TDTO, T>);
        }

        public IEnumerable<TDTO> GetListByExpr(Expression<Func<TDTO, bool>> lambdaWhere)
        {
            return provider.GetListByExpr(ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere)).Select<T, TDTO>(TypeHelper.SetNewObjectModel<TDTO, T>);
        }

        public RtnEntity<int> DeleteList(IEnumerable<TDTO> ListParam)
        {
            return BaseEvent.Exec<int>(() =>
            {
                //逻辑删除                
                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Update(ListParam.Select(TypeHelper.SetNewObjectModel<T, TDTO>).Select(Convert2Delete))
                };

                //物理删除
                //return new RtnEntity<int>
                //{
                //    IsSuccess = true,
                //    Data = provider.Delete(ListParam.Select(TypeHelper.SetNewObjectModel<T, TDTO>))
                //};
            });
        }

        public RtnEntity<int> Delete(TDTO Param)
        {
            return BaseEvent.Exec<int>(() =>
            {
                //逻辑删除          
                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Update(Convert2Delete(TypeHelper.SetNewObjectModel<T, TDTO>(Param)))
                };

                //物理删除
                ////return new RtnEntity<int>
                ////{
                ////    IsSuccess = true,
                ////    Data = provider.Delete(TypeHelper.SetNewObjectModel<T, TDTO>(Param))
                ////};
            });
        }

        public RtnEntity<int> DeleteByExpr(Expression<Func<TDTO, bool>> lambdaWhere = null)
        {
            return BaseEvent.Exec<int>(() =>
            {
                //逻辑删除
                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Update(Convert2Delete(new T()), ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere))
                };

                //物理删除
                //return new RtnEntity<int>
                //{
                //    IsSuccess = true,
                //    Data = provider.Delete(ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere))
                //};
            });
        }

        public RtnEntity<int> UpdateList(IEnumerable<TDTO> paramList)
        {
            return BaseEvent.Exec<int>(() =>
            {
                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    Data = provider.Update(paramList.Select(TypeHelper.SetNewObjectModel<T, TDTO>))
                };
            });
        }

        public RtnEntity<int> Update(TDTO Param, Expression<Func<TDTO, bool>> lambdaWhere = null)
        {
            return BaseEvent.Exec<int>(() =>
            {
                int data = -1;
                if (lambdaWhere == null)
                    data = provider.Update(TypeHelper.SetNewObjectModel<T, TDTO>(Param));
                else
                    data = provider.Update(TypeHelper.SetNewObjectModel<T, TDTO>(Param), ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere));
                return new RtnEntity<int> { IsSuccess = true, Data = data };
            });
        }

        public TDTO GetModelByGid(string Gid)
        {
            var obj = Expression.Parameter(typeof(T), "obj");
            var expr = Expression.Equal(Expression.PropertyOrField(obj, "GID"), Expression.Constant(Gid));
            var expr1 = Expression.NotEqual(Expression.PropertyOrField(obj, "IS_DELETE"), Expression.Constant(null));
            var expr2 = Expression.Equal(Expression.PropertyOrField(obj, "IS_DELETE"), Expression.Constant(0m, typeof(decimal?)));
            var lab = Expression.Lambda<Func<T, bool>>(Expression.AndAlso(Expression.AndAlso(expr1, expr2), expr), obj);
            return provider.GetListByExpr(lab).Select(TypeHelper.SetNewObjectModel<TDTO, T>).FirstOrDefault();
        }

        public IEnumerable<TDTO> GetPageList(int pageIndex, int pageSize, Expression<Func<TDTO, bool>> lambdaWhere, string orderByField, bool desc)
        {
            return provider.GetPageList(pageIndex, pageSize, ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere), new Dos.ORM.Field(orderByField), desc).Select<T, TDTO>(TypeHelper.SetNewObjectModel<TDTO, T>);
        }

        public int GetCount(Expression<Func<TDTO, bool>> lambdaWhere)
        {
            return provider.GetCount(ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere));
        }

        #endregion

        #region 不带有事务     

        public int BatchCreateWithOutTran(IEnumerable<TDTO> listParam)
        {
            var prop = typeof(TDTO).GetProperty("GID");
            foreach (var item in listParam)
            {
                if (string.IsNullOrEmpty(prop.GetValue(item, null).ToString()))
                    prop.SetValue(item, System.Guid.NewGuid().ToString(), null);
            }
            return provider.Create(listParam.Select<TDTO, T>(TypeHelper.SetNewObjectModel<T, TDTO>));
        }

        public int CreateWithOutTran(TDTO param)
        {
            var prop = typeof(TDTO).GetProperty("GID");
            if (string.IsNullOrEmpty(prop.GetValue(param, null).ToString()))
                prop.SetValue(param, System.Guid.NewGuid().ToString(), null);
            return provider.Create(TypeHelper.SetNewObjectModel<T, TDTO>(param));
        }

        public int DeleteWithOutTran(IEnumerable<TDTO> ListParam)
        {
            return provider.Update(ListParam.Select(TypeHelper.SetNewObjectModel<T, TDTO>).Select(Convert2Delete));
        }

        public int DeleteWithOutTran(TDTO param)
        {
            //逻辑删除           
            return provider.Update(Convert2Delete(TypeHelper.SetNewObjectModel<T, TDTO>(param)));

            //物理删除
            //return provider.Delete(TypeHelper.SetNewObjectModel<T, TDTO>(param));
        }

        public int DeleteWithOutTran(Expression<Func<TDTO, bool>> lambdaWhere = null)
        {
            //逻辑删除      
            return provider.Update(Convert2Delete(new T()), ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere));

            //物理删除
            //return provider.Delete(ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere));
        }

        public int UpdateListWithOutTran(IEnumerable<TDTO> paramList)
        {
            return provider.Update(paramList.Select(TypeHelper.SetNewObjectModel<T, TDTO>));
        }

        public int UpdateWithOutTran(TDTO Param, Expression<Func<TDTO, bool>> lambdaWhere = null)
        {
            if (lambdaWhere == null)
                return provider.Update(TypeHelper.SetNewObjectModel<T, TDTO>(Param));
            else
                return provider.Update(TypeHelper.SetNewObjectModel<T, TDTO>(Param), ExpressionHelper.ReplaceMember<TDTO, T>(lambdaWhere));
        }

        #endregion  

        public RtnEntity<TReturn> Return<TReturn>(bool status, TReturn data, string Message)
        {
            return new RtnEntity<TReturn>()
            {
                Data = data,
                ErrorMsg = Message,
                IsSuccess = status

            };
        }
    }

    public static class BaseEvent
    {
        public static RtnEntity<T> Exec<T>(Func<RtnEntity<T>> func)
        {
            //var trans = DbHelper.dbSession.BeginTransaction();
            try
            {
                RtnEntity<T> rtn = new RtnEntity<T>();

                rtn = func();
                if (rtn.IsSuccess)
                {
                    //trans.Commit();
                }
                else
                {
                    //trans.Rollback();
                    return new RtnEntity<T> { IsSuccess = false, Data = rtn.Data, ErrorMsg = rtn.ErrorMsg };
                }

                return rtn;
            }
            catch (Exception ex)
            {
                //trans.Rollback();

                return new RtnEntity<T>
                {
                    IsSuccess = false,
                    ErrorMsg = ex.Message
                };
            }
            finally
            {
                //trans.Close();
            }
        }
    }
}
