using System;
using System.Windows.Forms;

namespace GestionDeFacturation.Controls
{
    public class TextBoxAlphanumerique : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!char.IsControl(e.KeyChar))
            {
                bool isLetter = char.IsLetter(e.KeyChar); 
                bool isDigit = char.IsDigit(e.KeyChar);
                bool isSpace = (e.KeyChar == ' ');

                if (!isLetter && !isDigit && !isSpace)
                {
                    e.Handled = true;
                }
            }
        }
    }
}