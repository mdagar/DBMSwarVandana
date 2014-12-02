using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DBConnection;
using DBM_SwarVandana.Resources;
using Models;
using System.Reflection;
using SqlRepositories;
using ListConversion;
using Code;

namespace Repositories
{
    public class SourceRepository
    {
        DBConnections db = new DBConnections();
        public int CreateSource(Sources s)
        {
            object[] objParam = { s.ActionId, s.SourceId, s.Source, s.Description, s.AddDate, s.AddedBy, s.ModifyDate, s.ModifyBy, s.IsActive };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Sources_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Sources> GetAllSources()
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_SourceGetAll);
            return ConvertList.TableToList<Sources>(d.Tables[0]);
        }
    }
}