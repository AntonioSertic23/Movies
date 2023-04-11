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
    public partial class FormAddMovie : Form
    {

        private MoviesRepository _MoviesRepository = new MoviesRepository();

        public FormAddMovie()
        {
            InitializeComponent();
        }

        Movies TajFilm;

        public void UzimanjeFilma(Movies film)
        {
            TajFilm = film;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (SviNaziviFilmovaUBazi())
            {
                string text = "Film se već nalazi u vašoj listi!";
                msg m = new msg(text);
                m.ShowDialog();
                this.Close();
            }
            else
            {
                var unesenavrijednost = textBoxOcjena.Text;
                if (unesenavrijednost != "")
                {
                    if (unesenavrijednost.All(char.IsDigit))
                    {
                        var ocjena = Int32.Parse(unesenavrijednost);
                        if (ocjena >= 0 && ocjena <= 10)
                        {
                            _MoviesRepository.AddMovie(TajFilm, unesenavrijednost);

                            string text = "Film uspješno dodan u vašu listu!";
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

                    }
                    else
                    {
                        string text = "Niste unjeli broj!";
                        msg m = new msg(text);
                        m.ShowDialog();
                    }
                }
                else
                {
                    string text = "Molimo unesite ocjenu!";
                    msg m = new msg(text);
                    m.ShowDialog();
                }
                               
            }
           
        }

        public bool SviNaziviFilmovaUBazi()
        {
            List<Movies> SviFilmovi = _MoviesRepository.GetAll();
            var brojac = 0; 
            var imefilma = movieTitle.Text;
            
            foreach (var film in SviFilmovi)
            {
                if (imefilma == film.Title)
                {
                    brojac++;
                }
            }

            if (brojac > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}