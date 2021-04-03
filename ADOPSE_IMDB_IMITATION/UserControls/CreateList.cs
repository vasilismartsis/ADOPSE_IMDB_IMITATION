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
    public partial class CreateList : UserControl
    {
        public CreateList()
        {
            InitializeComponent();
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO Lists (userId, name) " +
                    "VALUES (@userId, @name)" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@name", ListNameText.Text);

                connection.Open();

                var rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
