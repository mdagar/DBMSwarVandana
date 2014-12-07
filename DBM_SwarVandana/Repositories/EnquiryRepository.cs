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
                                    e.FinalComments,e.NoOfClasses,e.Package,e.RegistrationAmount,e.CentreId,e.IsEnquiryClosed,
                                    e.AddDate, e.AddedBy, e.ModifyDate, e.ModifyBy, e.IsActive,e.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Enquiries_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Enquiries> ListEnquuiry(int centerId, int EnqueryType, string search = "")
        {
            object[] objParam = { centerId, EnqueryType, search };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetEnquiry, objParam);
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

    }
}