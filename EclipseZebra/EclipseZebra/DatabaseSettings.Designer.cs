namespace EclipseZebra
{
    partial class DatabaseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.Data1TB = new System.Windows.Forms.TextBox();
            this.Data1SB = new System.Windows.Forms.Button();
            this.Data2SB = new System.Windows.Forms.Button();
            this.Data2TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source Name (Exactly as it appears in windows)";
            // 
            // Data1TB
            // 
            this.Data1TB.Location = new System.Drawing.Point(11, 37);
            this.Data1TB.Margin = new System.Windows.Forms.Padding(2);
            this.Data1TB.Name = "Data1TB";
            this.Data1TB.Size = new System.Drawing.Size(169, 20);
            this.Data1TB.TabIndex = 1;
            // 
            // Data1SB
            // 
            this.Data1SB.Location = new System.Drawing.Point(11, 61);
            this.Data1SB.Margin = new System.Windows.Forms.Padding(2);
            this.Data1SB.Name = "Data1SB";
            this.Data1SB.Size = new System.Drawing.Size(72, 22);
            this.Data1SB.TabIndex = 2;
            this.Data1SB.Text = "Save";
            this.Data1SB.UseVisualStyleBackColor = true;
            this.Data1SB.Click += new System.EventHandler(this.Data1SB_Click);
            // 
            // Data2SB
            // 
            this.Data2SB.Location = new System.Drawing.Point(10, 150);
            this.Data2SB.Margin = new System.Windows.Forms.Padding(2);
            this.Data2SB.Name = "Data2SB";
            this.Data2SB.Size = new System.Drawing.Size(72, 22);
            this.Data2SB.TabIndex = 5;
            this.Data2SB.Text = "Save";
            this.Data2SB.UseVisualStyleBackColor = true;
            this.Data2SB.Click += new System.EventHandler(this.Data2SB_Click);
            // 
            // Data2TB
            // 
            this.Data2TB.Location = new System.Drawing.Point(10, 126);
            this.Data2TB.Margin = new System.Windows.Forms.Padding(2);
            this.Data2TB.Name = "Data2TB";
            this.Data2TB.Size = new System.Drawing.Size(169, 20);
            this.Data2TB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Source Name (Exactly as it appears in windows)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Healing Health Centers Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Associated Physicians Data Source";
            // 
            // DatabaseSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Data2SB);
            this.Controls.Add(this.Data2TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data1SB);
            this.Controls.Add(this.Data1TB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DatabaseSettings";
            this.Text = "Database Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Data1TB;
        private System.Windows.Forms.Button Data1SB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Data2TB;
        private System.Windows.Forms.Button Data2SB;
    }
}