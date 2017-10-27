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
            if (Session["UserID"] != null)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
        }

        public ActionResult Login()
        {
            if (Session["UserID"] == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CustomerViewModel viewModel)
        {
            if (Session["UserID"] == null)
            {
                var customerId = _customerWCFClient.GetUserByEmail(viewModel.CustomerEmail);
                if (ModelState.IsValid)
                {
                    var obj = _customerWCFClient.LoginUser(viewModel.CustomerEmail, viewModel.Password);
                    if (obj != null)
                    {
                        Session["UserID"] = customerId.CustomerId;
                        Session["Email"] = viewModel.CustomerEmail.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }

                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
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

        public ActionResult SignOut()
        {
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();
            return RedirectToAction("Login", "Home");
        }
    }
}