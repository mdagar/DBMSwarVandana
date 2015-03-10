using System.Net.Mail;
using Code;
//using System.Web.Mail;
using System.Web.Helpers;
using System;
using System.Net;
using Models;
using Repositories;
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
    
    public static void AutoEmail(string mailAddress, string msgType, string message, bool IsBrodcast = false, string attachment = "")
    {
        MessageTransactionRepository _allmsg = new MessageTransactionRepository();
        var reply = "";
        string msg = message;
        mailAddress = "sanjay@swarvandana.com";
        //mailAddress = "mohitdagar80@gmail.com";

        string url = ConfigurationWrapper.SiteLink;
        string Imgsrc = url + @"Content/images/logo.png";
        msg = msg.Replace("{imgsrc}", Imgsrc);
        try
        {
            reply = MailHelper.SendCompanionMail(mailAddress, "Svar Vandana Music & Dance Academy.", msg, attachment);
            MessageTransaction m = new MessageTransaction();
            m.IsBrodcast = IsBrodcast;
            m.Message = message.ToString();
            m.MsgType = msgType;
            m.SendTo = mailAddress;
            m.SendBy = SessionWrapper.User.UserId;
            m.SendDate = DateTime.Now;
            _allmsg.SaveRecord(m);
        }
        catch (Exception e)
        {
            reply = e.Message;
        }

    }


    public static string SendCompanionMail(string to, string subject, string body, string fileAttachment = "")
    {
        string msg = string.Empty;
        try
        {
            to = "sanjay@swarvandana.com";
           // to = "mohitdagar80@gmail.com";
            WebMail.SmtpServer = ConfigurationWrapper.SMTP_SERVER;
            WebMail.From = "chairman.svarvandana@gmail.com";
            WebMail.Password = "mercygod";
            WebMail.SmtpPort = ConfigurationWrapper.SMTP_PORT;
            WebMail.UserName = "chairman.svarvandana@gmail.com";
            var filesList = new string[] { fileAttachment };
            WebMail.EnableSsl = true;
            if (!string.IsNullOrEmpty(fileAttachment))
                WebMail.Send(to: to, subject: subject, body: body, isBodyHtml: true, filesToAttach: filesList);
            else
                WebMail.Send(to: to, subject: subject, body: body, isBodyHtml: true);
            msg = "Mail send successfully";
        }
        catch (Exception e)
        {
            msg = e.Message;
            //throw e;
        }
        return msg;
    }
}
