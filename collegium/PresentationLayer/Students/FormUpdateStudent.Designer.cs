﻿namespace collegium.Students
{
    partial class FormUpdateStudent
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
            this.grBox = new System.Windows.Forms.GroupBox();
            this.radButton_undergrade = new System.Windows.Forms.RadioButton();
            this.radButton_postgrade = new System.Windows.Forms.RadioButton();
            this.btn_SaveStudent = new System.Windows.Forms.Button();
            this.txtBox_studentNumber = new System.Windows.Forms.TextBox();
            this.txtBox_city = new System.Windows.Forms.TextBox();
            this.txtBox_addressLine2 = new System.Windows.Forms.TextBox();
            this.txtBox_addressLine1 = new System.Windows.Forms.TextBox();
            this.txtBox_email = new System.Windows.Forms.TextBox();
            this.txtBox_surname = new System.Windows.Forms.TextBox();
            this.txtBox_firstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.studentNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.cmbCounty = new System.Windows.Forms.ComboBox();
            this.erProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtBox_phone = new System.Windows.Forms.MaskedTextBox();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.radButton_undergrade);
            this.grBox.Controls.Add(this.radButton_postgrade);
            this.grBox.Location = new System.Drawing.Point(148, 541);
            this.grBox.Margin = new System.Windows.Forms.Padding(6);
            this.grBox.Name = "grBox";
            this.grBox.Padding = new System.Windows.Forms.Padding(6);
            this.grBox.Size = new System.Drawing.Size(992, 73);
            this.grBox.TabIndex = 9;
            this.grBox.TabStop = false;
            this.grBox.Text = "Level";
            // 
            // radButton_undergrade
            // 
            this.radButton_undergrade.AutoSize = true;
            this.radButton_undergrade.Location = new System.Drawing.Point(506, 30);
            this.radButton_undergrade.Margin = new System.Windows.Forms.Padding(6);
            this.radButton_undergrade.Name = "radButton_undergrade";
            this.radButton_undergrade.Size = new System.Drawing.Size(144, 29);
            this.radButton_undergrade.TabIndex = 1;
            this.radButton_undergrade.TabStop = true;
            this.radButton_undergrade.Text = "Undergrad";
            this.radButton_undergrade.UseVisualStyleBackColor = true;
            // 
            // radButton_postgrade
            // 
            this.radButton_postgrade.AutoSize = true;
            this.radButton_postgrade.Location = new System.Drawing.Point(114, 30);
            this.radButton_postgrade.Margin = new System.Windows.Forms.Padding(6);
            this.radButton_postgrade.Name = "radButton_postgrade";
            this.radButton_postgrade.Size = new System.Drawing.Size(129, 29);
            this.radButton_postgrade.TabIndex = 0;
            this.radButton_postgrade.TabStop = true;
            this.radButton_postgrade.Text = "Postgrad";
            this.radButton_postgrade.UseVisualStyleBackColor = true;
            // 
            // btn_SaveStudent
            // 
            this.btn_SaveStudent.Location = new System.Drawing.Point(990, 770);
            this.btn_SaveStudent.Margin = new System.Windows.Forms.Padding(6);
            this.btn_SaveStudent.Name = "btn_SaveStudent";
            this.btn_SaveStudent.Size = new System.Drawing.Size(150, 44);
            this.btn_SaveStudent.TabIndex = 12;
            this.btn_SaveStudent.Text = "&Update";
            this.btn_SaveStudent.UseVisualStyleBackColor = true;
            this.btn_SaveStudent.Click += new System.EventHandler(this.btn_SaveStudent_Click);
            // 
            // txtBox_studentNumber
            // 
            this.txtBox_studentNumber.Enabled = false;
            this.txtBox_studentNumber.Location = new System.Drawing.Point(324, 698);
            this.txtBox_studentNumber.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_studentNumber.Name = "txtBox_studentNumber";
            this.txtBox_studentNumber.Size = new System.Drawing.Size(816, 31);
            this.txtBox_studentNumber.TabIndex = 11;
            this.txtBox_studentNumber.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_studentNumber.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_studentNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txtBox_city
            // 
            this.txtBox_city.Location = new System.Drawing.Point(324, 391);
            this.txtBox_city.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_city.Name = "txtBox_city";
            this.txtBox_city.Size = new System.Drawing.Size(816, 31);
            this.txtBox_city.TabIndex = 7;
            this.txtBox_city.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_city.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_city.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txtBox_addressLine2
            // 
            this.txtBox_addressLine2.Location = new System.Drawing.Point(324, 345);
            this.txtBox_addressLine2.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_addressLine2.Name = "txtBox_addressLine2";
            this.txtBox_addressLine2.Size = new System.Drawing.Size(816, 31);
            this.txtBox_addressLine2.TabIndex = 6;
            this.txtBox_addressLine2.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_addressLine2.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_addressLine2.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txtBox_addressLine1
            // 
            this.txtBox_addressLine1.Location = new System.Drawing.Point(324, 300);
            this.txtBox_addressLine1.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_addressLine1.Name = "txtBox_addressLine1";
            this.txtBox_addressLine1.Size = new System.Drawing.Size(816, 31);
            this.txtBox_addressLine1.TabIndex = 5;
            this.txtBox_addressLine1.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_addressLine1.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_addressLine1.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txtBox_email
            // 
            this.txtBox_email.Location = new System.Drawing.Point(324, 208);
            this.txtBox_email.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_email.Name = "txtBox_email";
            this.txtBox_email.Size = new System.Drawing.Size(816, 31);
            this.txtBox_email.TabIndex = 3;
            this.txtBox_email.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_email.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_email.Validating += new System.ComponentModel.CancelEventHandler(this.validEmail);
            // 
            // txtBox_surname
            // 
            this.txtBox_surname.Enabled = false;
            this.txtBox_surname.Location = new System.Drawing.Point(324, 158);
            this.txtBox_surname.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_surname.Name = "txtBox_surname";
            this.txtBox_surname.Size = new System.Drawing.Size(816, 31);
            this.txtBox_surname.TabIndex = 2;
            this.txtBox_surname.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_surname.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_surname.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // txtBox_firstName
            // 
            this.txtBox_firstName.Enabled = false;
            this.txtBox_firstName.Location = new System.Drawing.Point(324, 108);
            this.txtBox_firstName.Margin = new System.Windows.Forms.Padding(6);
            this.txtBox_firstName.Name = "txtBox_firstName";
            this.txtBox_firstName.Size = new System.Drawing.Size(816, 31);
            this.txtBox_firstName.TabIndex = 1;
            this.txtBox_firstName.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_firstName.Leave += new System.EventHandler(this.txtBox_Leave);
            this.txtBox_firstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 648);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 717);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 38;
            this.label10.Text = "Student Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Address Line 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 458);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "County";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Address Line 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 258);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(144, 108);
            this.lbl_StudentName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(116, 25);
            this.lbl_StudentName.TabIndex = 30;
            this.lbl_StudentName.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 25);
            this.label11.TabIndex = 53;
            this.label11.Text = "Student Number";
            // 
            // studentNumber
            // 
            this.studentNumber.Location = new System.Drawing.Point(324, 25);
            this.studentNumber.Margin = new System.Windows.Forms.Padding(6);
            this.studentNumber.Name = "studentNumber";
            this.studentNumber.Size = new System.Drawing.Size(816, 31);
            this.studentNumber.TabIndex = 0;
            this.studentNumber.TextChanged += new System.EventHandler(this.studentNumber_TextChanged);
            this.studentNumber.Enter += new System.EventHandler(this.txtBox_Enter);
            this.studentNumber.Leave += new System.EventHandler(this.txtBox_Leave);
            this.studentNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtBox_notEmpty);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1428, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 16);
            this.button1.TabIndex = 55;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbCourse
            // 
            this.cmbCourse.Enabled = false;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Business",
            "Arts",
            "Software Development",
            "Marketing",
            "Accounting",
            "Psychotherapy",
            "Information Technology",
            "Law",
            "Journalism"});
            this.cmbCourse.Location = new System.Drawing.Point(324, 645);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(816, 33);
            this.cmbCourse.TabIndex = 10;
            this.cmbCourse.Text = "Law";
            this.cmbCourse.Enter += new System.EventHandler(this.txtBox_Enter);
            this.cmbCourse.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // cmbCounty
            // 
            this.cmbCounty.FormattingEnabled = true;
            this.cmbCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry (Londonderry)",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois (Queens)",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Meath",
            "Monaghan",
            "Offaly (Kings)",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cmbCounty.Location = new System.Drawing.Point(324, 455);
            this.cmbCounty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCounty.Name = "cmbCounty";
            this.cmbCounty.Size = new System.Drawing.Size(816, 33);
            this.cmbCounty.TabIndex = 8;
            this.cmbCounty.Text = "Dublin";
            this.cmbCounty.Enter += new System.EventHandler(this.txtBox_Enter);
            this.cmbCounty.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // erProvider
            // 
            this.erProvider.ContainerControl = this;
            // 
            // txtBox_phone
            // 
            this.txtBox_phone.Location = new System.Drawing.Point(324, 255);
            this.txtBox_phone.Mask = "(90) 000-0000";
            this.txtBox_phone.Name = "txtBox_phone";
            this.txtBox_phone.Size = new System.Drawing.Size(816, 31);
            this.txtBox_phone.TabIndex = 4;
            this.txtBox_phone.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBox_phone.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // FormUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1206, 841);
            this.Controls.Add(this.txtBox_phone);
            this.Controls.Add(this.cmbCourse);
            this.Controls.Add(this.cmbCounty);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studentNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.btn_SaveStudent);
            this.Controls.Add(this.txtBox_studentNumber);
            this.Controls.Add(this.txtBox_city);
            this.Controls.Add(this.txtBox_addressLine2);
            this.Controls.Add(this.txtBox_addressLine1);
            this.Controls.Add(this.txtBox_email);
            this.Controls.Add(this.txtBox_surname);
            this.Controls.Add(this.txtBox_firstName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_StudentName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUpdateStudent";
            this.Text = "Update Student Info";
            this.Load += new System.EventHandler(this.FormUpdateStudent_Load);
            this.Enter += new System.EventHandler(this.txtBox_Enter);
            this.Leave += new System.EventHandler(this.txtBox_Leave);
            this.grBox.ResumeLayout(false);
            this.grBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.RadioButton radButton_undergrade;
        private System.Windows.Forms.RadioButton radButton_postgrade;
        private System.Windows.Forms.Button btn_SaveStudent;
        private System.Windows.Forms.TextBox txtBox_studentNumber;
        private System.Windows.Forms.TextBox txtBox_city;
        private System.Windows.Forms.TextBox txtBox_addressLine2;
        private System.Windows.Forms.TextBox txtBox_addressLine1;
        private System.Windows.Forms.TextBox txtBox_email;
        private System.Windows.Forms.TextBox txtBox_surname;
        private System.Windows.Forms.TextBox txtBox_firstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox studentNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.ComboBox cmbCounty;
        private System.Windows.Forms.ErrorProvider erProvider;
        private System.Windows.Forms.MaskedTextBox txtBox_phone;
    }
}