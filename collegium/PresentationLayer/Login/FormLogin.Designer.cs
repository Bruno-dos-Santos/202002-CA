namespace collegium.Login
{
    partial class FormLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBox_login = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtBox_login
            // 
            this.txtBox_login.Location = new System.Drawing.Point(326, 108);
            this.txtBox_login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox_login.Name = "txtBox_login";
            this.txtBox_login.Size = new System.Drawing.Size(390, 31);
            this.txtBox_login.TabIndex = 2;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(326, 231);
            this.txtbox_password.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(390, 31);
            this.txtbox_password.TabIndex = 3;
            this.txtbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_password_KeyDown);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(356, 354);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(150, 44);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "&Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(566, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 44);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 496);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtBox_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBox_login;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btnCancel;
    }
}