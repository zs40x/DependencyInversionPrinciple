using System;
using UserEMailNotificationSender.BL;
using UserEMailNotificationSender.Model;

namespace UserEMailNotificationSender
{
    class Program
    {
        static void Main(string[] args)
        {
            User aUser = new User("TheUser", "the_user@mail_service.com", false);

            SMTPNotificationSender sender = new SMTPNotificationSender();
            sender.sendNotificationForUser(aUser);


            Console.ReadKey();
        }
    }
}
