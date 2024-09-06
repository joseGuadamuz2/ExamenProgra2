namespace prueba2_jose1
{
    public partial class frmUpdateArticle : Form
    {
        // Variables to hold the selected new category, new storage, and original article name

        #region Variable

        public string NewCategorySelected;
        public string NewStorageSelected;
        public string BeforeName;
        public int MinAmount;
        public int MaxAmount;

        #endregion

        #region Builder

        /// <summary>
        /// Constructor that initializes the form and loads storages and article data.
        /// </summary>
        /// <param name="updateStorage">List of storages to display in the storage dropdown</param>
        /// <param name="dataInventory">List containing inventory data for the article to be updated</param>
        public frmUpdateArticle(List<Storage> updateStorage, List<inventory> dataInventory)
        {
            InitializeComponent();
            ChargeDataUpdateCB(updateStorage); // Load storage data into combo box
            ChargeArticle(dataInventory);      // Load article data for update
        }

        #endregion

        #region Event

        private void frmUpdateArticle_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Event triggered when the selected category changes.
        /// Updates the NewCategorySelected variable with the new selection.
        /// </summary>
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NewCategorySelected = cbCategory.SelectedItem as string;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting the category: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Event triggered when the "Update" button is clicked.
        /// Validates input and updates the article information if validation passes.
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather input values
                string nameA = txtName.Text;
                double priceA;
                int amountA;
                string categoryA = NewCategorySelected;
                string storageA = NewStorageSelected;

                try
                {
                    priceA = double.Parse(txtPrice.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid price format", "Error");
                    return;
                }

                try
                {
                    amountA = int.Parse(txtAmount.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid amount format", "Error");
                    return;
                }

                // Validate the amount
                if (!AmountValidation(MinAmount, MaxAmount, amountA))
                {
                    return; // Stop if validation fails
                }

                // Update article information in the main form
                frmMain frm = Owner as frmMain;
                var result = MessageBox.Show("Do you want to update the article?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        frm.UpdateDataArticle(nameA, priceA, amountA, categoryA, storageA, MinAmount, MaxAmount, BeforeName);
                        frm.ChargeList(); // Reload the inventory list after the update
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the article: {ex.Message}", "Error");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Event triggered when the selected storage changes.
        /// Updates the NewStorageSelected variable with the new selection.
        /// </summary>
        private void cbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                NewStorageSelected = cbStorage.SelectedItem as string;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while selecting the storage: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Event triggered when the "Cancel" button is clicked.
        /// Closes the form.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Method
        /// <summary>
        /// Loads available storage options into the combo box.
        /// </summary>
        /// <param name="storages">List of storages</param>
        private void ChargeDataUpdateCB(List<Storage> storages)
        {
            try
            {
                cbStorage.DataSource = null;
                foreach (var storage in storages)
                {
                    cbStorage.Items.Add(storage.StorageName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading storage data: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Loads the current article information into the form for updating.
        /// </summary>
        /// <param name="dataInventory">List containing the article's inventory data</param>
        public void ChargeArticle(List<inventory> dataInventory)
        {
            try
            {
                var item = dataInventory[0]; // Assume the first item in the list is the one being updated

                BeforeName = item.Name;           // Store the original name for reference
                txtName.Text = item.Name;         // Set the article name
                txtPrice.Text = item.Price.ToString();   // Set the price
                txtAmount.Text = item.Amount.ToString(); // Set the amount
                MinAmount = item.MinAmount;       // Store the minimum amount
                MaxAmount = item.MaxAmount;       // Store the maximum amount
                PreSelectionCategory(item.Category);  // Preselect the category
                PreSelectionStorage(item.Storage);    // Preselect the storage
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the article data: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Preselects the category in the dropdown list if it exists.
        /// </summary>
        /// <param name="option">The category to preselect</param>
        public void PreSelectionCategory(string option)
        {
            try
            {
                if (cbCategory.Items.Contains(option))
                {
                    cbCategory.SelectedItem = option;  // Select the category if it exists
                }
                else
                {
                    cbCategory.SelectedIndex = 0;      // Default to the first option if not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while preselecting the category: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Preselects the storage in the dropdown list if it exists.
        /// </summary>
        /// <param name="option">The storage to preselect</param>
        public void PreSelectionStorage(string option)
        {
            try
            {
                if (cbStorage.Items.Contains(option))
                {
                    cbStorage.SelectedItem = option;   // Select the storage if it exists
                }
                else
                {
                    cbStorage.SelectedIndex = 0;       // Default to the first option if not found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while preselecting the storage: {ex.Message}", "Error");
            }
        }

        /// <summary>
        /// Validates that the article's amount is within the allowed range.
        /// </summary>
        /// <param name="minAmount">Minimum allowed amount</param>
        /// <param name="maxAmount">Maximum allowed amount</param>
        /// <param name="amount">Amount to validate</param>
        /// <returns>True if the amount is valid, otherwise false</returns>
        private bool AmountValidation(int minAmount, int maxAmount, int amount)
        {
            try
            {
                if (amount < minAmount)
                {
                    MessageBox.Show("The amount is less than the minimum established", "Warning");
                    return false;
                }
                else if (amount > maxAmount)
                {
                    MessageBox.Show("The amount exceeds the maximum established", "Warning");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during amount validation: {ex.Message}", "Error");
                return false;
            }
        }

        #endregion

    }
}

