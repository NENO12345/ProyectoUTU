using Datos.Personas;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.PersonasVO;
using Datos.Remates;

namespace Datos.Repositorios.Usuarios
{
    public class RepoRem
    {

        public ArrayList rematadores;

        public RepoRem()
        {
            ArrayList RepoRem = new ArrayList();
        }

        public ArrayList BuscarTodos()
        {
            ArrayList rematadores = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM rematadores WHERE estado = 1";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int permiso = resultado.GetInt32(0);
                    int id = resultado.GetInt32(1);
                    string user = resultado.GetString(2);
                    string pass = resultado.GetString(3);
                    string nombre = resultado.GetString(4);
                    string apellido = resultado.GetString(5);
                    int telefono = resultado.GetInt32(6);
                    string direccion = resultado.GetString(7);
                    bool estado = resultado.GetBoolean(8);

                    rematadores.Add(new RematadorVO(permiso, id, user, pass, nombre, apellido, telefono, direccion, estado));
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
            return rematadores;
        }

        public static RematadorVO BuscarUsuario(string login)
        {

            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSqll = new MySqlCommand();


                consultaSqll.CommandText = "SELECT * FROM rematadores WHERE usuario=@login;";
                consultaSqll.Connection = conn;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al buscar el usuario");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return null;
        }

        public bool borrarUsuario(RematadorVO remVO)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE rematadores SET estado = 0 WHERE id_rematador = @id";

                MySqlCommand borrarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                borrarUsuario.Parameters.AddWithValue("@id", remVO.id);
                borrarUsuario.ExecuteScalar();

                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al eliminar el usuario");
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

        public bool agregarUsuario(RematadorVO remVO)
        {
            MySqlConnection conn = null;


            try
            {
                conn = Conexion.obtenerConexion();
                string MySQLSentence = "INSERT IGNORE INTO rematadores (id_permiso, usuario, contrasena, nombre, apellido, telefono, direccion, estado) VALUES (@permiso, @user, @pass, @nombre, @apellido, @telefono, @direccion, @estado)";

                MySqlCommand agregarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                agregarUsuario.Parameters.AddWithValue("@permiso", remVO.id);
                agregarUsuario.Parameters.AddWithValue("@user", remVO.user);
                agregarUsuario.Parameters.AddWithValue("@pass", HashPass(remVO.pass));
                agregarUsuario.Parameters.AddWithValue("@nombre", remVO.nombre);
                agregarUsuario.Parameters.AddWithValue("@apellido", remVO.apellido);
                agregarUsuario.Parameters.AddWithValue("@telefono", remVO.telefono);
                agregarUsuario.Parameters.AddWithValue("@direccion", remVO.direccion);
                agregarUsuario.Parameters.AddWithValue("@estado", remVO.estado);

                int rowsAffected = agregarUsuario.ExecuteNonQuery();
                return rowsAffected > 0;

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al agregar usuario");
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



        public bool modificarUsuario(RematadorVO remVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE rematadores SET usuario = @user, contrasena = @pass, nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion WHERE id_rematador = @id";
                MySqlCommand modificarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarUsuario.Parameters.AddWithValue("@id", remVO.id);
                modificarUsuario.Parameters.AddWithValue("@user", remVO.user);
                modificarUsuario.Parameters.AddWithValue("@pass", HashPass(remVO.pass));
                modificarUsuario.Parameters.AddWithValue("@nombre", remVO.nombre);
                modificarUsuario.Parameters.AddWithValue("@apellido", remVO.apellido);
                modificarUsuario.Parameters.AddWithValue("@telefono", remVO.telefono);
                modificarUsuario.Parameters.AddWithValue("@direccion", remVO.direccion);

                modificarUsuario.ExecuteScalar();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al modificar el usuario");
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


        public (bool, int, int) ComprobarCredenciales(RematadorVO remVO)
        {

            // Comprueba la contrasena del usuario.
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT * FROM rematadores WHERE usuario = @user AND contrasena = @pass";
                MySqlCommand modificarUsuario = new MySqlCommand(MySQLSentence, conn);

                modificarUsuario.Parameters.AddWithValue("@user", remVO.user);
                modificarUsuario.Parameters.AddWithValue("@pass", HashPass(remVO.pass));

                MySqlDataReader reader = modificarUsuario.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        bool estado = true;
                        int idPermiso = Convert.ToInt32(reader["id_permiso"]);
                        int idUsuario = Convert.ToInt32(reader["id_rematador"]);

                        return (true, idPermiso, idUsuario);
                    }
                    else
                    {
                        return (false, -1, -1);
                    }

                }
                else
                {
                    return (false, -1, -1);
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al verificar el usuario");
                return (false, -1, -1);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }


        // sin funcionar, ver para despues
        public bool ComprobarExistencia(RematadorVO remVO)
        {
            MySqlConnection conn = null;
            // Comprueba la existencia del nombre de usuario.
            try
            {

                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT COUNT(*) FROM rematadores WHERE usuario = @user";
                MySqlCommand comprobarExistencia = new MySqlCommand(MySQLSentence, conn);
                comprobarExistencia.Parameters.AddWithValue("@user", remVO.user);
                bool existe = (int)comprobarExistencia.ExecuteScalar() == 0;
                return existe;

            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error al verificar el usuario");
                return false;
            }


        }

        public static string HashPass(string variable)
        {
            // Convertir la variable en un arreglo de bytes
            byte[] variableBytes = Encoding.UTF8.GetBytes(variable);

            byte[] hashBytes = SHA256.HashData(variableBytes);

            // Convertir el hash en un string
            string hashString = BitConverter.ToString(hashBytes).Replace("-", "");

            // Devolver el hash como resultado
            return hashString;
        }

    }
}
