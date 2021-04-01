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

        private void SearchIMDBInput_Enter(object sender, EventArgs e)
        {
            if (SearchIMDBInput.Text == "Search IMDB")
            {
                SearchIMDBInput.Text = "";
                SearchIMDBInput.ForeColor = Color.Black;
            }
        }

        private void SearchIMDBInput_Leave(object sender, EventArgs e)
        {
            if (SearchIMDBInput.Text == "")
            {
                SearchIMDBInput.Text = "Search IMDB";
                SearchIMDBInput.ForeColor = Color.DarkGray;
            }
        }
    }
}
