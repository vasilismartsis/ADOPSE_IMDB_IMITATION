using ADOPSE_IMDB_IMITATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

class PlaceholderTextBox : TextBox
{
    public string placeholderValue;

    [Description("Placeholder"), Category("Appearance")]
    public string Placeholder
    {
        get => Text;
        set => Text = value;
    }

    public PlaceholderTextBox()
    {
        ForeColor = Color.DarkGray;
    }

    protected override void OnCreateControl()
    {
        base.OnCreateControl();

        SetPlaceholderValue();
    }

    void SetPlaceholderValue()
    {
        placeholderValue = Placeholder;
    }

    protected override void OnEnter(EventArgs e)
    {
        base.OnEnter(e);

        if (Text == placeholderValue)
        {
            Text = "";

            if (Session.Theme() == "Light")
                ForeColor = Color.Black;
            else
                ForeColor = Color.White;
        }
    }

    protected override void OnLeave(EventArgs e)
    {
        base.OnLeave(e);

        if (Text == "")
        {
            Text = placeholderValue;

            ForeColor = Color.DarkGray;
        }
    }
}
