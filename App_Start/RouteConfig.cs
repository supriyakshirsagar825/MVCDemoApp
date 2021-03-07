using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "StudentController",
                url:"{controller}/{action}/{id}",
                defaults:new { controller= "Student", action="Index",id=UrlParameter.Optional}
                );
            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "StudentAbout", id = UrlParameter.Optional }
                );

            routes.MapRoute(
                name:"Index1",
                url:"{controller}/{action}/{id}",
                defaults:new {Controller="Home",action="Index1",id=UrlParameter.Optional}
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
