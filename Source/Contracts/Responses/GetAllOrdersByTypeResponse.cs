using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Contracts.Responses
{
    public class GetAllOrdersByTypeResponse
    {
        public List<Order>? Orders { get; set; }
    }
}