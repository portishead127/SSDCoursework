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
            this.lstGender = new System.Windows.Forms.ListBox();
            this.lblExplain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtEmail.Location = new System.Drawing.Point(151, 151);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(642, 49);
            this.txtEmail.TabIndex = 34;
            this.txtEmail.Tag = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(35, 151);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 42);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Tag = "Email";
            this.lblEmail.Text = "Email";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(26, 320);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(193, 42);
            this.lblFirstName.TabIndex = 19;
            this.lblFirstName.Tag = "FirstName";
            this.lblFirstName.Text = "First name";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtSurname.Location = new System.Drawing.Point(224, 379);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(381, 49);
            this.txtSurname.TabIndex = 20;
            this.txtSurname.Tag = "Surname";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtUsername.Location = new System.Drawing.Point(224, 24);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(569, 49);
            this.txtUsername.TabIndex = 24;
            this.txtUsername.Tag = "Username";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(26, 386);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(169, 42);
            this.lblSurname.TabIndex = 21;
            this.lblSurname.Tag = "Surname";
            this.lblSurname.Text = "Surname";
            // 
            // txtFirstName
            // 
            this.txtFirstName.CausesValidation = false;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtFirstName.Location = new System.Drawing.Point(225, 320);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(380, 49);
            this.txtFirstName.TabIndex = 18;
            this.txtFirstName.Tag = "FirstName";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(35, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(190, 42);
            this.lblUsername.TabIndex = 22;
            this.lblUsername.Tag = "Username";
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtPassword.Location = new System.Drawing.Point(225, 87);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(568, 49);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.Tag = "Pass";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(35, 479);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(143, 42);
            this.lblGender.TabIndex = 26;
            this.lblGender.Tag = "Gender";
            this.lblGender.Text = "Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.White;
            this.lblDOB.Location = new System.Drawing.Point(35, 539);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(220, 42);
            this.lblDOB.TabIndex = 31;
            this.lblDOB.Tag = "DOB";
            this.lblDOB.Text = "Date of birth";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoCheck = false;
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(491, 654);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoAdmin.Size = new System.Drawing.Size(114, 54);
            this.rdoAdmin.TabIndex = 30;
            this.rdoAdmin.Tag = "Admin";
            this.rdoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAdmin.UseVisualStyleBackColor = true;
            // 
            // datDOB
            // 
            this.datDOB.CalendarFont = new System.Drawing.Font("Corbel", 18F);
            this.datDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDOB.Location = new System.Drawing.Point(261, 539);
            this.datDOB.MaxDate = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            this.datDOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.datDOB.Name = "datDOB";
            this.datDOB.Size = new System.Drawing.Size(344, 49);
            this.datDOB.TabIndex = 32;
            this.datDOB.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(35, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(183, 42);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Tag = "Pass";
            this.lblPassword.Text = "Password";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.White;
            this.lblAdmin.Location = new System.Drawing.Point(35, 651);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(123, 42);
            this.lblAdmin.TabIndex = 27;
            this.lblAdmin.Tag = "Admin";
            this.lblAdmin.Text = "Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(1108, 24);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(232, 74);
            this.btnConfirm.TabIndex = 25;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // lstGender
            // 
            this.lstGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGender.ForeColor = System.Drawing.Color.Black;
            this.lstGender.FormattingEnabled = true;
            this.lstGender.ItemHeight = 42;
            this.lstGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.lstGender.Location = new System.Drawing.Point(224, 479);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(381, 46);
            this.lstGender.TabIndex = 29;
            this.lstGender.Tag = "Gender";
            // 
            // lblExplain
            // 
            this.lblExplain.BackColor = System.Drawing.Color.Silver;
            this.lblExplain.Location = new System.Drawing.Point(628, 224);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(712, 469);
            this.lblExplain.TabIndex = 35;
            this.lblExplain.Tag = "Accent2";
            this.lblExplain.Text = "label2";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(5)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.rdoAdmin);
            this.Controls.Add(this.datDOB);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lstGender);
            this.Controls.Add(this.lblExplain);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(751, 411);
            this.Name = "SignUp";
            this.Tag = "childForm";
            this.Text = "Sign Up";
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
        private ListBox lstGender;
        private Label lblExplain;
    }
}