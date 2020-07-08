using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASMXService.Models
{
    public class Record
    {
        public long RecordID { get; set; }
        public string Name { get; set; }
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