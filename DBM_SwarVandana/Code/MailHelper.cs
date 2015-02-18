using System.Net.Mail;
using Code;
//using System.Web.Mail;
using System.Web.Helpers;
using System;
using System.Net;
public class MailHelper
{
    public static void SendMail(string to, string subject, string body, string fileAttachment = "")
    {
        try
        {
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = ConfigurationWrapper.SMTP_FROM;
            WebMail.Password = ConfigurationWrapper.SMTP_PASSWORD;
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = ConfigurationWrapper.SMTP_USER;            
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            WebMail.Send(to: to, subject: subject, body: body, isBodyHtml: true);
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}
