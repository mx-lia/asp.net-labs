using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace lab_5a_2.Controllers
{
    public class CResearchController : Controller
    {
        public ActionResult C01()
        {
            StringBuilder result = new StringBuilder(
                "<h6>Request</h6>" +
                $"<p>Method: {this.HttpContext.Request.HttpMethod}</p>" +
                $"<p>QueryString: {this.HttpContext.Request.QueryString}</p>" +
                $"<p>Uri: {this.HttpContext.Request.Url}</p>" +
                $"<p>Headers: {this.HttpContext.Request.Headers}</p>"
                );
            using(StreamReader streamReader = new StreamReader(this.HttpContext.Request.InputStream))
            {
                result.Append($"<p>Body: {streamReader.ReadToEnd()}</p>");
            }
            return Content(result.ToString());
        }

        public ActionResult C02()
        {
            StringBuilder result = new StringBuilder(
                "<h6>Response</h6>" +
                $"<p>Status code: {this.HttpContext.Response.StatusCode}</p>" +
                $"<p>Headers: {this.HttpContext.Response.Headers}</p>"
                );
            return Content(result.ToString());
        }
    }
}