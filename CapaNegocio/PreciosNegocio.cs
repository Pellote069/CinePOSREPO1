using CapaData;
using CapaEntidad;
using System;

namespace CapaNegocio
{
    public class PreciosNegocio
    {
        private CD_Precios objCD_Precios = new CD_Precios();

        public bool GuardarPrecios(PreciosPorTipo obj, out string mensaje)
        {
            mensaje = string.Empty;

            // validar los cpreicios pq no pueden ser negativos
            if (obj.PrecioAdulto < 0 || obj.PrecioNino < 0 || obj.PrecioEspecial < 0)
            {
                mensaje = "Los precios no pueden ser negativos.";
                return false;
            }

            return objCD_Precios.GuardarPrecios(obj);
        }

        
        public PreciosPorTipo ObtenerPrecios(string tipoSala)
        {
            return objCD_Precios.ObtenerPrecios(tipoSala);
        }
    }
}