using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADOPSE_IMDB_IMITATION
{
    public static class PopupMessage1
    {
        public static void ShowToolTip(Form senderForm, string message, Color backgroundColor)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.OwnerDraw = true;
            tooltip.Draw += new DrawToolTipEventHandler(DrawTooltip);
            tooltip.ForeColor = Color.White;
            tooltip.BackColor = backgroundColor;

            tooltip.Show(message, senderForm, Cursor.Position.X - senderForm.Location.X + 20, Cursor.Position.Y - senderForm.Location.Y + 20, 1000);
        }

        public static void DrawTooltip(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }
    }
}
