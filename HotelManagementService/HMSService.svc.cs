using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HMS.Models;
using HMS.Data.Repositories;
using HMS.Data;

namespace HotelManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "HMSService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select HMSService.svc or HMSService.svc.cs at the Solution Explorer and start debugging.
    public class HMSService : IHMSService
    {
        private readonly RoomRepository _roomRepository = new RoomRepository();
        private readonly BookingRepository _bookingRepository = new BookingRepository();
        private readonly CustomerRepository _customerRepository = new CustomerRepository();
        private readonly HotelRepository _hotelRepository = new HotelRepository();


        public ICollection<Room> GetRooms()
        {
            var rooms = _roomRepository.GetRooms();

            return rooms;
        }

        public void CreateRoom(Room roomObject)
        {
            _roomRepository.CreateRoom(roomObject);
        }

        public ICollection<CustomerDetails> GetCustomerDetails()
        {
            var customerDetails = _customerRepository.GetCustomerDetails();
            return customerDetails;
        }

        //Kanske borde ha detta i en form för att mer välja vilka object som ska skapas.
        public void CreateBooking(Booking bookingObject)
        {
            _bookingRepository.CreateBooking(bookingObject);
        }

        public ICollection<Booking> GetBookingStatus()
        {
            var bookingStatus = _bookingRepository.GetBookingStatus();

            return bookingStatus;
        }

        public ICollection<Hotel> GetHotels()
        {
            var hotels = _hotelRepository.GetHotels();

            return hotels;
        }

        public void CreateHotel(Hotel hotelObject)
        {
            _hotelRepository.CreateHotel(hotelObject);
        }

        public void CreateUser(Customer customerObject)
        {
            _customerRepository.CreateUser(customerObject);
        }

        public void DeleteRoomById(int roomId)
        {
            _roomRepository.DeleteRoomById(roomId);
        }

        public ICollection<Customer> GetCustomers()
        {
           var customers = _customerRepository.GetCustomers();

           return customers;
        }

        public ICollection<RoomCategory> GetRoomCategoryTypes()
        {
            return _roomRepository.GetRoomCategoryTypes();
        }

        public ICollection<RoomCapacity> GetRoomCapacity()
        {
            return _roomRepository.GetRoomCapacity();
        }

        public ICollection<Room> GetRoomsByCategoryId(int roomCategoryId)
        {
            return _roomRepository.GetRoomByCategoryId(roomCategoryId);
        }
        
        public ICollection<CustomerDetails> GetCustomerByCustomerDetailsId(int customerDetailsId)
		{
            return _customerRepository.GetCustomerByCustomerDetailsId(customerDetailsId);
		}

        public Room GetRoomById(int roomId)
        {
            return _roomRepository.FindRoomById(roomId);
        }

        public RoomCategory GetCategoryById(int categoryId)
        {
            return _roomRepository.FindCategoryById(categoryId);
        }

        public ICollection<Room> RoomDetailInfoById(int id)
        {
            return _roomRepository.RoomDetailInfoById(id);
        }

        public Customer LoginUser(string Email, string Password)
        {
            return _customerRepository.LoginUser(Email, Password);
        }

        public Customer GetUserByEmail(string Email)
        {
            return _customerRepository.GetUserByEmail(Email);
        }

        public ICollection<Booking> GetBookingsByUserId(int id)
        {
            return _bookingRepository.GetBookingByUserId(id);
        }

        public ICollection<Booking> BookingDetailInfoById(int id)
        {
            return _bookingRepository.BookingDetailInfoById(id);
        }

        public RoomCapacity GetCapacityById(int capacityId)
        {
            return _roomRepository.FindCapacityById(capacityId);
        }
    }
}
