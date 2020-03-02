using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class StudentRepository : RepositoryBase
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        public Student Insert(Student student) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using(SqlCommand command = new SqlCommand("dbo.uspAddStudent", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pFirstName", student.FirstName));
                    command.Parameters.Add(new SqlParameter("@pLastName", student.LastName));
                    command.Parameters.Add(new SqlParameter("@pEmail", student.Email));
                    command.Parameters.Add(new SqlParameter("@pPhone", student.Phone));
                    command.Parameters.Add(new SqlParameter("@pAddressLine1", student.AddressLine1));
                    command.Parameters.Add(new SqlParameter("@pAddressLine2", student.AddressLine2));
                    command.Parameters.Add(new SqlParameter("@pCity", student.City));
                    command.Parameters.Add(new SqlParameter("@pCounty", student.Country));
                    command.Parameters.Add(new SqlParameter("@pLevel", student.Level));
                    command.Parameters.Add(new SqlParameter("@pCourse", student.Course));
                    command.Parameters.Add(new SqlParameter("@pStudentNumber", student.StudentNumber));

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Sql Connection Error");

                    return student;
                }
            }
        }
        public Student Update(Student student) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspUpdateStudent", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pFirstName", student.FirstName));
                    command.Parameters.Add(new SqlParameter("@pLastName", student.LastName));
                    command.Parameters.Add(new SqlParameter("@pEmail", student.Email));
                    command.Parameters.Add(new SqlParameter("@pPhone", student.Phone));
                    command.Parameters.Add(new SqlParameter("@pAddressLine1", student.AddressLine1));
                    command.Parameters.Add(new SqlParameter("@pAddressLine2", student.AddressLine2));
                    command.Parameters.Add(new SqlParameter("@pCity", student.City));
                    command.Parameters.Add(new SqlParameter("@pCounty", student.Country));
                    command.Parameters.Add(new SqlParameter("@pLevel", student.Level));
                    command.Parameters.Add(new SqlParameter("@pCourse", student.Course));
                    command.Parameters.Add(new SqlParameter("@pStudentNumber", student.StudentNumber));

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Sql Connection Error");

                    return student;
                }
            }
        }
        
        public void Delete(long studentNumber) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspDeleteStudent", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pStudentNumber", studentNumber));
                    command.ExecuteNonQuery();
                }
            }
        }

        public IEnumerable<Student> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspGetAllStudents", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.ExecuteNonQuery();

                    var table = new DataTable();
                    var sqlAdapter = new SqlDataAdapter();
                    sqlAdapter.SelectCommand = command;

                    sqlAdapter.Fill(table);

                    return ExecuteObject<Student>(table);
                }
            }
        }
    }
}