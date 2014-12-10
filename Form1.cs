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
    public partial class Form1 : Form
    {

        // Holds the current slide show interval
        public int CurrentInterval;

        public Form1()
        {
            InitializeComponent();

            // Make the file dialog FileName default to blank (on first open)
            openFileDialog1.FileName = "";
            // Set filter options and filter index.
            openFileDialog1.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            // Use openFileDialog tool (in designer) to create openFileDialog1
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                // Add the file(s) selected in the openFileDialog tool to the FileNameListBox
                foreach (string FileName in openFileDialog1.FileNames)
                {
                    FileNameListBox.Items.Add(FileName);
                }
            }
            this.Invalidate();
        }

        private void DeleteFilesButton_Click(object sender, EventArgs e)
        {
            // Remove the currently selected file(s).
            for (int i = FileNameListBox.Items.Count - 1; i >= 0; i--)
            {
                FileNameListBox.Items.RemoveAt(i);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            // If no items in list, show error message
            if (FileNameListBox.Items.Count == 0)
            {
                MessageBox.Show("No images to show.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            try
            {
                // Set the value in the IntervalTextBox to the program's current interval
                CurrentInterval = Int32.Parse(IntervalTextBox.Text);

                if (this.CurrentInterval <= 0)
                {
                    throw new Exception("Please enter an integer time interval > 0");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter an integer time interval > 0",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
                return;
            }

            // Create new ViewerForm, *important* - Owner is this!!
            ViewerForm VForm = new ViewerForm { Owner = this };
            // Show as modal window
            VForm.ShowDialog();
        }

        private void openCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
