using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HMS.Models
{

    [DataContract(IsReference = true)]
    public class Customer
    {
        [Key]
        [Required]
        [DataMember]
        public int CustomerId { get; set; }

        [Required]
        [DataMember]
        public string CustomerFName { get; set; }

        [Required]
        [DataMember]
        public string CustomerLName { get; set; }

        [DataMember]
        public string  CustomerGender { get; set; }

        [Required]
        [DataMember]
        public string CustomerAddress { get; set; }

        [Required]
        [DataMember]
        public string CustomerCity { get; set; }

        [Required]
        [DataMember]
        public string CustomerCountry { get; set; }

        [Required]
        [DataMember]
        public string  CustomerPhoneNo { get; set; }

        [Required]
        [DataMember]
        public string CustomerEmail { get; set; }

        [Required]
        [DataMember]
        [MaxLength(25)]
        public string Password { get; set; }

        [DataMember]
        public bool CheckedIn { get; set; }

    }
}
