using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class Booking
    {
        [Required]
        [DataMember]
        public int BookingId { get; set; }

        [DataMember]
        public DateTime BookingDate { get; set; }

        [DataMember]
        public DateTime BookingArrivalDate { get; set; }

        [DataMember]
        public DateTime BookingDepartureDate { get; set; }

        [DataMember]
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]

        public virtual Room Room { get; set; }

        [DataMember]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]

        public virtual Customer Customer { get; set; }

        [DataMember]
        public bool BookingStatus { get; set; }

        [DataMember]
        public int BookingTotalNights { get; set; }

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
