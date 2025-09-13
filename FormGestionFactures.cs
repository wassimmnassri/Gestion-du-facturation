using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;
using GestionFacture;

namespace GestionDeFacturation
{
    public partial class FormGestionFactures : Form
    {
        Tools Tool = new Tools(); // Create an instance of the Tools class
        private decimal droitTimbre = 5.0m; // Fixed stamp duty
        private decimal totalHT = 0; // Total amount excluding tax
        private decimal tva = 0; // Value-added tax

        public FormGestionFactures()
        {
            InitializeComponent();
            LoadClients(); // Load clients when the form is initialized
            LoadArticles(); // Load articles when the form is initialized
            GenerateInvoiceNumber(); // Generate a new invoice number when the form is initialized
        }

        // Method to generate a new invoice number
        private void GenerateInvoiceNumber()
        {
            try
            {
                int nextNum = Tool.GenerateInvoiceNumber(); // Get the next invoice number
                txtNumeroFacture.Text = nextNum.ToString(); // Display the invoice number
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if generating invoice number fails
            }
        }

        // Method to load clients from the database and display them in the ComboBox
        private void LoadClients()
        {
            try
            {
                DataTable dt = Tool.LoadClients();
                cmbClient.DataSource = dt; // Bind the DataTable to the ComboBox
                cmbClient.DisplayMember = "Nom_Prenom"; // Display the client's name
                cmbClient.ValueMember = "Code_Client"; // Use the client's code as the value
                cmbClient.SelectedIndex = -1; // Ensure no item is selected by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if loading clients fails
            }
        }

        // Method to load articles from the database and display them in the ComboBox
        private void LoadArticles()
        {
            try
            {
                DataTable dt = Tool.LoadArticles();
                cmbArticle.DataSource = dt; // Bind the DataTable to the ComboBox
                cmbArticle.DisplayMember = "Nom_Article"; // Display the article's name
                cmbArticle.ValueMember = "Code_Article"; // Use the article's code as the value
                cmbArticle.SelectedIndex = -1; // Ensure no item is selected by default
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if loading articles fails
            }
        }

        // Method to clear input fields and set focus to the first input field
        private void ClearInputFields()
        {
            cmbArticle.SelectedIndex = -1;
            nudQuantite.Value = 0;
            txtRemise.Text = "0"; // Set default value to 0
            cmbArticle.Focus();
            txtStockQuantity.Text = ""; // Clear the stock quantity
        }

        // Method to add an article to the invoice
        private void btnAjouterArticle_Click(object sender, EventArgs e)
        {
            if (cmbArticle.SelectedValue == null || nudQuantite.Value == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article et une quantité valide!");
                return;
            }

            try
            {
                decimal prix = GetArticlePrice((int)cmbArticle.SelectedValue);
                decimal quantite = nudQuantite.Value; // NumericUpDown.Value
                decimal remise = 0;

                // Validate remise
                if (!decimal.TryParse(txtRemise.Text, out remise))
                {
                    MessageBox.Show("Veuillez entrer une remise valide!");
                    return;
                }

                int codeArticle = (int)cmbArticle.SelectedValue;
                decimal stockQuantity = decimal.Parse(txtStockQuantity.Text);

                // Calculate the total quantity of the article already in the DataGridView
                decimal totalQuantityInGrid = 0;
                foreach (DataGridViewRow row in dgvFactureDetails.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colCodeArticle"].Value) == codeArticle)
                    {
                        totalQuantityInGrid += Convert.ToDecimal(row.Cells["colQuantite"].Value);
                    }
                }

                // Check if the new quantity exceeds the stock quantity
                if (totalQuantityInGrid + quantite > stockQuantity)
                {
                    MessageBox.Show("La quantité demandée dépasse la quantité en stock!");
                    return;
                }

                // Check if the article already exists in the DataGridView
                bool articleExists = false;
                foreach (DataGridViewRow row in dgvFactureDetails.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colCodeArticle"].Value) == codeArticle)
                    {
                        // Update the existing row
                        row.Cells["colQuantite"].Value = Convert.ToDecimal(row.Cells["colQuantite"].Value) + quantite;
                        row.Cells["colTotal"].Value = (prix * Convert.ToDecimal(row.Cells["colQuantite"].Value)) * (1 - remise / 100);
                        articleExists = true;
                        break;
                    }
                }

                if (!articleExists)
                {
                    // Add a new row
                    dgvFactureDetails.Rows.Add(
                        codeArticle, // Store Article Code
                        cmbArticle.Text, // Store Article Name
                        prix,
                        quantite,
                        remise,
                        (prix * quantite) * (1 - remise / 100)
                    );
                }

                CalculateTotals(); // Recalculate totals after adding the article
                ClearInputFields(); // Clear input fields and set focus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if adding article fails
            }
        }

