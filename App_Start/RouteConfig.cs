using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {//
        /// <summary>
        /// same(one) url from two action method will not work
        /// but
        /// two url from one action method will work 
        /// </summary>
        /// <param name="routes"></param>
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name:"allstudent",
            //    url:"student",
            //    defaults:new { controller ="Student",action= "GetAllStudent", id=UrlParameter.Optional}
            //    );

            //routes.MapRoute(
            //    name:"GetSingleStudent",
            //    url:"student/{id}",
            //    defaults: new { controller= "Student", action= "GetStudentById", id=UrlParameter.Optional},
            //    constraints: new { id = @"\d+" }
            //    );

            //routes.MapRoute(
            //    name:"getaddress",
            //    url:"student/{id}/address",
            //    defaults:new { controller="Student" , action= "GetStudentAddress", id=UrlParameter.Optional }
            //    );

           routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
               name: "StudentController",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional }
               );
            routes.MapRoute(
                name: "Student",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Student", action = "StudentAbout", id = UrlParameter.Optional }
                );

        }
    }
}
