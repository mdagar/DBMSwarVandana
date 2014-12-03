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
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetFaculityList()
        {
            List<Faculties> fac = _allfaculty.GetFacultyByCentreId(SessionWrapper.User.CentreId);
            return View(fac);
        }

        public ActionResult FacultyRegistration(int? facultyId)
        {
            FacultyViewModel f = new FacultyViewModel();
            if (facultyId.HasValue)
                f = new FacultyViewModel(_allfaculty.GetFacultyByFacultyId(facultyId.Value));
            return View(f);
        }

        [HttpPost]
        public ActionResult FacultyRegistration(FacultyViewModel fl)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                fl.ActionId = 0;
                fl.CentreId = SessionWrapper.User.CentreId;
                fl.AddDate = DateTime.Now;
                fl.AddedBy = SessionWrapper.User.UserId;
                fl.ModifyBy = SessionWrapper.User.UserId;
                fl.ModifyDate = DateTime.Now;
                fl.IsActive = true;
                string FilePath = ConfigurationWrapper.Pictures;
                if (fl.Image != null && fl.Image.ContentLength > 0)
                {
                    if (!Directory.Exists(Server.MapPath(FilePath)))
                        Directory.CreateDirectory(Server.MapPath(FilePath));
                    if (!string.IsNullOrEmpty(fl.Picture))
                        System.IO.File.Delete(Server.MapPath(FilePath + "/" + fl.Picture));
                    fl.Picture = Guid.NewGuid().ToString() + fl.Image.FileName.Substring(fl.Image.FileName.LastIndexOf('.')).ToLower();
                    string _filename = FilePath + "/" + fl.Picture;
                    fl.Image.SaveAs(Server.MapPath(_filename));
                }
                result = _allfaculty.FacultyRegistration(fl);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitEnquiry;
                }
                else
                {
                    ViewBag.Error = Messages.ExquiryExists;
                }
            }
            else
            {
                fl = new FacultyViewModel();
            }
            return View(fl);
        }

    }
}
