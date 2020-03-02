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
    public partial class frmHistoryLog : Form
    {
        LogRepository logRepository = new LogRepository();
        public frmHistoryLog()
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
            DataTable dt = logRepository.RefreshGrid();
                        
            dgHistoryLog.DataSource = dt;
            dgHistoryLog.Refresh();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            refreshGrip();
        }
    }
}
