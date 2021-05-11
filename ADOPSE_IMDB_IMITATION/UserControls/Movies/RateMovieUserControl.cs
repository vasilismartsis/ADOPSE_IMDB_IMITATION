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


    public partial class RateMovieUserControl : Form
    {
        public delegate void RatingEventHandler(object sender, RateMovieEventArgs e);

        public event RatingEventHandler RateMovieEvent;

        public RateMovieUserControl()
        {
            InitializeComponent();
        }

        private void SaveRatingBtn_Click(object sender, EventArgs e)
        {
            var checkedButton = RateMovieRadioButtonGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            //Close();

            RateMovieEvent?.Invoke(this, new RateMovieEventArgs(checkedButton.Text));   //the radiobtn.text gives us the selected rating


        }
    }

    public class RateMovieEventArgs
    {
        public string Rating { get; }

        public RateMovieEventArgs(string rating) { Rating = rating; }
    }
}
