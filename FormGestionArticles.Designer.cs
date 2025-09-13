namespace GestionDeFacturation
{
    partial class FormGestionArticles
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.TextBox txtArticleName;
        private System.Windows.Forms.NumericUpDown numStockQty;
        private System.Windows.Forms.NumericUpDown numTVA;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnEditArticle;
        private System.Windows.Forms.Button btnDeleteArticle;
        private System.Windows.Forms.Label lblArticleName;
        private System.Windows.Forms.Label lblStockQty;
        private System.Windows.Forms.Label lblPUHTVA;
        private System.Windows.Forms.Label lblTVA;


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
            dgvArticles = new DataGridView();
            txtArticleName = new TextBox();
            numStockQty = new NumericUpDown();
            numTVA = new NumericUpDown();
            btnAddArticle = new Button();
            btnEditArticle = new Button();
            btnDeleteArticle = new Button();
            lblArticleName = new Label();
            lblStockQty = new Label();
            lblPUHTVA = new Label();
            lblTVA = new Label();
            textBoxDecimalPUHTVA = new GestionDeFacturation.Controls.TextBoxDecimal();
            txtSearchName = new TextBox();
            label1 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArticles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTVA).BeginInit();
            SuspendLayout();
            // 
            // dgvArticles
            // 
            dgvArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArticles.Location = new Point(12, 15);
            dgvArticles.Margin = new Padding(3, 4, 3, 4);
            dgvArticles.Name = "dgvArticles";
            dgvArticles.RowHeadersWidth = 51;
            dgvArticles.RowTemplate.Height = 24;
            dgvArticles.Size = new Size(1205, 279);
            dgvArticles.TabIndex = 0;
            // 
            // txtArticleName
            // 
            txtArticleName.Location = new Point(144, 389);
            txtArticleName.Margin = new Padding(3, 4, 3, 4);
            txtArticleName.Name = "txtArticleName";
            txtArticleName.Size = new Size(200, 27);
            txtArticleName.TabIndex = 1;
            // 
            // numStockQty
            // 
            numStockQty.Location = new Point(144, 439);
            numStockQty.Margin = new Padding(3, 4, 3, 4);
            numStockQty.Name = "numStockQty";
            numStockQty.Size = new Size(63, 27);
            numStockQty.TabIndex = 2;
            // 
            // numTVA
            // 
            numTVA.DecimalPlaces = 2;
            numTVA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numTVA.Location = new Point(144, 539);
            numTVA.Margin = new Padding(3, 4, 3, 4);
            numTVA.Name = "numTVA";
            numTVA.Size = new Size(74, 27);
            numTVA.TabIndex = 4;
            numTVA.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnAddArticle
            // 
            btnAddArticle.BackColor = Color.ForestGreen;
            btnAddArticle.Location = new Point(479, 410);
            btnAddArticle.Margin = new Padding(3, 4, 3, 4);
            btnAddArticle.Name = "btnAddArticle";
            btnAddArticle.Size = new Size(100, 38);
            btnAddArticle.TabIndex = 5;
            btnAddArticle.Text = "Add";
            btnAddArticle.UseVisualStyleBackColor = false;
            btnAddArticle.Click += btnAddArticle_Click;
            // 
            // btnEditArticle
            // 
            btnEditArticle.BackColor = SystemColors.ActiveCaption;
            btnEditArticle.Location = new Point(479, 460);
            btnEditArticle.Margin = new Padding(3, 4, 3, 4);
            btnEditArticle.Name = "btnEditArticle";
            btnEditArticle.Size = new Size(100, 38);
            btnEditArticle.TabIndex = 6;
            btnEditArticle.Text = "Edit";
            btnEditArticle.UseVisualStyleBackColor = false;
            btnEditArticle.Click += btnEditArticle_Click;
            // 
            // btnDeleteArticle
            // 
            btnDeleteArticle.BackColor = Color.IndianRed;
            btnDeleteArticle.Location = new Point(479, 510);
            btnDeleteArticle.Margin = new Padding(3, 4, 3, 4);
            btnDeleteArticle.Name = "btnDeleteArticle";
            btnDeleteArticle.Size = new Size(100, 38);
            btnDeleteArticle.TabIndex = 7;
            btnDeleteArticle.Text = "Delete";
            btnDeleteArticle.UseVisualStyleBackColor = false;
            btnDeleteArticle.Click += btnDeleteArticle_Click;
            // 
            // lblArticleName
            // 
            lblArticleName.AutoSize = true;
            lblArticleName.Location = new Point(31, 389);
            lblArticleName.Name = "lblArticleName";
            lblArticleName.Size = new Size(96, 20);
            lblArticleName.TabIndex = 10;
            lblArticleName.Text = "Article Name";
            // 
            // lblStockQty
            // 
            lblStockQty.AutoSize = true;
            lblStockQty.Location = new Point(31, 439);
            lblStockQty.Name = "lblStockQty";
            lblStockQty.Size = new Size(105, 20);
            lblStockQty.TabIndex = 11;
            lblStockQty.Text = "Stock Quantity";
            // 
            // lblPUHTVA
            // 
            lblPUHTVA.AutoSize = true;
            lblPUHTVA.Location = new Point(31, 489);
            lblPUHTVA.Name = "lblPUHTVA";
            lblPUHTVA.Size = new Size(68, 20);
            lblPUHTVA.TabIndex = 12;
            lblPUHTVA.Text = "PU HTVA";
            // 
            // lblTVA
            // 
            lblTVA.AutoSize = true;
            lblTVA.Location = new Point(31, 539);
            lblTVA.Name = "lblTVA";
            lblTVA.Size = new Size(64, 20);
            lblTVA.TabIndex = 13;
            lblTVA.Text = "TVA(%) :";
            // 
            // textBoxDecimalPUHTVA
            // 
            textBoxDecimalPUHTVA.Location = new Point(144, 489);
            textBoxDecimalPUHTVA.Name = "textBoxDecimalPUHTVA";
            textBoxDecimalPUHTVA.Size = new Size(125, 27);
            textBoxDecimalPUHTVA.TabIndex = 3;
            // 
            // txtSearchName
            // 
            txtSearchName.Location = new Point(1039, 305);
            txtSearchName.Margin = new Padding(3, 4, 3, 4);
            txtSearchName.Name = "txtSearchName";
            txtSearchName.Size = new Size(179, 27);
            txtSearchName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(909, 308);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 15;
            label1.Text = "Search By Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(624, 469);
            label3.Name = "label3";
            label3.Size = new Size(379, 20);
            label3.TabIndex = 23;
            label3.Text = "* Double-click on a row to edit the product information.";
            // 
            // FormGestionArticles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 646);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtSearchName);
            Controls.Add(textBoxDecimalPUHTVA);
            Controls.Add(lblTVA);
            Controls.Add(lblPUHTVA);
            Controls.Add(lblStockQty);
            Controls.Add(lblArticleName);
            Controls.Add(btnDeleteArticle);
            Controls.Add(btnEditArticle);
            Controls.Add(btnAddArticle);
            Controls.Add(numTVA);
            Controls.Add(numStockQty);
            Controls.Add(txtArticleName);
            Controls.Add(dgvArticles);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionArticles";
            Text = "Gestion des Articles";
            ((System.ComponentModel.ISupportInitialize)dgvArticles).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTVA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Controls.TextBoxDecimal textBoxDecimalPUHTVA;
        private TextBox txtSearchName;
        private Label label1;
        private Label label3;
    }
}
