namespace SSDCoursework.Forms.MainMenu
{
    partial class AdminOptions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDomains = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExample = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckbTFAnswer = new System.Windows.Forms.CheckBox();
            this.txtTFQuestionTerm = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFakeAnswer2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFakeAnswer1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWrittenAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.txtQuestionTerm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlChangePass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desired password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Location = new System.Drawing.Point(535, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "ButtonAccent";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(380, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 5;
            this.button1.Tag = "ButtonAccent";
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlChangePass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChangePass.Controls.Add(this.lstUsers);
            this.pnlChangePass.Controls.Add(this.button5);
            this.pnlChangePass.Controls.Add(this.button1);
            this.pnlChangePass.Controls.Add(this.button7);
            this.pnlChangePass.Controls.Add(this.txtPassword);
            this.pnlChangePass.Controls.Add(this.textBox2);
            this.pnlChangePass.Controls.Add(this.label1);
            this.pnlChangePass.Controls.Add(this.label9);
            this.pnlChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChangePass.Location = new System.Drawing.Point(0, 0);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(1386, 146);
            this.pnlChangePass.TabIndex = 6;
            this.pnlChangePass.Tag = "MainColour";
            // 
            // lstUsers
            // 
            this.lstUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(909, 0);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(473, 142);
            this.lstUsers.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(13, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(307, 23);
            this.button5.TabIndex = 18;
            this.button5.Tag = "ButtonAccent";
            this.button5.Text = "Remove user";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(13, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(307, 23);
            this.button7.TabIndex = 16;
            this.button7.Tag = "ButtonAccent";
            this.button7.Text = "Edit username";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.ChangeUsername_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(175, 8);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Tag = "ButtonAccent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 16);
            this.label9.TabIndex = 14;
            this.label9.Tag = "Username";
            this.label9.Text = "Reassigned username:";
            // 
            // lstDomains
            // 
            this.lstDomains.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstDomains.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lstDomains.FormattingEnabled = true;
            this.lstDomains.ItemHeight = 20;
            this.lstDomains.Location = new System.Drawing.Point(909, 0);
            this.lstDomains.Name = "lstDomains";
            this.lstDomains.Size = new System.Drawing.Size(473, 142);
            this.lstDomains.TabIndex = 9;
            this.lstDomains.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblExample);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.lstDomains);
            this.panel1.Controls.Add(this.txtDomain);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 146);
            this.panel1.TabIndex = 10;
            this.panel1.Tag = "MainColour";
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.BackColor = System.Drawing.Color.Black;
            this.lblExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblExample.ForeColor = System.Drawing.Color.White;
            this.lblExample.Location = new System.Drawing.Point(405, 55);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(329, 26);
            this.lblExample.TabIndex = 13;
            this.lblExample.Tag = "ButtonAccent";
            this.lblExample.Text = "Example Domain: @example.com";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(10, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 23);
            this.button4.TabIndex = 12;
            this.button4.Tag = "ButtonAccent";
            this.button4.Text = "Remove selected domain";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(10, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 23);
            this.button3.TabIndex = 11;
            this.button3.Tag = "ButtonAccent";
            this.button3.Text = "Edit domain";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 23);
            this.button2.TabIndex = 10;
            this.button2.Tag = "ButtonAccent";
            this.button2.Text = "Add domain";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(117, 12);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(200, 20);
            this.txtDomain.TabIndex = 8;
            this.txtDomain.Tag = "ButtonAccent";
            this.txtDomain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 7;
            this.label4.Tag = "Username";
            this.label4.Text = "Desired domain:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ckbTFAnswer);
            this.panel2.Controls.Add(this.txtTFQuestionTerm);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtFakeAnswer2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtFakeAnswer1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtWrittenAnswer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dgvQuestions);
            this.panel2.Controls.Add(this.btnRemoveQuestion);
            this.panel2.Controls.Add(this.btnAddQuestion);
            this.panel2.Controls.Add(this.txtQuestionTerm);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 556);
            this.panel2.TabIndex = 11;
            this.panel2.Tag = "MainColour";
            // 
            // ckbTFAnswer
            // 
            this.ckbTFAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ckbTFAnswer.AutoSize = true;
            this.ckbTFAnswer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbTFAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbTFAnswer.Location = new System.Drawing.Point(135, 237);
            this.ckbTFAnswer.Name = "ckbTFAnswer";
            this.ckbTFAnswer.Size = new System.Drawing.Size(203, 20);
            this.ckbTFAnswer.TabIndex = 23;
            this.ckbTFAnswer.Text = "True/False answer            ";
            this.ckbTFAnswer.UseVisualStyleBackColor = true;
            // 
            // txtTFQuestionTerm
            // 
            this.txtTFQuestionTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTFQuestionTerm.Location = new System.Drawing.Point(324, 211);
            this.txtTFQuestionTerm.Name = "txtTFQuestionTerm";
            this.txtTFQuestionTerm.Size = new System.Drawing.Size(281, 20);
            this.txtTFQuestionTerm.TabIndex = 21;
            this.txtTFQuestionTerm.Tag = "ButtonAccent";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(138, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 16);
            this.label8.TabIndex = 20;
            this.label8.Tag = "Username";
            this.label8.Text = "True/False question term";
            // 
            // txtFakeAnswer2
            // 
            this.txtFakeAnswer2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFakeAnswer2.Location = new System.Drawing.Point(255, 184);
            this.txtFakeAnswer2.Name = "txtFakeAnswer2";
            this.txtFakeAnswer2.Size = new System.Drawing.Size(350, 20);
            this.txtFakeAnswer2.TabIndex = 19;
            this.txtFakeAnswer2.Tag = "ButtonAccent";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 18;
            this.label7.Tag = "Username";
            this.label7.Text = "Fake answer 2:";
            // 
            // txtFakeAnswer1
            // 
            this.txtFakeAnswer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFakeAnswer1.Location = new System.Drawing.Point(255, 159);
            this.txtFakeAnswer1.Name = "txtFakeAnswer1";
            this.txtFakeAnswer1.Size = new System.Drawing.Size(350, 20);
            this.txtFakeAnswer1.TabIndex = 17;
            this.txtFakeAnswer1.Tag = "ButtonAccent";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(138, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 16;
            this.label6.Tag = "Username";
            this.label6.Text = "Fake answer 1:";
            // 
            // txtWrittenAnswer
            // 
            this.txtWrittenAnswer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtWrittenAnswer.Location = new System.Drawing.Point(255, 133);
            this.txtWrittenAnswer.Name = "txtWrittenAnswer";
            this.txtWrittenAnswer.Size = new System.Drawing.Size(350, 20);
            this.txtWrittenAnswer.TabIndex = 15;
            this.txtWrittenAnswer.Tag = "ButtonAccent";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 14;
            this.label5.Tag = "Username";
            this.label5.Text = "Written answer:";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvQuestions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestions.GridColor = System.Drawing.Color.Black;
            this.dgvQuestions.Location = new System.Drawing.Point(636, 0);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(746, 552);
            this.dgvQuestions.TabIndex = 13;
            this.dgvQuestions.Tag = "ButtonAccent";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRemoveQuestion.BackColor = System.Drawing.Color.DimGray;
            this.btnRemoveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuestion.Location = new System.Drawing.Point(135, 334);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(467, 63);
            this.btnRemoveQuestion.TabIndex = 12;
            this.btnRemoveQuestion.Tag = "ButtonAccent";
            this.btnRemoveQuestion.Text = "Remove selected question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = false;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddQuestion.BackColor = System.Drawing.Color.DimGray;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestion.Location = new System.Drawing.Point(135, 265);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(467, 63);
            this.btnAddQuestion.TabIndex = 10;
            this.btnAddQuestion.Tag = "ButtonAccent";
            this.btnAddQuestion.Text = "Add specified question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtQuestionTerm
            // 
            this.txtQuestionTerm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtQuestionTerm.Location = new System.Drawing.Point(255, 107);
            this.txtQuestionTerm.Name = "txtQuestionTerm";
            this.txtQuestionTerm.Size = new System.Drawing.Size(350, 20);
            this.txtQuestionTerm.TabIndex = 8;
            this.txtQuestionTerm.Tag = "ButtonAccent";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 7;
            this.label3.Tag = "Username";
            this.label3.Text = "Question term:";
            // 
            // AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlChangePass);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Tag = "MainColour";
            this.Text = "AdminOptions";
            this.pnlChangePass.ResumeLayout(false);
            this.pnlChangePass.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlChangePass;
        private System.Windows.Forms.ListBox lstDomains;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TextBox txtQuestionTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbTFAnswer;
        private System.Windows.Forms.TextBox txtTFQuestionTerm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFakeAnswer2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFakeAnswer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWrittenAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label lblExample;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstUsers;
        private System.Windows.Forms.Button button7;
    }
}