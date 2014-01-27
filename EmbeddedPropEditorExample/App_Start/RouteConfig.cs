using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EmbeddedPropEditorExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.MapRoute(
                name: "Example",
                url: "App_Plugins/Example/{action}/{id}",
                defaults: new { controller = "Embedded", action = "Resource", id = UrlParameter.Optional }
            );
        }
    }
}