using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult game_setup()
        {

            return View("game_setup");
        }

        public ActionResult About()
        {
	        return View("About");
        }

        public ActionResult Game_Rules()
        {
	        return View("game_rules");
        }

        public ActionResult Game()
        {
	        return View("game");
        }
    }
}