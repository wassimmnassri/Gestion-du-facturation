namespace GestionDeFacturation
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button btnShowPassword;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxLogo = new PictureBox();
            lblUsername = new Label();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            lblPassword = new Label();
            panelPassword = new Panel();
            txtPassword = new TextBox();
            btnShowPassword = new Button();
            lblErrorMessage = new Label();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelUsername.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = GestionFacture.Properties.Resources.password;
            pictureBoxLogo.Location = new Point(165, 197);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(43, 37);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Arial", 10F);
            lblUsername.ForeColor = Color.Gray;
            lblUsername.Location = new Point(214, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(100, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Login";
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.LightGray;
            panelUsername.BorderStyle = BorderStyle.FixedSingle;
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Location = new Point(214, 107);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(300, 40);
            panelUsername.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Arial", 12F);
            txtUsername.Location = new Point(9, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(280, 23);
            txtUsername.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Arial", 10F);
            lblPassword.ForeColor = Color.Gray;
            lblPassword.Location = new Point(210, 171);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mot de passe";
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.LightGray;
            panelPassword.BorderStyle = BorderStyle.FixedSingle;
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(btnShowPassword);
            panelPassword.Location = new Point(210, 197);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(307, 40);
            panelPassword.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 12F);
            txtPassword.Location = new Point(6, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(260, 23);
            txtPassword.TabIndex = 0;
            // 
            // btnShowPassword
            // 
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.ForeColor = Color.Black;
            btnShowPassword.Location = new Point(272, 3);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(30, 30);
            btnShowPassword.TabIndex = 1;
            btnShowPassword.Text = "👁";
            btnShowPassword.Click += BtnShowPassword_Click;
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Font = new Font("Arial", 9F, FontStyle.Bold);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(197, 295);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 18);
            lblErrorMessage.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(199, 377);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(300, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Se connecter";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(165, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            BackColor = Color.White;
            ClientSize = new Size(724, 496);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblUsername);
            Controls.Add(panelUsername);
            Controls.Add(lblPassword);
            Controls.Add(panelPassword);
            Controls.Add(lblErrorMessage);
            Controls.Add(btnLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
