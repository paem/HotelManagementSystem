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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GUI.AdminApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
        }

        //Simple login where the input need to be equal to Admin, then it returns different boolean values.
        public static bool ValidateAccountCredentials(string username, string password)
        {
            if (username == "Admin" && password == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Depending on the bool value it sends you to a different page. MainPage is the login page.
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateAccountCredentials(UsernameTextBox.Text, PasswordTextBox.Password) == true)
            {
                Frame.Navigate(typeof(Home));
            }
            if (ValidateAccountCredentials(UsernameTextBox.Text, PasswordTextBox.Password) == false)
            {
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}