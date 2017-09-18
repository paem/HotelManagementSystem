using System.Web.Mvc;
using HotelManagement.ViewModels;
using HMS.Data.Repositories;
using HMS.Models;
using HotelManagementService;

namespace HotelManagement.Controllers
{
    public class BookingController : Controller
    {
        private readonly HMSService _bookingWCFClient = new HMSService();


        public ActionResult Index()
        {
            var rooms = _bookingWCFClient.GetRooms();
            var viewModel = new RoomViewModel
            {
                Rooms = rooms
            };

            return View(viewModel);
        }


        
         [HttpPost]
         public ActionResult CreateBooking(BookingViewModel viewModel)
         {
             if (ModelState.IsValid)
             {
             
                 var bookingObject = new Booking
                 {
                     BookingId = viewModel.BookingId,

                 };
                 _bookingWCFClient.CreateBooking(bookingObject);


                 return RedirectToAction("Index", "EventList");
             }



             //viewModel.EventTypes = eventsTypes;


             return View("Index", viewModel);
         }


     
    }
}