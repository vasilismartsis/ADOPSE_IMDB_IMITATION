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
    public partial class ProfileSettings : UserControl
    {
        public ProfileSettings()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "UPDATE UserSettings SET state = @state, theme = @theme WHERE userId = @userId;";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@state", StateComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@theme", ThemeComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@userId", Session.userId);

                connection.Open();

                var reader = command.ExecuteNonQuery();
            }

            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
