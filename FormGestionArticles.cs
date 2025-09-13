using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using GestionFacture;

namespace GestionDeFacturation
{
    public partial class FormGestionArticles : Form
    {
        Tools Tool = new Tools(); // Create an instance of the Tools class

        public FormGestionArticles()
        {
            InitializeComponent();
            LoadArticles(); // Load articles when the form is initialized
            // Add event handlers for the search fields
            txtSearchName.TextChanged += txtSearchName_TextChanged;
            dgvArticles.CellDoubleClick += dgvArticles_CellDoubleClick;
        }

        // Method to load articles from the database and display them in the DataGridView
        private void LoadArticles(string filterName = "")
        {
            try
            {
                DataTable dt = Tool.LoadFilteredData("Article", "Nom_Article", filterName);
                dgvArticles.DataSource = dt; // Bind the DataTable to the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement: " + ex.Message); // Show error message if loading fails
            }
        }

        // Event handler for the search by name field
        private void txtSearchName_TextChanged(object? sender, EventArgs e)
        {
            LoadArticles(txtSearchName.Text);
        }


        // Event handler for the DataGridView cell double click
        private void dgvArticles_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the row index is valid
            {
                DataGridViewRow row = dgvArticles.Rows[e.RowIndex];
                txtArticleName.Text = row.Cells["Nom_Article"].Value?.ToString() ?? string.Empty;
                numStockQty.Value = Convert.ToInt32(row.Cells["Qte_Stock"].Value ?? 0);
                textBoxDecimalPUHTVA.Text = row.Cells["PUHTVA"].Value?.ToString() ?? string.Empty;
                numTVA.Value = Convert.ToInt32(row.Cells["TVA"].Value ?? 0);
            }
        }

        // Method to clear input fields and set focus to the first input field
        private void ClearInputFields()
        {
            txtArticleName.Clear();
            numStockQty.Value = 0;
            textBoxDecimalPUHTVA.Clear();
            numTVA.Value = 20;
            txtArticleName.Focus();
        }

        // Method to add a new article to the database
        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            try
            {
                string articleName = txtArticleName.Text;
                int stockQty = (int)numStockQty.Value;
                decimal puhtva = decimal.Parse(textBoxDecimalPUHTVA.Text);
                int tva = (int)numTVA.Value;

                // Validate input fields
                if (string.IsNullOrEmpty(articleName) || stockQty == 0 || puhtva == 0 || tva == 0)
                {
                    MessageBox.Show("Veuillez remplir tous les champs!");
                    return;
                }

                // Check if the article already exists
                string checkQuery = "SELECT COUNT(*) FROM Article WHERE Nom_Article = @Nom_Article";
                var checkParams = new Dictionary<string, object>
                    {
                        { "@Nom_Article", articleName }
                    };
                if (Tool.RecordExists(checkQuery, checkParams))
                {
                    MessageBox.Show("L'article existe déjà!");
                    return;
                }

                // Add the new article
                string query = @"INSERT INTO Article 
                                     (Nom_Article, Qte_Stock, PUHTVA, TVA, 
                                      Creer_Par, Date_Creation)
                                     VALUES (@Nom_Article, @Qte_Stock, @PUHTVA, @TVA, 
                                     @Creer_Par, GETDATE())";
                var parameters = new Dictionary<string, object>
                    {
                        { "@Nom_Article", articleName },
                        { "@Qte_Stock", stockQty },
                        { "@PUHTVA", puhtva },
                        { "@TVA", tva },
                        { "@Creer_Par", FormLogin.CurrentUser }
                    };
                Tool.Execution_Query(query, parameters);

                LoadArticles(); // Reload articles to reflect the new addition
                MessageBox.Show("Article ajouté avec succès!");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if adding fails
            }
        }

        // Method to edit an existing article in the database
        private void btnEditArticle_Click(object sender, EventArgs e)
        {
            if (dgvArticles.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un article!");
                return;
            }

            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtArticleName.Text) || numStockQty.Value == 0 || string.IsNullOrWhiteSpace(textBoxDecimalPUHTVA.Text) || numTVA.Value == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs!");
                return;
            }

            try
            {
                int codeArticle = (int)(dgvArticles.CurrentRow?.Cells["Code_Article"].Value ?? 0);

                string query = @"UPDATE Article SET 
                                     Nom_Article = @Nom_Article,
                                     Qte_Stock = @Qte_Stock,
                                     PUHTVA = @PUHTVA,
                                     TVA = @TVA,
                                     Modifier_Par = @Modifier_Par,
                                     Date_Modification = GETDATE()
                                     WHERE Code_Article = @Code_Article";
                var parameters = new Dictionary<string, object>
                    {
                        { "@Code_Article", codeArticle },
                        { "@Nom_Article", txtArticleName.Text },
                        { "@Qte_Stock", numStockQty.Value },
                        { "@PUHTVA", decimal.Parse(textBoxDecimalPUHTVA.Text) },
                        { "@TVA", numTVA.Value },
                        { "@Modifier_Par", FormLogin.CurrentUser }
                    };
                Tool.Execution_Query(query, parameters);

                LoadArticles(); // Reload articles to reflect the changes
                MessageBox.Show("Article modifié avec succès!");
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if editing fails
            }
        }

        // Method to delete an article from the database
        private void btnDeleteArticle_Click(object sender, EventArgs e)
        {
            if (dgvArticles.CurrentRow == null)
            {
                MessageBox.Show("Sélectionnez un article!");
                return;
            }

            // Prompt the user for confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int codeArticle = (int)(dgvArticles.CurrentRow?.Cells["Code_Article"].Value ?? 0);

                    string query = "DELETE FROM Article WHERE Code_Article = @Code_Article";
                    var parameters = new Dictionary<string, object>
            {
                { "@Code_Article", codeArticle }
            };
                    Tool.Execution_Query(query, parameters);

                    LoadArticles(); // Reload articles to reflect the deletion
                    MessageBox.Show("Article supprimé avec succès!");
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
