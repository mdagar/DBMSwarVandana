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

        public int CreateCentres(Centres c)
        {
            object[] objParam = { c.ActionId, c.CentreId, c.CentreName, c.Address, c.StateId, c.CityId, c.CentreOpenDate, c.AddDate, c.AddedBy, c.ModifyDate, c.ModifyBy, c.IsActive };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Centres_IUD, objParam);
            return Convert.ToInt32(d);
        }
    }
}