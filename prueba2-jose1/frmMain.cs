﻿

namespace prueba2_jose1
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// This program registers products and modifies products. 
        /// It can also assign warehouses and add new warehouses.
        /// </summary>
        #region Variables

        // List containing the complete inventory
        public List<inventory> completeInventory = new List<inventory>();

        // List containing the warehouses
        public List<Storage> storages = new List<Storage>();

        // Temporary list for loading data to be updated
        public List<inventory> chargeNewData = new List<inventory>();
        #endregion

        #region Builder

        /// <summary>
        /// Constructor of the frmMain class. Initializes the warehouses and inventory with default data.
        /// </summary>

        public frmMain()
        {
            InitializeComponent();
            storages.Add(new Storage("BODEGA1", ""));
            storages.Add(new Storage("BODEGA2", ""));
            storages.Add(new Storage("BODEGA3", ""));

            // Add an initial item to the inventory
            completeInventory.Add(new inventory("papas", 150, 18, "alimento", "cañas", 1, 100));
        }

        #endregion

        #region Events

        /// <summary>
        /// Event triggered when the form loads. Calls the ChargeList method to display the data.
        /// </summary>
        /// 
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                ChargeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the form: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Event triggered when the user selects the "Add Article" option from the menu. 
        /// Opens the frmAddArticle form.
        /// </summary>
        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddArticle frmAddArticle = new frmAddArticle(storages);
                AddOwnedForm(frmAddArticle);
                frmAddArticle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Add Article form: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Event triggered when the user selects the "Add Storage" option from the menu. 
        /// Opens the frmAddStorage form.
        /// </summary>
        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddStorage frmAddStorage = new frmAddStorage();
                AddOwnedForm(frmAddStorage);
                frmAddStorage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Add Storage form: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Event triggered when a cell in the DataGridView is clicked. Handles deletion or updating of articles.
        /// </summary>
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the clicked cell belongs to the "Delete" column
                if (e.ColumnIndex == dgvMain.Columns["Eliminar"].Index && e.RowIndex >= 0)
                {
                    string selectedId = (string)dgvMain.Rows[e.RowIndex].Cells["Name"].Value;
                    DeleteArticle(selectedId);
                }

                // Check if the clicked cell belongs to the "Update" column
                if (e.ColumnIndex == dgvMain.Columns["Actualizar"].Index && e.RowIndex >= 0)
                {
                    string selectedId = (string)dgvMain.Rows[e.RowIndex].Cells["Name"].Value;
                    UpdateArticle(selectedId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the DataGridView cell click: {ex.Message}", "Warning");
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Adds a new article to the inventory and updates the display.
        /// </summary>
        public void AddArticle(string name, double price, int amount, string category, string storage,
            int minAmount, int maxAmount)
        {
            try
            {
                completeInventory.Add(new inventory(name, price, amount, category, storage, minAmount, maxAmount));
                ChargeList(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the article: {ex.Message}", "Warning");
            }
        }


        /// <summary>
        /// Loads the inventory data into the DataGridView and adds Delete/Update buttons to each row.
        /// </summary>
        public void ChargeList()
        {
            try
            {
                // Remove previous columns if they exist
                if (dgvMain.Columns["Eliminar"] != null)
                {
                    dgvMain.Columns.Remove("Eliminar");
                    dgvMain.Columns.Remove("Actualizar");
                }

                // Set the DataGridView data source to the inventory
                dgvMain.DataSource = null;
                dgvMain.DataSource = completeInventory;

                // Add the Delete button column
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

                // Add the Update button column
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the DataGridView: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Adds a new warehouse (storage) to the storages list.
        /// </summary>
        public void AddStorage(string storageName, string storageLocation)
        {
            try
            {
                storages.Add(new Storage(storageName, storageLocation));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the storage: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Deletes an article from the inventory by its name and updates the display.
        /// </summary>
        public void DeleteArticle(string articleName)
        {
            try
            {
                // Search for the article by its name and remove it from the inventory
                for (int i = 0; i < completeInventory.Count; i++)
                {
                    var article = completeInventory[i];
                    if (article.Name == articleName)
                    {
                        completeInventory.RemoveAt(i);
                        break; // Exit the loop after removing the article
                    }
                }
                ChargeList(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the article: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Loads the data of the selected article for updating and opens the update form.
        /// </summary>
        public void UpdateArticle(string articleName)
        {
            try
            {
                chargeNewData.Clear(); // Clear the temporary data list

                // Search for the article by its name and add its data to the temporary list
                for (int i = 0; i < completeInventory.Count; i++)
                {
                    var article = completeInventory[i];
                    if (article.Name == articleName)
                    {
                        chargeNewData.Add(new inventory(article.Name, article.Price, article.Amount,
                            article.Category, article.Storage, article.MinAmount, article.MaxAmount));
                    }
                }

                // Open the update form with the selected article's data
                frmUpdateArticle frmUpdateArticle = new frmUpdateArticle(storages, chargeNewData);
                AddOwnedForm(frmUpdateArticle);
                frmUpdateArticle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the article: {ex.Message}", "Warning");
            }
        }

        /// <summary>
        /// Updates the data of an existing article with new values and refreshes the display.
        /// </summary>
        public void UpdateDataArticle(string name, double price, int amount, string category, string storage,
            int minAmount, int maxAmount, string beforeName)
        {
            try
            {
                // Search for the article by its previous name and update its properties
                for (int i = 0; i < completeInventory.Count; i++)
                {
                    var article = completeInventory[i];
                    if (article.Name == beforeName)
                    {
                        // Update the article's properties
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

                ChargeList(); // Refresh the DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the article data: {ex.Message}", "Warning");
            }
        }
        #endregion
    }
}