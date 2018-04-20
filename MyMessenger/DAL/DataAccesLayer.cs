using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class DataAccesLayer
    {
        static string connectionString;
        SqlConnection connection;

        public DataAccesLayer()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public bool AddUser(string UserName, string Password, string FullName)
        {
            DataSet ds = new DataSet();
            using (connection)
            using (var command = new SqlCommand("Add_User", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                SqlDataAdapter a = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@UserName",UserName));
                command.Parameters.Add(new SqlParameter("@Password", Password));
                command.Parameters.Add(new SqlParameter("@FullName", FullName));

                return Convert.ToInt32(command.ExecuteScalar())==1;
            }
        }

        public bool AddMessage(int MsgFrom, int MsgTo, string Sub, string Body, DateTime Date)
        {
            DataSet ds = new DataSet();
            using (connection)
            using (var command = new SqlCommand("Add_Message", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                SqlDataAdapter a = new SqlDataAdapter(command);
                command.Parameters.Add(new SqlParameter("@MsgFrom", MsgFrom));
                command.Parameters.Add(new SqlParameter("@MsgTo", MsgTo));
                command.Parameters.Add(new SqlParameter("@Sub", Sub));
                command.Parameters.Add(new SqlParameter("@Body", Body));
                command.Parameters.Add(new SqlParameter("@Date", Date));
                a.Fill(ds);

                return true;
            }
        }
    }
}
