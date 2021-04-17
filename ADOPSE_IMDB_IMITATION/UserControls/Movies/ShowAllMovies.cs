using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.UserControls.Nena;
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

namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    public partial class ShowAllMovies : UserControl
    {
        public ShowAllMovies()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            MoviesGridView.DataSource = MovieDataAccess.GetAllMovies();
            MoviesGridView.CellDoubleClick += MoviesGridView_CellContentDoubleClick;
            MoviesGridView.MultiSelect = false;
        }

        private void MoviesGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditMovie((Movie)MoviesGridView.CurrentRow.DataBoundItem));
        }
    }
}
