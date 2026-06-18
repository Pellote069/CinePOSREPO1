using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaData;
using CapaEntidad;
namespace CapaNegocio
{
    public class CarteleraNegocio
    {

        private CD_Funcion objFuncion = new CD_Funcion();
        
        
        public DataTable ObtenerCartelera()
        {
            return objFuncion.ListarPeliculasConFunciones();

        }

        public List<Funcion> ObtenerHorarios(int idPelicual)
        {
            return objFuncion.ObtenerFuncionesPorPelicula(idPelicual);
        }

        public Funcion ObtenerDetallesPeicula(int idPelicual)
        {
            return objFuncion.ObtenerDetalle(idPelicual);

        }

    }
}
