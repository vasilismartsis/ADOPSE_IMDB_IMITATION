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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            mainPanel = MainPanel;

            MainPanelUserControlOpener.OpenUserControl(new Movie(14));
        }
    }
}
