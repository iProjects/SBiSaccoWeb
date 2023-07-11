using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using SBiSaccoWeb.Business;
using SBiSaccoWeb.Entities;
using SBiSaccoWeb.UI.MVC.Models;
using WebMatrix.WebData;

namespace SBiSaccoWeb.UI.MVC.Controllers
{
    [HandleError]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "For Sacco Management";

            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Soft Books Sacco";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contacts";

            return View();
        }
        public ActionResult ContactUs()
        {
            ViewBag.Message = "Contact Us";

            return View();
        }
        public ActionResult SiteMap()
        {
            ViewBag.Message = "Site Map";

            return View();
        }
        public ActionResult Help()
        {
            ViewBag.Message = "Help";

            return View();
        }




































    }
}
