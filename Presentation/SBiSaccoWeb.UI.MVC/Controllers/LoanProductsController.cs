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
    public class LoanProductsController : Controller
    {
        public ActionResult GetAllLoanProducts()
        {
            LoanProductsComponent lpc = new LoanProductsComponent();
            List<Package> LoanProducts = lpc.GetAllLoanProducts();

            return View("LoanProductsListView", LoanProducts);
        }



    }
}