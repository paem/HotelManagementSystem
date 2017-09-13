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

        public ICollection<Room> GetRooms()
        {
            var rooms = _roomRepository.GetRooms();

            return rooms;
        }

        public void CreateRoom(Room roomObject)
        {
            _roomRepository.CreateRoom(roomObject);
        }


    }
}
