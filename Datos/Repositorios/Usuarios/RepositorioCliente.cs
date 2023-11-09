using System.Collections;
using System.Text;
using System;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using Microsoft.AspNet.Identity;
using System.Data;
using Datos.Personas;

namespace Datos.Repositorios.Usuarios
{
    public class RepoClientes
    {
        public ArrayList Clientes;

        public RepoClientes()
        {
            ArrayList RepoClte = new ArrayList();
        }
        public ArrayList BuscarTodos()
        {
            ArrayList clientes = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM clientes WHERE estado = 1";
                consultaSql.Connection = conn;
                resultado = consultaSql.ExecuteReader();
                while (resultado.Read())
                {
                    int permiso = resultado.GetInt32(0);
                    int id = resultado.GetInt32(1);
                    string login = resultado.GetString(2);
                    string pass = resultado.GetString(3);
                    string nombre = resultado.GetString(4);
                    string apellido = resultado.GetString(5);
                    int telefono = resultado.GetInt32(6);
                    string direccion = resultado.GetString(7);
                    string correo = resultado.GetString(8);
                    bool estado = resultado.GetBoolean(9); 

                    clientes.Add(new ClienteVO(permiso, id, login, pass, nombre, apellido, direccion, telefono, correo, estado));
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
            return clientes;
        }

        public static ClienteVO BuscarUsuario(string login)
        {

            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSqll = new MySqlCommand();


                consultaSqll.CommandText = "SELECT * FROM CLIENTES WHERE usuario=@login";
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

        public bool borrarUsuario(ClienteVO clteVO)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE clientes SET estado = 0 WHERE id_cliente = @id_cliente";
                
                MySqlCommand borrarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                borrarUsuario.Parameters.AddWithValue("@id_cliente", clteVO.id);
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

        public bool agregarUsuario(ClienteVO clteVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "INSERT IGNORE INTO clientes (id_permiso, usuario, contrasena, nombre, apellido, telefono, direccion, email, estado) " +
                    "VALUES (@permiso, @user, @pass, @nombre, @apellido, @telefono, @direccion, @email, @estado)";

                MySqlCommand agregarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                agregarUsuario.Parameters.AddWithValue("permiso", clteVO.id);
                agregarUsuario.Parameters.AddWithValue("@user", clteVO.user);
                agregarUsuario.Parameters.AddWithValue("@pass", HashPass(clteVO.pass));
                agregarUsuario.Parameters.AddWithValue("@nombre", clteVO.nombre);
                agregarUsuario.Parameters.AddWithValue("@apellido", clteVO.apellido);
                agregarUsuario.Parameters.AddWithValue("@direccion", clteVO.direccion);
                agregarUsuario.Parameters.AddWithValue("@telefono", clteVO.telefono);
                agregarUsuario.Parameters.AddWithValue("@email", clteVO.correo);
                agregarUsuario.Parameters.AddWithValue("@estado", clteVO.estado);

                agregarUsuario.ExecuteNonQuery();
                return true;

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

        public bool modificarUsuario(ClienteVO clteVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE clientes SET usuario = @user, contrasena = @pass, nombre = @nombre, apellido = @apellido, direccion = @direccion, telefono = @telefono, email = @email WHERE id_cliente = @id";
                MySqlCommand modificarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarUsuario.Parameters.Add("@id", MySqlDbType.Int32).Value = clteVO.id;
                modificarUsuario.Parameters.Add("@user", MySqlDbType.VarChar, 50).Value = clteVO.user;
                modificarUsuario.Parameters.Add("@pass", MySqlDbType.VarChar, 64).Value = HashPass(clteVO.pass);
                modificarUsuario.Parameters.Add("@nombre", MySqlDbType.VarChar, 50).Value = clteVO.nombre;
                modificarUsuario.Parameters.Add("@apellido", MySqlDbType.VarChar, 50).Value = clteVO.apellido;
                modificarUsuario.Parameters.Add("@direccion", MySqlDbType.VarChar, 50).Value = clteVO.direccion;
                modificarUsuario.Parameters.Add("@telefono", MySqlDbType.Int32).Value = clteVO.telefono;
                modificarUsuario.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = clteVO.correo;

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


        public (bool, int, int) ComprobarCredenciales(ClienteVO clteVO)
        {

            // Comprueba la contrasena del usuario.
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT * FROM clientes WHERE usuario = @user AND contrasena = @pass";
                MySqlCommand verificarUsuario = new MySqlCommand(MySQLSentence, conn);

                verificarUsuario.Parameters.AddWithValue("@user", clteVO.user);
                verificarUsuario.Parameters.AddWithValue("@pass", HashPass(clteVO.pass));

                MySqlDataReader reader = verificarUsuario.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        bool estado = true;
                        int idPermiso = Convert.ToInt32(reader["id_permiso"]);
                        int idUsuario = Convert.ToInt32(reader["id_cliente"]);

                        return(true, idPermiso, idUsuario);
                    }
                    else
                    {
                        return (false, -1, -1);
                    }
                    // El usuario se encontró y la contraseña es correcta

                }
                else
                {
                    // El usuario no se encontró o la contraseña es incorrecta
                    return (false, -1 , -1);
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
        public bool ComprobarExistencia(ClienteVO clteVO)
        {
            MySqlConnection conn = null;
            // Comprueba la existencia del nombre de usuario.
            try
            {

                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT COUNT(*) FROM clientes WHERE cl_login = @user";
                MySqlCommand comprobarExistencia = new MySqlCommand(MySQLSentence, conn);
                comprobarExistencia.Parameters.AddWithValue("@cl_login", clteVO.user);
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