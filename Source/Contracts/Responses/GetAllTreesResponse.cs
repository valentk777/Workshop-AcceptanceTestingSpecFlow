using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Contracts.Responses
{
    public class GetAllTreesResponse
    {
        public List<Tree>? Trees { get; set; }
    }
}