namespace GestionDeFacturation
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox cmbLanguage;
        private Button btnSave;

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
            cmbLanguage = new ComboBox();
            btnSave = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cmbLanguage
            // 
            cmbLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLanguage.FormattingEnabled = true;
            cmbLanguage.Items.AddRange(new object[] { "English", "French" });
            cmbLanguage.Location = new Point(457, 133);
            cmbLanguage.Name = "cmbLanguage";
            cmbLanguage.Size = new Size(200, 28);
            cmbLanguage.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(457, 192);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 30);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 134);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Language :";
            // 
            // FormSettings
            // 
            ClientSize = new Size(1048, 454);
            Controls.Add(label1);
            Controls.Add(cmbLanguage);
            Controls.Add(btnSave);
            Name = "FormSettings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
