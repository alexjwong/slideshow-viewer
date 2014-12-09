namespace slide_show_viewer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNameListBox = new System.Windows.Forms.ListBox();
            this.FilesGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteFilesButton = new System.Windows.Forms.Button();
            this.AddFilesButton = new System.Windows.Forms.Button();
            this.ShowButton = new System.Windows.Forms.Button();
            this.IntervalTextBox = new System.Windows.Forms.TextBox();
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.FilesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openCollectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItem2.Text = "Open Collection";
            // 
            // openCollectionToolStripMenuItem
            // 
            this.openCollectionToolStripMenuItem.Name = "openCollectionToolStripMenuItem";
            this.openCollectionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.openCollectionToolStripMenuItem.Text = "Save Collection";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FileNameListBox
            // 
            this.FileNameListBox.FormattingEnabled = true;
            this.FileNameListBox.Location = new System.Drawing.Point(12, 28);
            this.FileNameListBox.Name = "FileNameListBox";
            this.FileNameListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.FileNameListBox.Size = new System.Drawing.Size(510, 69);
            this.FileNameListBox.TabIndex = 1;
            // 
            // FilesGroupBox
            // 
            this.FilesGroupBox.Controls.Add(this.DeleteFilesButton);
            this.FilesGroupBox.Controls.Add(this.AddFilesButton);
            this.FilesGroupBox.Location = new System.Drawing.Point(36, 128);
            this.FilesGroupBox.Name = "FilesGroupBox";
            this.FilesGroupBox.Size = new System.Drawing.Size(231, 95);
            this.FilesGroupBox.TabIndex = 2;
            this.FilesGroupBox.TabStop = false;
            this.FilesGroupBox.Text = "Files";
            // 
            // DeleteFilesButton
            // 
            this.DeleteFilesButton.Location = new System.Drawing.Point(129, 34);
            this.DeleteFilesButton.Name = "DeleteFilesButton";
            this.DeleteFilesButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteFilesButton.TabIndex = 1;
            this.DeleteFilesButton.Text = "Delete";
            this.DeleteFilesButton.UseVisualStyleBackColor = true;
            this.DeleteFilesButton.Click += new System.EventHandler(this.DeleteFilesButton_Click);
            // 
            // AddFilesButton
            // 
            this.AddFilesButton.Location = new System.Drawing.Point(26, 34);
            this.AddFilesButton.Name = "AddFilesButton";
            this.AddFilesButton.Size = new System.Drawing.Size(75, 23);
            this.AddFilesButton.TabIndex = 0;
            this.AddFilesButton.Text = "Add";
            this.AddFilesButton.UseVisualStyleBackColor = true;
            this.AddFilesButton.Click += new System.EventHandler(this.AddFilesButton_Click);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(380, 162);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 3;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // IntervalTextBox
            // 
            this.IntervalTextBox.Location = new System.Drawing.Point(396, 203);
            this.IntervalTextBox.Name = "IntervalTextBox";
            this.IntervalTextBox.Size = new System.Drawing.Size(42, 20);
            this.IntervalTextBox.TabIndex = 4;
            this.IntervalTextBox.TextChanged += new System.EventHandler(this.IntervalTextBox_TextChanged);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.Location = new System.Drawing.Point(348, 206);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(42, 13);
            this.IntervalLabel.TabIndex = 5;
            this.IntervalLabel.Text = "Interval";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 262);
            this.Controls.Add(this.IntervalLabel);
            this.Controls.Add(this.IntervalTextBox);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.FilesGroupBox);
            this.Controls.Add(this.FileNameListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Slide Show Viewer by Alexander Wong";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FilesGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem openCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox FileNameListBox;
        private System.Windows.Forms.GroupBox FilesGroupBox;
        private System.Windows.Forms.Button DeleteFilesButton;
        private System.Windows.Forms.Button AddFilesButton;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.TextBox IntervalTextBox;
        private System.Windows.Forms.Label IntervalLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

