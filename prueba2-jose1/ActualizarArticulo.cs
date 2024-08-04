using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace prueba2_jose1
{
    public partial class ActualizarArticulo : Form
    {
        public string categoriaSelecActu;
        public string bodegaSelecActu;
        public string nomAnterior;
        public int minA;
        public int maxA;

        public ActualizarArticulo(List<Bodegas> bodeActu, List<inventario> datosVis)
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

                Form1 frm = Owner as Form1;
                var result = MessageBox.Show("¿Desea actualizar el artículo?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.actualizarDatos(nombreA, precioA, cantidadA, categoriaA, bodegaA, minA, maxA, nomAnterior);
                    frm.cargarLista();

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
        private void cargarDatosComboActu(List<Bodegas> bode1)
        {

            actuBodegaComboBox.DataContext = null;
            for (int i = 0; i < bode1.Count; i++)
            {
                var bodega2 = bode1[i];
                actuBodegaComboBox.Items.Add(bodega2.NombreBodega);
            }



        }

        public void vizualizarDatos(List<inventario> datosVis1)
        {
            var list = datosVis1[0];

            nomAnterior = list.Nombre;
            actualizarNomInput.Text = list.Nombre;
            actualizarPrecioInput.Text = list.precio.ToString();
            actualizarCantidadInventarioInput.Text = list.Cantidad.ToString();
            minA = list.NumMin;
            maxA = list.NumMax;
            preSeleccionCateg(list.Categoria);
            preSeleccionBode(list.Bodega);


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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
