using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Budgets
    {
        public virtual int ActionId { get; set; }
        public virtual int BudgetID { get; set; }
        public virtual decimal BudgetAmount { get; set; }
        public virtual string Description { get; set; }
        public virtual string FinancialYear { get; set; }
        public virtual int CentreID { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual DateTime? CreatedOn { get; set; }
        public virtual int ModifiedBy { get; set; }
        public virtual DateTime? ModifiedOn { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public Budgets()
        {
            this.ActionId = 0;
            this.BudgetID = 0;
            this.BudgetAmount = 0;
            this.Description = string.Empty;
            this.FinancialYear = string.Empty;
            this.CentreID = 0;
            this.CreatedBy = 0;
            this.CreatedOn = null;
            this.ModifiedBy = 0;
            this.ModifiedOn = null;
            this.IsActive = true;
            this.IsDeleted = false;

        }

    }
}