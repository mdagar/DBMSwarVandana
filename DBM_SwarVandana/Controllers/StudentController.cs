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

namespace DBM_SwarVandana.Controllers
{
    public class StudentController : Controller
    {
        //
        // GET: /Student/

        StudentsRepository _allstudents = new StudentsRepository();
        ClassRepository _allClassRepository = new ClassRepository();

        public static List<StudentAttendence> AttendenceCollection = new List<StudentAttendence>();

        #region Enrollment
        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult AllStudents()
        {
            var stu = _allstudents.GetStudents(SessionWrapper.User.CentreId);
            return View(stu);
        }

        [Authenticate]
        public ActionResult AddStudent()
        {
            StudentsViewModel stu = new StudentsViewModel();
            return View(stu);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddStudent(StudentsViewModel s)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                s.ActionId = 0;
                s.UniqueKey = "STU1234";
                s.CenterId = SessionWrapper.User.CentreId;
                s.CreatedDate = DateTime.Now;
                s.CreatedBy = SessionWrapper.User.UserId;
                s.ModifyBy = SessionWrapper.User.UserId;
                s.ModifyDate = DateTime.Now;
                s.IsActive = true;
                s.IsDeleted = false;
                result = _allstudents.AdStudents(s);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitStudent;
                }
                else
                {
                    ViewBag.Error = Messages.StudentExists;
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
            return View();
        }
        #endregion

        #region Attendence
        [Authenticate]
        public ActionResult MakeAttendence(long classId = 0, DateTime? attendenceDate = null)
        {
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();
            m.ClassId = classId;
            m.DateOfAttendence = attendenceDate == null ? DateTime.Now : attendenceDate.Value;
            int weekDay = m.DateOfAttendence.Value.Day;
            m.Classes = _allClassRepository.GetClassByWeekDays(SessionWrapper.User.CentreId, weekDay);
            m.students = _allstudents.GetStudentsByClassId(SessionWrapper.User.CentreId);
            return View(m);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult MakeAttendence()
        {
            return View();
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
                s.AddDate = DateTime.Now;
                s.AttendenceStatus = Status;
                s.ClassId = classId;
                s.WeekDayId = weekDay;
                s.StuentId = studentId;
                AttendenceCollection.Add(s);
            }
            return Json("",JsonRequestBehavior.AllowGet);
        }
        #endregion

    }
}
