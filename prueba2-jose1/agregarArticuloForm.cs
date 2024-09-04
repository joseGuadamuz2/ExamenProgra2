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
            categoriaSelec = cbCateory.SelectedItem as string;
        }

        private void agregarArticuloForm_Load(object sender, EventArgs e)
        {
            if (cbCateory.Items.Count > 0)
            {
                cbCateory.SelectedIndex = 0;  // Selecciona el primer ítem
            }
            if (cbStore.Items.Count > 0)
            {
                cbStore.SelectedIndex = 0;  // Selecciona el primer ítem
            }
        }

        private void cancelarGuardado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreA = txtName.Text;
                double precioA = double.Parse(txtPrice.Text);
                int cantidadA = int.Parse(txtAmount.Text);
                string categoriaA = categoriaSelec;
                string bodegaA = bodegaSelec;
                int minA = int.Parse(txtMinAmount.Text);
                int maxA = int.Parse(txtMaxAmount.Text);
                if (!minMaxValidation(minA, maxA))
                {
                    return; // Si la validación falla, no continúa
                }

                if (!amountValidation(minA, maxA, cantidadA))
                {
                    return;
                };


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
            bodegaSelec = cbStore.SelectedItem as string;
        }
        private void cargarDatosCombo(List<Bodegas> bode1)
        {

            cbStore.DataContext = null;
            for (int i = 0; i < bode1.Count; i++)
            {
                var bodega2 = bode1[i];
                cbStore.Items.Add(bodega2.NombreBodega);
            }



        }

        private void agregarArtiInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private bool amountValidation(int amountMin, int amountMax, int amount)
        {
            if (amount < amountMin)
            {
                MessageBox.Show("la cantidad es menor al minimo establecido", "Aviso");
                return false;
            }
            else if (amount > amountMax)
            {
                MessageBox.Show("la cantidad es menor al máximo estabecido", "Aviso");
                return false;
            }
               return true;
        }
        private bool minMaxValidation(int amountMin, int amountMax)
        {
            if (amountMin > amountMax)
            {
                MessageBox.Show("El monto mínimo no puede ser mayor al máximo", "Aviso");
                return false;
            }
            if (amountMin < 0)
            {
                MessageBox.Show("El monto mínimo no puede ser negativo", "Aviso");
                return false;
            }
            if (amountMax < 1)
            {
                MessageBox.Show("El monto máximo no puede ser cero o  negativo", "Aviso");
                return false;
            }

            return true; // Si todas las validaciones pasan, retorna true
        }





    }
    
}
