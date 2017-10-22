using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using GUI.AdminApp.HMSServiceReference;


namespace GUI.AdminApp
{
    public sealed partial class EditUser : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient(); 
        public EditUser()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            Customer customer = (Customer)e.Parameter;
          
            int CustomerId = customer.CustomerId;
            string FName = customer.CustomerFName;
            string LName = customer.CustomerLName;
            string Email = customer.CustomerEmail;
            string Gender = customer.CustomerGender;
            string PhoneNumber = customer.CustomerPhoneNo;
            string Country = customer.CustomerCountry;
            string City = customer.CustomerCity;
            string Adress = customer.CustomerAddress;

            this.CustomerId.Text = "Id: "+CustomerId.ToString();
            this.FName.Text = "Name: "+FName;
            this.LName.Text = "Lastname: "+LName;
            this.Email.Text = "Email: "+Email;
            this.Gender.Text = "Gender: "+Gender;
            this.PhoneNumber.Text = "Phonenumber: "+PhoneNumber;
            this.Country.Text = "Country: "+Country;
            this.City.Text = "City: "+City;
            this.Adress.Text = "Adress: "+Adress;

            CustomerDetails cd = new CustomerDetails();
            bool checkIn = cd.CheckedIn;
            if (checkIn == true)
            {
                this.checkIn.Text = customer.CustomerFName+" is checked in (Status: "+checkIn+")";
            }
            else
            {
                this.checkIn.Text = customer.CustomerFName + " is not checked in (Status: " + checkIn + ")";
            }

            //userList.ItemsSource = e.Parameter.ToString();

        }
    }
    }
