using ADOPSE_IMDB_IMITATION.Scripts;
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
        private int MovieId;
        private float MovieScore;
        private String MovieName;

        private DateTime DateOfRelease;
        private String ImagePath;

        private String TrailerPath;
        private String Director;
        private Boolean isSeries;
        private Image img;
        public int getMovieId()
        {
            return MovieId;
        }
        public void setMovieId(int id)
        {
            this.MovieId = id;
        }
        public String getMovieName()
        {
            return MovieName;
        }
        public void setMovieName(String name)
        {
            this.MovieName = name;
        }
        public float getMovieScore()
        {
            return MovieScore;
        }
        public void setMovieScore(float MovieScore)
        {
            this.MovieScore = MovieScore;
        }

        public DateTime getDateOfRelease()
        {
            return DateOfRelease;
        }
        public void setDateOfRelease(DateTime time)
        {
            this.DateOfRelease = time;
        }

        public String getImagePath()
        {
            return this.ImagePath;
        }
        public void setImagePath(String path)
        {
            this.ImagePath = path;
        }
        public String getTrailerPath()
        {
            return TrailerPath;
        }
        public void setTrailerPath(String path)
        {
            this.TrailerPath = path;
        }
        public string getDirector()
        {
            return Director;
        }
        public void setDirector(string name)
        {
            this.Director = name;
        }
        public bool getisSeries()
        {
            return isSeries;
        }
        public void setisSeries(bool isSeries)
        {
            this.isSeries = isSeries;
        }
        public Image setImage(String ImagePath) //Works only with .jpeg 
        {
            Image imageStream;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest request = WebRequest.Create(ImagePath);
            using (var response = request.GetResponse())
            {
                using (var str = response.GetResponseStream())
                {
                    imageStream = Bitmap.FromStream(str);
                }

            }
            this.img = imageStream;
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


        public MovieUserControl GetAndSetInfo(int movieId) //Retrieve all columns from Table Movies 
        {

            GetMovieInfo r = new GetMovieInfo();
            MovieUserControl m = r.retrieveAllMovieColumnsDataAndSet(movieId); // Get the Columns of the movie Table and set them
            GetMovieScores score = new GetMovieScores(); //Get the score of the movie
            this.MovieScore = score.GetMovieScore(movieId);
            m.MovieScore = this.MovieScore;
            return m;

        }

        public MovieUserControl(int movieId)
        {
            GetAndSetInfo(movieId);




        }
        public MovieUserControl()
        {

        }
        public MovieUserControl(MovieUserControl m)
        {
            this.MovieId = m.MovieId;
            this.MovieScore = m.MovieScore;
            this.MovieName = m.MovieName;
            this.DateOfRelease = m.DateOfRelease;
            this.ImagePath = m.ImagePath;
            this.TrailerPath = m.TrailerPath;
            this.Director = m.Director;
            this.isSeries = m.isSeries;
            this.img = m.img;
            InitializeComponent();
        }

        private void Movie_Load(object sender, EventArgs e)
        {

            DisplayMovieDetails();

        }

        void DisplayMovieDetails()
        {
            NameOfMovie.Text = MovieName.ToString();
            RatingOfMovie.Text = "Rating : " + MovieScore + "/10";
            ImageOfMovie.Image = img;

        }
    }
}
