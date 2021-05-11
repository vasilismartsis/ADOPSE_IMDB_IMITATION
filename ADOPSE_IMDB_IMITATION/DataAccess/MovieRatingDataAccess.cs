using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public class MovieRatingFromDB
    {
        #region Public Properties
        public int Id { get; set; }
        public int userId { get; set; }
        public int movieId { get; set; }
        public int score { get; set; }
        #endregion
    }

    public static class MovieRatingDataAccess
    {
         public static MovieRatingFromDB GetByUserIdAndMovieId(int userId, int movieId)
        {
            var result = new MovieRatingFromDB();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT Id, userId, movieId, score " +
                    "FROM MovieRatings " +
                    "WHERE userId = @UserId and movieId = @Movieid;";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@Movieid", movieId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Id = int.Parse(reader["Id"].ToString());
                        result.userId = int.Parse(reader["userId"].ToString());
                        result.movieId = int.Parse(reader["movieId"].ToString());
                        result.score = int.Parse(reader["score"].ToString());
                    }
                }

                connection.Close();
            }

            return result;
        }

        public static void AddOrUpdateMovieRating(MovieRatingFromDB param)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText =
@"begin transaction
if exists(select * from MovieRatings with (updlock, serializable) where userId = @UserId and movieId = @MovieId)
begin
   update MovieRatings set score = @Score where userId = @UserId and movieId = @MovieId
end
else
begin
    insert into MovieRatings(userId, movieId, score) values(@UserId, @MovieId, @Score)
end
commit transaction; ";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@UserId", param.userId);
                command.Parameters.AddWithValue("@MovieId", param.movieId);
                command.Parameters.AddWithValue("@Score", param.score);

                connection.Open();

                command.ExecuteNonQuery();
                
                connection.Close();
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
