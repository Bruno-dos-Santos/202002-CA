using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusinessLogicLayer.Operations

{
    public static class GeneralTools
    {
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



    }
}
