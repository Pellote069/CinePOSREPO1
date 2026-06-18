using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Funcion
    {
        public int ID_Funcion { get; set; }
        public int ID_Pelicula { get; set; }
        public int ID_Sala { get; set; }
        public DateTime FechaHora { get; set; }

        public string NombrePelicula { get; set; }
        public string NombreSala { get; set; }
        public int Duracion { get; set; }
        public string TipoSala { get; set; }
        public string RutaPoster { get; set; }
        public int Capacidad { get; set; }

        public string Sinopsis { get; set; }
        public string Clasificacion { get; set; }
        public string EstadoFuncion
        {
            get
            {
                DateTime finFuncion = FechaHora.AddMinutes(Duracion);
                if (DateTime.Now > finFuncion) return "Vencida";
                if (DateTime.Now >= FechaHora && DateTime.Now <= finFuncion) return "Corriendo";
                return "Por comenzar";




            }
        }



    }
}
