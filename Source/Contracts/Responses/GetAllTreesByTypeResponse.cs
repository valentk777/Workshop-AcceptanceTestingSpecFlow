using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Contracts.Responses
{
    public class GetAllTreesByTypeResponse
    {
        public List<Tree>? Trees { get; set; }
    }
}