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
    public partial class MyLists : UserControl
    {
        public MyLists()
        {
            InitializeComponent();
        }

        private void MyLists_Load(object sender, EventArgs e)
        {
            DisplayUserLists();
        }

        void DisplayUserLists()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT Id, name " +
                    "FROM Lists " +
                    "WHERE userId = @userId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Button listButton = new Button();
                        listButton.Text = reader["name"].ToString();
                        listButton.AutoSize = true;
                        listButton.TextAlign = ContentAlignment.MiddleCenter;
                        int listId = (int)reader["Id"];
                        string listName = reader["name"].ToString();
                        listButton.Click += (s, ev) => { MainPanelUserControlOpener.OpenUserControl(new List(listId, listName)); };
                        ListLayoutPanel.Controls.Add(listButton);
                    }
                }
            }
        }
    }
}
