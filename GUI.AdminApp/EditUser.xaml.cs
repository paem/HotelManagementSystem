﻿using System;
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


           // var cd = await HMSClient.GetCustomerDetailsByCustomerIdAsync(c.CustomerId);
            //bool checker = cd.CheckedIn;


            //if(cd.CheckedIn == true)
            //{
            //    this.checkIn.Text = "true";
            //}
            //else
            //{
            //    this.checkIn.Text = "false";
            //}
            //var cd = HMSClient.GetCustomerDetailsAsync().Result.Where(i => i.CustomerDetailsId == i.CustomerId);

            //foreach(var a in cd)
            //{
            //    this.checkIn.Text = a.CheckedIn.ToString();
            //}
            //CustomerDetails cd = new CustomerDetails();
            //c.CustomerId = cd.CustomerId;

            //this.checkIn.Text = cd.CheckedIn.ToString();
            //bool checkIn = cd.CheckedIn;


        }


        
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
           
        }
       
        
       
        private void CheckInStatus_Click(object sender, RoutedEventArgs e)
        {
            int id = c.CustomerId;


            CustomerDetails cd = new CustomerDetails(); //Denna datan ska komma ifrån 
            //var cd = await HMSClient.GetCustomerDetailsByCustomerIdAsync(c.CustomerId);                                         
           //bool checker = cd.CheckedIn;


            if (checkBox.IsChecked != true)
            {
                if (cd.CheckedIn == false) { 
                var i = HMSClient.SetCheckedInAsync(id);
                checkBox.IsChecked = true;
                }

            }
            if(checkBox.IsChecked != false)
            {
                checkBox.IsChecked = true;
            }
        }
    }
    }
