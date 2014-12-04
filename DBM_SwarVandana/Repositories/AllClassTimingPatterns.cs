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
using System.Xml;
using System.Data.SqlClient;
namespace Repositories
{
    public class AllClassTimingPatterns
    {
        public AllClassTimingPatterns()
        { }
        DBConnections db = new DBConnections();
        public List<ClassTimingPatterns> FindByClassId(long classId)
        {
            string Query = "SELECT PatternId,ClassId,WeekDayId,StartTime,EndTime,Summary,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[ClassTimingPatterns] WHERE ClassId =" + classId;
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return d.Tables[0].TableToList<ClassTimingPatterns>();
            else
                return new List<ClassTimingPatterns>();
        }

        public List<ClassTimingPatterns> FindByWeekDay(long classId, long WeekDayid)
        {
            string Query = "SELECT PatternId,ClassId,WeekDayId,StartTime,EndTime,Summary,AddDate,AddedBy,ModifyDate,ModifyBy,IsActive FROM [dbo].[ClassTimingPatterns] WHERE ClassId =" + classId + "AND WeekDayId=" + WeekDayid;
            DataSet d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return d.Tables[0].TableToList<ClassTimingPatterns>();
            else
                return new List<ClassTimingPatterns>();
        }

        public long Save(XmlDocument doc)
        {
            using (SqlConnection con = db.GetConnection())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insertclasstimming", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@XMLdata", doc.InnerXml);
                cmd.ExecuteNonQuery();
                con.Close();
                return 1;
            }
        }
    }
}