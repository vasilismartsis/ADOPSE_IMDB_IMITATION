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
        List<Movie> movies;

        public void FillList() // Get the ids of the movies
        {
            movies = MovieDataAccess.GetAllMovies();
        }
        public BrowseMoviesSeries()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }
        public void ShowAllSmallWindowMovie()
        {
            for (int i = 0; i < movies.Count(); i++)
            {
                SmallWindowMovie x = new SmallWindowMovie(movies[i].Id);
                flowLayoutBrowseMovies.Controls.Add(x);
            }
        }

        private void BrowseMoviesUI_Load(object sender, EventArgs e)
        {
            FillList();
            ShowAllSmallWindowMovie();

        }
    }
}
