using System;
using System.Collections.Generic;
using CapaData;
using CapaEntidad;

namespace CapaNegocio
{
    public class FuncionNegocio
    {
        private CD_Funcion objCapaData = new CD_Funcion();

        public bool Insertar(Funcion obj, out string mensaje)
        {
            mensaje = string.Empty;

            //validacion para que no se creen funciones en diaas anterirores
            if (obj.FechaHora < DateTime.Now)
            {
                mensaje = "No puedes programar funciones en el pasado.";
                return false;
            }

            // 2validacion de traslape llamamos a la lista de funciones con el metodo listar y comparamos la entrada(obj.ID_Sala) con todos los ID_Sala ya presentes en la tabla funciones
            List<Funcion> listaFunciones = objCapaData.Listar();
            foreach (Funcion f in listaFunciones)
            {
                if (f.ID_Sala == obj.ID_Sala)
                {
                    DateTime inicioExistente = f.FechaHora;
                    DateTime finExistente = f.FechaHora.AddMinutes(f.Duracion);
                    DateTime inicioNuevo = obj.FechaHora;
                    DateTime finNuevo = obj.FechaHora.AddMinutes(obj.Duracion);

                    if (inicioNuevo < finExistente && finNuevo > inicioExistente)
                    {
                        mensaje = "Error: Esta sala ya tiene una función programada en ese horario.";
                        return false;
                    }
                }
            }

            // 3 insertar funcion 
            if (objCapaData.Insertar(obj))
            {
                mensaje = "Función programada exitosamente";
                return true; // ahora si retornamos true
            }
            else
            {
                mensaje = "Error al guardar en la base de datos";
                return false; // por si hay error de conecion con la base de datos
            }
        }

        public List<Funcion> Listar() // nos retorna lista de funciones existentes 
        {
            return objCapaData.Listar();

        }

        public bool Eliminar(int id)
        {
            
            return new CD_Funcion().Eliminar(id);
        }

        public Funcion ObtenerDetalle(int id)
        {
            return new CD_Funcion().ObtenerDetalle(id);
        }
        public bool Actualizar(Funcion f)
        {
            return new CD_Funcion().Actualizar(f);

        }

    }
}