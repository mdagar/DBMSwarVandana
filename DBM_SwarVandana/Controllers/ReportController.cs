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
    }
}
