using Mapping_Polyline_API_Burak_Ozgur.Models;
using Newtonsoft.Json;

namespace Services
{
    public class RecordService : IRecordService

    {
        const string FILE_PATH = "./Data/records.json";

        public void AddRecord(Record record)
        {
            var records = ReadAllRecordsFromFile();
            records.Add(record);
            WriteToFile(records);
        }

        public List<Record> GetAllRecords()
        {
            if (File.Exists(FILE_PATH))
            {
                var content = File.ReadAllText(FILE_PATH);
                return JsonConvert.DeserializeObject<List<Record>>(content) ?? new List<Record>();
            }

            return new List<Record>();
        }
        public static List<Record> ReadAllRecordsFromFile()
        {
            if (!File.Exists(FILE_PATH))
            {
                return new List<Record>();
            }
            var content = File.ReadAllText(FILE_PATH);
            return JsonConvert.DeserializeObject<List<Record>>(content) ?? new List<Record>();
        }

        public static void WriteToFile(List<Record> records)
        {
            var content = JsonConvert.SerializeObject(records, Formatting.Indented);
            File.WriteAllText(FILE_PATH, content);
        }
    }
}
