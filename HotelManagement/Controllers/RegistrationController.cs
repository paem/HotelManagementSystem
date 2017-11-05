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
            // try catch for errors with the database (primary key duplicity or any other database update issues)
            try
            {   // check if the DataAnnotations (validation) is valid if it is continue with the update
                if (ModelState.IsValid)
            {
                    // create a new customer object with the users input
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
                    // create the new user with the WCF service
                _customerWCFClient.CreateUser(customerObject);

                return RedirectToAction("Index", "Home");
            }
            }
            // creates a error page if there were to be any errors, it uses the default error page that comes with MVC it is located under /views/shared/Error.cshtml
            catch(Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "CustomerViewModel", "CreateUser"));
            }

            return View("Index", viewModel);
        }


    }
}