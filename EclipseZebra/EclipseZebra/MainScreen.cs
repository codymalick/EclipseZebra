﻿using EclipseZebra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace EclipseZebra
{
    public partial class MainScreen : Form
    {
        
        public MainScreen()
        {
            //connect to database
            //https://msdn.microsoft.com/en-us/library/aa984313(v=vs.71).aspx
            //Eclipse uses ODBC database pattern
            
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            this.testbox.Text = Search.execute(this.FirstNameTB.Text, this.LastNameTB.Text);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if(this.FirstNameTB.Text == string.Empty || this.LastNameTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter customer name");
            } else
            {
                string printer_name = File.ReadAllText("settings.txt");
                string name = this.FirstNameTB.Text + " " + this.LastNameTB.Text;
                RawPrinterHelper.print(name, printer_name);
            }
            
        }

        private void setPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
    }
}
