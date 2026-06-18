using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaData
{
    public class CD_Boletos
    {
        public List<int> ListarAsientosOcupados(int idFuncion)
        {
            List<int> lista = new List<int>();
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();
                string query = "SELECT ID_Asiento FROM Boletos WHERE ID_Funcion = @idFuncion";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idFuncion", idFuncion);
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(Convert.ToInt32(dr["ID_Asiento"]));
                        }
                    }
                }
            }
            return lista;
        }
    }






}
