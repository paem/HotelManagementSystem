using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;

namespace HotelManagement.ViewModels
{
    public class RoomPriceViewModel
    {
        public ICollection<RoomPrice> RoomPrice { get; set; }

        public int RoomPriceId { get; set; }

        public string RoomPriceName { get; set; }

        public float RoomPrices { get; set; }

        public int RoomCapacityId { get; set; }
    }
}