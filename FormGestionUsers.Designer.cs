namespace GestionDeFacturation
{
    partial class FormGestionUsers
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserType;

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
            dgvUsers = new DataGridView();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            cmbUserType = new ComboBox();
            btnAddUser = new Button();
            btnEditUser = new Button();
            btnDeleteUser = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblUserType = new Label();
            label1 = new Label();
            txtSearchName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 15);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.Height = 24;
            dgvUsers.Size = new Size(1199, 297);
            dgvUsers.TabIndex = 0;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(102, 420);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 470);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 2;
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "Admin", "User" });
            cmbUserType.Location = new Point(102, 520);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(200, 28);
            cmbUserType.TabIndex = 3;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.ForestGreen;
            btnAddUser.Location = new Point(430, 420);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 38);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Add";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = SystemColors.ActiveCaption;
            btnEditUser.Location = new Point(430, 470);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(100, 38);
            btnEditUser.TabIndex = 5;
            btnEditUser.Text = "Edit";
            btnEditUser.UseVisualStyleBackColor = false;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.IndianRed;
            btnDeleteUser.Location = new Point(430, 520);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(100, 38);
            btnDeleteUser.TabIndex = 6;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(14, 420);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 7;
            lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(14, 470);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Location = new Point(14, 520);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(73, 20);
            lblUserType.TabIndex = 9;
            lblUserType.Text = "User Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(884, 325);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 21;
            label1.Text = "Search By Name :";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(1014, 322);
            txtSearchName.Margin = new Padding(3, 4, 3, 4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 27);
            txtSearchName.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(594, 479);
            label3.Name = "label3";
            label3.Size = new Size(354, 20);
            label3.TabIndex = 25;
            label3.Text = "* Double-click on a row to edit the user information.";
            // 
            // FormGestionUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 641);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSearchName);
            Controls.Add(lblUserType);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnEditUser);
            Controls.Add(btnAddUser);
            Controls.Add(cmbUserType);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(dgvUsers);
            Name = "FormGestionUsers";
            Text = "Gestion des Utilisateurs";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private TextBox txtSearchName;
        private Label label3;
    }
}
