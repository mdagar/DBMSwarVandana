using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace Code
{
    public class SMSHelper
    {
        string uid = "8800648085"; string password = "1138941964"; string senderName = "SWARVA";

        public SMSHelper()
        {

        }

        public string SMSToSingleContact(string message, string Number)
        {

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://46.4.103.196:8080/SMSAPI.jsp?username=" + uid + "&password=" + password + "&sendername=" + senderName + "&mobileno=" + Number + "&message=" + message);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
            return responseString;
        }

        public string SmsToMultipleContact(string message, string commaSepratedNumbers)
        {
            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://46.4.103.196:8080/SMSAPI.jsp?username=" + uid + "&password=" + password + "&sendername=" + senderName + "&mobileno=" + commaSepratedNumbers + "&message=" + message);
            HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
            System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
            string responseString = respStreamReader.ReadToEnd();
            respStreamReader.Close();
            myResp.Close();
            return responseString;

        }

    }
}