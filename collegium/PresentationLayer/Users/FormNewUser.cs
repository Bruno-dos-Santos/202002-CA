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

namespace collegium.Users
{
    public partial class FormNewUser : Form
    {
        public FormNewUser()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var user = MapTxtBoxesToStudent();

            var repository = new UserRepository();
            repository.Insert(user);

            GeneralTools.WarningBox("User inserted");
            Close();
        }

        private User MapTxtBoxesToStudent()
        {
            var loginName = txt_loginName.Text;
            var password = txt_password.Text;
            var firstName = txt_firstName.Text;
            var lastName = txt_lastName.Text;

            return User.CreateUser(loginName, password, firstName, lastName);
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

    }
}
