using Mapping_Polyline_API_Burak_Ozgur.Models;

namespace Services
{
    public interface IRecordService
    {
        List<Record> GetAllRecords();
        void AddRecord(Record record);
    }
}
