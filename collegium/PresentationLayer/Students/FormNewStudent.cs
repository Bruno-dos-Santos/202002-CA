using BusinessLogicLayer.Operations;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegium
{
    public partial class FormNewStudent : Form
    {
        public FormNewStudent()
        {
            InitializeComponent();
        }

        private void btn_SaveStudent_Click(object sender, EventArgs e)
        {
            var student = MapTxtBoxesToStudent();

            var repository = new StudentRepository();
            repository.Insert(student);

            GeneralTools.WarningBox("Student inserted");
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
            var level = radButton_postgrade.Checked ? radButton_postgrade.Text : radButton_undergrade.Text ;
            var course = cmbCourse.Text;
            var studentNumber = Convert.ToInt32(txtBox_studentNumber.Text);

            return Student.CreateStudent(firstName, surname, email, phone, addressline1, addressline2, city, county, country, level, course, studentNumber);
        }


        private void FormNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Enter(sender, e);
        }
        private void txtBox_Leave(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Leave(sender, e);
        }
    }
}
