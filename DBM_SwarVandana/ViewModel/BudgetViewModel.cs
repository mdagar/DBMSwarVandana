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
    public class BudgetViewModel : Budgets
    {
        public BudgetViewModel() { }
        public BudgetViewModel(Budgets b)
        {
            this.ActionId = b.ActionId;
            this.BudgetID = b.BudgetID;
            this.BudgetAmount = b.BudgetAmount;
            this.Description = b.Description;
            this.FinancialYear = b.FinancialYear;
            this.CentreID = b.CentreID;
            this.CreatedBy = b.CreatedBy;
            this.CreatedOn = b.CreatedOn;
            this.ModifiedBy = b.ModifiedBy;
            this.ModifiedOn = b.ModifiedOn;
            this.IsActive = b.IsActive;
            this.IsDeleted = b.IsDeleted;
        }

        public override int ActionId { get; set; }
        public override int BudgetID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "BudgetAmountRequired")]
        public override decimal BudgetAmount { get; set; }
        [Required(ErrorMessageResourceType = typeof(Messages), ErrorMessageResourceName = "FinancialYearRequired")]
        public override string FinancialYear { get; set; }
        public override string Description { get; set; }
        public override int CentreID { get; set; }
        public override int CreatedBy { get; set; }
        public override DateTime? CreatedOn { get; set; }
        public override int ModifiedBy { get; set; }
        public override DateTime? ModifiedOn { get; set; }
        public override bool IsActive { get; set; }
        public override bool IsDeleted { get; set; }
    }
}