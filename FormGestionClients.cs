using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using GestionFacture;

namespace GestionDeFacturation
{
    public partial class FormGestionClients : Form
    {
        Tools Tool = new Tools(); // Create an instance of the Tools class

        public FormGestionClients()
        {
            InitializeComponent();
            LoadClients(); // Load clients when the form is initialized

            // Add event handlers for the search fields
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            dgvClients.CellDoubleClick += dgvClients_CellDoubleClick;
        }

        // Method to load clients from the database and display them in the DataGridView
        private void LoadClients(string filterName = "", string filterCode = "")
        {
            try
            {
                DataTable dt = Tool.LoadFilteredData("Client", "Nom_Prenom", filterName);
                dgvClients.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement: " + ex.Message); // Show error message if loading fails
            }
        }

        // Event handler for the search by name field
        private void txtSearchName_TextChanged(object? sender, EventArgs e)
        {
            LoadClients(txtSearchName.Text);
        }



        // Event handler for the DataGridView cell double click
        private void dgvClients_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dgvClients.Rows[e.RowIndex];
                txtFullName.Text = row.Cells["Nom_Prenom"].Value?.ToString() ?? string.Empty;
                textBoxAlphanumerique1.Text = row.Cells["Matricule_Fiscale"].Value?.ToString() ?? string.Empty;
                txtAddress.Text = row.Cells["Adresse"].Value?.ToString() ?? string.Empty;
                textBoxPhone1.Text = row.Cells["Num_Telephone"].Value?.ToString() ?? string.Empty;
            }
        }

        // Method to clear input fields and set focus to the first input field
        private void ClearInputFields()
        {
            txtFullName.Clear();
            textBoxAlphanumerique1.Clear();
            txtAddress.Clear();
            textBoxPhone1.Clear();
            txtFullName.Focus();
        }

        // Method to add a new client to the database
        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                string nomPrenom = txtFullName.Text;
                string matriculeFiscale = textBoxAlphanumerique1.Text;
                string adresse = txtAddress.Text;
                string numTelephone = textBoxPhone1.Text;

                // Validate input fields
                if (string.IsNullOrWhiteSpace(nomPrenom) || string.IsNullOrWhiteSpace(matriculeFiscale) || string.IsNullOrWhiteSpace(adresse))
                {
                    MessageBox.Show("Veuillez remplir les champs obligatoires !");
                    return;
                }
                if (string.IsNullOrWhiteSpace(numTelephone) || numTelephone.Length != 8)
                {
                    MessageBox.Show("Numéro de téléphone invalide !");
                    return;
                }

                // Check if the client already exists
                string checkQuery = "SELECT COUNT(*) FROM Client WHERE Nom_Prenom = @Nom_Prenom AND Matricule_Fiscale = @Matricule_Fiscale";
                var checkParams = new Dictionary<string, object>
                    {
                        { "@Nom_Prenom", nomPrenom },
                        { "@Matricule_Fiscale", matriculeFiscale }
                    };
                if (Tool.RecordExists(checkQuery, checkParams))
                {
                    MessageBox.Show("Le client existe déjà !");
                    return;
                }

                // Add the new client
                string query = @"INSERT INTO Client 
                                     (Nom_Prenom, Matricule_Fiscale, Adresse, Num_Telephone, 
                                      Creer_Par, Date_Creation)
                                     VALUES (@Nom_Prenom, @Matricule_Fiscale, @Adresse, @Num_Telephone, 
                                     @Creer_Par, GETDATE())";
                var parameters = new Dictionary<string, object>
                    {
                        { "@Nom_Prenom", nomPrenom },
                        { "@Matricule_Fiscale", matriculeFiscale },
                        { "@Adresse", adresse },
                        { "@Num_Telephone", numTelephone },
                        { "@Creer_Par", FormLogin.CurrentUser }
                    };
                Tool.Execution_Query(query, parameters);

                LoadClients(); // Reload clients to reflect the new addition
                MessageBox.Show("Client ajouté avec succès !");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if adding fails
            }
        }

        // Method to edit an existing client in the database
        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un client !");
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(textBoxAlphanumerique1.Text) || string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Veuillez remplir les champs obligatoires !");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPhone1.Text) || textBoxPhone1.Text.Length != 8)
            {
                MessageBox.Show("Numéro de téléphone invalide !");
                return;
            }

            try
            {
                int codeClient = dgvClients.CurrentRow?.Cells["Code_Client"].Value as int? ?? 0;

                string query = @"UPDATE Client SET 
                             Nom_Prenom = @Nom_Prenom,
                             Matricule_Fiscale = @Matricule_Fiscale,
                             Adresse = @Adresse,
                             Num_Telephone = @Num_Telephone,
                             Modifier_Par = @Modifier_Par,
                             Date_Modification = GETDATE()
                             WHERE Code_Client = @Code_Client";
                var parameters = new Dictionary<string, object>
                {
                    { "@Code_Client", codeClient },
                    { "@Nom_Prenom", txtFullName.Text },
                    { "@Matricule_Fiscale", textBoxAlphanumerique1.Text },
                    { "@Adresse", txtAddress.Text },
                    { "@Num_Telephone", textBoxPhone1.Text },
                    { "@Modifier_Par", FormLogin.CurrentUser }
                };
                Tool.Execution_Query(query, parameters);

                LoadClients(); // Reload clients to reflect the changes
                MessageBox.Show("Client modifié avec succès !");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if editing fails
            }
        }

        // Method to delete a client from the database
        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvClients.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un client !");
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce client?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int codeClient = dgvClients.CurrentRow?.Cells["Code_Client"].Value as int? ?? 0;

                    string query = "DELETE FROM Client WHERE Code_Client = @Code_Client";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@Code_Client", codeClient }
                    };
                    Tool.Execution_Query(query, parameters);

                    LoadClients(); // Reload clients to reflect the deletion
                    MessageBox.Show("Client supprimé avec succès !");
                    ClearInputFields(); // Clear input fields and set focus
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message); // Show error message if deletion fails
                }
            }
        }
    }
}
