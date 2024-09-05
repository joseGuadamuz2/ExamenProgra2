

using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace prueba2_jose1
{
    public partial class frmAddStorage : Form
    {
        public string storageName;
        public string storageUbication;

        public frmAddStorage()
        {
            InitializeComponent();
        }

        // Evento de selección de ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            storageUbication = cbStorage.SelectedItem as string; // Uso de propiedad StorageUbication
        }

        // Evento de clic en el botón Guardar
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                storageName = txtName.Text; // Uso de propiedad StorageName
                frmMain frm = Owner as frmMain;
                var result = MessageBox.Show("¿Desea guardar la bodega?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.AddStorage(storageName, storageUbication); // Pasar las propiedades
                }
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Evento de clic en el botón Salir
        private void salirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}