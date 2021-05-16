using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Enums;
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
        private static readonly int AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE = 10;
        private List<Movie> _movies;
        private MovieType _movieType;
        private UserControlType _userControlType;

        public BrowseMoviesSeries(UserControlType userControlType, MovieType movieType)
        {
            InitializeComponent();

            _userControlType = userControlType;
            _movieType = movieType;

            Session.SetThemeColor(this);
        }

        public void ShowAllSmallWindowMovie()
        {
            var moviesToShow = _movies;

            //first we get all the movies that have score
            //then we order then descending based on score
            //then we take the first AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE elements
            if (_userControlType == UserControlType.Order)
                moviesToShow = (from movie in _movies
                                where movie.Score.HasValue
                                orderby movie.Score descending
                                select movie).Take(AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE).ToList();

            for (int i = 0; i < moviesToShow.Count; i++)
            {
                flowLayoutBrowseMovies.Controls.Add(new SmallWindowMovie(_movies[i].Id, _userControlType == UserControlType.Order, i + 1));
            }
        }

        private void BrowseMoviesSeries_Load(object sender, EventArgs e)
        {
            _movies = MovieDataAccess.GetAllMovies(_movieType);

            ShowAllSmallWindowMovie();
        }
    }
}
