using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab_4.Models
{
    public class RecordRepository
    {
        private RecordContext context = new RecordContext();

        public List<Record> GetAll() => context.Records.OrderBy(x => x.Name).ToList();

        public Record GetByID(long recordID)
        {
            return context.Records.Where(x => x.RecordID == recordID).FirstOrDefault();
        }

        public Record Add(Record newRecord)
        {
            context.Records.Add(newRecord);
            context.SaveChanges();
            return newRecord;
        }

        public Record Update(Record newRecord)
        {
            Record record = GetByID(newRecord.RecordID);
            record.Name = newRecord.Name;
            record.Phone = newRecord.Phone;
            context.Entry(record).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return newRecord;
        }

        public long Delete(long recordID)
        {
            Record record = GetByID(recordID);
            context.Records.Remove(record);
            context.Entry(record).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
            return recordID;
        }
    }
}