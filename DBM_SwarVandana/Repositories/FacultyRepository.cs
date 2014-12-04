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
    public class FacultyRepository : Faculties
    {
        DBConnections db = new DBConnections();
        public int FacultyRegistration(Faculties f)
        {
            object[] objParam = { f.ActionId,f.FacultyId,f.NameOfFaculty,f.EmailID,
                                  f. ContactNumber    ,
                                  f. Address          ,
                                  f. StateId          ,
                                  f. CityId           ,
                                  f. DOJ              ,
                                  f. Gender           ,
                                  f. Salary           ,
                                  f. SalaryRevision   ,
                                  f. DisciplineId     ,
                                  f. YearOfExperience ,
                                  f. CentreId         ,
                                  f. Picture          ,
                                  f. AddDate          ,
                                  f. AddedBy          ,
                                  f. ModifyDate       ,
                                  f. ModifyBy        ,
                                  f. IsActive};
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Faculties_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Faculties> GetFacultyByCentreId(int CentreId)
        {
            object[] objParam = { CentreId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_FacultyGetByCenterId, objParam);
            return ConvertList.TableToList<Faculties>(d.Tables[0]);
        }

        public Faculties GetFacultyByFacultyId(long FacultyId)
        {
            string query = "SELECT FacultyId,NameOfFaculty,EmailID,ContactNumber,Address,StateId,CityId,DOJ,Gender,Salary,SalaryRevision,DisciplineId,YearOfExperience,CentreId,Picture,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[Faculties] WHERE FacultyId=" + FacultyId + "";
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, query);
            if (ds == null)
                return new Faculties();
            else
                return ds.Tables[0].TableToList<Faculties>().FirstOrDefault();
        }
    }
}