using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Security.Cryptography;

public class CD_Asientos
{
    Conexion conexion = new Conexion();

    public List<Asiento> ListarAsientosPorSala(int idSala)// este metodo devuelve una lista de objetos tipo asiento(capaentidad) 
    {
        List<Asiento> lista = new List<Asiento>();

        using(SQLiteConnection con = conexion.CrearConexion())
        {
            string query = "SELECT ID_Asiento, ID_Sala, Fila, Numero, Estado FROM Asientos WHERE ID_Sala = @idSala ORDER BY Fila, Numero";
            SQLiteCommand cmd = new SQLiteCommand(query, con);

            cmd.Parameters.AddWithValue("@idSala", idSala);

            con.Open();

            using(SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    lista.Add(new Asiento()
                    {
                        ID_Asiento = Convert.ToInt32(reader["ID_Asiento"]),
                        ID_Sala = Convert.ToInt32(reader["ID_Sala"]),
                        Fila = reader["Fila"].ToString(),
                        Numero = Convert.ToInt32(reader["Numero"]),
                        Estado = Convert.ToInt32(reader["Estado"])
                    });

                }
            }

        }
        return lista;
        
    }

    public bool ActualizarEstadoAsiento(int idAsiento, int nuevoEstado)
    {
        using(SQLiteConnection con = conexion.CrearConexion())
        {
            string query = "UPDATE Asientos SET Estado = @estado WHERE ID_Asiento = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, con);
            cmd.Parameters.AddWithValue("@estado", nuevoEstado);
            cmd.Parameters.AddWithValue("@id", idAsiento);

            con.Open();

            return cmd.ExecuteNonQuery() > 0;
        }
    }


}