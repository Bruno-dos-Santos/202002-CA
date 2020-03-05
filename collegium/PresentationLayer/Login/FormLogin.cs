using BusinessLogicLayer.Operations;
using DataAccessLayer.Repository;
using DataAccessLayer.Util;
using System;
using System.Windows.Forms;

namespace collegium.Login
{
    public partial class FormLogin : Form
    {
        public Form TheParent { get; set; }

        public FormLogin()
        {
            InitializeComponent();

            ControlBox = false;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var userRepository = new UserRepository();

            var response = userRepository.Login(txtBox_login.Text, txtbox_password.Text);

            if (response == LoginEnum.Successful)
            {
                LoggedInDetails.SetUserLogged(txtBox_login.Text);
                LoggedInDetails.SetLoggedInState(true);                
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

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login_Click(e, e);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            LoggedInDetails.SetLoggedInState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GeneralTools.ConfirmationBox("this action will close the application, confirm?"))
                Application.Exit();
        }
        private void txtBox_Leave(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Leave(sender, e);
        }
        private void txtBox_Enter(object sender, EventArgs e)
        {
            GeneralTools.txtBox_Enter(sender, e);
        }

    }
}
