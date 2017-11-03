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
using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;
using System.Threading;

namespace GUI.AdminApp
{
    public sealed partial class EditUser : Page
    {
        //Timer _timer;
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();
        private Customer c = new Customer();
       
        private CheckBox checkBox = new CheckBox();

        public EditUser()
        {
           
            this.InitializeComponent();
            
            //_timer = new Timer(new TimerCallback((obj) => Refresh()), null, 0, 5000);

        }
        //Start on auto refresh
        //private async void Refresh()
        //{
        //    await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority.Normal,
        //        () =>
        //        {

        //        });

        //}

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
            bool CheckedIn = c.CheckedIn;
        
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
            var bookings = await HMSClient.GetBookingsByUserIdAsync(c.CustomerId);
 
            int id = c.CustomerId;
         

            if (checkBox.IsChecked == false)
                {  
                    if (c.CheckedIn != true)
                    {
                        this.checkIn.Text = "Checked In";
                        var i = HMSClient.SetCheckedInAsync(id);
                    foreach (var item in bookings)
                    {
                        var bookingObject = new Booking
                        {
                            BookingId = item.BookingId,
                            BookingStatus = true,
                        };
                        await HMSClient.CreateBookingAsync(bookingObject);
                    }
                    displayToastNotification("Checked In", "Bookingstatus is now set to: paid");
                }
                    if (c.CheckedIn != false)
                    {
                        this.checkIn.Text = "Checked Out";
                        var i = HMSClient.SetCheckedOutAsync(id);

                    foreach (var item in bookings)
                    {                      
                        var category = await HMSClient.GetCategoryByIdAsync(item.RoomCategoryId);

                        var roomObject = new Room
                        {
                            RoomId = item.RoomId,
                            RoomStatus = false
                        };
                        await HMSClient.CreateRoomAsync(roomObject);

                        var roomCategoryObject = new RoomCategory
                        {
                            RoomCategoryId = item.RoomCategoryId,
                            RoomCount = category.RoomCount + 1,
                        };
                        await HMSClient.CreateRoomCategoryAsync(roomCategoryObject);

                        await HMSClient.DeleteBookingByBookingIdAsync(item.BookingId);
                    }
                    displayToastNotification("Checked Out", "Booking removed and room added back to list");
                }

                    
                }

           
        }

        //Display a toast message
        private void displayToastNotification(String caption, String message)
        {
            var toastTemplate = "<toast launch=\"app-defined-string\">" +
                                "<visual>" +
                                  "<binding template =\"ToastGeneric\">" +
                                    "<text>" + caption + "</text>" +
                                    "<text>" + message + "</text>" +
                                  "</binding>" +
                                "</visual>" +
                                "</toast>";

            var xmlDocument = new XmlDocument();

            xmlDocument.LoadXml(toastTemplate);

            var toastNotification = new ToastNotification(xmlDocument);

            var notification = ToastNotificationManager.CreateToastNotifier();

            notification.Show(toastNotification);
        }

        //Button Close
        private void btnCloseApp_Click(object sender, RoutedEventArgs e)
        {
            removeToastHistory();
            Application.Current.Exit();
        }
        //Remove toast history
        private void removeToastHistory()
        {
            var toastHistory = ToastNotificationManager.History;
            toastHistory.Clear();
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
