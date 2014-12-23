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
        public ActionResult BudgetList(string search = "")
        {
            List<Budgets> bgt = _allbudget.GetBudgetForAll(search);
            string currentYear = CurrentFinancialYear();
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
                year = date.AddYears(-1) + " - " + date.Year;
            return year;

        }

        private void GetYears(List<string> existingYears)
        {
            List<string> Years = new List<string>();
            DateTime startYear = DateTime.Now;
            while (startYear.Year <= DateTime.Now.AddYears(1).Year)
            {
                if (startYear.Month >= 4)
                    Years.Add(startYear.Year + " - " + startYear.AddYears(1).Year);
                else
                    Years.Add(startYear.AddYears(-1) + " - " + startYear.Year);
                startYear = startYear.AddYears(1);
            }
            foreach (var v in existingYears)
                Years.Remove(v);

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
                    Years.Add(startYear.AddYears(-1) + " - " + startYear.Year);
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
                GetYears(new List<string>());
                b = new BudgetViewModel(_allbudget.GetBudgetForAll("").Where(x => x.BudgetID == BudgetID).FirstOrDefault());
            }
            else
            {
                List<Budgets> bgt = _allbudget.GetBudgetForAll("");
                b = new BudgetViewModel();
                var y = new List<string>();
                foreach (var v in bgt)
                    y.Add(v.FinancialYear);
                GetYears(y);

            }
            return View(b);
        }

        [Authenticate]
        [HttpPost]
        public ActionResult AssignBudget(BudgetViewModel bgt)
        {
            var result = 0;
            if (ModelState.IsValid)
            {

                bgt.ActionId = 0;
                bgt.CentreID = SessionWrapper.User.CentreId;
                bgt.CreatedOn = DateTime.Now;
                bgt.CreatedBy = SessionWrapper.User.UserId;
                bgt.ModifiedBy = SessionWrapper.User.UserId;
                bgt.ModifiedOn = DateTime.Now;
                bgt.IsDeleted = false;
                result = _allbudget.AddBudget(bgt);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitBudget;
                    GetYears(new List<string>());
                }
                else
                {
                    ModelState.AddModelError("", Messages.BudgetExists);
                }
            }
            else
            {
                List<Budgets> bgt1 = _allbudget.GetBudgetForAll("");
                var b = new BudgetViewModel();
                var y = new List<string>();
                foreach (var v in bgt1)
                    y.Add(v.FinancialYear);
                GetYears(y);
            }
            return View(bgt);
        }

        [Authenticate]
        public ActionResult ExpenseList(string Search = "", int page = 1)
        {
            int TotalPages = 0;
            List<Expenses> exp = _allbudget.GetAllExpenses(SessionWrapper.User.CentreId, out TotalPages, page, Search);
            var expfor = _allbudget.GetExpenseForAll();
            exp.Update(x => x.ExpenseForName = expfor.Where(s => s.ExpenseForId == x.ExpenseFor).FirstOrDefault().ExpenseFor);
            ViewBag.TotalPages = TotalPages;
            return View(exp);
        }

        [Authenticate]
        public ActionResult AddExpenses(int? ExpenseId)
        {
            ExpensesViewModel e;
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
                exp.IsDeleted = false;
                result = _allbudget.AddExpenses(exp);
                if (result > 0)
                {
                    ViewBag.Success = Messages.SubmitExpense;
                }
                else
                {
                    ModelState.AddModelError("", Messages.ExpenseExists);
                }
            }
            else
            {
                exp = new ExpensesViewModel();
            }
            return View(exp);
        }
        #endregion

        #region Profit Loss Management

        [Authenticate]
        public ActionResult ProfitLoss(string financialyear = "")
        {
            ProfitLossViewModel p = new ProfitLossViewModel();

            string final = "";
            p.financialYears = GetPreviousFinancialYears();
            if (!string.IsNullOrEmpty(financialyear))
                p.SelectedFinancialyear = financialyear;
            else
                p.SelectedFinancialyear = p.financialYears.FirstOrDefault();
            final = p.SelectedFinancialyear;
            p = _allbudget.GetRevenue(SessionWrapper.User.CentreId, p.SelectedFinancialyear);

            p.financialYears = GetPreviousFinancialYears();
            p.SelectedFinancialyear = final;
            var budgetassign = _allbudget.FindByCenterId(SessionWrapper.User.CentreId, p.SelectedFinancialyear);
            p.BudgetAssign = budgetassign == null ? 0 : Convert.ToDecimal(budgetassign.BudgetAmount);

            return View(p);
        }

        #endregion
    }
}
