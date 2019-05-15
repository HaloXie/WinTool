using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    public partial class ProduceOrderInfo
    {

        #region 属性
        /// <summary>
        /// 源工单ID标识
        /// </summary>
        public int SourceProduceOrderID { get => sourceProduceOrderID; set => sourceProduceOrderID = value; }
        /// <summary>
        /// ID标识
        /// </summary>
        public int ProduceOrderID { get => produceOrderID; set => produceOrderID = value; }
        /// <summary>
        /// 派工单的guid
        /// </summary>
        public string OrderGuid { get => orderGuid; set => orderGuid = value; }
        /// <summary>
        /// 派工单编码
        /// </summary>
        public string OrderCode { get => orderCode; set => orderCode = value; }
        /// <summary>
        /// 测量开始时间
        /// </summary>
        public DateTime CalculateBeginTime { get => calculateBeginTime; set => calculateBeginTime = value; }
        /// <summary>
        /// 测量结束时间
        /// </summary>
        public DateTime CalculateEndTime { get => calculateEndTime; set => calculateEndTime = value; }
        /// <summary>
        /// 订单状态
        /// </summary>
        public int OrderStatus { get => orderStatus; set => orderStatus = value; }
        /// <summary>
        /// 计划开始时间
        /// </summary>
        public DateTime PlanBeginTime { get => planBeginTime; set => planBeginTime = value; }
        /// <summary>
        /// 计划结束时间
        /// </summary>
        public DateTime PlanEndTime { get => planEndTime; set => planEndTime = value; }
        /// <summary>
        /// 计划数量
        /// </summary>
        public int PlanQuantity { get => planQuantity; set => planQuantity = value; }
        /// <summary>
        /// 工序名
        /// </summary>
        public string ProcessName { get => processName; set => processName = value; }
        /// <summary>
        /// 工序编号
        /// </summary>
        public string ProcessCode { get => processCode; set => processCode = value; }
        /// <summary>
        /// 物料编码
        /// </summary>
        public string MaterialCode { get => materialCode; set => materialCode = value; }
        /// <summary>
        /// 物料名称
        /// </summary>
        public string MaterialName { get => materialName; set => materialName = value; }

        #endregion

        #region 私有字段
        private string materialName;

        private string materialCode;

        private string processCode;

        private string processName;

        private int planQuantity;

        private DateTime planEndTime;

        private DateTime planBeginTime;

        private int orderStatus;

        private DateTime calculateEndTime;

        private DateTime calculateBeginTime;

        private string orderCode;

        private string orderGuid;

        private int sourceProduceOrderID;

        private int produceOrderID;
        #endregion
    }
}
