using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code;
using Models;
using Repositories;
using ViewModel;
using System.Data;

namespace DBM_SwarVandana.Controllers
{
    public class TargetManagementController : Controller
    {
        //
        // GET: /TargetManagement/

        AllTargetManagement _allAarget = new AllTargetManagement();

        private List<string> GetPreviousFinancialYears()
        {
            List<string> Years = new List<string>();
            DateTime startYear = DateTime.Now;
            while (startYear.Year >= DateTime.Now.AddYears(-5).Year)
            {
                if (startYear.Month >= 4)
                    Years.Add(startYear.Year + " - " + startYear.AddYears(1).Year);
                else
                    Years.Add(startYear.AddYears(-1).Year + " - " + startYear.Year);
                startYear = startYear.AddYears(-1);
            }
            return Years;
        }

        [Authenticate]
        public ActionResult Index(int month = 0, string SelectedFinancialyear = "")
        {
            if (month == 0)
                month = DateTime.Now.Month;
            var financialYears = GetPreviousFinancialYears();
            if (string.IsNullOrEmpty(SelectedFinancialyear))
                SelectedFinancialyear = financialYears.FirstOrDefault();

            ViewBag.FinancialYears = financialYears;
            ViewBag.Month = month;
            ViewBag.financialYer = SelectedFinancialyear;
            TargetManagementViewModel tr = new TargetManagementViewModel();
            tr.ds = _allAarget.GetTargetData(SessionWrapper.User.CentreId, month, SelectedFinancialyear);
            return View(tr);

        }

        [Authenticate]
        public ActionResult AddToAgtget(long EnqId, int TargetType)
        {
            ViewBag.EnqID = EnqId;
            ViewBag.TargetType = TargetType;
            return View();
        }

        public string CurrentFinancialYear()
        {
            DateTime date = DateTime.Now;
            string year = "";
            if (date.Month >= 4)
                year = (date.Year + " - " + date.AddYears(1).Year);
            else
                year = date.AddYears(-1).Year + " - " + date.Year;
            return year;
        }

        [Authenticate]
        public ActionResult AddTarget(int Type, string Amount, long EnqId)
        {
            TargetManagement t = new TargetManagement();
            t.Type = Type;
            t.Month = DateTime.Now.Month;
            t.FinancialYear = CurrentFinancialYear();
            t.Amount = Convert.ToDecimal(Amount);
            t.CenterId = SessionWrapper.User.CentreId;
            t.EnqId = EnqId;
            t.CreatedBy = SessionWrapper.User.UserId;
            t.CreatedDate = DateTime.Now;
            t.ModifyBy = SessionWrapper.User.UserId;
            t.ModifyDate = DateTime.Now;
            var r = _allAarget.AddTarget(t);
            string msg = "";
            if (r == -1)
                msg = "Target already Added";
            else
                msg = "Target Added successfully";
            return Json(msg, JsonRequestBehavior.AllowGet);
        }

        [Authenticate]
        public ActionResult EnqueryDetai(int Ttype, int month, string financialYear)
        {
            DataSet d = new DataSet();
            d = _allAarget.GetTargetDetais(Ttype, month, financialYear, SessionWrapper.User.CentreId);
            TargetManagementViewModel tr = new TargetManagementViewModel();
            tr.ds = d;
            ViewBag.TargetType = Ttype;
            return View(tr);

        }

    }
}
