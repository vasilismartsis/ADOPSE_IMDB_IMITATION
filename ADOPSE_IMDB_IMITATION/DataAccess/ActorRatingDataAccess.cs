using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public class ActorRatingFromDB
    {
        #region Public Properties
        public int Id { get; set; }
        public int userId { get; set; }
        public int actorId { get; set; }
        public int score { get; set; }
        #endregion
    }

    public static class ActorRatingDataAccess
    {
        public static ActorRatingFromDB GetByUserIdAndMovieId(int userId, int actorId)
        {
            var result = new ActorRatingFromDB();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT Id, userId, actorId, score " +
                    "FROM ActorRatings " +
                    "WHERE userId = @UserId and actorId = @ActorId;";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@ActorId", actorId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Id = int.Parse(reader["Id"].ToString());
                        result.userId = int.Parse(reader["userId"].ToString());
                        result.actorId = int.Parse(reader["actorId"].ToString());
                        result.score = int.Parse(reader["score"].ToString());
                    }
                }

                connection.Close();
            }

            return result;
        }

        public static void AddOrUpdateActorRating(ActorRatingFromDB param)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText =
@"begin transaction
if exists(select * from ActorRatings with (updlock, serializable) where userId = @UserId and actorId = @ActorId)
begin
   update ActorRatings set score = @Score where userId = @UserId and actorId = @ActorId
end
else
begin
    insert into ActorRatings(userId, actorId, score) values(@UserId, @ActorId, @Score)
end
commit transaction; ";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@UserId", param.userId);
                command.Parameters.AddWithValue("@ActorId", param.actorId);
                command.Parameters.AddWithValue("@Score", param.score);

                connection.Open();

                command.ExecuteNonQuery();
                
                connection.Close();
            }
        }

        public static float GetActorScoreByActorId(int actorId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT score " +
                    "FROM ActorRatings " +
                    "WHERE actorId = @actorId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@actorId", actorId);

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

        public static void RateActor(int actorId, int score)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                //If movie is not rated by currently loged in user, insert new entry into ActorRatings table
                if (!IsActorRatedByCurrentUser(actorId))
                {
                    const string commandText = "" +
                        "INSERT INTO ActorRatings (userId, actorId, score) " +
                        "VALUES (@userId, @actorId, @score);" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@userId,", Session.userId);
                    command.Parameters.AddWithValue("@actorId", actorId);
                    command.Parameters.AddWithValue("@score", score);

                    connection.Open();

                    command.ExecuteNonQuery();
                }
                //Else update entry in ActorRatings table
                else
                {
                    const string commandText = "" +
                        "UPDATE ActorRatings " +
                        "SET score = @score " +
                        "WHERE userId = @userId AND actorId = @actorId" +
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

        public static bool IsActorRatedByCurrentUser(int actorId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT actorId " +
                    "FROM ActorRatings " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId,", Session.userId);

                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        if (reader.GetInt32(0) == actorId)
                            return true;

                    return false;
                }
            }
        }
    }
}
