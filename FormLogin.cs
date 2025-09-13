using System;
using System.Data;
using System.Windows.Forms;
using GestionFacture;
using Microsoft.Data.SqlClient;

namespace GestionDeFacturation
{
    public partial class FormLogin : Form
    {
        public static string CurrentUser = ""; // Static variable to store the current user
        public static string CurrentUserRole = ""; // Static variable to store the current user's role
        Tools Tool = new Tools(); // Create an instance of the Tools class

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Connexion réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentUser = username;
                this.Hide();
                MenuForm menuForm = new MenuForm();
                menuForm.Show();
            }
            else
            {
                lblErrorMessage.Text = "Nom d'utilisateur ou mot de passe incorrect.";
            }
        }
        
        private bool AuthenticateUser(string username, string password)
        {
            string query = "SELECT Password, Type_Utilisateur FROM Utilisateur WHERE Login = @username";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username }
            };

            try
            {
                DataTable dt = Tool.LoadData(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    string storedPassword = dt.Rows[0]["Password"]?.ToString() ?? string.Empty;
                    string role = dt.Rows[0]["Type_Utilisateur"]?.ToString() ?? string.Empty;

                    if (password == storedPassword) // Replace with proper password hashing in production
                    {
                        CurrentUserRole = role;
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        


        // this methode is no sucure!!!! because I type this ' OR 1=1 -- in the password field and I can login
        // ✅ SECURE EXAMPLE: Parameters block SQL injection  
        // and handle data types (e.g., quotes, dates) safely
       /* private bool AuthenticateUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(Tool.ConnectionString))
            {
                try
                {
                    conn.Open();

                    // ❌ INSECURE CODE (DO NOT USE IN PRODUCTION) ❌
                    string query = $"SELECT COUNT(*) FROM Utilisateur WHERE Login = '{username}' AND Password = '{password}'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                    return false;
                }
            }
        }*/


        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = txtPassword.PasswordChar == '•' ? '\0' : '•';
        }
    }
}
