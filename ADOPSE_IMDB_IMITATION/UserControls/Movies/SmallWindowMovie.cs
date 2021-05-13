using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.UserControls.Movies;
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
    public partial class SmallWindowMovie : UserControl, IDisposable
    {
        Movie movie;
        private GenericRatingUserControl _genericRatingUserControl;
        MovieUserControl m;

        public SmallWindowMovie(int movieId, bool showOrderLabel, int? orderOfMovie)
        {
            movie = MovieDataAccess.GetMovieById(movieId);

            m = new MovieUserControl(movie);

            m.setImage(movie.Image);

            InitializeComponent1();

            Session.SetThemeColor(this);

            if (Session.userId > 1 && !showOrderLabel)
                RateMovieBtn.Visible = true;

            if (showOrderLabel)
            {
                if (!orderOfMovie.HasValue)
                    throw new NotSupportedException("With showOrderLabel == true you must send a orderOfMovie parameter!");

                MovieOrderLabel.Visible = true;
                MovieOrderLabel.Text = $"#: {orderOfMovie}";
            }
        }

        public void ShowInfo(MovieUserControl m)
        {
            NameOfMovie.Text = movie.Name;
            RatingOfMovie.Text = movie.GetRatingDisplayName;
            ImageOfMovie.Image = m.getImage();
        }

        private void SmallWindowMovie_Load(object sender, EventArgs e)
        {
            ShowInfo(m);
        }

        private void NameOfMovie_Click(object sender, EventArgs e)
        {

            MainPanelUserControlOpener.OpenUserControl(new MovieUserControl(movie));
        }

        private void InitializeComponent()
        {
            this.NameOfMovie = new System.Windows.Forms.Label();
            this.SummaryOfMovie = new System.Windows.Forms.Label();
            this.RatingOfMovie = new System.Windows.Forms.Label();
            this.ImageOfMovie = new System.Windows.Forms.PictureBox();
            this.RateMovieBtn = new System.Windows.Forms.Button();
            this.MovieOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfMovie
            // 
            this.NameOfMovie.AutoSize = true;
            this.NameOfMovie.Location = new System.Drawing.Point(157, 3);
            this.NameOfMovie.Name = "NameOfMovie";
            this.NameOfMovie.Size = new System.Drawing.Size(75, 13);
            this.NameOfMovie.TabIndex = 0;
            this.NameOfMovie.Text = "NameOfMovie";
            // 
            // SummaryOfMovie
            // 
            this.SummaryOfMovie.AutoSize = true;
            this.SummaryOfMovie.Location = new System.Drawing.Point(157, 34);
            this.SummaryOfMovie.Name = "SummaryOfMovie";
            this.SummaryOfMovie.Size = new System.Drawing.Size(90, 13);
            this.SummaryOfMovie.TabIndex = 1;
            this.SummaryOfMovie.Text = "SummaryOfMovie";
            // 
            // RatingOfMovie
            // 
            this.RatingOfMovie.AutoSize = true;
            this.RatingOfMovie.Location = new System.Drawing.Point(157, 58);
            this.RatingOfMovie.Name = "RatingOfMovie";
            this.RatingOfMovie.Size = new System.Drawing.Size(78, 13);
            this.RatingOfMovie.TabIndex = 2;
            this.RatingOfMovie.Text = "RatingOfMovie";
            // 
            // ImageOfMovie
            // 
            this.ImageOfMovie.Location = new System.Drawing.Point(27, 3);
            this.ImageOfMovie.Name = "ImageOfMovie";
            this.ImageOfMovie.Size = new System.Drawing.Size(124, 106);
            this.ImageOfMovie.TabIndex = 3;
            this.ImageOfMovie.TabStop = false;
            // 
            // RateMovieBtn
            // 
            this.RateMovieBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RateMovieBtn.Location = new System.Drawing.Point(157, 74);
            this.RateMovieBtn.Name = "RateMovieBtn";
            this.RateMovieBtn.Size = new System.Drawing.Size(75, 23);
            this.RateMovieBtn.TabIndex = 4;
            this.RateMovieBtn.Text = "rate me";
            this.RateMovieBtn.UseVisualStyleBackColor = false;
            this.RateMovieBtn.Visible = false;
            this.RateMovieBtn.Click += new System.EventHandler(this.RateMovieBtn_Click);
            // 
            // MovieOrderLabel
            // 
            this.MovieOrderLabel.AutoSize = true;
            this.MovieOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieOrderLabel.Location = new System.Drawing.Point(210, 55);
            this.MovieOrderLabel.Name = "MovieOrderLabel";
            this.MovieOrderLabel.Size = new System.Drawing.Size(17, 17);
            this.MovieOrderLabel.TabIndex = 6;
            this.MovieOrderLabel.Text = "#";
            this.MovieOrderLabel.Visible = false;
            // 
            // SmallWindowMovie
            // 
            this.Controls.Add(this.MovieOrderLabel);
            this.Controls.Add(this.RateMovieBtn);
            this.Controls.Add(this.ImageOfMovie);
            this.Controls.Add(this.RatingOfMovie);
            this.Controls.Add(this.SummaryOfMovie);
            this.Controls.Add(this.NameOfMovie);
            this.Name = "SmallWindowMovie";
            this.Size = new System.Drawing.Size(285, 125);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private void RateMovieBtn_Click(object sender, EventArgs e)
        {
            if (_genericRatingUserControl != null)
                _genericRatingUserControl.RateMovieEvent -= GenericRatingUserControl_RateMovieEvent;

            _genericRatingUserControl = new GenericRatingUserControl("Movie");
            _genericRatingUserControl.RateMovieEvent += GenericRatingUserControl_RateMovieEvent;
            _genericRatingUserControl.ShowDialog();
        }

        private void GenericRatingUserControl_RateMovieEvent(object sender, RateMovieEventArgs e)
        {
            _genericRatingUserControl.DialogResult = DialogResult.OK;//.Close();

            MovieRatingDataAccess.AddOrUpdateMovieRating(new MovieRatingFromDB() { userId = Session.userId, movieId = movie.Id, score = int.Parse(e.Rating) });

            MessageBox.Show($"The selected Rating, for the movie {movie.Name} is {e.Rating}", "Movie Rating");
        }
    }

    /*  private void InitializeComponent()
      {
          this.NameOfMovie = new System.Windows.Forms.Label();
          this.SummaryOfMovie = new System.Windows.Forms.Label();
          this.RatingOfMovie= new System.Windows.Forms.Label();
          this.ImageOfMovie = new System.Windows.Forms.PictureBox();
          ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).BeginInit();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.NameOfMovie.AutoSize = true;
          this.NameOfMovie.Location = new System.Drawing.Point(157, 3);
          this.NameOfMovie.Name = "label1";
          this.NameOfMovie.Size = new System.Drawing.Size(35, 13);
          this.NameOfMovie.TabIndex = 0;
          this.NameOfMovie.Text = "label1";
          // 
          // label2
          // 
          this.SummaryOfMovie.AutoSize = true;
          this.SummaryOfMovie.Location = new System.Drawing.Point(157, 34);
          this.SummaryOfMovie.Name = "label2";
          this.SummaryOfMovie.Size = new System.Drawing.Size(35, 13);
          this.SummaryOfMovie.TabIndex = 1;
          this.SummaryOfMovie.Text = "label2";
          // 
          // label3
          // 
          this.RatingOfMovie.AutoSize = true;
          this.RatingOfMovie.Location = new System.Drawing.Point(157, 96);
          this.RatingOfMovie.Name = "label3";
          this.RatingOfMovie.Size = new System.Drawing.Size(35, 13);
          this.RatingOfMovie.TabIndex = 2;
          this.RatingOfMovie.Text = "label3";
          // 
          // pictureBox1
          // 
          this.ImageOfMovie.Location = new System.Drawing.Point(3, 3);
          this.ImageOfMovie.Name = "pictureBox1";
          this.ImageOfMovie.Size = new System.Drawing.Size(124, 106);
          this.ImageOfMovie.TabIndex = 3;
          this.ImageOfMovie.TabStop = false;
          //ImageOfMovie
          // SmallWindowMovie
          // 
          this.Controls.Add(this.ImageOfMovie);
          this.Controls.Add(this.RatingOfMovie);
          this.Controls.Add(this.SummaryOfMovie);
          this.Controls.Add(this.NameOfMovie);
          this.Name = "SmallWindowMovie";
          this.Size = new System.Drawing.Size(285, 125);
          ((System.ComponentModel.ISupportInitialize)(this.ImageOfMovie)).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();

      }
  }
}*/
}