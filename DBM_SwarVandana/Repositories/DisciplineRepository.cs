﻿using System;
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
    public class DisciplineRepository
    {
        DBConnections db = new DBConnections();
        public int CreateDiscipline(Disciplines dis)
        {
            if (dis.DisciplineId > 0)
                dis.ActionId = 1;
            else
                dis.ActionId = 0;
            object[] objParam = { dis.ActionId, dis.DisciplineId, dis.Discipline, dis.Description, dis.CentreID, dis.AddDate, dis.AddedBy, dis.ModifyDate, dis.ModifyBy, dis.IsActive, dis.IsDeleted,SessionWrapper.User.CentreId };
            var d = SqlHelper.ExecuteScalar(db.GetConnection(), Procedures.USP_Disciplines_IUD, objParam);
            return Convert.ToInt32(d);
        }

        public List<Disciplines> GetAllDisciplines(int CentreID, string search = "")
        {
            object[] obj = { search, CentreID };
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_DisciplineGetAll, obj);
            return ConvertList.TableToList<Disciplines>(d.Tables[0]);
        }

        public Disciplines GetDisciplineById(int? DisciplineId)
        {
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), Procedures.USP_DisciplineGetById, DisciplineId);
            Disciplines dis = new Disciplines();
            dis.DisciplineId = Convert.ToInt32(d.Tables[0].Rows[0][0]);
            dis.Discipline = Convert.ToString(d.Tables[0].Rows[0][1]);
            dis.Description = Convert.ToString(d.Tables[0].Rows[0][2]);
            return dis;
        }
    }
}