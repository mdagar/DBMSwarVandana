using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBConnection;
using Models;
using SqlRepositories;
using System.Data;
using Code;
namespace Repositories
{
    public class MessageTransactionRepository
    {
        public MessageTransactionRepository()
        { }
        DBConnections db = new DBConnections();

        public int SaveRecord(MessageTransaction m)
        {
            string Query = string.Empty;
            Query = "Insert into MessageTransaction(MsgType,SendBy,SendDate,Message,SendTo,IsBrodcast) values('" + m.MsgType + "'," + m.SendBy + ",'" + m.SendDate + "','" + m.Message + "','" + m.SendTo + "','" + m.IsBrodcast + "')";
            var d = SqlHelper.ExecuteNonQuery(db.GetConnection(), CommandType.Text, Query);
            return Convert.ToInt32(d);
        }

        public DataTable GetContacts(int centerid)
        {
            string Query = "select distinct ContactNumber from  [dbo].[Enquiries] where CentreId= "+centerid+"";
            var d = SqlHelper.ExecuteDataset(db.GetConnection(), CommandType.Text, Query);
            if (d != null)
                return d.Tables[0];
            else
            {
                return new DataTable();
            }
        }
    }
}