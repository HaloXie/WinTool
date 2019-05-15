using NeuSoft.Client.InterfaceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi
{
    public interface IOperationInfoInterface : IBaseApi<OperationInfoDTO>
    {
        //这里写该领域的私有方法

        /// <summary>
        /// 获取主子表相应的信息
        /// </summary>
        /// <param name="lambdaWhere"></param>
        /// <returns></returns>
        IEnumerable<OperationInfoDTO> GetListWithChild(Expression<Func<OperationInfoDTO, bool>> lambdaWhere);

        /// <summary>
        /// 创建数据且含有子表信息
        /// </summary>
        /// <param name="listParam"></param>
        /// <returns></returns>
        RtnEntity<int> CreateListWithChild(IEnumerable<OperationInfoDTO> listParam);

		/// <summary>
        /// 删除数据且含有子表信息
        /// </summary>
        /// <param name="listParam"></param>
        /// <returns></returns>
		RtnEntity<int> DeleteListWithChild(IEnumerable<OperationInfoDTO> listParam);
    }
}
