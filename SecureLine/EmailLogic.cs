using System.Net.Mail;

namespace SecureLine
{
    public static class EmailLogic
    {
        public static void SendEmail(string recipientAddress, string subject, string body)
        {
            //Get the sender e-mail and display name from App.config
            string fromAddress = GlobalConfig.AppKeyLookup("senderEmail");
            string displayName = GlobalConfig.AppKeyLookup("senderDisplayName");

            //Create the e-mail
            MailAddress fromMailAddress = new MailAddress(fromAddress, displayName);
            MailMessage mail = new MailMessage();
            mail.To.Add(recipientAddress);
            mail.From = fromMailAddress;
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient client = new SmtpClient();
            //Send the e-mail
            client.Send(mail);
        }
    }
}
