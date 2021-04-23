using System;
using System.Windows.Forms;
using FilenamesLister.Properties;

namespace YamlFilesNamesListGenerator
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            textBox_sourcePath.Text = Settings.Default.SourcePath.Trim();
            textBox_targetPath.Text = Settings.Default.TargetPath.Trim();
            textBox_filename.Text = Settings.Default.Filename.Trim();
            if (string.IsNullOrEmpty(textBox_targetPath.Text.Trim()))
            {
                textBox_targetPath.Text = Core.CurrentFolderPath;
            }
        }

        private void CheckIfSaveIsAllowed()
        {
            button_save.Enabled = (
                !string.IsNullOrEmpty(textBox_sourcePath.Text.Trim()) &&
                !string.IsNullOrEmpty(textBox_targetPath.Text.Trim()) &&
                !string.IsNullOrEmpty(textBox_filename.Text.Trim())
            );
        }

        private void button_browseSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_sourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void textBox_sourcePath_TextChanged(object sender, EventArgs e)
        {
            CheckIfSaveIsAllowed();
            richTextBox_output.Text = Core.GetYAMLOutput(textBox_sourcePath.Text);
        }

        private void button_browseTarget_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_targetPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_sourcePath.Text.Trim()))
            {
                MessageBox.Show("Choose Source Folder!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox_targetPath.Text.Trim()))
            {
                MessageBox.Show("Choose Target Folder!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(textBox_filename.Text.Trim()))
            {
                MessageBox.Show("Enter File Name!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Core.SaveFile(richTextBox_output.Text, textBox_targetPath.Text, textBox_filename.Text);
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SourcePath = textBox_sourcePath.Text.Trim();
            Settings.Default.TargetPath = textBox_targetPath.Text.Trim();
            Settings.Default.Filename = textBox_filename.Text.Trim();
            Settings.Default.Save();
        }

        private void textBox_targetPath_TextChanged(object sender, EventArgs e)
        {
            CheckIfSaveIsAllowed();
        }

        private void textBox_filename_TextChanged(object sender, EventArgs e)
        {
            CheckIfSaveIsAllowed();
        }
    }
}
