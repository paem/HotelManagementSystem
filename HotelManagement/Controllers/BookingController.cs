using System.Web.Mvc;
using System;
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
                    BookingCustomerId = viewModel.BookingCustomerId,
                    BookingDate = DateTime.Now,
                    BookingRoomId = viewModel.BookingRoomId,
                    BookingRoomCategoryId = viewModel.BookingRoomCategoryId,
                    BookingArrivalDate = viewModel.BookingArrivalDate,
                    BookingDepartureDate = viewModel.BookingDepartureDate,
                    BookingStatus = viewModel.BookingStatus,
                    BookingTotalAdults = viewModel.BookingTotalAdults,
                    BookingTotalChilds = viewModel.BookingTotalChilds,
                    BookingTotalCost = viewModel.BookingTotalCost,
                    BookingTotalNights = viewModel.BookingTotalNights,
                    BookingTotalRooms = viewModel.BookingTotalRooms
                    
                 };
                 _bookingWCFClient.CreateBooking(bookingObject);


                 return RedirectToAction("Index", "Booking");
             }



             //viewModel.EventTypes = eventsTypes;


             return View("Index", viewModel);
         }


     
    }
}