using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract(IsReference = true)]
    public class RoomCategory
    {
        [Key]     
        [DataMember]
        public int RoomCategoryId { get; set; }

        [DataMember]
        public string RoomCategoryName { get; set; }

        [DataMember]
        public string RoomCategoryDesc { get; set; }

        [DataMember]
        public string RoomCategoryBeds { get; set; }

        [DataMember]
        public int RoomCapacityId { get; set; }

        [DataMember]
        public string RoomCategoryImage { get; set; }

        [DataMember]
        public double RoomCount { get; set; }
        /* Navigation Properties*/
        [DataMember]
        public ICollection<Room> Rooms { get; set; }

        [DataMember]
        public ICollection<RoomCapacity> RoomCapacities { get; set; }

        public RoomCategory()
        {
            Rooms = new Collection<Room>();
            RoomCapacities = new Collection<RoomCapacity>();
        }

    }
}
