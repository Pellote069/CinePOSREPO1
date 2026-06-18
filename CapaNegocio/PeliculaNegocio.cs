using System;
using CapaData;
using CapaEntidad; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaNegocio
{
    public class PeliculaNegocio
    {
        private PeliculaDatos objDatos = new PeliculaDatos();

        public bool Insertar(Pelicula obj)
        {
            if (string.IsNullOrEmpty(obj.Titulo))
            {
                return false;
            }

            return objDatos.Insertar(obj);
        }
        public DataTable Listar()
        {
            return objDatos.Listar();

        }

        public bool Eliminar(int id)
        {
            return objDatos.Eliminar(id);

        }

        public bool Actualizar(Pelicula obj)
        {
            return objDatos.Actualizar(obj);

        }


        // esta nos servita para FormCartelera
        

    }



 
                

            
}
