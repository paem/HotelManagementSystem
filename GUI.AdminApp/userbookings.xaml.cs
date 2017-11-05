using System;
using System.Collections.Generic;
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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class userbookings : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();

        public userbookings()
        {
            this.InitializeComponent();
        }

        // Displaying the object that was chosen, but also information from rooms and roomscategory
        // It shows the information in text and image.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Booking b = (Booking)e.Parameter;

           var room = HMSClient.GetRoomByIdAsync(b.RoomId);
           var category = HMSClient.GetCategoryByIdAsync(b.RoomCategoryId);

            

            String stringPath = category.Result.RoomCategoryImage;
            Uri imageUri = new Uri(stringPath, UriKind.Absolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
         
            this.bookingImage.Source = imageBitmap;
            this.ubookings.Text = "Room type: " + category.Result.RoomCategoryName;
            this.bookingBeds.Text = "Beds: " + category.Result.RoomCategoryBeds + "sized bed";
            this.bookingId.Text = "Doornumber: " + room.Result.RoomDoorNumber;          
            this.bookingDate.Text = "Was booked on: " + b.BookingDate.ToString();
            this.bookingArrivalDate.Text = "Check in Date: " + b.BookingArrivalDate.ToString();
            this.bookingDepatureDate.Text = "Check out Date: " + b.BookingDepartureDate.ToString();
            if (b.BookingStatus == true)
            {
                this.bookingStatus.Text = "Customer has paid";
            }else
            {
                this.bookingStatus.Text = "Customer has not paid";
            }
            
            this.bookingTotalAdults.Text = "Total Adults: " + b.BookingTotalAdults.ToString();
            this.bookingTotalChilds.Text = "Total Childs: " + b.BookingTotalChilds.ToString();
            this.bookingTotalNights.Text = "Total Nights: " + b.BookingTotalNights.ToString();
            this.bookingTotalRooms.Text = "Total Rooms: " + b.BookingTotalRooms.ToString();
            this.bookingTotalCost.Text = "Total price: " + b.BookingTotalCost.ToString();  

        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
