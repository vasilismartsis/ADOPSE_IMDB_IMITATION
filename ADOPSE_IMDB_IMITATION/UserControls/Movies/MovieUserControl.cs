using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.UserControls.Movies;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class MovieUserControl : UserControl
    {
        Movie movie;
        public Size Size = new Size(182, 268);
        private Image img;

        public MovieUserControl(Movie movie)
        {
            this.movie = movie;
            InitializeComponent();
            Session.SetThemeColor(this);
        }

        public Image setImage(String ImagePath) //Works only with .jpeg 
        {
            Image imageStream;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest request = WebRequest.Create(ImagePath);

            using (var response = request.GetResponse())
            using (var str = response.GetResponseStream())
                imageStream = Bitmap.FromStream(str);

            img = imageStream;
            return imageStream; //is type of Image
        }

        public Image getImage()
        {
            return img;
        }



        /* Using HttpWebrequest Not working
          ServicePointManager.Expect100Continue = true;
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        HttpWebRequest lxRequest = (HttpWebRequest)WebRequest.Create(ImagePath);
        String lsresponse = String.Empty;

        using (HttpWebResponse lxResponse = (HttpWebResponse)lxRequest.GetResponse()) {
            using (var str = lxResponse.GetResponseStream())
            {
            ImageOfMovie.Image = Bitmap.FromStream(str);
            }

        }*/


        /* Using webrequest works only with .jpg
         * ServicePointManager.Expect100Continue = true;
         ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
         WebRequest request = WebRequest.Create(ImagePath);
         using(var response = request.GetResponse()) 
         {
             using(var str = response.GetResponseStream())
             {
                 ImageOfMovie.Image = Bitmap.FromStream(str);
             }

         }*/

        private void Movie_Load(object sender, EventArgs e)
        {
            DisplayMovieDetails();
        }

        void DisplayMovieDetails()
        {
            //imageLayout
            // PictureBox image = new PictureBox();
            // image.Image = setImage(movie.Image);
            // image.
            // image.Size = Size;

            //ImageLayout.Controls.Add(image);
            ImageOfMovie.Image = setImage(movie.Image);
            ImageOfMovie.Size = new Size();
            NameOfMovie.Text = movie.Name;
            NameOfMovie.Font = new Font("Arial", 24, FontStyle.Bold);
            DescriptionOfMovie.Text = movie.Description;
            DescriptionOfMovie.Font = new Font("Arial", 15);
            if (movie.ImdbRating != null)
            {

                RatingOfMovie.Text = "Rating : " + movie.ImdbRating + "/10";
            }
            else
            {
                RatingOfMovie.Text = null;
            }
            ReleaseDate.Text = movie.ReleaseDate;


            //InfoLayout
            /*  Label title = new Label();
              title.Text = movie.Name;
              MovieInfoPanel.Controls.Add(title);

              title.Font = new Font("Arial", 24, FontStyle.Bold);
              title.Dock = DockStyle.Fill;

              Label summary = new Label();
              summary.Text = movie.Description;
              MovieInfoPanel.Controls.Add(summary);
              summary.AutoSize = true;
              summary.Dock = DockStyle.Fill;

              Label rating = new Label();
              if (movie.ImdbRating != null)
              {

                  rating.Text = "Rating : " + movie.ImdbRating + "/10";
              }
              Label date = new Label();


              date.Text = "Release Date: " + movie.ReleaseDate;
              Label director = new Label();
              director.Text = "Director :" + movie.Director;





              MovieInfoPanel.Controls.Add(rating);
              rating.AutoSize = true;
              MovieInfoPanel.Controls.Add(date);
              date.AutoSize = true;
              MovieInfoPanel.Controls.Add(director);*/
            /*
            SummaryOfMovie.Text = movie.Description;
            NameOfMovie.Text = movie.Name;
            RatingOfMovie.Text = movie.GetRatingDisplayName;
            ImageOfMovie.Image = this.setImage(movie.Image);
            ImageOfMovie.Size = Size;*/
            //  ImageOfMovie.Size = new Size(182, 268);
            UserDataAccess.UpdateUserHistory(new UserHistory
            {
                userId = Session.userId,
                movieId = movie.Id
            });

            if (movie.IsSeries == true)
            {
               
                EpisodesUserControl x = new EpisodesUserControl();
                SeriesLayout.Controls.Add(x);
            }


        }

        

       
    }
}
