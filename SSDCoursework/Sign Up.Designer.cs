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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.lblGender = new System.Windows.Forms.Label();
            this.lstGender = new System.Windows.Forms.ListBox();
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
            this.lblTitle.Text = "Sign Up";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // txtSurname
            // 
            this.txtSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSurname.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(178, 105);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(364, 37);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.Tag = "Surname";
            // 
            // txtUsername
            // 
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtUsername.Location = new System.Drawing.Point(178, 201);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(364, 37);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Tag = "Username";
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
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtPassword.Location = new System.Drawing.Point(178, 299);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(364, 37);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Tag = "Pass";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.BackColor = System.Drawing.Color.PaleGreen;
            this.btnConfirm.Font = new System.Drawing.Font("Corbel", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(700, 299);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0, 0, 20, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(180, 73);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.CausesValidation = false;
            this.txtFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFirstName.Font = new System.Drawing.Font("Corbel", 18F);
            this.txtFirstName.Location = new System.Drawing.Point(178, 6);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(364, 37);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "FirstName";
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
            // tlp
            // 
            this.tlp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp.ColumnCount = 4;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp.Controls.Add(this.lblGender, 2, 0);
            this.tlp.Controls.Add(this.lblFirstName, 0, 0);
            this.tlp.Controls.Add(this.txtSurname, 1, 1);
            this.tlp.Controls.Add(this.lblPassword, 0, 3);
            this.tlp.Controls.Add(this.txtUsername, 1, 2);
            this.tlp.Controls.Add(this.lblSurname, 0, 1);
            this.tlp.Controls.Add(this.txtFirstName, 1, 0);
            this.tlp.Controls.Add(this.lblUsername, 0, 2);
            this.tlp.Controls.Add(this.txtPassword, 1, 3);
            this.tlp.Controls.Add(this.lstGender, 3, 0);
            this.tlp.Controls.Add(this.btnConfirm, 3, 3);
            this.tlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp.Font = new System.Drawing.Font("Arial Narrow", 21.75F);
            this.tlp.Location = new System.Drawing.Point(0, 130);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 4;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.26316F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.5614F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.08772F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.08772F));
            this.tlp.Size = new System.Drawing.Size(900, 392);
            this.tlp.TabIndex = 4;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Corbel", 21.75F);
            this.lblGender.Location = new System.Drawing.Point(588, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(108, 36);
            this.lblGender.TabIndex = 6;
            this.lblGender.Tag = "Gender";
            this.lblGender.Text = " Gender";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lstGender
            // 
            this.lstGender.Font = new System.Drawing.Font("Corbel", 18F);
            this.lstGender.FormattingEnabled = true;
            this.lstGender.ItemHeight = 29;
            this.lstGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other",
            "Prefer not to say"});
            this.lstGender.Location = new System.Drawing.Point(702, 3);
            this.lstGender.Name = "lstGender";
            this.lstGender.ScrollAlwaysVisible = true;
            this.lstGender.Size = new System.Drawing.Size(195, 33);
            this.lstGender.TabIndex = 7;
            this.lstGender.Tag = "Gender";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(900, 522);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(916, 561);
            this.Name = "SignUp";
            this.Tag = "childForm";
            this.Text = "SignUp";
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnConfirm;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TableLayoutPanel tlp;
        private Label lblGender;
        private ListBox lstGender;
    }
}