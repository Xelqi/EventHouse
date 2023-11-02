using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
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
using mywebapi;

namespace frontend
{
    /// <summary>
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Window
    {
        public string Token { get; set; }
        public string Username { get; set; }


        public ProfilePage()
        {

            InitializeComponent();
        }

        // Making new method that allows for window to be moved when mouse clicked
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void back_btn2(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Show();
            this.Close();
        }

        private void update_btn(object sender, RoutedEventArgs e)
        {

        }

        private async void delete_btn(object sender, RoutedEventArgs e)
        {
            string usernameID = username.Text;

            try
            {
                if (string.IsNullOrEmpty(usernameID))
                {
                    MessageBox.Show("Please enter a username.");
                    return;
                }

                var url = "http://localhost:5109/User/" + usernameID;
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("Authorization", Token);
                HttpResponseMessage response = await client.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to delete the User. Please try again.");
                    MessageBox.Show("Failed to delete the User. Please try again.\nResponse: " + response.ToString());

                }
            }
            catch (Exception ex)
            {
                // Handle exception
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void delete_list_btn(object sender, RoutedEventArgs e)
        {

        }

        static async Task<string> GetUserDataFromApi(string Token, string Username)
        {
            var response = string.Empty;
            var url = "http://localhost:5109/user/" + Username;
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", Token);
            HttpResponseMessage result = await client.GetAsync(url);
            response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public void ShowMyData()
        {
            if (Token == null)
            {
                MessageBox.Show("You have to log in first");
            }
            else
            {
                var data = Task.Run(() => GetUserDataFromApi(Token, Username));
                data.Wait();
                Console.WriteLine(data.Result);

                JArray jsonArray = JArray.Parse(data.Result);
                if (jsonArray.Count > 0)
                {
                    JObject j = (JObject)jsonArray[0];
                    username.Text = j["username"].ToString();
                    Password.Text = j["password"].ToString();
                    Firstname.Text = j["fname"].ToString();
                    Lastname.Text = j["lname"].ToString();
                }
                else
                {
                    MessageBox.Show("There is no data");
                }
            }
        }
    }
}
