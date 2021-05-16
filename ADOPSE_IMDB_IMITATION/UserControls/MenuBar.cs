using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.Enums;
using ADOPSE_IMDB_IMITATION.UserControls;
using ADOPSE_IMDB_IMITATION.UserControls.Movies;
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
    public partial class MenuBar : UserControl
    {
        public MenuBar()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }

        #region Initialize controls

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
            Session.SetThemeColor(MainForm.menuBar);
            LogoutToolStripMenuItem.Visible = false;
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
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
            MainPanelUserControlOpener.OpenUserControl(new AddEditMovie());
        }

        private void HomePageButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }

        private void EditMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new ShowAllMovies());
        }

        private void AddActorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new AddEditActorUserControl());
        }

        private void reportAProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new Complaints());
        }

        private void browseMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Browse, MovieType.Movie));
        }

        private void moviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Browse, MovieType.Movie));
        }

        private void seriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Browse, MovieType.Series));
        }

        private void actorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new BrowseActorsUserControl());
        }
        #endregion

        #region TypeCombobox

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTypeComboBoxToSelectedChildSize();
        }

        private void TypeComboBox_Enter(object sender, EventArgs e)
        {
            SetTypeComboBoxToMaxChildSize();
        }

        private void TypeComboBox_Leave(object sender, EventArgs e)
        {
            SetTypeComboBoxToSelectedChildSize();
        }

        void SetTypeComboBoxToSelectedChildSize()
        {
            Label label1 = new Label();
            label1.Text = TypeComboBox.SelectedItem.ToString();
            label1.AutoSize = true;

            TypeComboBox.Width = label1.PreferredWidth + 17;

            label1.Dispose();
        }

        void SetTypeComboBoxToMaxChildSize()
        {
            int maxWidth = 0;
            Label label1 = new Label();

            foreach (Object obj in TypeComboBox.Items)
            {
                label1.Text = obj.ToString();
                label1.AutoSize = true;
                int temp = label1.PreferredWidth;
                if (temp > maxWidth)
                    maxWidth = temp;
            }

            TypeComboBox.Width = maxWidth + 17;

            ComboBoxTimer.Interval = 1;
            ComboBoxTimer.Start();

            label1.Dispose();
        }

        private void ComboBoxTimer_Tick(object sender, EventArgs e)
        {
            TypeComboBox.DroppedDown = true;

            ComboBoxTimer.Stop();
        }

        #endregion

        private void showAllActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new ShowAllActorsUserControl());
        }

        private void EditActorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void browseActorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MainPanelUserControlOpener.OpenUserControl(new BrowseActorsUserControl());
        }

        private void browseSeriesMenuItem_Click(object sender, EventArgs e)
        {
            //MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Browse, MovieType.Series));
        }

        private void moviesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Order, MovieType.Movie));
        }

        private void seriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new BrowseMoviesSeries(BrowseMoviesSeriesUserControlType.Order, MovieType.Series));
        }
        private void showTop10MoviesMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void actorsToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void showTop10SeriesMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void showTop10ActorsMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //method to build index, run only once

            // DataAccess.index_test.index_creator();
            //SearchTMDB.SearchSeries();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // uses the search bar text to search titles
            if (SearchIMDBInput.Text.Length > 0 && (SearchIMDBInput.Text.Substring(0, 1) == "*" || SearchIMDBInput.Text.Substring(0, 1) == "?"))
            {
                SearchIMDBInput.Text = "";
                return;
            }

            if (SearchIMDBInput.Text.Length == 0) return;

            int searchBy = TypeComboBox.SelectedIndex;
            switch (searchBy)
            {
                case 0:
                    DataAccess.index_test.index_searcher_by_name(SearchIMDBInput.Text);
                    break;
                case 1:
                    DataAccess.index_test.index_searcher_by_genre(SearchIMDBInput.Text);
                    break;
                case 2:
                    DataAccess.index_test.index_searcher_by_year(SearchIMDBInput.Text);
                    break;
            }

            //DataAccess.index_test.index_searcher_by_name(SearchIMDBInput.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void createIndexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //method to build index, run only once

            DataAccess.index_test.index_creator();

        }
    }
}