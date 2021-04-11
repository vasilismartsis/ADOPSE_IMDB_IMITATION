using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Scripts
{
    class RateActors
    {
        void RateActor(int actorId, int score)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO ActorRatings (userId, actorId, score) " +
                    "VALUES (@userId, @movieId, @score);" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId,", Session.userId);
                command.Parameters.AddWithValue("@actorId", actorId);
                command.Parameters.AddWithValue("@score", score);

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
