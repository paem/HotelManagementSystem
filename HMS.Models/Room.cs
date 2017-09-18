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
        public int RoomCount { get; set; }

        [DataMember]
        public bool RoomStatus { get; set; }

        //RoomCapacity
        [DataMember]
        public int RoomCapacityId { get; set; }

        [DataMember]
        public string RoomCapacityName { get; set; }

        [DataMember]
        public int RoomCapacityAdults { get; set; }

        [DataMember]
        public int RoomCapacityChilds { get; set; }

        //RoomCategory
        [DataMember]
        public int RoomCategoryId { get; set; }

        [DataMember]
        public string RoomCategoryName { get; set; }

        [DataMember]
        public string RoomCategoryDescription { get; set; }

        [DataMember]
        public string RoomCategoryBeds { get; set; }

        //RoomPrice
        [DataMember]
        public int RoomPriceId { get; set; }

        [DataMember]
        public string RoomPriceName { get; set; }

        [DataMember]
        public float RoomPrices { get; set; }

    }
}
