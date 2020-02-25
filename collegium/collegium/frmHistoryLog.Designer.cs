﻿namespace collegium
{
    partial class frmHistoryLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgHistoryLog = new System.Windows.Forms.DataGridView();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btClean = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryLog)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgHistoryLog
            // 
            this.dgHistoryLog.AllowUserToAddRows = false;
            this.dgHistoryLog.AllowUserToDeleteRows = false;
            this.dgHistoryLog.AllowUserToOrderColumns = true;
            this.dgHistoryLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHistoryLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistoryLog.Location = new System.Drawing.Point(0, 0);
            this.dgHistoryLog.Name = "dgHistoryLog";
            this.dgHistoryLog.ReadOnly = true;
            this.dgHistoryLog.RowHeadersWidth = 62;
            this.dgHistoryLog.RowTemplate.Height = 28;
            this.dgHistoryLog.Size = new System.Drawing.Size(1488, 770);
            this.dgHistoryLog.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnExit);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btClean);
            this.pnlFilter.Controls.Add(this.comboBox3);
            this.pnlFilter.Controls.Add(this.comboBox2);
            this.pnlFilter.Controls.Add(this.comboBox1);
            this.pnlFilter.Controls.Add(this.textBox1);
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.lblLogin);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1488, 212);
            this.pnlFilter.TabIndex = 1;
            this.pnlFilter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlFilter_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1259, 154);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 29);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1259, 113);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(99, 29);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(1259, 73);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(99, 30);
            this.btClean.TabIndex = 8;
            this.btClean.Text = "&Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "All",
            "Students",
            "Users"});
            this.comboBox3.Location = new System.Drawing.Point(157, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(314, 28);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.Text = "All";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(157, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(314, 28);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.Text = "All";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Info",
            "Error"});
            this.comboBox1.Location = new System.Drawing.Point(157, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "All";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 26);
            this.textBox1.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 78);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(4, 36);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(56, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login: ";
            // 
            // frmHistoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 770);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.dgHistoryLog);
            this.Name = "frmHistoryLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View Database History";
            ((System.ComponentModel.ISupportInitialize)(this.dgHistoryLog)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHistoryLog;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btClean;
        private System.Windows.Forms.Button btnExit;
    }
}