using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using Repositories;
using DBM_SwarVandana.Resources;
using Models;
namespace DBM_SwarVandana.Controllers
{
    public class EmailSMSCompanionController : Controller
    {
        //
        // GET: /EmailSMSCompanion/

        MessageTransactionRepository _allmsg = new MessageTransactionRepository();

        [Authenticate]
        public ActionResult Index(string contactNo, string msgType, int message, bool IsBrodcast = false)
        {
            var reply = "";
            //contactNo = "8800648085";
            string msg = string.Empty;
            switch (message)
            {
                case 1:
                    msg = Server.UrlEncode(SmsMessages.TETOPE);
                    break;
                case 2:
                    msg = Server.UrlEncode(SmsMessages.Renewal);
                    break;
                case 3:
                    msg = Server.UrlEncode(SmsMessages.PaymentPending);
                    break;
                case 4:
                    msg = Server.UrlEncode(SmsMessages.Enrolled);
                    break;
                case 5:
                    msg = Server.UrlEncode(SmsMessages.CustomerFeedBack);
                    break;
                default:
                    msg = "";
                    break;
            }
            try
            {
                SMSHelper s = new SMSHelper();

                if (IsBrodcast)
                    reply = s.SmsToMultipleContact(msg, contactNo);
                else
                    reply = s.SMSToSingleContact(msg, contactNo);

                MessageTransaction m = new MessageTransaction();
                m.IsBrodcast = IsBrodcast;
                m.Message = msg;
                m.MsgType = msgType;
                m.SendTo = contactNo;
                m.SendBy = SessionWrapper.User.UserId;
                m.SendDate = DateTime.Now;
                _allmsg.SaveRecord(m);
            }
            catch (Exception e)
            {
                reply = e.Message;
            }

            return Json(reply, JsonRequestBehavior.AllowGet);
        }


        [Authenticate]
        public ActionResult EmailNotify(string mailAddress, string msgType, int message, bool IsBrodcast = false)
        {
            var reply = "";

            string msg = string.Empty;
            //mailAddress = "sanjay@swarvandana.com";

            switch (message)
            {
                case 1:
                    msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\TEDonePEPending.html"));
                    break;
                case 2:
                    msg = Server.UrlEncode(SmsMessages.Renewal);
                    break;
                case 3:
                    msg = Server.UrlEncode(SmsMessages.PaymentPending);
                    break;
                case 4:
                    msg = Server.UrlEncode(SmsMessages.Enrolled);
                    break;
                case 5:
                    msg = Server.UrlEncode(SmsMessages.CustomerFeedBack);
                    break;
                default:
                    msg = "";
                    break;
            }
            string url = ConfigurationWrapper.SiteLink;
            string Imgsrc = url + @"Content/images/logo.png";
            msg = msg.Replace("{imgsrc}", Imgsrc);

            try
            {
                reply = MailHelper.SendCompanionMail(mailAddress, "Svar Vandana Music & Dance Academy.", msg);

                //if (IsBrodcast)
                //    reply = s.SmsToMultipleContact(msg, contactNo);
                //else
                //    reply = s.SMSToSingleContact(msg, contactNo);

                MessageTransaction m = new MessageTransaction();
                m.IsBrodcast = IsBrodcast;
                m.Message = msg;
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

            return Json(reply, JsonRequestBehavior.AllowGet);
        }


    }
}
