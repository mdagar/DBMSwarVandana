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

        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        //[Authenticate]
        public ActionResult TelephonicEnquiryList()
        {
            List<Enquiries> enq = _allenquiry.ListEnquuiry(0, 1);
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

        //[Authenticate]
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

    }
}
