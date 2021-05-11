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
    public partial class ListUserControl : UserControl
    {
        int listId;
        String listName;

        public Size moviePictureBoxSize = new Size(182, 268);

        public ListUserControl(int listId, String listName)
        {
            InitializeComponent();

            this.listName = listName;
            this.listId = listId;

            Session.SetThemeColor(this);
        }

        private void List_Load(object sender, EventArgs e)
        {
            ListNameLabel.Text = listName;

            DisplayMoviesInList();
        }

        void DisplayMoviesInList()
        {
            List<Movie> movies = ImdbListDataAccess.GetMoviesInListByListId(listId);

            if (movies != null)
                foreach (Movie movie in movies)
                {
                    PictureBox moviePictureBox = new PictureBox
                    {
                        ImageLocation = movie.Image,
                        Size = moviePictureBoxSize
                    };

                    moviePictureBox.MouseClick += new MouseEventHandler((o, e) => { MainPanelUserControlOpener.OpenUserControl(new MovieUserControl(movie)); });

                    MoviesLayoutPanel.Controls.Add(moviePictureBox);
                }
        }
    }
}
