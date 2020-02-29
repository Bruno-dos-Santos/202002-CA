using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Operations
{
    class OStudent
    {
        public void Insert(EStudent eStudent) {
            // dbo.uspAddStudent


            SqlCommand cmd = new SqlCommand("dbo.uspAddStudent", conn);
            cmd.Parameters.AddWithValue("@EID", eStudent.StudentID);
            cmd.Parameters.AddWithValue("@FName", fn);
            cmd.Parameters.AddWithValue("@LName", ln);
            cmd.Parameters.AddWithValue("@Pos", pos);
            cmd.Parameters.AddWithValue("@Salary", sal);
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }
        public void Delete() { }
        public void Update() { }
        public void Select()
        {

        }
    }
}