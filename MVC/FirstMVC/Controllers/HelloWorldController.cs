﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public string Index()
        public ActionResult Index() {
            return View();
            //return "This is my <b>default</b> action...";
        }

        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int id = 1) {
            return HttpUtility.HtmlEncode($"Hello [{name}], ID: [{id}]");
		}
    }
}