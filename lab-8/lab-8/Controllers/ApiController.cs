using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lab_8.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lab_8.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private RecordRepository repository;

        public ApiController(RecordContext context)
        {
            repository = new RecordRepository(context);
        }

        public IEnumerable<Record> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{recordId}")]
        public Record GetById(long recordId)
        {
            return repository.GetByID(recordId);
        }

        [HttpPost]
        public Record Add(Record record)
        {
            return repository.Add(record);
        }

        [HttpPut]
        public Record Update(Record record)
        {
            return repository.Update(record);
        }

        [HttpDelete("{recordId}")]
        public long Delete(long recordId)
        {
            return repository.Delete(recordId);
        }
    }
}