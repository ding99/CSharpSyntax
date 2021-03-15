using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarLotMVC {

	// TODO: double check https://localhost:44376/Home/Contact/Foo/Goo

	public class RouteConfig {
		public static void RegisterRoutes(RouteCollection routes) {
			routes.IgnoreRoute("{resource}.axd/{*pathinfo}");

			routes.MapRoute("Contact", "Contact/{*pathinfo}", new { controller = "Home", action = "Contact" });

			routes.MapRoute("About", "About/{*pathinfo}", new { controller = "Home", action = "About" });

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
