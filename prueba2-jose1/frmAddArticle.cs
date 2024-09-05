namespace prueba2_jose1
{
    public partial class frmAddArticle : Form
    {
        public string CategorySelected;
        public string StorageSelected;

        public frmAddArticle(List<Storage> storages)
        {
            InitializeComponent();
            ChargeDataCB(storages);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategorySelected = cbCategory.SelectedItem as string;
        }

        private void frmAddArticle_Load(object sender, EventArgs e)
        {
            if (cbCategory.Items.Count > 0)
            {
                cbCategory.SelectedIndex = 0;  // Select the first item
            }
            if (cbStorage.Items.Count > 0)
            {
                cbStorage.SelectedIndex = 0;  // Select the first item
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nameA = txtName.Text;
                double priceA = double.Parse(txtPrice.Text);
                int amountA = int.Parse(txtAmount.Text);
                string categoryA = CategorySelected;
                string storageA = StorageSelected;
                int minAmountA = int.Parse(txtMinAmount.Text);
                int maxAmountA = int.Parse(txtMaxAmount.Text);

                if (!MinMaxValidation(minAmountA, maxAmountA))
                {
                    return; // If validation fails, do not continue
                }

                if (!AmountValidation(minAmountA, maxAmountA, amountA))
                {
                    return;
                }

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

        private void cbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            StorageSelected = cbStorage.SelectedItem as string;
        }

        private void ChargeDataCB(List<Storage> storageList)
        {
            cbStorage.DataSource = null;
            foreach (var storage in storageList)
            {
                cbStorage.Items.Add(storage.StorageName);
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool AmountValidation(int minAmount, int maxAmount, int amount)
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

        private bool MinMaxValidation(int minAmount, int maxAmount)
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
    }
}

