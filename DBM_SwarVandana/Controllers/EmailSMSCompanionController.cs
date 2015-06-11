using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using DBM_SwarVandana.Resources;
using Models;
using System.Data;
using System.Text;
using ListConversion;
using System.IO;
using System.Data.OleDb;
using System.Net.Mail;
namespace DBM_SwarVandana.Controllers
{
    public class EmailSMSCompanionController : Controller
    {
        //
        // GET: /EmailSMSCompanion/

        MessageTransactionRepository _allmsg = new MessageTransactionRepository();
        StudentsRepository _allStudents = new StudentsRepository();

        [Authenticate]
        public ActionResult Index(string contactNo, string msgType, int message, bool IsBrodcast = false)
        {
            var reply = "";
            string msg = string.Empty;
            //contactNo = "7838330700";
            //contactNo = "8800648085";
            switch (message)
            {
                case 1:
                    msg = Server.UrlEncode(SmsMessages.TETOPE);
                    break;
                case 2:
                    // In case of Panding Payment We send Unique Keyof Student in Contact No.
                    contactNo = _allStudents.GetStudentsByUniqueId(contactNo).Contact1;
                    msg = Server.UrlEncode(SmsMessages.Renewal);
                    break;
                case 3:
                    msg = Server.UrlEncode(SmsMessages.PETOENROLL);
                    break;
                case 4:
                    // In case of Panding Payment We send Unique Keyof Student in Contact No.
                    contactNo = _allStudents.GetStudentsByUniqueId(contactNo).Contact1;
                    msg = Server.UrlEncode(SmsMessages.PaymentPending);
                    break;
                case 5:
                    msg = Server.UrlEncode(SmsMessages.Enrolled);
                    break;
                case 6:
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

                reply += reply + " Messge Type : " + message;
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
        public ActionResult TestEmai()
        {
            return View();
        }

        [ValidateInput(false)]
        [Authenticate]
        [HttpPost]
        public ActionResult TestEmai(string emailaddress, string message)
        {
            if (!string.IsNullOrEmpty(emailaddress) && !string.IsNullOrEmpty(message))
            {
                MailHelper.SendCompanionMail(emailaddress, "Svar Vandana Music & Dance Academy.", message);
                MessageTransaction m = new MessageTransaction();
                m.IsBrodcast = false;
                m.Message = message.ToString();
                m.MsgType = "m";
                m.SendTo = emailaddress;
                m.SendBy = SessionWrapper.User.UserId;
                m.SendDate = DateTime.Now;
                _allmsg.SaveRecord(m);
            }
            return View();

        }


        [Authenticate]
        public ActionResult BulkEmai()
        {
            return View();
        }

        [ValidateInput(false)]
        [Authenticate]
        [HttpPost]
        public ActionResult BulkEmai(HttpPostedFileBase file ,string message)
        {
            if (file == null)
            {
                ModelState.AddModelError(string.Empty, "Select a file");
            }
            else if (file.ContentLength > 0)
            {
                int MaxContentLength = 1024 * 1024 * 4; //4 MB
                string[] AllowedFileExtensions = new string[] { ".xls", ".xlsx" };

                string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf('.'));
                if (!AllowedFileExtensions.Contains(fileExtension))
                {
                    ModelState.AddModelError(string.Empty, "Only following file type is allowed :" + " :" + string.Join(", ", AllowedFileExtensions));
                }

                else if (file.ContentLength > MaxContentLength)
                {
                    ModelState.AddModelError(string.Empty, "File size is big" + ":" + MaxContentLength + " MB");
                }
                else
                {
                    //TO:DO
                    if (ModelState.IsValid)
                    {
                        var fileName = Path.GetFileName(file.FileName.Substring(0, file.FileName.LastIndexOf('.')));
                        fileName = fileName + "_" + SessionWrapper.User.UserId + "_" + DateTime.Now.ToString("dd_MM_yyyy") + "_" + Guid.NewGuid().ToString() + fileExtension;
                        var path = Path.Combine(Server.MapPath(ConfigurationWrapper.TempCollection), fileName);
                        List<string> Emails = new List<string>();

                        try
                        {
                            if (!Directory.Exists(Server.MapPath(ConfigurationWrapper.TempCollection)))
                                Directory.CreateDirectory(Server.MapPath(ConfigurationWrapper.TempCollection));
                            file.SaveAs(path);

                            //User Uploaded Record
                            var UserUploadedRecord = this.ReadExcelUser(path, "Sheet1");
                            if (UserUploadedRecord.Rows.Count > 0)
                            {

                                //  var mainSapId = Convert.ToInt32(_allAccounts.CreateNewMainSapId());
                                foreach (DataRow row in UserUploadedRecord.Rows)
                                {
                                    if (!string.IsNullOrEmpty(row[0] == null ? "" : row[0].ToString()))
                                    {
                                        if (IsValid(row[0].ToString()))
                                            Emails.Add(row[0].ToString());
                                    }
                                }                              
                                int counter = 0;
                                string mailaddress = "";
                                //send and save to database
                                int loopcounter = Emails.Count / 100;
                                for (int i = 0; i <= loopcounter; i++)
                                {
                                     mailaddress = string.Join(",", Emails.Take(90));
                                    mailaddress = mailaddress + ",mohitdagar80@gmail.com,sanjay@swarvandana.com";
                                    int numberslength = mailaddress.Split(',').Length;
                                    counter += numberslength;
                                    if (numberslength > 0)
                                    {
                                        if (counter < 950)
                                            MailHelper.BroadCastMail1("svarvandana@gmail.com", mailaddress, "Svar Vandana Music & Dance Academy.", message);
                                        else
                                            MailHelper.BroadCastMail2("svarvandana@gmail.com", mailaddress, "Svar Vandana Music & Dance Academy.", message);
                                        Emails.RemoveRange(0, numberslength);
                                         mailaddress = "";
                                    }
                                }
                            }
                        }
                        catch { }

                    }
                }
            }
            return View();
        }

        public bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        //=======Read excel =========
        private DataTable ReadExcelUser(string filePath, string sheetName)
        {
            DataTable dt = new DataTable("UserUploadedRecord");
            string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from[" + sheetName + "$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;
        }

        [Authenticate]
        public ActionResult Testsms()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult Testsms(string contactNumber, string message)
        {

            if (!string.IsNullOrEmpty(contactNumber) && !string.IsNullOrEmpty(message))
            {
                SMSHelper s = new SMSHelper();
                s.SmsToMultipleContact(message, contactNumber);
                MessageTransaction m = new MessageTransaction();
                m.IsBrodcast = false;
                m.Message = message;
                m.MsgType = "s";
                m.SendTo = contactNumber;
                m.SendBy = SessionWrapper.User.UserId;
                m.SendDate = DateTime.Now;
                _allmsg.SaveRecord(m);
            }
            return View();
        }


        [Authenticate]
        public ActionResult SendsmsCompanion()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult SendsmsCompanion(string SMS = "")
        {
            SMS = SMS.Trim();
            if (!string.IsNullOrEmpty(SMS))
            {
                DataTable dt = new DataTable();
                List<string> contactNumbers = new List<string>();
                StringBuilder sb = new StringBuilder();
                int[] centerids = new int[] { 1, 2, 3 };

                foreach (var centerid in centerids)
                {
                    SMSHelper s = new SMSHelper();
                    dt = _allmsg.GetContacts(centerid);
                    contactNumbers.Add("8800648085");

                    foreach (DataRow r in dt.Rows)
                    {
                        if (!contactNumbers.Contains(r[0].ToString()))
                            contactNumbers.Add(r[0].ToString());
                    }


                    //send and save to database
                    int loopcounter = contactNumbers.Count / 100;
                    for (int i = 0; i <= loopcounter; i++)
                    {
                        string numbers = string.Join(",", contactNumbers.Take(100));
                        int numberslength = numbers.Split(',').Length;
                        if (numberslength > 0)
                        {
                            s.SmsToMultipleContact(SMS, numbers);
                            MessageTransaction m = new MessageTransaction();
                            m.IsBrodcast = true;
                            m.Message = SMS;
                            m.MsgType = "s";
                            m.SendTo = numbers;
                            m.SendBy = SessionWrapper.User.UserId;
                            m.SendDate = DateTime.Now;
                            _allmsg.SaveRecord(m);
                            contactNumbers.RemoveRange(0, numberslength);
                        }
                    }
                    contactNumbers.Clear();
                }
            }
            else
            {
                ViewBag.Error = "Please enter message";
            }

            return View();
        }

        [Authenticate]
        public ActionResult SendEmailCompanion()
        {

            return View();
        }

        [ValidateInput(false)]
        [Authenticate]
        [HttpPost]
        public ActionResult SendEmailCompanion(int centerid, string Email = "")
        {
            Email = Email.Trim();
            int counter = 0;
            if (!string.IsNullOrEmpty(Email))
            {
                StringBuilder bcc = new StringBuilder();
                DataTable dt = new DataTable();
                List<string> emailAddress = new List<string>();

                dt = _allmsg.GetEmailAddress(centerid);
                emailAddress.Add("mohitdagar80@gmail.com");

                foreach (DataRow r in dt.Rows)
                {
                    if (!emailAddress.Contains(r[0].ToString()))
                        emailAddress.Add(r[0].ToString());
                }
                //send and save to database
                int loopcounter = emailAddress.Count / 100;
                for (int i = 0; i <= loopcounter; i++)
                {
                    string mailaddress = string.Join(",", emailAddress.Take(90));
                    int numberslength = mailaddress.Split(',').Length;
                    counter += numberslength;
                    if (numberslength > 0)
                    {
                        if (counter < 350)
                            MailHelper.BroadCastMail1("svarvandana@gmail.com", mailaddress, "Svar Vandana Music & Dance Academy.", Email);
                        else
                            MailHelper.BroadCastMail2("svarvandana@gmail.com", mailaddress, "Svar Vandana Music & Dance Academy.", Email);
                        //MessageTransaction m = new MessageTransaction();
                        //m.IsBrodcast = true;
                        //m.Message = Email;
                        //m.MsgType = "E";
                        //m.SendTo = mailaddress;
                        //m.SendBy = SessionWrapper.User.UserId;
                        //m.SendDate = DateTime.Now;
                        //_allmsg.SaveRecord(m);
                        emailAddress.RemoveRange(0, numberslength);
                    }
                }
                emailAddress.Clear();
            }

            else
            {
                ViewBag.Error = "Please enter message";
            }

            return View();
        }


        [Authenticate]
        public ActionResult EmailNotify(string mailAddress, string msgType, int message, bool IsBrodcast = false)
        {
            var reply = "";
            string attachment = string.Empty;
            string msg = string.Empty;
            //mailAddress = "sanjay@swarvandana.com";
            //mailAddress = "mohitdagar80@gmail.com";

            switch (message)
            {
                case 1:
                    msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\TEDonePEPending.html"));
                    break;
                case 2:
                    //msg = Server.UrlEncode(SmsMessages.Renewal);
                    mailAddress = _allStudents.GetStudentsByUniqueId(mailAddress).EmailAddress;
                    msg = msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\Renewal.html"));
                    break;
                case 3:
                    msg = msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\PEDoneEnrollPending.html"));
                    break;
                case 4:
                    //msg = Server.UrlEncode(SmsMessages.PaymentPending);
                    mailAddress = _allStudents.GetStudentsByUniqueId(mailAddress).EmailAddress;
                    msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\PendingPayment.html"));
                    break;
                case 5:
                    msg = System.IO.File.ReadAllText(Server.MapPath(@"~\Content\EmalTemplates\Enrollment.html"));
                    attachment = Server.MapPath(@"~\Content\Downloads\Welcome Presentation.pptx");
                    break;
                case 6:
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
                reply = MailHelper.SendCompanionMail(mailAddress, "Svar Vandana Music & Dance Academy.", msg, attachment);

                reply += reply + " Mail Type : " + message;

                //if (IsBrodcast)
                //    reply = s.SmsToMultipleContact(msg, contactNo);
                //else
                //    reply = s.SMSToSingleContact(msg, contactNo);

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

            return Json(reply, JsonRequestBehavior.AllowGet);
        }


    }
}
