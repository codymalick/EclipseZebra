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
            this.testbox = new System.Windows.Forms.RichTextBox();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(28, 29);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Location = new System.Drawing.Point(33, 57);
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(199, 31);
            this.FirstNameTB.TabIndex = 1;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.LastNameTB);
            this.SearchPanel.Controls.Add(this.LastNameLabel);
            this.SearchPanel.Controls.Add(this.FirstNameTB);
            this.SearchPanel.Controls.Add(this.FirstNameLabel);
            this.SearchPanel.Location = new System.Drawing.Point(56, 93);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(967, 144);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(627, 55);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(240, 48);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(310, 57);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(199, 31);
            this.LastNameTB.TabIndex = 3;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(305, 29);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // PatientSearchLabel
            // 
            this.PatientSearchLabel.AutoSize = true;
            this.PatientSearchLabel.Location = new System.Drawing.Point(64, 52);
            this.PatientSearchLabel.Name = "PatientSearchLabel";
            this.PatientSearchLabel.Size = new System.Drawing.Size(153, 25);
            this.PatientSearchLabel.TabIndex = 3;
            this.PatientSearchLabel.Text = "Patient Search";
            // 
            // testbox
            // 
            this.testbox.Location = new System.Drawing.Point(56, 423);
            this.testbox.Name = "testbox";
            this.testbox.Size = new System.Drawing.Size(1065, 340);
            this.testbox.TabIndex = 4;
            this.testbox.Text = "";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 1068);
            this.Controls.Add(this.testbox);
            this.Controls.Add(this.PatientSearchLabel);
            this.Controls.Add(this.SearchPanel);
            this.Name = "MainScreen";
            this.Text = "Form1";
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
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
        private System.Windows.Forms.RichTextBox testbox;
    }
}

