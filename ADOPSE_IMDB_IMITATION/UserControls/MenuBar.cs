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
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();
        }

        //SearchIMDBInput Placeholder
        private void SearchIMDBInput_Enter(object sender, EventArgs e)
        {
            if (SearchIMDBInput.Text == "Search IMDB")
            {
                SearchIMDBInput.Text = "";
                SearchIMDBInput.ForeColor = Color.Black;
            }
        }

        //SearchIMDBInput Placeholder
        private void SearchIMDBInput_Leave(object sender, EventArgs e)
        {
            if (SearchIMDBInput.Text == "")
            {
                SearchIMDBInput.Text = "Search IMDB";
                SearchIMDBInput.ForeColor = Color.DarkGray;
            }
        }

        private void ProfileButton_MouseEnter(object sender, EventArgs e)
        {
            DisplayProfileMenus();
        }

        void DisplayProfileMenus()
        {
            if (Session.userId == 0)
            {
                RegisterToolStripMenuItem.Visible = true;
                LoginToolStripMenuItem.Visible = true;
                LogoutToolStripMenuItem.Visible = false;
                SettingsToolStripMenuItem.Visible = false;
                CreateListToolStripMenuItem.Visible = false;
                MyListsToolStripMenuItem.Visible = false;
                AdministratorFunctionsToolStripMenuItem.Visible = false;
            }
            else
            {
                RegisterToolStripMenuItem.Visible = false;
                LoginToolStripMenuItem.Visible = false;
                LogoutToolStripMenuItem.Visible = true;
                SettingsToolStripMenuItem.Visible = true;
                CreateListToolStripMenuItem.Visible = true;
                MyListsToolStripMenuItem.Visible = true;
                if (Session.administrator)
                    AdministratorFunctionsToolStripMenuItem.Visible = true;
            }
        }

        private void RegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new Register());
        }

        private void LoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new Login());
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.userId = 0;
            LogoutToolStripMenuItem.Visible = false;
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new ProfileSettings());
        }

        private void MyListsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MyLists());
        }

        private void CreateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new CreateList());
        }

        private void AddMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddMovie());
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}