using TreeDeliveryApp.Contracts.Dto;
using TreeDeliveryApp.Contracts.Enitites;

namespace TreeDeliveryApp.Domain.Extensions
{
    public static class TreeDataExtensions
    {
        public static Order ToOrder(this TreeRecordDto record) =>
            new Order()
            {
                Tree = new Tree(record.Name, (TreeType)record.Type),
                DeliveryAddress = record.DeliveryAddress,
                DeliveryDate = record.DeliveryDate.Value,
            };

        public static Tree ToTree(this TreeRecordDto record) =>
            new Tree(record.Name, (TreeType)record.Type);

        public static TreeRecordDto ToRecordDto(this Order order) =>
            new TreeRecordDto()
            {
                Name = order.Tree.Name,
                Type = (int)order.Tree.Type,
                DeliveryAddress = order.DeliveryAddress,
                DeliveryDate = order.DeliveryDate,
            };
    }
}
