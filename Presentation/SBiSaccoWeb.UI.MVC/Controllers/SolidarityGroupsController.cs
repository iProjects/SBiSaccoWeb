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
    public class SolidarityGroupsController : Controller
    {
        public ActionResult GetAllSolidarityGroups()
        {
            SolidarityGroupsComponent sgc = new SolidarityGroupsComponent();
            List<Group> SolidarityGroups = sgc.GetAllSolidarityGroups();

            return View("SolidarityGroupsListView", SolidarityGroups);
        }

        public ActionResult SolidarityGroupDetails(int id)
        {
            Group model = new Group();

            return View("SolidarityGroupDetailsView", model);
        }

        public ActionResult CreateSolidarityGroup()
        {
            Group model = new Group();

            return View("CreateSolidarityGroupView", model);
        }
        [HttpPost]
        public ActionResult CreateSolidarityGroup([Bind] Group model)
        {
            return RedirectToAction("GetAllSolidarityGroups");
        }

        public ActionResult EditSolidarityGroup(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditSolidarityGroup([Bind] Group model)
        {
            return RedirectToAction("GetAllSolidarityGroups");
        }

        public ActionResult DeleteSolidarityGroup(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteSolidarityGroup(int id, FormCollection collection)
        {
            return RedirectToAction("GetAllSolidarityGroups");
        }



    }
}