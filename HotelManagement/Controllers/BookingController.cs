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

        public ActionResult Index(int id)
        {
            Session["RoomId"] = id;
            return View(new BookingViewModel());
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
         public ActionResult CreateBooking(BookingViewModel viewModel)
         {
             if (ModelState.IsValid)
             {


                var bookingObject = new Booking
                {
                    BookingId = viewModel.BookingId,
                    CustomerId = int.Parse(Session["UserID"].ToString()),
                    BookingDate = DateTime.Now,
                    RoomId = int.Parse(viewModel.BookingRoomId.ToString()),
                    BookingArrivalDate = viewModel.BookingArrivalDate,
                    BookingDepartureDate = viewModel.BookingDepartureDate,
                    BookingStatus = true,
                    BookingTotalAdults = viewModel.BookingTotalAdults,
                    BookingTotalChilds = viewModel.BookingTotalChilds,
                    BookingTotalCost = viewModel.BookingTotalCost,
                    BookingTotalNights = viewModel.BookingTotalNights,
                    BookingTotalRooms = viewModel.BookingTotalRooms,
                    RoomCategoryId = 1,               
                    
                 };
                 _bookingWCFClient.CreateBooking(bookingObject);


                return RedirectToAction("Index", "Room");
            }

            return View("Index", viewModel);
        }
     
    }
}