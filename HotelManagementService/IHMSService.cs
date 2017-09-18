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

    }
}
