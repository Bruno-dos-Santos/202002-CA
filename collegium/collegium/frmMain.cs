﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer.Operations;


namespace collegium
{
    public partial class frmMain : Form
    {
        GeneralTools generalTools = new GeneralTools(); 
        public frmMain()
        {
            InitializeComponent();
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
            if (generalTools.confirmationBox("confirm?")) 
            {
                Application.Exit();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setTsUserName("bruno");
            setTsFrmName();
        }
        private void setTsUserName(string userName)
        {
            tsUserName.Text = userName;
        }
        private void setTsFrmName(string frmName = "frmMain")
        {
            tsFrmName.Text = frmName;
        }

        private void viewDatabaseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setTsFrmName("frmHistoryLog");
            frmHistoryLog obj = new frmHistoryLog();
            obj.ShowDialog();
            setTsFrmName();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
