using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using System.IO;
using Repositories;
using System.Data;
using System.Data.OleDb;
using Models;

namespace DBM_SwarVandana.Controllers
{
    public class BulkUploadController : Controller
    {

        SourceRepository _allSources = new SourceRepository();
        DisciplineRepository _allDisciplane = new DisciplineRepository();
        CentreRepository _allcenter = new CentreRepository();
        UsersRepository _allUsers = new UsersRepository();
        // GET: /BulkUpload/
        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            List<string> MessageList = new List<string>();
            List<Enquiries> RecordCollection = new List<Enquiries>();
            string path = string.Empty;
            int EnqueryType = 1;
            var Source = _allSources.GetAllSources();
            var Disciplane = _allDisciplane.GetAllDisciplines(SessionWrapper.User.CentreId);
            var State = _allcenter.GetStates();
            var City = _allcenter.GetCities();
            var users =_allUsers.AllUsers(SessionWrapper.User.CentreId);
            try
            {

                if (file == null)
                {
                    ModelState.AddModelError(string.Empty, "Please Select a file");
                }
                if (file.ContentLength > 0)
                {
                    int MaxContentLength = 1024 * 1024 * 4; //4 MB
                    string[] AllowedFileExtensions = new string[] { ".xls", ".xlsx" };

                    string fileExtension = file.FileName.Substring(file.FileName.LastIndexOf('.'));
                    if (!AllowedFileExtensions.Contains(fileExtension))
                    {
                        ModelState.AddModelError(string.Empty, "File Not Alowed" + " :" + string.Join(", ", AllowedFileExtensions));
                    }

                    else if (file.ContentLength > MaxContentLength)
                    {
                        ModelState.AddModelError(string.Empty, "File is big" + ":" + MaxContentLength + " MB");
                    }
                    else
                    {
                        //TO:DO
                        if (ModelState.IsValid)
                        {

                            var fileName = Path.GetFileName(file.FileName.Substring(0, file.FileName.LastIndexOf('.')));
                            fileName = fileName + Guid.NewGuid().ToString() + fileExtension;
                            path = Path.Combine(Server.MapPath("~/Content/TempFileCollection/"), fileName);
                            if (!Directory.Exists(Server.MapPath("~/Content/TempFileCollection/")))
                                Directory.CreateDirectory(Server.MapPath("~/Content/TempFileCollection/"));
                            file.SaveAs(path);

                            var UserUploadedRecord = this.ReadExcelUserUploadTemplat(path);
                            if (UserUploadedRecord.Rows.Count > 0)
                            {
                                // Remove Blank Sources
                                var Rowloop = UserUploadedRecord.Rows.Count;
                                var Columnloop = UserUploadedRecord.Columns.Count;
                                for (int i = Rowloop - 1; i >= 0; i--)
                                {
                                    if (string.IsNullOrEmpty(UserUploadedRecord.Rows[i][0].ToString()))
                                        UserUploadedRecord.Rows.Remove(UserUploadedRecord.Rows[i]);
                                }
                                Rowloop = UserUploadedRecord.Rows.Count;

                                // Remove Blank Disciplane
                                for (int i = Rowloop - 1; i >= 0; i--)
                                {
                                    if (string.IsNullOrEmpty(UserUploadedRecord.Rows[i][4].ToString()))
                                        UserUploadedRecord.Rows.Remove(UserUploadedRecord.Rows[i]);
                                }
                                Rowloop = UserUploadedRecord.Rows.Count;

                                // Remove Blank States
                                for (int i = Rowloop - 1; i >= 0; i--)
                                {
                                    if (string.IsNullOrEmpty(UserUploadedRecord.Rows[i][5].ToString()))
                                        UserUploadedRecord.Rows.Remove(UserUploadedRecord.Rows[i]);
                                }
                                Rowloop = UserUploadedRecord.Rows.Count;

                                // Remove Blank City
                                for (int i = Rowloop - 1; i >= 0; i--)
                                {
                                    if (string.IsNullOrEmpty(UserUploadedRecord.Rows[i][6].ToString()))
                                        UserUploadedRecord.Rows.Remove(UserUploadedRecord.Rows[i]);
                                }
                                Rowloop = UserUploadedRecord.Rows.Count;

                                //Start Loop On Rows
                                for (int row = 0; row < Rowloop; row++)
                                {
                                    var src = Source.Where(x => x.Source.Trim().ToLower() == UserUploadedRecord.Rows[row][0].ToString().Trim().ToLower()).FirstOrDefault();
                                    if (src == null)
                                    {
                                        MessageList.Add(UserUploadedRecord.Rows[row][0].ToString() + " Not exist in our record.");
                                        continue;
                                    }

                                    var Dis = Disciplane.Where(x => x.Discipline.ToString().ToLower() == UserUploadedRecord.Rows[row][4].ToString().Trim().ToLower()).FirstOrDefault();
                                    if (Dis == null)
                                    {
                                        MessageList.Add(UserUploadedRecord.Rows[row][4].ToString() + " Not exist in our record.");
                                        continue;
                                    }

                                    var sta = State.Where(x => x.StateName == UserUploadedRecord.Rows[row][5].ToString().Trim().ToLower()).FirstOrDefault();
                                    if (sta == null)
                                    {
                                        MessageList.Add(UserUploadedRecord.Rows[row][5].ToString() + " Not exist in our record.");
                                        continue;
                                    }

                                    var Cit = City.Where(x => x.CityName == UserUploadedRecord.Rows[row][6].ToString().Trim().ToLower()).FirstOrDefault();
                                    if (Cit == null)
                                    {
                                        MessageList.Add(UserUploadedRecord.Rows[row][6].ToString() + " Not exist in our record.");
                                        continue;
                                    }

                                       var Usr = users.Where(x => x.UserName == UserUploadedRecord.Rows[row][6]).FirstOrDefault();
                                    if (Cit == null)
                                    {
                                        MessageList.Add(UserUploadedRecord.Rows[row][6].ToString() + " Not exist in our record.");
                                        continue;
                                    }

                                    for (int column = 1; column < Columnloop; column++)
                                    {
                                        
                                        Enquiries e = new Enquiries();
                                        e.SourceId = src.SourceId;
                                        e.ContactNumber = UserUploadedRecord.Rows[row][1].ToString().Trim();
                                        e.Name = UserUploadedRecord.Rows[row][2].ToString().Trim();
                                        e.DateOfEnquiry = Convert.ToDateTime(UserUploadedRecord.Rows[row][3].ToString().Trim());
                                        e.Discipline = Dis.DisciplineId;
                                        e.StateId = sta.StateId;
                                        e.CityId = Cit.CityId;
                                        e.EnquiryBy =1;                                        
                                        RecordCollection.Add(e);
                                    }
                                }
                                
                                                              
                               // _allTrans_Records.Save(RecordCollection);
                                ViewBag.Success = string.Concat("Record Uploded Succefffully");
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message;
                if (!string.IsNullOrEmpty(path))
                    System.IO.File.Delete(path);
            }
            finally
            {
                if (!string.IsNullOrEmpty(path))
                    System.IO.File.Delete(path);
            }
           
            return View();
        }


        private DataTable ReadExcelUserUploadTemplat(string filePath)
        {
            DataTable dt = new DataTable();
            string con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;";
            using (OleDbConnection connection = new OleDbConnection(con))
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand("select * from [Sheet1$]", connection);
                using (OleDbDataReader dr = command.ExecuteReader())
                {
                    dt.Load(dr);
                }
            }
            return dt;
        }

    }
}
