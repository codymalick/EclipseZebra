using System;
using System.IO;
using System.Linq;
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
                Data1TB.Text = File.ReadAllText("dbSettings.txt");
            }
            if (File.Exists("db2Settings.txt"))
            {
                Data2TB.Text = File.ReadAllText("db2Settings.txt");
            }
        }

        private void Data1SB_Click(object sender, EventArgs e)
        {
            if (Data1TB.Text != string.Empty)
            {
                File.WriteAllText("dbSettings.txt", Data1TB.Text);
                this.Close();
            }
        }

        private void Data2SB_Click(object sender, EventArgs e)
        {
            if (Data2TB.Text != string.Empty)
            {
                File.WriteAllText("db2Settings.txt", Data2TB.Text);
                this.Close();
            }
        }


        //Sets the default ODBC Datasources to EclipseAP and EclipseHHC
        public void auto_select_datasources()
        {
            if (!File.Exists("dbSettings.txt"))
            {
                File.WriteAllText("dbSettings.txt", "EclipseHHC");
            }
            if(!File.Exists("db2Settings.txt"))
            {
                File.WriteAllText("db2Settings.txt", "EclipseAP");
            }
        }

    }
}
