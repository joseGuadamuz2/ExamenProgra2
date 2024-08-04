﻿using System.ComponentModel;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace prueba2_jose1
{

    public partial class Form1 : Form
    {
        public List<inventario> inventarioCompleto = new List<inventario>();
        public List<Bodegas> bodegasLista = new List<Bodegas>();
        public List<inventario> cargaDatosActu = new List<inventario>();




        public Form1()
        {
            InitializeComponent();
            bodegasLista.Add(new Bodegas("BODEGA1", ""));
            bodegasLista.Add(new Bodegas("BODEGA2", ""));
            bodegasLista.Add(new Bodegas("BODEGA3", ""));


            inventarioCompleto.Add(new inventario("papas", 150, 18, "alimento", "cañas", 1, 100));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            agregarArticuloForm agregarArticuloForm = new agregarArticuloForm(bodegasLista);
            AddOwnedForm(agregarArticuloForm);
            agregarArticuloForm.ShowDialog();
        }
        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarBodegas agregarBodegasForm = new agregarBodegas();
            AddOwnedForm(agregarBodegasForm);
            agregarBodegasForm.ShowDialog();

        }

        public void agregarArticulo(string nombre, double precio, int cantidad, string categoria, string bodega, int minimo, int maximo)
        {
            inventarioCompleto.Add(new inventario(nombre, precio, cantidad, categoria, bodega, minimo, maximo));

            cargarLista();
        }



        public void cargarLista()
        {
            if (mainGridView.Columns["Eliminar"] != null)
            {
                mainGridView.Columns.Remove("Eliminar");
                mainGridView.Columns.Remove("Actualizar");
            }
               
            mainGridView.DataSource = null;
            mainGridView.DataSource = inventarioCompleto;
           

            if (mainGridView.Columns["Eliminar"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Eliminar";
                btnColumn.Name = "Eliminar";
                btnColumn.Text = "Eliminar";
                btnColumn.UseColumnTextForButtonValue = true;
                mainGridView.Columns.Add(btnColumn);
            }
            if (mainGridView.Columns["Actualizar"] == null)
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Actualizar";
                btnColumn.Name = "Actualizar";
                btnColumn.Text = "Actualizar";
                btnColumn.UseColumnTextForButtonValue = true;
                mainGridView.Columns.Add(btnColumn);

            }

        }

        private void mainGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == mainGridView.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
              string selectedId = (string)mainGridView.Rows[e.RowIndex].Cells["Nombre"].Value;
                MessageBox.Show(string.Format("Hola {0}", selectedId));
                eliminarArticulo(selectedId);


            }
            if (e.ColumnIndex == mainGridView.Columns["Actualizar"].Index && e.RowIndex >= 0)
            {
                string selectedId = (string)mainGridView.Rows[e.RowIndex].Cells["Nombre"].Value;
                MessageBox.Show(string.Format("Hola {0}", selectedId));
                datosCargarActualizar(selectedId);


            }
        }
    

        public void agregarBodega(string nombre, string ubicacion)
        {
            bodegasLista.Add(new Bodegas(nombre, ubicacion));

           
        }
        public void eliminarArticulo(string nomArt)
        {

            try {
                for (int i = 0; i < inventarioCompleto.Count; i++)
                {
                    var articulo = inventarioCompleto[i];

                    if (articulo.Nombre == nomArt)
                    {
                        inventarioCompleto.RemoveAt(i);

                    }
                }
                cargarLista();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
                

        }

        //carga las variables para mostrar en el form de actualizar.
        public void datosCargarActualizar(string nomArt)
        {

            try
            {

                cargaDatosActu.Clear();
                for (int i = 0; i < inventarioCompleto.Count; i++)
                {
                    var articulo = inventarioCompleto[i];
                    if (articulo.Nombre == nomArt)
                    {


                        cargaDatosActu.Add(new inventario(articulo.Nombre, articulo.precio, articulo.Cantidad, articulo.Categoria, articulo.Bodega, articulo.NumMin, articulo.NumMax));
                        

                    }
                }
                
                ActualizarArticulo actuAr = new ActualizarArticulo(bodegasLista,cargaDatosActu);
                AddOwnedForm(actuAr);
                actuAr.ShowDialog();

               
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public void actualizarDatos(string nombre, double precio, int cantidad, string categoria, string bodega, int minimo, int maximo,string nomAnterior)
        {
            for (int i = 0; i < inventarioCompleto.Count; i++)
            {
                var articulo = inventarioCompleto[i];
                if (articulo.Nombre == nomAnterior)
                {
                    // Actualizar las propiedades del artículo existente
                    articulo.Nombre = nombre;
                    articulo.Precio = precio;
                    articulo.Cantidad = cantidad;
                    articulo.Categoria = categoria;
                    articulo.Bodega = bodega;
                    articulo.NumMin = minimo;
                    articulo.NumMax = maximo;

                    MessageBox.Show("Se ha ejecutado");
                    break; // Salir del bucle después de actualizar el artículo
                }
            }

                cargarLista();

        }


    }
}
