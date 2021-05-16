using ADOPSE_IMDB_IMITATION.DataAccess;
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

        public BrowseActorsUserControl()
        {
            InitializeComponent();

            Session.SetThemeColor(this);

            _actorViewModel = new ActorViewModel();
            _actorViewModel.LoadAllActors();

            foreach (var actor in _actorViewModel.AllActors)
            {
                flowLayoutBrowseActors.Controls.Add(new ActorThumbnailuserControl(actor));
            }
        }
    }
}
