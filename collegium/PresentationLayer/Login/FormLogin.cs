using BusinessLogicLayer.Operations;
using DataAccessLayer.Repository;
using DataAccessLayer.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace collegium.Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userRepository = new UserRepository();

            var response = userRepository.Login(txtBox_login.Text, txtbox_password.Text);

            if (response == LoginEnum.Successful)
            {
                GeneralTools.SetUserLogged(txtBox_login.Text);
                Close();
                return;
            }

            if (response == LoginEnum.IncorrectLogin)
            {
                GeneralTools.WarningBox("Incorrect login.");
            }

            if (response == LoginEnum.IncorrectPassword)
            {
                GeneralTools.WarningBox("Incorrect password.");
            }
        }
    }
}
