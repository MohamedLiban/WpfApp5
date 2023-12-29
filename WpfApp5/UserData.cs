using System.Text.Json;

namespace YourNamespace
{
    public class UserData
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public UserData(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public static UserData FromJson(string json)
        {
            return JsonSerializer.Deserialize<UserData>(json);
        }
    }
}
