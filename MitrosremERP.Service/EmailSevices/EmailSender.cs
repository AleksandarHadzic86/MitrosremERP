using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using MitrosremERP.Domain.Models.Email;
using System.Net;

namespace MitrosremERP.Infrastructure.EmailSevices
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }
        public Task SendEmailAsync(string email, string subject, string message)
        {

            var mail = "potvrdaregistracije@duskohadzic.com";
            var pw = "sr53ce17";
            var client = new SmtpClient("mail.duskohadzic.com", 465)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(mail, pw)
            };
            return client.SendMailAsync(
                new MailMessage(from: mail,
                                 to: email,
                                 subject,
                                 message));
            //var smtpClient = new SmtpClient
            //{
            //    Host = _emailSettings.SmtpServer,
            //    Port = _emailSettings.SmtpPort,
            //    Credentials = new NetworkCredential(_emailSettings.UserName, _emailSettings.Password),
            //    EnableSsl = true,
            //};

            //var mailMessage = new MailMessage
            //{
            //    From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName),
            //    Subject = subject,
            //    IsBodyHtml = true,
            //    Body = htmlMessage, // Use the htmlMessage parameter for the email body.
            //};

            //mailMessage.To.Add(email);
            //await smtpClient.SendMailAsync(mailMessage);
        }
    }
}
