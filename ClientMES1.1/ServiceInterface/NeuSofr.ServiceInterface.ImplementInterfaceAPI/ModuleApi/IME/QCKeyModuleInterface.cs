using HealthManagement.Model;
using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class QCKeyModuleInterface : AbsBaseApi<QCKeyModuleDTO, IME_QC_KEY_MODULE>, IQCKeyModuleInterface
    {
        private QCKeyModuleInfoInterface _QCKeyModuleInfoService = new QCKeyModuleInfoInterface();
        public new RtnEntity<int> Create(QCKeyModuleDTO param)
        {
            return BaseEvent.Exec(() =>
              {
                  var rtnEntityTemp = new RtnEntity<int>();
                  rtnEntityTemp.IsSuccess = false;
                  rtnEntityTemp.Data = 0;
                  param.GID = Guid.NewGuid().ToString();
                  int successNum = base.CreateWithOutTran(param);
                  if (successNum > 1 && param.QCkeyModelInfoLst != null && param.QCkeyModelInfoLst.Count() > 0)
                  {
                      if (_QCKeyModuleInfoService.BatchCreateWithOutTran(param.QCkeyModelInfoLst) == param.QCkeyModelInfoLst.Count)
                      {
                          rtnEntityTemp.IsSuccess = true;
                          rtnEntityTemp.Data = successNum;
                          return rtnEntityTemp;
                      }
                      throw new ApplicationException("插入失败");
                  }
                  return rtnEntityTemp;
              });
        }

        public RtnEntity<int> DeleteListWithChild(IEnumerable<QCKeyModuleDTO> listParam)
        {
            if (listParam == null)
                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };

            return BaseEvent.Exec<int>(() =>
            {
                //删除主表
                foreach (var item in listParam)
                {
                    int count = this.DeleteWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除主表信息返回值是0" };

                    //删除子表
                    foreach (var childItem in item.QCkeyModelInfoLst ?? new List<QCKeyModuleInfoDTO>())
                    {
                        count = this._QCKeyModuleInfoService.DeleteWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });
        }

        public new RtnEntity<int> BatchCreate(IEnumerable<QCKeyModuleDTO> listParam)
        {
            return BaseEvent.Exec(() =>
            {
                var rtnEntityTemp = new RtnEntity<int>();
                rtnEntityTemp.IsSuccess = false;
                rtnEntityTemp.Data = 0;
                if (this.BatchCreateWithOutTran(listParam) == listParam.Count())
                {
                    foreach (var item in listParam)
                    {
                        if (item.QCkeyModelInfoLst != null && item.QCkeyModelInfoLst.Count() > 0)
                        {
                            foreach (var info in item.QCkeyModelInfoLst)
                            {
                                info.IME_QC_KEY_MODULE_GID = item.GID;
                            }
                            if (_QCKeyModuleInfoService.BatchCreateWithOutTran(item.QCkeyModelInfoLst) == item.QCkeyModelInfoLst.Count)
                            {
                                rtnEntityTemp.IsSuccess = true;
                                rtnEntityTemp.Data = item.QCkeyModelInfoLst.Count();
                                return rtnEntityTemp;
                            }
                        }
                    }
                }
                throw new ApplicationException("插入失败");
            });
        }

        public new QCKeyModuleDTO GetModelByGid(string gid)
        {
            var QCkeyModel = base.GetModelByGid(gid);
            if (QCkeyModel != null)
            {
                QCkeyModel.QCkeyModelInfoLst = _QCKeyModuleInfoService.GetListByExpr(p => p.IME_QC_KEY_MODULE_GID == QCkeyModel.GID).ToList();
            }
            return QCkeyModel;
        }

        public new IEnumerable<QCKeyModuleDTO> GetListByExpr(Expression<Func<QCKeyModuleDTO, bool>> whereParam)
        {
            var QCKeyModuleLst = base.GetListByExpr(whereParam);
            if (QCKeyModuleLst != null && QCKeyModuleLst.Count() > 0)
            {
                foreach (var item in QCKeyModuleLst)
                {
                    item.QCkeyModelInfoLst = _QCKeyModuleInfoService.GetAllList().ToList();
                }
            }
            return QCKeyModuleLst;
        }

        public new IEnumerable<QCKeyModuleDTO> GetPageList(int pageIndex, int pageSize, Expression<Func<QCKeyModuleDTO, bool>> whereParam, string orderByField, bool desc)
        {
            var QCKeyModuleLst = base.GetPageList(pageIndex, pageSize, whereParam, orderByField, desc);
            if (QCKeyModuleLst != null && QCKeyModuleLst.Count() > 0)
            {
                foreach (var item in QCKeyModuleLst)
                {
                    item.QCkeyModelInfoLst = _QCKeyModuleInfoService.GetAllList().ToList();
                }
            }
            return QCKeyModuleLst;
        }

        public new RtnEntity<int> Update(QCKeyModuleDTO Param, Expression<Func<QCKeyModuleDTO, bool>> lambdaWhere = null)
        {
            return BaseEvent.Exec(() =>
            {
                var rtnEntityTemp = new RtnEntity<int>();
                rtnEntityTemp.IsSuccess = false;
                rtnEntityTemp.Data = 0;
                int isSuccessNum = this.UpdateWithOutTran(Param, lambdaWhere);
                if (isSuccessNum > 0)
                {
                    if (Param.QCkeyModelInfoLst != null && Param.QCkeyModelInfoLst.Count > 0)
                    {
                        foreach (var item in Param.QCkeyModelInfoLst)
                        {
                            if (_QCKeyModuleInfoService.UpdateWithOutTran(item, null) < 1)
                                throw new ApplicationException("更新失败");
                        }
                    }
                    rtnEntityTemp.IsSuccess = true;
                    rtnEntityTemp.Data = isSuccessNum;
                    return rtnEntityTemp;
                }
                throw new ApplicationException("更新失败");
            });
        }

    }
}
