using CapaData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaNegocio
{
    public class AsientoNegocio
    {
        private CD_Asientos objData = new CD_Asientos();

        public List<Asiento> obtenerAsientos(int idSala)
        {
            return objData.ListarAsientosPorSala(idSala);
        }

        public bool ModificarEstados(int idAsiento, int nuevoEstado)
        {
            if (idAsiento <= 0) return false;

            return objData.ActualizarEstadoAsiento(idAsiento, nuevoEstado);
        }
   
}
}
