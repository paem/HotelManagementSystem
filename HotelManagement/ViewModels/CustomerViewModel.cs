using HMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManagement.ViewModels
{
    public class CustomerViewModel
    {
    
        public ICollection<Customer> Customers { get; set; }

        public int CustomerDetailsId { get; set; }

        public bool CheckedIn { get; set; }

        public int CustomerId { get; set; }

        [Required(ErrorMessage = "First name is required")]
        public string CustomerFName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [StringLength(30, ErrorMessage = "Can't be over 30 characters")]
        public string CustomerLName { get; set; }

        public string CustomerGender { get; set; }

        [Required(ErrorMessage = "Adress is required")]
        [StringLength(30, ErrorMessage = "Can't be over 30 characters")]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "City is required")]
        [StringLength(40, ErrorMessage = "Can't be over 40 characters")]
        public string CustomerCity { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [StringLength(40, ErrorMessage = "Can't be over 40 characters")]
        public string CustomerCountry { get; set; }

        [Required(ErrorMessage = "Number is required")]
        [StringLength(15, ErrorMessage = "Can't be over 15 characters")]
        public string CustomerPhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string CustomerEmail { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        public bool IsEdit { get; set; }

    }
}