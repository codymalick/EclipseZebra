using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing.Printing;

namespace EclipseZebra
{
    public partial class PrinterSettings : Form
    {


        List<string> printer_list = new List<string>();
        public PrinterSettings()
        {
            InitializeComponent();
            if(File.Exists("printerSettings.txt"))
            {
                PrinterTB.Text = File.ReadAllText("printerSettings.txt");
            }

            foreach(var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                printer_list.Add(printer.ToString());
            }

            printer_box1.Items.AddRange(printer_list.ToArray());         
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(PrinterTB.Text != string.Empty)
            {
                File.WriteAllText("printerSettings.txt", printer_box1.SelectedItem.ToString());
                this.Close();
            }
                
                
        }

        private void PrinterTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void printer_box1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string printer_name = printer_box1.SelectedItem.ToString();
            PrinterTB.Text = printer_name;
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PrintDialog print = new PrintDialog();
        //    print.ShowDialog();

        //}
    }
}
