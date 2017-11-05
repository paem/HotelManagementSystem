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
    public sealed partial class Home : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();

        private async void rooms()
        {
            //Gets all the rooms from the service method GetRooms.
            var roomList = await HMSClient.GetRoomsAsync();
     
            //Displays the rooms in a list that is connected to XAML
            this.roomList.ItemsSource = roomList;
        }

        public Home()
        {
            //Runs the room method when the page is initializing
            this.rooms();
            this.InitializeComponent();
        }
        
        //The "Hamburger" button that slides out the side menu
        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        //These are navigations to different pages
        private void adminHome_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

        private void searchCustomer_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(SearchCustomer));

        }

        private void xml_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(typeof(Rooms));
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        //When clicked on a room you get sent to a page that displays more info about that specific room.
        private void roomList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Frame.Navigate(typeof(roomInfo), roomList.SelectedItem);
        }
    }
}
