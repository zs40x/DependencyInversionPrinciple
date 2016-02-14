using Core.Interfaces;
using Core.Model;

namespace Core.Services
{
    public class NotificationService
    {
        SendMail sendMail;

        public NotificationService(SendMail _sendMail)
        {
            sendMail = _sendMail;
        }

        public void sendNotificationForUser(User userToNotify)
        {
            string message = "Dear ";
            message += userToNotify.Username;
            message += " this is a Notification!";

            if(userToNotify.IsPremium)
            {
                message += " -> Additional Information for Premium Users!";
            }

            sendMail.sendMail(userToNotify.EMailAddress, "Notification", message);
        }
    }
}
