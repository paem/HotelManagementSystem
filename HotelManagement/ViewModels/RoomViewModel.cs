using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;

namespace HotelManagement.ViewModels
{
    public class RoomViewModel
    {
        public ICollection<Room> Rooms { get; set; }

        public ICollection<RoomCategory> CategoryTypes { get; set; }

        public ICollection<RoomCapacity> RoomCapacity { get; set; }

        public int RoomId { get; set; }
        
        public int CategoryId { get; set; }
        
        public int RoomDoorNumber { get; set; }

        public int RoomCount { get; set; }
       
        public bool RoomStatus { get; set; }

        public string RoomPrice { get; set; }

    }
}
