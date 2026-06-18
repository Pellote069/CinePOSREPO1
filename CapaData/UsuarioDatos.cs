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
    public class UsuarioDatos
    {
        Conexion conexion = new Conexion();

        public string ValidarLogin(string username, string paswrd)
        {
            string rol = ""; // string vacio
            
            using (SQLiteConnection oConexion = conexion.CrearConexion())
            {
                string consult = "SELECT Rol FROM Usuarios WHERE Username = @u AND Passwordd = @p";
                

                SQLiteCommand cmd = new SQLiteCommand(consult, oConexion);

                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", paswrd);

                try
                {
                    oConexion.Open();
                    object resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        rol = resultado.ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al conectar con la base de datos: " + ex.Message);
                }
            }
            return rol;
        }
    }
}