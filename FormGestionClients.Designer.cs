namespace GestionDeFacturation
{
    partial class FormGestionClients
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvClients;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblTaxNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;

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
            dgvClients = new DataGridView();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            btnAddClient = new Button();
            btnEditClient = new Button();
            btnDeleteClient = new Button();
            lblFullName = new Label();
            lblTaxNumber = new Label();
            lblAddress = new Label();
            lblPhoneNumber = new Label();
            textBoxAlphanumerique1 = new GestionDeFacturation.Controls.TextBoxAlphanumerique();
            textBoxPhone1 = new GestionDeFacturation.Controls.TextBoxPhone();
            label1 = new Label();
            txtSearchName = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // dgvClients
            // 
            dgvClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 13);
            dgvClients.Margin = new Padding(3, 4, 3, 4);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.Height = 24;
            dgvClients.Size = new Size(1206, 264);
            dgvClients.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(130, 378);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(130, 478);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 4;
            // 
            // btnAddClient
            // 
            btnAddClient.BackColor = Color.ForestGreen;
            btnAddClient.Location = new Point(501, 390);
            btnAddClient.Margin = new Padding(3, 4, 3, 4);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(100, 38);
            btnAddClient.TabIndex = 6;
            btnAddClient.Text = "Add";
            btnAddClient.UseVisualStyleBackColor = false;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnEditClient
            // 
            btnEditClient.BackColor = SystemColors.ActiveCaption;
            btnEditClient.Location = new Point(501, 440);
            btnEditClient.Margin = new Padding(3, 4, 3, 4);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new Size(100, 38);
            btnEditClient.TabIndex = 7;
            btnEditClient.Text = "Edit";
            btnEditClient.UseVisualStyleBackColor = false;
            btnEditClient.Click += btnEditClient_Click;
            // 
            // btnDeleteClient
            // 
            btnDeleteClient.BackColor = Color.IndianRed;
            btnDeleteClient.Location = new Point(501, 490);
            btnDeleteClient.Margin = new Padding(3, 4, 3, 4);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new Size(100, 38);
            btnDeleteClient.TabIndex = 8;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.UseVisualStyleBackColor = false;
            btnDeleteClient.Click += btnDeleteClient_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 378);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 10;
            lblFullName.Text = "Full Name";
            // 
            // lblTaxNumber
            // 
            lblTaxNumber.AutoSize = true;
            lblTaxNumber.Location = new Point(12, 428);
            lblTaxNumber.Name = "lblTaxNumber";
            lblTaxNumber.Size = new Size(88, 20);
            lblTaxNumber.TabIndex = 11;
            lblTaxNumber.Text = "Tax Number";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(12, 478);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(62, 20);
            lblAddress.TabIndex = 12;
            lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(12, 528);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 20);
            lblPhoneNumber.TabIndex = 13;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // textBoxAlphanumerique1
            // 
            textBoxAlphanumerique1.Location = new Point(130, 428);
            textBoxAlphanumerique1.Name = "textBoxAlphanumerique1";
            textBoxAlphanumerique1.Size = new Size(125, 27);
            textBoxAlphanumerique1.TabIndex = 14;
            // 
            // textBoxPhone1
            // 
            textBoxPhone1.Location = new Point(130, 528);
            textBoxPhone1.Name = "textBoxPhone1";
            textBoxPhone1.Size = new Size(125, 27);
            textBoxPhone1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(886, 290);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 19;
            label1.Text = "Search By Name :";
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(1016, 287);
            txtSearchName.Margin = new Padding(3, 4, 3, 4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(200, 27);
            txtSearchName.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(638, 449);
            label3.Name = "label3";
            label3.Size = new Size(372, 20);
            label3.TabIndex = 22;
            label3.Text = "* Double-click on a row to edit the client's information.";
            // 
            // FormGestionClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 641);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSearchName);
            Controls.Add(textBoxPhone1);
            Controls.Add(textBoxAlphanumerique1);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblAddress);
            Controls.Add(lblTaxNumber);
            Controls.Add(lblFullName);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(dgvClients);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionClients";
            Text = "Gestion des Clients";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Controls.TextBoxAlphanumerique textBoxAlphanumerique1;
        private Controls.TextBoxPhone textBoxPhone1;
        private Label label1;
        private TextBox txtSearchName;
        private Label label3;
    }
}
