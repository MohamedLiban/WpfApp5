using System;
using System.IO;
using System.Text.Json;
using System.Windows;
using WpfApp5;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        private const string FileName = "userdata.json";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            SaveUserData(username, password);

            UserInfoWindow userInfoWindow = new UserInfoWindow();
            userInfoWindow.Show();
            Close();
        }

        private void SaveUserData(string username, string password)
        {
            UserData userData = new UserData(username, password);

            string json = JsonSerializer.Serialize(userData);

            File.WriteAllText(FileName, json);
        }
    }
}
