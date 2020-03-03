using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void refreshStudentGrid()
        {
            Students = student.GetAll().ToList();

            var source = new BindingSource();
            source.DataSource = Students;
            dataGridView1.DataSource = source;
        }

        public FormMain()
        {
            InitializeComponent();
            refreshStudentGrid();

            var formLogin = new FormLogin();

            formLogin.ShowDialog();
        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsTime.Text  = DateTime.Now.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GeneralTools.ConfirmationBox("confirm?")) 
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setTsUserName();
            setTsFrmName();
        }
        private void setTsUserName()
        {
            tsUserName.Text = GeneralTools.GetUserLogged();
        }
        private void setTsFrmName(string frmName = "FormMain")
        {
            tsFrmName.Text = frmName;
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTsFrmName("FormHistoryLog");
            FormHistoryLog obj = new FormHistoryLog();
            obj.ShowDialog();
            setTsFrmName();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newStudentForm = new FormNewStudent();
            setTsFrmName("FormNewStudent");
            newStudentForm.ShowDialog();
            setTsFrmName();
            refreshStudentGrid();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var updateStudentForm = new FormUpdateStudent();
            setTsFrmName("FormNewStudent");
            updateStudentForm.ShowDialog();
            setTsFrmName();
            refreshStudentGrid();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteStudentForm = new FormDeleteStudent();

            deleteStudentForm.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var userNewForm = new FormNewUser();

            userNewForm.Show();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteForm = new FormDeleteUser();

            deleteForm.Show();
        }
    }
}
