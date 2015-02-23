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


        public ActionResult TestMessage()
        {
            SMSHelper s = new SMSHelper();
            string SMS =  Server.UrlEncode(Resources.SmsMessages.PETOENROLL);
            int length = SMS.Length;

            //s.SmsToMultipleContact(Resources.SmsMessages.TETOPE, "8800648085");
            //s.SmsToMultipleContact(Resources.SmsMessages.CustomerFeedBack, "8800648085,9654629744");
            //s.SmsToMultipleContact(Resources.SmsMessages.Enrolled, "8800648085");
            //s.SmsToMultipleContact(Resources.SmsMessages.PaymentPending, "8800648085");
            //s.SmsToMultipleContact(Resources.SmsMessages.PETOENROLL, "8800648085");
            //s.SmsToMultipleContact(Resources.SmsMessages.Renewal, "8800648085");
            return View();

        }

    }
}
