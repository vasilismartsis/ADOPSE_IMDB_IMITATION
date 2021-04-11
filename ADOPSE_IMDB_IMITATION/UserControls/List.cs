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
    public partial class List : UserControl
    {
        String listName;
        int listId;

        public List(int listId, String listName)
        {
            InitializeComponent();

            this.listName = listName;
            this.listId = listId;
        }

        private void List_Load(object sender, EventArgs e)
        {
            GetMoviesInList();
        }

        void GetMoviesInList()
        {
            ListNameLabel.Text = listName;
            List<int> moviesInListIds = new List<int>();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "SELECT movieId " +
                    "FROM ListEntries " +
                    "WHERE userId = @userId AND listId = @listId" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@userId", Session.userId);
                command.Parameters.AddWithValue("@listId", listId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                        moviesInListIds.Add(reader.GetInt32(0));
            }

            DisplayListMovies(moviesInListIds);
        }

        void DisplayListMovies(List<int> moviesInListIds)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                string commandText = "" +
                    "SELECT id, name " +
                    "FROM Movies " +
                    "WHERE ";

                for (int i = 0; i < moviesInListIds.Count; i++)
                {
                    commandText += "id = " + moviesInListIds[i];

                    if (i < moviesInListIds.Count - 1)
                        commandText += " OR ";
                }

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        SmallWindowMovie x = new SmallWindowMovie(reader.GetInt32(0));
                        MoviesLayoutPanel.Controls.Add(x);
                        
                        
                        
                        
                        
                        /*Button listButton = new Button();
                        listButton.Text = reader.GetString(1);
                        int movieId = reader.GetInt32(0);
                        listButton.AutoSize = true;
                        listButton.TextAlign = ContentAlignment.MiddleCenter;
                        listButton.Click += (s, ev) => { MainPanelUserControlOpener.OpenUserControl(new Movie(movieId)); };
                        MoviesLayoutPanel.Controls.Add(listButton);*/
                    }
            }
        }

        private void MoviesLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
