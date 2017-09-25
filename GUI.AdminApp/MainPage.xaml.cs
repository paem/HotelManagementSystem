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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        HMSServiceReference.HMSServiceClient HMSClient = new HMSServiceReference.HMSServiceClient();

        //Skriver ut alla användare
        private async void LoadCustomers()
        {

            var customerList = await HMSClient.GetCustomersAsync();

            userList.ItemsSource = customerList; 

        }
    
        public MainPage()
        {

           LoadCustomers();
           

            this.InitializeComponent();
        }
        private void mySearchBox_QuerySubmitted(SearchBox sender,
            SearchBoxQuerySubmittedEventArgs args)
        {
            string keyword = mySearchBox.QueryText;

            var customerList = HMSClient.GetCustomersAsync();

            var searchResult = customerList.Result.Where(name => name.ToString().Contains(keyword));

            userList.ItemsSource = searchResult;
            

         //   this.Frame.Navigate(typeof(SearchResultPage), args.QueryText);
        }
     /*   class SearchResultPage
        {

        }
        */




        /*
        //Kanske ska använda AUTOSUGGESTBOX istället för SearchBOX

        private void AutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            // Only get results when it was a user typing,
            // otherwise assume the value got filled in by TextMemberPath
            // or the handler for SuggestionChosen.
            if (args.Reason == AutoSuggestionBoxTextChangeReason.UserInput)
            {
                //Set the ItemsSource to be your filtered dataset
                //sender.ItemsSource = dataset;
             
              
            //  var customerList = HMSClient.GetCustomersAsync();

              //  userList.ItemsSource = customerList;
            }
        }


        private void AutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            // Set sender.Text. You can use args.SelectedItem to build your text string.
        }


        private void AutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            if (args.ChosenSuggestion != null)
            {
                // User selected an item from the suggestion list, take an action on it here.
            }
            else
            {
                // Use args.QueryText to determine what to do.
                string keyword = args.QueryText;

                var customerList = HMSClient.GetCustomersAsync();

                var searchResult = customerList.Result.Where(name => name.ToString().Contains(keyword));

                userList.ItemsSource = searchResult;
            }
        }
        */
    }
}
