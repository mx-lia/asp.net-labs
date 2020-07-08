using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab_8.Models;

namespace lab_8.Controllers
{
    public class DictController : Controller
    {
        private readonly ILogger<DictController> _logger;
        private RecordRepository repository;

        public DictController(ILogger<DictController> logger, RecordContext context)
        {
            _logger = logger;
            repository = new RecordRepository(context);
        }

        public IActionResult Index()
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult AddSave(Record record)
        {
            repository.Add(record);
            return Redirect("/Dict/Index");
        }

        public IActionResult Update(long recordId)
        {
            ViewBag.PhoneDictionary = repository.GetAll();
            ViewBag.SelectedRecord = repository.GetByID(recordId);
            return View();
        }

        [HttpPost]
        public IActionResult UpdateSave(Record record)
        {
            repository.Update(record);
            return Redirect("/Dict/Index");
        }

        public IActionResult Delete(long recordId)
        {
            ViewBag.SelectedRecord = repository.GetByID(recordId);
            return View();
        }

        [HttpPost]
        public IActionResult DeleteSave(long recordId)
        {
            repository.Delete(recordId);
            return Redirect("/Dict/Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
