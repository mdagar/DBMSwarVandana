using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ViewModel;
using Repositories;
using Code;
using System.Data;
using SqlRepositories;
using DBConnection;
using System.Text;

namespace DBM_SwarVandana.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        UsersRepository _alluser = new UsersRepository();
        DBConnections db = new DBConnections();

        public ActionResult Index()
        {
            UsersViewModel user = new UsersViewModel();
            return View(user);
        }

        [HttpPost]
        public ActionResult Index(UsersViewModel u)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = _alluser.Login(u.UserName, u.Password);

                    return RedirectToAction("Index", "Main");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            CookieWrapper.UniqueId = 0;
            Session.Abandon();
            return RedirectToAction("Index");
        }

        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ForgotPassword(string UserName)
        {
            try
            {
                if (!string.IsNullOrEmpty(UserName))
                {
                    string Query = "select UserId,(FirstName+' '+ LastName) as Name,ContactNumber,EmailID,CentreId,Password,IsActive,IsDeleted from users where username = '" + UserName + "' and IsDeleted =0 and IsActive=1";
                    DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
                    if (ds != null)
                    {
                        string emailAddress = ds.Tables[0].Rows[0]["EmailID"].ToString();
                        string password = ds.Tables[0].Rows[0]["Password"].ToString();
                        string bodymessage = "Dear " + ds.Tables[0].Rows[0]["Name"] + ", <br/>Your Swarvandana login password is '" + password + "'" + "<br/><br/> Regards <br/>Swarvandana Admin";
                        MailHelper.SendMail(emailAddress, "Swarvandana password", bodymessage);
                        ViewBag.Success = "Password has been send to your registered email address. Please check your email";
                    }
                    else
                        ViewBag.ErrorMessage = "Invalid username";
                }
                else
                    ViewBag.ErrorMessage = "Please enter userName";

            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
            }
            return View();
        }

        [Authenticate]
        public ActionResult UpdateCenter(int centerId, string number)
        {
            if (SessionWrapper.User.RoleId == (int)UserRole.SuperAdmin)
                SessionWrapper.User.CentreId = centerId;
            return Json("", JsonRequestBehavior.AllowGet);
        }

        public ActionResult SendPassword(string username)
        {
            string message = "";
            try
            {
                if (!string.IsNullOrEmpty(username))
                {
                    string Query = "select UserId,(FirstName+' '+ LastName) as Name,ContactNumber,EmailID,CentreId,Password,IsActive,IsDeleted from users where username = '" + username + "' and IsDeleted =0 and IsActive=1";
                    DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
                    if (ds != null)
                    {
                        string emailAddress = ds.Tables[0].Rows[0]["EmailID"].ToString();
                        string password = ds.Tables[0].Rows[0]["Password"].ToString();
                        string bodymessage = "Dear " + ds.Tables[0].Rows[0]["Name"] + ", <br/>Your Swarvandana login password is '" + password + "'" + "<br/><br/> Regards <br/>Swarvandana Admin";
                        MailHelper.SendMail(emailAddress, "Swarvandana password", bodymessage);
                        message = "Password has been send to your registered email address. Please check your email";
                    }
                    else
                        message = "Invalid username";
                }
            }
            catch (Exception e)
            {
                message = e.Message;
            }
            return Json(message, JsonRequestBehavior.AllowGet);

        }

        public class TEst
        {
            public string Destination { get; set; }
            public string Message { get; set; }
        }

        public ActionResult TestMessage()
        {
            int x = SendSMS("demo03", "demo@123", "8800648085", "Test Message");
            List<TEst> t = new List<TEst>();
            TEst t1 = new TEst();
            t1.Destination = "8800648085";
            t1.Message = "Test";

            TEst t2 = new TEst();
            t1.Destination = "8800648085";
            t1.Message = "Test2";
            t.Add(t1);
            t.Add(t2);

            return View();
        }



        public int SendSMS(String username, String Password, String Recipient, String Message)
        {
            WebClient Client = new WebClient();
            String RequestURL, RequestData;

            RequestURL = "http://sms3.kingdigital.in/xmlapi/smsapi";

            RequestData = "?uname=" + username
                + "&Password=" + System.Web.HttpUtility.UrlEncode(Password)
                + "&sender=Origin&group={}&route=PA&msgtype=1"
                + "&receiver=" + System.Web.HttpUtility.UrlEncode(Recipient)
                + "&sms=" + System.Web.HttpUtility.UrlEncode(Message);
            string finalUrl = RequestURL + RequestData;


            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(finalUrl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return 0;
        }


        public int SendSMS(String username, String Password, String xmlFile)
        {
            WebClient Client = new WebClient();
            String RequestURL, RequestData;

            RequestURL = "http://sms3.kingdigital.in/xmlapi/smsapi";

            RequestData = "?uname=" + username
                + "&Password=" + System.Web.HttpUtility.UrlEncode(Password)
                + "&sender=Origin&group={}&route=PA&msgtype=1"
                + "&xmlfile=" + System.Web.HttpUtility.UrlEncode(xmlFile);
            string finalUrl = RequestURL + RequestData;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(finalUrl);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            return 0;
        }




    }
}
