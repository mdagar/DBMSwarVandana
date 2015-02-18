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
        public ActionResult TelephonicToPhysicalEnquiryAjaxView(string fromdate,string todate)
        {
            ReportViewModel rm = new ReportViewModel();
            DateTime fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime tDate = fDate.AddMonths(1).AddDays(-1);
            if (!string.IsNullOrEmpty(fromdate))
            {
                fDate = Convert.ToDateTime(fromdate);
            }
            if (!string.IsNullOrEmpty(todate))
            {
                tDate = Convert.ToDateTime(todate);
            }
            var d = _reports.GetTe_to_PE_Details(fDate, tDate);
            rm.ReportDataset = d;
            return View(rm);
        }

        [Authenticate]
        public ActionResult PhysicalEnquiryToEnrollmentAjaxView(string fromdate, string todate)
        {
            ReportViewModel rm = new ReportViewModel();
            DateTime fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime tDate = fDate.AddMonths(1).AddDays(-1);
            if (!string.IsNullOrEmpty(fromdate))
            {
                fDate = Convert.ToDateTime(fromdate);
            }
            if (!string.IsNullOrEmpty(todate))
            {
                tDate = Convert.ToDateTime(todate);
            }
            var d = _reports.GetPE_to_Enrollment_Details(fDate, tDate);
            rm.ReportDataset = d;
            return View(rm);
        }

        [Authenticate]
        public ActionResult DemoToEnrollmentAjaxView(string fromdate, string todate)
        {
            ReportViewModel rm = new ReportViewModel();
            DateTime fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime tDate = fDate.AddMonths(1).AddDays(-1);
            if (!string.IsNullOrEmpty(fromdate))
            {
                fDate = Convert.ToDateTime(fromdate);
            }
            if (!string.IsNullOrEmpty(todate))
            {
                tDate = Convert.ToDateTime(todate);
            }
            var d = _reports.GetDemo_to_Enrollment_Details(fDate, tDate);
            rm.ReportDataset = d;
            return View(rm);
        }

        [Authenticate]
        public ActionResult EnrollmentStudentList(string fromdate = "", string todate = "", int page = 1)
        {
            ReportViewModel rm = new ReportViewModel();
            int TotalPages = 0, datefilter = 1; ;
            DateTime fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime tDate = fDate.AddMonths(1).AddDays(-1);
            if (!string.IsNullOrEmpty(fromdate))
            {
                fDate = Convert.ToDateTime(fromdate);
            }
            else
                datefilter = 0;  
            if (!string.IsNullOrEmpty(todate))
            {
                tDate = Convert.ToDateTime(todate);
            }
            var d = _reports.GetStudentEnrollmentList(fDate, tDate, datefilter, out TotalPages, page);
            rm.ReportDataset = d;
            ViewBag.TotalPages = TotalPages;
            return View(rm);
        }

        [Authenticate]
        public ActionResult PaymentDetailList()
        {
            ReportViewModel rm = new ReportViewModel();
            var d = _reports.GetUpCommingPaymentDetail();
            rm.ReportDataset = d;
            return View(rm);
        }
    }
}
