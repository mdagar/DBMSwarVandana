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
using System.Xml;
using System.Data;

namespace DBM_SwarVandana.Controllers
{
    public class BudgetController : Controller
    {
        //
        // GET: /Budget/

        BudgetRepository _allbudget = new BudgetRepository();

        #region BudgetManagement

        [Authenticate]
        public ActionResult Index()
        {
            return View();
        }

        [Authenticate]
        public ActionResult BudgetList(string search = "", int page = 1)
        {
            int TotalPages = 0;
            search = search.Trim();
            ViewBag.Search = search;
            List<Budgets> bgt = _allbudget.GetBudgetForAll(out TotalPages, page, search);
            ViewBag.TotalPages = TotalPages;
            string currentYear = CurrentFinancialYear();
            var expfor = _allbudget.GetExpenseForAll();
            bgt.Update(x => x.ExpenseForName = expfor.Where(s => s.ExpenseForId == x.ExpenseFor).FirstOrDefault().ExpenseFor);
            var month = Enum.GetValues(typeof(Months)).Cast<Months>().ToList();
            foreach (var v in bgt)
                v.CurrentFinancialYear = currentYear;
            return View(bgt);
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

        private void GetYears()
        {
            List<string> Years = new List<string>();
            // this code is on temp bases need to remove soon.
            //DateTime startYear = DateTime.Now.AddYears(-1);
            DateTime startYear = DateTime.Now;
            while (startYear.Year <= DateTime.Now.AddYears(1).Year)
            {
                if (startYear.Month >= 4)
                    Years.Add(startYear.Year + " - " + startYear.AddYears(1).Year);
                else
                    Years.Add(startYear.AddYears(-1).Year + " - " + startYear.Year);
                startYear = startYear.AddYears(1);
            }
            ViewBag.Years = Years;
        }

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
        public ActionResult AssignBudget(int? BudgetID)
        {
            BudgetViewModel b;
            if (BudgetID.HasValue)
            {
                GetYears();
                b = new BudgetViewModel(_allbudget.FindByBudgetId(BudgetID.Value));
            }
            else
            {
                b = new BudgetViewModel();
                GetYears();
            }
            return View(b);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AssignBudget(BudgetViewModel bgt)
        {
            var result = 0;
            //if (bgt.BudgetAmount < 100)
            //    ModelState.AddModelError(string.Empty, "Budget amount should not less then 100 rs.");
            if (ModelState.IsValid)
            {
                bgt.ActionId = 0;
                bgt.CentreID = SessionWrapper.User.CentreId;
                bgt.CreatedOn = DateTime.Now;
                bgt.CreatedBy = SessionWrapper.User.UserId;
                bgt.ModifiedBy = SessionWrapper.User.UserId;
                bgt.ModifiedOn = DateTime.Now;
                bgt.IsActive = true;
                bgt.IsDeleted = false;
                result = _allbudget.AddBudget(bgt);
                if (result > 0)
                    ViewBag.Success = Messages.SubmitBudget;
                else
                    ModelState.AddModelError("", Messages.BudgetExists);
            }
            GetYears();
            return View(bgt);
        }

        [Authenticate]
        public ActionResult ExpenseList(int month = 0, string SelectedFinancialyear = "", string Search = "", int page = 1)
        {
            int TotalPages = 0;
            if (month == 0)
                month = DateTime.Now.Month;
            var financialYears = GetPreviousFinancialYears();
            if (string.IsNullOrEmpty(SelectedFinancialyear))
                SelectedFinancialyear = financialYears.FirstOrDefault();

            Search = Search.Trim();
            ViewBag.Search = Search;
            ViewBag.FinancialYears = financialYears;
            List<Expenses> exp = _allbudget.GetAllExpenses(month, SessionWrapper.User.CentreId, out TotalPages, page, Search.Trim(), SelectedFinancialyear);
            var expfor = _allbudget.GetExpenseForAll();
            exp.Update(x => x.ExpenseForName = expfor.Where(s => s.ExpenseForId == x.ExpenseFor).FirstOrDefault().ExpenseFor);
            ViewBag.TotalPages = TotalPages;
            return View(exp);
        }

        [Authenticate]
        public ActionResult AddExpenses(int? ExpenseId)
        {
            ExpensesViewModel e;
            GetYears();
            if (ExpenseId.HasValue)
                e = new ExpensesViewModel(_allbudget.GetExpenseById(ExpenseId.Value));
            else
                e = new ExpensesViewModel();
            return View(e);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AddExpenses(ExpensesViewModel exp)
        {
            var result = 0;
            if (ModelState.IsValid)
            {
                exp.ActionId = 0;
                exp.CentreID = SessionWrapper.User.CentreId;
                exp.CreatedOn = DateTime.Now;
                exp.CreatedBy = SessionWrapper.User.UserId;
                exp.ModifiedBy = SessionWrapper.User.UserId;
                exp.ModifiedOn = DateTime.Now;
                exp.IsActive = true;
                exp.IsDeleted = false;
                result = _allbudget.AddExpenses(exp);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitExpense;
                }
                else
                {
                    if (result == -1)
                        ModelState.AddModelError("", Messages.ExpenseExists);
                    else
                        ModelState.AddModelError("", "Budget Not Assigned for Selected Expense");
                }
            }
            else
            {
                exp = new ExpensesViewModel();
            }
            GetYears();
            return View(exp);
        }

        [Authenticate]
        public ActionResult GetBudgetAmountForMonth(int month, string year, int expensefor)
        {
            DataSet ds = new DataSet();
            if (month != 0)
            {
                if (!string.IsNullOrEmpty(year))
                {
                    ds = _allbudget.GetBudgetAmountForMonth(month, year, expensefor);
                }
            }
            System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in ds.Tables[0].Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            return Json(serializer.Serialize(rows));
        }
        #endregion

        #region Profit Loss Management

        [Authenticate]
        public ActionResult ProfitLoss(string SelectedFinancialyear = "", int month = 0)
        {
            ProfitLossViewModel p = new ProfitLossViewModel();
            string final = "";
            p.financialYears = GetPreviousFinancialYears();
            if (!string.IsNullOrEmpty(SelectedFinancialyear))
                p.SelectedFinancialyear = SelectedFinancialyear;
            else
                p.SelectedFinancialyear = p.financialYears.FirstOrDefault();
            final = p.SelectedFinancialyear;
            p = _allbudget.GetRevenue(SessionWrapper.User.CentreId, p.SelectedFinancialyear, month);

            p.financialYears = GetPreviousFinancialYears();
            p.SelectedFinancialyear = final;
            p.BudgetAssign = _allbudget.ConsolidatedCenterBudget(SessionWrapper.User.CentreId, p.SelectedFinancialyear, month);
            if (p.BudgetAssign == 0)
            {
                p.Salary = 0;
                p.Revenue = 0;
                p.Expenseses = 0;
                p.FinalAmount = 0;
            }
            p.month = month;
            return View(p);
        }

        public ActionResult PaymentBreakUp()
        {

            return View();
        }

        #endregion
    }
}
