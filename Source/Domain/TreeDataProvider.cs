using TreeDeliveryApp.Contracts.Enitites;
using TreeDeliveryApp.Contracts.Responses;
using TreeDeliveryApp.Domain.Extensions;
using TreeDeliveryApp.Domain.Integrations;

namespace TreeDeliveryApp.Domain
{
    public class TreeDataProvider : ITreeDataProvider
    {
        private readonly IDatabase _database;

        public TreeDataProvider(IDatabase database)
        {
            _database = database;
        }

        public GetAllOrdersResponse GetAllOrderedTrees()
        {
            var orders = _database
                .GetAllRecords()
                ?.Where(x => x.DeliveryAddress != null && x.DeliveryDate != null)
                .Select(x => x.ToOrder())
                .ToList();

            return new GetAllOrdersResponse()
            {
                Orders = orders
            };
        }

        public GetAllOrdersByTypeResponse GetAllOrderedTrees(TreeType type)
        {
            var orders = _database
                .GetAllRecords((int)type)
                ?.Where(x => x.DeliveryAddress != null && x.DeliveryDate != null)
                .Select(x => x.ToOrder())
                .ToList();

            return new GetAllOrdersByTypeResponse()
            {
                Orders = orders
            };
        }

        public GetAllTreesResponse GetAllTrees()
        {
            var trees = _database.GetAllRecords()?.Select(x => x.ToTree()).ToList();

            return new GetAllTreesResponse()
            {
                Trees = trees
            };
        }

        public GetAllTreesByTypeResponse GetAllTrees(TreeType type)
        {
            var trees = _database.GetAllRecords((int)type)?.Select(x => x.ToTree()).ToList();

            return new GetAllTreesByTypeResponse()
            {
                Trees = trees
            };
        }

        public bool SaveTree(Order order) =>
            _database.SaveOrUpdateRecord(order.ToRecordDto());
    }
}
