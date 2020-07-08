using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_8.Models
{
    public class Record
    {
        public long RecordId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public Record()
        {

        }

        public Record(string name, string phone)
        {
            this.RecordId = DateTime.Now.ToFileTime();
            this.Name = name;
            this.Phone = phone;
        }

        public Record(long recordId, string name, string phone)
        {
            this.RecordId = recordId;
            this.Name = name;
            this.Phone = phone;
        }

        public override string ToString() => Name + " " + Phone;
    }
}
