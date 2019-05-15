using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuSoft.ServiceInterface.ModelData.Table
{
    public class SourceProduceOrderInfo
    {
        #region 属性
        /// <summary>
        /// 源工单生产订单ID
        /// </summary>
        public int SourceProduceOrderID { get => sourceProduceOrderID; set => sourceProduceOrderID = value; }
        /// <summary>
        /// 
        /// </summary>
        public int ActualQuantity { get => actualQuantity; set => actualQuantity = value; }
        public string BusinessActivityType { get => businessActivityType; set => businessActivityType = value; }
        public string SourceCode { get => sourceCode; set => sourceCode = value; }
        public int CreateStatus { get => createStatus; set => createStatus = value; }
        public DateTime DeliverTime { get => deliverTime; set => deliverTime = value; }
        public string SourceProduceOrderGuid { get => sourceProduceOrderGuid; set => sourceProduceOrderGuid = value; }
        /// <summary>
        /// 是否关键件 默认是false |是为1，不是为0
        /// </summary>
        public int IsCreateKeyParts { get => isCreateKeyParts; set => isCreateKeyParts = value; }
        public int IsCreateProduceOrder { get => isCreateProduceOrder; set => isCreateProduceOrder = value; }
        public DateTime MeasureBeginTime { get => measureBeginTime; set => measureBeginTime = value; }
        public DateTime MeasureEndTime { get => measureEndTime; set => measureEndTime = value; }
        public int PlanQuantity { get => planQuantity; set => planQuantity = value; }
        public string OrderGuid { get => orderGuid; set => orderGuid = value; }
        public string PriorityLevel { get => priorityLevel; set => priorityLevel = value; }
        public int ProcessStatus { get => processStatus; set => processStatus = value; }
        public DateTime SourceProduceOrderPlanStartTime { get => sourceProduceOrderPlanStartTime; set => sourceProduceOrderPlanStartTime = value; }
        public DateTime SourceProduceOrderPlanEndTime { get => sourceProduceOrderPlanEndTime; set => sourceProduceOrderPlanEndTime = value; }
        public string SourceProduceOrderBomStatusGuid { get => sourceProduceOrderBomStatusGuid; set => sourceProduceOrderBomStatusGuid = value; }
        public string SourceProduceOrderStatusGuid { get => sourceProduceOrderStatusGuid; set => sourceProduceOrderStatusGuid = value; }

        #endregion

        #region 私有字段
        private string sourceProduceOrderStatusGuid;

        private string sourceProduceOrderBomStatusGuid;

        private DateTime sourceProduceOrderPlanEndTime;

        private DateTime sourceProduceOrderPlanStartTime;

        private int processStatus;

        private string priorityLevel;

        private string orderGuid;

        private int planQuantity;

        private DateTime measureEndTime;

        private DateTime measureBeginTime;

        private int isCreateProduceOrder;

        private int isCreateKeyParts;

        private string sourceProduceOrderGuid;

        private DateTime deliverTime;

        private int createStatus;

        private string sourceCode;

        private string businessActivityType;

        private int actualQuantity;

        private int sourceProduceOrderID;
        #endregion
    }
}
