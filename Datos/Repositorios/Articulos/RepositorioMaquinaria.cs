using Datos.Articulos;
using Datos.Personas;
using Datos.Repositorios.Usuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios.Articulos
{
    public class RepoMaquina
    {
        public ArrayList Maquinarias;

        public RepoMaquina()
        {
            ArrayList RepoMaquina = new ArrayList();
        }

        public ArrayList BuscarTodos()
        {
            ArrayList maquinarias = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM maquinas WHERE estado_venta = false;";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int kilometraje = resultado.GetInt32(1);
                    string tipo = resultado.GetString(2);
                    string marca = resultado.GetString(3);
                    string modelo = resultado.GetString(4);
                    byte[] imagen = new byte[resultado.GetBytes(5, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(5, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(6);
                    bool disponibilidad = resultado.GetBoolean(7);
                    int id_provVO = resultado.GetInt32(8);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(9)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(9); // asigna el valor de la columna 9 a la variable
                    }
                  
                    maquinarias.Add(new MaquinariaVO(id, kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                resultado.Close(); // Aquí se vacía el buffer de registro
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conectarse a la base");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("Fin de ejecucion obtener usuario");
            return maquinarias;
        }

        public ArrayList BuscarConProv(int prov)
        {
            ArrayList maquinarias = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM maquinas WHERE estado_venta = false AND id_proveedor = @id";
                consultaSql.Parameters.AddWithValue("@id", prov);

                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int kilometraje = resultado.GetInt32(1);
                    string tipo = resultado.GetString(2);
                    string marca = resultado.GetString(3);
                    string modelo = resultado.GetString(4);
                    byte[] imagen = new byte[resultado.GetBytes(5, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(5, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(6);
                    bool disponibilidad = resultado.GetBoolean(7);
                    int id_provVO = resultado.GetInt32(8);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(9)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(9); // asigna el valor de la columna 9 a la variable
                    }

                    maquinarias.Add(new MaquinariaVO(id, kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                resultado.Close(); // Aquí se vacía el buffer de registro
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al conectarse a la base");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            Console.WriteLine("Fin de ejecucion obtener usuario");
            return maquinarias;
        }

        public ArrayList obtenerMaquinaConLote(int id_lote)
        {
            ArrayList maquinarias = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM maquinas WHERE id_lote = @lote";
                consultaSql.Connection = conn;

                consultaSql.Parameters.AddWithValue("@lote", id_lote);


                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int kilometraje = resultado.GetInt32(1);
                    string tipo = resultado.GetString(2);
                    string marca = resultado.GetString(3);
                    string modelo = resultado.GetString(4);
                    byte[] imagen = new byte[resultado.GetBytes(5, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(5, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(6);
                    bool disponibilidad = resultado.GetBoolean(7);
                    int id_provVO = resultado.GetInt32(8);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(9)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(9); // asigna el valor de la columna 9 a la variable
                    }

                    maquinarias.Add(new MaquinariaVO(id, kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                return maquinarias;
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
            Console.WriteLine("Fin ejecución obtener articulos sin paquete");
            return maquinarias;
        }


        public void asignarMaquinaALote(int idLote, int idMaquina)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE maquinas SET disponibilidad = 0,  id_lote =  @idLote WHERE id_maquina = @idMaquina";
                consultaSql.Parameters.AddWithValue("@idLote", idLote);
                consultaSql.Parameters.AddWithValue("@idMaquina", idMaquina);
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



        public ArrayList obtenerMaquinariaSinLote()
        {
            ArrayList MaquinariaObtenida = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM maquinas WHERE disponibilidad = 1";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int kilometraje = resultado.GetInt32(1);
                    string tipo = resultado.GetString(2);
                    string marca = resultado.GetString(3);
                    string modelo = resultado.GetString(4);
                    byte[] imagen = new byte[resultado.GetBytes(5, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(5, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(6);
                    bool disponibilidad = resultado.GetBoolean(7);
                    int id_provVO = resultado.GetInt32(8);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(9)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(9); // asigna el valor de la columna 9 a la variable
                    }

                    MaquinariaObtenida.Add(new MaquinariaVO(id, kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                return MaquinariaObtenida;
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
            Console.WriteLine("Fin ejecución obtener articulos sin paquete");
            return MaquinariaObtenida;
        }

        public bool agregarMaquina(MaquinariaVO maqVO)
        {
            MySqlConnection conn = null;


            try
            {
                conn = Conexion.obtenerConexion();
                string MySQLSentence = "INSERT INTO maquinas (kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_proveedor) VALUES (@kilometraje, @tipo, @marca, @modelo, @imagen, @estado, @disponibilidad, @id_proveedor)";

                MySqlCommand agregarMaquina = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                agregarMaquina.Parameters.AddWithValue("@kilometraje", maqVO.kilometraje);
                agregarMaquina.Parameters.AddWithValue("@tipo", maqVO.tipo);
                agregarMaquina.Parameters.AddWithValue("@marca", maqVO.marca);
                agregarMaquina.Parameters.AddWithValue("@modelo", maqVO.modelo);
                agregarMaquina.Parameters.AddWithValue("@imagen", maqVO.imagen);
                agregarMaquina.Parameters.AddWithValue("@estado", maqVO.estado_venta);
                agregarMaquina.Parameters.AddWithValue("@disponibilidad", maqVO.disponibilidad);
                agregarMaquina.Parameters.AddWithValue("@id_proveedor", maqVO.id_provVO);



                agregarMaquina.ExecuteNonQuery();
                return true;

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al ingresar maquina");
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

        public bool modificarMaquina(MaquinariaVO maqVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE maquinas SET kilometraje = @kilometraje, tipo = @tipo, marca = @marca, modelo = @modelo, imagen = @imagen WHERE id_maquina = @id";
                MySqlCommand modificarMaquina = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarMaquina.Parameters.AddWithValue("@id", maqVO.id);
                modificarMaquina.Parameters.AddWithValue("@kilometraje", maqVO.kilometraje);
                modificarMaquina.Parameters.AddWithValue("@tipo", maqVO.tipo);
                modificarMaquina.Parameters.AddWithValue("@marca", maqVO.marca);
                modificarMaquina.Parameters.AddWithValue("@modelo", maqVO.modelo);
                modificarMaquina.Parameters.AddWithValue("@imagen", maqVO.imagen);

                modificarMaquina.ExecuteScalar();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al modificar la maquinaria");
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

        public bool borrarMaquina(MaquinariaVO maqVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "DELETE FROM maquinas WHERE id_maquina = @id";
                MySqlCommand modificarMaquina = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarMaquina.Parameters.AddWithValue("@id", maqVO.id);

                modificarMaquina.ExecuteNonQuery();

                
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al borrar la maquinaria");
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

        public void asignarMaquinalALote(int idLote, int idMaquina)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE maquinas SET id_lote =  @idLote, disponibilidad = 0 WHERE id_maquina = @idMaquina";
                consultaSql.Parameters.AddWithValue("@idLote", idLote);
                consultaSql.Parameters.AddWithValue("@idMaquina", idMaquina);
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
            Console.WriteLine("Fin de la ejecucion asignando maquinas");
        }

        public void maquinaVendida(int id)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE maquinas SET estado_venta = 1, disponibilidad = 0 WHERE id_lote = @id";
                MySqlCommand modificarMaquina = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarMaquina.Parameters.AddWithValue("@id", id);


                modificarMaquina.ExecuteScalar();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al modificar la maquinaria");
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
