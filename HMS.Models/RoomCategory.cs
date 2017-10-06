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

        /* Skapar error vid skapande av rum! Skitbra...vi behöver nog inte ens ha foreign keys osv, för vi gör ju allt i koden egentligen som i de gamla projekten men ska det vara "rätt" så...
        [DataMember]
        [ForeignKey("RoomCapacityId")]
        public virtual RoomCapacity RoomCapacity { get; set; }
        public int RoomCapacityId { get; set; }
        */
    }
}
