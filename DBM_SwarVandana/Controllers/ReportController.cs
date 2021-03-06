﻿using Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewModel;
using Repositories;
using DBM_SwarVandana.Resources;
using System.Data;

namespace DBM_SwarVandana.Controllers
{
    public class ReportController : Controller
    {
        //
        // GET: /Report/

        ReportRepository _reports = new ReportRepository();
        DisciplineRepository _alldisciplane = new DisciplineRepository();

        [Authenticate]
        public ActionResult StudentAttendence(DateTime? startdate, DateTime? enddate, int DisciplineId = 0)
        {
            ReportViewModel rm = new ReportViewModel();
            ViewBag.disciplane = _alldisciplane.GetAllDisciplines(SessionWrapper.User.CentreId);
            if (startdate == null || enddate == null)
            {
                rm.FromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                rm.ToDate = DateTime.Today;
                rm.ReportDataset = new DataSet();
            }
            else
            {
                rm.FromDate = startdate.Value;
                rm.ToDate = enddate.Value;
                rm.ReportDataset = _reports.GetStudentsAttendenceEnrollmentId(startdate.Value, enddate.Value, DisciplineId);
            }
            return View(rm);
        }

        //[Authenticate]
        //public ActionResult StudentAttendenceAjaxView(string enrollmentId, string studentId)
        //{
        //    ReportViewModel rm = new ReportViewModel();
        //    if (!string.IsNullOrEmpty(enrollmentId))
        //    {
        //        long EnrollmentId = Convert.ToInt64(enrollmentId);
        //        if (!string.IsNullOrEmpty(studentId))
        //        {
        //            long StudentId = Convert.ToInt64(studentId);
        //            var d = _reports.GetStudentsAttendenceEnrollmentId(EnrollmentId, StudentId);
        //            rm.ReportDataset = d;
        //            return View(rm);
        //        }
        //    }
        //    return View(rm);
        //}
        
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
            decimal TotalAmount = 0;
            DateTime fDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime tDate = fDate.AddMonths(1).AddDays(-1);
            if (!string.IsNullOrEmpty(fromdate))
            {
                fDate = Convert.ToDateTime(fromdate);
            }
            else
            {
                datefilter = 0;
                fromdate = fDate.ToString("dd MMM yyyy");
                fDate = Convert.ToDateTime(fromdate);
            }
            if (!string.IsNullOrEmpty(todate))
            {
                tDate = Convert.ToDateTime(todate);
            }
            else
            {
                todate = tDate.ToString("dd MMM yyyy");
                tDate = Convert.ToDateTime(todate);
            }
            var d = _reports.GetStudentEnrollmentList(fDate, tDate, datefilter, out TotalPages,out TotalAmount, page);
            rm.ReportDataset = d;
            ViewBag.TotalPages = TotalPages;
            ViewBag.TotalAmount = TotalAmount;
            return View(rm);
        }

        [Authenticate]
        public ActionResult PaymentDetailList(int month = 0)
        {
            ReportViewModel rm = new ReportViewModel();
            var d = _reports.GetUpCommingPaymentDetail(month);
            rm.ReportDataset = d;
            return View(rm);
        }
        
    }
}
