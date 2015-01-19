using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DBM_SwarVandana.Resources;

namespace ViewModel
{
    public class ExpensesViewModel : Expenses
    {
        public ExpensesViewModel() { }
        public ExpensesViewModel(Expenses e)
        {
            this.ActionId = e.ActionId;
            this.ExpenseID = e.ExpenseID;
            this.ExpenseAmount = e.ExpenseAmount;
            this.ExpenseFor = e.ExpenseFor;
            this.Description = e.Description;
            this.DateOfExpense = e.DateOfExpense;
            this.CentreID = e.CentreID;
            this.CreatedOn = e.CreatedOn;
            this.CreatedBy = e.CreatedBy;
            this.ModifiedOn = e.ModifiedOn;
            this.ModifiedBy = e.ModifiedBy;
            this.IsActive = e.IsActive;
            this.IsDeleted = e.IsDeleted;
            this.Month = e.Month;
            this.FinancialYear = e.FinancialYear;

        }

        public override int ActionId { get; set; }
        public override int ExpenseID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ExpenseAmountRequired")]
        public override decimal ExpenseAmount { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "ExpenseForRequired")]
        public override int ExpenseFor { get; set; }
        public override string Description { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "DateOfExpenseRequired")]
        public override DateTime? DateOfExpense { get; set; }
        public override int CentreID { get; set; }
        public override DateTime? CreatedOn { get; set; }
        public override int CreatedBy { get; set; }
        public override DateTime? ModifiedOn { get; set; }
        public override int ModifiedBy { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsDeleted { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "MonthRequired")]
        public override int Month { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FinancialYearRequired")]
        public override string FinancialYear { get; set; }
    }
}