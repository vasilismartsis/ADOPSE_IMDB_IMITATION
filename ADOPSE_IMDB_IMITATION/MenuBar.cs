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

        private void iMDBSearchInput_Enter(object sender, EventArgs e)
        {
            if (iMDBSearchInput.Text == "IMDB Search")
            {
                iMDBSearchInput.Text = "";
                iMDBSearchInput.ForeColor = Color.Black;
            }
        }

        private void iMDBSearchInput_Leave(object sender, EventArgs e)
        {
            if (iMDBSearchInput.Text == "")
            {
                iMDBSearchInput.Text = "IMDB Search";
                iMDBSearchInput.ForeColor = Color.DarkGray;
            }
        }
    }
}
