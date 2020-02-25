using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using DataAccessLayer.Entities;
using System.Data;

namespace DataAccessLayer.Operations
{
    public class OLog
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
        public DataTable refreshGrid(string loginName = "", string type = "All", string operation = "All", string tableName = "All" )
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = "select * from Logs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);            
            
            return dataTable;
        }
    }
}
