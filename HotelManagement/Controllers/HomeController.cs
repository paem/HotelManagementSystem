using System;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using System.Web.Mvc;
using HotelManagement.HotelManagementServiceReference;

namespace HotelManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly HMSServiceClient _customerWCFClient = new HMSServiceClient();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CustomerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var obj = _customerWCFClient.LoginUser(viewModel.CustomerEmail,viewModel.Password);
                if (obj != null)
                {
                    Session["UserID"] = viewModel.CustomerId.ToString();
                    Session["Email"] = viewModel.CustomerEmail.ToString();
                    return RedirectToAction("UserDashBoard");
                }           
            }

            return View(viewModel);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}