using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSDCoursework.Forms.MainMenu
{
    public partial class DragAndDropQuiz : Form
    {
        PictureBox currentDraggedElement;


        public DragAndDropQuiz()
        {
            InitializeComponent();
        }

        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            currentDraggedElement = sender as PictureBox;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            foreach (Control c in panel1.Controls)
            {
                c.Visible = true;
                c.Enabled = true;
            }
            currentDraggedElement.Visible = false;
            currentDraggedElement.Enabled = false;

            pictureBox1.Image = currentDraggedElement.Image; 
        }
    }
}
