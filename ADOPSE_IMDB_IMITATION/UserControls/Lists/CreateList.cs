using ADOPSE_IMDB_IMITATION.DataAccess;
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
    public partial class CreateList : UserControl
    {
        public CreateList()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }

        private void CreateListButton_Click(object sender, EventArgs e)
        {
            int listId = ImdbListDataAccess.AddList(ListNameText.Text);
            string listName = ImdbListDataAccess.GetListById(listId).Name;

            MainPanelUserControlOpener.OpenUserControl(new ListUserControl(listId, listName));
        }
    }
}
