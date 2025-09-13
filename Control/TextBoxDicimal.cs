using System;
using System.Windows.Forms;

namespace GestionDeFacturation.Controls
{
    public class TextBoxDecimal : TextBox
    {
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            // Allow control keys, digits, and one decimal point or comma
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            // Only allow one decimal point or comma
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (this.Text.Contains(".") || this.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            // Replace comma with dot for consistency
            if (this.Text.Contains("."))
            {
                this.Text = this.Text.Replace('.', ',');
                this.SelectionStart = this.Text.Length; // Move cursor to the end
            }
        }
    }
}
