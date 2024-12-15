using System.Windows.Forms;

namespace SSDCoursework
{
    partial class Login
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 130);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Login";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblPassword.Location = new System.Drawing.Point(3, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(169, 99);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Tag = "Pass";
            this.lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblGender.Location = new System.Drawing.Point(552, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(108, 36);
            this.lblGender.TabIndex = 6;
            this.lblGender.Tag = "Gender";
            this.lblGender.Text = " Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(735, 306);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(145, 66);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblUsername.Location = new System.Drawing.Point(3, 195);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(169, 98);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Tag = "Username";
            this.lblUsername.Text = "Username";
            // 
            // txtFirstName
            // 
            this.txtFirstName.CausesValidation = false;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtFirstName.Location = new System.Drawing.Point(178, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(332, 37);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "FirstName";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSurname.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblSurname.Location = new System.Drawing.Point(3, 99);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(169, 96);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Tag = "Surname";
            this.lblSurname.Text = "Surname";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtUsername.Location = new System.Drawing.Point(178, 201);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(332, 37);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Tag = "Username";
            // 
            // txtSurname
            // 
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurname.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(178, 105);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(332, 37);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Tag = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(169, 99);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Tag = "FirstName";
            this.lblFirstName.Text = "First name";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtPassword.Location = new System.Drawing.Point(178, 299);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(332, 37);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Tag = "Pass";
            // 
            // tlp
            // 
            this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp.ColumnCount = 4;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Controls.Add(this.lblDOB, 2, 1);
            this.tlp.Controls.Add(this.lblFirstName, 0, 0);
            this.tlp.Controls.Add(this.txtSurname, 1, 1);
            this.tlp.Controls.Add(this.txtUsername, 1, 2);
            this.tlp.Controls.Add(this.lblSurname, 0, 1);
            this.tlp.Controls.Add(this.txtFirstName, 1, 0);
            this.tlp.Controls.Add(this.lblUsername, 0, 2);
            this.tlp.Controls.Add(this.btnConfirm, 3, 3);
            this.tlp.Controls.Add(this.lstGender, 3, 0);
            this.tlp.Controls.Add(this.txtPassword, 1, 3);
            this.tlp.Controls.Add(this.lblPassword, 0, 3);
            this.tlp.Controls.Add(this.lblGender, 2, 0);
            this.tlp.Controls.Add(this.txtAdmin, 2, 2);
            this.tlp.Controls.Add(this.rdoAdmin, 3, 2);
            this.tlp.Controls.Add(this.dateTimePicker1, 3, 1);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.tlp.Location = new System.Drawing.Point(0, 130);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 4;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26316F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5614F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.08772F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.08772F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(900, 392);
            this.tlp.TabIndex = 4;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblDOB.Location = new System.Drawing.Point(558, 99);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(102, 72);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Tag = "DOB";
            this.lblDOB.Text = "Date of birth";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstGender
            // 
            this.lstGender.Font = new System.Drawing.Font("Corbel", 18F);
            this.lstGender.FormattingEnabled = true;
            this.lstGender.ItemHeight = 29;
            this.lstGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer not to say"});
            this.lstGender.Location = new System.Drawing.Point(666, 3);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(211, 33);
            this.lstGender.TabIndex = 11;
            this.lstGender.Tag = "Gender";
            // 
            // txtAdmin
            // 
            this.txtAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.txtAdmin.Location = new System.Drawing.Point(565, 195);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(95, 36);
            this.txtAdmin.TabIndex = 7;
            this.txtAdmin.Tag = "Admin";
            this.txtAdmin.Text = "Admin";
            this.txtAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoCheck = false;
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(666, 198);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoAdmin.Size = new System.Drawing.Size(114, 54);
            this.rdoAdmin.TabIndex = 12;
            this.rdoAdmin.Tag = "Admin";
            this.rdoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.Click += new System.EventHandler(this.RdoAdmin_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Corbel", 18F);
            this.dateTimePicker1.Location = new System.Drawing.Point(666, 102);
            this.dateTimePicker1.MaxDate = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(231, 41);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(916, 561);
            this.Name = "Login";
            this.Tag = "childForm";
            this.Text = "SignUp";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTitle;
        private Label lblPassword;
        private Label lblGender;
        private Button btnConfirm;
        private Label lblUsername;
        private TextBox txtFirstName;
        private Label lblSurname;
        private TextBox txtUsername;
        private TextBox txtSurname;
        private Label lblFirstName;
        private TextBox txtPassword;
        private TableLayoutPanel tlp;
        private ListBox lstGender;
        private Label txtAdmin;
        private RadioButton rdoAdmin;
        private Label lblDOB;
        private DateTimePicker dateTimePicker1;
    }
}