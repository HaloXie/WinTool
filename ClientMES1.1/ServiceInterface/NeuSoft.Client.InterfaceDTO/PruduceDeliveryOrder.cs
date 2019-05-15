namespace NeuSoft.Client.InterfaceDTO
{
    public class PruduceDeliveryOrder
    {
        private string materialName;
        public string MaterialName { get => materialName; set => materialName = value; }
        public string OrderGuid { get => orderGuid; set => orderGuid = value; }
        public string OrderCode { get => orderCode; set => orderCode = value; }

        private string orderGuid;

        private string orderCode;
    }
}