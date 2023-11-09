using Datos.Remates;
using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Repositorios.Remates
{
    public class RepositorioRemates
    {
        public ArrayList obtenerRemates()
        {
            ArrayList remates = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM remates";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    DateTime fecha = resultado.GetDateTime(1);
                    int idRem = resultado.GetInt32(2);
                    bool finalizado = resultado.GetBoolean(3);
                    remates.Add(new RemateVO(id, fecha, idRem, finalizado));

                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conextarce a la base");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
            Console.WriteLine("Fin ejecución obtener usuario");
            return remates;
        }

        public ArrayList obtenerLoteSinRemate()
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM remates WHERE venta = 0 AND id_remate IS NULL";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    string categoria = resultado.GetString(1);
                    int precio_base = resultado.GetInt32(2);
                    int cantidad = resultado.GetInt32(3);
                    int id_rematador = resultado.IsDBNull(4) ? -1 : resultado.GetInt32(4);
                    int id_remate = resultado.IsDBNull(5) ? -1 : resultado.GetInt32(5);
                    int id_empleado = resultado.GetInt32(6);
                    lotes.Add(new LoteVO(id, categoria, precio_base, cantidad, id_rematador, id_remate, id_empleado, 0));
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conextarce a la base");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
            Console.WriteLine("Fin ejecución obtener usuario");
            return lotes;
        }

        public void quitarArticulos(int idPaquete)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE lotes SET id_remate = null, disponibilidad = 1 WHERE id_remate = @id_remate";
                consultaSql.Parameters.AddWithValue("@id_remate", idPaquete);
                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conectarse a la base de datos");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
            Console.WriteLine("Fin ejecución quitar articulos del paquete");

        }


        public int crearRemate(RemateVO remVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "INSERT INTO remates(fecha, id_rematador) VALUES (@fecha, @rematador)";

                consultaSql.Parameters.AddWithValue("@fecha", remVO.fecha);
                consultaSql.Parameters.AddWithValue("@rematador", remVO.idRem);
                consultaSql.Connection = conn;
                consultaSql.ExecuteNonQuery();
                long idLote = consultaSql.LastInsertedId;
                int x = Convert.ToInt32(idLote);
                return x;
                
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al crear lote");
                return -1;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void modificarRemate(RemateVO remate)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE remates SET fecha = @fecha, id_rematador = @idRem WHERE id_remate = @id";
                consultaSql.Parameters.AddWithValue("@id", remate.id);
                consultaSql.Parameters.AddWithValue("@fecha", remate.fecha);
                consultaSql.Parameters.AddWithValue("@idRem", remate.idRem);



                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conetarse con la base de datos");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public int obtenerID()
        {
            MySqlConnection conn = null;
            int maxId = 0;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                consultaSql.CommandText = "SELECT COALESCE (MAX (id_lote), 0) FROM lotes";
                consultaSql.Connection = conn;
                maxId = Convert.ToInt32(consultaSql.ExecuteScalar());
                maxId++;
            }
            catch (Exception ex)
            {
                // Manejar la excepción adecuadamente
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Cerrar la conexión con la base de datos
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return maxId;
        }

        public void finalizar(RemateVO remate)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE remates SET finalizado = 1 WHERE id_remate = @id";
                consultaSql.Parameters.AddWithValue("@id", remate.id);

                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conetarse con la base de datos");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }
        }

        public bool borrarRemate(RemateVO remVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "DELETE FROM remates WHERE id_remate = @id";
                MySqlCommand eliminarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                eliminarAnimal.Parameters.AddWithValue("@id", remVO.id);

                eliminarAnimal.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al borrar remate");
                return false;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
