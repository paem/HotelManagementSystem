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

        [DataMember]
        public string CustomerFName { get; set; }

        [DataMember]
        public string CustomerLName { get; set; }

        [DataMember]
        public string  CustomerGender { get; set; }

        [DataMember]
        public string CustomerAddress { get; set; }

        [DataMember]
        public string CustomerCity { get; set; }

        [DataMember]
        public string CustomerCountry { get; set; }

        [DataMember]
        public string  CustomerPhoneNo { get; set; }

        [DataMember]
        public string CustomerEmail { get; set; } 

        [DataMember]
        [MaxLength(25)]
        public string Password { get; set; }

    }
}
