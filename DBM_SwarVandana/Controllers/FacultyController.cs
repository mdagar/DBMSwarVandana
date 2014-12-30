using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;
using System.IO;
using Models;

namespace DBM_SwarVandana.Controllers
{
    public class FacultyController : Controller
    {
        //
        // GET: /Faculty/
        FacultyRepository _allfaculty = new FacultyRepository();
        DisciplineRepository _allDiscipline = new DisciplineRepository();
        CentreRepository _allcentre = new CentreRepository();

        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult GetFaculityList(string search = "", int page = 1)
        {
            int TotalPages = 0;
            List<Faculties> fac = _allfaculty.GetFacultyByCentreId(SessionWrapper.User.CentreId, out TotalPages, page, search.Trim());
            ViewBag.TotalPages = TotalPages;
            var Discipline = _allDiscipline.GetAllDisciplines();
            var state = _allcentre.GetStates();
            var city = _allcentre.GetCities();
            foreach (var v in fac)
            {
                var sname = state.Where(x => x.StateId == v.StateId).FirstOrDefault();
                v.StateName = sname == null ? "" : sname.StateName;

                var cname = city.Where(x => x.CityId == v.CityId).FirstOrDefault();
                v.CityName = cname == null ? "" : cname.CityName;
            }
            fac.Update(x => x.DisciplaneName = Discipline.Where(s => s.DisciplineId == x.DisciplineId).FirstOrDefault().Discipline);
            return View(fac);
        }

        [Authenticate]
        public ActionResult FacultyRegistration(int? facultyId)
        {
            FacultyViewModel f = new FacultyViewModel();
            if (facultyId.HasValue)
                f = new FacultyViewModel(_allfaculty.GetFacultyByFacultyId(facultyId.Value));
            return View(f);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult FacultyRegistration(FacultyViewModel fl)
        {
            var result = 0;
            FacultyViewModel fac = new FacultyViewModel();
            if (ModelState.IsValid)
            {
                fac.ActionId = 0;
                if (fl.FacultyId != 0)
                {
                    fac = new FacultyViewModel(_allfaculty.GetFacultyByFacultyId(fl.FacultyId));
                    fac.ActionId = 1;
                }
                fac.NameOfFaculty = fl.NameOfFaculty;
                fac.EmailID = fl.EmailID;
                fac.ContactNumber = fl.ContactNumber;
                fac.Address = fl.Address;
                fac.StateId = fl.StateId;
                fac.CityId = fl.CityId;
                fac.DOJ = fl.DOJ;
                fac.DOB = fl.DOB;
                fac.Gender = fl.Gender;
                fac.Salary = fl.Salary;
                fac.SalaryRevision = fl.SalaryRevision;
                fac.DisciplineId = fl.DisciplineId;
                fac.YearOfExperience = fl.YearOfExperience;
                fac.CentreId = SessionWrapper.User.CentreId;
                fac.AddDate = DateTime.Now;
                fac.AddedBy = SessionWrapper.User.UserId;
                fac.ModifyBy = SessionWrapper.User.UserId;
                fac.ModifyDate = DateTime.Now;
                fac.IsActive = true;
                string FilePath = ConfigurationWrapper.Pictures;
                if (fl.Image != null && fl.Image.ContentLength > 0)
                {
                    if (!Directory.Exists(Server.MapPath(FilePath)))
                        Directory.CreateDirectory(Server.MapPath(FilePath));
                    if (!string.IsNullOrEmpty(fl.Picture))
                        System.IO.File.Delete(Server.MapPath(FilePath + "/" + fl.Picture));
                    fac.Picture = Guid.NewGuid().ToString() + fl.Image.FileName.Substring(fl.Image.FileName.LastIndexOf('.')).ToLower();
                    string _filename = FilePath + "/" + fl.Picture;
                    fl.Image.SaveAs(Server.MapPath(_filename));
                }
                result = _allfaculty.FacultyRegistration(fac);
                if (result > -1)
                {
                    ViewBag.Success = Messages.SubmitFaculty;
                }
                else
                {
                    ModelState.AddModelError("", Messages.FacultyExists);
                }
            }
            else
            {
                fl = new FacultyViewModel();
            }
            return View(fl);
        }

        [Authenticate]
        public ActionResult DeleteFaculty(int facultyId)
        {
            try
            {
                var fac = _allfaculty.GetFacultyByFacultyId(facultyId);
                fac.IsDeleted = true;
                fac.ActionId = 1;
                int result = _allfaculty.FacultyRegistration(fac);
                if (result > -1)
                {
                    ViewBag.Success = Messages.SubmitFaculty;
                }
                else
                {
                    ModelState.AddModelError("", Messages.FacultyExists);
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;
            }
            return RedirectToAction("GetFaculityList");
        }
    }
}
