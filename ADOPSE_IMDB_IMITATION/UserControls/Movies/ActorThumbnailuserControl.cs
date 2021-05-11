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

namespace ADOPSE_IMDB_IMITATION.UserControls.Movies
{
    public partial class ActorThumbnailuserControl : UserControl
    {
        private Actor _actor;
        private GenericRatingUserControl _genericRatingUserControl;

        /// <summary>
        /// Our ActorThumbnailuserControl, which shows the basic actor information + the rating me button
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="actorId" in case we want to load a specific actor></param>
        public ActorThumbnailuserControl(Actor actor, int? actorId = null)
        {
            InitializeComponent();

            _actor = actor;

            Session.SetThemeColor(this);

            if (Session.userId > 1)
                RateActorBtn.Visible = true;

            ShowInfo();
        }

        public void ShowInfo()
        {
            FirstNameTextBox.Text = $"FirstName: {_actor.FirstName}";
            LastNameTextBox.Text = $"LastName: {_actor.LastName}";
            DateOfBirthTextBox.Text = $"Birthdate: {_actor.Birthday.ToString("dd.MM.yyyy")}";
        }

        private void RateActorBtn_Click(object sender, EventArgs e)
        {
            if (_genericRatingUserControl != null)
                _genericRatingUserControl.RateMovieEvent -= GenericRatingUserControl_RateActorEvent;

            _genericRatingUserControl = new GenericRatingUserControl("Actor");
            _genericRatingUserControl.RateMovieEvent += GenericRatingUserControl_RateActorEvent;
            _genericRatingUserControl.ShowDialog();
        }

        private void GenericRatingUserControl_RateActorEvent(object sender, RateMovieEventArgs e)
        {
            _genericRatingUserControl.DialogResult = DialogResult.OK;//.Close();

            ActorRatingDataAccess.AddOrUpdateActorRating(new ActorRatingFromDB() { userId = Session.userId, actorId = _actor.ID, score = int.Parse(e.Rating) });

            MessageBox.Show($"The selected Rating, for the Actor {_actor.FirstName} {_actor.LastName} is {e.Rating}", "Actor Rating");
        }
    }
}
