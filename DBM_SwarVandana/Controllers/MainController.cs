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
            CentresViewModel c = new CentresViewModel();
            return View(c);
        }

        public void FillCenterIdSession(int CentreId)
        {
            SessionWrapper.User.CentreId = CentreId;
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
                    ModelState.AddModelError("", Messages.InvalidPassword);
            }
            return View();
        }

        [Authenticate]
        public ActionResult GetCitiesByStateId(int StateId = 0)
        {
            var result = _allcentre.GetCitiesByStateId(StateId);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        #region CenterPanel
        [Authenticate]
        public ActionResult CentreList(string Search = "")
        {
            List<Centres> cls = _allcentre.GetAllCentres(Search);
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            cls.Update(x => x.StateName = state.Where(s => s.StateId == x.StateId).FirstOrDefault().StateName);
            cls.Update(x => x.CityName = city.Where(s => s.CityId == x.CityId).FirstOrDefault().CityName);
            return View(cls);
        }

        [Authenticate]
        public ActionResult CentreRegistration(long? centreId)
        {
            CentresViewModel c;
            if (centreId.HasValue)
                c = new CentresViewModel(_allcentre.FindByCenterId(centreId.Value));
            else
                c = new CentresViewModel();
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
                // c.IsActive = c.IsActive == true ? true : false;
                c.IsDeleted = false;
                result = _allcentre.CreateCentres(c);
                if (result > 0)
                    ViewBag.Success = Messages.SubmitCentre;
                else
                    ModelState.AddModelError("", Messages.CentreExists);
            }
            else
            {
                c = new CentresViewModel();
            }
            return View(c);
        }

        public ActionResult ExportCenterList()
        {
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            var record = _allcentre.GetAllCentres();
            record.Update(x => x.StateName = state.Where(s => s.StateId == x.StateId).FirstOrDefault().StateName);
            record.Update(x => x.CityName = city.Where(s => s.CityId == x.CityId).FirstOrDefault().CityName);
            var rec = (record.Select(s => new
            {
                Name = s.CentreName,
                State = s.StateName,
                City = s.CityName,
                Address = s.Address,
                Status = s.StateId
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Center List");
            return File(data.ToArray(), "application/vnd.ms-excel", "*Centers");
        }

        #endregion

        #region UserRegistration
        [Authenticate]
        public ActionResult UserList(string search = "")
        {
            var users = _alluser.GetAllUsers(SessionWrapper.User.CentreId, search).Where(x => x.RoleId < SessionWrapper.User.RoleId).ToList();
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            users.Update(x => x.StateName = state.Where(s => s.StateId == x.StateId).FirstOrDefault().StateName);
            users.Update(x => x.CityName = city.Where(s => s.CityId == x.CityId).FirstOrDefault().CityName);
            return View(users);
        }

        [Authenticate]
        public ActionResult UserRegistration(long? UserId)
        {
            UsersViewModel user;// = new UsersViewModel();
            if (UserId.HasValue)
                user = new UsersViewModel(_alluser.UsersGetByUserId(UserId.Value));
            else
                user = new UsersViewModel();
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
                u.CentreId = SessionWrapper.User.CentreId;
                u.AddedBy = SessionWrapper.User.UserId;
                u.ModifyBy = SessionWrapper.User.UserId;
                u.ModifyDate = DateTime.Now;
                u.IsDeleted = false;
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

        public ActionResult ExportUserList()
        {
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            var x = _alluser.GetAllUsers(SessionWrapper.User.CentreId);
            var rec = (x.Select(s => new
            {
                Name = s.FirstName + " " + s.LastName,
                Contact = s.ContactNumber,
                Email = s.EmailID,
                State = s.StateName,
                City = s.CityName,
                Address = s.Address,
                DirthDate = s.DOB,
                JoinDate = s.DOJ
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Users List");
            return File(data.ToArray(), "application/vnd.ms-excel", "Users");
        }

        #endregion

        #region SourceManagement
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

        #endregion

        #region Disciplane Management
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
                dis.IsDeleted = false;
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
        public ActionResult ManageDiscipline(string search = "")
        {
            var d = _alldiscipline.GetAllDisciplines(search);
            return View(d);
        }

        #endregion
    }
}
