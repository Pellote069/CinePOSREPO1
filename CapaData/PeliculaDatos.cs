using System;
using System.Data;
using System.Data.SQLite;    
using CapaEntidad;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class PeliculaDatos
    {
        private Conexion conexion = new Conexion();


        
        public bool Insertar(Pelicula obj)
        {
            // ajustado a sqlite conexion 
            using (SQLiteConnection oConexion = conexion.CrearConexion())
            {
                string Solicit = "INSERT INTO Peliculas (Titulo, Duracion, Clasificacion, Sinopsis, RutaImagen) VALUES (@titulo, @duracion, @clasificacion, @sinopsis, @ruta)";
                // query para sqlite
                SQLiteCommand cmd = new SQLiteCommand(Solicit, oConexion);

                cmd.Parameters.AddWithValue("@titulo", obj.Titulo);
                cmd.Parameters.AddWithValue("@duracion", obj.Duracion);
                cmd.Parameters.AddWithValue("@clasificacion", obj.Clasificacion);
                cmd.Parameters.AddWithValue("@sinopsis", obj.Sinopsis);
                cmd.Parameters.AddWithValue("@ruta", obj.RutaImagen);
                oConexion.Open();

                int FilasAfectadoas = cmd.ExecuteNonQuery();

                return FilasAfectadoas > 0;
            }
        }

        public DataTable Listar()
        {
            DataTable tabla = new DataTable();

            using (SQLiteConnection oConexion = conexion.CrearConexion())
            {
                string query = "SELECT * FROM Peliculas";
                SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                oConexion.Open();
                
                //cambiamos modo lectura
                SQLiteDataReader reader = cmd.ExecuteReader();
                tabla.Load(reader);
            }
            return tabla;
        }

        public bool Eliminar(int id)
        {
            using (SQLiteConnection oConexion = conexion.CrearConexion())
            {
                string query = "DELETE FROM Peliculas WHERE ID_Pelicula = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                cmd.Parameters.AddWithValue("@id", id);


                oConexion.Open();
                int filasAfectadas = cmd.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool Actualizar(Pelicula obj)
        {
            using (SQLiteConnection oConexion = conexion.CrearConexion())
            {
                string query = "UPDATE Peliculas SET Titulo = @titulo, Duracion = @duracion, Clasificacion = @clasificacion, Sinopsis = @sinopsis, RutaImagen = @ruta WHERE ID_Pelicula = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, oConexion);

                cmd.Parameters.AddWithValue("@titulo", obj.Titulo);
                cmd.Parameters.AddWithValue("@duracion", obj.Duracion);

                cmd.Parameters.AddWithValue("@clasificacion", obj.Clasificacion);
                cmd.Parameters.AddWithValue("@sinopsis", obj.Sinopsis);
                cmd.Parameters.AddWithValue("@ruta", obj.RutaImagen);

                cmd.Parameters.AddWithValue("@id", obj.ID_Pelicula);

                oConexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}