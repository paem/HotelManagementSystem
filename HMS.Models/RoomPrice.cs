using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
   public class RoomPrice
    {
        [DataMember]
        public int RoomPriceId { get; set; }

        [DataMember]
        public string RoomPriceName { get; set; }

        [DataMember]
        public float RoomPrices { get; set; }

        [DataMember]
        public int RoomCategoryId{ get; set; }

        [DataMember]
        public int RoomCapacityId { get; set; }
    }
}
