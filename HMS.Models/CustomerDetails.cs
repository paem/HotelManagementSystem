using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class CustomerDetails
    {
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
