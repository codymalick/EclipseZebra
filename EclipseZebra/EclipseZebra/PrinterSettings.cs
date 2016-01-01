using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EclipseZebra
{
    public partial class PrinterSettings : Form
    {
        public PrinterSettings()
        {
            InitializeComponent();
            if(File.Exists("printerSettings.txt"))
            {
                PrinterTB.Text = File.ReadAllText("printerSettings.txt");
            }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(PrinterTB.Text != string.Empty)
            {
                File.WriteAllText("printerSettings.txt", PrinterTB.Text);
                this.Close();
            }
                
                
        }

        private void PrinterTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    PrintDialog print = new PrintDialog();
        //    print.ShowDialog();

        //}
    }
}
