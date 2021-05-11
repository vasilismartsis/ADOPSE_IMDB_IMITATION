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
        //public static List<ActorFromDB> GetAll()
        //{
        //    var result = new List<ActorFromDB>();

        //    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
        //    {
        //        const string commandText = "" +
        //            "SELECT Id, firstName, lastName, dateOfBirth " +
        //            "FROM Actors;";

        //        SqlCommand command = new SqlCommand(commandText, connection);

        //        connection.Open();

        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                var newActor = new ActorFromDB();

        //                newActor.Id = int.Parse(reader["Id"].ToString());
        //                newActor.firstName = reader["firstName"].ToString();
        //                newActor.lastName = reader["lastName"].ToString();
        //                newActor.dateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());

        //                result.Add(newActor);
        //            }
        //        }

        //        connection.Close();
        //    }

        //    return result;
        //}

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
                command.Parameters.AddWithValue("@Movieid", param.movieId);
                command.Parameters.AddWithValue("@Score", param.score);

                connection.Open();

                command.ExecuteNonQuery();
                
                connection.Close();
            }
        }

        public static void SaveExistingActor(ActorFromDB param)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "Update Actors " +
                    "set firstName = @FirstName, lastName = @lastName, dateOfBirth = @DateOfBirth " +
                    "WHERE Id = @ActorId;";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@ActorId", param.Id);
                command.Parameters.AddWithValue("@FirstName", param.firstName);
                command.Parameters.AddWithValue("@LastName", param.lastName);
                command.Parameters.AddWithValue("@DateOfBirth", param.dateOfBirth);

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
                //If movie is not rated by currently loged in user, insert new entry into MovieRatings table
                if (!IsActorRatedByCurrentUser(actorId))
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
                //Else update entry in MovieRatings table
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
