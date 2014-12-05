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
        public ActionResult MakeAttendence(long classId = 0)
        {
            StudentAttendenceViewModel m = new StudentAttendenceViewModel();
            m.ClassId = classId;
            m.Classes = _allClassRepository.ListClassDetails(SessionWrapper.User.CentreId);
            m.students = _allstudents.GetStudentsByClassId(SessionWrapper.User.CentreId);
            return View(m);
        }

        [Authenticate]
        public ActionResult CollectAttendence(long classId = 0)
        {
            List<StudentAttendence> list = new List<StudentAttendence>();
                       
            return View();
        }
        #endregion

    }
}
