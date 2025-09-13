using System;
using System.Windows.Forms;

namespace GestionDeFacturation
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        // Event handler for the Save button click
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save settings logic here
            MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

