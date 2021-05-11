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

namespace ADOPSE_IMDB_IMITATION.UserControls.MainPage
{
    public partial class MainPageCategory : UserControl
    {
        public Size moviePictureBoxSize = new Size(182, 268);
        public int panelMargin = 3;

        string direction;

        public int timerStep;
        public int timerStepSize = 25;

        bool leftRightButtonClicked;

        int[] movieIds;

        public MainPageCategory(int[] movieIds)
        {
            InitializeComponent();

            this.movieIds = movieIds;

            Session.SetThemeColor(this);

            AddMovies();
        }

        void AddMovies()
        {
            List<Movie> movies = MovieDataAccess.GetMoviesByIds(movieIds);

            for (int i = 0; i < movies.Count; i++)
            {
                Movie movie = movies[i];

                PictureBox moviePictureBox = new PictureBox
                {
                    ImageLocation = movie.Image,
                    Size = moviePictureBoxSize,
                    Location = new Point((i * moviePictureBoxSize.Width) + i * panelMargin, Location.Y)
                };

                moviePictureBox.MouseClick += new MouseEventHandler((o, e) => { MainPanelUserControlOpener.OpenUserControl(new MovieUserControl(movie)); });

                MoviePanel.Controls.Add(moviePictureBox);
            }
        }

        //Move smoothly panel items to the left
        private void LeftButton_Click(object sender, EventArgs e)
        {
            if (!leftRightButtonClicked)
                if (MoviePanel.Controls[0].Location.X < 0)
                {
                    direction = "left";
                    timerStep = 0;
                    leftRightButtonClicked = true;
                    timer1.Start();
                }
        }

        //Move smoothly panel items to the right
        private void RightButton_Click(object sender, EventArgs e)
        {
            if (!leftRightButtonClicked)
                if (MoviePanel.Controls[MoviePanel.Controls.Count - 1].Location.X + MoviePanel.Controls[MoviePanel.Controls.Count - 1].Width > MoviePanel.Width)
                {
                    direction = "right";
                    timerStep = 0;
                    leftRightButtonClicked = true;
                    timer1.Start();
                }
        }

        //Using timer to succed the smoothing effect
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerStep < (moviePictureBoxSize.Width + panelMargin))
                if (direction == "right")
                {
                    for (int i = 0; i < MoviePanel.Controls.Count; i++)
                    {
                        Control control = MoviePanel.Controls[i];

                        control.Location = new Point(control.Location.X - timerStepSize, control.Location.Y);
                    }
                }
                else
                {
                    for (int i = 0; i < MoviePanel.Controls.Count; i++)
                    {
                        Control control = MoviePanel.Controls[i];

                        control.Location = new Point(control.Location.X + timerStepSize, control.Location.Y);
                    }
                }
            else
            {
                timer1.Stop();

                leftRightButtonClicked = false;
            }

            timerStep += timerStepSize;
        }
    }
}
