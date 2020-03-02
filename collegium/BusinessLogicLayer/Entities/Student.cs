using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }
        public int StudentNumber { get; set; }

        protected Student()
        {

        }

        public static Student CreateStudent(string firstName, string lastName, string email, string phone, string addressLine1, string addressLine2, string city, string county, string level, string course, int studentNumber)
        {
            return new Student
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Phone = phone,
                AddressLine1 = addressLine1,
                AddressLine2 = addressLine2,
                City = city,
                Country = county,
                Course = GetCourseFromForm(course),
                Level = level,
                StudentNumber = studentNumber
            };
        }

        public Student(DataRow row)
        {
            StudentID = row.Field<int>("StudentID");
            FirstName = row.Field<string>("FirstName");
            LastName = row.Field<string>("LastName");
            Email = row.Field<string>("Email");
            Phone = row.Field<string>("Phone");
            AddressLine1 = row.Field<string>("AddressLine1");
            AddressLine2 = row.Field<string>("AddressLine2");
            City = row.Field<string>("City");
            Country = row.Field<string>("County");
            Level = row.Field<string>("Level");
            Course = row.Field<string>("Course");
            StudentNumber = row.Field<int>("StudentNumber");
        }

        private static string GetCourseFromForm(string text)
        {
            var numberOfCities = text.Split(',').ToList().Count();

            if (numberOfCities != 5)
                throw new Exception("Number os cities don't match 5.");

            return text;

        }
    }
}
