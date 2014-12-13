using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConnection;
using DBM_SwarVandana.Resources;
using Models;
using System.Reflection;
using SqlRepositories;
using ListConversion;
using Code;
using System.Data;

namespace Repositories
{
    public class BudgetRepository
    {
        DBConnections db = new DBConnections();
        public List<ExpensesFor> GetExpenseForAll()
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExpensesForAll);
            return ConvertList.TableToList<ExpensesFor>(d.Tables[0]);
        }
    }
}