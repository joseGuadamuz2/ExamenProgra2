

namespace prueba2_jose1
{
    public partial class frmUpdateArticle : Form
    {
        public string categoriaSelecActu;
        public string bodegaSelecActu;
        public string nomAnterior;
        public int minA;
        public int maxA;

        public frmUpdateArticle(List<Storage> bodeActu, List<inventory> datosVis)
        {
            InitializeComponent();
            cargarDatosComboActu(bodeActu);
            vizualizarDatos(datosVis);


        }

        private void ActualizarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void actuCategoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaSelecActu = actuCategoComboBox.SelectedItem as string;
        }

        private void actualizarBtn_Click(object sender, EventArgs e)
        {
            try
            {

                string nombreA = actualizarNomInput.Text;
                double precioA = double.Parse(actualizarPrecioInput.Text);
                int cantidadA = int.Parse(actualizarCantidadInventarioInput.Text);
                string categoriaA = categoriaSelecActu;
                string bodegaA = bodegaSelecActu;

                if (!amountValidation(minA, maxA, cantidadA))
                {
                    return;
                };

                frmMain frm = Owner as frmMain;
                var result = MessageBox.Show("¿Desea actualizar el artículo?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.UpdateDataArticle(nombreA, precioA, cantidadA, categoriaA, bodegaA, minA, maxA, nomAnterior);
                    frm.ChargeList();

                }

            }
            catch
            {
                MessageBox.Show("Ha Ocurrido un error");
            }
        }

        private void actuBodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodegaSelecActu = actuBodegaComboBox.SelectedItem as string;
        }
        private void cargarDatosComboActu(List<Storage> bode1)
        {

            actuBodegaComboBox.DataContext = null;
            for (int i = 0; i < bode1.Count; i++)
            {
                var bodega2 = bode1[i];
                actuBodegaComboBox.Items.Add(bodega2.StorageName);
            }



        }

        public void vizualizarDatos(List<inventory> datosVis1)
        {
            var list = datosVis1[0];

            nomAnterior = list.Name;
            actualizarNomInput.Text = list.Name;
            actualizarPrecioInput.Text = list.Price.ToString();
            actualizarCantidadInventarioInput.Text = list.Amount.ToString();
            minA = list.MinAmount;
            maxA = list.MaxAmount;
            preSeleccionCateg(list.Category);
            preSeleccionBode(list.Storage);


        }
        public void preSeleccionCateg(string opc)
        {
            if (actuCategoComboBox.Items.Contains(opc))
            {
                actuCategoComboBox.SelectedItem = opc;
            }
            else
            {
                // Seleccionar la primera opción por defecto si no se encuentra la preseleccionada
                actuCategoComboBox.SelectedIndex = 0;
            }
        }
        public void preSeleccionBode(string opc)
        {
            if (actuBodegaComboBox.Items.Contains(opc))
            {
                actuBodegaComboBox.SelectedItem = opc;
            }
            else
            {
                // Seleccionar la primera opción por defecto si no se encuentra la preseleccionada
                actuBodegaComboBox.SelectedIndex = 0;
            }
        }
        private bool amountValidation(int amountMin, int amountMax, int amount)
        {
            if (amount < amountMin)
            {
                MessageBox.Show("la cantidad es menor al minimo establecido", "Aviso");
                return false;
            }
            else if (amount > amountMax)
            {
                MessageBox.Show("la cantidad es mayor al máximo estabecido", "Aviso");
                return false;
            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
