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
    public partial class PrijavaForma : Form
    {
        private MoviesRepository _moviesRepository = new MoviesRepository();

        public PrijavaForma()
        {
            InitializeComponent();
            
        }

        private void btnPrijavaPrijava_Click(object sender, EventArgs e)
        {
            string username = inptKorisnickoImePrijava.Text;
            string password = inptLozinkaPrijava.Text;

            List<Users> users = new List<Users>();
            users = _moviesRepository.GetAllUsers();

            var brojac = 0;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password)) {
                
                for (int i = 0; i < users.Count(); i++)
                {
                    if (users[i].Username == username && users[i].Password == password)
                    {
                        brojac++;

                        this.Hide();
                        Form1 form1 = new Form1(users[i].Username);
                        form1.Closed += (s, args) => this.Close();
                        form1.Show();
                    }

                }
                if (brojac == 0) {
                    string text = "Netočno korisničko ime ili lozinka!";
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

        private void btnPrijavaNatrag_Click(object sender, EventArgs e)
        {
            this.Hide();
            FirstForm firstForm = new FirstForm();
            firstForm.Closed += (s, args) => this.Close();
            firstForm.Show();
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked == true)
            {
                inptLozinkaPrijava.UseSystemPasswordChar = false;
            }
            else
            {
                inptLozinkaPrijava.UseSystemPasswordChar = true;
            }
        }
    }
}
