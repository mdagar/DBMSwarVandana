using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;
using Code;
namespace DBM_SwarVandana.Controllers
{
    [Authenticate]
    public class MainController : Controller
    {
        //
        // GET: /Main/

        UsersRepository _alluser = new UsersRepository();
        CentreRepository _allcentre = new CentreRepository();
        SourceRepository _allsource = new SourceRepository();
        DisciplineRepository _alldiscipline = new DisciplineRepository();

        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult ChangePassword()
        {
            ChangePasswordViewModel pass = new ChangePasswordViewModel();
            return View(pass);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordViewModel pass)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                result = _alluser.ChangePassword(SessionWrapper.User.UserId, pass.Password, pass.NewPassword);
                if (result > 0)
                    ViewBag.Success = Messages.PasswordChanged;
                else
                    ViewBag.Error = Messages.InvalidPassword;
            }
            return View();
        }

        [Authenticate]
        public ActionResult GetCitiesByStateId(int StateId = 0)
        {
            var result = _allcentre.GetCitiesByStateId(StateId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        public ActionResult CentreRegistration()
        {
            CentresViewModel c = new CentresViewModel();
            return View(c);
        }

        [HttpPost]
        public ActionResult CentreRegistration(CentresViewModel c)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                c.ActionId = 0;
                c.AddDate = DateTime.Now;
                c.AddedBy = SessionWrapper.User.UserId;
                c.ModifyBy = SessionWrapper.User.UserId;
                c.ModifyDate = DateTime.Now;
                c.IsActive = true;
                result = _allcentre.CreateCentres(c);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitCentre;
                }
                else
                {
                    ViewBag.Error = Messages.CentreExists;
                }
            }
            else
            {
                c = new CentresViewModel();
            }
            return View(c);
        }

        public ActionResult UserRegistration()
        {
            UsersViewModel user = new UsersViewModel();
            return View(user);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult UserRegistration(UsersViewModel u)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                u.ActionId = 0;
                u.AddDate = DateTime.Now;
                u.AddedBy = SessionWrapper.User.UserId;
                u.ModifyBy = SessionWrapper.User.UserId;
                u.ModifyDate = DateTime.Now;
                u.IsActive = true;
                result = _alluser.CreateUsers(u);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitUsers;
                }
                else
                {
                    ViewBag.Error = Messages.UserExists;
                }
            }
            else
            {
                u = new UsersViewModel();
            }
            return View(u);
        }

        [Authenticate]
        public ActionResult AddSource()
        {
            return View();
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddSource(SourceViewModel src)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                src.ActionId = 0;
                src.AddDate = DateTime.Now;
                src.AddedBy = SessionWrapper.User.UserId;
                src.ModifyBy = SessionWrapper.User.UserId;
                src.ModifyDate = DateTime.Now;
                src.IsActive = true;
                result = _allsource.CreateSource(src);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitSource;
                }
                else
                {
                    ViewBag.Error = Messages.SourceExists;
                }
            }
            else
            {
                src = new SourceViewModel();
            }
            return View(src);
        }

        [Authenticate]
        public ActionResult AddDiscipline(int? DisciplineId)
        {
            DisciplineViewModel d = new DisciplineViewModel();
            if (DisciplineId.HasValue)
                d = new DisciplineViewModel(_alldiscipline.GetDisciplineById(DisciplineId));
            return View(d);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddDiscipline(DisciplineViewModel dis)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                if (dis.DisciplineId != 0)
                    dis.ActionId = 1;
                else
                    dis.ActionId = 0;
                dis.AddDate = DateTime.Now;
                dis.AddedBy = SessionWrapper.User.UserId;
                dis.ModifyBy = SessionWrapper.User.UserId;
                dis.ModifyDate = DateTime.Now;
                dis.IsActive = true;
                result = _alldiscipline.CreateDiscipline(dis);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitDisipline;
                }
                else
                {
                    ViewBag.Error = Messages.DisciplineExists;
                }
            }
            else
            {
                dis = new DisciplineViewModel();
            }
            return View(dis);
        }

        [Authenticate]
        public ActionResult ManageDiscipline()
        {
            var d = _alldiscipline.GetAllDisciplines();
            return View(d);
        }
    }
}
