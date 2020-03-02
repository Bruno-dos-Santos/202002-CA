using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository;

namespace collegium
{
    public partial class FormHistoryLog : Form
    {
        LogRepository logRepository = new LogRepository();
        public FormHistoryLog()
        {
            InitializeComponent();

            refreshGrip();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            refreshGrip();
        }

        private void refreshGrip()
        {
            DataTable dt = logRepository.RefreshGrid(txtLogin.Text, cmbType.Text, cmbOperation.Text, cmbTable.Text);
                        
            dgHistoryLog.DataSource = dt;
            dgHistoryLog.Refresh();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            cmbOperation.Text = "All";
            cmbTable.Text = "All";
            cmbType.Text = "All";
            refreshGrip();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
