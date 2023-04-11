using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Web.Script.Serialization;
using System.IO;

namespace Filmovi
{
    public partial class Form1 : Form
    {
        int page = 1;
        string NazivFilma = "";
        int pageBaza = 1;

        int brojPronadenihStranica = 1;
        int pagePretrazivanje = 0;
        List<Movies> pronadeniFiloviPretrazivanje = new List<Movies>();

        private MoviesRepository _MoviesRepository = new MoviesRepository();

        public Form1(string username)
        {
            InitializeComponent();

            DataGridViewImageColumn oAddButton = new DataGridViewImageColumn(); 
            oAddButton.Image = Image.FromFile("/Resources/AddIcon.ico");
            oAddButton.Width = 16;
            oAddButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewFilmovi.Columns.Add(oAddButton);
            DataGridViewFilmovi.AllowUserToAddRows = false;
            DataGridViewFilmovi.AutoGenerateColumns = false;
            DataGridViewFilmovi.Columns[1].Width = 100;

            DataGridViewImageColumn oAddButton1 = new DataGridViewImageColumn();
            oAddButton1.Image = Image.FromFile("/Resources/AddIcon.ico");
            oAddButton1.Width = 16;
            oAddButton1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewMojiFilmovi.Columns.Add(oAddButton1);
            dataGridViewMojiFilmovi.AllowUserToAddRows = false;
            dataGridViewMojiFilmovi.AutoGenerateColumns = false;

            button5.Text = username;

            IspisivanjeMojihFilmova();
            
        }

        const string ApiKey = "";


        private void ButtonPretrazi_Click(object sender, EventArgs e)
        {
            string title = textBoxTitle.Text;
            string year = textBoxYear.Text;

            if (NazivFilma != title)
            {
                page = 1;
                buttonLeft.Enabled = false;
            }

            ListarFilmes(title, year, page);
        }

        public void ListarFilmes(string film, string year, int page)
        {
            if (year != "")
            {
                using (WebClient webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("http://www.omdbapi.com/?s=" + film + "&y=" + year + "&page=" + page + "&apikey=" + ApiKey);
                    
                    List<Movies> ResultFilm = new List<Movies>();

                    dynamic contourManifest = JObject.Parse(json);
                    string response = contourManifest.Response;
                    
                    if (response == "True")                   {
                        JToken search = JObject.Parse(json).GetValue("Search");
                        ResultFilm = search.Select(f => f.ToObject<Movies>()).ToList();

                        string total = contourManifest.totalResults;
                        int Results = Int32.Parse(total);
                        if (Results <= 10)
                        {
                            Results = 1;
                        }
                        else
                        {
                            Results /= 10;
                        }
                        if (page == Results)
                        {
                            buttonRight.Enabled = false;
                        }
                        else
                        {
                            buttonRight.Enabled = true;
                        }
                        labelBrojStranice.Text = "" + page + "/" + Results + "";
                        NazivFilma = film;

                        IspisNadjenoga(ResultFilm);
                    }
                    else
                    {
                        string text = "Nije pronaden niti jedan film..";
                        IspisMessageBox(text);
                    }

                }
            }
            else
            {
                using (WebClient webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString("http://www.omdbapi.com/?s=" + film + "&page=" + page + "&apikey=" + ApiKey);

                    List<Movies> ResultFilm = new List<Movies>();

                    dynamic contourManifest = JObject.Parse(json);
                    string response = contourManifest.Response;
                    
                    if (response == "True")
                    {
                        JToken search = JObject.Parse(json).GetValue("Search");
                        ResultFilm = search.Select(f => f.ToObject<Movies>()).ToList();

                        string total = contourManifest.totalResults;
                        int Results = Int32.Parse(total);
                        if (Results <= 10)
                        {
                            Results = 1;
                        }
                        else
                        {
                            Results /= 10;
                        }
                        if (page == Results)
                        {
                            buttonRight.Enabled = false;
                        }
                        else
                        {
                            buttonRight.Enabled = true;
                        }
                        labelBrojStranice.Text = "" + page + "/" + Results + "";
                        NazivFilma = film;

                        IspisNadjenoga(ResultFilm);
                    }
                    else
                    {
                        string text = "Nije pronaden niti jedan film..";
                        IspisMessageBox(text);
                    }
                }
            }
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            page--;
            
            if (page == 1)
            {
                buttonLeft.Enabled = false;
            }
            string title = textBoxTitle.Text;
            string year = textBoxYear.Text;

            ListarFilmes(title, year, page);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
                page++;

                buttonLeft.Enabled = true;
                string title = textBoxTitle.Text;
                string year = textBoxYear.Text;

                ListarFilmes(title, year, page);
            
        }

