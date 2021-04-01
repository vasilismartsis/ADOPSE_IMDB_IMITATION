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
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO Users (username, password, firstName, lastName, dateOfBirth) " +
                    "VALUES (@username, @password, @firstName, @lastName, @dateOfBirth)" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = usernameTextBox.Text;

                command.Parameters.Add("@password", SqlDbType.VarChar);
                command.Parameters["@password"].Value = passwordTextBox.Text;

                command.Parameters.Add("@firstName", SqlDbType.VarChar);
                command.Parameters["@firstName"].Value = firstNameTextBox.Text;

                command.Parameters.Add("@lastName", SqlDbType.VarChar);
                command.Parameters["@lastName"].Value = lastNameTextBox.Text;

                command.Parameters.Add("@dateOfBirth", SqlDbType.Date);
                command.Parameters["@dateOfBirth"].Value = dateOfBirthDateTimePicker.Value.ToShortDateString();

                connection.Open();

                var rowsAffected = command.ExecuteNonQuery();

                SessionTempData.session = true;
            }
        }
    }
}
