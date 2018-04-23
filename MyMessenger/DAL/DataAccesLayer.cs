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
        static string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        SqlConnection connection;

        public DataAccesLayer()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        public bool AddUser(string UserName, string Password, string FullName)
        {
            using (connection)
            using (var command = new SqlCommand("Add_User", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@UserName", UserName));
                command.Parameters.Add(new SqlParameter("@Password", Password));
                command.Parameters.Add(new SqlParameter("@FullName", FullName));

                return Convert.ToInt32(command.ExecuteScalar()) == 1;
            }
        }

        public bool Authorize(string UserName,string Password)
        {
            using (connection)
            using (var command = new SqlCommand("Authorize", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@UserName", UserName));
                command.Parameters.Add(new SqlParameter("@Password", Password));
                SqlDataAdapter a = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                a.Fill(ds);
                return ds.Tables.Count == 1;
            }
        }

        public User GetUserByName(string UserName)
        {
            using (connection)
            using (var command = new SqlCommand("Get_User_By_Name", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@UserName", UserName));
                SqlDataAdapter a = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                a.Fill(ds);


                if (ds.Tables.Count != 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    return FormUserFromRow(row);
                }
                return null;
            }
        }

        public User GetUser(int Id)
        {
            using (connection)
            using (var command = new SqlCommand("Get_User", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@Id", Id));
                SqlDataAdapter a = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                a.Fill(ds);


                if (ds.Tables.Count != 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    return FormUserFromRow(row);
                }
                return null;
            }
        }

        public User FormUserFromRow(DataRow row)
        {
            return new User()
            {
                Id = (int)row["Id"],
                UserName = row["UserName"].ToString(),
                Password = row["Password"].ToString(),
                FullName = row["FullName"].ToString(),
            };
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

        public List<Entities.Message> GetMessagesFromById(int Id)
        {
            var list = new List<Entities.Message>();
            using (connection)
            using (var command = new SqlCommand("Get_Messages_From_By_Id", connection) { CommandType = CommandType.StoredProcedure })
            {
                var ds = new DataSet();
                SqlDataAdapter a = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@Id",Id);
                a.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    list.Add(FormMessageFromRow(row));
                }
                return list;
            }
        }

        public List<Entities.Message> GetMessagesToById(int Id)
        {
            var list = new List<Entities.Message>();
            using (connection)
            using (var command = new SqlCommand("Get_Messages_To_By_Id", connection) { CommandType = CommandType.StoredProcedure })
            {
                var ds = new DataSet();
                SqlDataAdapter a = new SqlDataAdapter(command);
                command.Parameters.AddWithValue("@Id", Id);
                a.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    list.Add(FormMessageFromRow(row));
                }
                return list;
            }
        }

        public Entities.Message GetMessage(int Id)
        {
            using (connection)
            using (var command = new SqlCommand("Get_Message", connection) { CommandType = CommandType.StoredProcedure })
            {
                connection.Open();
                command.Parameters.Add(new SqlParameter("@Id", Id));
                SqlDataAdapter a = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                a.Fill(ds);


                if (ds.Tables.Count != 0)
                {
                    DataRow row = ds.Tables[0].Rows[0];
                    return FormMessageFromRow(row);
                }
                return null;
            }
        }

        public Message FormMessageFromRow(DataRow row)
        {
            return new Message()
            {
                Id = (int)row["Id"],
                MsgFrom = (int)row["MsgFrom"],
                MsgTo = (int)row["MsgTo"],
                Sub = row["Sub"].ToString(),
                Body = row["Body"].ToString(),
                Date = Convert.ToDateTime(row["Date"])
            };
        }
    }
}
