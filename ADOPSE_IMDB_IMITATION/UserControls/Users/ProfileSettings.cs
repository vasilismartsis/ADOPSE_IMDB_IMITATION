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
    public partial class ProfileSettings : UserControl
    {
        public ProfileSettings()
        {
            InitializeComponent();

            Session.SetThemeColor(this);

            StateComboBox.SelectedIndex = StateComboBox.FindStringExact(UserDataAccess.GetUserById(Session.userId).UserSettings.State);
            ThemeComboBox.SelectedIndex = ThemeComboBox.FindStringExact(UserDataAccess.GetUserById(Session.userId).UserSettings.Theme);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            UserDataAccess.UpdateUserSettings(new UserSettings
            {
                State = StateComboBox.SelectedItem.ToString(),
                Theme = ThemeComboBox.SelectedItem.ToString()
            });

            Session.SetThemeColor(MainForm.menuBar);
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
