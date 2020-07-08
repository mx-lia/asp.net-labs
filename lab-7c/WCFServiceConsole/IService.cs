using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServiceConsole
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<Record> GetAll();
        [OperationContract]
        Record GetByID(long recordID);
        [OperationContract]
        Record Add(string name, string phone);
        [OperationContract]
        Record Update(long recordID, string name, string phone);
        [OperationContract]
        long Delete(long recordID);
    }

    [DataContract]
    public class Record
    {
        [DataMember]
        public long RecordID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }

        public Record()
        {

        }

        public Record(string name, string phone)
        {
            this.RecordID = DateTime.Now.ToFileTime();
            this.Name = name;
            this.Phone = phone;
        }

        public Record(long recordID, string name, string phone)
        {
            this.RecordID = recordID;
            this.Name = name;
            this.Phone = phone;
        }

        public override string ToString() => Name + " " + Phone;
    }
}
