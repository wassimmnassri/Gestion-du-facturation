using System;
using System.Windows.Forms;

namespace GestionDeFacturation
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            CheckPermissions(); // Check user permissions when the form is initialized
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormGestionUsers());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormGestionClients());
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormGestionArticles());
        }

        private void btnFactures_Click(object sender, EventArgs e)
        {
            ShowFormInPanel(new FormGestionFactures());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",  // Message
                "Confirm Logout",                     // Title
                MessageBoxButtons.YesNo,             // Buttons
                MessageBoxIcon.Question              // Icon
            );

            // If user clicks "Yes", close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gestion de Facturation\nVersion 1.0\nDéveloppé par Khalil Amamri", "About");
        }

        private void ShowFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(label3);
            mainPanel.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isExpanded = false; // Initial state

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (isExpanded)
            {
                sidePanel.Width -= 10;
                if (sidePanel.Width <= sidePanel.MinimumSize.Width)
                {
                    sidePanel.Width = sidePanel.MinimumSize.Width;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                sidePanel.Width += 10;
                if (sidePanel.Width >= sidePanel.MaximumSize.Width)
                {
                    sidePanel.Width = sidePanel.MaximumSize.Width;
                    SideBarTimer.Stop();
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            if (!SideBarTimer.Enabled) // Prevent interrupting animation
            {
                isExpanded = !isExpanded; // Toggle BEFORE starting the timer
                SideBarTimer.Start();
            }
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {

            ShowFormInPanel(new FormSettings());
        }
        // Method to check user permissions
        private void CheckPermissions()
        {
            if (FormLogin.CurrentUserRole.ToUpper() != "Admin".ToUpper())
            {
                btnUsers.Enabled = false; // Disable the GestionUser button if the user is not an admin
                btnUsers.BackColor = System.Drawing.Color.Silver; // Change the button color
            }
        }
    }
}

