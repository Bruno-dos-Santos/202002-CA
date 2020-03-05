using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BusinessLogicLayer.Operations;
using collegium.Login;
using collegium.Students;
using collegium.Users;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;

namespace collegium
{
    public partial class FormMain : Form
    {
        public List<Student> Students { get; set; }

        private StudentRepository student = new StudentRepository();

        public FormMain()
        {
            InitializeComponent();
            RefreshStudentGrid();
        }

        public void RefreshStudentGrid()
        {
            Students = student.GetAll().ToList();

            var source = new BindingSource();
            source.DataSource = Students;
            dataGridStudent.DataSource = source;
        }

        private void openForm(Form formName)
        {
            setTsFrmName(formName.Name);
            formName.ShowDialog();
            setTsFrmName();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            tsTime.Text  = DateTime.Now.ToString();
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GeneralTools.ConfirmationBox("this action will close the application, confirm?")) 
                Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setTsFrmName();
            setLoginLogoutState(LoggedInDetails.GetLoggedInState());
        }
        private void setTsUserName()
        {
            tsUserName.Text = LoggedInDetails.GetUserLogged();
        }
        private void setTsFrmName(string frmName = "FormMain")
        {
            tsFrmName.Text = frmName;
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormHistoryLog());
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormNewStudent());
            RefreshStudentGrid();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormUpdateStudent());
            RefreshStudentGrid();
        }



        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormDeleteStudent());
            RefreshStudentGrid();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormNewUser());
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openForm(new FormDeleteUser());
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!LoggedInDetails.GetLoggedInState())
            {
                // login
                openForm(new FormLogin());
            } else
            {
                //logout
                LoggedInDetails.SetLoggedInState(false);
            }

            setLoginLogoutState(LoggedInDetails.GetLoggedInState());
            setTsUserName();
        }

        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlTools.ExportXML(Students);
        }
        public void setLoginLogoutState(bool logged = true)
        {
            logoutToolStripMenuItem.Text = logged ? "Logout" : "Login";
            studentToolStripMenuItem.Visible = logged;
            utilitiesToolStripMenuItem.Visible = logged;
            dataGridStudent.Visible = logged;
            tsUserName.Visible = logged;
        }

        private void dataGridStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            openForm(new FormUpdateStudent(dataGridStudent.CurrentRow.Cells[dataGridStudent.Columns["StudentNumber"].Index].FormattedValue.ToString()));
            RefreshStudentGrid();
        }

        private void dataGridStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(GeneralTools.ConfirmationBox("Are you sure you want to delete this student?") == true)
                {
                    var studentRepository = new StudentRepository();

                    studentRepository.Delete(Convert.ToInt64(dataGridStudent.CurrentRow.Cells[dataGridStudent.Columns["StudentNumber"].Index].FormattedValue.ToString()));

                    RefreshStudentGrid();
                }
            }
        }

    }
}
