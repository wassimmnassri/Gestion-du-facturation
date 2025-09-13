using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionDeFacturation.Controls
{
    public class TextBoxEmail : TextBox
    {
        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled);

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            if (!EmailRegex.IsMatch(this.Text))
            {
                this.BackColor = System.Drawing.Color.LightCoral;
            }
            else
            {
                this.BackColor = System.Drawing.Color.White;
            }
        }
    }
}
