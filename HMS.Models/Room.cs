using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class Room
    {
        [Key]
        [Required]
        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int RoomDoorNumber { get; set; }

        [DataMember]
        public int RoomCount { get; set; }

        [DataMember]
        public bool RoomStatus { get; set; }

        [DataMember]
        public int? RoomCategoryId { get; set; }
        [ForeignKey("RoomCategoryId")]
        public virtual RoomCategory RoomCategory { get; set; }

        [DataMember]
        public double RoomPrice { get; set; }

    }
}
