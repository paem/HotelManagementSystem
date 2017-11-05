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
using System.Threading.Tasks;

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
            //Receives one customer object, that has been click on.
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

            //Displays the values in xaml
            this.FName.Text = "Name: "+FName;
            this.LName.Text = "Lastname: "+LName;
            this.Email.Text = "Email: "+Email;
            this.Gender.Text = "Gender: "+Gender;
            this.PhoneNumber.Text = "Phonenumber: "+PhoneNumber;
            this.Country.Text = "Country: "+Country;
            this.City.Text = "City: "+City;
            this.Adress.Text = "Adress: "+Adress;

            //Finds the selected users booking by checking the id of the user.
            var bookings = await HMSClient.GetBookingsByUserIdAsync(c.CustomerId);
            //Puts the result in a list.
            bookingList.ItemsSource = bookings;
             

            //Sets the check in text in or out depending on the state that it is in.
            if (c.CheckedIn == true)
                    {
                       
                        this.checkIn.Text = "Checked in";
                    }
                    else if (c.CheckedIn == false)
                    {
                        this.checkIn.Text = "Checked Out";
                    }

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
                //If user is not checked in, when pressed the text will change and a new booking object will be created
                //Giving feedback in a dialog
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
                   
                    DisplayCheckInDialog();
                }
                    //If the checkin is already true, when pressed the text will change to checkout
                    // The room that is booked will be added back to the room list and removed from the user
                    //Giving feedback in a dialog
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
                  
                    DisplayCheckOutDialog();
                }

                    
                }

           
        }

        //These are the dialog that the Admin receives after one secound. When checking in and out.
        private async void DisplayCheckInDialog()
        {
            ContentDialog checkInDialog = new ContentDialog
            {
                Title = "Checked In Customer",
                Content = "Bookingstatus is now set to: PAID",
                CloseButtonText = "Ok"
            };
            await Task.Delay(1000);
            Frame.GoBack();
            ContentDialogResult result = await checkInDialog.ShowAsync();
        }

        private async void DisplayCheckOutDialog()
        {
            ContentDialog checkOutDialog = new ContentDialog
            {
                Title = "Checked Out Customer",
                Content = "Bookings removed and the room(s) has been set to: AVAILABLE",
                CloseButtonText = "Ok"
            };          
            await Task.Delay(1000);     
            Frame.GoBack();
            ContentDialogResult result = await checkOutDialog.ShowAsync();
        }

      
        //When selected a booking from the list it sends the object selected to another page for display.
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
