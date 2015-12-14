using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclipseZebra
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if(File.Exists("settings.txt"))
            {
                PrinterTB.Text = File.ReadAllText("settings.txt");
            }
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(PrinterTB.Text != string.Empty)
            {
                File.WriteAllText("settings.txt", PrinterTB.Text);
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
