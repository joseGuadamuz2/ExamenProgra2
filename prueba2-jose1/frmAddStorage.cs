

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace prueba2_jose1
{
    public partial class frmAddStorage : Form
    {
        #region Variable

        // Name of the storage
        public string storageName;
        // Location of the storage
        public string storageUbication;


        #endregion

        #region Builder
        public frmAddStorage()
        {
            InitializeComponent();
        }
        #endregion

        #region Events


        // Event triggered when the cdStorage selection changes
        private void cdStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageUbication = cbStorage.SelectedItem as string; // Uso de propiedad StorageUbication
        }

        // Event triggered when the Save button is clicked
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                storageName = txtName.Text; // Use of StorageName property
                frmMain frm = Owner as frmMain;
                var result = MessageBox.Show("Do you want to save the storage?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.AddStorage(storageName, storageUbication); // Pass the properties
                }
            }
            catch
            {
                MessageBox.Show("An error has occurred");
            }
        }

        // Event triggered when the Exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}