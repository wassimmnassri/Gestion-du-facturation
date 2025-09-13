namespace GestionDeFacturation
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnArticles;
        private System.Windows.Forms.Button btnFactures;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAbout;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            sidePanel = new Panel();
            btnSettings = new Button();
            label4 = new Label();
            MenuButton = new PictureBox();
            button1 = new Button();
            btnUsers = new Button();
            btnClients = new Button();
            btnArticles = new Button();
            btnFactures = new Button();
            btnLogout = new Button();
            btnAbout = new Button();
            mainPanel = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            SideBarTimer = new System.Windows.Forms.Timer(components);
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).BeginInit();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.White;
            sidePanel.BorderStyle = BorderStyle.Fixed3D;
            sidePanel.Controls.Add(btnSettings);
            sidePanel.Controls.Add(label4);
            sidePanel.Controls.Add(MenuButton);
            sidePanel.Controls.Add(button1);
            sidePanel.Controls.Add(btnUsers);
            sidePanel.Controls.Add(btnClients);
            sidePanel.Controls.Add(btnArticles);
            sidePanel.Controls.Add(btnFactures);
            sidePanel.Controls.Add(btnLogout);
            sidePanel.Controls.Add(btnAbout);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            sidePanel.Location = new Point(0, 0);
            sidePanel.Margin = new Padding(3, 4, 3, 4);
            sidePanel.MaximumSize = new Size(184, 689);
            sidePanel.MinimumSize = new Size(57, 689);
            sidePanel.Name = "sidePanel";
            sidePanel.RightToLeft = RightToLeft.No;
            sidePanel.Size = new Size(57, 689);
            sidePanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.White;
            btnSettings.Cursor = Cursors.Hand;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 475);
            btnSettings.Margin = new Padding(3, 4, 3, 4);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(160, 58);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "     Settings";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 17);
            label4.Name = "label4";
            label4.Size = new Size(76, 31);
            label4.TabIndex = 9;
            label4.Text = "Menu";
            // 
            // MenuButton
            // 
            MenuButton.Cursor = Cursors.Hand;
            MenuButton.Image = GestionFacture.Properties.Resources.SideBarPicture;
            MenuButton.Location = new Point(3, 10);
            MenuButton.Name = "MenuButton";
            MenuButton.Size = new Size(50, 47);
            MenuButton.SizeMode = PictureBoxSizeMode.StretchImage;
            MenuButton.TabIndex = 8;
            MenuButton.TabStop = false;
            MenuButton.Click += MenuButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 110);
            button1.Name = "button1";
            button1.Size = new Size(160, 58);
            button1.TabIndex = 7;
            button1.Text = "  Home";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.White;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnUsers.ForeColor = Color.Black;
            btnUsers.Image = (Image)resources.GetObject("btnUsers.Image");
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 175);
            btnUsers.Margin = new Padding(3, 4, 3, 4);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(160, 58);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Gestion    Utilisateur";
            btnUsers.TextAlign = ContentAlignment.MiddleRight;
            btnUsers.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnClients
            // 
            btnClients.BackColor = Color.White;
            btnClients.Cursor = Cursors.Hand;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnClients.Image = GestionFacture.Properties.Resources.client;
            btnClients.ImageAlign = ContentAlignment.MiddleLeft;
            btnClients.Location = new Point(3, 241);
            btnClients.Margin = new Padding(3, 4, 3, 4);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(160, 58);
            btnClients.TabIndex = 1;
            btnClients.Text = " Gestion Client";
            btnClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClients.UseVisualStyleBackColor = false;
            btnClients.Click += btnClients_Click;
            // 
            // btnArticles
            // 
            btnArticles.BackColor = Color.White;
            btnArticles.Cursor = Cursors.Hand;
            btnArticles.FlatStyle = FlatStyle.Flat;
            btnArticles.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnArticles.Image = (Image)resources.GetObject("btnArticles.Image");
            btnArticles.ImageAlign = ContentAlignment.MiddleLeft;
            btnArticles.Location = new Point(3, 306);
            btnArticles.Margin = new Padding(3, 4, 3, 4);
            btnArticles.Name = "btnArticles";
            btnArticles.Size = new Size(160, 58);
            btnArticles.TabIndex = 2;
            btnArticles.Text = "  Gestion Article";
            btnArticles.TextAlign = ContentAlignment.MiddleRight;
            btnArticles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnArticles.UseVisualStyleBackColor = false;
            btnArticles.Click += btnArticles_Click;
            // 
            // btnFactures
            // 
            btnFactures.BackColor = Color.White;
            btnFactures.Cursor = Cursors.Hand;
            btnFactures.FlatStyle = FlatStyle.Flat;
            btnFactures.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnFactures.Image = (Image)resources.GetObject("btnFactures.Image");
            btnFactures.ImageAlign = ContentAlignment.MiddleLeft;
            btnFactures.Location = new Point(3, 372);
            btnFactures.Margin = new Padding(3, 4, 3, 4);
            btnFactures.Name = "btnFactures";
            btnFactures.Size = new Size(160, 58);
            btnFactures.TabIndex = 3;
            btnFactures.Text = "  Gestion   Facture";
            btnFactures.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFactures.UseVisualStyleBackColor = false;
            btnFactures.Click += btnFactures_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(3, 607);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 58);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.White;
            btnAbout.Cursor = Cursors.Hand;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.MiddleLeft;
            btnAbout.Location = new Point(3, 541);
            btnAbout.Margin = new Padding(3, 4, 3, 4);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(160, 58);
            btnAbout.TabIndex = 6;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.White;
            mainPanel.Controls.Add(label3);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(label2);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(57, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1482, 688);
            mainPanel.TabIndex = 1;
            mainPanel.Paint += mainPanel_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Castellar", 13.8F);
            label3.Location = new Point(28, 266);
            label3.Name = "label3";
            label3.Size = new Size(795, 27);
            label3.TabIndex = 2;
            label3.Text = "Gestion de Facturation - Simplifiez Vos Transactions!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Nova Cond", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(440, 30);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 0;
            label1.Text = "Gestion Facture \r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(5, 111);
            label2.Name = "label2";
            label2.Size = new Size(1385, 100);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // SideBarTimer
            // 
            SideBarTimer.Interval = 1;
            SideBarTimer.Tick += SideBarTimer_Tick;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1539, 688);
            Controls.Add(mainPanel);
            Controls.Add(sidePanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            Text = "Menu Principal";
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MenuButton).EndInit();
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }
        private Button button1;
        private Label label2;
        private Label label1;
        private Label label3;
        private PictureBox MenuButton;
        private Label label4;
        private System.Windows.Forms.Timer SideBarTimer;
        private Button btnSettings;
    }
}
