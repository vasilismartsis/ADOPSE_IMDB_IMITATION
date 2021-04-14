using ADOPSE_IMDB_IMITATION.Scripts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.UserControls
{
    public partial class BrowseMovies : UserControl
    {
        List<int> ListWithIds = new List<int>();
        
        
        
          
     public void fillList() // Get the ids of the movies
        {
            GetIdsFromDB List = new GetIdsFromDB();
            this.ListWithIds = List.returnList();
        }   
        public BrowseMovies()
        {
            InitializeComponent();

        }
        public void showAllSmallWindowMovie() 
        { 
            for(int i=0; i<ListWithIds.Count(); i++)
            {
                SmallWindowMovie x = new SmallWindowMovie(ListWithIds[i]);
                flowLayoutBrowseMovies.Controls.Add(x);
            }
        }


        private void BrowseMoviesUI_Load(object sender, EventArgs e)
        {
            fillList();
            showAllSmallWindowMovie();
           
        }
    }
}
