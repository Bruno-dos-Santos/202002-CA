using DataAccessLayer.Entities;
using System;
using System.Configuration;
using System.Data.SqlClient;
using BusinessLogicLayer.Operations;
using DataAccessLayer.Util;

namespace DataAccessLayer.Repository
{
    public class UserRepository : RepositoryBase
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        
        public User Insert(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspAddUser", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pLoginName", user.LoginName));
                    command.Parameters.Add(new SqlParameter("@pPassword", user.Password));
                    command.Parameters.Add(new SqlParameter("@pFirstName", user.FirstName));
                    command.Parameters.Add(new SqlParameter("@pLastName", user.LastName));
                    command.Parameters.Add(new SqlParameter("@pActiveUser", LoggedInDetails.GetUserLogged()));


                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Sql Connection Error");

                    return user;
                }
            }
        }
        public User Update(User user) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspUpdateUser", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pUserId", user.UserID));
                    command.Parameters.Add(new SqlParameter("@pLoginName", user.LoginName));
                    command.Parameters.Add(new SqlParameter("@pPassword", user.Password));
                    command.Parameters.Add(new SqlParameter("@pFirstName", user.FirstName));
                    command.Parameters.Add(new SqlParameter("@pLastName", user.LastName));
                    command.Parameters.Add(new SqlParameter("@pActiveUser", LoggedInDetails.GetUserLogged()));

                    var rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                        throw new Exception("Sql Connection Error");

                    return user;
                }
            }
        }

        public void Delete(int id) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspDeleteUser", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pUserID", id));
                    command.ExecuteNonQuery();
                }
            }
        }

        public LoginEnum Login(string login, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("dbo.uspLogin", connection))
                {
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@pLoginName", login));
                    command.Parameters.Add(new SqlParameter("@pPassword", password));
                    command.Parameters.Add("@responseMessage", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;

                    command.ExecuteNonQuery();
                    
                    return (LoginEnum)command.Parameters["@responseMessage"].Value;
                }
            }
        }
    }
}
