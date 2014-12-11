using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slide_show_viewer
{
    public partial class ViewerForm : Form
    {
        // Holds index to determine file
        private int currentIndex = 0;

        public ViewerForm()
        {
            InitializeComponent();

            // Custom options for the form as a view for the pictures
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void ViewerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }

        private void ViewerForm_Paint(object sender, PaintEventArgs e)
        {
            // Create graphics object
            Graphics graphics = e.Graphics;
            Form1 mainForm = (Form1)base.Owner;

            if (this.currentIndex + 1 > mainForm.FileNameListBox.Items.Count)
            {
                this.Close();
                return;
            }

            // Get the name of the file to be displayed
            string filename = (string)mainForm.FileNameListBox.Items[this.currentIndex];
            Console.WriteLine(filename);

            try
            {
                Image image = Image.FromFile(filename);
                SizeF sizeF = base.ClientSize;
                int width = image.Width;
                int height = image.Height;
                float num = Math.Min(sizeF.Height / (float)height, sizeF.Width / (float)width);

                Console.WriteLine(currentIndex);
                
                // Draw the image fullscreen, retaining aspect ratio
                graphics.DrawImage(image, (sizeF.Width - (float)width * num) / 2, (sizeF.Height - (float)height * num) / 2, (float)width * num, (float)height * num);
            }
            catch
            {
                // Failing to load an image
                graphics.DrawString("Not an image file!", new Font("Arial", 24), Brushes.Red, 20, 20);
            }
        }

        private void ViewerForm_Activated(object sender, EventArgs e)
        {
            Form1 mainForm = (Form1)base.Owner;

            // Get interval from the main form and translate to minutes
            this.intervalTimer.Interval = mainForm.CurrentInterval * 1000;

            // Enable the timer
            this.intervalTimer.Enabled = true;
        }

        private void intervalTimer_Tick(object sender, EventArgs e)
        {
            // Advance one picture
            this.currentIndex++;
            base.Invalidate();
        }
    }
}
