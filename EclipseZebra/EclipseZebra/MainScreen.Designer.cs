namespace EclipseZebra
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PatientSearchLabel = new System.Windows.Forms.Label();
            this.AppointmentTB = new System.Windows.Forms.RichTextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintThreeBtn = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(28, 29);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(32, 58);
            this.FirstNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(200, 31);
            this.FirstNameTB.TabIndex = 1;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.LastNameTB);
            this.SearchPanel.Controls.Add(this.LastNameLabel);
            this.SearchPanel.Controls.Add(this.FirstNameTB);
            this.SearchPanel.Controls.Add(this.FirstNameLabel);
            this.SearchPanel.Location = new System.Drawing.Point(56, 92);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(823, 144);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(555, 53);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(233, 40);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(310, 58);
            this.LastNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(200, 31);
            this.LastNameTB.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(304, 29);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PatientSearchLabel
            // 
            this.PatientSearchLabel.AutoSize = true;
            this.PatientSearchLabel.Location = new System.Drawing.Point(51, 51);
            this.PatientSearchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientSearchLabel.Name = "PatientSearchLabel";
            this.PatientSearchLabel.Size = new System.Drawing.Size(153, 25);
            this.PatientSearchLabel.TabIndex = 3;
            this.PatientSearchLabel.Text = "Patient Search";
            // 
            // AppointmentTB
            // 
            this.AppointmentTB.Location = new System.Drawing.Point(56, 298);
            this.AppointmentTB.Margin = new System.Windows.Forms.Padding(4);
            this.AppointmentTB.Name = "AppointmentTB";
            this.AppointmentTB.ReadOnly = true;
            this.AppointmentTB.Size = new System.Drawing.Size(823, 326);
            this.AppointmentTB.TabIndex = 4;
            this.AppointmentTB.Text = "";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(56, 647);
            this.PrintBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(248, 65);
            this.PrintBtn.TabIndex = 5;
            this.PrintBtn.Text = "Print";
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
            this.menuStrip1.Size = new System.Drawing.Size(961, 40);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPrinterToolStripMenuItem,
            this.databaseSettingsToolStripMenuItem,
            this.loadTestToolStripMenuItem,
            this.printTestToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 36);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // setPrinterToolStripMenuItem
            // 
            this.setPrinterToolStripMenuItem.Name = "setPrinterToolStripMenuItem";
            this.setPrinterToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.setPrinterToolStripMenuItem.Text = "Printer Settings";
            this.setPrinterToolStripMenuItem.Click += new System.EventHandler(this.setPrinterToolStripMenuItem_Click);
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            this.databaseSettingsToolStripMenuItem.Click += new System.EventHandler(this.databaseSettingsToolStripMenuItem_Click);
            // 
            // loadTestToolStripMenuItem
            // 
            this.loadTestToolStripMenuItem.Name = "loadTestToolStripMenuItem";
            this.loadTestToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.loadTestToolStripMenuItem.Text = "Load Test";
            this.loadTestToolStripMenuItem.Click += new System.EventHandler(this.loadTestToolStripMenuItem_Click);
            // 
            // printTestToolStripMenuItem
            // 
            this.printTestToolStripMenuItem.Name = "printTestToolStripMenuItem";
            this.printTestToolStripMenuItem.Size = new System.Drawing.Size(306, 38);
            this.printTestToolStripMenuItem.Text = "Print Test";
            this.printTestToolStripMenuItem.Click += new System.EventHandler(this.printTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Future Appointments";
            // 
            // PrintThreeBtn
            // 
            this.PrintThreeBtn.Location = new System.Drawing.Point(333, 647);
            this.PrintThreeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrintThreeBtn.Name = "PrintThreeBtn";
            this.PrintThreeBtn.Size = new System.Drawing.Size(248, 65);
            this.PrintThreeBtn.TabIndex = 8;
            this.PrintThreeBtn.Text = "Print Next Three Appointments";
            this.PrintThreeBtn.UseVisualStyleBackColor = true;
            this.PrintThreeBtn.Click += new System.EventHandler(this.PrintThreeBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 763);
            this.Controls.Add(this.PrintThreeBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AppointmentTB);
            this.Controls.Add(this.PatientSearchLabel);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "EclipseZebra";
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Label PatientSearchLabel;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.RichTextBox AppointmentTB;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPrinterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.Button PrintThreeBtn;
    }
}

