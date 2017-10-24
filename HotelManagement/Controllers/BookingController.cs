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

        public ActionResult Index(int id, string roomCost)
        {
            Session["RoomId"] = id;
            Session["RoomCost"] = roomCost;
            return View(new BookingViewModel());
        }

        public ActionResult MyBookings()
        {
            var bookings = _bookingWCFClient.BookingDetailInfoById(int.Parse(Session["UserId"].ToString()));

     

            var viewModel = new BookingViewModel
            {
                Bookings = bookings,
              
            };

            return View(viewModel);
        }


        [ValidateAntiForgeryToken]
        [HttpPost]
         public ActionResult CreateBooking(BookingViewModel viewModel)
         {
             if (ModelState.IsValid)
             {
                var room = _bookingWCFClient.GetRoomById(int.Parse(Session["RoomId"].ToString()));
                var totalNights = (int)(viewModel.BookingDepartureDate - viewModel.BookingArrivalDate).TotalDays;
                var totalCost = room.RoomPrice * viewModel.BookingTotalRooms * totalNights;
               

                var bookingObject = new Booking
                {
                    BookingId = viewModel.BookingId,
                    CustomerId = int.Parse(Session["UserID"].ToString()),
                    BookingDate = DateTime.Now,
                    RoomId = int.Parse(Session["RoomId"].ToString()),
                    BookingArrivalDate = viewModel.BookingArrivalDate,
                    BookingDepartureDate = viewModel.BookingDepartureDate,
                    BookingStatus = true,
                    BookingTotalAdults = viewModel.BookingTotalAdults,
                    BookingTotalChilds = viewModel.BookingTotalChilds,
                    BookingTotalCost = totalCost,
                    BookingTotalNights = totalNights ,
                    BookingTotalRooms = viewModel.BookingTotalRooms,
                    RoomCategoryId = room.RoomCategoryId,               
                    
                 };
                 _bookingWCFClient.CreateBooking(bookingObject);


                return RedirectToAction("Index", "Room");
            }

            return View("Index", viewModel);
        }
     
    }
}