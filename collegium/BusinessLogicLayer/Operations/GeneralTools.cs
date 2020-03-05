using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BusinessLogicLayer.Operations

{
    public static class LoggedInDetails
    {
        private static string LoginName { get; set; }
        private static bool LoggedIn { get; set; }

        public static void SetUserLogged(string loginName)
        {
            LoginName = loginName;
        }
        public static bool GetLoggedInState()
        {
            return LoggedIn;
        }

        public static void SetLoggedInState(bool loggedIn = false)
        {
            LoggedIn = loggedIn;
        }
        public static string GetUserLogged()
        {
            return LoginName;
        }

    }
    public static class XmlTools
    {
        public static void ExportXML(List<Student> students)
        {
            var openFileDialog = new SaveFileDialog();
            openFileDialog.DefaultExt = ".xml";
            openFileDialog.Filter = "XML File | *.xml";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;

                var serializer = new XmlSerializer(typeof(List<Student>));
                var writer = new StreamWriter(path);

                serializer.Serialize(writer, students);
                writer.Close();
                GeneralTools.WarningBox("XML file created", "info");
            }
        }
    }
    public static class ValidationTool
    {
        public static string CamelCaseToWords(string input)
        {
            string result = "";
            foreach (char ch in input.ToCharArray())
            {
                if (char.IsUpper(ch)) result += " ";
                result += ch;
            }

            return result.Substring(result.IndexOf(" ") + 1);
        }

        public static bool RequiredFieldIsBlank(ErrorProvider err, TextBox txt)
        {

            if (txt.Text.Length > 0)
            {
                // Clear the error.
                err.SetError(txt, "");
                return false;
            }
            else
            {
                // Set the error.
                err.SetError(txt, txt.Name +
                    " must not be blank.");
                return true;
            }
        }

        public static bool EmailAddressIsWrong(ErrorProvider err, TextBox txt)
        {

            if (txt.Text.Trim() == string.Empty)
            {
                err.SetError(txt, txt.Name + " must not be blank.");
                return true;
            }
            else if(GeneralTools.IsValidEmailAddress(txt.Text)) 
            {
                // Clear the error.
                err.SetError(txt, "");
                return false;
            }
            else
            {
                // Set the error.
                err.SetError(txt, txt.Text + " not a valid email address!");
                return true;
            }
        }
    }
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

        public static bool IsValidEmailAddress(string emailaddress)
        {
            return Regex.IsMatch(emailaddress, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
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
