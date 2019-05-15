using NeuSoft.Client.InterfaceDTO;
using NeuSoft.Client.InterfaceDTO.IME;
using NeuSoft.ClientDataService.ProduceBusiness.ModelBusiness;
using NeuSoft.ServiceInterface.InterfaceAPI.IModuleApi.IME;
using NeuSoft.ServiceInterface.ModelData.Table;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NeuSoft.ServiceInterface.ImplementInterfaceAPI.ModuleApi.IME
{
    public class ReportOrderInterface : AbsBaseApi<ReportOrderDTO, IME_REPORT_ORDER>, IReportOrderInterface
    {
        public RtnEntity<int> RecordProduce(ReportOrderDTO reportOrderDTO)
        {
            if (string.IsNullOrEmpty(reportOrderDTO.RESOURCE_ORDER_GID) || string.IsNullOrEmpty(reportOrderDTO.ORIGIN_TRACK_GID))
            {
                base.Return<int>(false, 1, "未填写参数");
            }
            RtnEntity<bool> rtnEntity = CheckCanRecordProduce(reportOrderDTO);
            bool boolResult = rtnEntity.IsSuccess == false ? false : rtnEntity.Data == false ? false : true;
            if (boolResult)
            {
                base.Create(reportOrderDTO);
                return new RtnEntity<int>
                {
                    IsSuccess = true,
                    ErrorMsg = "报工成功",
                    Data = 1
                };
            }
            return new RtnEntity<int>()
            {
                Data = 2,
                IsSuccess = false,
                ErrorMsg = "验证不通过，请先调用CheckCanRecordProduce方法校验一下"
            };

        }

        public RtnEntity<bool> CheckCanRecordProduce(ReportOrderDTO reportOrderDTO)
        {
            if (string.IsNullOrEmpty(reportOrderDTO.RESOURCE_ORDER_GID) || string.IsNullOrEmpty(reportOrderDTO.ORIGIN_TRACK_GID))
            {
                base.Return<bool>(false, false, "未填写参数");
            }
            IEnumerable<ReportOrderDTO> ienumerable = base.GetListByExpr(s => s.RESOURCE_ORDER_OPERATION_GID == reportOrderDTO.RESOURCE_ORDER_GID && s.ORIGIN_TRACK_GID == reportOrderDTO.ORIGIN_TRACK_GID);
            base.GetModelByGid(reportOrderDTO.ORIGIN_TRACK_GID);
            int CountQTY = 0;
            if (ienumerable != null)
            {
                List<ReportOrderDTO> listForReportOrderDTO = ienumerable.ToList();

                for (int i = 0; i < listForReportOrderDTO.Count; i++)
                {
                    CountQTY += Convert.ToInt32(listForReportOrderDTO[i].CUR_REPORT_QTY);
                }
            }
            int readyRecordCount = Convert.ToInt32(reportOrderDTO.CUR_REPORT_QTY);
            ProviderIME_TRACK_ORDERBusiness providerIME_TRACK_ORDERBusiness = new ProviderIME_TRACK_ORDERBusiness();
            IME_TRACK_ORDER iME_TRACK_ORDER = providerIME_TRACK_ORDERBusiness.GetIME_TRACK_ORDERModelByGuid(reportOrderDTO.ORIGIN_TRACK_GID);
            int allcounts = Convert.ToInt32(iME_TRACK_ORDER.WORK_ORDER_QTY);
            if (allcounts < CountQTY + reportOrderDTO.WORK_ORDER_QTY)
            {
                return base.Return<bool>(true, false, "报工数量超过派工单的数量");
            }
            return base.Return<bool>(true, true, "可以报工");
        }
    }
}
