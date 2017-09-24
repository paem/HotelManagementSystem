using System;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using HotelManagementService;
using System.Web.Mvc;

namespace HotelManagement.Controllers
{
    public class RegistrationController : Controller
    {


        private readonly HMSService _customerWCFClient = new HMSService();


        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateUser(CustomerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var customerObject = new Customer
                {
                    CustomerId = viewModel.CustomerId,
                    CustomerFName = viewModel.CustomerFName,
                    CustomerLName = viewModel.CustomerLName,
                    CustomerGender = viewModel.CustomerGender,
                    CustomerCity = viewModel.CustomerCity,
                    CustomerCountry = viewModel.CustomerCountry,
                    CustomerAddress = viewModel.CustomerAddress,
                    CustomerPhoneNo = viewModel.CustomerPhoneNo,
                    CustomerEmail = viewModel.CustomerEmail,
                };
                _customerWCFClient.CreateUser(customerObject);


                return RedirectToAction("Index", "Home");
            }
           
            return View("Index", viewModel);
        }


    }
}