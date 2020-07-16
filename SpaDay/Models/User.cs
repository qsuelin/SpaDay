using System;
namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedTime { get; set; }
        public User()
        {
            CreatedTime = DateTime.UtcNow;
        
        }
        public User(string username, string email, string password):this()
        {
            Username = username;
            Email = email;
            Password = password;
        }
    }
}
