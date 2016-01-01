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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.AppointmentTB = new System.Windows.Forms.RichTextBox();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSourceConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDataSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSource1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSource2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printerSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPrinterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceAutocompleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintThreeBtn = new System.Windows.Forms.Button();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DBLB = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppointmentTB
            // 
            this.AppointmentTB.Location = new System.Drawing.Point(26, 98);
            this.AppointmentTB.Margin = new System.Windows.Forms.Padding(2);
            this.AppointmentTB.Name = "AppointmentTB";
            this.AppointmentTB.Size = new System.Drawing.Size(414, 171);
            this.AppointmentTB.TabIndex = 9;
            this.AppointmentTB.TabStop = false;
            this.AppointmentTB.Text = "";
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(26, 273);
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
            this.databaseSettingsToolStripMenuItem,
            this.printerSettingsToolStripMenuItem,
            this.otherToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // databaseSettingsToolStripMenuItem
            // 
            this.databaseSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSourceConfigToolStripMenuItem,
            this.selectDataSourceToolStripMenuItem});
            this.databaseSettingsToolStripMenuItem.Name = "databaseSettingsToolStripMenuItem";
            this.databaseSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.databaseSettingsToolStripMenuItem.Text = "Database Settings";
            // 
            // dataSourceConfigToolStripMenuItem
            // 
            this.dataSourceConfigToolStripMenuItem.Name = "dataSourceConfigToolStripMenuItem";
            this.dataSourceConfigToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.dataSourceConfigToolStripMenuItem.Text = "Data Source Config";
            this.dataSourceConfigToolStripMenuItem.Click += new System.EventHandler(this.dataSourceConfigToolStripMenuItem_Click);
            // 
            // selectDataSourceToolStripMenuItem
            // 
            this.selectDataSourceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataSource1ToolStripMenuItem,
            this.dataSource2ToolStripMenuItem});
            this.selectDataSourceToolStripMenuItem.Name = "selectDataSourceToolStripMenuItem";
            this.selectDataSourceToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.selectDataSourceToolStripMenuItem.Text = "Select Data Source";
            // 
            // dataSource1ToolStripMenuItem
            // 
            this.dataSource1ToolStripMenuItem.Name = "dataSource1ToolStripMenuItem";
            this.dataSource1ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dataSource1ToolStripMenuItem.Text = "Healing Health Centers";
            this.dataSource1ToolStripMenuItem.Click += new System.EventHandler(this.dataSource1ToolStripMenuItem_Click);
            // 
            // dataSource2ToolStripMenuItem
            // 
            this.dataSource2ToolStripMenuItem.Name = "dataSource2ToolStripMenuItem";
            this.dataSource2ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dataSource2ToolStripMenuItem.Text = "Associated Physicians";
            this.dataSource2ToolStripMenuItem.Click += new System.EventHandler(this.dataSource2ToolStripMenuItem_Click);
            // 
            // printerSettingsToolStripMenuItem
            // 
            this.printerSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPrinterToolStripMenuItem,
            this.printTestToolStripMenuItem});
            this.printerSettingsToolStripMenuItem.Name = "printerSettingsToolStripMenuItem";
            this.printerSettingsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.printerSettingsToolStripMenuItem.Text = "Printer Settings";
            // 
            // setPrinterToolStripMenuItem
            // 
            this.setPrinterToolStripMenuItem.Name = "setPrinterToolStripMenuItem";
            this.setPrinterToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.setPrinterToolStripMenuItem.Text = "Printer Config";
            // 
            // printTestToolStripMenuItem
            // 
            this.printTestToolStripMenuItem.Name = "printTestToolStripMenuItem";
            this.printTestToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.printTestToolStripMenuItem.Text = "Print Test";
            // 
            // otherToolStripMenuItem
            // 
            this.otherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTestToolStripMenuItem,
            this.sourceAutocompleteToolStripMenuItem});
            this.otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            this.otherToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.otherToolStripMenuItem.Text = "Other";
            // 
            // loadTestToolStripMenuItem
            // 
            this.loadTestToolStripMenuItem.Name = "loadTestToolStripMenuItem";
            this.loadTestToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.loadTestToolStripMenuItem.Text = "Load Test";
            // 
            // sourceAutocompleteToolStripMenuItem
            // 
            this.sourceAutocompleteToolStripMenuItem.Name = "sourceAutocompleteToolStripMenuItem";
            this.sourceAutocompleteToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.sourceAutocompleteToolStripMenuItem.Text = "Source Autocomplete";
            // 
            // PrintThreeBtn
            // 
            this.PrintThreeBtn.Location = new System.Drawing.Point(154, 273);
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
            this.FirstNameLabel.Location = new System.Drawing.Point(26, 33);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(71, 13);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "Patient Name";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(213, 1);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(116, 22);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 35);
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
            this.NameTB.Location = new System.Drawing.Point(18, 2);
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
            this.SearchPanel.Location = new System.Drawing.Point(11, 48);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(412, 75);
            this.SearchPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Current Data Source:";
            // 
            // DBLB
            // 
            this.DBLB.AutoSize = true;
            this.DBLB.Location = new System.Drawing.Point(115, 320);
            this.DBLB.Name = "DBLB";
            this.DBLB.Size = new System.Drawing.Size(43, 13);
            this.DBLB.TabIndex = 10;
            this.DBLB.Text = "Not Set";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 338);
            this.Controls.Add(this.DBLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrintThreeBtn);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.AppointmentTB);
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
        private System.Windows.Forms.RichTextBox AppointmentTB;
        private System.Windows.Forms.Button PrintBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseSettingsToolStripMenuItem;
        private System.Windows.Forms.Button PrintThreeBtn;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.ToolStripMenuItem dataSourceConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDataSourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSource1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataSource2ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DBLB;
        private System.Windows.Forms.ToolStripMenuItem printerSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceAutocompleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPrinterToolStripMenuItem;
    }
}

