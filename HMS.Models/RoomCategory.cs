using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class RoomCategory
    {
        [DataMember]
        public int RoomCategoryId { get; set; }

        [DataMember]
        public string RoomCategoryName { get; set; }

        [DataMember]
        public string RoomCategoryDescription { get; set; }

        [DataMember]
        public string RoomCategoryBeds { get; set; }

        [DataMember]
        public int RoomCapacityId { get; set; }


    }
}
