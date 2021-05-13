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

            Session.SetThemeColor(this, new List<object> { new DataGridView() });
        }

        private void EditMovie_Load(object sender, EventArgs e)
        {
            MoviesGridView.DataSource = MovieDataAccess.GetAllMovies(MovieType.All);
            MoviesGridView.CellDoubleClick += MoviesGridView_CellContentDoubleClick;
            MoviesGridView.MultiSelect = false;

            foreach (DataGridViewRow dataGridViewRow in MoviesGridView.Rows)
                dataGridViewRow.ReadOnly = true;
        }

        private void MoviesGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditMovie((Movie)MoviesGridView.CurrentRow.DataBoundItem));
        }

        private void SearchMovieTextBox_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in MoviesGridView.Rows)
                if (dataGridViewRow.Cells[1].Value.ToString().ToLower().Contains(SearchMovieTextBox.Text.ToLower()))
                    dataGridViewRow.Visible = true;
                else if (dataGridViewRow.Index != 0 && SearchMovieTextBox.Text != "Search Movie")
                    dataGridViewRow.Visible = false;
        }
    }
}
