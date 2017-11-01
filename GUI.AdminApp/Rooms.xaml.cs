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
    public sealed partial class Rooms : Page
    {
        private HMSServiceClient HMSClient = new HMSServiceClient();

        public Rooms()
        {
            this.InitializeComponent();
        }

        private void loadCapacities_Click(object sender, RoutedEventArgs e)
        {
            HMSClient.LoadCapacitiesAsync();
            this.Loaded.Text = "Capacities Loaded";
        }

        private void loadCategories_Click(object sender, RoutedEventArgs e)
        {
            HMSClient.LoadCategoriesAsync();
            
            this.Loaded.Text = "Categories Loaded";
        }

        private void loadRooms_Click(object sender, RoutedEventArgs e)
        {
            HMSClient.LoadRoomsAsync();
            this.Loaded.Text = "Rooms Loaded";
        }
    }
}
