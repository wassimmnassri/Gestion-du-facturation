using System;
using System.Windows.Forms;

namespace GestionDeFacturation.Controls
{
    public class TextBoxNumerique : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Allow control keys and digits
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
