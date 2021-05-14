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
        public static string Theme()
        {
            if (userId != 0)
                return UserDataAccess.GetUserById(userId).UserSettings.Theme;
            else
                return "Light";
        }
        public static Color ThemeColor()
        {
            if (userId != 0)
            {
                if (Theme() == "Light")
                    return Color.White;
                else if (Theme() == "Dark")
                    return Color.FromArgb(0, 0, 0);
                else
                    return Color.White;
            }
            else
                return Color.White;
        }
        public static Color OpositeThemeColor()
        {
            if (userId != 0)
            {
                if (Theme() == "Light")
                    return Color.FromArgb(0, 0, 0);
                else if (Theme() == "Dark")
                    return Color.White;
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
        public static void SetThemeColor(UserControl userControl, List<Object> userControlChildTypeException)
        {
            userControl.BackColor = ThemeColor();

            foreach (Control child in userControl.Controls)
            {
                bool exceptionFound = false;

                foreach (Control childTypeException in userControlChildTypeException)
                    if (child.GetType() == childTypeException.GetType())
                        exceptionFound = true;

                if (!exceptionFound)
                {
                    child.BackColor = ThemeColor();
                    child.ForeColor = OpositeThemeColor();
                }
            }
        }
    }
}
