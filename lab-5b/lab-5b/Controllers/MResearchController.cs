using System.Web.Mvc;

namespace lab_5b.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        [HttpGet]
        [Route("{n:int}/{_string}")]
        public ActionResult M01(int n, string _string)
        {
            return Content($"GET:M01:/{n}/{_string}");
        }

        [AcceptVerbs("get", "post")]
        [Route("{b:bool}/{letters:alpha}")]
        public ActionResult M02(bool b, string letters)
        {
            return Content($"{Request.HttpMethod}:M02:/{b}/{letters}");
        }

        [AcceptVerbs("get", "delete")]
        [Route("{f:float}/{_string:length(2,5)}")]
        public ActionResult M03(float f, string _string)
        {
            return Content($"{Request.HttpMethod}:M03:/{f}/{_string}");
        }

        [HttpPut]
        [Route("{letters:alpha:length(3,4)}/{n:int:range(100,200)}")]
        public ActionResult M04(string letters, int n)
        {
            return Content($"PUT:M03:/{letters}/{n}");
        }

        [HttpPost]
        [Route(@"{mail:regex(\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*)}")]
        public ActionResult M04(string mail)
        {
            return Content($"POST:M04:/{mail}");
        }
    }
}