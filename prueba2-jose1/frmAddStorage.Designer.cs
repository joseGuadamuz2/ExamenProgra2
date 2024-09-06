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
            lblName = new Label();
            txtName = new TextBox();
            lblUbication = new Label();
            cbStorage = new ComboBox();
            btnSave = new Button();
            btnExit = new Button();
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
            // lblUbication
            // 
            resources.ApplyResources(lblUbication, "lblUbication");
            lblUbication.Name = "lblUbication";
            // 
            // cbStorage
            // 
            resources.ApplyResources(cbStorage, "cbStorage");
            cbStorage.FormattingEnabled = true;
            cbStorage.Items.AddRange(new object[] { resources.GetString("cbStorage.Items"), resources.GetString("cbStorage.Items1"), resources.GetString("cbStorage.Items2") });
            cbStorage.Name = "cbStorage";
            cbStorage.SelectedIndexChanged += cdStorage_SelectedIndexChanged;
            // 
            // btnSave
            // 
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmAddStorage
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(cbStorage);
            Controls.Add(lblUbication);
            Controls.Add(txtName);
            Controls.Add(lblName);
            Name = "frmAddStorage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblUbication;
        private ComboBox cbStorage;
        private Button btnSave;
        private Button btnExit;
    }
}