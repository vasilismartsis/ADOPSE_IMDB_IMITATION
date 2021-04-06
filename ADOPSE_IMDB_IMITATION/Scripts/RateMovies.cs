using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Scripts
{
    class RateMovies
    {
        void RateMovie(int movieId, int score)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
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
        }
    }
}
