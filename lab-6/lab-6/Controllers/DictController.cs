using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//using dll_json;
using dll_sql;

namespace lab_6.Controllers
{
    public class DictController : Controller
    {
        private IRecordRepository repository;

        public DictController(IRecordRepository repository)
        {
            this.repository = repository;
        }

        // GET: Dict
        public ActionResult Index()
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            return View();
        }

        [HttpPost]
        public ActionResult AddSave(string name, string phone)
        {
            repository.Add(new Record(name, phone));
            return Redirect("/Dict/Index");
        }

        public ActionResult Update(long recordID)
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            ViewBag.SelectedRecord = repository.GetByID(recordID);
            return View();
        }

        [HttpPost]
        public ActionResult UpdateSave(long recordID, string name, string phone)
        {
            repository.Update(new Record(recordID, name, phone));
            return Redirect("/Dict/Index");
        }

        public ActionResult Delete(long recordID)
        {
            ViewBag.SelectedRecord = repository.GetByID(recordID);
            return View();
        }

        [HttpPost]
        public ActionResult DeleteSave(long recordID)
        {
            repository.Delete(recordID);
            return Redirect("/Dict/Index");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}