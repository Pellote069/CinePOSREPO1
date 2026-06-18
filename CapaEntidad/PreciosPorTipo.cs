using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PreciosPorTipo
    {
        public string TipoSala { get; set; }

        public decimal PrecioAdulto { get; set; }
        public decimal PrecioNino { get; set; }
        public decimal PrecioEspecial { get; set; }

    }
}
