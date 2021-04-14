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
    public partial class SmallWindowMovie : UserControl
    {

        MovieUserControl m;
        public void ShowInfo(MovieUserControl m)
        {
            NameOfMovie.Text = m.getMovieName();
            RatingOfMovie.Text = "Rating : " + m.getMovieScore() + "/10";
            ImageOfMovie.Image = m.getImage();

        }

        public SmallWindowMovie()
        {

        }

        public SmallWindowMovie(int movieid)
        {
            MovieUserControl m1 = new MovieUserControl(movieid);
            this.m = m1.GetAndSetInfo(movieid);
            String ImagePath = m.getImagePath();
            m.setImage(ImagePath);

            InitializeComponent1();
        }

        private void SmallWindowMovie_Load(object sender, EventArgs e)
        {
            ShowInfo(m);

        }



        private void NameOfMovie_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MovieUserControl(m));
        }

        private void InitializeComponent()
        {
            this.NameOfMovie = new System.Windows.Forms.Label();
            this.SummaryOfMovie = new System.Windows.Forms.Label();
            this.RatingOfMovie = new System.Windows.Forms.Label();
            this.ImageOfMovie = new System.Windows.Forms.PictureBox();
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
            this.RatingOfMovie.Location = new System.Drawing.Point(157, 96);
            this.RatingOfMovie.Name = "RatingOfMovie";
            this.RatingOfMovie.Size = new System.Drawing.Size(78, 13);
            this.RatingOfMovie.TabIndex = 2;
            this.RatingOfMovie.Text = "RatingOfMovie";
            // 
            // ImageOfMovie
            // 
            this.ImageOfMovie.Location = new System.Drawing.Point(3, 3);
            this.ImageOfMovie.Name = "ImageOfMovie";
            this.ImageOfMovie.Size = new System.Drawing.Size(124, 106);
            this.ImageOfMovie.TabIndex = 3;
            this.ImageOfMovie.TabStop = false;
            // 
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