using System;
using System.Windows.Forms;

namespace GestionDeFacturation.Controls
{
    public class TextBoxAlphabetique : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Allow control keys and alphabetic characters
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}