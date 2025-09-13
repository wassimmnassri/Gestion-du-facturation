using Microsoft.Data.SqlClient;
using System.Data;

namespace GestionFacture
{
    class Tools
    {
        // Connection string to connect to the database
        public string ConnectionString = @"Data Source=LAPTOP-ODCPSS87;Initial Catalog=DB_GestionFacture;Integrated Security=True;Trust Server Certificate=True;";

        // Method to execute a non-query SQL command (e.g., INSERT, UPDATE, DELETE)
        public void Execution_Query(string query, Dictionary<string, object>? parameters = null)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Method to check if a record exists in the database
        public bool RecordExists(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                    }
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }

        // Method to load data from the database into a DataTable
        public DataTable LoadData(string query, Dictionary<string, object>? parameters = null)
        {
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            cmd.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        // Generic method to load and filter data from the database
        public DataTable LoadFilteredData(string tableName, string filterColumn, string filterValue)
        {
            string query = $@"SELECT * FROM {tableName}
                                  WHERE {filterColumn} LIKE @FilterValue";
            var parameters = new Dictionary<string, object>
                {
                    { "@FilterValue", "%" + filterValue + "%" },
                };
            return LoadData(query, parameters);
        }

        // Method to load clients from the database
        public DataTable LoadClients()
        {
            string query = "SELECT Code_Client, Nom_Prenom, Adresse, Num_Telephone FROM Client";
            return LoadData(query);
        }

        // Method to load articles from the database
        public DataTable LoadArticles()
        {
            string query = "SELECT Code_Article, Nom_Article, PUHTVA FROM Article";
            return LoadData(query);
        }

        // Method to update the stock quantity of an article
        public void UpdateStockQuantity(int articleCode, decimal quantitySold)
        {
            string query = "UPDATE Article SET Qte_Stock = Qte_Stock - @QuantitySold WHERE Code_Article = @Code";
            var parameters = new Dictionary<string, object>
                {
                    { "@QuantitySold", quantitySold },
                    { "@Code", articleCode }
                };
            Execution_Query(query, parameters);
        }

        // Method to generate a new invoice number
        public int GenerateInvoiceNumber()
        {
            string query = "SELECT ISNULL(MAX(Num_Facture), 0) + 1 FROM Facture";
            return (int)LoadData(query).Rows[0][0];
        }
    }
}
