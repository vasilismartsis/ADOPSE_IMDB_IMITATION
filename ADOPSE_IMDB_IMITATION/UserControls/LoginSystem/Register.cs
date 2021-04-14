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
                    PopupMessage1.ShowToolTip(ParentForm, "User already exists!", Color.Red);
                //If user doesn't exist, add user to the database
                else
                {
                    const string commandText = "" +
                        "INSERT INTO Users (username, password, firstName, lastName, dateOfBirth) " +
                        "VALUES (@username, @password, @firstName, @lastName, @dateOfBirth) " +
                        "SELECT SCOPE_IDENTITY()" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@username", UsernameTextBox.Text);
                    command.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@firstName", FirstNameTextBox.Text);
                    command.Parameters.AddWithValue("@lastName", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@dateOfBirth", DateOfBirthDateTimePicker.Value.Date);

                    connection.Open();

                    int userId = Convert.ToInt32(command.ExecuteScalar());

                    PopupMessage1.ShowToolTip(ParentForm, "You have successfuly created an account!", Color.Green);

                    Session.userId = userId;
                    Session.administrator = false;

                    AddUserSettings();
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


                Console.WriteLine(Session.userId);
                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@state", "Public");
                command.Parameters.AddWithValue("@theme", "Light");

                connection.Open();

                command.ExecuteNonQuery();
            }

            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
