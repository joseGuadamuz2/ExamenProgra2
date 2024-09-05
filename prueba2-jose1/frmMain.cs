

namespace prueba2_jose1
{
    public partial class frmMain : Form
    {
        public List<inventory> completeInventory = new List<inventory>();
        public List<Storage> storages = new List<Storage>();
        public List<inventory> chargeNewData = new List<inventory>();

        public frmMain()
        {
            InitializeComponent();
            storages.Add(new Storage("BODEGA1", ""));
            storages.Add(new Storage("BODEGA2", ""));
            storages.Add(new Storage("BODEGA3", ""));

            completeInventory.Add(new inventory("papas", 150, 18, "alimento", "cañas", 1, 100));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChargeList();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddArticle frmAddArticle = new frmAddArticle(storages);
            AddOwnedForm(frmAddArticle);
            frmAddArticle.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStorage frmAddStorage = new frmAddStorage();
            AddOwnedForm(frmAddStorage);
            frmAddStorage.ShowDialog();
        }

        public void AddArticle(string name, double price, int amount, string category, string storage,
            int minAmount, int maxAmount)
        {
            completeInventory.Add(new inventory(name, price, amount, category, storage, minAmount, maxAmount));
            ChargeList();
        }

        public void ChargeList()
        {
            if (dgvMain.Columns["Eliminar"] != null)
            {
                dgvMain.Columns.Remove("Eliminar");
                dgvMain.Columns.Remove("Actualizar");
            }

            dgvMain.DataSource = null;
            dgvMain.DataSource = completeInventory;

            if (dgvMain.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Delete",
                    Name = "Eliminar",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true
                };
                dgvMain.Columns.Add(btnColumn);
            }

            if (dgvMain.Columns["Actualizar"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn
                {
                    HeaderText = "Update",
                    Name = "Actualizar",
                    Text = "Update",
                    UseColumnTextForButtonValue = true
                };
                dgvMain.Columns.Add(btnColumn);
            }
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMain.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                string selectedId = (string)dgvMain.Rows[e.RowIndex].Cells["Nombre"].Value;
                //MessageBox.Show(string.Format("Hello {0}", selectedId));
                DeleteArticle(selectedId);
            }

            if (e.ColumnIndex == dgvMain.Columns["Actualizar"].Index && e.RowIndex >= 0)
            {
                string selectedId = (string)dgvMain.Rows[e.RowIndex].Cells["Nombre"].Value;
                //MessageBox.Show(string.Format("Hello {0}", selectedId));
                UpdateArticle(selectedId);
            }
        }

        public void AddStorage(string storageName, string storageLocation)
        {
            storages.Add(new Storage(storageName, storageLocation));
        }

        public void DeleteArticle(string articleName)
        {
            try
            {
                for (int i = 0; i < completeInventory.Count; i++)
                {
                    var article = completeInventory[i];
                    if (article.Name == articleName)
                    {
                        completeInventory.RemoveAt(i);
                    }
                }
                ChargeList();
            }
            catch
            {
                MessageBox.Show("An error has occurred", "Warning");
            }
        }

        // Loads the variables to display in the update form.
        public void UpdateArticle(string articleName)
        {
            try
            {
                chargeNewData.Clear();
                for (int i = 0; i < completeInventory.Count; i++)
                {
                    var article = completeInventory[i];
                    if (article.Name == articleName)
                    {
                        chargeNewData.Add(new inventory(article.Name, article.Price, article.Amount, 
                            article.Category, article.Storage, article.MinAmount, article.MaxAmount));
                    }
                }

                frmUpdateArticle frmUpdateArticle = new frmUpdateArticle(storages, chargeNewData);
                AddOwnedForm(frmUpdateArticle);
                frmUpdateArticle.ShowDialog();
            }
            catch
            {
                MessageBox.Show("An error has occurred", "Warning");
            }
        }

        public void UpdateDataArticle(string name, double price, int amount, string category, string storage,
            int minAmount, int maxAmount, string beforeName)
        {
            for (int i = 0; i < completeInventory.Count; i++)
            {
                var article = completeInventory[i];
                if (article.Name == beforeName)
                {
                    // Update the properties of the existing article
                    article.Name = name;
                    article.Price = price;
                    article.Amount = amount;
                    article.Category = category;
                    article.Storage = storage;
                    article.MinAmount = minAmount;
                    article.MaxAmount = maxAmount;

                    //MessageBox.Show("Executed");
                    break; // Exit the loop after updating the article
                }
            }

            ChargeList();
        }
    }
}