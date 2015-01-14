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
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        ReportRepository _reports = new ReportRepository();

        [Authenticate]
        public ActionResult StudentAttendence()
        {
            ReportViewModel rm = new ReportViewModel();
            return View(rm);
        }

        [Authenticate]
        public ActionResult StudentAttendenceAjaxView(string enrollmentId, string studentId)
        {
            ReportViewModel rm = new ReportViewModel();
            if (!string.IsNullOrEmpty(enrollmentId))
            {
                long EnrollmentId = Convert.ToInt64(enrollmentId);
                if (!string.IsNullOrEmpty(studentId))
                {
                    long StudentId = Convert.ToInt64(studentId);
                    var d = _reports.GetStudentsAttendenceEnrollmentId(EnrollmentId, StudentId);
                    rm.ReportDataset = d;
                    return View(rm);
                }
            }
            return View(rm);
        }


        [Authenticate]
        public ActionResult StudentPaymentDetails()
        {
            ReportViewModel rm = new ReportViewModel();
            return View(rm);
        }

        [Authenticate]
        public ActionResult StudentPaymentDetailsAjaxView(string enrollmentId, string studentId)
        {
            ReportViewModel rm = new ReportViewModel();
            if (!string.IsNullOrEmpty(enrollmentId))
            {
                long EnrollmentId = Convert.ToInt64(enrollmentId);
                if (!string.IsNullOrEmpty(studentId))
                {
                    long StudentId = Convert.ToInt64(studentId);
                    var d = _reports.GetStudentsPaymentDetails(EnrollmentId, StudentId);
                    rm.ReportDatasetPayment = d;
                    return View(rm);
                }
            }
            return View(rm);
        }

        [Authenticate]
        public ActionResult ReportsOnEnquiry()
        {
            ReportViewModel rm = new ReportViewModel();
            return View(rm);
        }

        [Authenticate]
        public ActionResult TelephonicToPhysicalEnquiryAjaxView()
        {
            ReportViewModel rm = new ReportViewModel();
            var d = _reports.GetTe_to_PE_Details();
            rm.ReportDataset = d;
            return View(rm);
        }

        [Authenticate]
        public ActionResult PhysicalEnquiryToEnrollmentAjaxView()
        {
            ReportViewModel rm = new ReportViewModel();
            var d = _reports.GetPE_to_Enrollment_Details();
            rm.ReportDataset = d;
            return View(rm);
        }

        [Authenticate]
        public ActionResult DemoToEnrollmentAjaxView()
        {
            ReportViewModel rm = new ReportViewModel();
            var d = _reports.GetDemo_to_Enrollment_Details();
            rm.ReportDataset = d;
            return View(rm);
        }
    }
}
