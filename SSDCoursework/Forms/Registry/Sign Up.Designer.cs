using System.Windows.Forms;

namespace SSDCoursework.Forms.Registry
{
    partial class SignUp
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.datDOB = new System.Windows.Forms.DateTimePicker();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.pnlExplain = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExplain2 = new System.Windows.Forms.Label();
            this.lblExplain1 = new System.Windows.Forms.Label();
            this.btnPasswordVis = new System.Windows.Forms.Button();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.pnlExplain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtEmail.Location = new System.Drawing.Point(224, 727);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(627, 38);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Tag = "Email ButtonAccent";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEmail.BackColor = System.Drawing.Color.Silver;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblEmail.Location = new System.Drawing.Point(13, 727);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(195, 42);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Tag = "Email ButtonAccent";
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Silver;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Gray;
            this.lblFirstName.Location = new System.Drawing.Point(13, 25);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(220, 42);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Tag = "FirstName ButtonAccent";
            this.lblFirstName.Text = "First name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtSurname.Location = new System.Drawing.Point(248, 96);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(602, 38);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Tag = "Surname ButtonAccent";
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtUsername.Location = new System.Drawing.Point(224, 589);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(626, 38);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.Tag = "Username ButtonAccent";
            // 
            // lblSurname
            // 
            this.lblSurname.BackColor = System.Drawing.Color.Silver;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Gray;
            this.lblSurname.Location = new System.Drawing.Point(13, 91);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(220, 42);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Tag = "Surname ButtonAccent";
            this.lblSurname.Text = "Surname";
            this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstName
            // 
            this.txtFirstName.CausesValidation = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtFirstName.Location = new System.Drawing.Point(248, 30);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(601, 38);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "FirstName ButtonAccent";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblUsername.BackColor = System.Drawing.Color.Silver;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Gray;
            this.lblUsername.Location = new System.Drawing.Point(13, 589);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(195, 42);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Tag = "Username ButtonAccent";
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtPassword.Location = new System.Drawing.Point(224, 663);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(587, 38);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.Tag = "Pass ButtonAccent";
            // 
            // lblGender
            // 
            this.lblGender.BackColor = System.Drawing.Color.Silver;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Gray;
            this.lblGender.Location = new System.Drawing.Point(13, 181);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(220, 42);
            this.lblGender.TabIndex = 26;
            this.lblGender.Tag = "Gender ButtonAccent";
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDOB
            // 
            this.lblDOB.BackColor = System.Drawing.Color.Silver;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Gray;
            this.lblDOB.Location = new System.Drawing.Point(13, 244);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(220, 42);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Tag = "DOB ButtonAccent";
            this.lblDOB.Text = "Date of birth";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoCheck = false;
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoAdmin.Location = new System.Drawing.Point(248, 307);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoAdmin.Size = new System.Drawing.Size(114, 54);
            this.rdoAdmin.TabIndex = 5;
            this.rdoAdmin.Tag = "Admin";
            this.rdoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.Click += new System.EventHandler(this.RdoAdmin_Click);
            // 
            // datDOB
            // 
            this.datDOB.CalendarFont = new System.Drawing.Font("Corbel", 18F);
            this.datDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDOB.Location = new System.Drawing.Point(248, 246);
            this.datDOB.MaxDate = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            this.datDOB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datDOB.Name = "datDOB";
            this.datDOB.Size = new System.Drawing.Size(602, 38);
            this.datDOB.TabIndex = 3;
            this.datDOB.Tag = "";
            this.datDOB.Value = new System.DateTime(2013, 1, 1, 0, 0, 0, 0);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassword.BackColor = System.Drawing.Color.Silver;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblPassword.Location = new System.Drawing.Point(12, 658);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(195, 42);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Tag = "Pass ButtonAccent";
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.Silver;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Gray;
            this.lblAdmin.Location = new System.Drawing.Point(13, 307);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(220, 42);
            this.lblAdmin.TabIndex = 27;
            this.lblAdmin.Tag = "Admin ButtonAccent";
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(1129, 636);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(245, 85);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Tag = "ButtonAccent";
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // pnlExplain
            // 
            this.pnlExplain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlExplain.BackColor = System.Drawing.Color.Silver;
            this.pnlExplain.Controls.Add(this.label4);
            this.pnlExplain.Controls.Add(this.label3);
            this.pnlExplain.Controls.Add(this.label2);
            this.pnlExplain.Controls.Add(this.label1);
            this.pnlExplain.Controls.Add(this.lblExplain2);
            this.pnlExplain.Controls.Add(this.lblExplain1);
            this.pnlExplain.Location = new System.Drawing.Point(1099, 12);
            this.pnlExplain.Name = "pnlExplain";
            this.pnlExplain.Size = new System.Drawing.Size(275, 319);
            this.pnlExplain.TabIndex = 35;
            this.pnlExplain.Tag = "ButtonAccent";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "(Not all email domains will be accepted)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "- At least one number";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "- At least one special character\r\n";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "- At least one capital";
            // 
            // lblExplain2
            // 
            this.lblExplain2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplain2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain2.Location = new System.Drawing.Point(3, 114);
            this.lblExplain2.Name = "lblExplain2";
            this.lblExplain2.Size = new System.Drawing.Size(413, 27);
            this.lblExplain2.TabIndex = 1;
            this.lblExplain2.Text = "Passwords must contain:";
            // 
            // lblExplain1
            // 
            this.lblExplain1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExplain1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExplain1.Location = new System.Drawing.Point(3, 18);
            this.lblExplain1.Name = "lblExplain1";
            this.lblExplain1.Size = new System.Drawing.Size(284, 40);
            this.lblExplain1.TabIndex = 0;
            this.lblExplain1.Text = "Username and password entries must be between 5 and 25 characters long.";
            // 
            // btnPasswordVis
            // 
            this.btnPasswordVis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPasswordVis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasswordVis.Location = new System.Drawing.Point(816, 662);
            this.btnPasswordVis.Name = "btnPasswordVis";
            this.btnPasswordVis.Size = new System.Drawing.Size(33, 37);
            this.btnPasswordVis.TabIndex = 8;
            this.btnPasswordVis.Tag = "ButtonAccent";
            this.btnPasswordVis.Text = "*";
            this.btnPasswordVis.UseVisualStyleBackColor = true;
            this.btnPasswordVis.Click += new System.EventHandler(this.btnPasswordVis_Click);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.cmbGender.Location = new System.Drawing.Point(248, 183);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(602, 39);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Tag = "exempt";
            // 
            // SignUp
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.btnPasswordVis);
            this.Controls.Add(this.pnlExplain);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.datDOB);
            this.Controls.Add(this.lblAdmin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "MainColour";
            this.Text = "Sign Up";
            this.pnlExplain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblFirstName;
        private TextBox txtSurname;
        private TextBox txtUsername;
        private Label lblSurname;
        private TextBox txtFirstName;
        private Label lblUsername;
        private TextBox txtPassword;
        private Label lblGender;
        private Label lblDOB;
        private RadioButton rdoAdmin;
        private DateTimePicker datDOB;
        private Label lblPassword;
        private Label lblAdmin;
        private Button btnConfirm;
        private Panel pnlExplain;
        private Label lblExplain2;
        private Label lblExplain1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnPasswordVis;
        private ComboBox cmbGender;
    }
}