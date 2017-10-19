using System.Collections.Generic;
using HMS.Models;

namespace HotelManagement.ViewModels
{
    public class RoomAndCategoryViewModel
    {
        public Room Room { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public RoomCategory RoomCategory { get; set; }

        public ICollection<RoomCategory> CategoryTypes { get; set; }

        public RoomCapacity RoomCapacity { get; set; }

        public ICollection<RoomCapacity> RoomCapacities { get; set; }

     
    }
}