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
    public sealed partial class SearchCustomer : Page
    {
        private readonly HMSServiceClient HMSClient = new HMSServiceClient();

        public SearchCustomer()
        {
            this.InitializeComponent();
        }

        //Autosuggestbox that querys through text
        private void AutoSuggBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                AutoSuggBox.Text = args.ChosenSuggestion.ToString();

            }
        }

        //Handle then choosen item in the list
        private void AutoSuggBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            var selectedItem = args.SelectedItem.ToString();
            sender.Text = selectedItem;

        }

        //Changes the text depending on what you are searching for and displaying it to a list.
        private async void AutoSuggBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                var customerList = await HMSClient.GetCustomersAsync();
                var searchResult = customerList.Where(name => (name.CustomerFName ?? "").ToLower().Contains(sender.Text.ToLower()));

                userList.ItemsSource = searchResult;
            }

        }
        //Sends the choosen object to a new page, to display more info about it.
        private void userList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Frame.Navigate(typeof(EditUser), userList.SelectedItem);
        }
    }
}
