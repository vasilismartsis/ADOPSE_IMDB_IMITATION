using ADOPSE_IMDB_IMITATION.DataAccess;
using ADOPSE_IMDB_IMITATION.UserControls.MainPage;
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
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();

            SpawnCategories();

            Session.SetThemeColor(this);
        }

        void SpawnCategories()
        {
            CategoriesPanel.Controls.Add(new MainPageCategory(new int[] { 35, 36, 37, 38, 39, 40, 41, 42 }) { Dock = DockStyle.Top });
            CategoriesPanel.Controls.Add(new MainPageCategory(new int[] { 35, 36, 37, 38, 39, 40, 41, 42 }) { Dock = DockStyle.Top });
            CategoriesPanel.Controls.Add(new MainPageCategory(new int[] { 35, 36, 37, 38, 39, 40, 41, 42 }) { Dock = DockStyle.Top });
            CategoriesPanel.Controls.Add(new MainPageCategory(new int[] { 35, 36, 37, 38, 39, 40, 41, 42 }) { Dock = DockStyle.Top });
            CategoriesPanel.Controls.Add(new MainPageCategory(new int[] { 35, 36, 37, 38, 39, 40, 41, 42 }) { Dock = DockStyle.Top });
        }
    }
}
