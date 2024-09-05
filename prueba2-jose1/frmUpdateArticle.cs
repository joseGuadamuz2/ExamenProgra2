namespace prueba2_jose1
{
    public partial class frmUpdateArticle : Form
    {
        public string NewCategorySelected;
        public string NewStorageSelected;
        public string BeforeName;
        public int MinAmount;
        public int MaxAmount;

        public frmUpdateArticle(List<Storage> updateStorage, List<inventory> dataInventory)
        {
            InitializeComponent();
            ChargeDataUpdateCB(updateStorage);
            ChargeArticle(dataInventory);
        }

        private void frmUpdateArticle_Load(object sender, EventArgs e)
        {
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewCategorySelected = cbCategory.SelectedItem as string;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string nameA = txtName.Text;
                double priceA = double.Parse(txtPrice.Text);
                int amountA = int.Parse(txtAmount.Text);
                string categoryA = NewCategorySelected;
                string storageA = NewStorageSelected;

                if (!AmountValidation(MinAmount, MaxAmount, amountA))
                {
                    return;
                }

                frmMain frm = Owner as frmMain;
                var result = MessageBox.Show("Do you want to update the article?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.UpdateDataArticle(nameA, priceA, amountA, categoryA, storageA, MinAmount, MaxAmount, BeforeName);
                    frm.ChargeList();
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred");
            }
        }

        private void cbStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            NewStorageSelected = cbStorage.SelectedItem as string;
        }

        private void ChargeDataUpdateCB(List<Storage> storages)
        {
            cbStorage.DataSource = null;
            foreach (var storage in storages)
            {
                cbStorage.Items.Add(storage.StorageName);
            }
        }

        public void ChargeArticle(List<inventory> dataInventory)
        {
            var item = dataInventory[0];

            BeforeName = item.Name;
            txtName.Text = item.Name;
            txtPrice.Text = item.Price.ToString();
            txtAmount.Text = item.Amount.ToString();
            MinAmount = item.MinAmount;
            MaxAmount = item.MaxAmount;
            PreSelectionCategory(item.Category);
            PreSelectionStorage(item.Storage);
        }

        public void PreSelectionCategory(string option)
        {
            if (cbCategory.Items.Contains(option))
            {
                cbCategory.SelectedItem = option;
            }
            else
            {
                // Select the first option by default if the preselected option is not found
                cbCategory.SelectedIndex = 0;
            }
        }

        public void PreSelectionStorage(string option)
        {
            if (cbStorage.Items.Contains(option))
            {
                cbStorage.SelectedItem = option;
            }
            else
            {
                // Select the first option by default if the preselected option is not found
                cbStorage.SelectedIndex = 0;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
