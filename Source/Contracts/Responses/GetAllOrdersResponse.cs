using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Contracts.Responses
{
    public class GetAllOrdersResponse
    {
        public List<Order>? Orders { get; set; }
    }
}