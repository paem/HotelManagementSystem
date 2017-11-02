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
            
            if (Session["UserID"] != null)
            {
                Session["RoomId"] = id;
                Session["RoomCost"] = roomCost;
                return View(new BookingViewModel());
            }
           
            return RedirectToAction("Index", "Home");
        }

        public ActionResult MyBookings()
        {
            if (Session["UserID"] != null)
            {
                
                var bookings = _bookingWCFClient.BookingDetailInfoById(int.Parse(Session["UserId"].ToString()));  
                var rooms = _bookingWCFClient.GetRooms();
                var categories = _bookingWCFClient.GetRoomCategoryTypes();
                var capacities = _bookingWCFClient.GetRoomCapacity();

                var viewModel = new BookingViewModel
                {
                    Bookings = bookings,
                    Rooms = rooms,
                    RoomCategories = categories,
                    RoomCapacities = capacities
                };
                return View(viewModel);
            }
            return RedirectToAction("Index", "Home");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteBookingById(int id)
        {
            var booking = _bookingWCFClient.GetBookingById(id);

            var room = _bookingWCFClient.GetRoomById(booking.RoomId);
            var category = _bookingWCFClient.GetCategoryById(room.RoomCategoryId);

            var roomObject = new Room
            {
                RoomId = room.RoomId,
                RoomStatus = false
            };
            _bookingWCFClient.CreateRoom(roomObject);

            var roomCategoryObject = new RoomCategory
            {
                RoomCategoryId = room.RoomCategoryId,
                RoomCount = category.RoomCount + 1,
            };
            _bookingWCFClient.CreateRoomCategory(roomCategoryObject);

            _bookingWCFClient.DeleteBookingByBookingId(id);
            return RedirectToAction("MyBookings", "Booking");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
         public ActionResult CreateBooking(BookingViewModel viewModel)
         {
            try
            {
                if (ModelState.IsValid)
             {
                var room = _bookingWCFClient.GetRoomById(int.Parse(Session["RoomId"].ToString()));
                var totalNights = (int)(viewModel.BookingDepartureDate - viewModel.BookingArrivalDate).TotalDays;
                var totalCost = room.RoomPrice * 1 * totalNights;
                var category = _bookingWCFClient.GetCategoryById(room.RoomCategoryId);
               

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
                    BookingTotalRooms = 1,
                    RoomCategoryId = room.RoomCategoryId,
                    
                 };
                 _bookingWCFClient.CreateBooking(bookingObject);


                var customerDetailsObject = new CustomerDetails
                {
                    CustomerDetailsId = 0,
                    CustomerId = int.Parse(Session["UserID"].ToString()),
                    CheckedIn = false
                };
                _bookingWCFClient.CreateCustomerDetails(customerDetailsObject);

                var roomObject = new Room
                {
                    RoomId = int.Parse(Session["RoomId"].ToString()),
                    RoomStatus = true
                };
                _bookingWCFClient.CreateRoom(roomObject);

                var roomCategoryObject = new RoomCategory
                {
                    RoomCategoryId = room.RoomCategoryId,
                    RoomCount = category.RoomCount - 1,
                };
                _bookingWCFClient.CreateRoomCategory(roomCategoryObject);

                return RedirectToAction("MyBookings", "Booking");
            }
            }
            catch (Exception ex)
            {
                return View("Error", new HandleErrorInfo(ex, "BookingViewModel", "CreateBooking"));
            }
            return View("Index", viewModel);
        }
     
    }
}