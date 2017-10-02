using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
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
        [ForeignKey("RoomCapacityId")]
        public virtual RoomCapacity RoomCapacity { get; set; }

    }
}
