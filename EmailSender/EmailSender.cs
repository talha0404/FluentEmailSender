using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public class EmailSender
    {
        public EmailSender()
        {

        }

        public async Task<bool> SendingEmail(EmailSenderModel model)
        {
            try
            {
                //string host = "smtp.gmail.com";
                string host = "smtp.office365.com";

                var sender = new SmtpSender(() => new SmtpClient(host)
                {
                    UseDefaultCredentials = false,
                    Port = 587,
                    Credentials = new NetworkCredential(model.From, model.Password),
                    EnableSsl = true,
                });

                Email.DefaultSender = sender;

                var email = Email
                    .From(model.From, "You Have mail from Talha")
                    .To(model.To, "Name")
                    .Subject("Hey there!")
                    .Body("Hello");

                var response = await email.SendAsync();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
