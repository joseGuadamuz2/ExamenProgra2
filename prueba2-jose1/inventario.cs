using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace prueba2_jose1
{
    public class inventario
    {
        private string nombre;
        public double precio;
        private int cantidad;
        private string categoria;
        private string bodega;
        private int numMin;
        private int numMax;

        public inventario() { }
        public inventario(string nombre, double precio, int cantidad, string categoria, string bodega, int numMin, int numMax)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.categoria = categoria;
            this.bodega = bodega;
            this.numMin = numMin;
            this.numMax = numMax;
           
        }
        public double Precio { get => precio; set => precio = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Bodega { get => bodega; set => bodega = value; }
        public int NumMin { get => numMin; set => numMin = value; }
        public int NumMax { get => numMax; set => numMax = value; }
    }
}
