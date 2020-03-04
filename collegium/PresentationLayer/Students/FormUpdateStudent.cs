using BusinessLogicLayer.Operations;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace collegium.Students
{
    public partial class FormUpdateStudent : Form
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public FormUpdateStudent(string StudentNumber = "")
        {
            InitializeComponent();

            var studentRepository = new StudentRepository();

            Students = studentRepository.GetAll().ToList();
            if (StudentNumber.Trim() != "")
            {
                studentNumber.Text = StudentNumber;
            }
        }


        private void studentNumber_TextChanged(object sender, EventArgs e)
        {
            var txtBox_id = sender as TextBox;
            var id = Convert.ToInt32(txtBox_id.Text);

            var student = Students
                .Find(x => x.StudentNumber == id);

            if (student == null)
            {
                ClearTextBox();
                return;
            }

            txtBox_firstName.Text = student.FirstName;
            txtBox_surname.Text = student.LastName;
            txtBox_email.Text = student.Email;
            txtBox_phone.Text = student.Phone;
            txtBox_addressLine1.Text = student.AddressLine1;
            txtBox_addressLine2.Text = student.AddressLine2;
            txtBox_city.Text = student.City;
            cmbCounty.Text = student.County;
            radButton_postgrade.Checked = student.Level == "Postgrad";
            radButton_undergrade.Checked = student.Level == "Undergrad";
            cmbCourse.Text = student.Course;
            txtBox_studentNumber.Text = Convert.ToString(student.StudentNumber);
        }

        private void ClearTextBox()
        {
            txtBox_firstName.Text = String.Empty;
            txtBox_surname.Text = String.Empty;
            txtBox_email.Text = String.Empty;
            txtBox_phone.Text = String.Empty;
            txtBox_addressLine1.Text = String.Empty;
            txtBox_addressLine2.Text = String.Empty;
            txtBox_city.Text = String.Empty;
            cmbCounty.Text = String.Empty;
            radButton_postgrade.Checked =  false;
            radButton_undergrade.Checked = false;
            cmbCourse.Text = String.Empty;
            txtBox_studentNumber.Text = Convert.ToString(String.Empty);
        }

        private void btn_SaveStudent_Click(object sender, EventArgs e)
        {
            var student = MapTxtBoxesToStudent();

            var repository = new StudentRepository();
            repository.Update(student);

            GeneralTools.WarningBox("Student updated");

            Close();
        }

        private Student MapTxtBoxesToStudent()
        {
            var firstName = txtBox_firstName.Text;
            var surname = txtBox_surname.Text;
            var email = txtBox_email.Text;
            var phone = txtBox_phone.Text;
            var addressline1 = txtBox_addressLine1.Text;
            var addressline2 = txtBox_addressLine2.Text;
            var city = txtBox_city.Text;
            var county = cmbCounty.Text;
            var country = "Ireland";
            var level = radButton_postgrade.Checked ? radButton_postgrade.Text : radButton_undergrade.Text;
            var course = cmbCourse.Text;
            var studentNumber = Convert.ToInt32(txtBox_studentNumber.Text);

            return Student.CreateStudent(firstName, surname, email, phone, addressline1, addressline2, city, county, country, level, course, studentNumber);
        }


        private void txtBox_Enter(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Enter(sender, e);
        }
        private void txtBox_Leave(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Leave(sender, e);
        }
        private void txtBox_notEmpty(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            e.Cancel = ValidationTool.RequiredFieldIsBlank(erProvider, txt);
        }
        private void validEmail(object sender, CancelEventArgs e)
        {
            TextBox txt = sender as TextBox;
            e.Cancel = ValidationTool.EmailAddressIsWrong(erProvider, txt);
        }
        private void FormUpdateStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
