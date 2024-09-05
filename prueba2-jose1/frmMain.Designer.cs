namespace prueba2_jose1
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            dgvMain = new DataGridView();
            menuStrip1 = new MenuStrip();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            artículosToolStripMenuItem = new ToolStripMenuItem();
            bodegaToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMain
            // 
            resources.ApplyResources(dgvMain, "dgvMain");
            dgvMain.AllowUserToOrderColumns = true;
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Name = "dgvMain";
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Items.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            resources.ApplyResources(agregarToolStripMenuItem, "agregarToolStripMenuItem");
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { artículosToolStripMenuItem, bodegaToolStripMenuItem });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            // 
            // artículosToolStripMenuItem
            // 
            resources.ApplyResources(artículosToolStripMenuItem, "artículosToolStripMenuItem");
            artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            artículosToolStripMenuItem.Click += artículosToolStripMenuItem_Click;
            // 
            // bodegaToolStripMenuItem
            // 
            resources.ApplyResources(bodegaToolStripMenuItem, "bodegaToolStripMenuItem");
            bodegaToolStripMenuItem.Name = "bodegaToolStripMenuItem";
            bodegaToolStripMenuItem.Click += bodegaToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMain;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem artículosToolStripMenuItem;
        private ToolStripMenuItem bodegaToolStripMenuItem;
    }
}
