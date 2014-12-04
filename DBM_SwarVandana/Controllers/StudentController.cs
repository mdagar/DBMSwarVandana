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

    }
}
