using Datos.PersonasVO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Datos.Personas;
using Datos.Remates;

namespace Datos.Repositorios.Usuarios
{
    public class RepoProv
    {
        public ArrayList proveedores;

        public RepoProv()
        {
            ArrayList RepoProv = new ArrayList();
        }

        public ArrayList BuscarTodos()
        {
            ArrayList proveedores = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM proveedores WHERE estado = 1";
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
                    string correo = resultado.GetString(8);
                    string empresa = resultado.GetString(9);
                    bool estado = resultado.GetBoolean(10);

                    proveedores.Add(new ProveedorVO(permiso, id, user, pass, nombre, apellido, telefono, direccion, correo, empresa, estado));
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
            return proveedores;
        }

        public static ProveedorVO BuscarUsuario(string login)
        {

            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSqll = new MySqlCommand();


                consultaSqll.CommandText = "SELECT * FROM proveedores WHERE usuario=@login;";
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

        public bool borrarUsuario(ProveedorVO provVO)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE proveedores SET estado = 0 WHERE id_proveedor = @id";

                MySqlCommand borrarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                borrarUsuario.Parameters.AddWithValue("@id", provVO.id);
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

        public bool agregarUsuario(ProveedorVO provVO)
        {
            MySqlConnection conn = null;


            try
            {
                conn = Conexion.obtenerConexion();
                string MySQLSentence = "INSERT IGNORE INTO proveedores (id_permiso, usuario, contrasena, nombre, apellido, telefono, direccion, email, empresa, estado) VALUES (@permiso, @user, @pass, @nombre, @apellido, @telefono, @direccion, @email, @empresa, @estado)";

                MySqlCommand agregarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                agregarUsuario.Parameters.AddWithValue("@permiso", provVO.permiso);
                agregarUsuario.Parameters.AddWithValue("@user", provVO.user);
                agregarUsuario.Parameters.AddWithValue("@pass", HashPass(provVO.pass));
                agregarUsuario.Parameters.AddWithValue("@nombre", provVO.nombre);
                agregarUsuario.Parameters.AddWithValue("@apellido", provVO.apellido);
                agregarUsuario.Parameters.AddWithValue("@telefono", provVO.telefono);
                agregarUsuario.Parameters.AddWithValue("@direccion", provVO.direccion);
                agregarUsuario.Parameters.AddWithValue("@email", provVO.correo);
                agregarUsuario.Parameters.AddWithValue("@empresa", provVO.empresa);
                agregarUsuario.Parameters.AddWithValue("@estado", provVO.estado);


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



        public bool modificarUsuario(ProveedorVO provVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE proveedores SET usuario = @user, contrasena = @pass, nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion, email = @email, empresa = @empresa WHERE id_proveedor = @id";
                MySqlCommand modificarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                modificarUsuario.Parameters.AddWithValue("@id", provVO.id);
                modificarUsuario.Parameters.AddWithValue("@user", provVO.user);
                modificarUsuario.Parameters.AddWithValue("@pass", HashPass(provVO.pass));
                modificarUsuario.Parameters.AddWithValue("@nombre", provVO.nombre);
                modificarUsuario.Parameters.AddWithValue("@apellido", provVO.apellido);
                modificarUsuario.Parameters.AddWithValue("@telefono", provVO.telefono);
                modificarUsuario.Parameters.AddWithValue("@direccion", provVO.direccion);
                modificarUsuario.Parameters.AddWithValue("@email", provVO.correo);
                modificarUsuario.Parameters.AddWithValue("@empresa", provVO.empresa);

                modificarUsuario.ExecuteNonQuery();
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


        public (bool, int, int) ComprobarCredenciales(ProveedorVO provVO)
        {

            // Comprueba la contrasena del usuario.
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT * FROM proveedores WHERE usuario = @user AND contrasena = @pass";
                MySqlCommand verificarUsuario = new MySqlCommand(MySQLSentence, conn);

                verificarUsuario.Parameters.AddWithValue("@user", provVO.user);
                verificarUsuario.Parameters.AddWithValue("@pass", HashPass(provVO.pass));

                MySqlDataReader reader = verificarUsuario.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        bool estado = true;
                        int idPermiso = Convert.ToInt32(reader["id_permiso"]);
                        int idUsuario = Convert.ToInt32(reader["id_proveedor"]);

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
        public bool ComprobarExistencia(ProveedorVO provVO)
        {
            MySqlConnection conn = null;
            // Comprueba la existencia del nombre de usuario.
            try
            {

                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT COUNT(*) FROM proveedores WHERE pr_user = @user";
                MySqlCommand comprobarExistencia = new MySqlCommand(MySQLSentence, conn);
                comprobarExistencia.Parameters.AddWithValue("@pr_login", provVO.user);
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
