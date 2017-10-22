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

        //??
        //public ActionResult Index()
        //{
        //    var rooms = _bookingWCFClient.GetRooms();
        //    var viewModel = new RoomViewModel
        //    {
        //        Rooms = rooms
        //    };

        //    return View(viewModel);
        //}

        public ActionResult Index()
        {
            return View(new BookingViewModel());
        }


        [HttpPost]
         public ActionResult CreateBooking(BookingViewModel viewModel)
         {
             if (ModelState.IsValid)
             {
             
                var bookingObject = new Booking
                {
                    BookingId = viewModel.BookingId,
                    CustomerId = viewModel.BookingCustomerId,
                    BookingDate = DateTime.Now,
                    RoomId = viewModel.BookingRoomId,                
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

            return View("Index", viewModel);
        }
     
    }
}