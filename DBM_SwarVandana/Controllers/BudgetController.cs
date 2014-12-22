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

            return View(bgt);
        }

        private void GetYears()
        {
            List<string> Years = new List<string>();
            DateTime startYear = DateTime.Now;
            while (startYear.Year <= DateTime.Now.AddYears(1).Year)
            {
                Years.Add(startYear.Year + " - " + startYear.AddYears(1).Year);
                startYear = startYear.AddYears(1);
            }
            ViewBag.Years = Years;
        }

        [Authenticate]
        public ActionResult AssignBudget(int? BudgetID)
        {
            BudgetViewModel b;
            if (BudgetID.HasValue)
            {
                GetYears();
                b = new BudgetViewModel(_allbudget.GetBudgetForAll("").Where(x => x.BudgetID == BudgetID).FirstOrDefault());
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
                    GetYears();
                }
                else
                {
                    ModelState.AddModelError("", Messages.BudgetExists);
                }
            }
            else
            {
                bgt = new BudgetViewModel();
                GetYears();
            }
            return View(bgt);
        }

        [Authenticate]
        public ActionResult ExpenseList(string search = "")
        {
            List<Expenses> exp = _allbudget.GetAllExpenses(SessionWrapper.User.CentreId, search);
            var expfor = _allbudget.GetExpenseForAll();
            exp.Update(x => x.ExpenseForName = expfor.Where(s => s.ExpenseForId == x.ExpenseFor).FirstOrDefault().ExpenseFor);
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
            GetYears();
            string final = "";
            p.financialYears = ViewBag.Years;
            if (!string.IsNullOrEmpty(financialyear))
                p.SelectedFinancialyear = financialyear;
            else
                p.SelectedFinancialyear = p.financialYears.FirstOrDefault();

            final = p.SelectedFinancialyear;

            p = _allbudget.GetRevenue(SessionWrapper.User.CentreId, p.SelectedFinancialyear);

            p.financialYears = ViewBag.Years;
            p.SelectedFinancialyear = final;
            var budgetassign = _allbudget.FindByCenterId(SessionWrapper.User.CentreId, p.SelectedFinancialyear);
            p.BudgetAssign = budgetassign == null ? 0 : Convert.ToDecimal(budgetassign.BudgetAmount);

            return View(p);
        }

        #endregion
    }
}
