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
    public class StudentsRepository
    {
        DBConnections db = new DBConnections();
        public List<Students> GetStudents(int centerId)
        {
            object[] objParam = { centerId, "" };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.GetStudents, objParam);
            if (ds == null)
                return new List<Students>();
            else
                return ds.Tables[0].TableToList<Students>();
        }

        public int AdStudents(Students s)
        {
            object[] objParam = {s.ActionId,s.Id,s.UniqueKey,s.Name,s.CenterId,s.DOB,s.Contact1,s.Contact2,s.EmailAddress,s.Address,s.StateId,
                                    s.CityId,s.GuardianName,s.Occupation,s.HasTransportFacility,s.CreatedDate,s.CreatedBy,s.ModifyDate,s.ModifyBy,s.IsActive,s.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Students_IUD, objParam);
            return Convert.ToInt32(d);
        }
    }
}