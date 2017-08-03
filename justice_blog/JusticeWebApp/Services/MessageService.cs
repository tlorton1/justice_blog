using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace JusticeWebApp.Services
{
    public class MessageService : IMessageService
    {
        public bool SendMessage(string name, string email, string message)
        {
            try
            {
                var msg = new MailMessage(email, "allegarjustice@yahoo.com", "New Contact", message);

                var client = new SmtpClient();
                client.Send(msg);
            }
            catch (Exception ex)
            {
                // Add logging
                return false;
            }

            return true;
        }
    }
}