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
    public partial class DatabaseSettings : Form
    {
        public DatabaseSettings()
        {
            InitializeComponent();
            if (File.Exists("dbSettings.txt"))
            {
                textBox1.Text = File.ReadAllText("dbSettings.txt");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                File.WriteAllText("dbSettings.txt", textBox1.Text);
                this.Close();
            }
        }
    }
}
