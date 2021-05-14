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

        bool isInEditMode;

        public AddEditMovie()
        {
            InitializeComponent();

            Session.SetThemeColor(this, new List<Object> { new Button() });
        }

        public AddEditMovie(Movie movie)
        {
            InitializeComponent();

            Session.SetThemeColor(this, new List<Object> { new Button() });

            this.movie = movie;
            isInEditMode = true;
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            FillGenresListBox();

            if (isInEditMode)
                InitializeEditUserControl();
        }

        void InitializeEditUserControl()
        {
            //List<Control> userControls = new List<Control>() { NameTextBox, ImageTextBox, TrailerTextBox, DirectorTextBox, DescriptionTextBox };

            NameTextBox.Placeholder = movie.Name;
            ReleaseDateTimePicker.Value = DateTime.Parse(movie.ReleaseDate);
            ImageTextBox.Text = movie.Image;
            TrailerTextBox.Text = movie.Trailer;
            DirectorTextBox.Text = movie.Director;
            IsSeriesCheckBox.Checked = movie.IsSeries;
            DescriptionTextBox.Text = movie.Description;
            AddMovieLabel.Text = "Edit Movie or Series";
            AddEditMovieButton.Text = "Edit Movie";
            DeleteMovieButton.Show();
        }

        void FillGenresListBox()
        {
            foreach (Genre genre in GenresDataAccess.GetAllGenres())
                GenresListBox.Items.Add(genre.Name);
        }

        private void AddEditMovieButton_Click(object sender, EventArgs e)
        {
            InitializeMovie();
            InitializeGenres();

            if (NameTextBox.Text != null || ImageTextBox.Text != null || TrailerTextBox.Text != null || DescriptionTextBox.Text != null)
                if (!isInEditMode)
                    AddNewMovie();
                else
                    EditExistingMovie();

            MainPanelUserControlOpener.OpenUserControl(new AddEditMovie());
        }

        void InitializeMovie()
        {
            movie.Name = NameTextBox.Text;
            movie.ReleaseDate = ReleaseDateTimePicker.Value.ToShortDateString();
            movie.Image = ImageTextBox.Text;
            movie.Trailer = TrailerTextBox.Text;
            movie.Director = DirectorTextBox.Text;
            movie.IsSeries = IsSeriesCheckBox.Checked;
            movie.Description = DescriptionTextBox.Text;
        }

        void InitializeGenres()
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
            MovieDataAccess.DeleteMovie(movie.Id);
            MovieDataAccess.AddMovie(movie, genres);
        }

        private void DeleteMovieButton_Click(object sender, EventArgs e)
        {
            MovieDataAccess.DeleteMovie(movie.Id);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
