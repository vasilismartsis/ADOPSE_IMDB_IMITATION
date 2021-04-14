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

                    genre.id = int.Parse(reader["Id"].ToString());
                    genre.name = reader["name"].ToString();

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
    }
}
