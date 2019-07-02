using System.Web.Mvc;
using System.Web.Routing;

namespace Biographies
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

            // Route: Candidates
            routes.MapRoute(
                name: "Candidates",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Candidates", action = "Get", id = UrlParameter.Optional }
            );
        }
    }
}
