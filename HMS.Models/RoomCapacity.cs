using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
   public class RoomCapacity
    {
        [DataMember]
        public int RoomCapacityId { get; set; }

        [DataMember]
        public string RoomCapacityName { get; set; }

        [DataMember]
        public int RoomCapacityAdults { get; set; }

        [DataMember]
        public int RoomCapacityChilds { get; set; }
    }
}
