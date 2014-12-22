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
        ClassRepository _allClassRepository = new ClassRepository();
        UsersRepository _alluser = new UsersRepository();
        CentreRepository _allcentre = new CentreRepository();
        SourceRepository _allsource = new SourceRepository();
        DisciplineRepository _allDiscipline = new DisciplineRepository();
        FacultyRepository _allfaculty = new FacultyRepository();

        public static List<StudentAttendence> AttendenceCollection = new List<StudentAttendence>();

        #region Enrollment
        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult AllStudents(string search = "", int page = 1)
        {
            ViewBag.search = search;
            int TotalPages = 0;
            var users = _alluser.AllUsers(SessionWrapper.User.CentreId).Where(x => x.RoleId < SessionWrapper.User.RoleId).ToList();
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            var stu = _allstudents.GetStudents(SessionWrapper.User.CentreId, out TotalPages, page, search);
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
                    ViewBag.Success = Messages.SubmitStudent + ", Student Id is: " + result;
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
            var result = _allstudents.GetClassByDisciplineId(DisciplineId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        public ActionResult GetClassByClassId(int ClassId)
        {
            var result = _allstudents.GetClassByClassId(ClassId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult EntrollStudent(StudentEntrollmentViewModel s)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                s.ActionId = 0;
                s.CreatedDate = DateTime.Now;
                s.CreatedBy = SessionWrapper.User.UserId;
                s.ModifBy = SessionWrapper.User.UserId;
                s.ModifyDate = DateTime.Now;
                s.IsActive = true;
                s.IsDeleted = false;
                result = _allstudents.EnrollStudents(s);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitEnroll;
                }
                else
                {
                    ModelState.AddModelError("", Messages.Enrollexists);
                }
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
            var Discipline = _allDiscipline.GetAllDisciplines();
            var Classes = _allClassRepository.GetAllClasses(SessionWrapper.User.CentreId);
            var sev = _allstudents.GetStudentDetails(studentId);
            foreach (var v in sev)
            {
                var disName = Discipline.Where(s => s.DisciplineId == s.DisciplineId).FirstOrDefault();
                v.DisciplaneName = disName == null ? "" : disName.Discipline;
            }
            foreach (var v in sev)
            {
                var clas = Classes.Where(s => s.ClassId == s.ClassId).FirstOrDefault();
                v.ClassName = clas == null ? "" : clas.ClassName;
            }
            return View(sev);
        }

        [Authenticate]
        public ActionResult GetRemainingClassesDetails(int classId, DateTime startDate, int NoofClass)
        {
            var sev = _allstudents.GetRemainingClassesDetails(classId, startDate, NoofClass);
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
            ViewBag.search = search;
            var stu = _allstudents.RenewStudentList(SessionWrapper.User.CentreId, search);
            return View(stu);
        }

        [Authenticate]
        public ActionResult RenewalStudent(int renewalId = 0)
        {
            StudentRenewalViewModel sr = new StudentRenewalViewModel();
            if (renewalId != 0)
                sr = new StudentRenewalViewModel(_allstudents.GetRenewStudentFromRenewId(SessionWrapper.User.UserId, renewalId));
            return View(sr);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult RenewalStudent(StudentRenewalViewModel s)
        {
            var result = 0;
            StudentRenewalViewModel sr;
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
        public ActionResult MakeAttendence(long classId = 0, DateTime? attendenceDate = null)
        {
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();
            m.ClassId = classId;
            m.DateOfAttendence = attendenceDate == null ? DateTime.Now : attendenceDate.Value;
            int weekDay = (int)m.DateOfAttendence.Value.DayOfWeek;
            //week day seven means it is sunday.
            if (weekDay == 0)
                weekDay = 7;
            m.WeekDayId = weekDay;
            m.Classes = _allClassRepository.GetClassByWeekDays(SessionWrapper.User.CentreId, weekDay);
            m.students = _allstudents.GetStudentsByClassId(m.ClassId);
            var CurrentAttendence = _allstudents.GetClassAttendence(m.ClassId, m.DateOfAttendence.Value);
            foreach (var v in m.students)
            {
                StudentAttendence s = new StudentAttendence();
                s.StuentId = v.StudentId;
                s.ClassId = m.ClassId;
                s.WeekDayId = m.WeekDayId;
                s.DateOfAttendence = m.DateOfAttendence;
                var status = CurrentAttendence.Where(x => x.StuentId == v.StudentId).FirstOrDefault();
                s.AttendenceStatus = status == null ? (int)AttendenceStatus.Absent : status.AttendenceStatus;
                s.AddBy = SessionWrapper.User.UserId;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.AddDate = DateTime.Now;
                s.ModifyDate = DateTime.Now;
                AttendenceCollection.Add(s);
            }
            m.studentAttendence = AttendenceCollection.Where(x => x.ClassId == m.ClassId).ToList();
            return View(m);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult MakeAttendence(DateTime? DateOfAttendence, long classId)
        {
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();

            if (AttendenceCollection.Count > 0)
            {
                if (DateOfAttendence.HasValue)
                {
                    List<StudentAttendence> FinalCollection = new List<StudentAttendence>();
                    FinalCollection = AttendenceCollection.Where(x => x.ClassId == classId).ToList();
                    FinalCollection.Update(u => u.DateOfAttendence = DateOfAttendence.Value);
                    XmlDocument doc = FinalCollection.ConvertToXML();
                    if (_allstudents.SaveAttendence(doc) >= 1)
                    {
                        foreach (var v in FinalCollection)
                            AttendenceCollection.Remove(v);
                        AttendenceCollection.TrimExcess();
                    }
                }
            }
            m.ClassId = classId;
            m.DateOfAttendence = DateOfAttendence == null ? DateTime.Now : DateOfAttendence.Value;
            int weekDay = (int)m.DateOfAttendence.Value.DayOfWeek;
            m.WeekDayId = weekDay;
            m.Classes = _allClassRepository.GetClassByWeekDays(SessionWrapper.User.CentreId, weekDay);
            //m.students = _allstudents.GetStudentsByClassId(m.ClassId);
            m.students = new List<Students>();
            return View(m);
        }

        [Authenticate]
        public ActionResult CollectAttendence(long classId, long studentId, int Status, int weekDay)
        {
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
                s.ClassId = classId;
                s.WeekDayId = weekDay;
                s.StuentId = studentId;
                AttendenceCollection.Add(s);
            }
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
        public ActionResult PayemntDetails(PaymentDetailsViewModel pdm, string ClassId)
        {
            var result = 0;
            if (!string.IsNullOrEmpty(ClassId))
            {
                if (ModelState.IsValid)
                {
                    pdm.AddDate = DateTime.Now;
                    pdm.ModifyDate = DateTime.Now;
                    pdm.ModifyBy = SessionWrapper.User.UserId;
                    pdm.AddBy = SessionWrapper.User.UserId;
                    result = _allstudents.SaveStudentPayments(pdm, ClassId);
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
        public ActionResult GetClassPaymentDetails(int ClassID, int studentID)
        {
            var result = _allstudents.GetClassPaymentDetails(ClassID, studentID);
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
            List<StudentRemarks> sr = _allstudents.GetStudentRemarksByCentreID(SessionWrapper.User.CentreId, page, search);
            ViewBag.TotalPages = TotalPages;
            var faculty = _allfaculty.GetAllFacultyByCentreId(SessionWrapper.User.CentreId);
            var student = _allstudents.GetStudentsByCentreId(SessionWrapper.User.CentreId);
            sr.Update(x => x.FacultyName = faculty.Where(s => s.FacultyId == x.FacultyID).FirstOrDefault().NameOfFaculty);
            sr.Update(x => x.StudentName = student.Where(s => s.StudentId == x.StudentId).FirstOrDefault().Name);
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
            else
            {
                sr = new StudentRemarksViewModel();
            }
            return View(sr);
        }

        #endregion

    }
}
