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
    public partial class UserHistoryControl : UserControl
    {
        String text = "You need to be logged in to use the history tab.";
        public static bool CheckIflogged() 
        {
            if (Session.userId == 0)
            {
                return false;
            }
            else 
                return true;
        }


        public UserHistoryControl()
        {
            InitializeComponent();
            Session.SetThemeColor(this);
        }
        private void DisplayHistory()
        {
            List<int> list = UserDataAccess.GetUserHistory();
            if (list != null)
            {
                foreach (int id in list)
                {
                    SmallWindowMovie x = new SmallWindowMovie(id);
                    HistoryLayoutPanel.Controls.Add(x);
                }
            }
         
        }

        private  void DisplayText()
        {
            Label label = new Label();
            
            label.AutoSize = true;
            label.Text = text;
            HistoryLayoutPanel.Controls.Add(label);
        }

        private void UserHistoryControlLoad(object sender, EventArgs e)
        {
            if (CheckIflogged() == true)
            {
                DisplayHistory();
            }
            else DisplayText();
        }
    }
}
