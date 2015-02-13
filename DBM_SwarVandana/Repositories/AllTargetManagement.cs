﻿using DBConnection;
using ListConversion;
using Models;
using SqlRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repositories
{
    public class AllTargetManagement
    {
        DBConnections db = new DBConnections();

        //public List<ExpensesFor> GetExpenseForAll()
        //{
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExpensesForAll);
        //    return ConvertList.TableToList<ExpensesFor>(d.Tables[0]);
        //}

        

        //public int AddBudget(Budgets b)
        //{
        //    if (b.BudgetID > 0)
        //        b.ActionId = 1;
        //    object[] objParam = { b.ActionId, b.BudgetID, b.ExpenseFor, b.BudgetAmount, b.Month, b.Description, b.FinancialYear, b.CentreID, b.CreatedBy, b.CreatedOn, b.ModifiedBy, b.ModifiedOn, b.IsActive, b.IsDeleted };
        //    var res = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertBudgetMaster, objParam);
        //    return Convert.ToInt32(res);
        //}

        //public Budgets FindByCenterId(int centerId, string financialYear)
        //{
        //    string Query = "SELECT BudgetID,ExpenseFor,BudgetAmount,Month,Description,FinancialYear,CentreID,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,IsActive,IsDeleted FROM [dbo].[BudgetMaster] WHERE centreId =" + centerId + " and FinancialYear ='" + financialYear + "'";
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
        //    if (d != null)
        //        return d.Tables[0].TableToList<Budgets>().FirstOrDefault();
        //    else
        //        return new Budgets();
        //}

        //public Budgets FindByBudgetId(int budgetId)
        //{
        //    string Query = "SELECT BudgetID,ExpenseFor,BudgetAmount,Month,Description,FinancialYear,CentreID,CreatedBy,CreatedOn,ModifiedBy,ModifiedOn,IsActive,IsDeleted FROM [dbo].[BudgetMaster] WHERE BudgetID =" + budgetId + "";
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
        //    if (d != null)
        //        return d.Tables[0].TableToList<Budgets>().FirstOrDefault();
        //    else
        //        return new Budgets();
        //}

        //public decimal ConsolidatedCenterBudget(int centerId, string financialYear, int Month)
        //{
        //    string Query = "";
        //    if (Month != 0)
        //        Query = "SELECT ISNULL(sum(BudgetAmount),0) as FinancialYearBudget FROM [dbo].[BudgetMaster] WHERE  Month=" + Month + " and centreId =" + centerId + " and FinancialYear ='" + financialYear + "'";
        //    else
        //        Query = "SELECT ISNULL(sum(BudgetAmount),0) as FinancialYearBudget FROM [dbo].[BudgetMaster] WHERE centreId =" + centerId + " and FinancialYear ='" + financialYear + "'";
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
        //    if (d != null)
        //        return Convert.ToDecimal(d.Tables[0].Rows[0][0] == null ? 0 : d.Tables[0].Rows[0][0]);
        //    else
        //        return 0;
        //}

        //public List<Expenses> GetAllExpenses(int centerId, out int TotalPages, int PageNumber = 1, string search = "")
        //{
        //    int RowsPerPage = ConfigurationWrapper.PageSize;
        //    SqlParameter[] spParameter = new SqlParameter[6];
        //    var pcenterId = new SqlParameter("@CentreId", centerId);
        //    var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
        //    var rowNo = new SqlParameter("@PageNumber", PageNumber);
        //    var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
        //    var psearch = new SqlParameter("@search", search);
        //    SqlCommand cmd = new SqlCommand("GetAllExpenses", db.GetConnection());
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    DataSet ds = new DataSet();
        //    cmd.Parameters.Add(pcenterId);
        //    cmd.Parameters.Add(rowsPerpage);
        //    cmd.Parameters.Add(rowNo);
        //    cmd.Parameters.Add(total);
        //    cmd.Parameters.Add(psearch);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(ds);
        //    TotalPages = Convert.ToInt32(total.Value);
        //    if (ds == null)
        //        return new List<Expenses>();
        //    else
        //        return ds.Tables[0].TableToList<Expenses>();
        //}

        //public Expenses GetExpenseById(int ExpenseID)
        //{
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetExpenseById, ExpenseID);
        //    if (d == null)
        //        return new Expenses();
        //    else
        //        return d.Tables[0].TableToList<Expenses>().FirstOrDefault();
        //}

        //public int AddExpenses(Expenses e)
        //{
        //    if (e.ExpenseID > 0)
        //        e.ActionId = 1;
        //    object[] objParam = { e.ActionId, e.ExpenseID, e.ExpenseAmount, e.ExpenseFor, e.Description, e.DateOfExpense, 
        //                            e.CentreID, e.CreatedOn,e.CreatedBy, e.ModifiedOn,e.ModifiedBy,  e.IsActive, e.IsDeleted,e.Month,e.FinancialYear };
        //    var res = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.InsertExpenses, objParam);
        //    return Convert.ToInt32(res);
        //}

        //public ViewModel.ProfitLossViewModel GetRevenue(int centerId, string FinancialYear, int Month)
        //{
        //    object[] obj = { centerId, FinancialYear, Month };

        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), "CalculateProfitLoss", obj);
        //    if (d != null)
        //        return d.Tables[0].TableToList<ViewModel.ProfitLossViewModel>().FirstOrDefault();
        //    else
        //        return new ViewModel.ProfitLossViewModel();

        //}

        //public DataSet GetBudgetAmountForMonth(int month, string year, int expensefor)
        //{
        //    //string Query = "select (BudgetAmount- isnull((select ExpenseAmount from [dbo].[Expenses] where [Month]=" + month + " and FinancialYear='" + year + "' and ExpenseFor=" + expensefor + "),0)) BalAmt from [dbo].[BudgetMaster] where [Month]=" + month + " and FinancialYear='" + year + "' and ExpenseFor=" + expensefor + "";
        //    string Query = "select BudgetAmount,(select Sum(ExpenseAmount) from [dbo].[Expenses] where [Month]=" + month + " and FinancialYear='" + year + "' and ExpenseFor=" + expensefor + ") ExpenseAmt from [dbo].[BudgetMaster] where [Month]=" + month + " and FinancialYear='" + year + "' and ExpenseFor=" + expensefor + "";
        //    var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
        //    if (d != null)
        //        return d;
        //    else
        //        return new DataSet();
        //}


    }
}