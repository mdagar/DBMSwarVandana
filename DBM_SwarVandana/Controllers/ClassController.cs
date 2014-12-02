using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;

namespace DBM_SwarVandana.Controllers
{
    public class ClassController : Controller
    {
        //
        // GET: /Class/
        ClassRepository _allclass = new ClassRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClassDetails()
        {
            ClassDetailViewModel cls = new ClassDetailViewModel();
            return View(cls);
        }

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

    }
}
