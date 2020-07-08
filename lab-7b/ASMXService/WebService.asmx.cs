using ASMXService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ASMXService
{
    /// <summary>
    /// Сводное описание для WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        private RecordRepository repository = new RecordRepository();

        [WebMethod(EnableSession = true)]
        public List<Record> GetDict()
        {
            return repository.GetAll();
        }

        [WebMethod(EnableSession = true)]
        public Record GetRecord(long id)
        {
            return repository.GetByID(id);
        }

        [WebMethod(EnableSession = true)]
        public Record AddDict(string name, string phone)
        {
            return repository.Add(name, phone);
        }

        [WebMethod(EnableSession = true)]
        public Record UpdDict(long recordID, string name, string phone)
        {
            return repository.Update(recordID, name, phone);
        }

        [WebMethod(EnableSession = true)]
        public long DelDict(long id)
        {
            return repository.Delete(id);
        }
    }
}
