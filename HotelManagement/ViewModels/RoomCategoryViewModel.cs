using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;

namespace HotelManagement.ViewModels
{
    public class RoomCategoryViewModel
    {
        public ICollection<RoomCategory> RoomCategory { get; set; }

        public int RoomCategoryId { get; set; }

        public string RoomCategoryName { get; set; }

        public string RoomCategoryDescription { get; set; }

        public string RoomCategoryBeds { get; set; }

        public int RoomCapacityId { get; set; }

    }
}