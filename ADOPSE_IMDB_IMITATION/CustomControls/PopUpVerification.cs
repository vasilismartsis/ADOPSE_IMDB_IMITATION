using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION.CustomControls
{
    class PopUpVerification
    {
        
        public static bool ShowVerification(string message, string title) 
        {
            bool confirmation;
            DialogResult dialog = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                confirmation = true;
            }
            else
            {
                confirmation = false;
            }

            return confirmation;
        }
    }
}
