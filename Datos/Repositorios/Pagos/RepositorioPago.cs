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
    public class RepoPago
    {
        public ArrayList obtenerPagos()
        {
            ArrayList pagos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM pagos";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id_pago = resultado.GetInt32(0);
                    int id_proveedor = resultado.GetInt32(1);
                    int id_empleado = resultado.GetInt32(2);
                    int monto = resultado.GetInt32(3);
                    string tipo_pago = resultado.GetString(4);
                    bool estado_pago = resultado.GetBoolean(5);
                    DateTime fecha = resultado.GetDateTime(6);
                    string infoPago = resultado.GetString(7);
                    pagos.Add(new PagoVO(id_pago, id_proveedor, id_empleado, monto, tipo_pago, infoPago,estado_pago, fecha));
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
            return pagos;
        }

        public static bool agregarPago(PagoVO pagoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "INSERT INTO pagos (id_proveedor, id_empleado, monto, tipo_pago, estado_pago, fecha, info_pago) VALUES (@proveedor, @empleado, @monto, @tipoPago, @estado, @fecha, @info)";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@proveedor", pagoVO.id_proveedor);
                        agregarPago.Parameters.AddWithValue("@empleado", pagoVO.id_empleado);
                        agregarPago.Parameters.AddWithValue("@monto", pagoVO.monto);
                        agregarPago.Parameters.AddWithValue("@tipoPago", pagoVO.tipoPago);
                        agregarPago.Parameters.AddWithValue("@estado", pagoVO.estadoPago);
                        agregarPago.Parameters.AddWithValue("@fecha", pagoVO.fecha);
                        agregarPago.Parameters.AddWithValue("@info", pagoVO.infoPago);


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

        public static void eliminarPago(PagoVO pagoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "DELETE FROM pagos WHERE id_pago = @id";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@id", pagoVO.id);


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

        public static void marcarPago(PagoVO pagoVO)
        {
            using (MySqlConnection conn = Conexion.obtenerConexion())
            {
                try
                {
                    string MySQLSentence = "UPDATE pagos SET estado_pago = 1 WHERE id_pago = @id";

                    using (MySqlCommand agregarPago = new MySqlCommand(MySQLSentence, conn))
                    {
                        agregarPago.Parameters.AddWithValue("@id", pagoVO.id);


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
