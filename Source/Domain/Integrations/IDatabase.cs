using TreeDeliveryApp.Contracts.Dto;

namespace TreeDeliveryApp.Domain.Integrations
{
    public interface IDatabase
    {
        List<TreeRecordDto>? GetAllRecords();

        List<TreeRecordDto>? GetAllRecords(int type);

        bool SaveOrUpdateRecord(TreeRecordDto order);
    }
}