using UserEMailNotificationSender.Infrastucture;
using UserEMailNotificationSender.Model;

namespace UserEMailNotificationSender.BL
{
    class SMTPNotificationSender
    {
        SMTPClient smtpClient = new SMTPClient();

        public void sendNotificationForUser(User userToNotify)
        {
            string message = "Dear ";
            message += userToNotify.Username;
            message += " this is a Notification!";

            if(userToNotify.IsPremium)
            {
                message += " -> Additional Information for Premium Users!";
            }

            smtpClient.sendMail(userToNotify.EMailAddress, "Notification", message);
        }
    }
}
