using System.Windows.Forms;

namespace SSDCoursework
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lstGender = new System.Windows.Forms.ListBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.rdoAdmin = new System.Windows.Forms.RadioButton();
            this.datDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAdmin = new System.Windows.Forms.Label();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(3, 433);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(194, 89);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Tag = "Pass";
            this.lblPassword.Text = "Password";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(521, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(144, 109);
            this.lblGender.TabIndex = 6;
            this.lblGender.Tag = "Gender";
            this.lblGender.Text = " Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(668, 440);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(232, 74);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Black;
            this.lblUsername.Location = new System.Drawing.Point(3, 215);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(194, 109);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Tag = "Username";
            this.lblUsername.Text = "Username";
            // 
            // txtFirstName
            // 
            this.txtFirstName.CausesValidation = false;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtFirstName.Location = new System.Drawing.Point(203, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(312, 49);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "FirstName";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(3, 109);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(194, 106);
            this.lblSurname.TabIndex = 1;
            this.lblSurname.Tag = "Surname";
            this.lblSurname.Text = "Surname";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtUsername.Location = new System.Drawing.Point(203, 221);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(312, 49);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Tag = "Username";
            // 
            // txtSurname
            // 
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtSurname.Location = new System.Drawing.Point(203, 115);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(312, 49);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Tag = "Surname";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(194, 109);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Tag = "FirstName";
            this.lblFirstName.Text = "First name";
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtPassword.Location = new System.Drawing.Point(203, 439);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(312, 49);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Tag = "Pass";
            // 
            // tlp
            // 
            this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(235)))), ((int)(((byte)(216)))));
            this.tlp.ColumnCount = 4;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Controls.Add(this.txtEmail, 1, 3);
            this.tlp.Controls.Add(this.lblEmail, 0, 3);
            this.tlp.Controls.Add(this.lblFirstName, 0, 0);
            this.tlp.Controls.Add(this.txtSurname, 1, 1);
            this.tlp.Controls.Add(this.txtUsername, 1, 2);
            this.tlp.Controls.Add(this.lblSurname, 0, 1);
            this.tlp.Controls.Add(this.txtFirstName, 1, 0);
            this.tlp.Controls.Add(this.lblUsername, 0, 2);
            this.tlp.Controls.Add(this.lstGender, 3, 0);
            this.tlp.Controls.Add(this.txtPassword, 1, 4);
            this.tlp.Controls.Add(this.lblGender, 2, 0);
            this.tlp.Controls.Add(this.lblDOB, 2, 1);
            this.tlp.Controls.Add(this.rdoAdmin, 3, 2);
            this.tlp.Controls.Add(this.datDOB, 3, 1);
            this.tlp.Controls.Add(this.lblPassword, 0, 4);
            this.tlp.Controls.Add(this.txtAdmin, 2, 2);
            this.tlp.Controls.Add(this.btnConfirm, 3, 4);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 5;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.05263F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46783F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.90643F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.90643F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp.Size = new System.Drawing.Size(900, 522);
            this.tlp.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(105)))));
            this.txtEmail.Location = new System.Drawing.Point(203, 330);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(312, 49);
            this.txtEmail.TabIndex = 17;
            this.txtEmail.Tag = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(3, 324);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(194, 109);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Tag = "Email";
            this.lblEmail.Text = "Email";
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
            this.lstGender.Location = new System.Drawing.Point(671, 3);
            this.lstGender.Name = "lstGender";
            this.lstGender.Size = new System.Drawing.Size(211, 4);
            this.lstGender.TabIndex = 11;
            this.lstGender.Tag = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(521, 109);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(144, 106);
            this.lblDOB.TabIndex = 14;
            this.lblDOB.Tag = "DOB";
            this.lblDOB.Text = "Date of birth";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.AutoCheck = false;
            this.rdoAdmin.AutoSize = true;
            this.rdoAdmin.Location = new System.Drawing.Point(671, 218);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Padding = new System.Windows.Forms.Padding(70, 11, 30, 30);
            this.rdoAdmin.Size = new System.Drawing.Size(114, 54);
            this.rdoAdmin.TabIndex = 12;
            this.rdoAdmin.Tag = "Admin";
            this.rdoAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoAdmin.UseVisualStyleBackColor = true;
            this.rdoAdmin.Click += new System.EventHandler(this.RdoAdmin_Click);
            // 
            // datDOB
            // 
            this.datDOB.CalendarFont = new System.Drawing.Font("Corbel", 18F);
            this.datDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datDOB.Location = new System.Drawing.Point(671, 112);
            this.datDOB.MaxDate = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            this.datDOB.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.datDOB.Name = "datDOB";
            this.datDOB.Size = new System.Drawing.Size(211, 49);
            this.datDOB.TabIndex = 15;
            this.datDOB.Value = new System.DateTime(2024, 12, 9, 0, 0, 0, 0);
            // 
            // txtAdmin
            // 
            this.txtAdmin.AutoSize = true;
            this.txtAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmin.ForeColor = System.Drawing.Color.Black;
            this.txtAdmin.Location = new System.Drawing.Point(521, 215);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(144, 109);
            this.txtAdmin.TabIndex = 7;
            this.txtAdmin.Tag = "Admin";
            this.txtAdmin.Text = "Admin";
            this.txtAdmin.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.tlp);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(916, 561);
            this.Name = "SignUp";
            this.Tag = "childForm";
            this.Text = "Sign Up";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private DateTimePicker datDOB;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}