namespace GestionDeFacturation
{
    partial class FormGestionFactures
    {
        private System.ComponentModel.IContainer components = null;

        // Header Section
        private Label lblNumeroFacture;
        private TextBox txtNumeroFacture;
        private Label lblDateFacture;
        private DateTimePicker dtpDateFacture;
        private ComboBox cmbArticle;
        private Controls.TextBoxDecimal txtRemise;

        // Data Grid
        private DataGridView dgvFactureDetails;

        // Totals Section
        private Label lblTotalHT;
        private Label lblTotalHTValue;
        private Label lblTVA;
        private Label lblTVAValue;
        private Label lblTimbre;
        private Label lblTimbreValue;
        private Label lblTotalTTC;
        private Label lblTotalTTCValue;

        // Buttons
        private Button btnAjouterArticle;
        private Button btnEnregistrer;
        private Button btnImprimer;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudQuantite;
        private NumericUpDown nudTVA; // Add this line

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
            lblNumeroFacture = new Label();
            txtNumeroFacture = new TextBox();
            lblDateFacture = new Label();
            dtpDateFacture = new DateTimePicker();
            cmbArticle = new ComboBox();
            dgvFactureDetails = new DataGridView();
            colCodeArticle = new DataGridViewTextBoxColumn();
            colArticle = new DataGridViewTextBoxColumn();
            colPrix = new DataGridViewTextBoxColumn();
            colQuantite = new DataGridViewTextBoxColumn();
            colRemise = new DataGridViewTextBoxColumn();
            colTotal = new DataGridViewTextBoxColumn();
            lblTotalHT = new Label();
            lblTotalHTValue = new Label();
            lblTVA = new Label();
            lblTVAValue = new Label();
            lblTimbre = new Label();
            lblTimbreValue = new Label();
            lblTotalTTC = new Label();
            lblTotalTTCValue = new Label();
            btnAjouterArticle = new Button();
            btnEnregistrer = new Button();
            btnImprimer = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nudQuantite = new NumericUpDown();
            txtRemise = new GestionDeFacturation.Controls.TextBoxDecimal();
            label7 = new Label();
            txtStockQuantity = new TextBox();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtTaxNumber = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbClient = new ComboBox();
            txtClientCode = new TextBox();
            lblClientAddress = new Label();
            txtClientAddress = new TextBox();
            txtClientPhone = new TextBox();
            groupBox2 = new GroupBox();
            nudTVA = new NumericUpDown();
            lblTVAInput = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFactureDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTVA).BeginInit();
            SuspendLayout();
            // 
            // lblNumeroFacture
            // 
            lblNumeroFacture.AutoSize = true;
            lblNumeroFacture.Location = new Point(273, 23);
            lblNumeroFacture.Name = "lblNumeroFacture";
            lblNumeroFacture.Size = new Size(114, 20);
            lblNumeroFacture.TabIndex = 0;
            lblNumeroFacture.Text = "Numéro Facture";
            // 
            // txtNumeroFacture
            // 
            txtNumeroFacture.Location = new Point(403, 20);
            txtNumeroFacture.Name = "txtNumeroFacture";
            txtNumeroFacture.ReadOnly = true;
            txtNumeroFacture.Size = new Size(123, 27);
            txtNumeroFacture.TabIndex = 1;
            // 
            // lblDateFacture
            // 
            lblDateFacture.AutoSize = true;
            lblDateFacture.Location = new Point(556, 23);
            lblDateFacture.Name = "lblDateFacture";
            lblDateFacture.Size = new Size(92, 20);
            lblDateFacture.TabIndex = 2;
            lblDateFacture.Text = "Date Facture";
            // 
            // dtpDateFacture
            // 
            dtpDateFacture.Format = DateTimePickerFormat.Short;
            dtpDateFacture.Location = new Point(686, 20);
            dtpDateFacture.Name = "dtpDateFacture";
            dtpDateFacture.Size = new Size(200, 27);
            dtpDateFacture.TabIndex = 3;
            // 
            // cmbArticle
            // 
            cmbArticle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbArticle.FormattingEnabled = true;
            cmbArticle.Location = new Point(179, 26);
            cmbArticle.Name = "cmbArticle";
            cmbArticle.Size = new Size(200, 28);
            cmbArticle.TabIndex = 13;
            cmbArticle.SelectedIndexChanged += cmbArticle_SelectedIndexChanged;
            // 
            // dgvFactureDetails
            // 
            dgvFactureDetails.AllowUserToAddRows = false;
            dgvFactureDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFactureDetails.Columns.AddRange(new DataGridViewColumn[] { colCodeArticle, colArticle, colPrix, colQuantite, colRemise, colTotal });
            dgvFactureDetails.Location = new Point(12, 386);
            dgvFactureDetails.Name = "dgvFactureDetails";
            dgvFactureDetails.ReadOnly = true;
            dgvFactureDetails.RowHeadersWidth = 51;
            dgvFactureDetails.Size = new Size(806, 233);
            dgvFactureDetails.TabIndex = 22;
            // 
            // colCodeArticle
            // 
            colCodeArticle.HeaderText = "CodeArticle";
            colCodeArticle.MinimumWidth = 6;
            colCodeArticle.Name = "colCodeArticle";
            colCodeArticle.ReadOnly = true;
            colCodeArticle.Width = 125;
            // 
            // colArticle
            // 
            colArticle.HeaderText = "Article";
            colArticle.MinimumWidth = 6;
            colArticle.Name = "colArticle";
            colArticle.ReadOnly = true;
            colArticle.Width = 125;
            // 
            // colPrix
            // 
            colPrix.HeaderText = "Prix";
            colPrix.MinimumWidth = 6;
            colPrix.Name = "colPrix";
            colPrix.ReadOnly = true;
            colPrix.Width = 125;
            // 
            // colQuantite
            // 
            colQuantite.HeaderText = "Quantité";
            colQuantite.MinimumWidth = 6;
            colQuantite.Name = "colQuantite";
            colQuantite.ReadOnly = true;
            colQuantite.Width = 125;
            // 
            // colRemise
            // 
            colRemise.HeaderText = "Remise";
            colRemise.MinimumWidth = 6;
            colRemise.Name = "colRemise";
            colRemise.ReadOnly = true;
            colRemise.Width = 125;
            // 
            // colTotal
            // 
            colTotal.HeaderText = "Total";
            colTotal.MinimumWidth = 6;
            colTotal.Name = "colTotal";
            colTotal.ReadOnly = true;
            colTotal.Width = 125;
            // 
            // lblTotalHT
            // 
            lblTotalHT.AutoSize = true;
            lblTotalHT.Location = new Point(868, 388);
            lblTotalHT.Name = "lblTotalHT";
            lblTotalHT.Size = new Size(68, 20);
            lblTotalHT.TabIndex = 23;
            lblTotalHT.Text = "Total HT:";
            // 
            // lblTotalHTValue
            // 
            lblTotalHTValue.AutoSize = true;
            lblTotalHTValue.Location = new Point(998, 388);
            lblTotalHTValue.Name = "lblTotalHTValue";
            lblTotalHTValue.Size = new Size(0, 20);
            lblTotalHTValue.TabIndex = 24;
            // 
            // lblTVA
            // 
            lblTVA.AutoSize = true;
            lblTVA.Location = new Point(868, 418);
            lblTVA.Name = "lblTVA";
            lblTVA.Size = new Size(64, 20);
            lblTVA.TabIndex = 25;
            lblTVA.Text = "TVA (%):";
            // 
            // lblTVAValue
            // 
            lblTVAValue.AutoSize = true;
            lblTVAValue.Location = new Point(998, 418);
            lblTVAValue.Name = "lblTVAValue";
            lblTVAValue.Size = new Size(0, 20);
            lblTVAValue.TabIndex = 26;
            // 
            // lblTimbre
            // 
            lblTimbre.AutoSize = true;
            lblTimbre.Location = new Point(868, 448);
            lblTimbre.Name = "lblTimbre";
            lblTimbre.Size = new Size(97, 20);
            lblTimbre.TabIndex = 27;
            lblTimbre.Text = "Droit Timbre:";
            // 
            // lblTimbreValue
            // 
            lblTimbreValue.AutoSize = true;
            lblTimbreValue.Location = new Point(998, 448);
            lblTimbreValue.Name = "lblTimbreValue";
            lblTimbreValue.Size = new Size(0, 20);
            lblTimbreValue.TabIndex = 28;
            // 
            // lblTotalTTC
            // 
            lblTotalTTC.AutoSize = true;
            lblTotalTTC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalTTC.Location = new Point(868, 478);
            lblTotalTTC.Name = "lblTotalTTC";
            lblTotalTTC.Size = new Size(78, 20);
            lblTotalTTC.TabIndex = 29;
            lblTotalTTC.Text = "Total TTC:";
            // 
            // lblTotalTTCValue
            // 
            lblTotalTTCValue.AutoSize = true;
            lblTotalTTCValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalTTCValue.Location = new Point(998, 478);
            lblTotalTTCValue.Name = "lblTotalTTCValue";
            lblTotalTTCValue.Size = new Size(0, 20);
            lblTotalTTCValue.TabIndex = 30;
            // 
            // btnAjouterArticle
            // 
            btnAjouterArticle.Location = new Point(353, 295);
            btnAjouterArticle.Name = "btnAjouterArticle";
            btnAjouterArticle.Size = new Size(110, 34);
            btnAjouterArticle.TabIndex = 31;
            btnAjouterArticle.Text = "Ajouter Article";
            btnAjouterArticle.Click += btnAjouterArticle_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.BackColor = SystemColors.ActiveCaption;
            btnEnregistrer.Location = new Point(998, 577);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(131, 42);
            btnEnregistrer.TabIndex = 32;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = false;
            btnEnregistrer.Click += btnEnregistrer_Click;
            // 
            // btnImprimer
            // 
            btnImprimer.BackColor = Color.ForestGreen;
            btnImprimer.Location = new Point(1135, 577);
            btnImprimer.Name = "btnImprimer";
            btnImprimer.Size = new Size(131, 42);
            btnImprimer.TabIndex = 33;
            btnImprimer.Text = "Imprimer";
            btnImprimer.UseVisualStyleBackColor = false;
            btnImprimer.Click += btnImprimer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 29);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 36;
            label3.Text = "Article Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 294);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 37;
            label4.Text = "Remise (%) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 252);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 38;
            label5.Text = "Quantite";
            // 
            // nudQuantite
            // 
            nudQuantite.Location = new Point(145, 250);
            nudQuantite.Name = "nudQuantite";
            nudQuantite.Size = new Size(83, 27);
            nudQuantite.TabIndex = 39;
            // 
            // txtRemise
            // 
            txtRemise.Location = new Point(145, 294);
            txtRemise.Name = "txtRemise";
            txtRemise.Size = new Size(100, 27);
            txtRemise.TabIndex = 0;
            txtRemise.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 75);
            label7.Name = "label7";
            label7.Size = new Size(111, 20);
            label7.TabIndex = 42;
            label7.Text = "Stock quantite :";
            // 
            // txtStockQuantity
            // 
            txtStockQuantity.Location = new Point(179, 72);
            txtStockQuantity.Name = "txtStockQuantity";
            txtStockQuantity.ReadOnly = true;
            txtStockQuantity.Size = new Size(60, 27);
            txtStockQuantity.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTaxNumber);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbClient);
            groupBox1.Controls.Add(txtClientCode);
            groupBox1.Controls.Add(lblClientAddress);
            groupBox1.Controls.Add(txtClientAddress);
            groupBox1.Controls.Add(txtClientPhone);
            groupBox1.Location = new Point(549, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(659, 259);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Client";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 178);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 71;
            label8.Text = "Tax number :";
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(175, 178);
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.ReadOnly = true;
            txtTaxNumber.Size = new Size(200, 27);
            txtTaxNumber.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(404, 58);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 69;
            label6.Text = "Code Client :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 138);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 68;
            label1.Text = "Telephone :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 57);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 67;
            label2.Text = "Client Name :";
            // 
            // cmbClient
            // 
            cmbClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(175, 54);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(200, 28);
            cmbClient.TabIndex = 62;
            cmbClient.SelectedIndexChanged += cmbClient_SelectedIndexChanged;
            // 
            // txtClientCode
            // 
            txtClientCode.Location = new Point(514, 55);
            txtClientCode.Name = "txtClientCode";
            txtClientCode.Size = new Size(100, 27);
            txtClientCode.TabIndex = 63;
            // 
            // lblClientAddress
            // 
            lblClientAddress.AutoSize = true;
            lblClientAddress.Location = new Point(45, 101);
            lblClientAddress.Name = "lblClientAddress";
            lblClientAddress.Size = new Size(68, 20);
            lblClientAddress.TabIndex = 64;
            lblClientAddress.Text = "Adresse :";
            // 
            // txtClientAddress
            // 
            txtClientAddress.Location = new Point(175, 98);
            txtClientAddress.Name = "txtClientAddress";
            txtClientAddress.ReadOnly = true;
            txtClientAddress.Size = new Size(200, 27);
            txtClientAddress.TabIndex = 65;
            // 
            // txtClientPhone
            // 
            txtClientPhone.Location = new Point(175, 135);
            txtClientPhone.Name = "txtClientPhone";
            txtClientPhone.ReadOnly = true;
            txtClientPhone.Size = new Size(200, 27);
            txtClientPhone.TabIndex = 66;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbArticle);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtStockQuantity);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(25, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 125);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "Article";
            // 
            // nudTVA
            // 
            nudTVA.DecimalPlaces = 2;
            nudTVA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudTVA.Location = new Point(145, 342);
            nudTVA.Name = "nudTVA";
            nudTVA.Size = new Size(100, 27);
            nudTVA.TabIndex = 0;
            nudTVA.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblTVAInput
            // 
            lblTVAInput.AutoSize = true;
            lblTVAInput.Location = new Point(24, 344);
            lblTVAInput.Name = "lblTVAInput";
            lblTVAInput.Size = new Size(98, 20);
            lblTVAInput.TabIndex = 1;
            lblTVAInput.Text = "TVA Rate (%):";
            // 
            // FormGestionFactures
            // 
            ClientSize = new Size(1337, 641);
            Controls.Add(nudTVA);
            Controls.Add(lblTVAInput);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nudQuantite);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblNumeroFacture);
            Controls.Add(txtNumeroFacture);
            Controls.Add(lblDateFacture);
            Controls.Add(dtpDateFacture);
            Controls.Add(txtRemise);
            Controls.Add(btnAjouterArticle);
            Controls.Add(dgvFactureDetails);
            Controls.Add(lblTotalHT);
            Controls.Add(lblTotalHTValue);
            Controls.Add(lblTVA);
            Controls.Add(lblTVAValue);
            Controls.Add(lblTimbre);
            Controls.Add(lblTimbreValue);
            Controls.Add(lblTotalTTC);
            Controls.Add(lblTotalTTCValue);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnImprimer);
            Name = "FormGestionFactures";
            Text = "Gestion de Factures";
            ((System.ComponentModel.ISupportInitialize)dgvFactureDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantite).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTVA).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private DataGridViewTextBoxColumn colCodeArticle;
        private DataGridViewTextBoxColumn colArticle;
        private DataGridViewTextBoxColumn colPrix;
        private DataGridViewTextBoxColumn colQuantite;
        private DataGridViewTextBoxColumn colRemise;
        private DataGridViewTextBoxColumn colTotal;
        private Label label7;
        private TextBox txtStockQuantity;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label8;
        private TextBox txtTaxNumber;
        private Label label6;
        private Label label1;
        private Label label2;
        private ComboBox cmbClient;
        private TextBox txtClientCode;
        private Label lblClientAddress;
        private TextBox txtClientAddress;
        private TextBox txtClientPhone;
        private Label lblTVAInput;
    }
}

