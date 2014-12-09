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
using System.Xml;

namespace DBM_SwarVandana.Controllers
{
    public class ClassController : Controller
    {
        //
        // GET: /Class/
        ClassRepository _allclass = new ClassRepository();
        AllClassTimingPatterns _allClassTimingPatterns = new AllClassTimingPatterns();
        DisciplineRepository _allDiscipline = new DisciplineRepository();
        SourceRepository _allSources = new SourceRepository();
        UsersRepository _allUsers = new UsersRepository();
        FacultyRepository _allFaculty = new FacultyRepository();
        public static List<ClassTimingPatterns> timepattern = new List<ClassTimingPatterns>();
        public ActionResult Index()
        {
            return View();
        }
        [Authenticate]
        public ActionResult ClassDetails(long? ClassId)
        {
            ClassDetailViewModel cls;
            if (ClassId.HasValue)
                cls = new ClassDetailViewModel(_allclass.FindById(ClassId.Value));
            else
                cls = new ClassDetailViewModel();
            return View(cls);
        }

        [Authenticate]
        public ActionResult ClassDetailsList(string Search = "")
        {
            List<ClassDetails> cls = _allclass.ListClassDetails(SessionWrapper.User.CentreId, Search);
            var Discipline = _allDiscipline.GetAllDisciplines();
            var Users = _allFaculty.GetFacultyByCentreId(SessionWrapper.User.CentreId);
            cls.Update(x => x.DisciplaneName = Discipline.Where(s => s.DisciplineId == x.DisciplineId).FirstOrDefault().Discipline);
            foreach (var v in cls)
            {
                var name = Users.Where(s => s.FacultyId == v.FacultyId).FirstOrDefault();
                v.FaculityName = name == null ? "" : name.NameOfFaculty;
            }
            return View(cls);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult ClassDetails(ClassDetailViewModel cls)
        {
            var result = 0;
            if (ModelState.IsValid)
            {

                cls.ActionId = 0;
                cls.CentreId = SessionWrapper.User.CentreId;
                cls.AddDate = DateTime.Now;
                cls.AddedBy = SessionWrapper.User.UserId;
                cls.ModifyBy = SessionWrapper.User.UserId;
                cls.ModifyDate = DateTime.Now;
                cls.IsActive = true;
                cls.IsDeleted = false;
                result = _allclass.CreateClassDetails(cls);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitClass;
                }
                else
                {
                    ViewBag.Error = Messages.ClassExists;
                }
            }
            else
            {
                cls = new ClassDetailViewModel();
            }
            return View(cls);
        }

        [Authenticate]
        public ActionResult CreateClassTimming(long? classId)
        {
            ClassTimingPatternsViewModel m = new ClassTimingPatternsViewModel();
            if (classId.HasValue)
            {
                m.classDetais = _allclass.FindById(classId.Value);
                var Discipline = _allDiscipline.GetAllDisciplines();
                var Users = _allFaculty.GetFacultyByCentreId(SessionWrapper.User.CentreId);
                m.classDetais.DisciplaneName = Discipline.Where(x => x.DisciplineId == m.classDetais.DisciplineId).FirstOrDefault().Discipline;
                var name = Users.Where(s => s.FacultyId == m.classDetais.FacultyId).FirstOrDefault();
                m.classDetais.FaculityName = name == null ? "" : name.NameOfFaculty;
                m.li = _allClassTimingPatterns.FindByClassId(classId.Value);
            }
            return View(m);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult CreateClassTimming()
        {
            DateTime time;
            long classId = 0;
            bool InsertDate = true;
            if (timepattern.Count > 0)
                classId = timepattern[0].ClassId;
            foreach (var v in timepattern)
            {
                if (string.IsNullOrEmpty(v.StartTime) || string.IsNullOrEmpty(v.EndTime))
                {
                    InsertDate = false;
                    break;
                }
            }
            if (InsertDate)
            {
                // code for save time pattren
                XmlDocument doc = timepattern.ConvertToXML();
                _allClassTimingPatterns.Save(doc);
            }
            // Return Message for success and failure.
            ClassTimingPatternsViewModel m = new ClassTimingPatternsViewModel();
            m.classDetais = _allclass.FindById(classId);
            m.li = _allClassTimingPatterns.FindByClassId(classId);
            return View(m);
        }

        [Authenticate]
        public ActionResult TimeCollection(int flag = 4, long classId = 0, string randNo = "", int WeekDayId = 0, string starttime = "", string endtime = "")
        {
            //if 1 then add if 2 then remove if 3 get from database
            if (flag == 1)
            {
                ClassTimingPatterns pattren = new ClassTimingPatterns();
                if (timepattern.Count > 0)
                    pattren.PatternId = timepattern.Max(m => m.PatternId) + 1;
                else
                    pattren.PatternId = 1;
                pattren.StartTime = starttime;
                pattren.EndTime = endtime;
                pattren.WeekDayId = WeekDayId;
                pattren.AddDate = DateTime.Now;
                pattren.AddedBy = SessionWrapper.User.UserId;
                pattren.ModifyDate = DateTime.Now;
                pattren.ModifyBy = SessionWrapper.User.UserId;
                pattren.IsActive = true;
                pattren.ClassId = classId;
                timepattern.Add(pattren);
            }
            if (flag == 2)
            {
                var p = timepattern.Where(x => x.ClassId == classId && x.WeekDayId == WeekDayId).FirstOrDefault();
                timepattern.Remove(p);
            }
            if (flag == 3)
            {
                timepattern.Clear();
                // Get TimePattern According to Class Selected.
                timepattern = _allClassTimingPatterns.FindByClassId(classId);
            }
            return View(timepattern);
        }

        [Authenticate]
        public ActionResult ExportToExcel()
        {
            var Discipline = _allDiscipline.GetAllDisciplines();
            var Users = _allFaculty.GetFacultyByCentreId(SessionWrapper.User.CentreId);
            List<ClassDetails> cls = _allclass.ListClassDetails(SessionWrapper.User.CentreId);
            cls.Update(x => x.DisciplaneName = Discipline.Where(s => s.DisciplineId == x.DisciplineId).FirstOrDefault().Discipline);
            cls.Update(x => x.FaculityName = Users.Where(s => s.FacultyId == x.FacultyId).FirstOrDefault().NameOfFaculty);
            var rec = (cls.Select(s => new
            {
                Name = s.ClassName,
                Discipline = s.DisciplaneName,
                Faculty = s.FaculityName,
                StudentLimit = s.StudentLimit,
                CreatedDate = s.AddDate.Value,
                IsActive = s.IsActive
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Classes");
            return File(data.ToArray(), "application/vnd.ms-excel", "Classes");
        }


    }
}
