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
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT username " +
                    "FROM Users " +
                    "WHERE username = @username AND password = @password" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.Add("@username", SqlDbType.VarChar);
                command.Parameters["@username"].Value = usernameTextBox.Text;

                command.Parameters.Add("@password", SqlDbType.VarChar);
                command.Parameters["@password"].Value = passwordTextBox.Text;

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    if (reader.HasRows)
                    {
                        SessionTempData.session = true;
                    }
            }
        }
    }
}
