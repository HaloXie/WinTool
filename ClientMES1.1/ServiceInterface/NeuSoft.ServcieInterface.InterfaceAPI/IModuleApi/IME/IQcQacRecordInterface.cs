using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi
{
    public interface IQcQacRecordInterface : IBaseApi<QacRecordDTO>
    {
        //这里写该领域的私有方法
        IEnumerable<QacRecordDTO> GetListWithChild(Expression<Func<QacRecordDTO, bool>> lambdaWhere);
        RtnEntity<int> CreateListWithChild(IEnumerable<QacRecordDTO> listParam);
        RtnEntity<int> DeleteListWithChild(IEnumerable<QacRecordDTO> listParam);

        /// <summary>
        /// 根据报检获取单检验卡
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<QacRecordCheckCardDTO> GetCheckCardbyRecord(QacRecordDTO param);

        /// <summary>
        /// 根据报检单获取缺陷信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<QacRecordCkDefectCardDTO> GetDefectCardbyRecord(QacRecordDTO param);

        /// <summary>
        /// 根据检验卡获取缺陷信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        IEnumerable<QacRecordCkDefectCardDTO> GetDefectCardbyCheckCard(QacRecordDTO param);
    }
}
