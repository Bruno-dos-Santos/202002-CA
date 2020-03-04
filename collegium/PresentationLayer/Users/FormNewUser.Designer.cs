namespace collegium.Users
{
    partial class FormNewUser
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_loginName = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.erProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // txt_loginName
            // 
            this.txt_loginName.Location = new System.Drawing.Point(288, 62);
            this.txt_loginName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_loginName.Name = "txt_loginName";
            this.txt_loginName.Size = new System.Drawing.Size(438, 31);
            this.txt_loginName.TabIndex = 5;
            this.txt_loginName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_loginName.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txt_loginName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(288, 125);
            this.txt_password.Margin = new System.Windows.Forms.Padding(6);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(438, 31);
            this.txt_password.TabIndex = 6;
            this.txt_password.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(288, 202);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(438, 31);
            this.txt_firstName.TabIndex = 7;
            this.txt_firstName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_firstName.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txt_firstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(288, 279);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(6);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(438, 31);
            this.txt_lastName.TabIndex = 8;
            this.txt_lastName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txt_lastName.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txt_lastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(804, 352);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(150, 44);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // erProvider
            // 
            this.erProvider.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 446);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_loginName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FormNewUser";
            this.Text = "New User";
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_loginName;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ErrorProvider erProvider;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}