namespace prueba2_jose1
{
    public partial class frmAddArticle : Form
    {
        #region Variables
        // Selected category and storage from the dropdown lists
        public string CategorySelected;
        public string StorageSelected;
        #endregion

        #region Builder
        /// <summary>
        /// Constructor that initializes the form and loads available storages into the combo box.
        /// </summary>
        /// <param name="storages">List of available storages</param>
        public frmAddArticle(List<Storage> storages)
        {
            InitializeComponent();
            ChargeDataCB(storages); // Load storages into the combo box
        }

        #endregion

        #region Events
        /// <summary>
        /// Event triggered when the selected category changes.
        /// Updates the CategorySelected variable with the new selection.
        /// </summary>
        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorySelected = cbCategory.SelectedItem as string;
        }

        /// <summary>
        /// Event triggered when the form loads. 
        /// Automatically selects the first item in the category and storage combo boxes if they contain items.
        /// </summary>
        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0;  // Select the first category
            }
            if (cbStorage.Items.Count > 0)
            {
                cbStorage.SelectedIndex = 0;  // Select the first storage
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

        /// <summary>
        /// Event triggered when the "Save" button is clicked.
        /// Validates inputs and adds a new article to the inventory if validation passes.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Gather input values
                string nameA = txtName.Text;
                double priceA = double.Parse(txtPrice.Text);
                int amountA = int.Parse(txtAmount.Text);
                string categoryA = CategorySelected;
                string storageA = StorageSelected;
                int minAmountA = int.Parse(txtMinAmount.Text);
                int maxAmountA = int.Parse(txtMaxAmount.Text);

                // Validate minimum and maximum amounts
                if (!MinMaxValidation(minAmountA, maxAmountA))
                {
                    return; // Stop if validation fails
                }

                // Validate that the amount is within the allowed range
                if (!AmountValidation(minAmountA, maxAmountA, amountA))
                {
                    return;
                }

                // Get the parent form (frmMain) and add the article to the inventory
                frmMain frm = Owner as frmMain;

                var result = MessageBox.Show("Do you want to save the article?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.AddArticle(nameA, priceA, amountA, categoryA, storageA, minAmountA, maxAmountA);
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred");
            }
        }

        /// <summary>
        /// Event triggered when the selected storage changes.
        /// Updates the StorageSelected variable with the new selection.
        /// </summary>
        private void cbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            StorageSelected = cbStorage.SelectedItem as string;
        }

        /// <summary>
        /// Ensures that only letters can be typed in the Name textbox.
        /// </summary>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Ensures that only digits can be typed in the Price textbox.
        /// </summary>
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region method

        /// <summary>
        /// Loads the available storage options into the combo box.
        /// </summary>
        /// <param name="storageList">List of storages to load</param>
        private void ChargeDataCB(List<Storage> storageList)
        {
            cbStorage.DataSource = null;
            foreach (var storage in storageList)
            {
                cbStorage.Items.Add(storage.StorageName);
            }
        }

        /// <summary>
        /// Validates that the amount is within the range defined by the minimum and maximum amounts.
        /// </summary>
        /// <param name="minAmount">Minimum allowed amount</param>
        /// <param name="maxAmount">Maximum allowed amount</param>
        /// <param name="amount">The amount to validate</param>
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
                MessageBox.Show($"An error occurred during amount validation: {ex.Message}", "Warning");
                return false;
            }
        }

        /// <summary>
        /// Validates that the minimum and maximum amounts are logical (min <= max, min >= 0, max > 0).
        /// </summary>
        /// <param name="minAmount">Minimum allowed amount</param>
        /// <param name="maxAmount">Maximum allowed amount</param>
        /// <returns>True if the values are valid, otherwise false</returns>
        private bool MinMaxValidation(int minAmount, int maxAmount)
        {
            try
            {
                if (minAmount > maxAmount)
                {
                    MessageBox.Show("The minimum amount cannot be greater than the maximum", "Warning");
                    return false;
                }
                if (minAmount < 0)
                {
                    MessageBox.Show("The minimum amount cannot be negative", "Warning");
                    return false;
                }
                if (maxAmount < 1)
                {
                    MessageBox.Show("The maximum amount cannot be zero or negative", "Warning");
                    return false;
                }
                return true; // If all validations pass, return true
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during min/max validation: {ex.Message}", "Warning");
                return false;
            }
        }
     #endregion




    }
}

