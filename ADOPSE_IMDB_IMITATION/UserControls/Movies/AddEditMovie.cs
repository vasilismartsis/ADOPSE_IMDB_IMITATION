using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
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
    public partial class AddEditMovie : UserControl
    {
        Movie movie = new Movie();
        List<int> genres = new List<int>();

        bool inEditMode;

        public AddEditMovie()
        {
            InitializeComponent();
        }

        public AddEditMovie(Movie movie)
        {
            InitializeComponent();

            this.movie = movie;
            inEditMode = true;
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            FillGenresListBox();

            if (inEditMode)
                InitializeEditUserControl();
        }

        void InitializeEditUserControl()
        {
            NameTextBox.Placeholder = movie.name;
            NameTextBox.ForeColor = Color.Black;
            ReleaseDateTimePicker.Value = DateTime.Parse(movie.releaseDate);
            ImageTextBox.Text = movie.image;
            ImageTextBox.ForeColor = Color.Black;
            TrailerTextBox.Text = movie.trailer;
            TrailerTextBox.ForeColor = Color.Black;
            DirectorTextBox.Text = movie.director;
            DirectorTextBox.ForeColor = Color.Black;
            IsSeriesCheckBox.Checked = movie.isSeries;
            DescriptionTextBox.Text = movie.description;
            DescriptionTextBox.ForeColor = Color.Black;
            AddMovieLabel.Text = "Edit Movie or Series";
            AddEditMovieButton.Text = "Edit Movie";
            DeleteMovieButton.Show();
        }

        void FillGenresListBox()
        {
            foreach (Genre genre in GenresDataAccess.GetAllGenres())
                GenresListBox.Items.Add(genre.name);
        }

        private void AddEditMovieButton_Click(object sender, EventArgs e)
        {
            FillMovie();
            FillMovieGenres();

            if (!inEditMode)
                AddNewMovie();
            else
                EditExistingMovie();

            MainPanelUserControlOpener.OpenUserControl(new AddEditMovie());
        }

        void FillMovie()
        {
            movie.name = NameTextBox.Text;
            movie.releaseDate = ReleaseDateTimePicker.Value.ToShortDateString();
            movie.image = ImageTextBox.Text;
            movie.trailer = TrailerTextBox.Text;
            movie.director = DirectorTextBox.Text;
            movie.isSeries = IsSeriesCheckBox.Checked;
            movie.description = DescriptionTextBox.Text;
        }

        void FillMovieGenres()
        {
            foreach (object genresListBoxIndex in GenresListBox.CheckedItems)
                genres.Add(GenresDataAccess.GetGenreIdByName(GenresListBox.GetItemText(genresListBoxIndex)));
        }

        void AddNewMovie()
        {
            MovieDataAccess.AddMovie(movie, genres);
        }

        void EditExistingMovie()
        {
            MovieDataAccess.DeleteMovie(movie.id);
            MovieDataAccess.AddMovie(movie, genres);
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            MovieDataAccess.DeleteMovie(movie.id);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
