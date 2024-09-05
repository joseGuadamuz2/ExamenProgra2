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
            cbCateory = new ComboBox();
            lblStore = new Label();
            cbStore = new ComboBox();
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
            lblAmount.Click += label1_Click;
            // 
            // lblCategory
            // 
            resources.ApplyResources(lblCategory, "lblCategory");
            lblCategory.Name = "lblCategory";
            // 
            // cbCateory
            // 
            resources.ApplyResources(cbCateory, "cbCateory");
            cbCateory.FormattingEnabled = true;
            cbCateory.Items.AddRange(new object[] { resources.GetString("cbCateory.Items"), resources.GetString("cbCateory.Items1"), resources.GetString("cbCateory.Items2"), resources.GetString("cbCateory.Items3"), resources.GetString("cbCateory.Items4") });
            cbCateory.Name = "cbCateory";
            cbCateory.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblStore
            // 
            resources.ApplyResources(lblStore, "lblStore");
            lblStore.Name = "lblStore";
            // 
            // cbStore
            // 
            resources.ApplyResources(cbStore, "cbStore");
            cbStore.FormattingEnabled = true;
            cbStore.Name = "cbStore";
            cbStore.SelectedIndexChanged += bodegaComboBox_SelectedIndexChanged;
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
            btnSave.Click += guardarBtn_Click;
            // 
            // btnCancel
            // 
            resources.ApplyResources(btnCancel, "btnCancel");
            btnCancel.Name = "btnCancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += cancelarGuardado_Click;
            // 
            // agregarArticuloForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtMaxAmount);
            Controls.Add(lblMaxAmount);
            Controls.Add(txtMinAmount);
            Controls.Add(lblMinAmount);
            Controls.Add(cbStore);
            Controls.Add(lblStore);
            Controls.Add(cbCateory);
            Controls.Add(lblCategory);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "agregarArticuloForm";
            Load += agregarArticuloForm_Load;
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
        private ComboBox cbCateory;
        private Label lblStore;
        private ComboBox cbStore;
        private Label lblMinAmount;
        private TextBox txtMinAmount;
        private Label lblMaxAmount;
        private TextBox txtMaxAmount;
        private Button btnSave;
        private Button btnCancel;
    }
}