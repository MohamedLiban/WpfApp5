using System.IO;
using System.Text.Json;
using System.Windows;

namespace YourNamespace
{
    public partial class UserInfoWindow : Window
    {
        private const string FileName = "userdata.json";

        public UserInfoWindow()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                if (File.Exists(FileName))
                {
                    string json = File.ReadAllText(FileName);
                    UserData userData = UserData.FromJson(json);

                    if (userData != null)
                    {
                        userInfoTextBlock.Text = $"Username: {userData.Username}\nPassword: {userData.Password}";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}");
            }
        }
    }
}
