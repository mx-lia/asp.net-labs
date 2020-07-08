using System;
using System.Web.Mvc;

namespace lab_5b.Controllers
{
    public class AResearchController : Controller
    {
        [ActionFilter]
        [Route("AA")]
        public ActionResult AA()
        {
            return Content("<p>AA</p>");
        }

        [ResultFilter]
        [Route("AR")]
        public ActionResult AR()
        {
            return Content("<p>AR</p>");
        }

        [ExceptionFilter]
        [Route("AE")]
        public ActionResult AE()
        {
            throw new Exception("AE");
            return Content("<p>AE</p>");
        }

        public class ActionFilterAttribute : FilterAttribute, IActionFilter
        {
            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ActionFilter: OnActionExecuted</p>");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ActionFilter: OnActionExecuting</p>");
            }
        }

        public class ResultFilterAttribute : FilterAttribute, IResultFilter
        {
            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ResultFilter: OnResultExecuted</p>");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ResultFilter: OnResultExecuting</p>");
            }
        }

        public class ExceptionFilterAttribute : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ExceptionFilter: OnException</p>");
                ViewResult viewResult = new ViewResult() { ViewName = "Error" };
                filterContext.Result = viewResult;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}