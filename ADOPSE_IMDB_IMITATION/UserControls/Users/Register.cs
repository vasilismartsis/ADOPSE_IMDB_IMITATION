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
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();

            Session.SetThemeColor(this);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DateTime bday = DateTime.Parse(DateOfBirthDateTimePicker.Value.ToString());
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;

            if (UsernameTextBox.Text != null || PasswordTextBox.Text != null || FirstNameTextBox.Text != null || LastNameTextBox.Text != null || age > 18)
                AddUser();
            else
                PopupMessage1.ShowToolTip(ParentForm, "Wrong info, please try again!", Color.Red);
        }

        void AddUser()
        {
            int userId;

            //Check if user exists
            if (UserDataAccess.GetUserByUsernameAndPassword(UsernameTextBox.Text, PasswordTextBox.Text).Id == 0)
                PopupMessage1.ShowToolTip(ParentForm, "User already exists!", Color.Red);
            //If user doesn't exist, add user to the database
            else
            {
                userId = UserDataAccess.AddUser(new User
                {
                    Username = UsernameTextBox.Text,
                    Password = PasswordTextBox.Text,
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    DateOfBirth = DateOfBirthDateTimePicker.Value.ToString(),
                    IsAdministrator = false
                });

                PopupMessage1.ShowToolTip(ParentForm, "You have successfuly created an account!", Color.Green);

                Session.userId = userId;
                Session.administrator = false;
                Session.SetThemeColor(MainForm.menuBar);

                MainPanelUserControlOpener.OpenUserControl(new MainPage());
            }
        }
    }
}
