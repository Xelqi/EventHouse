using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.Net.Http.Headers;
using System.Windows.Automation.Text;

namespace frontend
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public string Username { get; set; }
        public Register()
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

        private void back_btn(object sender, RoutedEventArgs e)
        {
            HomePage homepage = new HomePage();
            homepage.Username = Username;
            homepage.Show();
            this.Close();
        }
        private async void btnCreateAcc_Click(object sender, RoutedEventArgs e)
        {
          
            NewUser newUser = new NewUser
            {
                fname = txtfirstname.Text,
                lname = txtlastname.Text,
                username = txtusername.Text,
                password = txtpassword.Password
            };

            var client = new HttpClient();

            // Convert the User object to JSON
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(newUser);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            // Send the POST request to the API
            HttpResponseMessage response = await client.PostAsync("http://localhost:5109/User", content);

            if (response.IsSuccessStatusCode)
            {
                // User added successfully
                MessageBox.Show("New User Added!");
            }
            else
            {
                // Handle error 
                MessageBox.Show("Failed to add new user. Please try again.");
            }
        }
    }
}