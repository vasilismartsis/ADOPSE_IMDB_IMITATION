using ADOPSE_IMDB_IMITATION.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    public partial class Suggestions : UserControl
    {
        public Suggestions()
        {
            InitializeComponent();

        }

        private void Suggestions_Load(object sender, EventArgs e)
        {
            List<int> movies = new List<int>();
            movies = UserSuggetions.MovieSuggestions();
            foreach (int id in movies)
            {
                SmallWindowMovie x = new SmallWindowMovie(id, true, 2);
                suggestionslayoutpanel.Controls.Add(x);
            }
        }
    }
}
