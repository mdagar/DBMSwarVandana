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
using System.Xml;

namespace DBM_SwarVandana.Controllers
{
    public class ExamsController : Controller
    {
        //
        // GET: /Exams/
        ExamRepository _allexams = new ExamRepository();
        StudentsRepository _allstudents = new StudentsRepository();
        FacultyRepository _allfaculty = new FacultyRepository();
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult AllExamDetails(string search = "")
        {
            int TotalPages = 0;
            List<ExamDetails> ed = _allexams.GetExamDetailsByCentreID(SessionWrapper.User.CentreId, search);
            var faculty = _allfaculty.GetAllFacultyByCentreId(SessionWrapper.User.CentreId);
            var student = _allstudents.GetStudentsByCentreId(SessionWrapper.User.CentreId);
            ed.Update(x => x.FacultyName = faculty.Where(s => s.FacultyId == x.FacultyID).FirstOrDefault().NameOfFaculty);
            ed.Update(x => x.StudentName = student.Where(s => s.StudentId == x.StudentID).FirstOrDefault().Name);
            ViewBag.TotalPages = TotalPages;
            return View(ed);
        }

        [Authenticate]
        public ActionResult AddExamDetails(Int64? ExamID)
        {
            ExamDetailsViewModel ed;
            if (ExamID.HasValue)
                ed = new ExamDetailsViewModel(_allexams.GetExamDetailsByExamID(ExamID.Value));
            else
                ed = new ExamDetailsViewModel();
            return View(ed);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddExamDetails(ExamDetailsViewModel ed)
        {
            var result = 0;
            if (ModelState.IsValid)
            {

                ed.ActionID = 0;
                ed.CentreID = SessionWrapper.User.CentreId;
                ed.CreatedOn = DateTime.Now;
                ed.CreatedBy = SessionWrapper.User.UserId;
                ed.ModifiedBy = SessionWrapper.User.UserId;
                ed.ModifiedOn = DateTime.Now;
                ed.IsDeleted = false;
                result = _allexams.InsertExamDetails(ed);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitExam;
                }
                else
                {
                    ModelState.AddModelError("", Messages.ExamExists);
                }
            }
            else
            {
                ed = new ExamDetailsViewModel();
            }
            return View(ed);
        }

    }
}
