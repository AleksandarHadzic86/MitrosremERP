using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MitrosremERP.Domain.Models.Email;
using Azure.Core;
using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace MitrosremERP.Infrastructure.EmailSevices
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string Htmlmessage)
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("potvrdaregistracije@duskohadzic.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;  
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = Htmlmessage };

            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("duskohadzic1956@gmail.com", "kkbt azls sxgm uofs");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);
            }
            return Task.CompletedTask;
        }
    }
}
