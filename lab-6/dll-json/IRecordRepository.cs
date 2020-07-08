using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_json
{
    public interface IRecordRepository
    {
        List<Record> GetAll();
        Record GetByID(long recordID);
        Record Add(Record newRecord);
        Record Update(Record newRecord);
        long Delete(long recordID);
    }
}
