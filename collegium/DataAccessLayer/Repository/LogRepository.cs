using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using System;

namespace DataAccessLayer.Repository
{
    public class LogRepository : RepositoryBase
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
        public Task<Log> Insert()
        {
            throw new NotImplementedException();
        }
        public Task<Log> Update() 
        {
            throw new NotImplementedException();
        }
        public Task Delete() 
        {
            throw new NotImplementedException();
        }

        public SqlDataReader Select()
        {
            conn.Open();
            string query = "select * from Logs";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            conn.Close();
            return reader;
        }

        public DataTable RefreshGrid(string loginName = "", string type = "All", string operation = "All", string tableName = "All")
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string query = "select * from Logs";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = cmd;

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            return dataTable;
        }
    }
}
