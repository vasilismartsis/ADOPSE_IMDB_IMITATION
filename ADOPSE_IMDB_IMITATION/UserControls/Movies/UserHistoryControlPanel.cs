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
    public partial class UserHistoryControlPanel : UserControl
    {
        public UserHistoryControlPanel()
        {
            InitializeComponent();
        }

        private void ShowHistory(object sender, EventArgs e)
        {
            if (Session.userId != 0)
            {

                label1.Text = "This is your history.";
                List<int> moviesfromhistory = new List<int>();
                moviesfromhistory = DataAccess.UserDataAccess.GetUserHistory();
                for(int i = 0; i<moviesfromhistory.Count; i++) 
                {
                    SmallWindowMovie x = new SmallWindowMovie(moviesfromhistory[i], true, 2);
                UserHistoryFlowlayout.Controls.Add(x);
                }
            }
            else
            {
                label1.Text = "You need to be logged in to use this feature.";
                Button but = new Button();
                but.Text = "LOG IN";
                but.MouseClick += new MouseEventHandler((o, et) => { MainPanelUserControlOpener.OpenUserControl(new Login() ); });
                UserHistoryFlowlayout.Controls.Add(but);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
