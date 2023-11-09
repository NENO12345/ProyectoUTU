using Datos.Articulos;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios.Articulos
{
    public class RepoAnimal
    {
        public ArrayList Maquinarias;

        public RepoAnimal()
        {
            ArrayList RepoAnimal = new ArrayList();
        }

        public ArrayList BuscarTodos()
        {
            ArrayList animales = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM animales WHERE estado_venta = false;";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int peso_promedio = resultado.GetInt32(1);
                    string categoria = resultado.GetString(2);
                    string descripcion = resultado.GetString(3);
                    byte[] imagen = new byte[resultado.GetBytes(4, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(4, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(5);
                    bool disponibilidad = resultado.GetBoolean(6);
                    int id_provVO = resultado.GetInt32(7);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(8)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(8); // asigna el valor de la columna 9 a la variable
                    }
                    animales.Add(new AnimalVO(id, peso_promedio, categoria, descripcion, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
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
            return animales;
        }

        public ArrayList BuscarProv(int prov)
        {
            ArrayList animales = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM animales WHERE estado_venta = 0 AND id_proveedor = @idProv";
                consultaSql.Connection = conn;
                consultaSql.Parameters.AddWithValue("@idProv", prov);
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int peso_promedio = resultado.GetInt32(1);
                    string categoria = resultado.GetString(2);
                    string descripcion = resultado.GetString(3);
                    byte[] imagen = new byte[resultado.GetBytes(4, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(4, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(5);
                    bool disponibilidad = resultado.GetBoolean(6);
                    int id_provVO = resultado.GetInt32(7);
                    int id_loteVO = 0; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(8)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(8); // asigna el valor de la columna 9 a la variable
                    }
                    animales.Add(new AnimalVO(id, peso_promedio, categoria, descripcion, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
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
            return animales;
        }

        public void asignarAnimalALote(int idLote, int idAnimal)
        {
            MySqlConnection conn = null;
            try
            {

                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();

                consultaSql.CommandText = "UPDATE animales SET disponibilidad = 0,  id_lote =  @idLote WHERE id_animal = @idAnimal";
                consultaSql.Parameters.AddWithValue("@idLote", idLote);
                consultaSql.Parameters.AddWithValue("@idAnimal", idAnimal);
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




        public ArrayList obtenerAnimalSinLote()
        {
            ArrayList AnimalesObtenidos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM animales WHERE disponibilidad = 1";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int peso_promedio = resultado.GetInt32(1);
                    string categoria = resultado.GetString(2);
                    string descripcion = resultado.GetString(3);
                    byte[] imagen = new byte[resultado.GetBytes(4, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(4, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(5);
                    bool disponibilidad = resultado.GetBoolean(6);
                    int id_provVO = resultado.GetInt32(7);
                    int id_loteVO = -1; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(8)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(8); // asigna el valor de la columna 9 a la variable
                    }
                    AnimalesObtenidos.Add(new AnimalVO(id, peso_promedio, categoria, descripcion, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                return AnimalesObtenidos;
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
            return AnimalesObtenidos;
        }

        public ArrayList obtenerAnimalConLote(int id_lote)
        {
            ArrayList AnimalesObtenidos = new ArrayList();
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM animales WHERE id_lote = @lote";
                consultaSql.Connection = conn;

                consultaSql.Parameters.AddWithValue("@lote", id_lote);


                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int id = resultado.GetInt32(0);
                    int peso_promedio = resultado.GetInt32(1);
                    string categoria = resultado.GetString(2);
                    string descripcion = resultado.GetString(3);
                    byte[] imagen = new byte[resultado.GetBytes(4, 0, null, 0, 0)]; // crea un arreglo con el tamaño de la imagen
                    resultado.GetBytes(4, 0, imagen, 0, imagen.Length); // lee la imagen y la guarda en el arreglo
                    bool estado_venta = resultado.GetBoolean(5);
                    bool disponibilidad = resultado.GetBoolean(6);
                    int id_provVO = resultado.GetInt32(7);
                    int id_loteVO = -1; // inicializa la variable con un valor por defecto
                    if (!resultado.IsDBNull(8)) // comprueba si el valor de la columna 9 es nulo o no
                    {
                        id_loteVO = resultado.GetInt32(8); // asigna el valor de la columna 9 a la variable
                    }
                    AnimalesObtenidos.Add(new AnimalVO(id, peso_promedio, categoria, descripcion, imagen, estado_venta, disponibilidad, id_provVO, id_loteVO));
                }
                return AnimalesObtenidos;
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
            return AnimalesObtenidos;
        }



        public bool agregarAnimal(AnimalVO aniVO)
        {
            MySqlConnection conn = null;


            try
            {
                conn = Conexion.obtenerConexion();
                string MySQLSentence = "INSERT IGNORE INTO animales (peso_promedio, categoria, descripcion, imagen, estado_venta, disponibilidad, id_proveedor) VALUES (@peso, @categoria, @desc, @imagen, @estado, @disponibilidad, @id_proveedor)";

                MySqlCommand agregarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                agregarAnimal.Parameters.AddWithValue("@peso", aniVO.peso_promedio);
                agregarAnimal.Parameters.AddWithValue("@categoria", aniVO.categoria);
                agregarAnimal.Parameters.AddWithValue("@desc", aniVO.descripcion);
                agregarAnimal.Parameters.AddWithValue("@imagen", aniVO.imagen);
                agregarAnimal.Parameters.AddWithValue("@estado", aniVO.estado_venta);
                agregarAnimal.Parameters.AddWithValue("@disponibilidad", aniVO.disponibilidad);
                agregarAnimal.Parameters.AddWithValue("@id_proveedor", aniVO.id_provVO);

                int rowsAffected = agregarAnimal.ExecuteNonQuery();
                return rowsAffected > 0;

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

        public bool modificarAnimal(AnimalVO aniVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE animales SET peso_promedio = @peso, categoria = @categoria, descripcion = @desc, imagen = @imagen WHERE id_animal = @id";
                MySqlCommand modificarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarAnimal.Parameters.AddWithValue("@id", aniVO.id);
                modificarAnimal.Parameters.AddWithValue("@peso", aniVO.peso_promedio);
                modificarAnimal.Parameters.AddWithValue("@categoria", aniVO.categoria);
                modificarAnimal.Parameters.AddWithValue("@desc", aniVO.descripcion);
                modificarAnimal.Parameters.AddWithValue("@imagen", aniVO.imagen);

                modificarAnimal.ExecuteScalar();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al modificar el animal");
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

        public void animalVendido(int id)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE animales SET estado_venta = 1, disponibilidad = 0 WHERE id_lote = @id";
                MySqlCommand modificarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarAnimal.Parameters.AddWithValue("@id", id);

                modificarAnimal.ExecuteScalar();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al modificar el animal");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool borrarAnimal(AnimalVO aniVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "DELETE FROM animales WHERE id_animal = @id";
                MySqlCommand eliminarAnimal = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                eliminarAnimal.Parameters.AddWithValue("@id", aniVO.id);

                eliminarAnimal.ExecuteNonQuery();


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
    }
}
