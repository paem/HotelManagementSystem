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
//using System.Data.SqlClient;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();
      
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void AutoSuggBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                AutoSuggBox.Text = args.ChosenSuggestion.ToString();

            }
        }

        private void AutoSuggBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            var selectedItem = args.SelectedItem.ToString();
            sender.Text = selectedItem;
           
        }

        private async void AutoSuggBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var customerList = await HMSClient.GetCustomersAsync();
                var searchResult = customerList.Where(name => (name.CustomerFName ?? "").ToLower().Contains(sender.Text.ToLower()));
               
                userList.ItemsSource = searchResult;
            }
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            Frame.Navigate(typeof(EditUser), userList.SelectedItem);
        }

        //private void uploadRooms_Click(object sender, EventArgs e)
        //{
        //    var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        //    var sqlConnection = new SqlConnection(connString);
        //    List<Room> values = File.ReadAllLines(@"C:\Users\Vidar\OneDrive\Dokument\GitHub\HotelManagementSystem\HMS.Data\Rooms.xml").Skip(1).Select(x => Room.FromCsv(x)).ToList();
        //    sqlConnection.Open();
        //    using (var scope = new TransactionScope())
        //    {
        //        string sqlIns = "INSERT INTO dbo.Rooms (roomId, categoryId, RoomDoorNumber, capacityId, roomPrice, roomStatus) VALUES(@roomId, @categoryId, @RoomDoorNumber, @capacityId, @RoomPrice, @RoomStatus)";
        //        foreach (var value in values)
        //        {
        //            var cmdIns = new SqlCommand(sqlIns, sqlConnection);
        //            cmdIns.Parameters.AddWithValue("@roomId", value.RoomId);
        //            cmdIns.Parameters.AddWithValue("@categoryId", value.)
        //        }
        //    }
        //}

    }
}