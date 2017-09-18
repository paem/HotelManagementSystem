using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;

namespace HotelManagement.ViewModels
{
    public class RoomCapacityViewModel
    {
        public ICollection<RoomCapacity> RoomCapacity { get; set; }

        public int RoomCapacityId { get; set; }

        public string RoomCapacityName { get; set; }

        public int RoomCapacityAdults { get; set; }

        public int RoomCapacityChilds { get; set; }
    }
}