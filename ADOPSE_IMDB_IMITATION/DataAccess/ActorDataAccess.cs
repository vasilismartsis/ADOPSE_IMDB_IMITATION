using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public class ActorFromDB
    {
        #region Public Properties
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }
        public double? Score { get; set; }
        #endregion
    }

    public static class ActorDataAccess
    {
        public static List<ActorFromDB> GetAll()
        {
            var result = new List<ActorFromDB>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                string commandText =
                 $@"SELECT
                               a.[Id]
                              ,a.[firstName]
                              ,a.[lastName]
                              ,a.[dateOfBirth]
	                          ,actorRtngs.FinalScore
                        FROM
                             Actors a
                        LEFT OUTER JOIN
                             (
                             select actorId, (sum(score) / count(1)) as FinalScore
			                        from ActorRatings as ar
			                        group by ar.actorId
                             ) AS actorRtngs ON actorRtngs.actorId= a.Id;";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var newActor = new ActorFromDB();

                        newActor.Id = int.Parse(reader["Id"].ToString());
                        newActor.firstName = reader["firstName"].ToString();
                        newActor.lastName = reader["lastName"].ToString();
                        newActor.dateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());
                        newActor.Score = reader["FinalScore"] == System.DBNull.Value ? (double?)null : Convert.ToDouble(reader["FinalScore"]);

                        result.Add(newActor);
                    }
                }

                connection.Close();
            }

            return result;
        }

        public static ActorFromDB GetById(int actorId)
        {
            var result = new ActorFromDB();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT Id, firstName, lastName, dateOfBirth " +
                    "FROM Actors " +
                    "WHERE Id = @ActorId;";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@ActorId", actorId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        result.Id = int.Parse(reader["Id"].ToString());
                        result.firstName = reader["firstName"].ToString();
                        result.lastName = reader["lastName"].ToString();
                        result.dateOfBirth = DateTime.Parse(reader["dateOfBirth"].ToString());
                    }
                }

                connection.Close();
            }

            return result;
        }

        public static int AddNewActor(ActorFromDB param)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "INSERT INTO Actors (firstName, lastName, dateOfBirth) " +
                                            "VALUES (@FirstName, @LastName, @DateOfBirth);SELECT SCOPE_IDENTITY();";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@FirstName", param.firstName);
                command.Parameters.AddWithValue("@LastName", param.lastName);
                command.Parameters.AddWithValue("@DateOfBirth", param.dateOfBirth);

                connection.Open();

                result = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
            }

            return result;
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

        public static int GetActorIdByName(String name)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                "SELECT Id " +
                "FROM Actors " +
                "WHERE actorName = @name" +
                ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@name", name);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetInt32(0);
                }

                connection.Close();

                return 0;
            }
        }

        public static int AddActorIdByName3(Person actorToAdd)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                int ep = 0;
                const string commandText = "" +
                    "INSERT INTO Actors (actorName, actorId, dateOfBirth, poster) " +
                    "VALUES (@name, @actorId, @birthday, @profile_path)" +
                    "SELECT SCOPE_IDENTITY()" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@name", actorToAdd.name);
                command.Parameters.AddWithValue("@actorId", actorToAdd.id);
                command.Parameters.AddWithValue("@birthday", actorToAdd.birthday);
                command.Parameters.AddWithValue("@profile_path", actorToAdd.profile_path);

                connection.Open();

                ep = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();
                return ep;
            }
        }

        public static void AddMovieToActorEntriesTable(int movieId, List<int> actorIds)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                foreach (int actorId in actorIds)
                {
                    const string commandText = "" +
                        "INSERT INTO ActorEntries (movieId, actorId) " +
                        "VALUES (@movieId, @actorId)" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@movieId", movieId);
                    command.Parameters.AddWithValue("@actorId", actorId);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
    }
}
