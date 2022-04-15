using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EmailSender
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            EmailSenderModel emailSenderModel = new EmailSenderModel();

            emailSenderModel.From = "From Mail";
            emailSenderModel.To = "To Mail";
            emailSenderModel.Password = "Password";
            emailSenderModel.Body = "This is the body of email";

            EmailSender emailSender = new EmailSender();
            bool result = await emailSender.SendingEmail(emailSenderModel);

            if (result)
            {
                Console.WriteLine("Successfull!");
            }
            else
            {
                Console.WriteLine("Unsuccessful!");
            }

        }
    }
}
