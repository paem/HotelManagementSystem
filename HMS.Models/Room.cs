using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class Room
    {
        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int RoomDoorNumber { get; set; }

        [DataMember]
        public int RoomCategoryId { get; set; }

        [DataMember]
        public int RoomCount { get; set; }

        [DataMember]
        public bool RoomStatus { get; set; }


    }
}
