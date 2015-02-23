using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using Repositories;
using Models;
namespace DBM_SwarVandana.Controllers
{
    public class EmailSMSCompanionController : Controller
    {
        //
        // GET: /EmailSMSCompanion/

        MessageTransactionRepository _allmsg = new MessageTransactionRepository();

        [Authenticate]
        public ActionResult Index(string contactNo, string msgType, string message, bool IsBrodcast = false)
        {
            var reply = "";
            var msg = Server.UrlEncode(message);
            try
            {
                SMSHelper s = new SMSHelper();

                if (IsBrodcast)
                    reply = s.SmsToMultipleContact(msg, contactNo);
                else
                    reply = s.SMSToSingleContact(msg, contactNo);

                MessageTransaction m = new MessageTransaction();
                m.IsBrodcast = IsBrodcast;
                m.Message = message;
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

    }
}
