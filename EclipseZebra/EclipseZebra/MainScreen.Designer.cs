﻿namespace EclipseZebra
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.PatientSearchLabel = new System.Windows.Forms.Label();
            this.AppointmentTB = new System.Windows.Forms.RichTextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceAutocompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintThreeBtn = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientSearchLabel
            // 
            this.PatientSearchLabel.AutoSize = true;
            this.PatientSearchLabel.Location = new System.Drawing.Point(26, 33);
            this.PatientSearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PatientSearchLabel.Name = "PatientSearchLabel";
            this.PatientSearchLabel.Size = new System.Drawing.Size(77, 13);
            this.PatientSearchLabel.TabIndex = 3;
            this.PatientSearchLabel.Text = "Patient Search";
            // 
            // AppointmentTB
            // 
            this.AppointmentTB.Location = new System.Drawing.Point(26, 127);
            this.AppointmentTB.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentTB.Name = "AppointmentTB";
            this.AppointmentTB.Size = new System.Drawing.Size(414, 171);
            this.AppointmentTB.TabIndex = 4;
            this.AppointmentTB.Text = "";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(26, 302);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(124, 34);
            this.PrintBtn.TabIndex = 5;
            this.PrintBtn.Text = "Print All Appointments";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(458, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPrinterToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem,
            this.sourceAutocompleteToolStripMenuItem,
            this.loadTestToolStripMenuItem,
            this.printTestToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setPrinterToolStripMenuItem
            // 
            this.setPrinterToolStripMenuItem.Name = "setPrinterToolStripMenuItem";
            this.setPrinterToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.setPrinterToolStripMenuItem.Text = "Printer Settings";
            this.setPrinterToolStripMenuItem.Click += new System.EventHandler(this.setPrinterToolStripMenuItem_Click);
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // sourceAutocompleteToolStripMenuItem
            // 
            this.sourceAutocompleteToolStripMenuItem.Name = "sourceAutocompleteToolStripMenuItem";
            this.sourceAutocompleteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sourceAutocompleteToolStripMenuItem.Text = "Source Autocomplete";
            this.sourceAutocompleteToolStripMenuItem.Click += new System.EventHandler(this.sourceAutocompleteToolStripMenuItem_Click);
            // 
            // loadTestToolStripMenuItem
            // 
            this.loadTestToolStripMenuItem.Name = "loadTestToolStripMenuItem";
            this.loadTestToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadTestToolStripMenuItem.Text = "Load Test";
            this.loadTestToolStripMenuItem.Click += new System.EventHandler(this.loadTestToolStripMenuItem_Click);
            // 
            // printTestToolStripMenuItem
            // 
            this.printTestToolStripMenuItem.Name = "printTestToolStripMenuItem";
            this.printTestToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.printTestToolStripMenuItem.Text = "Print Test";
            this.printTestToolStripMenuItem.Click += new System.EventHandler(this.printTestToolStripMenuItem_Click);
            // 
            // PrintThreeBtn
            // 
            this.PrintThreeBtn.Location = new System.Drawing.Point(154, 302);
            this.PrintThreeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.PrintThreeBtn.Name = "PrintThreeBtn";
            this.PrintThreeBtn.Size = new System.Drawing.Size(124, 34);
            this.PrintThreeBtn.TabIndex = 8;
            this.PrintThreeBtn.Text = "Print Next Three Appointments";
            this.PrintThreeBtn.UseVisualStyleBackColor = true;
            this.PrintThreeBtn.Click += new System.EventHandler(this.PrintThreeBtn_Click);
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(-2, 17);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(82, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Customer Name";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(195, 31);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(116, 21);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Future Appointments";
            // 
            // NameTB
            // 
            this.NameTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameTB.Location = new System.Drawing.Point(0, 31);
            this.NameTB.Margin = new System.Windows.Forms.Padding(2);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(191, 20);
            this.NameTB.TabIndex = 4;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.NameTB);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.FirstNameLabel);
            this.SearchPanel.Location = new System.Drawing.Point(28, 48);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(412, 75);
            this.SearchPanel.TabIndex = 2;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 353);
            this.Controls.Add(this.PrintThreeBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AppointmentTB);
            this.Controls.Add(this.PatientSearchLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "EclipseZebra";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientSearchLabel;
        private System.Windows.Forms.RichTextBox AppointmentTB;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.Button PrintThreeBtn;
        private System.Windows.Forms.ToolStripMenuItem sourceAutocompleteToolStripMenuItem;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Panel SearchPanel;
    }
}

