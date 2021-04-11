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
        #endregion
    }

    public static class ActorDataAccess
    {
        public static List<ActorFromDB> GetAll()
        {
            var result = new List<ActorFromDB>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT Id, firstName, lastName, dateOfBirth " +
                    "FROM Actors;";

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
    }
}
