using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab_8.Models
{
    public class RecordRepository
    {
        private RecordContext context;

        public RecordRepository(RecordContext context)
        {
            this.context = context;
        }

        public List<Record> GetAll() => context.Records.OrderBy(x => x.Name).ToList();

        public Record GetByID(long recordId)
        {
            return context.Records.Where(x => x.RecordId == recordId).FirstOrDefault();
        }

        public Record Add(Record newRecord)
        {
            context.Records.Add(newRecord);
            context.SaveChanges();
            return newRecord;
        }

        public Record Update(Record newRecord)
        {
            Record record = GetByID(newRecord.RecordId);
            record.Name = newRecord.Name;
            record.Phone = newRecord.Phone;
            context.Entry(record).State = EntityState.Modified;
            context.SaveChanges();
            return newRecord;
        }

        public long Delete(long recordId)
        {
            Record record = GetByID(recordId);
            context.Records.Remove(record);
            context.Entry(record).State = EntityState.Deleted;
            context.SaveChanges();
            return recordId;
        }
    }
}
