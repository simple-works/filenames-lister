namespace YamlFilesNamesListGenerator
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_sourcePath = new System.Windows.Forms.TextBox();
            this.button_browseSource = new System.Windows.Forms.Button();
            this.richTextBox_output = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_browseTarget = new System.Windows.Forms.Button();
            this.textBox_targetPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Folder :";
            // 
            // textBox_sourcePath
            // 
            this.textBox_sourcePath.Location = new System.Drawing.Point(17, 35);
            this.textBox_sourcePath.Name = "textBox_sourcePath";
            this.textBox_sourcePath.Size = new System.Drawing.Size(357, 20);
            this.textBox_sourcePath.TabIndex = 1;
            this.textBox_sourcePath.TextChanged += new System.EventHandler(this.textBox_sourcePath_TextChanged);
            // 
            // button_browseSource
            // 
            this.button_browseSource.Location = new System.Drawing.Point(380, 34);
            this.button_browseSource.Name = "button_browseSource";
            this.button_browseSource.Size = new System.Drawing.Size(30, 23);
            this.button_browseSource.TabIndex = 2;
            this.button_browseSource.Text = "...";
            this.button_browseSource.UseVisualStyleBackColor = true;
            this.button_browseSource.Click += new System.EventHandler(this.button_browseSource_Click);
            // 
            // richTextBox_output
            // 
            this.richTextBox_output.Location = new System.Drawing.Point(17, 83);
            this.richTextBox_output.Name = "richTextBox_output";
            this.richTextBox_output.ReadOnly = true;
            this.richTextBox_output.Size = new System.Drawing.Size(393, 199);
            this.richTextBox_output.TabIndex = 4;
            this.richTextBox_output.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output :";
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(335, 359);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 22);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_browseTarget
            // 
            this.button_browseTarget.Location = new System.Drawing.Point(380, 310);
            this.button_browseTarget.Name = "button_browseTarget";
            this.button_browseTarget.Size = new System.Drawing.Size(30, 23);
            this.button_browseTarget.TabIndex = 7;
            this.button_browseTarget.Text = "...";
            this.button_browseTarget.UseVisualStyleBackColor = true;
            this.button_browseTarget.Click += new System.EventHandler(this.button_browseTarget_Click);
            // 
            // textBox_targetPath
            // 
            this.textBox_targetPath.Location = new System.Drawing.Point(17, 311);
            this.textBox_targetPath.Name = "textBox_targetPath";
            this.textBox_targetPath.Size = new System.Drawing.Size(357, 20);
            this.textBox_targetPath.TabIndex = 6;
            this.textBox_targetPath.TextChanged += new System.EventHandler(this.textBox_targetPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target Folder :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "File Name :";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(17, 362);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(312, 20);
            this.textBox_filename.TabIndex = 9;
            this.textBox_filename.TextChanged += new System.EventHandler(this.textBox_filename_TextChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 399);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_browseTarget);
            this.Controls.Add(this.textBox_targetPath);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_output);
            this.Controls.Add(this.button_browseSource);
            this.Controls.Add(this.textBox_sourcePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filenames Lister (By Ambratolm)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_sourcePath;
        private System.Windows.Forms.Button button_browseSource;
        private System.Windows.Forms.RichTextBox richTextBox_output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_browseTarget;
        private System.Windows.Forms.TextBox textBox_targetPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}