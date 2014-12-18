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
    public class EnquiriesController : Controller
    {
        //
        // GET: /Enquiries/
        EnquiryRepository _allenquiry = new EnquiryRepository();
        DisciplineRepository _allDiscipline = new DisciplineRepository();
        SourceRepository _allSources = new SourceRepository();
        UsersRepository _allUsers = new UsersRepository();
        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult TelephonicEnquiryList(string search = "", int page = 1)
        {
            int TotalPages = 0;
            List<Enquiries> enq = _allenquiry.ListEnquuiry(SessionWrapper.User.CentreId, (int)EnquiryType.TE, out TotalPages, page, search);
            ViewBag.TotalPages = TotalPages;
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            enq.Update(x => x.SourceName = sources.Where(s => s.SourceId == x.SourceId).FirstOrDefault().Source);
            enq.Update(x => x.DisciplaneName = Discipline.Where(s => s.DisciplineId == x.Discipline).FirstOrDefault().Discipline);
            return View(enq);
        }

        [Authenticate]
        public ActionResult TelephonicEnquiry(int? enquiryId)
        {
            EnquiryViewModel en = new EnquiryViewModel();
            if (enquiryId.HasValue)
                en = new EnquiryViewModel(_allenquiry.FindByEnquirieID(enquiryId.Value));
            return View(en);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult TelephonicEnquiry(EnquiryViewModel en)
        {
            var result = 0;
            EnquiryViewModel evm = new EnquiryViewModel();
            if (ModelState.IsValid)
            {
                en.ActionId = 0;
                en.CentreId = SessionWrapper.User.CentreId;
                en.EnquiryTypeId = Convert.ToInt32(EnquiryType.TE);
                en.IsEnquiryClosed = false;
                en.AddDate = DateTime.Now;
                en.AddedBy = SessionWrapper.User.UserId;
                en.ModifyBy = SessionWrapper.User.UserId;
                en.ModifyDate = DateTime.Now;
                if (en.EnquiryId != 0)
                {
                    evm = new EnquiryViewModel(_allenquiry.FindByEnquirieID(en.EnquiryId));
                    evm.ActionId = 1;
                    evm.StatusId = en.StatusId;
                    evm.ModifyDate = DateTime.Now;
                    evm.ModifyBy = SessionWrapper.User.UserId;
                    result = _allenquiry.CreateEnquiry(evm);
                }
                else
                {
                    result = _allenquiry.CreateEnquiry(en);
                }

                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitEnquiry;
                }
                else
                {
                    ModelState.AddModelError("", Messages.ExquiryExists);
                }
            }
            else
            {
                en = new EnquiryViewModel();
            }
            return View(en);
        }

        [Authenticate]
        public ActionResult PhysicalEnquiryList(string search = "", int page = 1)
        {
            int TotalPages = 0;
            List<Enquiries> enq = _allenquiry.ListEnquuiry(SessionWrapper.User.CentreId, (int)EnquiryType.PE, out TotalPages, page, search);
            ViewBag.TotalPages = TotalPages;
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            var Users = _allUsers.AllUsers(SessionWrapper.User.CentreId);
            enq.Update(x => x.SourceName = sources.Where(s => s.SourceId == x.SourceId).FirstOrDefault().Source);
            enq.Update(x => x.DisciplaneName = Discipline.Where(s => s.DisciplineId == x.Discipline).FirstOrDefault().Discipline);
            foreach (var v in enq)
            {
                var name = Users.Where(s => s.UserId == v.AttendedBy).FirstOrDefault();
                v.AttendedByUser = name == null ? "" : name.FirstName + " " + name.LastName;
            }
            return View(enq);
        }

        [Authenticate]
        public ActionResult PhysicalEnquiry(int? enquiryId)
        {
            EnquiryViewModel en = new EnquiryViewModel();
            if (enquiryId.HasValue)
                en = new EnquiryViewModel(_allenquiry.FindByEnquirieID(enquiryId.Value));
            return View(en);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult PhysicalEnquiry(EnquiryViewModel en)
        {
            var result = 0;
            EnquiryViewModel evm = new EnquiryViewModel();
            if (ModelState.IsValid)
            {
                en.ActionId = 0;
                en.CentreId = SessionWrapper.User.CentreId;
                en.EnquiryTypeId = Convert.ToInt32(EnquiryType.TE);
                en.IsEnquiryClosed = false;
                en.AddDate = DateTime.Now;
                en.AddedBy = SessionWrapper.User.UserId;
                en.ModifyBy = SessionWrapper.User.UserId;
                en.ModifyDate = DateTime.Now;

                en.IsDeleted = false;
                if (en.EnquiryId != 0)
                {
                    evm = new EnquiryViewModel(_allenquiry.FindByEnquirieID(en.EnquiryId));
                    evm.ActionId = 1;
                    evm.StatusId = en.StatusId;
                    evm.ModifyDate = DateTime.Now;
                    evm.ModifyBy = SessionWrapper.User.UserId;
                    result = _allenquiry.CreateEnquiry(evm);
                }
                else
                    result = _allenquiry.CreateEnquiry(en);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitEnquiry;
                }
                else
                {
                    ModelState.AddModelError("", Messages.ExquiryExists);
                }
            }
            else
            {
                en = new EnquiryViewModel();
            }
            return View(en);
        }

        [Authenticate]
        public ActionResult DeleteEnquiry(int enquiryID, int type)
        {
            try
            {
                var enq = _allenquiry.FindByEnquirieID(enquiryID);
                enq.IsDeleted = true;
                enq.ActionId = 1;
                var result = _allenquiry.CreateEnquiry(enq);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            if (type == 1)
                return RedirectToAction("PhysicalEnquiryList");
            else
                return RedirectToAction("TelephonicEnquiryList");
        }

        [Authenticate]
        public ActionResult ExportTelephonicEnq()
        {
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            var rec = (_allenquiry.GetAllEnquery(SessionWrapper.User.CentreId, (int)EnquiryType.TE).Select(s => new
            {
                Name = s.Name,
                Discipline = Discipline.Where(x => x.DisciplineId == s.Discipline).FirstOrDefault().Discipline,
                source = sources.Where(x => x.SourceId == s.SourceId).FirstOrDefault().Source,
                Contact = s.ContactNumber,
                Date = s.DateOfEnquiry.Value.ToString("dd MMM yyyy"),
                Address = s.Address,
                Status = (((Status)Enum.Parse(typeof(Status), s.StatusId.ToString())).Desciption())
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Telephonic Enquiry");
            return File(data.ToArray(), "application/vnd.ms-excel", "TelephonicEnquiry");
        }

        [Authenticate]
        public ActionResult ExportPhysicalEnq()
        {
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            var Users = _allUsers.AllUsers(SessionWrapper.User.CentreId);
            var rec = (_allenquiry.GetAllEnquery(SessionWrapper.User.CentreId, (int)EnquiryType.PE).Select(s => new
            {
                Name = s.Name,
                Discipline = Discipline.Where(x => x.DisciplineId == s.Discipline).FirstOrDefault().Discipline,
                source = sources.Where(x => x.SourceId == s.SourceId).FirstOrDefault().Source,
                DateOfEnquiry = s.DateOfEnquiry.Value.ToString("dd MMM yyyy"),
                AttendedBy = Users.Where(x => x.UserId == s.AttendedBy).FirstOrDefault().FirstName,
                Contact = s.ContactNumber,
                ProbableStudent = ((EnquiryFor)Enum.Parse(typeof(EnquiryFor), s.ProbableStudentFor.ToString())).Desciption(),
                Gender = ((Gender)Enum.Parse(typeof(Gender), s.Gender.ToString())).Desciption(),
                Age = s.Age,
                Classes = s.NoOfClasses,
                Package = s.Package,
                Demo = s.Demo,
                FaculityRemarks = s.RemarksByFaculty,
                FinalRemarks = s.FinalComments,
                Status = ((Status)Enum.Parse(typeof(Status), s.StatusId.ToString())).Desciption()
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Physical Enquiry");
            return File(data.ToArray(), "application/vnd.ms-excel", "PhysicalEnquiry");
        }
    }
}
