using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public static class MovieDataAccess
    {
        public static List<Movie> GetAllMovies()
        {
            var movies = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT *" +
                    "FROM Movies" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie();

                        movie.id = int.Parse(reader["Id"].ToString());
                        movie.name = reader["name"].ToString();
                        movie.releaseDate = reader["releaseDate"].ToString();
                        movie.image = reader["image"].ToString();
                        movie.trailer = reader["trailer"].ToString();
                        movie.director = reader["director"].ToString();
                        movie.isSeries = Convert.ToBoolean(reader["isSeries"]);
                        movie.description = reader["description"].ToString();

                        movies.Add(movie);
                    }
                }

                connection.Close();
            }

            return movies;
        }

        public static void AddMovie(Movie movie, List<int> genreIds)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO Movies (name, releaseDate, image, trailer, director, isSeries, description) " +
                    "VALUES (@name, @releaseDate, @image, @trailer, @director, @isSeries, @description);" +
                    "SELECT SCOPE_IDENTITY()" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@name", movie.name);
                command.Parameters.AddWithValue("@releaseDate", DateTime.Parse(movie.releaseDate).Date);
                command.Parameters.AddWithValue("@image", movie.image);
                command.Parameters.AddWithValue("@trailer", movie.trailer);
                command.Parameters.AddWithValue("@director", movie.director);
                command.Parameters.AddWithValue("@isSeries", movie.isSeries);
                command.Parameters.AddWithValue("@description", movie.description);

                connection.Open();

                int movieId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                GenresDataAccess.AddMovieToGenreEntriesTable(movieId, genreIds);
            }
        }

        public static void DeleteMovie(int movieId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "DELETE FROM MOVIES " +
                    "WHERE Id = @movieId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@movieId", movieId);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
