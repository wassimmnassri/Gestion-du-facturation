using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using GestionFacture;

namespace GestionDeFacturation
{
    public partial class FormGestionUsers : Form
    {
        Tools Tool = new Tools(); // Create an instance of the Tools class

        public FormGestionUsers()
        {
            InitializeComponent();
            LoadUsers(); // Load users when the form is initialized

            // Add event handlers for the search fields
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            dgvUsers.CellDoubleClick += dgvUsers_CellDoubleClick; // Add double-click event
        }

        // Method to load users from the database and display them in the DataGridView
        private void LoadUsers(string filterName = "", string filterUserType = "")
        {
            try
            {
                DataTable dt = Tool.LoadFilteredData("Utilisateur", "Login", filterName);
                dgvUsers.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message); // Show error message if loading fails
            }
        }

        // Event handler for the search by name field
        private void txtSearchName_TextChanged(object? sender, EventArgs e)
        {
            LoadUsers(txtSearchName.Text);
        }


        // Event handler for the DataGridView cell double click
        private void dgvUsers_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells["Login"].Value?.ToString() ?? string.Empty;
                txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? string.Empty;
                cmbUserType.SelectedItem = row.Cells["Type_Utilisateur"].Value?.ToString() ?? string.Empty;
            }
        }

        // Method to clear input fields and set focus to the first input field
        private void ClearInputFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbUserType.SelectedIndex = -1;
            txtUsername.Focus();
        }

        // Method to add a new user to the database
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string userType = cmbUserType.SelectedItem?.ToString() ?? string.Empty; // Use null-coalescing operator

                // Validate input fields
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userType))
                {
                    MessageBox.Show("Veuillez remplir tous les champs!");
                    return;
                }

                // Check if the user already exists
                string checkQuery = "SELECT COUNT(*) FROM Utilisateur WHERE Login = @Login";
                var checkParams = new Dictionary<string, object>
                    {
                        { "@Login", username }
                    };
                if (Tool.RecordExists(checkQuery, checkParams))
                {
                    MessageBox.Show("L'utilisateur existe déjà!");
                    return;
                }

                // Add the new user
                string query = @"INSERT INTO Utilisateur (Login, Password, Type_Utilisateur) 
                                 VALUES (@Login, @Password, @Type_Utilisateur)";
                var parameters = new Dictionary<string, object>
                    {
                        { "@Login", username },
                        { "@Password", password }, // Consider hashing the password
                        { "@Type_Utilisateur", userType }
                    };
                Tool.Execution_Query(query, parameters);

                LoadUsers(); // Reload users to reflect the new addition
                MessageBox.Show("Utilisateur ajouté avec succès!");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message); // Show error message if adding fails
            }
        }

        // Method to edit an existing user in the database
        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un utilisateur!");
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || cmbUserType.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs!");
                return;
            }

            try
            {
                string oldLogin = dgvUsers.CurrentRow.Cells["Login"].Value?.ToString() ?? string.Empty;
                string newLogin = txtUsername.Text;
                string password = txtPassword.Text;
                string userType = cmbUserType.SelectedItem?.ToString() ?? string.Empty;

                string query = @"UPDATE Utilisateur SET 
                                     Login = @NewLogin,
                                     Password = @Password,
                                     Type_Utilisateur = @Type_Utilisateur
                                     WHERE Login = @OldLogin";
                var parameters = new Dictionary<string, object>
                    {
                        { "@OldLogin", oldLogin },
                        { "@NewLogin", newLogin },
                        { "@Password", password },
                        { "@Type_Utilisateur", userType }
                    };
                Tool.Execution_Query(query, parameters);

                LoadUsers(); // Reload users to reflect the changes
                MessageBox.Show("Utilisateur modifié avec succès!");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if editing fails
            }
        }

        // Method to delete a user from the database
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un utilisateur!");
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string selectedUser = dgvUsers.CurrentRow.Cells["Login"]?.Value?.ToString() ?? string.Empty;

                    if (string.IsNullOrEmpty(selectedUser))
                    {
                        MessageBox.Show("Utilisateur non valide!");
                        return;
                    }

                    string query = "DELETE FROM Utilisateur WHERE Login = @Login";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@Login", selectedUser }
                    };
                    Tool.Execution_Query(query, parameters);

                    LoadUsers(); // Reload users to reflect the deletion
                    MessageBox.Show("Utilisateur supprimé avec succès!");
                    ClearInputFields(); // Clear input fields and set focus
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message); // Show error message if deletion fails
                }
            }
        }
    }
}
