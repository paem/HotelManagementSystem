using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using HMS.Models;

namespace HotelManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IHMSService
    {

        [OperationContract]
        ICollection<Room> GetRooms();

        [OperationContract]
        void CreateRoom(Room roomObject);

        [OperationContract]
        void CreateRoomCategory(RoomCategory roomCategoryObject);

        [OperationContract]
        ICollection<Booking> GetBookingStatus();

        [OperationContract]
        void CreateBooking(Booking bookingObject);

        [OperationContract]
        ICollection<CustomerDetails> GetCustomerDetails();

        [OperationContract]
        ICollection<Hotel> GetHotels();

        [OperationContract]
        void CreateHotel(Hotel hotelObject);

        [OperationContract]
        void CreateUser(Customer customerObject);

        [OperationContract]
        void DeleteRoomById(int roomId);

        [OperationContract]
        ICollection<Customer> GetCustomers();

        [OperationContract]
        ICollection<Room> GetRoomsByCategoryId(int roomCategoryId);

        [OperationContract]
        ICollection<RoomCategory> GetRoomCategoryTypes();

        [OperationContract]
        ICollection<RoomCapacity> GetRoomCapacity();
        
        [OperationContract]
        ICollection<CustomerDetails> GetCustomerByCustomerDetailsId(int customerDetailsId);

        [OperationContract]
        Room GetRoomById(int roomId);

        [OperationContract]
        RoomCategory GetCategoryById(int roomId);

        [OperationContract]
        ICollection<Room> RoomDetailInfoById(int id);

        [OperationContract]
        Customer LoginUser(string Email, string Password);

        [OperationContract]
        Customer GetUserByEmail(string Email);

        [OperationContract]
        ICollection<Booking> GetBookingsByUserId(int id);

        [OperationContract]
        ICollection<Booking> BookingDetailInfoById(int id);

        [OperationContract]
        RoomCapacity GetCapacityById(int roomId);

        [OperationContract]
        void SetCheckedIn(int userId);

        [OperationContract]
        void SetCheckedOut(int userId);

        [OperationContract]
        void DeleteBookingByBookingId(int customerId);

        [OperationContract]
        void CreateCustomerDetails(CustomerDetails customerDetailsObject);

        [OperationContract]
        ICollection<CustomerDetails> GetCustomerDetailsByCustomerId(int customerId);

        [OperationContract]
        void LoadRooms();

        [OperationContract]
        void LoadCategories();

        [OperationContract]
        void LoadCapacities();
    }
}
