namespace prueba2_jose1
{
    partial class frmAddStorage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddStorage));
            nomBodeLable = new Label();
            nombreBodeInput = new TextBox();
            ubicacionLabel = new Label();
            BodegaBox1 = new ComboBox();
            guardaBodeBtn = new Button();
            salirBtn = new Button();
            SuspendLayout();
            // 
            // nomBodeLable
            // 
            resources.ApplyResources(nomBodeLable, "nomBodeLable");
            nomBodeLable.Name = "nomBodeLable";
            // 
            // nombreBodeInput
            // 
            resources.ApplyResources(nombreBodeInput, "nombreBodeInput");
            nombreBodeInput.Name = "nombreBodeInput";
            // 
            // ubicacionLabel
            // 
            resources.ApplyResources(ubicacionLabel, "ubicacionLabel");
            ubicacionLabel.Name = "ubicacionLabel";
            // 
            // BodegaBox1
            // 
            resources.ApplyResources(BodegaBox1, "BodegaBox1");
            BodegaBox1.FormattingEnabled = true;
            BodegaBox1.Items.AddRange(new object[] { resources.GetString("BodegaBox1.Items"), resources.GetString("BodegaBox1.Items1"), resources.GetString("BodegaBox1.Items2") });
            BodegaBox1.Name = "BodegaBox1";
            BodegaBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // guardaBodeBtn
            // 
            resources.ApplyResources(guardaBodeBtn, "guardaBodeBtn");
            guardaBodeBtn.Name = "guardaBodeBtn";
            guardaBodeBtn.UseVisualStyleBackColor = true;
            guardaBodeBtn.Click += guardaBodeBtn_Click;
            // 
            // salirBtn
            // 
            resources.ApplyResources(salirBtn, "salirBtn");
            salirBtn.Name = "salirBtn";
            salirBtn.UseVisualStyleBackColor = true;
            salirBtn.Click += salirBtn_Click;
            // 
            // agregarBodegas
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salirBtn);
            Controls.Add(guardaBodeBtn);
            Controls.Add(BodegaBox1);
            Controls.Add(ubicacionLabel);
            Controls.Add(nombreBodeInput);
            Controls.Add(nomBodeLable);
            Name = "agregarBodegas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomBodeLable;
        private TextBox nombreBodeInput;
        private Label ubicacionLabel;
        private ComboBox BodegaBox1;
        private Button guardaBodeBtn;
        private Button salirBtn;
    }
}