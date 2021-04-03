using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        void AddUser()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                Login login = new Login();

                //Check if user exists
                if (login.LoginToSystem(UsernameTextBox.Text, PasswordTextBox.Text, true))
                    PopupMessage.ShowToolTip(ParentForm, "User already exists!", Color.Red);
                //If user doesn't exist, add user to the database
                else
                {
                    const string commandText = "" +
                        "INSERT INTO Users (username, password, firstName, lastName, dateOfBirth) " +
                        "VALUES (@username, @password, @firstName, @lastName, @dateOfBirth)" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@dateOfBirth", DateOfBirthDateTimePicker.Value.ToShortDateString());

                    connection.Open();

                    command.ExecuteNonQuery();

                    AddUserSettings();

                    PopupMessage.ShowToolTip(ParentForm, "You have successfuly created an account!", Color.Green);

                    login.LoginToSystem(UsernameTextBox.Text, PasswordTextBox.Text);
                }
            }
        }

        void AddUserSettings()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO UserSettings (userId, state, theme)" +
                    "VALUES (@userId, @state, @theme)" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@state", "Public");
                command.Parameters.AddWithValue("@theme", "Light");

                connection.Open();

                command.ExecuteNonQuery();
            }
        }
    }
}
