using TreeDeliveryApp.Contracts.Enitites;
using TreeDeliveryApp.Contracts.Responses;

namespace TreeDeliveryApp.Domain
{
    public interface ITreeDataProvider
    {
        GetAllTreesResponse GetAllTrees();

        GetAllTreesByTypeResponse GetAllTrees(TreeType type);

        GetAllOrdersResponse GetAllOrderedTrees();

        GetAllOrdersByTypeResponse GetAllOrderedTrees(TreeType type);

        bool SaveTree(Order order);
    }
}