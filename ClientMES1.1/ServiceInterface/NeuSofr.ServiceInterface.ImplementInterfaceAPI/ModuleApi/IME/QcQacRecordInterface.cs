using NeuSoft.Client.InterfaceDTO;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi
{
    public class QcQacRecordInterface : AbsBaseApi<QacRecordDTO, IME_QC_QAC_RECORD>, IQcQacRecordInterface
    {
        //这里写该领域的私有方法
        //这里写该领域的私有方法        
        private QcQacRecordCheckCardInterface ChildInterface = new QcQacRecordCheckCardInterface();
        private QcQacRecCkDefectcardInterface ChildChildInterface = new QcQacRecCkDefectcardInterface();

        //这里写该领域的私有方法
        public IEnumerable<QacRecordDTO> GetListWithChild(Expression<Func<QacRecordDTO, bool>> lambdaWhere)
        {
            var list = this.GetListByExpr(lambdaWhere);
            if (list == null) return null;
            foreach (var item in list)
            {
                item.ListQacRecordCheckCardDTO = ChildInterface.GetListByExpr(x => x.IME_QC_QAC_RECORD_GID == item.GID);
                foreach (var itemChild in item.ListQacRecordCheckCardDTO ?? new List<QacRecordCheckCardDTO>())
                {
                    itemChild.ListQacRecordCkDefectCardDTO = ChildChildInterface.GetListByExpr(x => x.IME_QC_QAC_RECORD_CKCARD_GID == itemChild.GID);
                }
            }
            return list;
        }

        public RtnEntity<int> CreateListWithChild(IEnumerable<QacRecordDTO> listParam)
        {
            if (listParam == null)
                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "参数不能为NULL" };

            return BaseEvent.Exec<int>(() =>
            {
                //创建主表
                foreach (var item in listParam)
                {
                    int count = this.CreateWithOutTran(item);
                    if (count == 0)
                        return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建主表信息返回值是0" };
                    //创建子表
                    foreach (var childItem in item.ListQacRecordCheckCardDTO ?? new List<QacRecordCheckCardDTO>())
                    {
                        count = this.ChildInterface.CreateWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };

                        //创建孙表
                        var tempChildChild = childItem.ListQacRecordCkDefectCardDTO as List<QacRecordCkDefectCardDTO>;
                        if (tempChildChild == null || tempChildChild.Count == 0) continue;
                        count = this.ChildChildInterface.BatchCreateWithOutTran(tempChildChild);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "创建子表信息返回值是0" };
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });
        }

        public RtnEntity<int> DeleteListWithChild(IEnumerable<QacRecordDTO> listParam)
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
                    foreach (var childItem in item.ListQacRecordCheckCardDTO ?? new List<QacRecordCheckCardDTO>())
                    {
                        count = this.ChildInterface.DeleteWithOutTran(childItem);
                        if (count == 0)
                            return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除子表信息返回值是0" };

                        //删除孙表
                        var tempChildChild = childItem.ListQacRecordCkDefectCardDTO as List<QacRecordCkDefectCardDTO>;
                        if (tempChildChild != null && tempChildChild.Count > 0)
                        {
                            count = this.ChildChildInterface.DeleteWithOutTran(tempChildChild);
                            if (count == 0 || count != tempChildChild.Count)
                                return new RtnEntity<int> { IsSuccess = false, ErrorMsg = "删除孙表信息返回值是0" };
                        }
                    }
                }
                return new RtnEntity<int> { IsSuccess = true };
            });

        }

        /// <summary>
        /// 根据报检获取单检验卡
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<QacRecordCheckCardDTO> GetCheckCardbyRecord(QacRecordDTO param)
        {
            if (param == null || string.IsNullOrEmpty(param.GID))
                return null;
            return ChildInterface.GetListByExpr(x => x.IME_QC_QAC_RECORD_GID == param.GID);
        }

        /// <summary>
        /// 根据报检单获取缺陷信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<QacRecordCkDefectCardDTO> GetDefectCardbyRecord(QacRecordDTO param)
        {
            if (param == null || string.IsNullOrEmpty(param.GID))
                return null;
            return ChildChildInterface.GetListByExpr(x => x.IME_QC_QAC_RECORD_GID == param.GID);
        }

        /// <summary>
        /// 根据检验卡获取缺陷信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public IEnumerable<QacRecordCkDefectCardDTO> GetDefectCardbyCheckCard(QacRecordDTO param)
        {
            if (param == null || string.IsNullOrEmpty(param.GID))
                return null;
            return ChildChildInterface.GetListByExpr(x => x.IME_QC_QAC_RECORD_CKCARD_GID == param.GID);
        }
    }
}
