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
    public partial class brisanje : Form
    {
        private MoviesRepository _MoviesRepository = new MoviesRepository();
        
        public brisanje(string ime, string godina)
        {
            InitializeComponent();

            lblfilmbrisanje.Text = ime;
            lblgodinabrisanje.Text = godina;
        }

        private void btnfilmbrisanje_Click(object sender, EventArgs e)
        {
            var ime = lblfilmbrisanje.Text;
            var godina = lblgodinabrisanje.Text;


            _MoviesRepository.ObrisiFilm(ime, godina);

            string text = "Uspješno ste obrisali film!";
            msg m = new msg(text);
            m.ShowDialog();
            this.Close();
        }

        private void btnfilmbrisanjeNE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblfilmbrisanje_Click(object sender, EventArgs e)
        {

        }

        private void lblgodinabrisanje_Click(object sender, EventArgs e)
        {

        }
    }
}
