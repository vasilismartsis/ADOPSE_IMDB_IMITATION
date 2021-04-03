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
        static UserControl displayedForm;

        //Opens the, given as parameter, usercontrol on the MainForm
        public static void OpenUserControl(UserControl userControl)
        {
            if (displayedForm != null)
                displayedForm.Dispose();

            displayedForm = userControl;
            MainForm.mainPanel.Controls.Add(displayedForm);
            displayedForm.Dock = DockStyle.Fill;
            displayedForm.Show();
        }
    }
}
