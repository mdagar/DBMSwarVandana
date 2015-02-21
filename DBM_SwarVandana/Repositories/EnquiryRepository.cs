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
using System.Configuration;
using System.Data.SqlClient;

namespace Repositories
{
    public class EnquiryRepository
    {
        DBConnections db = new DBConnections();
        public int CreateEnquiry(Enquiries e)
        {
            if (e.EnquiryId > 0)
                e.ActionId = 1;
            else
                e.ActionId = 0;
            object[] objParam = { e.ActionId, e.EnquiryId, e.SourceId, e.EnquiryTypeId, e.ContactNumber, e.Name, 
                                    e.DateOfEnquiry, e.Discipline, e.StateId, e.CityId, e.Address, e.AttendedBy,
                                    e.Demo,e.RemarksByFaculty, e.StatusId,e.ProbableStudentFor,e.Gender,e.Age,e.Occupation,
                                    e.FinalComments,e.NoOfClasses,e.Package,e.RegistrationAmount,e.CentreId,e.IsEnquiryClosed,e.FacultyID,
                                    e.TelephonicEnquiryId,e.AddDate, e.AddedBy, e.ModifyDate, e.ModifyBy, e.IsActive,e.IsDeleted };
            var strings = string.Join(",", objParam);
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Enquiries_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Enquiries> ListEnquuiry(int centerId, int EnqueryType, out int TotalPages, int PageNumber = 1, string search = "")
        {
            bool IsStatus = false;
            switch (search.ToLower())
            {
                case "red":
                    search = "1";
                    IsStatus = true;
                    break;
                case "green":
                    search = "2";
                    IsStatus = true;
                    break;
                case "yellow":
                    search = "3";
                    IsStatus = true;
                    break;
                default:
                    break;
            }
            int RowsPerPage = ConfigurationWrapper.PageSize;
            SqlParameter[] spParameter = new SqlParameter[6];
            var pcenterId = new SqlParameter("@centerId", centerId);
            var EnqType = new SqlParameter("@enqueryType", EnqueryType);
            var rowsPerpage = new SqlParameter("@RowsPerPage", RowsPerPage);
            var rowNo = new SqlParameter("@PageNumber", PageNumber);
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", search);
            var isstatus = new SqlParameter("@IsStatus", IsStatus);
            SqlCommand cmd = new SqlCommand("GetEnquiry", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            cmd.Parameters.Add(pcenterId);
            cmd.Parameters.Add(EnqType);
            cmd.Parameters.Add(rowsPerpage);
            cmd.Parameters.Add(rowNo);
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(psearch);
            cmd.Parameters.Add(isstatus);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            TotalPages = Convert.ToInt32(total.Value);
            if (ds == null)
                return new List<Enquiries>();
            else
                return ds.Tables[0].TableToList<Enquiries>();
        }

        public List<Enquiries> ListEnquuiryAdvance(int centerId, int EnqueryType, out int TotalPages, int PageNumber = 1, string SourceId = "", string StatusId = "", string search = "", string DisciplineID = "")
        {
            int RowsPerPage = ConfigurationWrapper.PageSize;
            string Query = string.Empty;
            string Query1 = string.Empty;
            search = search.Trim();
            Query += "EnquiryTypeId=" + EnqueryType + " AND CentreId=" + centerId + " AND IsDeleted=0";
            if (SourceId != "")
                Query += "and SourceId=" + SourceId;
            if (StatusId != "")
                Query += " and StatusId=" + StatusId;
            if (DisciplineID != "")
                Query += " and Discipline=" + DisciplineID;
            if (search != "")
                Query += " and ( Name like '%" + search + "%' OR ContactNumber like '%" + search + "%' OR [Address] like '%" + search + "%' OR NoOfClasses like '%" + search + "%' OR Package like '%" + search + "%'  OR EnquiryNumber like '%" + search + "%' )";


            Query1 = "" + (((PageNumber - 1) * RowsPerPage) + 1) + " AND " + RowsPerPage * (PageNumber);
            SqlParameter[] spParameter = new SqlParameter[6];
            var total = new SqlParameter("@TotalPages", 0) { Direction = System.Data.ParameterDirection.Output };
            var psearch = new SqlParameter("@search", Query);
            var pageno = new SqlParameter("@pageno", Query1);
            SqlCommand cmd = new SqlCommand("GetEnquiryAdvanceSearch", db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            cmd.Parameters.Add(total);
            cmd.Parameters.Add(psearch);
            cmd.Parameters.Add(pageno);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            TotalPages = Convert.ToInt32(total.Value);
            if (ds == null)
                return new List<Enquiries>();
            else
                return ds.Tables[0].TableToList<Enquiries>();
        }

        public List<Enquiries> GetAllEnquery(int centerId, int EnqueryType)
        {
            object[] objParam = { centerId, EnqueryType };
            string Query = "SELECT EnquiryId,SourceId,EnquiryTypeId,ContactNumber,Name,DateOfEnquiry,Discipline,StateId,CityId,[Address],AttendedBy,Demo,RemarksByFaculty,StatusId,ProbableStudentFor,Gender,Age,Occupation,FinalComments,"
                           + "NoOfClasses,Package,RegistrationAmount,CentreId,IsEnquiryClosed,TelePhonicEnquiryId,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted FROM [dbo].[Enquiries]"
                            + " WHERE EnquiryTypeId = " + EnqueryType + " AND CentreId = " + centerId + " AND IsDeleted=0";
            //DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Query, objParam);
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new List<Enquiries>();
            else
                return ds.Tables[0].TableToList<Enquiries>();

        }


        public Enquiries FindByEnquirieID(long enquiryId)
        {
            object[] objParam = { enquiryId };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetEnquiryById, objParam);
            if (ds == null)
                return new Enquiries();
            else
                return ds.Tables[0].TableToList<Enquiries>().FirstOrDefault();


        }

        public Enquiries FindByEnquirieNumber(string EnquiryNumber)
        {
            object[] objParam = { EnquiryNumber, SessionWrapper.User.CentreId };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetEnquiryByEnquiryNumber, objParam);
            if (ds.Tables.Count == 0)
                return new Enquiries();
            else
                return ds.Tables[0].TableToList<Enquiries>().FirstOrDefault();


        }

        public List<Users> GetUsersForEnquiryBy(int CentreId)
        {
            object[] objParam = { CentreId };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetUsersForEnquiryBy, objParam);
            if (ds == null)
                return new List<Users>();
            else
                return ds.Tables[0].TableToList<Users>();
        }

    }
}