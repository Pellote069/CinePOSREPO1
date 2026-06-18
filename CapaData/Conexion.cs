using System;
using System.Data.SQLite;
using System.IO;

namespace CapaData
{
    public class Conexion
    {
        // Ruta donde el programa espera encontrar el archivo .db
        private string ObtenerRutaDB()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CinePOSdb.db");// nombre de la db
        }

        public SQLiteConnection CrearConexion()
        {
            string dbPath = ObtenerRutaDB();

            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException("No se encontró el archivo de base de datos en: " + dbPath);
            }

            // Creamos la conexión
            return new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
        }


        // metodo para probar la conexion nos devuelve true/fasle
        public bool PruebConex()
        {
            try
            {
                using (SQLiteConnection con = CrearConexion())
                {
                    con.Open();

                    using (var cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", con))// para las conexiones que abrimos siempre tenemos en cuenta las fk
                    {
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception)
            {
                //esto le indicara al form que mensaje enviar al inicio y no indicara si se abre correctamente la conexion o no 
                return false;
            }
        }
    }
}