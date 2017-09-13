using HMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class CustomerViewModel
    {

        public ICollection<CustomerDetails> CustomerDetails { get; set; }

        public int CustomerDetailsId { get; set; }

        public int CustomerId { get; set; }

        public bool CheckedIn { get; set; }
    }
}