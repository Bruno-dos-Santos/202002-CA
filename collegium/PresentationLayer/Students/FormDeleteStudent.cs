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

namespace collegium.Students
{
    public partial class FormDeleteStudent : Form
    {
        public FormDeleteStudent()
        {
            InitializeComponent();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var studentRepository = new StudentRepository();

            var studentNumber = Convert.ToInt32(txtBox_studentNumber.Text);

            studentRepository.Delete(studentNumber);

            Close();
        }
    }
}
