using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    class SearchWithFilters
    {
        public static List<int> GetMoviesByGenre(Genre genre)
        {
            List<int> list = new List<int>();
            int genreId;
            genreId = GenresDataAccess.GetGenreIdByName(genre.Name);
            if (genreId != 0)
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
                {
                    string commandText = "" +
                        "SELECT movieId " +
                        "FROM GenreEntries " +
                        "WHERE genreId=@genreId " +
                        ";";
                    SqlCommand command = new SqlCommand(commandText, connection);
                    command.Parameters.AddWithValue("@genreId", genreId);
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

       public static List<Movie> GetOnlySeries()
        {
            List<Movie> listofSeries = new List<Movie>();
            List<Movie> listofAllMovies = new List<Movie>();
            listofAllMovies = MovieDataAccess.GetAllMovies(MovieType.All);
            foreach (Movie movie in listofAllMovies) 
            {
                if (movie.IsSeries == true)
                {
                    listofSeries.Add(movie);
                }
            }


            return listofSeries;
        }
        public static List<Movie> GetOnlyMovies()
        {
            List<Movie> listofMovies = new List<Movie>();
            List<Movie> listofAllMovies = MovieDataAccess.GetAllMovies(MovieType.All);
            foreach (Movie movie in listofAllMovies)
            {
                if (movie.IsSeries == false)
                {
                    listofMovies.Add(movie);
                }
            }


            return listofMovies;
        }
        public static List<Movie> GetMoviesByDirector(String director)
        {
            List<Movie> movies = new List<Movie>();
            List<Movie> listofAllMovies = MovieDataAccess.GetAllMovies(MovieType.All);
            foreach (Movie movie in listofAllMovies)
            {
                if (movie.Director == director)
                {
                    movies.Add(movie);
                }
            }


            return movies;
        }

        public static List<Movie> GetMoviesByDate(DateTime earliest, DateTime latest)
        {
            if (earliest > latest)
            {
                DateTime newearliest = latest;
                latest = earliest;
                earliest = newearliest;
            }
            
            
            
            
            List<Movie> listOfmovies = new List<Movie>();
            List<Movie> listofAllMovies = MovieDataAccess.GetAllMovies(MovieType.All);
            foreach (Movie movie in listofAllMovies)
            {
                if ( Convert.ToDateTime(movie.ReleaseDate) >= earliest )
                {
                    if (Convert.ToDateTime(movie.ReleaseDate) <= latest)
                    {
                        listOfmovies.Add(movie);
                    }
                }
            }

            return listOfmovies;
        }
    }
}
