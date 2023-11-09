using Datos.Remates;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios.Remates
{
    public class RepositorioLotes
    {

        public ArrayList obtenerLotes()
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM lotes;";
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

        public ArrayList obtenerLotesAnimal()
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM lotes WHERE categoria = @Animal";
                consultaSql.Connection = conn;
                consultaSql.Parameters.AddWithValue("@Animal", "Animal");

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

        public ArrayList obtenerLoteSinRemate()
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM lotes WHERE venta = 0 AND id_remate IS NULL";
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

        public ArrayList obtenerLoteDisponible()
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM lotes WHERE venta = 0";
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

        public ArrayList obtenerLoteConRemate(int idRemate)
        {
            ArrayList lotes = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM lotes WHERE id_remate = @id";
                consultaSql.Connection = conn;
                consultaSql.Parameters.AddWithValue("@id", idRemate);
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

        public void quitarAnimales(int idLote)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE  animales SET id_lote = null, disponibilidad = 1 WHERE id_lote = @id_lote";
                consultaSql.Parameters.AddWithValue("@id_lote", idLote);
                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();
                Console.WriteLine("Se modificaron " + cantRegistrosModificados + " animales");
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

        public void quitarMaquinas(int idLote)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE  maquinas SET id_lote = null, disponibilidad = 1 WHERE id_lote = @id_lote";
                consultaSql.Parameters.AddWithValue("@id_lote", idLote);
                consultaSql.Connection = conn;
                int cantRegistrosModificados = consultaSql.ExecuteNonQuery();
                Console.WriteLine("Se modificaron " + cantRegistrosModificados + " maquinas");
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

        public int crearLote(LoteVO loteVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "INSERT INTO lotes(categoria, base, cantidad, id_empleado, venta) VALUES (@categoria, @base, @cantidad, @id_empleado, 0)";

                consultaSql.Parameters.AddWithValue("@categoria", loteVO.categoria);
                consultaSql.Parameters.AddWithValue("@base", loteVO.precio_base);
                consultaSql.Parameters.AddWithValue("@cantidad", loteVO.cantidad);
                consultaSql.Parameters.AddWithValue("@id_empleado", loteVO.id_empleadoVO);
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

        public void asignarRemateALote(int idRemate, int idLote)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE lotes SET disponibilidad = 0,  id_remate =  @idRemate WHERE id_lote = @idLote";
                consultaSql.Parameters.AddWithValue("@idLote", idLote);
                consultaSql.Parameters.AddWithValue("@idRemate", idRemate);
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
            Console.WriteLine("Fin de la ejecucion asignando animales");

        }


        public void modificarBase(LoteVO lote)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE lotes SET base = @base, cantidad = @cantidad, id_empleado = @empleado WHERE id_lote = @id";
                consultaSql.Parameters.AddWithValue("@id", lote.id);
                consultaSql.Parameters.AddWithValue("@base", lote.precio_base);
                consultaSql.Parameters.AddWithValue("@cantidad", lote.cantidad);
                consultaSql.Parameters.AddWithValue("@empleado", lote.id_empleadoVO);



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

        public void grabarVenta(LoteVO lote)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE lotes SET venta = 1, precio_final = @precio, disponibilidad = 0, id_rematador = @rematador WHERE id_lote = @id";
                consultaSql.Parameters.AddWithValue("@id", lote.id);
                consultaSql.Parameters.AddWithValue("@precio", lote.precio_final);
                consultaSql.Parameters.AddWithValue("@rematador", lote.id_rematadorVO);




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

        public bool borrarLote(LoteVO loteVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "DELETE FROM lotes WHERE id_lote = @id";
                MySqlCommand eliminarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                eliminarAnimal.Parameters.AddWithValue("@id", loteVO.id);

                eliminarAnimal.ExecuteNonQuery();


                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al borrar lote");
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
