using Core.Model;
using Core.Services;
using Infrastucture.Services;
using System;

namespace UserEMailNotificationSender
{
    public class Program
    {
        static void Main(string[] args)
        {
            User aUser = new User("TheUser", "the_user@mail_service.com", false);

            NotificationService sender = new NotificationService(new SMTPClient());
            sender.sendNotificationForUser(aUser);


            Console.ReadKey();
        }
    }
}
