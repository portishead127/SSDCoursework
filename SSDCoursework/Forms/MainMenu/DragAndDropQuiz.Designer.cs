namespace SSDCoursework.Forms.MainMenu.Arcade
{
    partial class DragAndDropQuiz
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSecond = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblExplanation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gameBannerControl1 = new SSDCoursework.UserControls.GameBannerControl();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblResult);
            this.panel1.Location = new System.Drawing.Point(625, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(110, 110);
            this.panel1.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.AllowDrop = true;
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.BackColor = System.Drawing.Color.Gray;
            this.lblResult.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(5, 5);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 100);
            this.lblResult.TabIndex = 0;
            this.lblResult.Tag = "ButtonAccent";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label_DragDrop);
            this.lblResult.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label_DragEnter);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.label9);
            this.flowLayoutPanel1.Controls.Add(this.label10);
            this.flowLayoutPanel1.Controls.Add(this.label11);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Controls.Add(this.label13);
            this.flowLayoutPanel1.Controls.Add(this.label14);
            this.flowLayoutPanel1.Controls.Add(this.label15);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 999);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1940, 101);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Tag = "Accent3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gray;
            this.label4.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 8;
            this.label4.Tag = "ButtonAccent";
            this.label4.Text = "F";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 100);
            this.label5.TabIndex = 9;
            this.label5.Tag = "ButtonAccent";
            this.label5.Text = "m";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(330, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 100);
            this.label6.TabIndex = 10;
            this.label6.Tag = "ButtonAccent";
            this.label6.Text = "a";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(495, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 100);
            this.label7.TabIndex = 11;
            this.label7.Tag = "ButtonAccent";
            this.label7.Text = "W";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(660, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 100);
            this.label8.TabIndex = 12;
            this.label8.Tag = "ButtonAccent";
            this.label8.Text = "P";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(825, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 100);
            this.label9.TabIndex = 13;
            this.label9.Tag = "ButtonAccent";
            this.label9.Text = "v";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(990, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 100);
            this.label10.TabIndex = 14;
            this.label10.Tag = "ButtonAccent";
            this.label10.Text = "Q";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1155, 0);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 100);
            this.label11.TabIndex = 15;
            this.label11.Tag = "ButtonAccent";
            this.label11.Text = "c";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1320, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 100);
            this.label12.TabIndex = 16;
            this.label12.Tag = "ButtonAccent";
            this.label12.Text = "V";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1485, 0);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 100);
            this.label13.TabIndex = 17;
            this.label13.Tag = "ButtonAccent";
            this.label13.Text = "I";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Gray;
            this.label14.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1650, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 100);
            this.label14.TabIndex = 18;
            this.label14.Tag = "ButtonAccent";
            this.label14.Text = "R";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Gray;
            this.label15.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1815, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0, 0, 65, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 100);
            this.label15.TabIndex = 19;
            this.label15.Tag = "ButtonAccent";
            this.label15.Text = "p";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblSecond);
            this.panel2.Location = new System.Drawing.Point(964, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(110, 110);
            this.panel2.TabIndex = 4;
            // 
            // lblSecond
            // 
            this.lblSecond.AllowDrop = true;
            this.lblSecond.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSecond.BackColor = System.Drawing.Color.Gray;
            this.lblSecond.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(5, 5);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(100, 100);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Tag = "ButtonAccent";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSecond.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label_DragDrop);
            this.lblSecond.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label_DragEnter);
            // 
            // panel3
            // 
            this.panel3.AllowDrop = true;
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblThird);
            this.panel3.Location = new System.Drawing.Point(1210, 407);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 110);
            this.panel3.TabIndex = 5;
            // 
            // lblThird
            // 
            this.lblThird.AllowDrop = true;
            this.lblThird.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThird.BackColor = System.Drawing.Color.Gray;
            this.lblThird.Font = new System.Drawing.Font("Rockwell", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThird.Location = new System.Drawing.Point(5, 5);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(100, 100);
            this.lblThird.TabIndex = 2;
            this.lblThird.Tag = "ButtonAccent";
            this.lblThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThird.DragDrop += new System.Windows.Forms.DragEventHandler(this.Label_DragDrop);
            this.lblThird.DragEnter += new System.Windows.Forms.DragEventHandler(this.Label_DragEnter);
            // 
            // lblExplanation
            // 
            this.lblExplanation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExplanation.BackColor = System.Drawing.Color.Silver;
            this.lblExplanation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblExplanation.Location = new System.Drawing.Point(546, 571);
            this.lblExplanation.Margin = new System.Windows.Forms.Padding(0);
            this.lblExplanation.Name = "lblExplanation";
            this.lblExplanation.Size = new System.Drawing.Size(852, 201);
            this.lblExplanation.TabIndex = 6;
            this.lblExplanation.Tag = "ButtonAccent";
            this.lblExplanation.Text = "Explanation label";
            this.lblExplanation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SSDCoursework.Properties.Resources.MultiplicationSign;
            this.pictureBox2.Location = new System.Drawing.Point(1103, 416);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Accent1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SSDCoursework.Properties.Resources.EqualsSign;
            this.pictureBox1.Location = new System.Drawing.Point(797, 409);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Accent1";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.Location = new System.Drawing.Point(546, 376);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 180);
            this.panel4.TabIndex = 9;
            this.panel4.Tag = "Accent1";
            // 
            // gameBannerControl1
            // 
            this.gameBannerControl1.AutoSize = true;
            this.gameBannerControl1.Location = new System.Drawing.Point(0, 0);
            this.gameBannerControl1.Name = "gameBannerControl1";
            this.gameBannerControl1.Size = new System.Drawing.Size(1928, 100);
            this.gameBannerControl1.TabIndex = 4;
            // 
            // DragAndDropQuiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1940, 1100);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExplanation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gameBannerControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DragAndDropQuiz";
            this.Tag = "MainColour";
            this.Text = "Formula Playground";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_MouseDown);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private UserControls.GameBannerControl gameBannerControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblExplanation;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
    }
}