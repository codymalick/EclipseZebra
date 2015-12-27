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
using EclipseZebra.Model;

namespace EclipseZebra
{
    public partial class MainScreen : Form
    {
        Patient current_patient = new Patient();
        string printer_name;

        public MainScreen()
        {
            //connect to database
            //https://msdn.microsoft.com/en-us/library/aa984313(v=vs.71).aspx
            //Eclipse uses ODBC database pattern
            
            InitializeComponent();
            set_printer();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.AppointmentTB.Text = string.Empty;

            if (this.FirstNameTB.Text == string.Empty || this.LastNameTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter customer name");
            }
            else {
                var result = Search.execute(this.FirstNameTB.Text, this.LastNameTB.Text);
                if(result != null)
                {
                    DateTime temp;
                    for(int i = 0; i <= result.Count - 1 ; i++)
                    {
                        temp = Convert.ToDateTime(result[i]);
                        this.AppointmentTB.Text += temp.ToShortDateString() + " @ " + temp.ToShortTimeString() + '\n';
                    }
                }
                
            }
            
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            if(this.FirstNameTB.Text == string.Empty || this.LastNameTB.Text == string.Empty)
            {
                MessageBox.Show("Please enter customer name");
            }
            else
            {
                set_printer();
                if(this.printer_name == string.Empty)
                {
                    MessageBox.Show("Please enter a printer in settings");
                } else
                {
                    string printer_name = File.ReadAllText("printerSettings.txt");
                    string name = this.FirstNameTB.Text + " " + this.LastNameTB.Text;
                    RawPrinterHelper.print(current_patient, printer_name);
                }
                
            }
            
        }

        private void setPrinterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrinterSettings settings = new PrinterSettings();
            settings.Show();
        }

        private void reset()
        {
            current_patient.reset();
            this.AppointmentTB.Text = string.Empty;
        }

        private void printTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient test_patient = new Patient()
            {
                firstName = "Cody",
                lastName = "Malick",
                //appointments = { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now}
                //appointments = { DateTime.Now, DateTime.Now, DateTime.Now }
                //appointments = { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now }
                //appointments = { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now }
                appointments = { DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now }

            };
            set_printer();
            if (printer_name == null)
            {
                MessageBox.Show("Please configure printer");
            }
            else
            {
                RawPrinterHelper.print(test_patient, printer_name);
            }
        }

        private void set_printer()
        {
            if(File.Exists("printerSettings.txt"))
            {
                printer_name = File.ReadLines("printerSettings.txt").Take(1).First();
            }
        }

        private void loadTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AppointmentTB.Text = string.Empty;
            current_patient = new Patient()
            {
                firstName = "Cody",
                lastName = "Malick",
                appointments = { DateTime.Now, DateTime.Now.AddDays(1) }
            };
            FirstNameTB.Text = current_patient.firstName;
            LastNameTB.Text = current_patient.lastName;
            DateTime temp;
            for (int i = 0; i <= current_patient.appointments.Count - 1; i++)
            {
                temp = Convert.ToDateTime(current_patient.appointments[i]);
                this.AppointmentTB.Text += temp.ToShortDateString() + " @ " + temp.ToShortTimeString() + '\n';
            }
        }

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSettings db = new DatabaseSettings();
            db.Show();
        }
    }
}
