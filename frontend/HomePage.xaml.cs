using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Http;
using mywebapi.Controllers;
using mywebapi;
using mywebapi.Models;

namespace frontend
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        private Database db;

        public string Token { get; set; }
        public string Username { get; set; }
        public HomePage()
        {
            InitializeComponent();
            PopulateListView();
        }
        // Making new method that allows for window to be moved when mouse clicked
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void HomePageLogin(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Username = Username;
            mainWindow.Show();
            this.Close();
        }

        private void HomePageRegister(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private async void HomepageProfile_Click(object sender, RoutedEventArgs e)
        {
            ProfilePage profilePage = new ProfilePage();
            profilePage.Token = Token;
            profilePage.Username = Username;
            profilePage.ShowMyData();
            profilePage.Show();
            this.Close();
        }
        private async Task PopulateListView()
        {
            try
            {
                HttpClient client = new HttpClient();
                string response = await client.GetStringAsync("http://localhost:5109/event");
                List<Event> events = JsonConvert.DeserializeObject<List<Event>>(response);

                ListView.Items.Clear(); // Clear existing items

                foreach (var ev in events)
                {
                    ListView.Items.Add(ev);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




    }
}
