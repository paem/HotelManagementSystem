using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int BookingId { get; set; }

        [DataMember]
        public DateTime BookingDate { get; set; }

        [DataMember]
        public DateTime BookingArrivalDate { get; set; }

        [DataMember]
        public DateTime BookingDepartureDate { get; set; }

        [DataMember]
        public int BookingRoomCategoryId { get; set; }

        [DataMember]
        public int BookingRoomId { get; set; }

        [DataMember]
        public int BookingCustomerId { get; set; }

        [DataMember]
        public bool BookingStatus { get; set; }

        [DataMember]
        public TimeSpan BookingTotalNights { get; set; }

        [DataMember]
        public int BookingTotalRooms { get; set; }

        [DataMember]
        public int BookingTotalAdults { get; set; }

        [DataMember]
        public int BookingTotalChilds { get; set; }

        [DataMember]
        public float BookingTotalCost { get; set; }
    }
}
