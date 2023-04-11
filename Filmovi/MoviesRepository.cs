using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SqlClient;

namespace Filmovi
{
    public class MoviesRepository
    {
        readonly string ConnectionString = @"Server=; DATABASE=; User ID=; Password=; Integrated Security=False; Trusted_Connection=False;";


        public List<Movies> GetAll()
        {
            var movies = new List<Movies> ();
            using (DbConnection connection = new SqlConnection(ConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM sertic_Movies";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movies.Add(new Movies()
                        {
                            Movie_ID = (int)reader["MOVIE_ID"],
                            Title = (string)reader["TITLE"],
                            Year = (string)reader["YEAR"],
                            Rated = (string)reader["RATED"],
                            Released = (string)reader["RELEASED"],
                            Runtime = (string)reader["RUNTIME"],
                            Genre = (string)reader["GENRE"],
                            Director = (string)reader["DIRECTOR"],
                            Writer = (string)reader["WRITER"],
                            Actors = (string)reader["ACTORS"],
                            Plot = (string)reader["PLOT"],
                            Language = (string)reader["LANGUAGE"],
                            Country = (string)reader["COUNTRY"],
                            Awards = (string)reader["AWARDS"],
                            Poster = (string)reader["POSTER"],
                            Metascore = (string)reader["METASCORE"],
                            ImdbRating = (string)reader["IMDB_RATING"],
                            ImdbVotes = (string)reader["IMDB_VOTES"],
                            ImdbID = (string)reader["IMDB_ID"],
                            Type = (string)reader["TYPE"],
                            DVD = (string)reader["DVD"],
                            BoxOffice = (string)reader["BOXOFFICE"],
                            Production = (string)reader["PRODUCTION"],
                            Website = (string)reader["WEBSITE"],
                            Response = (string)reader["RESPONSE"],
                            My_Rating = (string)reader["MY_RATING"]
                        });
                    }
                }
            }
            return movies;
        }

        public List<Users> GetAllUsers()
        {
            var users = new List<Users>();
            using (DbConnection connection = new SqlConnection(ConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM sertic_Users";
                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Users()
                        {
                            UserID = (int)reader["ID"],
                            Username = (string)reader["Username"],
                            Email = (string)reader["Email"],
                            Password = (string)reader["Password"]
                        });
                    }
                }
            }
            return users;
        }

        public void AddMovie(Movies oMovie, string ocjena)
        {
            using (DbConnection oConnection = new SqlConnection(ConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "INSERT INTO sertic_Movies (TITLE, YEAR, RATED, RELEASED, RUNTIME, GENRE, DIRECTOR, WRITER, ACTORS, PLOT, LANGUAGE, COUNTRY, AWARDS, POSTER, METASCORE, IMDB_RATING, IMDB_VOTES, IMDB_ID, TYPE, DVD, BOXOFFICE, PRODUCTION, WEBSITE, RESPONSE, MY_RATING) VALUES (@title, @year, @rated, @released, @runtime, @genre, @director, @writer, @actors, @plot, @language, @country, @awards, @poster, @metascore, @imdb_rating, @imdb_votes, @imdb_id, @type, @dvd, @boxoffice, @production, @website, @response, @my_rating)";

                var p1 = oCommand.CreateParameter();
                p1.ParameterName = "@title";
                p1.Value = oMovie.Title;
                oCommand.Parameters.Add(p1);

                var p2 = oCommand.CreateParameter();
                p2.ParameterName = "@year";
                p2.Value = oMovie.Year;
                oCommand.Parameters.Add(p2);

                var p3 = oCommand.CreateParameter();
                p3.ParameterName = "@rated";               
                p3.Value = oMovie.Rated;
                oCommand.Parameters.Add(p3);

                var p4 = oCommand.CreateParameter();
                p4.ParameterName = "@released";
                p4.Value = oMovie.Released;
                oCommand.Parameters.Add(p4);

                var p5 = oCommand.CreateParameter();
                p5.ParameterName = "@runtime";
                p5.Value = oMovie.Runtime;
                oCommand.Parameters.Add(p5);

                var p6 = oCommand.CreateParameter();
                p6.ParameterName = "@genre";
                p6.Value = oMovie.Genre;
                oCommand.Parameters.Add(p6);

                var p7 = oCommand.CreateParameter();
                p7.ParameterName = "@director";
                p7.Value = oMovie.Director;
                oCommand.Parameters.Add(p7);

                var p8 = oCommand.CreateParameter();
                p8.ParameterName = "@writer";
                p8.Value = oMovie.Writer;
                oCommand.Parameters.Add(p8);

                var p9 = oCommand.CreateParameter();
                p9.ParameterName = "@actors";
                p9.Value = oMovie.Actors;
                oCommand.Parameters.Add(p9);

                var p10 = oCommand.CreateParameter();
                p10.ParameterName = "@plot";
                p10.Value = oMovie.Plot;
                oCommand.Parameters.Add(p10);

                var p11 = oCommand.CreateParameter();
                p11.ParameterName = "@language";
                p11.Value = oMovie.Language;
                oCommand.Parameters.Add(p11);

                var p12 = oCommand.CreateParameter();
                p12.ParameterName = "@country";
                p12.Value = oMovie.Country;
                oCommand.Parameters.Add(p12);

                var p13 = oCommand.CreateParameter();
                p13.ParameterName = "@awards";
                p13.Value = oMovie.Awards;
                oCommand.Parameters.Add(p13);

                var p14 = oCommand.CreateParameter();
                p14.ParameterName = "@poster";
                p14.Value = oMovie.Poster;
                oCommand.Parameters.Add(p14);

                var p16 = oCommand.CreateParameter();
                p16.ParameterName = "@metascore";
                p16.Value = oMovie.Metascore;
                oCommand.Parameters.Add(p16);

                var p17 = oCommand.CreateParameter();
                p17.ParameterName = "@imdb_rating";
                p17.Value = oMovie.ImdbRating;
                oCommand.Parameters.Add(p17);

                var p18 = oCommand.CreateParameter();
                p18.ParameterName = "@imdb_votes";
                p18.Value = oMovie.ImdbVotes;
                oCommand.Parameters.Add(p18);

                var p19 = oCommand.CreateParameter();
                p19.ParameterName = "@imdb_id";
                p19.Value = oMovie.ImdbID;
                oCommand.Parameters.Add(p19);

                var p20 = oCommand.CreateParameter();
                p20.ParameterName = "@type";
                p20.Value = oMovie.Type;
                oCommand.Parameters.Add(p20);
                
                var p21 = oCommand.CreateParameter();
                p21.ParameterName = "@dvd";
                p21.Value = oMovie.DVD;
                oCommand.Parameters.Add(p21);

                var p22 = oCommand.CreateParameter();
                p22.ParameterName = "@boxoffice";
                p22.Value = oMovie.BoxOffice;
                oCommand.Parameters.Add(p22);

                var p23 = oCommand.CreateParameter();
                p23.ParameterName = "@production";
                p23.Value = oMovie.Production;
                oCommand.Parameters.Add(p23);

                var p24 = oCommand.CreateParameter();
                p24.ParameterName = "@website";
                p24.Value = oMovie.Website;
                oCommand.Parameters.Add(p24);

                var p25 = oCommand.CreateParameter();
                p25.ParameterName = "@response";
                p25.Value = oMovie.Response;
                oCommand.Parameters.Add(p25);

                var p26 = oCommand.CreateParameter();
                p26.ParameterName = "@my_rating";
                p26.Value = ocjena;
                oCommand.Parameters.Add(p26);

                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {}
            }
        }

        public void SpremiNovuOcjenu(string ocjena, string imefilma)
        {
            using (DbConnection connection = new SqlConnection(ConnectionString))
            using (DbCommand command = connection.CreateCommand())
            { 
                command.CommandText = "UPDATE sertic_Movies SET MY_RATING = @ocjena WHERE TITLE = @title";

                var p1 = command.CreateParameter();
                p1.ParameterName = "@ocjena";
                p1.Value = ocjena;
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.ParameterName = "@title";
                p2.Value = imefilma;
                command.Parameters.Add(p2);

                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                {}
            }
        }

        public void ObrisiFilm(string imefilma, string godinafilma)
        {
            using (DbConnection connection = new SqlConnection(ConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM sertic_Movies WHERE TITLE = @title AND YEAR = @godina";

                var p1 = command.CreateParameter();
                p1.ParameterName = "@godina";
                p1.Value = godinafilma;
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.ParameterName = "@title";
                p2.Value = imefilma;
                command.Parameters.Add(p2);

                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                { }
            }

            
        }

        public void RefreshOcjena(string ocjena, string imefilma)
        {
            using (DbConnection connection = new SqlConnection(ConnectionString))
            using (DbCommand command = connection.CreateCommand())
            {
                command.CommandText = "UPDATE sertic_Movies SET IMDB_RATING = @ocjena WHERE TITLE = @title";

                var p1 = command.CreateParameter();
                p1.ParameterName = "@ocjena";
                p1.Value = ocjena;
                command.Parameters.Add(p1);

                var p2 = command.CreateParameter();
                p2.ParameterName = "@title";
                p2.Value = imefilma;
                command.Parameters.Add(p2);

                connection.Open();
                using (DbDataReader reader = command.ExecuteReader())
                { }
            }
        }

    }
}
