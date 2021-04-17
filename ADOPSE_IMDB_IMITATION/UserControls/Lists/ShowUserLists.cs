using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class MyLists : UserControl
    {
        public MyLists()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }

        private void MyLists_Load(object sender, EventArgs e)
        {
            DisplayUserLists();
        }

        void DisplayUserLists()
        {
            foreach (ImdbList list in ImdbListDataAccess.GetListsByUserId(Session.userId))
            {
                Button listButton = new Button
                {
                    Text = list.Name,
                    AutoSize = true,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                listButton.MouseClick += (o, e) => { MainPanelUserControlOpener.OpenUserControl(new ListUserControl(list.Id, list.Name)); };
                ListLayoutPanel.Controls.Add(listButton);
            }
        }
    }
}
