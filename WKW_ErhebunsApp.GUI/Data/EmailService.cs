using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WKW_ErhebunsApp.GUI.Data
{
    public class EmailService
    {
        private SmtpClient _client;

        public EmailService()
        {
            _client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("wkwfreielokale.app@gmail.com", "ddjuazepmeikknes"),
                EnableSsl = true
            };
        }

        public string SendEmail(string recipient, string content)
        {
            try
            {
                MailMessage message = new MailMessage
                {
                    From = new MailAddress("wkwfreielokale.app@gmail.com"),
                    Subject = $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year} Erhebung",
                    Body = content,
                    IsBodyHtml = true,
                };
                message.To.Add(recipient);

                _client.Send(message);
            }
            catch (Exception e) 
            {
                return "!ERROR: " + e.Message;
            }

            return "E-Mail was sent successfully!";
        }
    }
}
