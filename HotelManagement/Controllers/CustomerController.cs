using HotelManagement.ViewModels;
using HotelManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    // is not being used at the moment!
    public class CustomerController : Controller
    {

        private readonly HMSService _customerWCFClient = new HMSService();
        // GET: Customer
        public ActionResult CustomerDetails()
        {
            if (Session["UserID"] != null)
            {
               
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}