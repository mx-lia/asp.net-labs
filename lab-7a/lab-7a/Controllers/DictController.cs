using lab_7a.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab_7a.Controllers
{
    public class DictController : ApiController
    {
        private RecordRepository repository = new RecordRepository();

        public List<Record> GetAll()
        {
            return repository.GetAll();
        }

        public Record GetRecord(long id)
        {
            return repository.GetByID(id);
        }

        [HttpPost]
        public Record Add([FromBody]Record record)
        {
            return repository.Add(record);
        }

        [HttpPut]
        public Record Update(long id, [FromBody]Record record)
        {
            record.RecordID = id;
            return repository.Update(record);
        }

        [HttpDelete]
        public long DeleteSave(long id)
        {
            return repository.Delete(id);
        }
    }
}
