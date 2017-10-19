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

            this.CustomerId.Text = CustomerId.ToString();
            this.FName.Text = FName;
            this.LName.Text = LName;
            this.Email.Text = Email;
            this.Gender.Text = Gender;
            this.PhoneNumber.Text = PhoneNumber;
            this.Country.Text = Country;
            this.City.Text = City;
            this.Adress.Text = Adress;

            //userList.ItemsSource = e.Parameter.ToString();
            
        }
    }
    }
