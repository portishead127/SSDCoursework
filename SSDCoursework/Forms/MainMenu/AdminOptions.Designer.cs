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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlChangePass = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExample = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.button7 = new System.Windows.Forms.Button();
            this.pnlChangePass.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desired password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Tag = "Username";
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(107, 36);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(210, 20);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Tag = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Location = new System.Drawing.Point(107, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(210, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Tag = "Password";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(10, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(307, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update Password";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlChangePass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChangePass.Controls.Add(this.listBox2);
            this.pnlChangePass.Controls.Add(this.button5);
            this.pnlChangePass.Controls.Add(this.button1);
            this.pnlChangePass.Controls.Add(this.txtUsername);
            this.pnlChangePass.Controls.Add(this.button7);
            this.pnlChangePass.Controls.Add(this.txtPassword);
            this.pnlChangePass.Controls.Add(this.textBox2);
            this.pnlChangePass.Controls.Add(this.label1);
            this.pnlChangePass.Controls.Add(this.label9);
            this.pnlChangePass.Controls.Add(this.label2);
            this.pnlChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChangePass.Location = new System.Drawing.Point(0, 0);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Size = new System.Drawing.Size(1386, 146);
            this.pnlChangePass.TabIndex = 6;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(909, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(473, 142);
            this.listBox2.TabIndex = 19;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Enabled = false;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(596, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(307, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Remove user";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(682, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Tag = "Username";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(561, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 14;
            this.label9.Tag = "Username";
            this.label9.Text = "Reassigned username:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(909, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(473, 142);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblExample);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1386, 146);
            this.panel1.TabIndex = 10;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.BackColor = System.Drawing.Color.White;
            this.lblExample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExample.Location = new System.Drawing.Point(451, 60);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(248, 22);
            this.lblExample.TabIndex = 13;
            this.lblExample.Text = "Example Domain: @example.com";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(10, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(307, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Remove selected domain";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(10, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(307, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Edit domain";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(10, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(307, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Add domain";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Tag = "Username";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 381);
            this.panel2.TabIndex = 11;
            // 
            // ckbTFAnswer
            // 
            this.ckbTFAnswer.AutoSize = true;
            this.ckbTFAnswer.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbTFAnswer.Location = new System.Drawing.Point(13, 196);
            this.ckbTFAnswer.Name = "ckbTFAnswer";
            this.ckbTFAnswer.Size = new System.Drawing.Size(145, 17);
            this.ckbTFAnswer.TabIndex = 23;
            this.ckbTFAnswer.Text = "True/False answer          ";
            this.ckbTFAnswer.UseVisualStyleBackColor = true;
            // 
            // txtTFQuestionTerm
            // 
            this.txtTFQuestionTerm.Location = new System.Drawing.Point(144, 171);
            this.txtTFQuestionTerm.Name = "txtTFQuestionTerm";
            this.txtTFQuestionTerm.Size = new System.Drawing.Size(235, 20);
            this.txtTFQuestionTerm.TabIndex = 21;
            this.txtTFQuestionTerm.Tag = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 20;
            this.label8.Tag = "Username";
            this.label8.Text = "True/False question term";
            // 
            // txtFakeAnswer2
            // 
            this.txtFakeAnswer2.Location = new System.Drawing.Point(102, 148);
            this.txtFakeAnswer2.Name = "txtFakeAnswer2";
            this.txtFakeAnswer2.Size = new System.Drawing.Size(275, 20);
            this.txtFakeAnswer2.TabIndex = 19;
            this.txtFakeAnswer2.Tag = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 18;
            this.label7.Tag = "Username";
            this.label7.Text = "Fake answer 2:";
            // 
            // txtFakeAnswer1
            // 
            this.txtFakeAnswer1.Location = new System.Drawing.Point(102, 122);
            this.txtFakeAnswer1.Name = "txtFakeAnswer1";
            this.txtFakeAnswer1.Size = new System.Drawing.Size(275, 20);
            this.txtFakeAnswer1.TabIndex = 17;
            this.txtFakeAnswer1.Tag = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 16;
            this.label6.Tag = "Username";
            this.label6.Text = "Fake answer 1:";
            // 
            // txtWrittenAnswer
            // 
            this.txtWrittenAnswer.Location = new System.Drawing.Point(102, 96);
            this.txtWrittenAnswer.Name = "txtWrittenAnswer";
            this.txtWrittenAnswer.Size = new System.Drawing.Size(275, 20);
            this.txtWrittenAnswer.TabIndex = 15;
            this.txtWrittenAnswer.Tag = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Tag = "Username";
            this.label5.Text = "Written answer:";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvQuestions.Location = new System.Drawing.Point(539, 0);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(843, 377);
            this.dgvQuestions.TabIndex = 13;
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.BackColor = System.Drawing.Color.DimGray;
            this.btnRemoveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveQuestion.Location = new System.Drawing.Point(10, 257);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(364, 23);
            this.btnRemoveQuestion.TabIndex = 12;
            this.btnRemoveQuestion.Text = "Remove selected question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = false;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.DimGray;
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Location = new System.Drawing.Point(10, 228);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(364, 23);
            this.btnAddQuestion.TabIndex = 10;
            this.btnAddQuestion.Text = "Add specified question";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // txtQuestionTerm
            // 
            this.txtQuestionTerm.Location = new System.Drawing.Point(102, 70);
            this.txtQuestionTerm.Name = "txtQuestionTerm";
            this.txtQuestionTerm.Size = new System.Drawing.Size(275, 20);
            this.txtQuestionTerm.TabIndex = 8;
            this.txtQuestionTerm.Tag = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Tag = "Username";
            this.label3.Text = "Question term:";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(596, 39);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(307, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Edit username";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button4Click);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlChangePass;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button7;
    }
}