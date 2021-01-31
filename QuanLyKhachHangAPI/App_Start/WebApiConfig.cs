using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
namespace QuanLyKhachHangAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Web API routes
            config.Routes.MapHttpRoute(
                   name: "Route1_API",
                   routeTemplate: "KH_API/api/{controller}/{action}",
                   defaults: new { id = RouteParameter.Optional }

                   );
            config.Routes.MapHttpRoute(
           name: "Route2_API",
           routeTemplate: "KH_API/api/{controller}/{id}",
           defaults: new { id = RouteParameter.Optional }

           );
            config.Routes.MapHttpRoute(
           name: "Route3_API",
           routeTemplate: "KH_API/api/{controller}/{action}/{id}",
           defaults: new { id = RouteParameter.Optional }

           );



        }
    }
}
