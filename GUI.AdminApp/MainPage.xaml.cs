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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();

        
        //Skriver ut alla användare
        private async void LoadCustomers(AutoSuggestBox sender)
        {
            var customerList = await HMSClient.GetCustomersAsync();
            var searchResult = customerList.Where(name => (name.CustomerFName ?? "").ToLower().Contains(sender.Text.ToLower()));

            userList.ItemsSource = searchResult;
        }
      
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

        private void AutoSuggBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                LoadCustomers(sender);
                // var customerList = HMSClient.GetCustomersAsync();
                //var searchResult = customerList.Result.Where(name => (name.CustomerFName ?? "").Contains(sender.Text));
                // userList.ItemsSource = searchResult;
            }
        }

        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Frame.Navigate(typeof(EditUser));
        }
    }
}