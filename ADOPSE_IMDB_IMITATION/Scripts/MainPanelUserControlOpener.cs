using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public static class MainPanelUserControlOpener
    {
        static UserControl displayedUserControl;

        //Opens the, given as parameter, usercontrol on the MainForm
        public static void OpenUserControl(UserControl userControl)
        {
            if (displayedUserControl != null)
                displayedUserControl.Dispose();

            displayedUserControl = userControl;
            MainForm.mainPanel.Controls.Add(displayedUserControl);
            displayedUserControl.Dock = DockStyle.Fill;
            displayedUserControl.Show();
        }
    }
}
