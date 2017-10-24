using HotelManagement.ViewModels;
using HotelManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    public class CustomerController : Controller
    {

        private readonly HMSService _customerWCFClient = new HMSService();
        // GET: Customer
        public ActionResult CustomerDetails()
        {
            if (Session["UserID"] != null)
            {
                var customerDetails = _customerWCFClient.GetCustomerDetails();
                var viewModel = new CustomerViewModel
                {
                    CustomerDetails = customerDetails
                };

                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}