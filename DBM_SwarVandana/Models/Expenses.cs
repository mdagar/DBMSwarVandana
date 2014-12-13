using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class Expenses
    {
        public virtual int ActionId { get; set; }
        public virtual int ExpenseID { get; set; }
        public virtual double ExpenseAmount { get; set; }
        public virtual int ExpenseFor { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime? DateOfExpense { get; set; }
        public virtual int CentreID { get; set; }
        public virtual DateTime? CreatedOn { get; set; }
        public virtual int CreatedBy { get; set; }
        public virtual DateTime? ModifiedOn { get; set; }
        public virtual int ModifiedBy { get; set; }
        public virtual bool IsActive { get; set; }
        public virtual bool IsDeleted { get; set; }

        public Expenses()
        {
            this.ActionId = 0;
            this.ExpenseID = 0;
            this.ExpenseAmount = 0;
            this.ExpenseFor = 0;
            this.Description = string.Empty;
            this.DateOfExpense = null;
            this.CentreID = 0;
            this.CreatedOn = null;
            this.CreatedBy = 0;
            this.ModifiedOn = null;
            this.ModifiedBy = 0;
            this.IsActive = true;
            this.IsDeleted = false;

        }
    }
}