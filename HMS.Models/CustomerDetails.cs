using System;
using System.Runtime.Serialization;

namespace HMS.Models
{
    [DataContract]
    public class CustomerDetails
    {
        [DataMember]
        public int CustomerDetailsId { get; set; }

        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public bool CheckedIn { get; set; }


    }
}
