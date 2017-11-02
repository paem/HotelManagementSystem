using HMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class BookingViewModel
    {
        public ICollection<Booking> Bookings { get; set; }

        public ICollection<RoomCategory> RoomCategories { get; set; }

        public ICollection<RoomCapacity> RoomCapacities { get; set; }

        public ICollection<Room> Rooms { get; set; }

        public RoomCategory RoomCategory { get; set; }

        public Room Room { get; set; }

        public int BookingId { get; set; }

        public DateTime BookingDate { get; set; }

        [Required(ErrorMessage = "Arrival date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BookingArrivalDate { get; set; }

        [Required(ErrorMessage = "Departure date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime BookingDepartureDate { get; set; }

        public int BookingRoomId { get; set; }

        public int BookingCustomerId { get; set; }

        public bool BookingStatus { get; set; }

        public int BookingTotalNights { get; set; }

        [Required(ErrorMessage = "How many rooms?")]
        public int BookingTotalRooms { get; set; }

        [Required(ErrorMessage = "How many Adults?")]
        public int BookingTotalAdults { get; set; }

        [Required(ErrorMessage = "How many children?")]
        public int BookingTotalChilds { get; set; }

        public double BookingTotalCost { get; set; }
    }
}