using System;
using System.Web.Mvc;

namespace lab_5b.Controllers
{
    public class CHResearchController : Controller
    {
        [HttpGet]
        [Route("AD")]
        [OutputCache(Duration = 5)]
        public ActionResult AD()
        {
            string time = DateTime.Now.ToLongTimeString();
            return Content($"<p>AD: {time}</p>");
        }
        
        [HttpPost]
        [Route("AP")]
        [OutputCache(Duration = 7)]
        public ActionResult AP(int x, int y)
        {
            string time = DateTime.Now.ToLongTimeString();
            return Content($"<p>x = {x}, y = {y}</p><p>AP: {time}</p>");
        }
    }
}