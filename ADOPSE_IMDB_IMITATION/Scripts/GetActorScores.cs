using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.Scripts
{
    class GetActorScores
    {
        float GetActorScore(int actorId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT score " +
                    "FROM ActorRatings" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    int sum = 0;
                    int total = 0;

                    while (reader.Read())
                    {
                        sum += reader.GetInt32(0);
                        total++;
                    }

                    return sum / total;
                }
            }
        }
    }
}
