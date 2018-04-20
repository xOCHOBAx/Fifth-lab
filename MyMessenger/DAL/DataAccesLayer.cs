using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccesLayer
    {
        //static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyMessengerDB"].ConnectionString;
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\repos\Fifth-lab\MyMessenger\DAL\MyMessengerDB.mdf;Integrated Security=True;Connect Timeout=30");

        public int AddUser(string UserName, string Password, string FullName)
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

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
    }
}
