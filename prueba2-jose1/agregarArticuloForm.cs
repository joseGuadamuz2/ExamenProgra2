using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace prueba2_jose1
{
    public partial class agregarArticuloForm : Form
    {
        public string categoriaSelec;
        public string bodegaSelec;
        public agregarArticuloForm(List<Bodegas> bode)
        {

            InitializeComponent();
            cargarDatosCombo(bode);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaSelec = categComboBox.SelectedItem as string;
        }

        private void agregarArticuloForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelarGuardado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreA = agregarArtiInput.Text;
                double precioA = double.Parse(precioInput.Text);
                int cantidadA = int.Parse(cantidadInventario.Text);
                string categoriaA = categoriaSelec;
                string bodegaA = bodegaSelec;
                int minA = int.Parse(minInput.Text);
                int maxA = int.Parse(maxInput.Text);

                Form1 frm = Owner as Form1;



                var result = MessageBox.Show("¿Desea guardar el artículo?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.agregarArticulo(nombreA, precioA, cantidadA, categoriaA, bodegaA, minA, maxA);
                 

                }

            }
            catch
            {
                MessageBox.Show("Ha Ocurrido un error");
            }


        }

        private void bodegaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodegaSelec = bodegaComboBox.SelectedItem as string;
        }
        private void cargarDatosCombo(List<Bodegas> bode1)
        {

            bodegaComboBox.DataContext = null;
            for (int i = 0; i < bode1.Count; i++)
            {
                var bodega2 = bode1[i];
                bodegaComboBox.Items.Add(bodega2.NombreBodega);
            }



        }

        private void agregarArtiInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void precioInput_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
