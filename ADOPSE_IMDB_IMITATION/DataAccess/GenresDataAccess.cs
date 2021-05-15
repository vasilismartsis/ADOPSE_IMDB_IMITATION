using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public static class GenresDataAccess
    {
        public static void AddMovieToGenreEntriesTable(int movieId, List<int> genreIds)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                foreach (int genreId in genreIds)
                {
                    const string commandText = "" +
                        "INSERT INTO GenreEntries (movieId, genreId) " +
                        "VALUES (@movieId, @genreId)" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@movieId", movieId);
                    command.Parameters.AddWithValue("@genreId", genreId);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }

        public static List<Genre> GetAllGenres()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                List<Genre> genres = new List<Genre>();

                const string commandText = "" +
                "SELECT * " +
                "FROM Genres" +
                ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Genre genre = new Genre();

                    genre.Id = int.Parse(reader["Id"].ToString());
                    genre.Name = reader["name"].ToString();

                    genres.Add(genre);
                }

                connection.Close();

                return genres;
            }
        }

        public static int GetGenreIdByName(String name)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                "SELECT Id " +
                "FROM Genres " +
                "WHERE name = @name" +
                ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@name", name);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }

                connection.Close();

                return 0;
            }
        }

        public static int AddGenreIdByName(String name)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                int ep = 0;
                const string commandText = "" +
                    "INSERT INTO Genres (name) " +
                    "VALUES (@name)" +
                    "SELECT SCOPE_IDENTITY()" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@name", name);

                connection.Open();

                ep = Convert.ToInt32(command.ExecuteScalar());
                //ep=command.ExecuteNonQuery();

                connection.Close();
                return ep;
            }
        }

        public static String GetGenreNameById(int Id)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                "SELECT name " +
                "FROM Genres " +
                "WHERE Id = @Id" +
                ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@Id", Id);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    String name = reader["name"].ToString();

                    return name;
                }

                connection.Close();

                return null;
            }
        }

        public static List<int> GetGenreIdsByMovieID(int movieId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                "SELECT genreId " +
                "FROM GenreEntries " +
                "WHERE movieId = @movieId" +
                ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@movieId", movieId);

                connection.Open();

                List<int> genreIds = new List<int>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    genreIds.Add(reader.GetInt32(0));
                }

                connection.Close();

                return genreIds;
            }
        }
    }
}
