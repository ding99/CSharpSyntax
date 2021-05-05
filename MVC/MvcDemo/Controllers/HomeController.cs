﻿using System.Web.Mvc;

namespace MvcDemo.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "The contact page.";

			return View();
		}
	}
}