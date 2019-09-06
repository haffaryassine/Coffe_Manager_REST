using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Cofe_Manager_
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
            name: "addselection",
            routeTemplate: "api/{controller}/{action}/{id_badge}/{id_boisson}/{mug}/{qte_sucre}",
            defaults: new { controller = "Cofe_", action = "addSelection", id_badge = 1, id_boisson = 1, mug = false, qte_sucre = 2 });

            config.Routes.MapHttpRoute(
             name: "Get_Last_selection",
             routeTemplate: "api/{controller}/{action}/{id_badge}",
             defaults: new { controller = "Cofe_", action = "Get_Last_selection", id_badge = 1 });

            config.Routes.MapHttpRoute(
                name: "Insert_Badge",
                routeTemplate: "api/{controller}/{action}/{id_badge}",
                 defaults: new { controller = "Cofe_", action = "Insert_Badge", id_badge = 1 });

            config.Routes.MapHttpRoute(
                name: "GetBadge",
                routeTemplate: "api/{controller}/{action}/{id_badge}",
                 defaults: new { controller = "Cofe_", action = "GetBadge", id_badge = 1 });

        }
    }
}
