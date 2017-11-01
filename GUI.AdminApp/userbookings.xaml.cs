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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class userbookings : Page
    {
        public userbookings()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Booking b = (Booking)e.Parameter;
           
            this.ubookings.Text = "User bookings, User Id: "+ b.CustomerId.ToString();

            this.bookingId.Text = "Booking Id: " + b.BookingId.ToString();
            this.bookingDate.Text = "Booking Date: " + b.BookingDate.ToString();
            this.bookingArrivalDate.Text = "Arrival Date: " + b.BookingArrivalDate.ToString();
            this.bookingDepatureDate.Text = "Depature Date: " + b.BookingDepartureDate.ToString();
            this.bookingStatus.Text = "Booking Status: " + b.BookingStatus.ToString();
            this.bookingTotalAdults.Text = "Total Adults: " + b.BookingTotalAdults.ToString();
            this.bookingTotalChilds.Text = "Total Childs: " + b.BookingTotalChilds.ToString();
            this.bookingTotalNights.Text = "Total Nights: " + b.BookingTotalNights.ToString();
            this.bookingTotalRooms.Text = "Total Rooms: " + b.BookingTotalRooms.ToString();
            this.bookingTotalCost.Text = "Total price: " + b.BookingTotalCost.ToString();

            this.roomId.Text = "Room Id: " + b.RoomId.ToString();
            this.roomCategoryId.Text = "Room-Category Id: " + b.RoomCategoryId.ToString();

        }
    }
}
