using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Enums;
using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.UserControls.Movies;
using ADOPSE_IMDB_IMITATION.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.UserControls
{
    public partial class BrowseActorsUserControl : UserControl
    {
        private ActorViewModel _actorViewModel;

        private static readonly int AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE = 10;
        private UserControlType _userControlType;

        public BrowseActorsUserControl(UserControlType userControlType)
        {
            InitializeComponent();

            _userControlType = userControlType;

            Session.SetThemeColor(this);

            _actorViewModel = new ActorViewModel();
            _actorViewModel.LoadAllActors();

            ShowAllSmallWindowMovie();
        }

        public void ShowAllSmallWindowMovie()
        {
            var actorsToShow = _actorViewModel.AllActors;

            //first we get all the actors that have score
            //then we order then descending based on score
            //then we take the first AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE elements
            if (_userControlType == UserControlType.Order)
                actorsToShow = (from actor in actorsToShow
                                where actor.Score.HasValue
                                orderby actor.Score descending
                                select actor).Take(AMOUNT_OF_ITEMS_TO_SHOW_IN_TOPXXX_TYPE).ToList();

            for (int i = 0; i < actorsToShow.Count; i++)
            {
                flowLayoutBrowseActors.Controls.Add(new ActorThumbnailuserControl(actorsToShow[i]));
            }
        }
    }
}
 