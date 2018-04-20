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
        string str = System.Configuration.ConfigurationManager.ConnectionStrings["MyMessengerDB"].ConnectionString;
        
    }
}
