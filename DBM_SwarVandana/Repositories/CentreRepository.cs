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
    public class CentreRepository
    {
        DBConnections db = new DBConnections();
        public List<States> GetStates()
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_StatesGetAll);
            return ConvertList.TableToList<States>(d.Tables[0]);
        }

        public List<Cities> GetCitiesByStateId(int StateId)
        {
            object[] objParam = { StateId };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_CitiesGetByStateId, objParam);
            return ConvertList.TableToList<Cities>(d.Tables[0]);
        }

        public List<Cities> GetCities()
        {
            string Query = "select CityId,StateId,CityName,AddDate,AddedBy,IsActive  from [dbo].[Cities] where isactive =1";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            return ConvertList.TableToList<Cities>(d.Tables[0]);
        }

        public int CreateCentres(Centres c)
        {
            if (c.CentreId > 0)
                c.ActionId = 1;
            else
                c.ActionId = 0;
            object[] objParam = { c.ActionId, c.CentreId, c.CentreName, c.Address, c.StateId, c.CityId, c.CentreOpenDate, c.AddDate, c.AddedBy, c.ModifyDate, c.ModifyBy, c.IsActive, c.IsDeleted };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Centres_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Centres> GetAllCentres(string search = "")
        {
            object[] objParam = { search };
            DataSet ds = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_CentresGetAll, objParam);
            if (ds == null)
                return new List<Centres>();
            else
                return ds.Tables[0].TableToList<Centres>();
        }

        public Centres FindByCenterId(long CenterId)
        {
            string Query = "Select CentreId,CentreName,Address,StateId,CityId,CentreOpenDate,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive,IsDeleted from  [dbo].[Centres] where IsActive=1 and isdeleted =0 and CentreId=" + CenterId;
            var ds = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (ds == null)
                return new Centres();
            else
                return ds.Tables[0].TableToList<Centres>().FirstOrDefault();
        }
    }
}