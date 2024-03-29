﻿namespace EclipseZebra
{
    partial class PrinterSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrinterSettings));
            this.label1 = new System.Windows.Forms.Label();
            this.PrinterTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.printer_box1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer Name (exactly as it appears in windows)";
            // 
            // PrinterTB
            // 
            this.PrinterTB.Location = new System.Drawing.Point(9, 23);
            this.PrinterTB.Margin = new System.Windows.Forms.Padding(2);
            this.PrinterTB.Name = "PrinterTB";
            this.PrinterTB.Size = new System.Drawing.Size(348, 20);
            this.PrinterTB.TabIndex = 1;
            this.PrinterTB.TextChanged += new System.EventHandler(this.PrinterTB_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(9, 150);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(83, 21);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // printer_box1
            // 
            this.printer_box1.FormattingEnabled = true;
            this.printer_box1.Location = new System.Drawing.Point(9, 48);
            this.printer_box1.Name = "printer_box1";
            this.printer_box1.Size = new System.Drawing.Size(348, 95);
            this.printer_box1.TabIndex = 3;
            this.printer_box1.SelectedIndexChanged += new System.EventHandler(this.printer_box1_SelectedIndexChanged);
            // 
            // PrinterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 182);
            this.Controls.Add(this.printer_box1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.PrinterTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrinterSettings";
            this.Text = "Printer Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrinterTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox printer_box1;
    }
}