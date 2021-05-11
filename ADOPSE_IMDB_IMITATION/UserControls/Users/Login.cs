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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();

            Session.SetThemeColor(this, new List<Object> { new PlaceholderTextBox() });
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text != null || PasswordTextBox.Text != null)
                LoginToSystem(UsernameTextBox.Text, PasswordTextBox.Text);
            else
                PopupMessage1.ShowToolTip(ParentForm, "Some fields are empty", Color.Red);
        }

        public void LoginToSystem(string username, string password)
        {
            User user = UserDataAccess.GetUserByUsernameAndPassword(username, password);

            //Check if user exists
            if (user.Id == 0)
            {
                PopupMessage1.ShowToolTip(ParentForm, "User does not exist!", Color.Red);
            }
            //If user exists, login to system
            else
            {
                Session.userId = user.Id;
                Session.administrator = user.IsAdministrator;
                Session.SetThemeColor(MainForm.menuBar);
                PopupMessage1.ShowToolTip(ParentForm, "You have successfuly loged in!", Color.Green);
                MainPanelUserControlOpener.OpenUserControl(new MainPage());
            }
        }
    }
}
