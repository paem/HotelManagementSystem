using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class BookingViewModel
    {
        public ICollection<Booking> Book { get; set; }

        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        public DateTime BookingArrivalDate { get; set; }

        public DateTime BookingDepartureDate { get; set; }

        public int BookingRoomCategoryId { get; set; }

        public int BookingRoomId { get; set; }

        public int BookingCustomerId { get; set; }

        public bool BookingStatus { get; set; }

        public TimeSpan BookingTotalNights { get; set; }

        public int BookingTotalRooms { get; set; }

        public int BookingTotalAdults { get; set; }

        public int BookingTotalChilds { get; set; }

        public float BookingTotalCost { get; set; }
    }
}