using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ViewModel
{
    public class ProfitLossViewModel
    {

        public virtual decimal BudgetAssign { get; set; }
        public virtual decimal TotalExpense { get; set; }
        public virtual decimal FinalResult { get; set; }

        public List<string> financialYears { get; set; }


    }
}