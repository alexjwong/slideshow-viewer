using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace slide_show_viewer
{
    public partial class Form1 : Form
    {

        // Holds the current slide show interval
        public int CurrentInterval;
        
        // If user opened a collection, its name is stored here
        private string CurrentCollection;

        public Form1()
        {
            InitializeComponent();

            // Set filter options and filter index.
            addOpenFileDialog.Filter = "Image Files (*.jpg; *.gif; *.png; *.bmp)|*.jpg; *.gif; *.png; *.bmp|All Files (*.*)|*.*";
            addOpenFileDialog.FilterIndex = 1;
            collectionOpenFileDialog.Filter = "*.pix|*.pix";
            collectionOpenFileDialog.FilterIndex = 1;
            collectionSaveFileDialog.Filter = "*.pix|*.pix";
            collectionSaveFileDialog.FilterIndex = 1;

            // Set 5 as default interval
            IntervalTextBox.Text = "5";
        }

        private void AddFilesButton_Click(object sender, EventArgs e)
        {
            // Use openFileDialog tool (in designer) to create open file dialog for adding files
            if (addOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Add the file(s) selected in the openFileDialog tool to the FileNameListBox
                foreach (string FileName in addOpenFileDialog.FileNames)
                {
                    FileNameListBox.Items.Add(FileName);
                }
            }
            this.Invalidate();
        }

        private void DeleteFilesButton_Click(object sender, EventArgs e)
        {
            // Remove the currently selected file(s).
            // Must iterate backwards so as to keep indexes consistent through the deletion process
            for (int i = FileNameListBox.Items.Count - 1; i >= 0; i--)
            {
                FileNameListBox.Items.RemoveAt(i);
            }
            this.Invalidate();
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
                // Show this message for any entry that does not work
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
            // Use openFileDialog tool (in designer) to create an open file dialog for opening collections
            if (collectionOpenFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                // Clear the current FileListBox
                FileNameListBox.Items.Clear();

                // Save the name of the collection to populate as default for saving
                CurrentCollection = collectionOpenFileDialog.FileName;
                
                // Create a streamReader for reading files
                StreamReader streamReader = new StreamReader(collectionOpenFileDialog.OpenFile());
                
                // Read each line from the .pix file and add it to the FileNameListBox
                string file;
                while ((file = streamReader.ReadLine()) != null)
                {
                    FileNameListBox.Items.Add(file);
                }

                // Close the StreamReader after use
                streamReader.Close();

            }
        }

        private void saveCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Can't save if there are no files added
            if (FileNameListBox.Items.Count == 0)
            {
                MessageBox.Show("No file names to save.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            // If we opened a collection previously, use that name as default for saving
            if (CurrentCollection != null)
            {
                collectionSaveFileDialog.FileName = CurrentCollection;
            }
            else // Set the filename field on the dialog to be blank
            {
                collectionSaveFileDialog.FileName = null;
            }

            // Call save dialog
            if (collectionSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Call a StreamWriter to write to a file
                StreamWriter streamWriter = new StreamWriter(collectionSaveFileDialog.OpenFile());
                // Write each file in the current FileNameListBox to a file
                foreach (string file in this.FileNameListBox.Items)
                {
                    streamWriter.WriteLine(file);
                }
                streamWriter.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
