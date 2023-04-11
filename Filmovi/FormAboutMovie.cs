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
    public partial class FormAboutMovie : Form
    {
        private MoviesRepository _MoviesRepository = new MoviesRepository();

        public FormAboutMovie()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            var imefilma = movieTitle.Text;

            var unesenavrijednost = textBoxOcjena.Text;
            if (unesenavrijednost.All(char.IsDigit))
            {
                var ocjena = Int32.Parse(unesenavrijednost);
                if (ocjena >= 0 && ocjena <= 10)
                {
                    _MoviesRepository.SpremiNovuOcjenu(unesenavrijednost, imefilma);
                    
                    string text = "Uspješno ste ažurirali ocjenu!";
                    msg m = new msg(text);
                    m.ShowDialog();
                    this.Close();
                }
                else
                {
                    string text = "Unesite vrijednost od 0 do 10!";
                    msg m = new msg(text);
                    m.ShowDialog();
                }

            } else
            {
                string text = "Niste unjeli broj!";
                msg m = new msg(text);
                m.ShowDialog();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var ime = movieTitle.Text;
            var godina = movieYear.Text;

            brisanje br = new brisanje(ime, godina);
            br.ShowDialog();

        }

        
    }
}
