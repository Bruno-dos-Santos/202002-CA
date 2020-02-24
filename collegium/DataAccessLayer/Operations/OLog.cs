using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Operations
{
    class OLog
    {
       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
        public void Insert() { }
       public void Delete() { }
       public void Update() { }
       public SqlDataReader Select() 
        {
            conn.Open();
            string query = "select * from Logs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            conn.Close();
            return reader;
        }
    }
}