        // Method to get the price of an article from the database
        private decimal GetArticlePrice(int codeArticle)
        {
            string query = "SELECT PUHTVA FROM Article WHERE Code_Article = @Code";
            var parameters = new Dictionary<string, object>
            {
                { "@Code", codeArticle }
            };
            return (decimal)Tool.LoadData(query, parameters).Rows[0][0]; // Return the price of the article
        }

        // Method to calculate the totals for the invoice
        private void CalculateTotals()
        {
            totalHT = 0;
            foreach (DataGridViewRow row in dgvFactureDetails.Rows)
            {
                totalHT += Convert.ToDecimal(row.Cells[5].Value); // Sum the total price of all articles
            }

            decimal tvaRate = nudTVA.Value / 100; // Get the TVA rate from the NumericUpDown control
            tva = totalHT * tvaRate; // Calculate the VAT based on the user-defined rate
            decimal totalTTC = totalHT + tva + droitTimbre; // Calculate the total amount including VAT and stamp duty

            // Display the totals
            lblTotalHTValue.Text = totalHT.ToString("N2", CultureInfo.InvariantCulture);
            lblTVAValue.Text = tva.ToString("N2", CultureInfo.InvariantCulture);
            lblTimbreValue.Text = droitTimbre.ToString("N2", CultureInfo.InvariantCulture);
            lblTotalTTCValue.Text = totalTTC.ToString("N2", CultureInfo.InvariantCulture);
        }

        // Method to generate the invoice and save it to the database
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un client!");
                return;
            }

