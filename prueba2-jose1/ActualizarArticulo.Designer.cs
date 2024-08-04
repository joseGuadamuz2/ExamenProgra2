namespace prueba2_jose1
{
    partial class ActualizarArticulo
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
            actualizarBtn = new Button();
            actuNombreLabel = new Label();
            actualizarNomInput = new TextBox();
            actuPrecioLabel = new Label();
            actualizarPrecioInput = new TextBox();
            actuCantInventarioLabel = new Label();
            actualizarCantidadInventarioInput = new TextBox();
            actuCategoLabel = new Label();
            actuCategoComboBox = new ComboBox();
            actuBodeLabel = new Label();
            actuBodegaComboBox = new ComboBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // actualizarBtn
            // 
            actualizarBtn.Location = new Point(232, 208);
            actualizarBtn.Name = "actualizarBtn";
            actualizarBtn.Size = new Size(75, 23);
            actualizarBtn.TabIndex = 0;
            actualizarBtn.Text = "Actualizar";
            actualizarBtn.UseVisualStyleBackColor = true;
            actualizarBtn.Click += actualizarBtn_Click;
            // 
            // actuNombreLabel
            // 
            actuNombreLabel.AutoSize = true;
            actuNombreLabel.Location = new Point(172, 33);
            actuNombreLabel.Name = "actuNombreLabel";
            actuNombreLabel.Size = new Size(54, 15);
            actuNombreLabel.TabIndex = 1;
            actuNombreLabel.Text = "Nombre:";
            // 
            // actualizarNomInput
            // 
            actualizarNomInput.Location = new Point(232, 30);
            actualizarNomInput.Name = "actualizarNomInput";
            actualizarNomInput.Size = new Size(202, 23);
            actualizarNomInput.TabIndex = 2;
            // 
            // actuPrecioLabel
            // 
            actuPrecioLabel.AutoSize = true;
            actuPrecioLabel.Location = new Point(183, 68);
            actuPrecioLabel.Name = "actuPrecioLabel";
            actuPrecioLabel.Size = new Size(43, 15);
            actuPrecioLabel.TabIndex = 3;
            actuPrecioLabel.Text = "Precio:";
            // 
            // actualizarPrecioInput
            // 
            actualizarPrecioInput.Location = new Point(232, 65);
            actualizarPrecioInput.Name = "actualizarPrecioInput";
            actualizarPrecioInput.Size = new Size(202, 23);
            actualizarPrecioInput.TabIndex = 4;
            // 
            // actuCantInventarioLabel
            // 
            actuCantInventarioLabel.AutoSize = true;
            actuCantInventarioLabel.Location = new Point(112, 97);
            actuCantInventarioLabel.Name = "actuCantInventarioLabel";
            actuCantInventarioLabel.Size = new Size(114, 15);
            actuCantInventarioLabel.TabIndex = 5;
            actuCantInventarioLabel.Text = "Cantidad inventario:";
            // 
            // actualizarCantidadInventarioInput
            // 
            actualizarCantidadInventarioInput.Location = new Point(232, 94);
            actualizarCantidadInventarioInput.Name = "actualizarCantidadInventarioInput";
            actualizarCantidadInventarioInput.Size = new Size(202, 23);
            actualizarCantidadInventarioInput.TabIndex = 6;
            // 
            // actuCategoLabel
            // 
            actuCategoLabel.AutoSize = true;
            actuCategoLabel.Location = new Point(165, 131);
            actuCategoLabel.Name = "actuCategoLabel";
            actuCategoLabel.Size = new Size(61, 15);
            actuCategoLabel.TabIndex = 7;
            actuCategoLabel.Text = "Categoría:";
            // 
            // actuCategoComboBox
            // 
            actuCategoComboBox.FormattingEnabled = true;
            actuCategoComboBox.Items.AddRange(new object[] { "Alimento", "Limpieza", "Hogar", "Mascotas", "Oficina" });
            actuCategoComboBox.Location = new Point(232, 128);
            actuCategoComboBox.Name = "actuCategoComboBox";
            actuCategoComboBox.Size = new Size(202, 23);
            actuCategoComboBox.TabIndex = 8;
            actuCategoComboBox.SelectedIndexChanged += actuCategoComboBox_SelectedIndexChanged;
            // 
            // actuBodeLabel
            // 
            actuBodeLabel.AutoSize = true;
            actuBodeLabel.Location = new Point(176, 166);
            actuBodeLabel.Name = "actuBodeLabel";
            actuBodeLabel.Size = new Size(50, 15);
            actuBodeLabel.TabIndex = 9;
            actuBodeLabel.Text = "Bodega:";
            // 
            // actuBodegaComboBox
            // 
            actuBodegaComboBox.FormattingEnabled = true;
            actuBodegaComboBox.Location = new Point(232, 158);
            actuBodegaComboBox.Name = "actuBodegaComboBox";
            actuBodegaComboBox.Size = new Size(202, 23);
            actuBodegaComboBox.TabIndex = 10;
            actuBodegaComboBox.SelectedIndexChanged += actuBodegaComboBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(359, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ActualizarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(actuBodegaComboBox);
            Controls.Add(actuBodeLabel);
            Controls.Add(actuCategoComboBox);
            Controls.Add(actuCategoLabel);
            Controls.Add(actualizarCantidadInventarioInput);
            Controls.Add(actuCantInventarioLabel);
            Controls.Add(actualizarPrecioInput);
            Controls.Add(actuPrecioLabel);
            Controls.Add(actualizarNomInput);
            Controls.Add(actuNombreLabel);
            Controls.Add(actualizarBtn);
            Name = "ActualizarArticulo";
            Text = "ActualizarArticulo";
            Load += ActualizarArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button actualizarBtn;
        private Label actuNombreLabel;
        private TextBox actualizarNomInput;
        private Label actuPrecioLabel;
        private TextBox actualizarPrecioInput;
        private Label actuCantInventarioLabel;
        private TextBox actualizarCantidadInventarioInput;
        private Label actuCategoLabel;
        private ComboBox actuCategoComboBox;
        private Label actuBodeLabel;
        private ComboBox actuBodegaComboBox;
        private Button button1;
    }
}