        public void IspisNadjenoga(List<Movies> filmovi)
        {
            DataGridViewFilmovi.Rows.Clear();

            foreach (Movies item in filmovi)
            {
                DataGridViewFilmovi.Rows.Add(item.Title, item.Year);
                DataGridViewFilmovi.Refresh();
            }
        }

        private void DataGridViewFilmovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Movies Jess;
                DataGridViewFilmovi.Rows[e.RowIndex].Selected = true;
                if (DataGridViewFilmovi.CurrentCell.ColumnIndex.Equals(2) && e.RowIndex != -1)
                {
                    FormAddMovie FormAddMovie = new FormAddMovie();
                    var imeFilma = DataGridViewFilmovi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var godinaFilma = DataGridViewFilmovi.Rows[e.RowIndex].Cells[1].Value.ToString();

                    using (WebClient webClient = new WebClient())
                    {
                        var response = webClient.DownloadString("http://www.omdbapi.com/?t=" + imeFilma + "&y=" + godinaFilma + "&apikey=" + ApiKey);

                        Movies movie = Newtonsoft.Json.JsonConvert.DeserializeObject<Movies>(response);
                        Jess = movie;
                        if (movie.Response == "True")
                        {
                            FormAddMovie.movieTitle.Text = movie.Title;
                            FormAddMovie.movieYear.Text = movie.Year;
                            FormAddMovie.lblRuntime.Text = movie.Runtime;
                            FormAddMovie.lblGenre.Text = movie.Genre;
                            FormAddMovie.lblDirector.Text = movie.Director;
                            FormAddMovie.lblimdb.Text = movie.ImdbRating;

                            var request = WebRequest.Create(movie.Poster);
                            using (var resp = request.GetResponse())
                            using (var stream = resp.GetResponseStream())
                            {
                                FormAddMovie.pictureBox1.Image = Bitmap.FromStream(stream);
                                FormAddMovie.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                        else
                        {
                            string text = "Error";
                            IspisMessageBox(text);
                        }
                    }

                    FormAddMovie.UzimanjeFilma(Jess);

                    FormAddMovie.ShowDialog();
                    DataGridViewFilmovi.Refresh();
                    IspisivanjeMojihFilmova();
                }
            }
            
        }               

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        public void IspisivanjeMojihFilmova()
        {
            dataGridViewMojiFilmovi.Rows.Clear();
            var mojifilmovi = _MoviesRepository.GetAll();
            int brojfilmova = mojifilmovi.Count();

            int dotogbroja = pageBaza * 10;
            int odtogbroja = dotogbroja - 10;

            for (var i = odtogbroja; i < dotogbroja; i++)
            {
                if (i == brojfilmova)
                {
                    break;
                }
                else
                {
                    dataGridViewMojiFilmovi.Rows.Add(mojifilmovi[i].Title, mojifilmovi[i].Genre, mojifilmovi[i].Year, mojifilmovi[i].My_Rating, mojifilmovi[i].ImdbRating);
                    dataGridViewMojiFilmovi.Refresh();
                }
            }

            if (pageBaza == ((brojfilmova/10)+1))
            {
                buttonRightBaza.Enabled = false;
            }
            else
            {
                buttonRightBaza.Enabled = true;
            }
            if (pageBaza == 1)
            {
                buttonLeftBaza.Enabled = false;
            }
            else
            {
                buttonLeftBaza.Enabled = true;
            }
            labelBrojStraniceBaza.Text = "" + pageBaza + "/" + ((brojfilmova / 10) + 1) + "";
            
        }
        
        private void buttonLeftBaza_Click(object sender, EventArgs e)
        {
            if (pagePretrazivanje > 1)
            {
                pagePretrazivanje--;
                dataGridViewMojiFilmovi.Rows.Clear();
                
                int brojpronadenihfilmova = pronadeniFiloviPretrazivanje.Count();

                int dotogbroja = pagePretrazivanje * 10;
                int odtogbroja = dotogbroja - 10;

                for (var i = odtogbroja; i < dotogbroja; i++)
                {
                    if (i == brojpronadenihfilmova)
                    {
                        break;
                    }
                    else
                    {
                        dataGridViewMojiFilmovi.Rows.Add(pronadeniFiloviPretrazivanje[i].Title, pronadeniFiloviPretrazivanje[i].Genre, pronadeniFiloviPretrazivanje[i].Year, pronadeniFiloviPretrazivanje[i].My_Rating, pronadeniFiloviPretrazivanje[i].ImdbRating);
                        dataGridViewMojiFilmovi.Refresh();
                    }
                }

                if (pagePretrazivanje == ((brojpronadenihfilmova / 10) + 1))
                {
                    buttonRightBaza.Enabled = false;
                }
                else
                {
                    buttonRightBaza.Enabled = true;
                }
                if (pagePretrazivanje == 1)
                {
                    buttonLeftBaza.Enabled = false;
                }
                else
                {
                    buttonLeftBaza.Enabled = true;
                }
                labelBrojStraniceBaza.Text = "" + pagePretrazivanje + "/" + ((brojpronadenihfilmova / 10) + 1) + "";
            }
            else
            {
                pageBaza--;

                if (page == 1)
                {
                    buttonLeftBaza.Enabled = false;
                }
                IspisivanjeMojihFilmova();
            }
            
        }

