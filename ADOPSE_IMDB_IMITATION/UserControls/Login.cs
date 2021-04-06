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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginToSystem(UsernameTextBox.Text, PasswordTextBox.Text);
        }

        public bool LoginToSystem(string username, string password, bool justChecking = false)
        {
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
                    if (reader.HasRows)
                        while (reader.Read())
                        {
                            if (!justChecking)
                            {
                                Session.userId = reader.GetInt32(0);
                                Session.administrator = (bool)reader["administrator"];
                                PopupMessage1.ShowToolTip(ParentForm, "You have successfuly loged in!", Color.Green);
                                MainPanelUserControlOpener.OpenUserControl(new MainPage());
                            }
                            return true;
                        }
                    else
                    {
                        PopupMessage1.ShowToolTip(ParentForm, "The user does not exists!", Color.Red);
                        return false;
                    }

                return false;
            }
        }
    }
}
