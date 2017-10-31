using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract(IsReference = true)]
    public class Room
    {
        [Key]
        [Required]
        [DataMember]
        public int RoomId { get; set; }

        [DataMember]
        public int RoomDoorNumber { get; set; }

        [DataMember]
        public bool RoomStatus { get; set; }
    
        [DataMember]
        [ForeignKey("RoomCategoryId")]
        public virtual RoomCategory RoomCategory { get; set; }
        public int RoomCategoryId { get; set; }

        [DataMember]
        public double RoomPrice { get; set; }

        [DataMember]
        public int RoomCapacityId { get; set; }

        [DataMember]
        public virtual RoomCapacity RoomCapacity { get; set; }

        /* Navigation Properties*/
        [DataMember]
        public ICollection<RoomCapacity> RoomCapacities { get; set; }

        [DataMember]
        public ICollection<RoomCategory> RoomCategories { get; set; }
   
        public Room()
        {
            RoomCategories = new Collection<RoomCategory>();
            RoomCapacities = new Collection<RoomCapacity>();         
        }
    }
}
