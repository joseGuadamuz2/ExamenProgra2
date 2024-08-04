using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba2_jose1
{
    public class Bodegas
    {
        public string NombreBodega { set; get; }
        public string UbicacionBodega { set; get; }


        public Bodegas() { }
        public Bodegas(string nombreBodega, string ubicacionBodega)
        {
            NombreBodega=nombreBodega;
            UbicacionBodega=ubicacionBodega;
        }


    }
}
