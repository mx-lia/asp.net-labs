using System;
using System.Web;

namespace lab_1a_new.handlers
{
    public class MYSHandler5 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse response = context.Response;
            HttpRequest request = context.Request;
            if (request.HttpMethod == "GET")
            {
                response.ContentType = "text/html";
                response.WriteFile("./static/XMLHttpRequest.html");
            }
            else if (request.HttpMethod == "POST")
            {
                response.ContentType = "text/plain";
                int.TryParse(request.Params.Get("x"), out int x);
                int.TryParse(request.Params.Get("y"), out int y);
                response.Write(x * y);
            }
        }

        #endregion
    }
}
