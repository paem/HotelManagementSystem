using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class CustomerViewModel
    {


        public ICollection<CustomerDetails> CustomerDetails {get; set;}
        public ICollection<Customer> Customers { get; set; }

        public int CustomerDetailsId { get; set; }

        public bool CheckedIn { get; set; }

        public int CustomerId { get; set; }

        public string CustomerFName { get; set; }

        public string CustomerLName { get; set; }

        public string CustomerGender { get; set; }

        public string CustomerAddress { get; set; }

        public string CustomerCity { get; set; }

        public string CustomerCountry { get; set; }

        public string CustomerPhoneNo { get; set; }

        public string CustomerEmail { get; set; }

        public bool IsEdit { get; set; }

    }
}