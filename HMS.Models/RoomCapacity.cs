using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract(IsReference = true)]
    public class RoomCapacity
    {
        [Key]
        [Required]
        [DataMember]
        public int RoomCapacityId { get; set; }

        [DataMember]
        public string RoomCapacityName { get; set; }

        [DataMember]
        public int RoomCapacityAdults { get; set; }

        [DataMember]
        public int RoomCapacityChildren { get; set; }

    }
}
