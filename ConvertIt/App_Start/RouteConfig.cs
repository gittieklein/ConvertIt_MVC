using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConvertIt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Home",
                url: "{controller}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Conversions",
                url: "{controller}",
                defaults: new { controller = "Conversion", action = "Index" }
            );

            routes.MapRoute(
                name: "ConvertCurrency",
                url: "{controller}/currency",
                defaults: new { controller = "Conversion", action = "Index" }

            );
            routes.MapRoute(
                name: "ConvertLength",
                url: "{controller}/length",
                defaults: new { controller = "Conversion", action = "Index" }
            );

            routes.MapRoute(
                name: "ConvertTime",
                url: "{controller}/time",
                defaults: new { controller = "Conversion", action = "Index" }
            );

            routes.MapRoute(
                name: "ConvertTemperature",
                url: "{controller}/temperature",
                defaults: new { controller = "Conversion", action = "Index" }
            );

            routes.MapRoute(
                name: "ConvertWeight",
                url: "{controller}/weight",
                defaults: new { controller = "Conversion", action = "Index" }
            );

            routes.MapRoute(
               name: "Formulas",
               url: "{controller}",
               defaults: new { controller = "Formulas", action = "Index" }
           );

            routes.MapRoute(
               name: "Default",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );
        }
    }
}
