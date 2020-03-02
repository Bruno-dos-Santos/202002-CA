namespace collegium
{
    partial class FormHistoryLog
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
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
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
            this.dgHistoryLog.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgHistoryLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHistoryLog.Location = new System.Drawing.Point(0, 158);
            this.dgHistoryLog.Name = "dgHistoryLog";
            this.dgHistoryLog.ReadOnly = true;
            this.dgHistoryLog.RowHeadersWidth = 62;
            this.dgHistoryLog.RowTemplate.Height = 28;
            this.dgHistoryLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHistoryLog.Size = new System.Drawing.Size(1278, 480);
            this.dgHistoryLog.TabIndex = 0;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.btnExit);
            this.pnlFilter.Controls.Add(this.btnFilter);
            this.pnlFilter.Controls.Add(this.btClean);
            this.pnlFilter.Controls.Add(this.cmbTable);
            this.pnlFilter.Controls.Add(this.cmbOperation);
            this.pnlFilter.Controls.Add(this.cmbType);
            this.pnlFilter.Controls.Add(this.txtLogin);
            this.pnlFilter.Controls.Add(this.lblType);
            this.pnlFilter.Controls.Add(this.label2);
            this.pnlFilter.Controls.Add(this.label1);
            this.pnlFilter.Controls.Add(this.lblLogin);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1278, 158);
            this.pnlFilter.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(548, 120);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(548, 87);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(88, 24);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "&Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btClean
            // 
            this.btClean.Location = new System.Drawing.Point(548, 55);
            this.btClean.Name = "btClean";
            this.btClean.Size = new System.Drawing.Size(88, 24);
            this.btClean.TabIndex = 11;
            this.btClean.Text = "&Clean";
            this.btClean.UseVisualStyleBackColor = true;
            this.btClean.Click += new System.EventHandler(this.btClean_Click);
            // 
            // cmbTable
            // 
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Items.AddRange(new object[] {
            "All",
            "Students",
            "Users"});
            this.cmbTable.Location = new System.Drawing.Point(140, 124);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(280, 24);
            this.cmbTable.TabIndex = 7;
            this.cmbTable.Text = "All";
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "All"});
            this.cmbOperation.Location = new System.Drawing.Point(140, 90);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(280, 24);
            this.cmbOperation.TabIndex = 6;
            this.cmbOperation.Text = "All";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "All",
            "Info",
            "Error"});
            this.cmbType.Location = new System.Drawing.Point(140, 56);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(280, 24);
            this.cmbType.TabIndex = 5;
            this.cmbType.Tag = "";
            this.cmbType.Text = "All";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(140, 24);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(280, 22);
            this.txtLogin.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(4, 63);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(40, 17);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(4, 28);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 17);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login: ";
            // 
            // FormHistoryLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 638);
            this.Controls.Add(this.dgHistoryLog);
            this.Controls.Add(this.pnlFilter);
            this.Name = "FormHistoryLog";
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
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.ComboBox cmbOperation;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btClean;
    }
}