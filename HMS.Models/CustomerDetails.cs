using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract(IsReference = true)]
    public class CustomerDetails
    {
        [Key]
        [Required]
        [DataMember]
        public int CustomerDetailsId { get; set; }

        [DataMember]     
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        [DataMember]
        public bool CheckedIn { get; set; }


    }
}
