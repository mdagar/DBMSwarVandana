using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class ProfitLossViewModel
    {

        public virtual decimal BudgetAssign { get; set; }
        public virtual decimal Revenue { get; set; }
        public virtual decimal Salary { get; set; }
        public virtual decimal Expenseses { get; set; }
        public virtual decimal FinalAmount { get; set; }
        public virtual string SelectedFinancialyear { get; set; }
        public List<string> financialYears { get; set; }


    }
}