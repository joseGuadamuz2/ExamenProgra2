namespace prueba2_jose1
{
    partial class frmUpdateArticle
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
            btnUpdate = new Button();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblAmount = new Label();
            txtAmount = new TextBox();
            lblCategory = new Label();
            cbCategory = new ComboBox();
            lblStorage = new Label();
            cbStorage = new ComboBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(131, 217);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(71, 42);
            lblName.Name = "lblName";
            lblName.Size = new Size(54, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 39);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 2;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(82, 77);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(43, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Precio:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(131, 74);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(202, 23);
            txtPrice.TabIndex = 4;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(11, 106);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(114, 15);
            lblAmount.TabIndex = 5;
            lblAmount.Text = "Cantidad inventario:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(131, 103);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(202, 23);
            txtAmount.TabIndex = 6;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(64, 140);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(61, 15);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Categoría:";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Alimento", "Limpieza", "Hogar", "Mascotas", "Oficina" });
            cbCategory.Location = new Point(131, 137);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(202, 23);
            cbCategory.TabIndex = 8;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // lblStorage
            // 
            lblStorage.AutoSize = true;
            lblStorage.Location = new Point(75, 175);
            lblStorage.Name = "lblStorage";
            lblStorage.Size = new Size(50, 15);
            lblStorage.TabIndex = 9;
            lblStorage.Text = "Bodega:";
            // 
            // cbStorage
            // 
            cbStorage.FormattingEnabled = true;
            cbStorage.Location = new Point(131, 167);
            cbStorage.Name = "cbStorage";
            cbStorage.Size = new Size(202, 23);
            cbStorage.TabIndex = 10;
            cbStorage.SelectedIndexChanged += cbStorage_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(232, 217);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 11;
            btnClose.Text = "Salir";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnCancel_Click;
            // 
            // frmUpdateArticle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 302);
            Controls.Add(btnClose);
            Controls.Add(cbStorage);
            Controls.Add(lblStorage);
            Controls.Add(cbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtAmount);
            Controls.Add(lblAmount);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Controls.Add(btnUpdate);
            Name = "frmUpdateArticle";
            Text = "ActualizarArticulo";
            Load += frmUpdateArticle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private Label lblName;
        private TextBox txtName;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblAmount;
        private TextBox txtAmount;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Label lblStorage;
        private ComboBox cbStorage;
        private Button btnClose;
    }
}