            if (dgvFactureDetails.Rows.Count == 0)
            {
                MessageBox.Show("Ajoutez des articles à la facture!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(Tool.ConnectionString))
                {
                    conn.Open(); // Open the database connection
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string query = @"INSERT INTO Facture 
                                     (Date_Facture, Code_Client, Total_HTVA, 
                                      Montant_TVA_Facture, Montant_HTVA_Facture, Droit_Timbre, Creer_Par, Date_Creation)
                                     VALUES (@Date, @Client, @HT, @TVA, @HT, @Timbre, @User, GETDATE());
                                     SELECT SCOPE_IDENTITY();";

                            using (SqlCommand cmd = new SqlCommand(query, conn, transaction))
                            {
                                // Add parameters to the SQL command
                                cmd.Parameters.AddWithValue("@Date", dtpDateFacture.Value.Date);
                                cmd.Parameters.AddWithValue("@Client", cmbClient.SelectedValue);
                                cmd.Parameters.AddWithValue("@HT", totalHT);
                                cmd.Parameters.AddWithValue("@TVA", tva);
                                cmd.Parameters.AddWithValue("@Timbre", droitTimbre);
                                cmd.Parameters.AddWithValue("@User", FormLogin.CurrentUser);
                                int newInvoiceNumber = Convert.ToInt32(cmd.ExecuteScalar()); // Get the new invoice number

                                // Save the invoice details
                                foreach (DataGridViewRow row in dgvFactureDetails.Rows)
                                {
                                    int articleCode = row.Cells[0].Value != null ? (int)(row.Cells[0].Value ?? 0) : 0; // Get the article code directly from the DataGridView
                                    decimal quantitySold = Convert.ToDecimal(row.Cells[3].Value); // Get the quantity sold

                                    string detailQuery = @"INSERT INTO Ligne_Facture 
                                                   (Num_Facture, Code_Article, Qte_Vendu, Remise, Totale_HTVA)
                                                   VALUES (@Num, @Code, @Qte, @Remise, @Total)";
                                    using (SqlCommand detailCmd = new SqlCommand(detailQuery, conn, transaction))
                                    {
                                        // Add parameters to the SQL command
                                        detailCmd.Parameters.AddWithValue("@Num", newInvoiceNumber);
                                        detailCmd.Parameters.AddWithValue("@Code", articleCode); // Use the article code directly
                                        detailCmd.Parameters.AddWithValue("@Qte", quantitySold); // Ensure this is the correct column index or name
                                        detailCmd.Parameters.AddWithValue("@Remise", row.Cells[3].Value); // Ensure this is the correct column index or name
                                        detailCmd.Parameters.AddWithValue("@Total", row.Cells[4].Value); // Ensure this is the correct column index or name
                                        detailCmd.ExecuteNonQuery(); // Execute the SQL command
                                    }

                                    // Update the stock quantity in the database
                                    Tool.UpdateStockQuantity(articleCode, quantitySold);
                                }

                                transaction.Commit(); // Commit the transaction
                                MessageBox.Show("Facture générée avec succès!");
                                dgvFactureDetails.Rows.Clear(); // Clear the DataGridView
                                GenerateInvoiceNumber(); // Generate a new invoice number
                                ClearClientInputFields(); // Clear the client details
                            }
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback(); // Rollback the transaction if an error occurs
                            MessageBox.Show("Erreur: " + ex.Message); // Show error message if generating invoice fails
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message); // Show error message if generating invoice fails
            }
        }
        private void ClearClientInputFields()
        {
            cmbClient.SelectedIndex = -1; // Deselect any selected client
            txtClientCode.Clear(); // Clear the client code text box
            txtClientAddress.Clear(); // Clear the client address text box
            txtClientPhone.Clear(); // Clear the client phone text box
            txtTaxNumber.Clear(); // Clear the tax number text box
        }

        // Event handler for client selection change
        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClient.SelectedValue != null && int.TryParse(cmbClient.SelectedValue.ToString(), out int clientCode))
            {
                LoadClientDetails(clientCode);
            }
        }

        // Method to load client details based on client code
        private void LoadClientDetails(int clientCode)
        {
            string query = "SELECT * FROM Client WHERE Code_Client = @Code";
            var parameters = new Dictionary<string, object>
            {
                { "@Code", clientCode }
            };
            DataTable dt = Tool.LoadData(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                // Display client details
                txtClientCode.Text = row["Code_Client"].ToString();
                txtClientAddress.Text = row["Adresse"].ToString();
                txtClientPhone.Text = row["Num_Telephone"].ToString();
                txtTaxNumber.Text = row["Matricule_Fiscale"].ToString();
            }
        }

        // Event handler for article selection change
        private void cmbArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArticle.SelectedValue != null && int.TryParse(cmbArticle.SelectedValue.ToString(), out int articleCode))
            {
                LoadArticleDetails(articleCode);
            }
        }

        // Method to load article details based on article code
        private void LoadArticleDetails(int articleCode)
        {
            string query = "SELECT * FROM Article WHERE Code_Article = @Code";
            var parameters = new Dictionary<string, object>
            {
                { "@Code", articleCode }
            };
            DataTable dt = Tool.LoadData(query, parameters);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                // Display article details
                txtStockQuantity.Text = Convert.ToInt32(row["Qte_Stock"]).ToString(); // Assuming the column name is Stock_Quantity
            }
        }


        // Method to print the invoice
        private void btnImprimer_Click(object sender, EventArgs e)
        {
            // Implement the print functionality here
            MessageBox.Show("Imprimer la facture");
        }
    }
}

