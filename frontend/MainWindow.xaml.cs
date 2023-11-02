using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Newtonsoft.Json;
using System.Net.Http;


namespace frontend
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string token = null;
        public string Username { get; set; }

        public MainWindow()
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string u = username.Text;
            string p = password.Password;

            string response = "";
            var data = Task.Run(() => LoginHttp(u, p));
            data.Wait();
            resultTest.Content = data.Result;
            response = data.Result;
            if (string.Compare(response, "-1") == 0)
            {
                MessageBox.Show("No connection to server");
            }
            else
            {
                if (string.Compare(response, "0") == 0)
                {
                    MessageBox.Show("No connection to Database");
                }
                else
                {
                    if (string.Compare(response, "false") == 0)
                    {
                        resultTest.Content = response;
                        MessageBox.Show("Wrong username/password");
                    }
                    else
                    {
                        token = "Bearer " + response;
                        
                        HomePage homePage = new HomePage();
                        homePage.Token = token;
                        homePage.Show();
                        this.Close();

                    }
                }
            }
        }
        static async Task<string> LoginHttp(string u, string p)
        {

            var response = string.Empty;

            User objectUser = new User(u, p);

            var json = JsonConvert.SerializeObject(objectUser);
            var postData = new StringContent(json, Encoding.UTF8, "application/json");

            var url = Environment.GetBaseUrl() + "/Login";

            var client = new HttpClient();
            try
            {
                HttpResponseMessage result = await client.PostAsync(url, postData);
                response = await result.Content.ReadAsStringAsync();
                return response;
            }
            catch (Exception)
            {
                return "-1";
            }

        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Close();
        }

        private void back_btn1(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Username = Username;
            homePage.Show();
            this.Close();
        }
    }
}
