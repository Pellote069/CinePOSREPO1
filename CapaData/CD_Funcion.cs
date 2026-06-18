using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaData
{
    public class CD_Funcion
    {
        // estos primeros dos metodose nos van a servir para el FormCartelera
        public List<Funcion> ObtenerFuncionesPorPelicula(int idpelicula)
        {
            List<Funcion> lista = new List<Funcion>();
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                // hacemos el el JOIN con la tabla salas para obtener Nombre y Tipo
                string query = @"SELECT F.ID_Funcion, F.ID_Pelicula, F.ID_Sala, F.FechaHora, 
                                S.Nombre as NombreSala, S.Tipo as TipoSala
                         FROM Funciones F
                         INNER JOIN Salas S ON F.ID_Sala = S.ID_Sala
                         WHERE F.ID_Pelicula = @idPelicula 
                         ORDER BY F.FechaHora ASC";

                SQLiteCommand cmd = new SQLiteCommand(query, con);
                cmd.Parameters.AddWithValue("@idPelicula", idpelicula);
                con.Open();

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new Funcion()
                        {
                            //se asignan los datos a la clase funcion
                            ID_Funcion = Convert.ToInt32(dr["ID_Funcion"]),
                            ID_Pelicula = Convert.ToInt32(dr["ID_Pelicula"]),
                            ID_Sala = Convert.ToInt32(dr["ID_Sala"]),

                            FechaHora = Convert.ToDateTime(dr["FechaHora"]),
                            
                            NombreSala = dr["NombreSala"].ToString(),
                            TipoSala = dr["TipoSala"].ToString()
                        });
                    }
                }
            }
            return lista;
        }


        public DataTable ListarPeliculasConFunciones()
        {
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                // conssulta para filtrar las pelicula scon funciones existentes
                string query = @"SELECT DISTINCT P.ID_Pelicula, P.Titulo
                         FROM Peliculas P
                         INNER JOIN Funciones F ON P.ID_Pelicula = F.ID_Pelicula
                         WHERE substr(F.FechaHora,7,4) || '-' || substr(F.FechaHora,4,2) || '-' || substr(F.FechaHora,1,2) >= date('now')";

                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public bool Eliminar(int id)
        {
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();
                string query = "DELETE FROM Funciones WHERE ID_Funcion = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }


        }   }
        public List<Funcion> Listar()
        {
            List<Funcion> lista = new List<Funcion>();

            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                try
                {
                    con.Open();
                    // le avisamos a sqlite que respecte las fk
                    new SQLiteCommand("PRAGMA foreign_keys = ON;", con).ExecuteNonQuery();

                    // consulta con join para obtenr los resultados
                    string query = @"SELECT F.ID_Funcion, F.ID_Pelicula, F.ID_Sala, F.FechaHora, 
                                            P.Titulo, P.Duracion, S.Nombre as NombreSala
                                     FROM Funciones F
                                     INNER JOIN Peliculas P ON F.ID_Pelicula = P.ID_Pelicula
                                     INNER JOIN Salas S ON F.ID_Sala = S.ID_Sala";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        using (SQLiteDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new Funcion()
                                {
                                    ID_Funcion = Convert.ToInt32(dr["ID_Funcion"]),
                                    ID_Pelicula = Convert.ToInt32(dr["ID_Pelicula"]),
                                    ID_Sala = Convert.ToInt32(dr["ID_Sala"]),
                                    NombrePelicula = dr["Titulo"].ToString(),
                                    NombreSala = dr["NombreSala"].ToString(),
                                    FechaHora = Convert.ToDateTime(dr["FechaHora"]),
                                    Duracion = Convert.ToInt32(dr["Duracion"])
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de funciones: " + ex.Message);
                }
            }
            return lista;
        }
        

        // esta funcion nos va a servir para el panel de creacion de funciones y para la carteler, para el caso de la cartelera usaremos el primer id que contenga a esa pelicula para que conincida la informacion que vamos a desplegar
        public Funcion ObtenerDetalle(int id)
        {
            Funcion obj = null;
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();
                string query = @"SELECT f.ID_Funcion, f.ID_Pelicula, f.ID_Sala, f.FechaHora, 
                         p.Titulo as NombrePelicula, p.Duracion, p.RutaImagen, 
                         p.Sinopsis, p.Clasificacion, 
                         s.Nombre as NombreSala, 
                         (SELECT COUNT(*) FROM Asientos WHERE ID_Sala = s.ID_Sala) as TotalAsientos
                         FROM Funciones f
                         INNER JOIN Peliculas p ON f.ID_Pelicula = p.ID_Pelicula
                         INNER JOIN Salas s ON f.ID_Sala = s.ID_Sala
                         WHERE f.ID_Funcion = @id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            obj = new Funcion()
                            {
                                ID_Funcion = Convert.ToInt32(dr["ID_Funcion"]),
                                ID_Pelicula = Convert.ToInt32(dr["ID_Pelicula"]),
                                ID_Sala = Convert.ToInt32(dr["ID_Sala"]),
                                FechaHora = Convert.ToDateTime(dr["FechaHora"]),
                                NombrePelicula = dr["NombrePelicula"].ToString(),
                                NombreSala = dr["NombreSala"].ToString(),
                                Duracion = Convert.ToInt32(dr["Duracion"]),
                                RutaPoster = dr["RutaImagen"].ToString(), 
                                Capacidad = Convert.ToInt32(dr["TotalAsientos"]),

                                Sinopsis = dr["Sinopsis"].ToString(),

                                Clasificacion = dr["Clasificacion"].ToString(),
                            };
                        }
                    }
                }
            }
            return obj;
        }

        public bool Actualizar(Funcion f)
        {
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                con.Open();

                string query = @"UPDATE Funciones SET 
                         ID_Pelicula = @idp, 
                         ID_Sala = @ids, 
                         FechaHora = @fecha 
                         WHERE ID_Funcion = @idf";

                using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@idp", f.ID_Pelicula);
                    cmd.Parameters.AddWithValue("@ids", f.ID_Sala);

                    cmd.Parameters.AddWithValue("@fecha", f.FechaHora);

                    cmd.Parameters.AddWithValue("@idf", f.ID_Funcion);




                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }



        public bool Insertar(Funcion obj)
        {
            bool repueta = false;
            
            using (SQLiteConnection con = new Conexion().CrearConexion())
            {
                try
                {
                    con.Open();
                    new SQLiteCommand("PRAGMA foreign_keys = ON;", con).ExecuteNonQuery();
                    string query = @"INSERT INTO Funciones (ID_Pelicula, ID_Sala, FechaHora) 
                             VALUES (@IDPelicula, @IDSala, @FechaHora)";


                    using (SQLiteCommand cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@IDPelicula", obj.ID_Pelicula);
                        cmd.Parameters.AddWithValue("@IDSala", obj.ID_Sala);
                        cmd.Parameters.AddWithValue("@FechaHora", obj.FechaHora.ToString("yyyy-MM-dd HH:mm:ss"));

                        repueta = cmd.ExecuteNonQuery() > 0;


                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error al insertar la funcion" + ex.Message);
                }
            }
            return repueta;


        }
    }
}