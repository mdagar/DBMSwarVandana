using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;
using Models;
using ListConversion;
using System.Data;
using System.Xml;
namespace DBM_SwarVandana.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        StudentsRepository _allstudents = new StudentsRepository();
        UsersRepository _alluser = new UsersRepository();
        CentreRepository _allcentre = new CentreRepository();
        SourceRepository _allsource = new SourceRepository();
        DisciplineRepository _allDiscipline = new DisciplineRepository();
        FacultyRepository _allfaculty = new FacultyRepository();
        AllBatches _allBatches = new AllBatches();
        EnquiryRepository _allenquiry = new EnquiryRepository();

        public List<StudentAttendence> AttendenceCollection = new List<StudentAttendence>();

        #region Enrollment
        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult AllStudents(string search = "", int page = 1)
        {
            search = search.Trim();
            ViewBag.search = search.Trim();
            int TotalPages = 0;
            var users = _alluser.AllUsers(SessionWrapper.User.CentreId).Where(x => x.RoleId < SessionWrapper.User.RoleId).ToList();
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            var stu = _allstudents.GetStudents(SessionWrapper.User.CentreId, out TotalPages, page, search.Trim());
            stu.Update(x => x.StateName = state.Where(s => s.StateId == x.StateId).FirstOrDefault().StateName);
            stu.Update(x => x.CityName = city.Where(s => s.CityId == x.CityId).FirstOrDefault().CityName);
            ViewBag.TotalPages = TotalPages;
            return View(stu);
        }

        [Authenticate]
        public ActionResult AddStudent(string uniqueId = "")
        {
            StudentsViewModel stu = new StudentsViewModel();
            if (uniqueId != "")
                stu = new StudentsViewModel(_allstudents.GetStudentsByUniqueId(uniqueId));
            return View(stu);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddStudent(StudentsViewModel s)
        {
            var result = "";
            StudentsViewModel stu = new StudentsViewModel();
            if (ModelState.IsValid)
            {
                s.ActionId = 0;
                s.CenterId = SessionWrapper.User.CentreId;
                s.CreatedDate = DateTime.Now;
                s.CreatedBy = SessionWrapper.User.UserId;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.ModifyDate = DateTime.Now;
                s.IsDeleted = false;
                if (!String.IsNullOrEmpty(s.UniqueKey))
                {
                    stu = new StudentsViewModel(_allstudents.GetStudentsByUniqueId(s.UniqueKey));
                    stu.ActionId = 1;
                    stu.Name = s.Name;
                    stu.EmailAddress = s.EmailAddress;
                    stu.Contact2 = s.Contact2;
                    stu.Contact1 = s.Contact1;
                    stu.Address = s.Address;
                    stu.ModifyBy = SessionWrapper.User.UserId;
                    stu.ModifyDate = DateTime.Now;
                    stu.IsDeleted = false;
                    result = _allstudents.AdStudents(stu);
                }
                else
                {
                    result = _allstudents.AdStudents(s);
                }
                if ((result != "-1") || (result != ""))
                {
                    ViewBag.Success = Messages.SubmitStudent + ", Enrollment No : " + result;
                }
                else
                {
                    ModelState.AddModelError("", Messages.StudentExists);
                }
            }
            else
            {
                s = new StudentsViewModel();
            }
            return View(s);
        }

        [Authenticate]
        public ActionResult EntrollStudent()
        {
            StudentEntrollmentViewModel se = new StudentEntrollmentViewModel();
            return View(se);
        }

        [Authenticate]
        public ActionResult GetStudentByUniqueId(string UniqueId = "")
        {
            var result = _allstudents.GetStudentsByUniqueId(UniqueId);
            if (result == null)
            {
                result = new Students();
                result.StudentId = 0;
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        public ActionResult GetStudentsByEnrollmentId(int EnrollmentId)
        {
            var result = _allstudents.GetStudentsByEnrollmentId(EnrollmentId);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in result.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in result.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }

        [Authenticate]
        public ActionResult GetClassByDisciplineId(int DisciplineId)
        {
            // var result = _allstudents.GetClassByDisciplineId(DisciplineId);
            var result = "";
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        [Authenticate]
        [HttpPost]
        public ActionResult EntrollStudent(StudentEntrollmentViewModel s, List<int> BatchIds, bool PE)
        {
            List<StudentBatchMapping> batchmapping = new List<StudentBatchMapping>();
            if (BatchIds.Count <= 0)
                ModelState.AddModelError(string.Empty, "Please assign batch.");

            if (PE == false)
            {
                var res = _allenquiry.FindByEnquirieNumber(s.EnqueryNo);
                if (res == null)
                    ModelState.AddModelError(string.Empty, "Invalid Enquery Number");
                else
                    s.IsRenewal = false;
            }
            else
            {
                s.EnqueryNo = string.Empty;
                s.IsRenewal = true;
            }

            if (s.StudentId == 0)
                ModelState.AddModelError(string.Empty, "Invalid Enrollment No.");

            if (s.CourseAmount < (s.RegistratonAmount + s.AmountPaid))
                ModelState.AddModelError(string.Empty, "Amount paid + Registration should be less then course amount");

            var result = 0;
            if (ModelState.IsValid)
            {
                s.ActionId = 0;
                s.CreatedDate = DateTime.Now;
                s.CreatedBy = SessionWrapper.User.UserId;
                s.ModifBy = SessionWrapper.User.UserId;
                s.ModifyDate = DateTime.Now;
                s.BankName = string.IsNullOrEmpty(s.BankName) ? "" : s.BankName;
                s.PaymentDetails = string.IsNullOrEmpty(s.PaymentDetails) ? "" : s.PaymentDetails;
                s.IsActive = true;
                s.IsDeleted = false;
                result = _allstudents.EnrollStudents(s);
                if (result > 0)
                {
                    foreach (var v in BatchIds)
                    {
                        StudentBatchMapping m = new StudentBatchMapping();
                        m.BatchId = v;
                        m.StudentId = s.StudentId;
                        m.EnrollmentId = result;
                        m.CreatedBy = SessionWrapper.User.UserId;
                        m.ModifyBy = SessionWrapper.User.UserId;
                        m.CreatedDate = DateTime.Now;
                        m.ModifyDate = DateTime.Now;
                        batchmapping.Add(m);
                    }
                    _allBatches.SaveBatches(batchmapping);
                    ViewBag.Success = Messages.SubmitEnroll;
                }
                else
                    ModelState.AddModelError("", Messages.Enrollexists);
            }
            else
            {
                s = new StudentEntrollmentViewModel();
            }
            return View(s);
        }

        [Authenticate]
        public ActionResult Studentdetail(long studentId)
        {
            var Discipline = _allDiscipline.GetAllDisciplines(SessionWrapper.User.CentreId);
            var sev = _allstudents.GetStudentDetails(studentId);
            foreach (var v in sev)
            {
                var disName = Discipline.Where(s => s.DisciplineId == v.DisciplineId).FirstOrDefault();
                v.DisciplaneName = disName == null ? "" : disName.Discipline;
            }

            return View(sev);
        }

        [Authenticate]
        public ActionResult GetClassEndDate(DateTime startDate, int NoofClass, string batchids)
        {
            var sev = _allstudents.GetEndDate(startDate, NoofClass, batchids, SessionWrapper.User.CentreId);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in sev.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in sev.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }

        [Authenticate]
        public ActionResult RenewalStudentList(string search = "")
        {
            search = search.Trim();
            ViewBag.search = search.Trim();
            var stu = _allstudents.RenewStudentList(SessionWrapper.User.CentreId, search.Trim());
            return View(stu);
        }

        [Authenticate]
        public ActionResult RenewalStudent(int renewalId = 0)
        {
            StudentRenewalViewModel sr = new StudentRenewalViewModel();
            if (renewalId != 0)
            {
                sr = new StudentRenewalViewModel(_allstudents.GetRenewStudentFromRenewId(SessionWrapper.User.UserId, renewalId));
            }
            return View(sr);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult RenewalStudent(StudentRenewalViewModel s)
        {
            var result = 0;
            StudentRenewalViewModel sr;
            var s1 = _allstudents.GetStudentsByUniqueId(s.EnrollmentNo);

            if (s1 == null)
                ModelState.AddModelError(string.Empty, "Please enter valid Enrollment no.");

            if (ModelState.IsValid)
            {
                s.ActionId = 0;
                s.AddDate = DateTime.Now;
                s.ModifyDate = DateTime.Now;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.AddedBy = SessionWrapper.User.UserId;
                s.CenterId = SessionWrapper.User.CentreId;
                if (s.RenewalId != 0)
                {
                    sr = new StudentRenewalViewModel(_allstudents.GetRenewStudentFromRenewId(SessionWrapper.User.UserId, s.RenewalId));
                    sr.ActionId = 1;
                    sr.ModifyDate = DateTime.Now;
                    sr.ModifyBy = SessionWrapper.User.UserId;
                    sr.Description = s.Description;
                    sr.Remark = s.Remark;
                    sr.Status = s.Status;
                    result = _allstudents.RenewalStudents(sr);
                }
                else
                {
                    result = _allstudents.RenewalStudents(s);
                }
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitRenewal;
                }
            }
            else
            {
                s = new StudentRenewalViewModel();
            }
            return View(s);
        }

        #endregion

        #region Attendence
        [Authenticate]
        public ActionResult MakeAttendence(long displaneId = 0, long batchId = 0, DateTime? DateOfAttendence = null)
        {
            Session["Atendence"] = null;
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();
            m.DateOfAttendence = DateOfAttendence == null ? DateTime.Now : DateOfAttendence.Value;
            // IN sql serevr Sunday is 7
            int weekday = (int)m.DateOfAttendence.Value.DayOfWeek;
            if (weekday == 0)
                weekday = 7;
            m.Disciplines = _allDiscipline.GetAllDisciplines(SessionWrapper.User.CentreId);
            m.Batches = _allBatches.FindBatchByDayId(SessionWrapper.User.CentreId, weekday);
            m.disciplaneid = displaneId;
            m.BatchId = batchId;
            m.students = _allstudents.GetStudentsByDisciplane(displaneId, batchId, weekday,m.DateOfAttendence.Value);
            var CurrentAttendence = _allstudents.GetClassAttendence(m.BatchId, m.DateOfAttendence.Value);
            foreach (var v in m.students)
            {
                StudentAttendence s = new StudentAttendence();
                s.StuentId = v.StudentId;
                s.DisciplaneId = displaneId;
                s.BatchId = m.BatchId;
                s.EnrollmentId = v.EnrollmentId;
                s.DateOfAttendence = m.DateOfAttendence;
                var status = CurrentAttendence.Where(x => x.StuentId == v.StudentId).FirstOrDefault();
                s.AttendenceStatus = status == null ? (int)AttendenceStatus.Absent : status.AttendenceStatus;
                s.AddBy = SessionWrapper.User.UserId;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.AddDate = DateTime.Now;
                s.ModifyDate = DateTime.Now;
                AttendenceCollection.Add(s);
            }
            Session["Atendence"] = AttendenceCollection;
            //m.studentAttendence = AttendenceCollection.Where(x => x.BatchId == m.BatchId && x.DisciplaneId == m.disciplaneid).ToList();
            return View(m);
        }

        [Authenticate]
        public ActionResult GetbatchTimming(DateTime? DateOfAttendence = null)
        {
            int weekday = (int)DateOfAttendence.Value.DayOfWeek;
            if (weekday == 0)
                weekday = 7;
            var Batches = _allBatches.FindBatchByDayId(SessionWrapper.User.CentreId, weekday);
            return Json(Batches, JsonRequestBehavior.AllowGet);
        }



        [Authenticate]
        [HttpPost]
        public ActionResult MakeAttendence(DateTime? DateOfAttendence, long BatchId, long DisciplaneId)
        {
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();
            int weekday = 0;
            if (Session["Atendence"] == null)
                AttendenceCollection = new List<StudentAttendence>();
            else
                AttendenceCollection = (List<StudentAttendence>)Session["Atendence"];
            if (AttendenceCollection.Count > 0)
            {
                if (DateOfAttendence.HasValue)
                {
                    weekday = (int)DateOfAttendence.Value.DayOfWeek;
                    if (weekday == 0)
                        weekday = 7;
                    List<StudentAttendence> FinalCollection = new List<StudentAttendence>();
                    FinalCollection = AttendenceCollection.Where(x => x.BatchId == BatchId && x.DisciplaneId == DisciplaneId).ToList();
                    FinalCollection.Update(u => u.DateOfAttendence = DateOfAttendence.Value);
                    XmlDocument doc = FinalCollection.ConvertToXML();
                    if (_allstudents.SaveAttendence(doc) >= 1)
                    {
                        foreach (var v in FinalCollection)
                            AttendenceCollection.Remove(v);
                        AttendenceCollection.TrimExcess();
                        ViewBag.Success = "Attendence submit successfully.";
                    }
                }
                else
                    ViewBag.Error = "Please select attendence date";
            }
            m.Disciplines = _allDiscipline.GetAllDisciplines(SessionWrapper.User.CentreId);
            m.DateOfAttendence = DateOfAttendence;
            m.BatchId = BatchId;
            m.disciplaneid = DisciplaneId;
            m.Batches = _allBatches.FindBatchByDayId(SessionWrapper.User.CentreId, weekday);
            m.students = new List<Students>();
            Session["Atendence"] = null;
            return View(m);
        }

        [Authenticate]
        public ActionResult CollectAttendence(long batchId, long studentId, int Status, long EnrollmentId, long disciplaneid)
        {
            if (Session["Atendence"] == null)
                AttendenceCollection = new List<StudentAttendence>();
            else
                AttendenceCollection = (List<StudentAttendence>)Session["Atendence"];

            //Session["Atendence"] = AttendenceCollection;
            var SAttendence = AttendenceCollection.Where(x => x.StuentId == studentId).FirstOrDefault();
            if (SAttendence != null)
                AttendenceCollection.Where(x => x.StuentId == studentId).Update(u => u.AttendenceStatus = Status);
            else
            {
                StudentAttendence s = new StudentAttendence();
                s.AddBy = SessionWrapper.User.UserId;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.AddDate = DateTime.Now;
                s.ModifyDate = DateTime.Now;
                s.AttendenceStatus = Status;
                s.BatchId = batchId;
                s.EnrollmentId = EnrollmentId;
                s.StuentId = studentId;
                s.DisciplaneId = disciplaneid;
                AttendenceCollection.Add(s);
            }
            Session["Atendence"] = AttendenceCollection;
            return Json("", JsonRequestBehavior.AllowGet);
        }

        #endregion

        #region Payment Details
        [Authenticate]
        public ActionResult PayemntDetails()
        {
            PaymentDetailsViewModel pd = new PaymentDetailsViewModel();
            return View(pd);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult PayemntDetails(PaymentDetailsViewModel pdm, string DisciplineId)
        {
            var result = 0;
            if (!string.IsNullOrEmpty(DisciplineId))
            {
                if (ModelState.IsValid)
                {
                    pdm.AddDate = DateTime.Now;
                    pdm.ModifyDate = DateTime.Now;
                    pdm.ModifyBy = SessionWrapper.User.UserId;
                    pdm.AddBy = SessionWrapper.User.UserId;
                    result = _allstudents.SaveStudentPayments(pdm, DisciplineId);
                    if (result > 0)
                    {
                        ViewBag.Success = Messages.SubmitPayment;
                    }
                }
                else
                {
                    pdm = new PaymentDetailsViewModel();
                }
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Please select discipline for payment.");
                //ViewBag.Error = "Please select discipline for payment.";
            }
            return View(pdm);
        }

        [Authenticate]
        public ActionResult GetClassesForPayments(int studentId)
        {
            var result = _allstudents.GetClassesForPayments(studentId, SessionWrapper.User.CentreId);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in result.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in result.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }

        [Authenticate]
        public ActionResult GetAllDisciplineForStudent(int studentId)
        {
            var result = _allstudents.GetAllDiscliplineForStudents(studentId, SessionWrapper.User.CentreId);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in result.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in result.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }
        [Authenticate]
        public ActionResult GetDisciplinePaymentDetails(int disciplineId, int studentID, long enrollmentId)
        {
            var result = _allstudents.GetDisciplinePaymentDetails(disciplineId, studentID, enrollmentId);
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in result.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in result.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }
        #endregion

        #region Student Remarks

        public ActionResult GetUniqueKeyByStudentId(Int64 StudentId)
        {
            var d = _allstudents.GetStudentByStudentId(StudentId);
            return Json(d.UniqueKey, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        public ActionResult AllRemarks(string search = "", int page = 1)
        {
            int TotalPages = 0;
            search = search.Trim();
            ViewBag.Search = search;
            List<StudentRemarks> sr = _allstudents.GetStudentRemarksByCentreID(SessionWrapper.User.CentreId, out TotalPages, page, search);
            ViewBag.TotalPages = TotalPages;
            var faculty = _allfaculty.GetAllFacultyByCentreId(SessionWrapper.User.CentreId);
            var student = _allstudents.GetStudentsByCentreId(SessionWrapper.User.CentreId);
            sr.Update(x => x.FacultyName = faculty.Where(s => s.FacultyId == x.FacultyID).FirstOrDefault().NameOfFaculty);
            foreach (var v in sr)
            {
                var stu = student.Where(s => s.StudentId == v.StudentId).FirstOrDefault();
                v.StudentName = stu == null ? "" : stu.Name;
                v.EnrollmentNo = stu == null ? "" : stu.UniqueKey;
            }

            return View(sr);
        }

        [Authenticate]
        public ActionResult AddRemarks(Int64 RemarksID = 0)
        {
            StudentRemarksViewModel sr = new StudentRemarksViewModel();
            if (RemarksID != 0)
                sr = new StudentRemarksViewModel(_allstudents.GetStudentRemarksByRemarksID(RemarksID));
            return View(sr);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddRemarks(StudentRemarksViewModel sr)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                sr.ActionID = 0;
                sr.CentreID = SessionWrapper.User.CentreId;
                sr.CreatedOn = DateTime.Now;
                sr.CreatedBy = SessionWrapper.User.UserId;
                sr.ModifiedBy = SessionWrapper.User.UserId;
                sr.ModifiedOn = DateTime.Now;
                sr.IsDeleted = false;
                if (sr.RemarksID == 0)
                    sr.ActionID = 0;
                else
                    sr.ActionID = 1;
                result = _allstudents.InsertStudentRemarks(sr);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitRemarks;
                }
                else
                {
                    ModelState.AddModelError("", Messages.RemarksExists);
                }
            }
            sr = new StudentRemarksViewModel(_allstudents.GetStudentRemarksByRemarksID(sr.RemarksID));
            return View(sr);
        }

        #endregion

        #region Batches
        public ActionResult Listbatches()
        {
            List<Batches> b = new List<Batches>();
            b = _allBatches.FindAllBatches(SessionWrapper.User.CentreId);
            return View(b);
        }

        [Authenticate]
        public ActionResult BatchTimingUpdate()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult BatchTimingUpdate(List<int> BatchIds, long StudentId = 0, long EnrollmentId = 0)
        {
            if (StudentId != 0)
            {
                if (EnrollmentId != 0)
                {
                    if (BatchIds.Count <= 0)
                        ModelState.AddModelError(string.Empty, "Please assign batch.");
                    else
                    {
                        List<StudentBatchMapping> batchmapping = new List<StudentBatchMapping>();

                        foreach (var v in BatchIds)
                        {
                            StudentBatchMapping m = new StudentBatchMapping();
                            m.BatchId = v;
                            m.StudentId = StudentId;
                            m.EnrollmentId = EnrollmentId;
                            m.CreatedBy = SessionWrapper.User.UserId;
                            m.ModifyBy = SessionWrapper.User.UserId;
                            m.CreatedDate = DateTime.Now;
                            m.ModifyDate = DateTime.Now;
                            batchmapping.Add(m);
                        }
                        _allBatches.UpdateBatchesForStudent(batchmapping, StudentId, EnrollmentId);
                        ViewBag.Success = "Batch timing is successfully updated";
                    }
                }
                else

                    ModelState.AddModelError(string.Empty, "Please Select Discipline.");
            }
            else
                ModelState.AddModelError(string.Empty, "Please enter Student Details.");

            return View();
        }

        public ActionResult GetDisciplineBatchDetails(long disciplineId, long studentID, long enrollmentId)
        {
            StudentBatchDetailsViewModel stu = new StudentBatchDetailsViewModel();
            stu.allbatch = _allBatches.FindAllBatches(SessionWrapper.User.CentreId);
            stu.selectbatch = _allBatches.FindBatchesForStudentDescipline(studentID, enrollmentId, disciplineId);
            return View(stu);
        }
        #endregion

    }
}
