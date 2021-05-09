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

        private Image img;

        public MovieUserControl(Movie movie)

        {
            
            this.movie = movie;
            InitializeComponent();
            Session.SetThemeColor(this);
        }

        public MovieUserControl(int movieId)
        {
            movie = MovieDataAccess.GetMovieById(movieId);

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
           
            NameOfMovie.Text = movie.Name;
            RatingOfMovie.Text = "Rating : " + movie.Score + "/10";
            ImageOfMovie.Image = this.setImage(movie.Image);

            UserDataAccess.UpdateUserHistory(new UserHistory
            {
                userId = Session.userId,
                movieId = movie.Id
            }

                );
            if (movie.IsSeries == true) 
            {
                EpisodesUserControl x = new EpisodesUserControl();
                flowLayoutMovie.Controls.Add(x);
           }
            
          
        }
    }
}
