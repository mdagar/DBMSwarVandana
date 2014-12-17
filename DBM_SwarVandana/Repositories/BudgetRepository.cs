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

        public List<Budgets> GetBudgetForAll(string Search = "")
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetBudgetForAll, Search);
            if (d != null)
                return d.Tables[0].TableToList<Budgets>();
            else
                return new List<Budgets>();
        }

        public int AddBudget(Budgets b)
        {
            if (b.BudgetID > 0)
                b.ActionId = 1;
            object[] objParam = { b.ActionId, b.BudgetID, b.BudgetAmount, b.Description, b.FinancialYear, b.CentreID, b.CreatedBy, b.CreatedOn, b.ModifiedBy, b.ModifiedOn, b.IsActive, b.IsDeleted };
            var res = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertBudgetMaster, objParam);
            return Convert.ToInt32(res);
        }

        public List<Expenses> GetAllExpenses(int centerid, string Search = "")
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetAllExpenses, centerid, Search);
            if (d != null)
                return d.Tables[0].TableToList<Expenses>();
            else
                return new List<Expenses>();
        }

        public Expenses GetExpenseById(int ExpenseID)
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExpenseById, ExpenseID);
            if (d == null)
                return new Expenses();
            else
                return d.Tables[0].TableToList<Expenses>().FirstOrDefault();
        }

        public int AddExpenses(Expenses e)
        {
            if (e.ExpenseID > 0)
                e.ActionId = 1;
            object[] objParam = { e.ActionId, e.ExpenseID, e.ExpenseAmount, e.ExpenseFor, e.Description, e.DateOfExpense, 
                                    e.CentreID, e.CreatedOn,e.CreatedBy, e.ModifiedOn,e.ModifiedBy,  e.IsActive, e.IsDeleted };
            var res = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertExpenses, objParam);
            return Convert.ToInt32(res);
        }
    }
}