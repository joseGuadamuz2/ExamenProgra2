using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2_jose1
{
    public partial class agregarBodegas : Form
    {
        public string nombreBode;
        public string ubicacionBode;

        public agregarBodegas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ubicacionBode = BodegaBox1.SelectedItem as string;
        }

        private void guardaBodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                nombreBode = nombreBodeInput.Text;
                Form1 frm = Owner as Form1;
                var result = MessageBox.Show("¿Desea guardar la bodega?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    frm.agregarBodega(nombreBode, ubicacionBode);

                }
            }

            catch
            {
                MessageBox.Show("Ha Ocurrido un error");
            }

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}