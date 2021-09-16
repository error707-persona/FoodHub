using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
namespace WebApplication1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Order",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Order", action = "Order", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Login",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "Login", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Registeration",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Registeration", action = "Registeration", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "OrderFinal",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "OrderFinal", action = "OrderFinal", id = UrlParameter.Optional }
            );
        }
    }
}
