using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class HotelViewModel
    {
        public ICollection<Hotel> Hotels { get; set; }

        public int HotelId { get; set; }

        public string HotelName { get; set; }

        public string HotelDescription { get; set; }

        public int HotelTotalRooms { get; set; }

        public int HotelTotalFloors { get; set; }
    }
}