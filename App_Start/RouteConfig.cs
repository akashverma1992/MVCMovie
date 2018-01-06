using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMovie
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name:"hello",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "helloworld",
                    action = "Index",
                    id = UrlParameter.Optional
                }
            );

            routes.MapRoute(
                name: "hello2",
                url: "{controller}/{action}/{name}/{age}"
            );

            routes.MapRoute(
                name: "Movies",
                url: "{controller}/{action}/{id}",
                defaults: new {
                    controller = "Movies",
                    action = "Edit",
                    id = UrlParameter.Optional
                }
            );
        }
    }
}
