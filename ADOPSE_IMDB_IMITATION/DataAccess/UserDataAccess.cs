using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public static class UserDataAccess
    {
        public static int AddUser(User user)
        {
            int userId;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                        "INSERT INTO Users (username, password, firstName, lastName, dateOfBirth, isAdministrator) " +
                        "VALUES (@username, @password, @firstName, @lastName, @dateOfBirth, @isAdministrator) " +
                        "SELECT SCOPE_IDENTITY()" +
                        ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@username", user.Username);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@dateOfBirth", DateTime.Parse(user.DateOfBirth));
                command.Parameters.AddWithValue("@isAdministrator", user.IsAdministrator);

                connection.Open();

                userId = Convert.ToInt32(command.ExecuteScalar());

                AddUserSettings(userId);
            }

            return userId;
        }

        static void AddUserSettings(int userId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO UserSettings (userId, state, theme)" +
                    "VALUES (@userId, @state, @theme)" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                Console.WriteLine(Session.userId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@state", "Public");
                command.Parameters.AddWithValue("@theme", "Light");

                connection.Open();

                command.ExecuteNonQuery();
            }
        }

        public static User GetUserById(int userId)
        {
            User user = new User();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM Users " +
                    "WHERE Id = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    user.Id = (int)reader["Id"];
                    user.Username = reader["username"].ToString();
                    user.Password = reader["password"].ToString();
                    user.FirstName = reader["firstName"].ToString();
                    user.LastName = reader["lastName"].ToString();
                    user.DateOfBirth = reader["dateOfBirth"].ToString();
                    user.IsAdministrator = (bool)reader["isAdministrator"];
                    user.UserSettings = GetUserSettingsById(userId);
                }
            }

            return user;
        }

        public static User GetUserByUsernameAndPassword(String username, String password)
        {
            User user = new User();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM Users " +
                    "WHERE username = @username AND password = @password" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        user.Id = (int)reader["Id"];
                        user.Username = reader["username"].ToString();
                        user.Password = reader["password"].ToString();
                        user.FirstName = reader["firstName"].ToString();
                        user.LastName = reader["lastName"].ToString();
                        user.DateOfBirth = reader["dateOfBirth"].ToString();
                        user.IsAdministrator = (bool)reader["isAdministrator"];
                        user.UserSettings = GetUserSettingsById((int)reader["Id"]);
                    }
            }

            return user;
        }

        public static UserSettings GetUserSettingsById(int userId)
        {
            UserSettings userSettings = new UserSettings();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT * " +
                    "FROM UserSettings " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", userId);

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    userSettings.UserId = (int)reader["userId"];
                    userSettings.State = reader["state"].ToString();
                    userSettings.Theme = reader["theme"].ToString();
                }
            }

            return userSettings;
        }

        public static void UpdateUserSettings(UserSettings userSettings)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "UPDATE UserSettings " +
                    "SET state = @state, theme = @theme " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@state", userSettings.State);
                command.Parameters.AddWithValue("@theme", userSettings.Theme);
                command.Parameters.AddWithValue("@userId", Session.userId);

                connection.Open();

                command.ExecuteNonQuery();

                Session.SetThemeColor(MainForm.menuBar);
            }
        }

        public static void UpdateUserHistory(UserHistory ids)
        {

            if (ids.userId != 0)
            {
                DateTime time = DateTime.Now;
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
                {
                    const string commandText = "" +
                            "INSERT INTO UsersMovieHistory(userId, movieId, datetimeBrowsed) " +
                            "VALUES (@userId,  @movieId, @time)" +
                            ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@userId", ids.userId);
                    command.Parameters.AddWithValue("@movieId", ids.movieId);
                    command.Parameters.AddWithValue("@time", time);

                    connection.Open();

                    command.ExecuteNonQuery();

                }
            }
        }
    }
}
