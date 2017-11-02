using System;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using System.Web.Mvc;
using HotelManagement.HotelManagementServiceReference;


namespace HotelManagement.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly HMSServiceClient _customerWCFClient = new HMSServiceClient();

        // GET: Registration
        public ActionResult Index()
        {
            if (Session["UserID"] == null)
            {
                return View(new CustomerViewModel());
            }
            return RedirectToAction("Index", "Home");
        }




        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateUser(CustomerViewModel viewModel)
        {
            // primary key duplicity or any other database update issues
            try
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
                    Password = viewModel.Password, 
                    CheckedIn = viewModel.CheckedIn
               
                };
                _customerWCFClient.CreateUser(customerObject);

                return RedirectToAction("Index", "Home");
            }
            }
            catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CustomerViewModel", "CreateUser"));
            }

            return View("Index", viewModel);
        }


    }
}