        private void buttonRightBaza_Click(object sender, EventArgs e)
        {
            if (pagePretrazivanje >= 1)
            {
                pagePretrazivanje++;
                dataGridViewMojiFilmovi.Rows.Clear();
                
                int brojpronadenihfilmova = pronadeniFiloviPretrazivanje.Count();

                int dotogbroja = pagePretrazivanje * 10;
                int odtogbroja = dotogbroja - 10;

                for (var i = odtogbroja; i < dotogbroja; i++)
                {
                    if (i == brojpronadenihfilmova)
                    {
                        break;
                    }
                    else
                    {
                        dataGridViewMojiFilmovi.Rows.Add(pronadeniFiloviPretrazivanje[i].Title, pronadeniFiloviPretrazivanje[i].Genre, pronadeniFiloviPretrazivanje[i].Year, pronadeniFiloviPretrazivanje[i].My_Rating, pronadeniFiloviPretrazivanje[i].ImdbRating);
                        dataGridViewMojiFilmovi.Refresh();
                    }
                }

                if (pagePretrazivanje == ((brojpronadenihfilmova / 10) + 1))
                {
                    buttonRightBaza.Enabled = false;
                }
                else
                {
                    buttonRightBaza.Enabled = true;
                }
                if (pagePretrazivanje == 1)
                {
                    buttonLeftBaza.Enabled = false;
                }
                else
                {
                    buttonLeftBaza.Enabled = true;
                }
                labelBrojStraniceBaza.Text = "" + pagePretrazivanje + "/" + ((brojpronadenihfilmova / 10) + 1) + "";
            }
            else
            {
                pageBaza++;

                buttonLeftBaza.Enabled = true;

                IspisivanjeMojihFilmova();
            }
                
        }

        private void dataGridViewMojiFilmovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dataGridViewMojiFilmovi.Rows[e.RowIndex].Selected = true;
                if (dataGridViewMojiFilmovi.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
                {
                    FormAboutMovie formAboutMovie = new FormAboutMovie();
                    var imeFilma = dataGridViewMojiFilmovi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    var sviFilmovi = _MoviesRepository.GetAll();

                    foreach (var film in sviFilmovi)
                    {
                        if (film.Title == imeFilma)
                        {
                            formAboutMovie.movieTitle.Text = film.Title;
                            formAboutMovie.movieYear.Text = film.Year;
                            formAboutMovie.lblRuntime.Text = film.Runtime;
                            formAboutMovie.lblGenre.Text = film.Genre;
                            formAboutMovie.lblDirector.Text = film.Director;
                            formAboutMovie.lblimdb.Text = film.ImdbRating;
                            formAboutMovie.lblScenarist.Text = film.Writer;
                            formAboutMovie.lblGlumci.Text = film.Actors;
                            formAboutMovie.lblPremijera.Text = film.Released;
                            formAboutMovie.lblNagrade.Text = film.Awards;
                            formAboutMovie.lblProdukcija.Text = film.Production;
                            formAboutMovie.textBoxOcjena.Text = film.My_Rating;

                            var request = WebRequest.Create(film.Poster);
                            using (var resp = request.GetResponse())
                            using (var stream = resp.GetResponseStream())
                            {
                                formAboutMovie.pictureBox1.Image = Bitmap.FromStream(stream);
                                formAboutMovie.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                        }
                    }

                    formAboutMovie.ShowDialog();
                    dataGridViewMojiFilmovi.Refresh();
                    IspisivanjeMojihFilmova();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var mojifilmovi = _MoviesRepository.GetAll();

            foreach (var film in mojifilmovi)
            {
                var imeFilma = film.Title;
                var godinaFilma = film.Year;

                using (WebClient webClient = new WebClient())
                {
                    var response = webClient.DownloadString("http://www.omdbapi.com/?t=" + imeFilma + "&y=" + godinaFilma + "&apikey=" + ApiKey);

                    Movies movie = Newtonsoft.Json.JsonConvert.DeserializeObject<Movies>(response);
                    
                    if (movie.Response == "True")
                    {
                        if (movie.ImdbRating != film.ImdbRating)
                        {
                            string ocjena = movie.ImdbRating;
                            string nazivfilma = film.Title;
                            _MoviesRepository.RefreshOcjena(ocjena, nazivfilma);
                        }
                    }
                    else
                    {
                        string text = "Error";
                        IspisMessageBox(text);
                    }
                }
            }

            IspisivanjeMojihFilmova();
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            string title = textBoxIme.Text;
            string year = textBoxGodina.Text;
            string genre = textBoxZanr.Text;

            pageBaza = 1;

            SortiranjeFilmova(title, year, genre);
        }

        public void SortiranjeFilmova(string title, string year, string genre)
        {
            var filmovi = _MoviesRepository.GetAll();
            List<Movies> pronadenifilmovi = new List<Movies>();
            int brojac = 0;
            int brojacZ = 0;

            if (title != "")
            {
                if(year != "")
                {
                    if (genre != "")
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Title.ToLower().Contains(title.ToLower()) && film.Year == year && film.Genre.ToLower().Contains(genre.ToLower()))
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tim imenom, godinom i žanrom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }
                    else
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Title.ToLower().Contains(title.ToLower()) && film.Year == year)
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tim imenom i godinom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }

                }
                else {
                    if(genre != "")
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Title.ToLower().Contains(title.ToLower()) && film.Genre.ToLower().Contains(genre.ToLower()))
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tim imenom i žanrom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }
                    else
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Title.ToLower().Contains(title.ToLower()))
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tim imenom!";
                            IspisMessageBox(text);
                            brojac++;
                        }

                    }
                }
            }
            else
            {
                if (year != "")
                {
                    if (genre != "")
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Year == year && film.Genre.ToLower().Contains(genre.ToLower()))
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tom godinom i žanrom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }
                    else {
                        foreach (var film in filmovi)
                        {
                            if (film.Year == year)
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tom godinom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }
                }
                else
                {
                    if (genre != "")
                    {
                        foreach (var film in filmovi)
                        {
                            if (film.Genre.ToLower().Contains(genre.ToLower()))
                            {
                                pronadenifilmovi.Add(film);
                                brojacZ++;
                            }
                        }
                        if (brojacZ == 0)
                        {
                            string text = "Nema filma s tim žanrom!";
                            IspisMessageBox(text);
                            brojac++;
                        }
                    }
                    else
                    {
                        string text = "Niste ispunili niti jedan upit!";
                        IspisMessageBox(text);
                        brojac++;
                    }
                }
                
            }

            if (brojac > 0)
            {
                IspisivanjeMojihFilmova();

                brojPronadenihStranica = 1;
                pronadeniFiloviPretrazivanje.Clear();
                pagePretrazivanje = 0;
            }
            else
            {
                dataGridViewMojiFilmovi.Rows.Clear();
                
                int brojpronadenihfilmova = pronadenifilmovi.Count();

                brojPronadenihStranica = ((brojpronadenihfilmova / 10) + 1);
                pronadeniFiloviPretrazivanje = pronadenifilmovi;
                pagePretrazivanje = 1;

                int dotogbroja = pageBaza * 10;
                int odtogbroja = dotogbroja - 10;

                for (var i = odtogbroja; i < dotogbroja; i++)
                {
                    if (i == brojpronadenihfilmova)
                    {
                        break;
                    }
                    else
                    {
                        dataGridViewMojiFilmovi.Rows.Add(pronadenifilmovi[i].Title, pronadenifilmovi[i].Genre, pronadenifilmovi[i].Year, pronadenifilmovi[i].My_Rating, pronadenifilmovi[i].ImdbRating);
                        dataGridViewMojiFilmovi.Refresh();
                    }
                }

                if (pageBaza == ((brojpronadenihfilmova / 10) + 1))
                {
                    buttonRightBaza.Enabled = false;
                }
                else
                {
                    buttonRightBaza.Enabled = true;
                }
                if (pageBaza == 1)
                {
                    buttonLeftBaza.Enabled = false;
                }
                else
                {
                    buttonLeftBaza.Enabled = true;
                }
                labelBrojStraniceBaza.Text = "" + pageBaza + "/" + ((brojpronadenihfilmova / 10) + 1) + "";

            }

        }

        private bool isCollapsed;

        private void button5_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel3.Height += 45;
                if (panel3.Size == panel3.MaximumSize)
                {
                    isCollapsed = false;
                }
            }
            else
            {
                panel3.Height -= 45;
                if (panel3.Size == panel3.MinimumSize)
                {
                    isCollapsed = true;
                }
            }

        }
        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.GreenYellow;
            button5.ForeColor = Color.Transparent;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.Closed += (s, args) => this.Close();
            firstForm.Show();

        }

        public void IspisMessageBox(string text)
        {
            msg m = new msg(text);
            m.ShowDialog();
        }


    }
}