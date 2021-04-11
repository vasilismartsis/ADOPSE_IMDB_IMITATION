using ADOPSE_IMDB_IMITATION.UserControls.Nena;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            //Test code till we make a proper main menu
            AddNewActorBtn.Visible = Session.userId > 0;
            ShowAllActorsBtn.Visible = Session.userId > 0;
        }

        private void AddNewActorBtn_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditActorUserControl());
        }

        private void ShowAllActorsBtn_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new ShowAllActorsUserControl());
        }
    }
}
