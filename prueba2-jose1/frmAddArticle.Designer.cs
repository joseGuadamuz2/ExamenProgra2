namespace prueba2_jose1
{
    partial class frmAddArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddArticle));
            lblName = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            lblPrice = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblStore = new Label();
            cbStorage = new ComboBox();
            lblMinAmount = new Label();
            txtMinAmount = new TextBox();
            lblMaxAmount = new Label();
            txtMaxAmount = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // txtPrice
            // 
            resources.ApplyResources(txtPrice, "txtPrice");
            txtPrice.Name = "txtPrice";
            txtPrice.KeyPress += txtPrice_KeyPress;
            // 
            // lblPrice
            // 
            resources.ApplyResources(lblPrice, "lblPrice");
            lblPrice.Name = "lblPrice";
            // 
            // txtAmount
            // 
            resources.ApplyResources(txtAmount, "txtAmount");
            txtAmount.Name = "txtAmount";
            // 
            // lblAmount
            // 
            resources.ApplyResources(lblAmount, "lblAmount");
            lblAmount.Name = "lblAmount";
            // 
            // lblCategory
            // 
            resources.ApplyResources(lblCategory, "lblCategory");
            lblCategory.Name = "lblCategory";
            // 
            // cbCategory
            // 
            resources.ApplyResources(cbCategory, "cbCategory");
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { resources.GetString("cbCategory.Items"), resources.GetString("cbCategory.Items1"), resources.GetString("cbCategory.Items2"), resources.GetString("cbCategory.Items3"), resources.GetString("cbCategory.Items4") });
            cbCategory.Name = "cbCategory";
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblStore
            // 
            resources.ApplyResources(lblStore, "lblStore");
            lblStore.Name = "lblStore";
            // 
            // cbStorage
            // 
            resources.ApplyResources(cbStorage, "cbStorage");
            cbStorage.FormattingEnabled = true;
            cbStorage.Name = "cbStorage";
            cbStorage.SelectedIndexChanged += cbStorage_SelectedIndexChanged;
            // 
            // lblMinAmount
            // 
            resources.ApplyResources(lblMinAmount, "lblMinAmount");
            lblMinAmount.Name = "lblMinAmount";
            // 
            // txtMinAmount
            // 
            resources.ApplyResources(txtMinAmount, "txtMinAmount");
            txtMinAmount.Name = "txtMinAmount";
            // 
            // lblMaxAmount
            // 
            resources.ApplyResources(lblMaxAmount, "lblMaxAmount");
            lblMaxAmount.Name = "lblMaxAmount";
            // 
            // txtMaxAmount
            // 
            resources.ApplyResources(txtMaxAmount, "txtMaxAmount");
            txtMaxAmount.Name = "txtMaxAmount";
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddArticle
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMaxAmount);
            Controls.Add(lblMaxAmount);
            Controls.Add(txtMinAmount);
            Controls.Add(lblMinAmount);
            Controls.Add(cbStorage);
            Controls.Add(lblStore);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "frmAddArticle";
            Load += frmAddArticle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private TextBox txtPrice;
        private Label lblPrice;
        private TextBox txtAmount;
        private Label lblAmount;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblStore;
        private ComboBox cbStorage;
        private Label lblMinAmount;
        private TextBox txtMinAmount;
        private Label lblMaxAmount;
        private TextBox txtMaxAmount;
        private Button btnSave;
        private Button btnCancel;
    }
}