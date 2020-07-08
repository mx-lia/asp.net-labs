using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace lab_5a
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "RouteV3",
                url: "V3/{controller}/X/{action}",
                defaults: new { controller = "MResearch", action = "M03" }
            );

            routes.MapRoute(
                name: "RouteV3General",
                url: "V3",
                defaults: new { controller = "MResearch", action = "M03" }
            );

            routes.MapRoute(
                name: "RouteV2",
                url: "V2/{controller}/{action}",
                defaults: new { controller = "MResearch", action = "M02" }
            );

            routes.MapRoute(
                name: "Route",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "MResearch", action = "M01", id = UrlParameter.Optional }
            );
        }
    }
}
