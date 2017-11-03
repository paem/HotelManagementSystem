using GUI.AdminApp.HMSServiceReference;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class roomInfo : Page
    {
        public roomInfo()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Room room = (Room)e.Parameter;
            this.RoomCapacityId.Text = "CapacityId: " + room.RoomCapacityId.ToString();
            this.RoomCategoryId.Text = "CategoryId: " + room.RoomCategoryId.ToString();
            this.RoomDoorNumber.Text = "Door Number: " + room.RoomDoorNumber.ToString();
            this.RoomId.Text = "RoomId: " + room.RoomId.ToString(); 
            this.RoomPrice.Text = "Price: " + room.RoomPrice.ToString();

            if (room.RoomStatus == false)
                this.RoomStatus.Text = "This room is Available";
            if (room.RoomStatus == true)
                this.RoomStatus.Text = "This room is booked";

        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.GoBack();
        }
    }
}
