using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Venta
    {
        public int ID_Detalle { get; set; }
        public int ID_Venta { get; set; }

        public int ID_Boleto { get; set; }
        public decimal PrecioUnitario { get; set; }
    }
}
