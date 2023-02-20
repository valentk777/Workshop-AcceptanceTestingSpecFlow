using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Contracts.Requests
{
    public class OrderTreeRequest
    {
        public string? TreeName { get; set; }

        public TreeType TreeType { get; set; }

        public string? DeliveryAddress { get; set; }
    }
}