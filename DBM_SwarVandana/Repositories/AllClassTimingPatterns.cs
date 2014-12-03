using DBConnection;
using Models;
using SqlRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ListConversion;
using System.Data;
using Code;
namespace Repositories
{
    public class AllClassTimingPatterns
    {
        public AllClassTimingPatterns()
        { }
        DBConnections db = new DBConnections();
        public List<ClassTimingPatterns> FindByClassId(long classId)
        {
            string Query = "SELECT PatternId,ClassId,WeekDayId,StartTime,EndTime,Summary,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[ClassTimingPatterns] WHERE ClassId ="+classId;
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(),CommandType.Text,Query);
            if (d != null)
                return d.Tables[0].TableToList<ClassTimingPatterns>();
            else
                return new List<ClassTimingPatterns>();
        }
    }
}