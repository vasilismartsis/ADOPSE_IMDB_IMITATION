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
    public enum MovieType
    {
        All = 0,
        Movie = 1,
        Series = 2,
    }

    public static class MovieDataAccess
    {
        /// <summary>
        /// Retrieves all movies, according to the movieType parameter
        /// </summary>
        /// <param name="movieType"></param>
        /// <returns></returns>
        public static List<Movie> GetAllMovies(MovieType movieType)
        {
            var movies = new List<Movie>();
            string whereClause = string.Empty;

            switch (movieType)
            {
                case MovieType.Movie:
                    whereClause = "Where isSeries = 'false'";
                    break;

                case MovieType.Series:
                    whereClause = "Where isSeries = 'true'";
                    break;

                case MovieType.All:
                default:
                    break;
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                string commandText =
                    $@"SELECT Id, name, releaseDate, image, trailer, director, isSeries, description 
                    FROM Movies {whereClause};";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Movie movie = new Movie
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Name = reader["name"].ToString(),
                            ReleaseDate = reader["releaseDate"].ToString(),
                            Image = reader["image"].ToString(),
                            Trailer = reader["trailer"].ToString(),
                            Director = reader["director"].ToString(),
                            IsSeries = Convert.ToBoolean(reader["isSeries"]),
                            Description = reader["description"].ToString()
                        };

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

                command.Parameters.AddWithValue("@name", movie.Name);
                command.Parameters.AddWithValue("@releaseDate", DateTime.Parse(movie.ReleaseDate).Date);
                command.Parameters.AddWithValue("@image", movie.Image);
                command.Parameters.AddWithValue("@trailer", movie.Trailer);
                command.Parameters.AddWithValue("@director", movie.Director);
                command.Parameters.AddWithValue("@isSeries", movie.IsSeries);
                command.Parameters.AddWithValue("@description", movie.Description);

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

        public static Movie GetMovieById(int movieId)
        {
            Movie movie = new Movie();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM Movies " +
                    "WHERE Id = @movieId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@movieId", movieId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    movie.Id = int.Parse(reader["Id"].ToString());
                    movie.Name = reader["name"].ToString();
                    movie.ReleaseDate = reader["releaseDate"].ToString();
                    movie.Image = reader["image"].ToString();
                    movie.Trailer = reader["trailer"].ToString();
                    movie.Director = reader["director"].ToString();
                    movie.IsSeries = Convert.ToBoolean(reader["isSeries"]);
                    movie.Description = reader["description"].ToString();
                    movie.Score = GetMovieScoreByMovieId(movieId);
                };
            }

            return movie;
        }

        public static List<Movie> GetMoviesByIds(int[] movieIds)
        {
            List<Movie> movies = new List<Movie>();

            foreach (int movieId in movieIds)
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
                {
                    const string commandText = "" +
                        "SELECT * " +
                        "FROM Movies " +
                        "WHERE Id = @movieId" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@movieId", movieId);

                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                        movies.Add(new Movie
                        {
                            Id = int.Parse(reader["Id"].ToString()),
                            Name = reader["name"].ToString(),
                            ReleaseDate = reader["releaseDate"].ToString(),
                            Image = reader["image"].ToString(),
                            Trailer = reader["trailer"].ToString(),
                            Director = reader["director"].ToString(),
                            IsSeries = (bool)reader["isSeries"],
                            Description = reader["description"].ToString(),
                            Score = GetMovieScoreByMovieId(movieId)
                        });
                }

            return movies;
        }

        static float? GetMovieScoreByMovieId(int movieId)
        {
            float? result = null;       //this Movie has no rating yet

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT score " +
                    "FROM MovieRatings " +
                    "WHERE movieId = @movieID" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@movieId", movieId);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    int sum = 0;
                    int total = 0;

                    //the movie has already some ratings
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            sum += reader.GetInt32(0);
                            total++;
                        }
                        result = sum / total;
                    }
                }
            }

            return result;
        }

        public static void RateMovie(int movieId, int score)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                //If movie is not rated by currently loged in user, insert new entry into MovieRatings table
                if (!IsMovieRatedByCurrentUser(movieId))
                {
                    const string commandText = "" +
                    "INSERT INTO MovieRatings (userId, movieId, score) " +
                    "VALUES (@userId, @movieId, @score);" +
                    ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@userId,", Session.userId);
                    command.Parameters.AddWithValue("@movieId", movieId);
                    command.Parameters.AddWithValue("@score", score);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
                //Else update entry in MovieRatings table
                else
                {
                    const string commandText = "" +
                        "UPDATE MovieRatings " +
                        "SET score = @score " +
                        "WHERE userId = @userId AND movieId = @movieId" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@userId,", Session.userId);
                    command.Parameters.AddWithValue("@movieId", movieId);
                    command.Parameters.AddWithValue("@score", score);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
            }
        }

        static bool IsMovieRatedByCurrentUser(int movieId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT movieId " +
                    "FROM MovieRatings " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId,", Session.userId);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        if (reader.GetInt32(0) == movieId)
                            return true;

                    return false;
                }
            }
        }
        public static List<int> GetMoviesByGenre(Genre genre)
        {
            List<int> list = new List<int>();

            if (genre != null)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
                {
                    string commandText = "" +
                        "SELECT movieId " +
                        "FROM GenreEntries " +
                        "WHERE genreId=@genreId " +
                        ";";
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@genreId", genre.Id);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                            list.Add(int.Parse(reader["movieId"].ToString()));
                    }
                }
            }
            else
            {
                list = null;
            }
            return list;
        }
    }
}