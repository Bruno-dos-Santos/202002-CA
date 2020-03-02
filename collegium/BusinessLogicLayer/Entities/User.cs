using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int isDeleted { get; set; }

        protected User()
        {

        }

        public static User CreateUser(string loginName, string password, string firstName, string lastName)
        {
            return new User
            {
                LoginName = loginName,
                Password = password,
                FirstName = firstName,
                LastName = lastName
            };
        }
        public User(DataRow row)
        {
            UserID = row.Field<int>("UserId");
            LoginName = row.Field<string>("LoginName");
            Password = row.Field<string>("PasswordHash");
            FirstName = row.Field<string>("FirstName");
            LastName = row.Field<string>("LastName");
            isDeleted = row.Field<int>("isDeleted");
        }
    }
}
