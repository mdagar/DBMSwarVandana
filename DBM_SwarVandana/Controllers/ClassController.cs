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
    public class ClassController : Controller
    {
        //
        // GET: /Class/
        ClassRepository _allclass = new ClassRepository();
        AllClassTimingPatterns _allClassTimingPatterns = new AllClassTimingPatterns();
        public static List<ClassTimingPatterns> timepattern = new List<ClassTimingPatterns>();
        public ActionResult Index()
        {
            return View();
        }
        [Authenticate]
        public ActionResult ClassDetails()
        {
            ClassDetailViewModel cls = new ClassDetailViewModel();
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
        public ActionResult CreateClassTimming(long classId = 1)
        {
            ClassTimingPatternsViewModel m = new ClassTimingPatternsViewModel();
            m.classDetais = _allclass.FindById(classId);
            return View(m);
        }
        [Authenticate]
        [HttpPost]
        public ActionResult CreateClassTimming(List<ClassTimingPatterns> p, long classId = 1)
        {
            DateTime time;
            foreach (var v in p)
            {
                if (string.IsNullOrEmpty(v.StartTime) || string.IsNullOrEmpty(v.EndTime))
                {
                    break;
                }

                if (DateTime.TryParse(v.StartTime, out time))
                {
                    if (DateTime.TryParse(v.EndTime, out time))
                    {
                        var Etime = DateTime.Parse(v.EndTime);
                        var stime = DateTime.Parse(v.StartTime);
                        if (Etime <= stime)
                            break;
                        else
                        {
                            // code for save time pattren
                        }

                    }

                }
                else
                    break;
            }
            ClassTimingPatternsViewModel m = new ClassTimingPatternsViewModel();
            m.classDetais = _allclass.FindById(classId);
            return View(m);
        }

        [Authenticate]
        public ActionResult TimeCollection(int flag = 4, long PatternId = 0, long classId = 0,string startTime="",string endTime="",string randNo="")
        {
            //if 1 then add if 2 then remove if 3 get from database
            if (flag == 1)
            {
                ClassTimingPatterns pattren = new ClassTimingPatterns();
                if (timepattern.Count > 0)
                    pattren.PatternId = timepattern.Max(m => m.PatternId) + 1;
                else
                    pattren.PatternId = 1;
                pattren.StartTime = startTime;
                pattren.EndTime = endTime;
                timepattern.Add(pattren);
            }
            if (flag == 2)
            {
                var p = timepattern.Where(x => x.PatternId == PatternId).FirstOrDefault();
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

    }
}
