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
    [Authorize]
    public class NonSolidarityGroupsController : Controller
    {
        public ActionResult GetAllNonSolidarityGroups()
        {
            NonSolidarityGroupsComponent cc = new NonSolidarityGroupsComponent();
            List<Village> NonSolidarityGroups = cc.GetAllNonSolidarityGroups();

            return View("NonSolidarityListView", NonSolidarityGroups);
        }



    }
}