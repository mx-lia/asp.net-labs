using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace dll_json
{
    public class RecordRepository : IRecordRepository
    {
        public List<Record> PhoneDictionary { get; set; }
        private readonly string FILE_PATH = @"D:\Study\ASP.Net\lab-6\lab-6\App_Data\PhoneDictionary.json";

        private List<Record> ReadFromJson()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader streamReader = new StreamReader(FILE_PATH))
            {
                using (JsonTextReader reader = new JsonTextReader(streamReader))
                {
                    return serializer.Deserialize<List<Record>>(reader).OrderBy(x => x.Name).ToList() ?? new List<Record>();
                }
            }
        }

        private void WriteToJson()
        {
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter streamWriter = new StreamWriter(FILE_PATH, false))
            {
                using (JsonTextWriter writer = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(writer, PhoneDictionary);
                }
            }
        }

        public List<Record> GetAll() => ReadFromJson();

        public Record GetByID(long recordID)
        {
            PhoneDictionary = ReadFromJson();
            return PhoneDictionary.FirstOrDefault(x => x.RecordID == recordID);
        }

        public Record Add(Record newRecord)
        {
            PhoneDictionary = ReadFromJson();
            PhoneDictionary.Add(newRecord);
            WriteToJson();
            return newRecord;
        }

        public Record Update(Record newRecord)
        {
            PhoneDictionary = ReadFromJson();
            Record oldRecord = PhoneDictionary.FirstOrDefault(x => x.RecordID == newRecord.RecordID);
            if (oldRecord != null)
            {
                oldRecord.Name = newRecord.Name;
                oldRecord.Phone = newRecord.Phone;
            }
            WriteToJson();
            return newRecord;
        }

        public long Delete(long recordID)
        {
            PhoneDictionary = ReadFromJson();
            PhoneDictionary.Remove(PhoneDictionary.FirstOrDefault(x => x.RecordID == recordID));
            WriteToJson();
            return recordID;
        }
    }
}
