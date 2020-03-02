using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogicLayer.Operations

{
    public static class GeneralTools
    {
        private static string LoginName { get; set; }

        public static void SetUserLogged(string loginName)
        {
            LoginName = loginName;
        }
        public static string GetUserLogged()
        {
            return LoginName;
        }
        public static bool ConfirmationBox(string message, string caption = "Confirmation")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes;
        }
        public static void WarningBox(string message, string caption = "Warning")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }

        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static void txtBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.Yellow;
            }
            else if (sender is ComboBox)
            {
                (sender as ComboBox).BackColor = Color.Yellow;
            }

        }
        public static void txtBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
            else if (sender is ComboBox)
            {
                (sender as ComboBox).BackColor = Color.White;
            }

        }



    }
}
