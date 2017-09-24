using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HMS.Models
{

    [DataContract]
    public class Hotel
    {
        [Required]
        [DataMember]
        public int HotelId { get; set; }

        [DataMember]
        public string HotelName { get; set; }

        [DataMember]
        public string HotelDescription { get; set; }

        [DataMember]
        public int HotelTotalRooms { get; set; }

        [DataMember]
        public int HotelTotalFloors { get; set; }

    }
}
