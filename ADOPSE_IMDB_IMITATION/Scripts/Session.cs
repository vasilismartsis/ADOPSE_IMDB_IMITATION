using ADOPSE_IMDB_IMITATION.DataAccess;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOPSE_IMDB_IMITATION
{
    public static class Session
    {
        public static int userId;
        public static bool administrator;
        public static Color ThemeColor()
        {
            if (Session.userId != 0)
            {
                if (UserDataAccess.GetUserById(Session.userId).UserSettings.Theme == "Light")
                    return SystemColors.Control;
                else if (UserDataAccess.GetUserById(Session.userId).UserSettings.Theme == "Dark")
                    return Color.FromArgb(0, 0, 0);
                else
                    return SystemColors.Control;
            }
            else
                return SystemColors.Control;
        }
        public static Color OpositeThemeColor()
        {
            if (Session.userId != 0)
            {
                if (UserDataAccess.GetUserById(Session.userId).UserSettings.Theme == "Light")
                    return Color.FromArgb(0, 0, 0);
                else if (UserDataAccess.GetUserById(Session.userId).UserSettings.Theme == "Dark")
                    return SystemColors.Control;
                else
                    return Color.FromArgb(0, 0, 0);
            }
            else
                return Color.FromArgb(0, 0, 0);
        }
        public static void SetThemeColor(UserControl userControl)
        {
            userControl.BackColor = ThemeColor();

            foreach (Control child in userControl.Controls)
            {
                child.BackColor = ThemeColor();
                child.ForeColor = OpositeThemeColor();
            }
        }
        public static void SetThemeColor(UserControl userControl, List<Object> userControlChildTypeExeption)
        {
            userControl.BackColor = ThemeColor();

            foreach (Control child in userControl.Controls)
                foreach (Control childTypeExeption in userControlChildTypeExeption)
                    if (child.GetType() != childTypeExeption.GetType())
                    {
                        child.BackColor = ThemeColor();
                        child.ForeColor = OpositeThemeColor();
                    }
        }
    }
}
