﻿using Code;
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
            StudentEntrollmentViewModel se = new StudentEntrollmentViewModel();
            return View(se);
        }

        [Authenticate]
        public ActionResult GetStudentByUniqueId(string UniqueId = "")
        {
            var result = _allstudents.GetStudentsByUniqueId(UniqueId);
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
                    ViewBag.Error = Messages.Enrollexists;
                }
            }
            else
            {
                s = new StudentEntrollmentViewModel();
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
            int weekDay = m.DateOfAttendence.Value.Day;
            m.Classes = _allClassRepository.GetClassByWeekDays(SessionWrapper.User.CentreId, weekDay);
            m.students = _allstudents.GetStudentsByClassId(m.ClassId);
            return View(m);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult MakeAttendence()
        {
            // code for save time pattren
            XmlDocument doc = AttendenceCollection.ConvertToXML();
            long result = _allstudents.SaveAttendence(doc);
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
            return Json("", JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region Payment Details
        [Authenticate]
        public ActionResult PayemntDetails()
        {
            StudentEntrollmentViewModel se = new StudentEntrollmentViewModel();
            return View(se);
        }
        #endregion
    }
}
