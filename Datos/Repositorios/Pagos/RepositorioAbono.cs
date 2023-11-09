using Datos.Remates;
using Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.PagosVO;

namespace Persistencia.Repositorios.Pago
{
    public class RepoAbono
    {
        public ArrayList obtenerPagos()
        {
            ArrayList abonos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM abonos";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id_pago = resultado.GetInt32(0);
                    int id_rematador = resultado.GetInt32(1);
                    int id_empleado = resultado.GetInt32(2);
                    int monto = resultado.GetInt32(3);
                    string tipo_pago = resultado.GetString(4);
                    bool estado_pago = resultado.GetBoolean(5);
                    DateTime fecha = resultado.GetDateTime(6);
                    string infoPago = resultado.GetString(7);
                    abonos.Add(new AbonoVO(id_pago, id_rematador, id_empleado, monto, tipo_pago, infoPago,estado_pago, fecha));
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
            return abonos;
        }

        public static bool agregarPago(AbonoVO abonoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "INSERT INTO abonos (id_rematador, id_empleado, monto, tipo_pago, estado_pago, fecha, info_pago) VALUES (@rematador, @empleado, @monto, @tipoPago, @estado, @fecha, @info)";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@rematador", abonoVO.id_rematador);
                        agregarPago.Parameters.AddWithValue("@empleado", abonoVO.id_empleado);
                        agregarPago.Parameters.AddWithValue("@monto", abonoVO.monto);
                        agregarPago.Parameters.AddWithValue("@tipoPago", abonoVO.tipoPago);
                        agregarPago.Parameters.AddWithValue("@estado", abonoVO.estadoPago);
                        agregarPago.Parameters.AddWithValue("@fecha", abonoVO.fecha);
                        agregarPago.Parameters.AddWithValue("@info", abonoVO.infoPago);


                        int rowsAffected = agregarPago.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Error al agregar pago: " + e.Message);
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

        public static void eliminarPago(AbonoVO abonoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "DELETE FROM abonos WHERE id_abono = @id";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@id", abonoVO.id);


                        int rowsAffected = agregarPago.ExecuteNonQuery();

                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Error al agregar pago: " + e.Message);
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

        public static void marcarPago(AbonoVO abonoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "UPDATE abonos SET estado_pago = 1 WHERE id_abono = @id";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@id", abonoVO.id);


                        int rowsAffected = agregarPago.ExecuteNonQuery();

                    }
                }
                catch (MySqlException e)
                {
                    Console.WriteLine("Error al agregar pago: " + e.Message);
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
}
