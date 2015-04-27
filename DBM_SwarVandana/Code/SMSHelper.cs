using DBM_SwarVandana.Resources;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Code
{
    public class SMSHelper
    {
        string uid = "8800648085"; string password = "8800648085"; string senderName = "SWARVA"; string apiKey = "6cddb922-a2a2-4a50-9c4b-6007775b6bee";

        public SMSHelper()
        {

        }

        public void AutoSMS(string contactNo, string msgType, string message, bool IsBrodcast = false)
        {
            MessageTransactionRepository _allmsg = new MessageTransactionRepository();
            var reply = "";
            string msg = string.Empty;
            //contactNo = "7838330700";
            //contactNo = "8800648085";

            try
            {
                SMSHelper s = new SMSHelper();

                if (IsBrodcast)
                    reply = s.SmsToMultipleContact(message, contactNo);
                else
                    reply = s.SMSToSingleContact(message, contactNo);

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

        }

        public string SMSToSingleContact(string message, string Number)
        {
            //Number = "7838330700";
            //Number = "8800648085";
            string api = "http://46.4.103.196:8090/sendSMS?username=" + uid + "&message=" + message + "&sendername=" + senderName + "&smstype=PROMO&numbers=" + Number + "&apikey=" + apiKey + "";
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(api);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
            return responseString;
         
        }

        public string SmsToMultipleContact(string message, string commaSepratedNumbers)
        {
            //commaSepratedNumbers = "7838330700";
            //commaSepratedNumbers = "8800648085";
            string api = "http://46.4.103.196:8090/sendSMS?username=" + uid + "&message=" + message + "&sendername=" + senderName + "&smstype=PROMO&numbers=" + commaSepratedNumbers + "&apikey=" + apiKey + "";
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(api);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
            return responseString;

        }

    }
}