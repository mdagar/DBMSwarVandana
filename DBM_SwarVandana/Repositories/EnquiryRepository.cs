﻿using System;
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
            object[] objParam = { e.ActionId, e.EnquiryId, e.SourceId, e.EnquiryTypeId, e.ContactNumber, e.Name, 
                                    e.DateOfEnquiry, e.Discipline, e.StateId, e.CityId, e.Address, e.AttendedBy,
                                    e.Demo,e.RemarksByFaculty, e.StatusId,e.ProbableStudentFor,e.Gender,e.Age,e.Occupation,
                                    e.FinalComments,e.NoOfClasses,e.Package,e.RegistrationAmount,e.CentreId,e.IsEnquiryClosed,
                                    e.AddDate, e.AddedBy, e.ModifyDate, e.ModifyBy, e.IsActive };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Enquiries_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Enquiries> ListEnquuiry(int centerId, int centerType)
        {
            object[] objParam = { centerId, centerType };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), "GetEnquiry", objParam);
            if (ds == null)
                return new List<Enquiries>();
            else
                return ds.Tables[0].TableToList<Enquiries>();
        }

    }
}