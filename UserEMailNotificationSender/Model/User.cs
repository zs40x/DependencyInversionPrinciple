
namespace UserEMailNotificationSender.Model
{
    class User
    {
        public User() { }

        
        public User(string username, string eMailAddress, bool isPremium)
        {
            Username = username;
            EMailAddress = eMailAddress;
            IsPremium = isPremium;
        }

        public string Username { get; set; }

        public string EMailAddress { get; set; }

        public bool IsPremium { get; set; }
    }
}
