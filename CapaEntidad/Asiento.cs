using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Asiento
    {
        public int ID_Asiento { get; set; }
        public int ID_Sala { get; set; }

        public string Fila { get; set; }

        public int Numero { get; set; }

        public int Estado { get; set; }




    }

    public class AsientoEstado : Asiento
    {
        public bool EstaOcupado { get; set; }
    }
}
