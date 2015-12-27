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
            NameTB.AutoCompleteCustomSource = Search.setup_autocomplete();
        }


        private void SearchBtn_Click(object sender, EventArgs e)
        {
            this.AppointmentTB.Text = string.Empty;
            this.current_patient = new Patient();

            if (!NameTB.Text.Equals(string.Empty))
            {
                //Break down user input
                string firstName, lastName;

                //Handles cases like "Jo Ann Doe"
                if((NameTB.Text.Split(' ').Count()) == 3)
                {
                    firstName = NameTB.Text.Split(' ')[0] + " " + NameTB.Text.Split(' ')[1];
                    lastName = NameTB.Text.Split(' ')[2];
                }
                //Base Case
                else
                {
                    firstName = NameTB.Text.Split(' ').First();
                    lastName = string.Empty;

                    //Gets the last name, fails silently
                    try
                    {
                        lastName = NameTB.Text.Split(' ')[1];
                    }
                    catch { }
                }
                //Gets the first name, will always work
                
                
                //Search
                var result = Search.execute(firstName, lastName);
                if (result != null)
                {
                    //Set Current Patient data for printing
                    current_patient.firstName = firstName;
                    current_patient.lastName = lastName;

                    DateTime temp;
                    for (int i = 0; i <= result.Count - 1; i++)
                    {
                        temp = Convert.ToDateTime(result[i]);
                        current_patient.appointments.Add(temp);
                        this.AppointmentTB.Text += temp.ToShortDateString() + " @ " + temp.ToShortTimeString() + '\n';
                    }
                }
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            set_printer();

            //check for errors
            int err = error_checking();
            if (err == 0)
            {
                string printer_name = File.ReadAllText("printerSettings.txt");
                RawPrinterHelper.print(current_patient, printer_name);
            }
        }

        private void PrintThreeBtn_Click(object sender, EventArgs e)
        {
            set_printer();

            //check for errors
            int err = error_checking();
            if (err == 0)
            {
                Patient temp_patient = new Patient() { firstName = current_patient.firstName, lastName = current_patient.lastName };
                for (int i = 0; i < 3; i++)
                {
                    if (i + 1 <= current_patient.appointments.Count && current_patient.appointments[i] != null)
                        temp_patient.appointments.Add(current_patient.appointments[i]);
                }
                RawPrinterHelper.print(temp_patient, printer_name);
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
        
        //private void loadTestToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    this.AppointmentTB.Text = string.Empty;
        //    current_patient = new Patient()
        //    {
        //        firstName = "Cody",
        //        lastName = "Malick",
        //        appointments = { DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now, DateTime.Now }
        //    };
        //    FirstNameTB.Text = current_patient.firstName;
        //    LastNameTB.Text = current_patient.lastName;
        //    DateTime temp;
        //    for (int i = 0; i <= current_patient.appointments.Count - 1; i++)
        //    {
        //        temp = Convert.ToDateTime(current_patient.appointments[i]);
        //        this.AppointmentTB.Text += temp.ToShortDateString() + " @ " + temp.ToShortTimeString() + '\n';
        //    }
        //}

        private void databaseSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseSettings db = new DatabaseSettings();
            db.Show();
        }

        

        private int error_checking()
        {
            if(current_patient.firstName.Equals(string.Empty) || current_patient.lastName.Equals(string.Empty))
            {
                MessageBox.Show("Please search for a Patient");
                return 1;
            }
            if(current_patient.appointments.Count == 0)
            {
                MessageBox.Show("Patient has no appointments");
                return 1;
            }
            if(this.printer_name.Equals(string.Empty))
            {
                MessageBox.Show("Please Configure Printer");
                return 1;
            }
            return 0;
            
        }

        private void sourceAutocompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NameTB.AutoCompleteCustomSource = Search.setup_autocomplete();
        }

    }
}
