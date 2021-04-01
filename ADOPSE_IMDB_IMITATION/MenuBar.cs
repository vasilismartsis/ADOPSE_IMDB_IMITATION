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
        UserControl displayedForm;

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

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (displayedForm != null)
                displayedForm.Dispose();

            displayedForm = new Register();
            MainPage.mainPanel.Controls.Add(displayedForm);
            displayedForm.Dock = DockStyle.Fill;
            displayedForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (displayedForm != null)
                displayedForm.Dispose();

            displayedForm = new Login();
            MainPage.mainPanel.Controls.Add(displayedForm);
            displayedForm.Dock = DockStyle.Fill;
            displayedForm.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            SessionTempData.session = false;
            LogoutButton.Visible = false;
        }

        private void ProfileButton_MouseEnter(object sender, EventArgs e)
        {
            if (SessionTempData.session == false)
            {
                RegisterButton.Visible = true;
                LoginButton.Visible = true;
                LogoutButton.Visible = false;
            }
            else
            {
                RegisterButton.Visible = false;
                LoginButton.Visible = false;
                LogoutButton.Visible = true;
            }
        }
    }
}
