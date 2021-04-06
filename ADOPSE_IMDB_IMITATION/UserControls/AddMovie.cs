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
    public partial class AddMovie : UserControl
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            FillGenresListBox();
        }

        void FillGenresListBox()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                List<string> genres = new List<string>();

                const string commandText = "" +
                    "SELECT name " +
                    "FROM Genres" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                        GenresListBox.Items.Add(reader.GetString(0));
            }
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                const string commandText = "" +
                    "INSERT INTO Movies (Name, Type, ReleaseDate, Image, Trailer, Director, IsSeries) " +
                    "VALUES (@Name, @Type, @ReleaseDate, @Image, @Trailer, @Director, @IsSeries);" +
                    "SELECT SCOPE_IDENTITY()" +
                    ";";

                SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@Name", NameTextBox.Text);
                command.Parameters.AddWithValue("@Type", TypeTextBox.Text);
                command.Parameters.AddWithValue("@ReleaseDate", ReleaseDateTimePicker.Value.ToShortDateString());
                command.Parameters.AddWithValue("@Image", ImageTextBox.Text);
                command.Parameters.AddWithValue("@Trailer", TrailerTextBox.Text);
                command.Parameters.AddWithValue("@Director", DirectorTextBox.Text);
                command.Parameters.AddWithValue("@IsSeries", IsSeriesCheckBox.Checked);

                connection.Open();

                int movieId = Convert.ToInt32(command.ExecuteScalar());

                AddMovieToGenreEntriesTable(movieId);

                PopupMessage1.ShowToolTip(ParentForm, "You have successfuly added a movie!", Color.Green);
            }
        }

        void AddMovieToGenreEntriesTable(int movieId)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.MyConnectionString))
            {
                foreach (int genreIndex in GenresListBox.CheckedIndices)
                {
                    const string commandText = "" +
                        "INSERT INTO GenreEntries (movieId, genreId) " +
                        "VALUES (@movieId, @genreId)" +
                        ";";

                    SqlCommand command = new SqlCommand(commandText, connection);

                    command.Parameters.AddWithValue("@movieId", movieId);
                    command.Parameters.AddWithValue("@genreId", genreIndex + 1);

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                }
            }
        }
    }
}
