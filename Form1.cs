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
        public Form1()
        {
            InitializeComponent();

            // Make the file dialog FileName default to blank (on first open)
            openFileDialog1.FileName = "";
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            // Set filter options and filter index.
            openFileDialog1.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

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

        }

        private void IntervalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
