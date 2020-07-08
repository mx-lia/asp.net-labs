using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceConsole
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service" в коде и файле конфигурации.
    public class Service : IService
    {
        public List<Record> PhoneDictionary { get; set; }
        private readonly string FILE_PATH = @"D:\Study\ASP.Net\lab-7c\WCFServiceConsole\App_Data\PhoneDictionary.json";

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

        public Record Add(string name, string phone)
        {
            PhoneDictionary = ReadFromJson();
            Record newRecord = new Record(name, phone);
            PhoneDictionary.Add(newRecord);
            WriteToJson();
            return newRecord;
        }

        public Record Update(long recordID, string name, string phone)
        {
            PhoneDictionary = ReadFromJson();
            Record newRecord = new Record(recordID, name, phone);
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
