using ADOPSE_IMDB_IMITATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class PopupMessage
{
    public static Label messageLabel;

    public static void ShowMessage(string message, bool isWarning)
    {
        messageLabel = new Label
        {
            Dock = DockStyle.Bottom,
            Location = new Point(0, 516),
            Name = "label1",
            Size = new Size(647, 13),
            TabIndex = 1,
            Text = message,
            TextAlign = ContentAlignment.MiddleCenter,
            ForeColor = Color.White,
            BackColor = Color.Green
        };

        if (isWarning)
            messageLabel.BackColor = Color.Red;

        MainForm.mainPanel.Controls.Add(messageLabel);

        Task.Delay(2000).ContinueWith(t => DestroyWithDelay());
    }

    public static void DestroyWithDelay()
    {
        messageLabel.Dispose();
    }
}
