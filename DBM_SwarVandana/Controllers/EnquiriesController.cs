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

        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult TelephonicEnquiryList(string search = "")
        {
            List<Enquiries> enq = _allenquiry.ListEnquuiry(SessionWrapper.User.CentreId, (int)EnquiryType.TE, search);
            return View(enq);
        }

        [Authenticate]
        public ActionResult TelephonicEnquiry()
        {
            EnquiryViewModel en = new EnquiryViewModel();
            return View(en);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult TelephonicEnquiry(EnquiryViewModel en)
        {
            var result = 0;
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
                en.IsActive = true;
                result = _allenquiry.CreateEnquiry(en);
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
                en = new EnquiryViewModel();
            }
            return View(en);
        }

        [Authenticate]
        public ActionResult PhysicalEnquiryList()
        {
            List<Enquiries> enq = _allenquiry.ListEnquuiry(0, 2);
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
            if (ModelState.IsValid)
            {
                en.ActionId = 0;
                en.CentreId = SessionWrapper.User.CentreId;
                en.EnquiryTypeId = Convert.ToInt32(EnquiryType.PE);

                en.IsEnquiryClosed = false;
                en.AddDate = DateTime.Now;
                en.AddedBy = SessionWrapper.User.UserId;
                en.ModifyBy = SessionWrapper.User.UserId;
                en.ModifyDate = DateTime.Now;
                en.IsActive = true;
                result = _allenquiry.CreateEnquiry(en);
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
                en = new EnquiryViewModel();
            }
            return View(en);
        }

        [Authenticate]
        public ActionResult ExportTelephonicEnq()
        {
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            var rec = (_allenquiry.ListEnquuiry(SessionWrapper.User.CentreId, (int)EnquiryType.TE).Select(s => new
            {
                Name = s.Name,
                Discipline = Discipline.Where(x => x.DisciplineId == s.Discipline).FirstOrDefault().Discipline,
                source = sources.Where(x => x.SourceId == s.SourceId).FirstOrDefault().Source,
                Contact = s.ContactNumber,
                AttendedBy = s.AttendedBy,
                Status =  s.StateId
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Telephonic Enquiry");
            return File(data.ToArray(), "application/vnd.ms-excel", "TelephonicEnquiry.xls");
        }

        [Authenticate]
        public ActionResult ExportPhysicalEnq()
        {
            var Discipline = _allDiscipline.GetAllDisciplines();
            var sources = _allSources.GetAllSources();
            var rec = (_allenquiry.ListEnquuiry(SessionWrapper.User.CentreId, (int)EnquiryType.PE).Select(s => new
            {
                Name = s.Name,
                Discipline = Discipline.Where(x => x.DisciplineId == s.Discipline).FirstOrDefault().Discipline,
                source = sources.Where(x => x.SourceId == s.SourceId).FirstOrDefault().Source,
                Contact = s.ContactNumber,
                DateOfEnquiry = s.DateOfEnquiry,
                AttendedBy = s.AttendedBy,
                Demo = s.Demo,
                ProbableStudent = s.ProbableStudentFor,
                Gender = s.Gender,
                Age = s.Age,
                Remarks = s.RemarksByFaculty,
                Status = s.StateId
            }).ToArray()).AsDataTable();

            var data = ExcelHelper.Export(rec, "Physical Enquiry");
            return File(data.ToArray(), "application/vnd.ms-excel", "PhysicalEnquiry.xls");
        }
    }
}
