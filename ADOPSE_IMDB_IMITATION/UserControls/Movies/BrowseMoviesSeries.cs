using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.UserControls
{
    public partial class BrowseMoviesSeries : UserControl
    {
        private List<Movie> _movies;
        private MovieType _movieType;

        public BrowseMoviesSeries(MovieType movieType)
        {
            InitializeComponent();

            _movieType = movieType;

            Session.SetThemeColor(this);
        }
        public void ShowAllSmallWindowMovie()
        {
            foreach (var movie in _movies)
                flowLayoutBrowseMovies.Controls.Add(new SmallWindowMovie(movie.Id));
        }

        private void BrowseMoviesUI_Load(object sender, EventArgs e)
        {
            _movies = MovieDataAccess.GetAllMovies(_movieType);

            ShowAllSmallWindowMovie();

        }
    }
}
