using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelManagement.ViewModels;



namespace HotelManagement.Controllers
{
    public class RoomController : Controller
    {
       // private readonly RoomRepository _eventRepository = new RoomRepository();

        public ActionResult Index()
        {
           
        
            return View("Index");
        

        }


       
        [HttpPost]
        public ActionResult CreateEvent(RoomViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                viewModel.RoomId = 1; // HARD CODED 
                viewModel.RoomDoorNumber = 45; // HARD CODED
                viewModel.RoomCount = 5;
                viewModel.RoomStatus = false;

                /*var eventObject = new Event
                {
                    Id = viewModel.Id,
                    SectionId = viewModel.SectionId,
                    Title = viewModel.Title,
                    Description = viewModel.Description,
                    StartDate = viewModel.StartDate,
                    EndDate = viewModel.EndDate,
                    SaleStop = viewModel.SaleStop,
                    BasePrice = viewModel.BasePrice,
                    MemberPrice = viewModel.MemberPrice,
                    EventTypeId = viewModel.EventTypeId,
                    ZipCode = viewModel.ZipCode,
                    Adress = viewModel.Adress,
                    MaxEmployees = viewModel.MaxEmployees,
                    MaxTickets = viewModel.MaxTickets,
                    ImageURL = viewModel.ImageURL,
                    EventOwner = viewModel.EventOwner,
                    CreatedBy = viewModel.EventOwner,
                    CreatedAt = DateTime.Now,
                };
                _eventWCFclient.CreateEvent(eventObject);

    */
                return RedirectToAction("Index", "EventList");
            }


            
            //viewModel.EventTypes = eventsTypes;


            return View("Index", viewModel);
        }




    }
}
