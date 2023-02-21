using System.Security.Cryptography;
using System.Text;
using TreeDeliveryApp.Contracts.Dto;
using TreeDeliveryApp.Domain.Integrations;
namespace TreeDeliveryApp.Integrations.Database
{
    public class FileDatabase : IDatabase
    {
        public readonly string _recordsTableName = Path.Join(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent?.FullName, "recordsTable.txt");

        public FileDatabase()
    {
        LoadDatabase();
    }
    private void LoadDatabase() =>
    CreateFileIfNotExist(_recordsTableName);
    public List<TreeRecordDto>? GetAllRecords() =>
    File.ReadAllLines(_recordsTableName).Select(ToTreeRecordDto).ToList();
    public List<TreeRecordDto>? GetAllRecords(int type) =>
    GetAllRecords()?.Where(x => x.Type == type).ToList();
    public bool SaveOrUpdateRecord(TreeRecordDto order)
    {
        var currentOrderKey = GetRecordKey(order);
        var sameRecordOrDefault = GetAllRecords(order.Type)?.FirstOrDefault(record => GetRecordKey(record) == currentOrderKey);

        // NOTE: we allow to buy only one tree with same tree name for same requester.
            if (sameRecordOrDefault == null)
        {
                File.AppendAllText(_recordsTableName, order.ToDatabaseFormat() + "\r\n");
                return true;
            }

            // update not implemented
            return false;
        }

        private TreeRecordDto ToTreeRecordDto(string order)
        {
            var data = order.Split(";");

            return new TreeRecordDto
            {
                Name = data[0],
                Type = int.Parse(data[1]),
                DeliveryAddress = data[2],
                DeliveryDate = data[3].ToDateTimeOrDefault(),
            };
        }

        private int GetRecordKey(TreeRecordDto order)
        {
            var key = 0;

            if (order.Name != null)
            {
                key += GetHash(order.Name);
            }

            if (order.DeliveryAddress != null)
            {
                key += GetHash(order.DeliveryAddress);
            }

            return key;
        }

        private int GetHash(string text)
        {
            var hasher = MD5.Create();
            var hashed = hasher.ComputeHash(Encoding.UTF8.GetBytes(text));

            return BitConverter.ToInt32(hashed, 0);
        }

        private void CreateFileIfNotExist(string filePath)
        {
            if (!File.Exists(filePath))
            {
                using FileStream _ = File.Create(filePath);
            }
        }
    }
}
