﻿using Core.Interfaces;
using System;

namespace Infrastucture.Services
{
    public class SMTPClient : SendMail
    {
        public void sendMail(string recipient, string subject, string message)
        {
            string debugLine = DateTime.Now.ToString();
            debugLine += ": sendMail() -> recipient: ";
            debugLine += recipient;
            debugLine += "; subject: ";
            debugLine += subject;
            debugLine += "; message: ";
            debugLine += message;

            Console.WriteLine(debugLine);
        }
    }
}
