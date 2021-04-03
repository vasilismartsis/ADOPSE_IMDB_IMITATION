using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class Movie : UserControl
    {
        int movieId;

        public Movie(int movieId)
        {
            InitializeComponent();

            this.movieId = movieId;
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            DisplayMovieDetails();
        }

        void DisplayMovieDetails()
        {
            MovieNameLabel.Text = movieId.ToString();
        }
    }
}
