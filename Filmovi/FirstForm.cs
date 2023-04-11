using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovi
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void buttonRegistracija_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            RegForma RegForma = new RegForma();
            RegForma.Closed += (s, args) => this.Close();
            RegForma.Show();

        }

        private void buttonPrijava_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PrijavaForma PrijavaForma = new PrijavaForma();
            PrijavaForma.Closed += (s, args) => this.Close();
            PrijavaForma.Show();
        }
    }
}
