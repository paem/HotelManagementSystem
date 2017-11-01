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
        private Customer c = new Customer();
       
        private CheckBox checkBox = new CheckBox();

        public EditUser()
        {
            this.InitializeComponent();
        }


        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {

            c = (Customer)e.Parameter;
          
            int CustomerId = c.CustomerId;
            string FName = c.CustomerFName;
            string LName = c.CustomerLName;
            string Email = c.CustomerEmail;
            string Gender = c.CustomerGender;
            string PhoneNumber = c.CustomerPhoneNo;
            string Country = c.CustomerCountry;
            string City = c.CustomerCity;
            string Adress = c.CustomerAddress;

            this.CustomerId.Text = "Id: "+CustomerId.ToString();
            this.FName.Text = "Name: "+FName;
            this.LName.Text = "Lastname: "+LName;
            this.Email.Text = "Email: "+Email;
            this.Gender.Text = "Gender: "+Gender;
            this.PhoneNumber.Text = "Phonenumber: "+PhoneNumber;
            this.Country.Text = "Country: "+Country;
            this.City.Text = "City: "+City;
            this.Adress.Text = "Adress: "+Adress;

            var bookings = await HMSClient.GetBookingsByUserIdAsync(c.CustomerId);
            bookingList.ItemsSource = bookings;



            //checkBox.IsChecked = true;
            var cd = await HMSClient.GetCustomerDetailsByCustomerIdAsync(c.CustomerId);
           
       
                foreach (var c in cd)
                {
                    if (c.CheckedIn == true)
                    {
                        //checkBox.IsChecked = true;

                        this.checkIn.Text = "Checked in";
                    }
                    else if (c.CheckedIn == false)
                    {
                        //checkBox.IsChecked = false;
                        this.checkIn.Text = "Checked Out";
                    }
                }
            
            //else
            //{
            //    this.checkIn.Text = "No bookings to check in/ out to";
            //}
           


            }


        
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
           
        }
       
        
       
        private async void CheckInStatus_Click(object sender, RoutedEventArgs e)
        {
            int id = c.CustomerId;

            var cd = await HMSClient.GetCustomerDetailsByCustomerIdAsync(c.CustomerId);
            foreach(var c in cd) { 
                if (checkBox.IsChecked == false)
                {  
                    if (c.CheckedIn != true)
                    {
                        this.checkIn.Text = "Checked In";
                        var i = HMSClient.SetCheckedInAsync(id);
                    }
                    if (c.CheckedIn != false)
                    {
                        this.checkIn.Text = "Checked Out";
                        var i = HMSClient.SetCheckedOutAsync(id);
      

                    }

                    
                }

            }
        }

        private void bookingList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame.Navigate(typeof(userbookings), bookingList.SelectedItem);
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
    }
