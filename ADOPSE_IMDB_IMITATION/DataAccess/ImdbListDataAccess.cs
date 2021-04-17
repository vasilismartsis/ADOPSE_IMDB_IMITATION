using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public static class ImdbListDataAccess
    {
        public static int AddList(string listName)
        {
            int listId;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO Lists (userId, name, state) " +
                    "VALUES (@userId, @name, @state)" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@name", listName);
                command.Parameters.AddWithValue("@state", "Public");

                connection.Open();

                listId = Convert.ToInt32(command.ExecuteScalar());
            }

            return listId;
        }

        public static ImdbList GetListById(int listId)
        {
            ImdbList imdbList = new ImdbList();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM Lists " +
                    "WHERE Id = @listId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", listId);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    imdbList.Id = (int)reader["Id"];
                    imdbList.UserId = (int)reader["userId"];
                    imdbList.Name = reader["name"].ToString();
                    imdbList.State = reader["state"].ToString();
                }

                connection.Close();
            }

            return imdbList;
        }

        public static List<ImdbList> GetListsByUserId(int userId)
        {
            List<ImdbList> imdbLists = new List<ImdbList>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM Lists " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ImdbList imdbList = new ImdbList
                        {
                            Id = (int)reader["Id"],
                            UserId = (int)reader["userId"],
                            Name = reader["name"].ToString(),
                            State = reader["state"].ToString(),
                        };

                        imdbLists.Add(imdbList);
                    }
                }

                connection.Close();
            }

            return imdbLists;
        }

        public static List<Movie> GetMoviesInListByListId(int listId)
        {
            List<int> movieIdsInList = GetMovieIdsInListByListId(listId);
            List<Movie> movies = new List<Movie>();

            if (movieIdsInList.Count > 0)
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
                {
                    string commandText = "" +
                        "SELECT * " +
                        "FROM Movies " +
                        "WHERE ";

                    for (int i = 0; i < movieIdsInList.Count; i++)
                    {
                        commandText += "id = " + movieIdsInList[i];

                        if (i < movieIdsInList.Count - 1)
                            commandText += " OR ";
                    }

                    SqlCommand command = new SqlCommand(commandText, connection);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            movies.Add(new Movie
                            {
                                Id = int.Parse(reader["Id"].ToString()),
                                Name = reader["name"].ToString(),
                                ReleaseDate = reader["releaseDate"].ToString(),
                                Image = reader["image"].ToString(),
                                Trailer = reader["trailer"].ToString(),
                                Director = reader["director"].ToString(),
                                IsSeries = Convert.ToBoolean(reader["isSeries"]),
                                Description = reader["description"].ToString()
                            });

                    return movies;
                }
            else
                return null;
        }

        static List<int> GetMovieIdsInListByListId(int listId)
        {
            List<int> moviesIdsInList = new List<int>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT movieId " +
                    "FROM ListEntries " +
                    "WHERE userId = @userId AND listId = @listId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@listId", listId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                        moviesIdsInList.Add(reader.GetInt32(0));
            }

            return moviesIdsInList;
        }
    }
}
