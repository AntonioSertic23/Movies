using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovi
{
    public partial class RegForma : Form
    {
        readonly string ConnectionString = @"Server=; DATABASE=; User ID=; Password=; Integrated Security=False; Trusted_Connection=False;";

        private MoviesRepository _moviesRepository = new MoviesRepository();

        public RegForma()
        {            
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Users> users = new List<Users>();
            users = _moviesRepository.GetAllUsers();

            string username = txtKorisnickoIme.Text;
            string email = txtEmail.Text;
            string password1 = txtLozinka1.Text;
            string password2 = txtLozinka2.Text;

            var brojac = 0;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password1) && !string.IsNullOrEmpty(password2))
            {
                if (password1 == password2)
                {
                    foreach (var user in users)
                    {
                        if (user.Email == email)
                        {
                            string text = "Taj email je već registriran!";
                            msg m = new msg(text);
                            m.ShowDialog();

                            brojac++;
                            break;
                            
                        }
                        if (user.Username == username)
                        {
                            string text = "To kosničko ime je zauzeto!";
                            msg m = new msg(text);
                            m.ShowDialog();

                            brojac++;
                            break;
                        }
                    }

                    if (brojac == 0)
                    {
                        DodajUsera(username, email, password1);
                        
                        string text = "Korisnik uspješno registriran!";
                        msg m = new msg(text);
                        m.ShowDialog();
                        
                        this.Hide();
                        FirstForm firstForm = new FirstForm();
                        firstForm.Closed += (s, args) => this.Close();
                        firstForm.Show();
                    }
                }
                else
                {
                    string text = "Lozinke se ne podudaraju!";
                    msg m = new msg(text);
                    m.ShowDialog();
                }
            }
            else
            {
                string text = "Niste ispunili sve upite!";
                msg m = new msg(text);
                m.ShowDialog();
            }
        }
        

        public void DodajUsera(string username, string email, string password)
        {
            using (DbConnection oConnection = new SqlConnection(ConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO sertic_Users (Username, Email, Password) VALUES (@username, @email, @password)";

                var p1 = oCommand.CreateParameter();
                p1.ParameterName = "@username";
                p1.Value = username;
                oCommand.Parameters.Add(p1);

                var p2 = oCommand.CreateParameter();
                p2.ParameterName = "@email";
                p2.Value = email;
                oCommand.Parameters.Add(p2);

                var p3 = oCommand.CreateParameter();
                p3.ParameterName = "@password";
                p3.Value = password;
                oCommand.Parameters.Add(p3);

                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                { }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.Closed += (s, args) => this.Close();
            firstForm.Show();

        }
    }
}
