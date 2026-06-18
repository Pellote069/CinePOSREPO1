using CapaEntidad;
using System;
using System.Data.SQLite;

namespace CapaData
{
    public class CD_Precios
    {
        // metodo para el btn guardar en el form apra los precios de boetos
        public bool GuardarPrecios(PreciosPorTipo obj)
        {
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();
                // insertamos o reemplazamos en el caso de existir ya un tipo de sala ya registrado usando el TipoSala de la tabla salas 
                string query = @"INSERT OR REPLACE INTO PreciosPorTipo (TipoSala, PrecioAdulto, PrecioNino, PrecioEspecial) 
                                 VALUES (@tipo, @pAdulto, @pNino, @pEspecial)";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tipo", obj.TipoSala);
                    cmd.Parameters.AddWithValue("@pAdulto", obj.PrecioAdulto);
                    cmd.Parameters.AddWithValue("@pNino", obj.PrecioNino);
                    cmd.Parameters.AddWithValue("@pEspecial", obj.PrecioEspecial);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        
        public PreciosPorTipo ObtenerPrecios(string tipoSala)// metodo para traer los prcios para un tipo especificio 
        {
            PreciosPorTipo obj = null;
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();
                string query = "SELECT TipoSala, PrecioAdulto, PrecioNino, PrecioEspecial FROM PreciosPorTipo WHERE TipoSala = @tipo";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tipo", tipoSala);
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj = new PreciosPorTipo()
                            {

                                TipoSala = dr["TipoSala"].ToString(),

                                PrecioAdulto = Convert.ToDecimal(dr["PrecioAdulto"]),
                                PrecioNino = Convert.ToDecimal(dr["PrecioNino"]),
                                PrecioEspecial = Convert.ToDecimal(dr["PrecioEspecial"])
                            };
                        }
                    }
                }
            }
            return obj;
        }
    }
}