
using System.Collections.Generic; 

namespace NeuSoft.Client.InterfaceDTO
{
    public partial class ProduceOrder
    {  
        public string SourceOrderCode { get; set; }
        public string SourceOrderGuid { get; set; }
        public List<PruduceDeliveryOrder> PruduceOrderInfoList { get; set; }

          
    }
}
