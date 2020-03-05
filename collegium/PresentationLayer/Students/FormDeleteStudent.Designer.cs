namespace collegium.Students
{
    partial class FormDeleteStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBox_studentNumber = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number";
            // 
            // txtBox_studentNumber
            // 
            this.txtBox_studentNumber.Location = new System.Drawing.Point(268, 42);
            this.txtBox_studentNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_studentNumber.Name = "txtBox_studentNumber";
            this.txtBox_studentNumber.Size = new System.Drawing.Size(292, 31);
            this.txtBox_studentNumber.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(650, 38);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 44);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "&Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // FormDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(868, 152);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txtBox_studentNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeleteStudent";
            this.Text = "Delete Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_studentNumber;
        private System.Windows.Forms.Button btn_delete;
    }
}