namespace prueba2_jose1
{
    partial class agregarArticuloForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarArticuloForm));
            nombreArtLabel = new Label();
            agregarArtiInput = new TextBox();
            precioInput = new TextBox();
            precioLabel = new Label();
            cantidadInventario = new TextBox();
            cantidadLabel = new Label();
            categLabel = new Label();
            categComboBox = new ComboBox();
            bodegaLabel = new Label();
            bodegaComboBox = new ComboBox();
            numMinLabel = new Label();
            minInput = new TextBox();
            numMaxLabel = new Label();
            maxInput = new TextBox();
            guardarBtn = new Button();
            cancelarGuardado = new Button();
            SuspendLayout();
            // 
            // nombreArtLabel
            // 
            resources.ApplyResources(nombreArtLabel, "nombreArtLabel");
            nombreArtLabel.Name = "nombreArtLabel";
            // 
            // agregarArtiInput
            // 
            resources.ApplyResources(agregarArtiInput, "agregarArtiInput");
            agregarArtiInput.Name = "agregarArtiInput";
            agregarArtiInput.KeyPress += agregarArtiInput_KeyPress;
            // 
            // precioInput
            // 
            resources.ApplyResources(precioInput, "precioInput");
            precioInput.Name = "precioInput";
            precioInput.TextChanged += precioInput_TextChanged;
            // 
            // precioLabel
            // 
            resources.ApplyResources(precioLabel, "precioLabel");
            precioLabel.Name = "precioLabel";
            // 
            // cantidadInventario
            // 
            resources.ApplyResources(cantidadInventario, "cantidadInventario");
            cantidadInventario.Name = "cantidadInventario";
            // 
            // cantidadLabel
            // 
            resources.ApplyResources(cantidadLabel, "cantidadLabel");
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Click += label1_Click;
            // 
            // categLabel
            // 
            resources.ApplyResources(categLabel, "categLabel");
            categLabel.Name = "categLabel";
            // 
            // categComboBox
            // 
            resources.ApplyResources(categComboBox, "categComboBox");
            categComboBox.FormattingEnabled = true;
            categComboBox.Items.AddRange(new object[] { resources.GetString("categComboBox.Items"), resources.GetString("categComboBox.Items1"), resources.GetString("categComboBox.Items2"), resources.GetString("categComboBox.Items3"), resources.GetString("categComboBox.Items4") });
            categComboBox.Name = "categComboBox";
            categComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bodegaLabel
            // 
            resources.ApplyResources(bodegaLabel, "bodegaLabel");
            bodegaLabel.Name = "bodegaLabel";
            // 
            // bodegaComboBox
            // 
            resources.ApplyResources(bodegaComboBox, "bodegaComboBox");
            bodegaComboBox.FormattingEnabled = true;
            bodegaComboBox.Name = "bodegaComboBox";
            bodegaComboBox.SelectedIndexChanged += bodegaComboBox_SelectedIndexChanged;
            // 
            // numMinLabel
            // 
            resources.ApplyResources(numMinLabel, "numMinLabel");
            numMinLabel.Name = "numMinLabel";
            // 
            // minInput
            // 
            resources.ApplyResources(minInput, "minInput");
            minInput.Name = "minInput";
            // 
            // numMaxLabel
            // 
            resources.ApplyResources(numMaxLabel, "numMaxLabel");
            numMaxLabel.Name = "numMaxLabel";
            // 
            // maxInput
            // 
            resources.ApplyResources(maxInput, "maxInput");
            maxInput.Name = "maxInput";
            // 
            // guardarBtn
            // 
            resources.ApplyResources(guardarBtn, "guardarBtn");
            guardarBtn.Name = "guardarBtn";
            guardarBtn.UseVisualStyleBackColor = true;
            guardarBtn.Click += guardarBtn_Click;
            // 
            // cancelarGuardado
            // 
            resources.ApplyResources(cancelarGuardado, "cancelarGuardado");
            cancelarGuardado.Name = "cancelarGuardado";
            cancelarGuardado.UseVisualStyleBackColor = true;
            cancelarGuardado.Click += cancelarGuardado_Click;
            // 
            // agregarArticuloForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cancelarGuardado);
            Controls.Add(guardarBtn);
            Controls.Add(maxInput);
            Controls.Add(numMaxLabel);
            Controls.Add(minInput);
            Controls.Add(numMinLabel);
            Controls.Add(bodegaComboBox);
            Controls.Add(bodegaLabel);
            Controls.Add(categComboBox);
            Controls.Add(categLabel);
            Controls.Add(cantidadInventario);
            Controls.Add(cantidadLabel);
            Controls.Add(precioInput);
            Controls.Add(precioLabel);
            Controls.Add(agregarArtiInput);
            Controls.Add(nombreArtLabel);
            Name = "agregarArticuloForm";
            Load += agregarArticuloForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nombreArtLabel;
        private TextBox agregarArtiInput;
        private TextBox precioInput;
        private Label precioLabel;
        private TextBox cantidadInventario;
        private Label cantidadLabel;
        private Label categLabel;
        private ComboBox categComboBox;
        private Label bodegaLabel;
        private ComboBox bodegaComboBox;
        private Label numMinLabel;
        private TextBox minInput;
        private Label numMaxLabel;
        private TextBox maxInput;
        private Button guardarBtn;
        private Button cancelarGuardado;
    }
}