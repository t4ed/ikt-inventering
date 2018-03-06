using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ikt
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "ToolsCreate",
                url: "Tools/Create",
                defaults: new { controller = "Ikts", action = "Create" }
            );

            routes.MapRoute(
                name: "ToolsEdit",
                url: "Tools/Edit/{id}",
                defaults: new { controller = "Ikts", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ToolsDetails",
                url: "Tools/{id}",
                defaults: new { controller = "Ikts", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ProjectsCreate",
                url: "Projects/Create",
                defaults: new { controller = "Projects", action = "Create" }
            );

            routes.MapRoute(
                name: "ProjectsEdit",
                url: "Projects/Edit/{id}",
                defaults: new { controller = "Projects", action = "Edit", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ProjectDetails",
                url: "Projects/{id}",
                defaults: new { controller = "Projects", action = "Details", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "LandingPage", id = UrlParameter.Optional }
            );
        }
    }
}
