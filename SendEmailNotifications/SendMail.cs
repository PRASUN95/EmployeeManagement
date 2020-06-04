using MailKit.Net.Smtp;
using MimeKit;
using System.IO;

namespace SendEmailNotifications
{
    public static class SendMail
    {
        public static bool sendMail()
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress("BabuBhai","from007@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("to@gmail.com"));
            mimeMessage.To.Add(new MailboxAddress("to1@gmail.com"));
            mimeMessage.Bcc.Add(new MailboxAddress("bcc.1111@gmail.com"));
            mimeMessage.Subject = "Test mail";
            string message = "<html><body>this is a <img src=cid:Logo \\> embedded image.</body></html>";
            var builder = new BodyBuilder
            {
                HtmlBody = message
            };
            var image = builder.LinkedResources.Add(@"E:\Repos\Penguins.jpg");
            image.ContentId = "Logo";
           // image.ContentId = MimeUtils.GenerateMessageId();
            mimeMessage.Body = builder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com",587,false);
                client.Authenticate("server@gmail.com", "paassss");
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
            return true;
        }
    }
}
