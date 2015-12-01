using EclipseZebra.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclipseZebra
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Search search = new Search()
            {
                firstName = this.FirstNameTB.Text,
                lastName = this.LastNameTB.Text
            };
            this.testbox.Text = search.firstName + search.lastName;
        }
    }
}
