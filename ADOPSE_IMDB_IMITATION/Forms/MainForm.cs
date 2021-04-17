using ADOPSE_IMDB_IMITATION.UserControls.Movies;
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
    public partial class MainForm : Form
    {
        public static Panel mainPanel;
        public static MenuBar menuBar;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            mainPanel = MainPanel;
            menuBar = MenuBar;

            MainPanelUserControlOpener.OpenUserControl(new MainPage());
        }
    }
}
