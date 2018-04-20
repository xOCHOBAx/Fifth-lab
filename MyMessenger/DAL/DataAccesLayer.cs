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
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyMessengerDB"].ConnectionString;
        SqlConnection connection = new SqlConnection(connectionString);

        public void kek() {
            using (connection)
            {
                connection.Open();
            }
        }
        
    }
}
