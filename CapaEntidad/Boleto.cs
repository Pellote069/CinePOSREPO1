using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Boleto
    {
        public int ID_Boleto { get; set; }
        public int ID_Funcion { get; set; }

        public int ID_Asiento { get; set; }
        public bool Estado { get; set; } // 0 = esta disponile
        // 1 = esta ocupado
        public decimal Precio { get; set; } // precio guardado al venderse( este es el que se va a registrar;

        




    }
}
