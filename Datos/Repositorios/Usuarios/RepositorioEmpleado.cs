using Datos.Personas;
using Microsoft.AspNet.Identity;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Datos.Remates;
using MySqlX.XDevAPI;

namespace Datos.Repositorios.Usuarios
{
    public class RepoEmp
    {
        public ArrayList Empleados;

        public RepoEmp()
        {
            ArrayList RepoEmp = new ArrayList();
        }

        public ArrayList BuscarTodos()
        {
            ArrayList empleados = new ArrayList();
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSql = new MySqlCommand();
                MySqlDataReader resultado;

                consultaSql.CommandText = "SELECT * FROM empleados WHERE estado = 1 ";
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
                    string puesto = resultado.GetString(8);
                    bool estado = resultado.GetBoolean(9);

                    empleados.Add(new EmpleadoVO(permiso, id, login, pass, nombre, apellido, telefono, direccion, puesto, estado));
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
            return empleados;
        }

        public static EmpleadoVO BuscarUsuario(string login)
        {

            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                MySqlCommand consultaSqll = new MySqlCommand();


                consultaSqll.CommandText = "SELECT * FROM EMPLEADOS WHERE usuario=@user;";
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


            MySqlCommand consultaSql = new MySqlCommand();

            consultaSql.CommandText = "SELECT * FROM EMPLEADOS WHERE nomEmpleado=@user;";
            consultaSql.Connection = conn;
            return null;
        }

        public bool borrarUsuario(EmpleadoVO empVO)
        {
            MySqlConnection conn = null;
            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE empleados SET estado = 0 WHERE id_empleado = @id";

                MySqlCommand borrarUsuario = new MySqlCommand(MySQLSentence, conn);

                // INDICO LOS PARAMETROS
                borrarUsuario.Parameters.AddWithValue("@id", empVO.id);
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

        public bool agregarUsuario(EmpleadoVO empVO)
        {

            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "INSERT INTO empleados (id_permiso, usuario, contrasena, nombre, apellido, telefono, direccion, puesto, estado) VALUES (@permiso, @user, @pass, @nombre, @apellido, @telefono, @direccion, @puesto, @estado)";

                MySqlCommand agregarUsuario = new MySqlCommand(MySQLSentence, conn);

                agregarUsuario.Parameters.AddWithValue("@permiso", empVO.id);
                agregarUsuario.Parameters.AddWithValue("@user", empVO.user);
                agregarUsuario.Parameters.AddWithValue("@pass", HashPass(empVO.pass));
                agregarUsuario.Parameters.AddWithValue("@nombre", empVO.nombre);
                agregarUsuario.Parameters.AddWithValue("@apellido", empVO.apellido);
                agregarUsuario.Parameters.AddWithValue("@telefono", empVO.telefono);
                agregarUsuario.Parameters.AddWithValue("@direccion", empVO.direccion);
                agregarUsuario.Parameters.AddWithValue("@puesto", empVO.puesto);
                agregarUsuario.Parameters.AddWithValue("@estado", empVO.estado);

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

        public bool modificarUsuario(EmpleadoVO empVO)
        {
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "UPDATE empleados SET id_permiso = @permiso, usuario = @user, contrasena = @pass, nombre = @nombre, apellido = @apellido, telefono = @telefono, direccion = @direccion, puesto = @puesto WHERE id_empleado = @id";
                MySqlCommand modificarUsuario = new MySqlCommand(MySQLSentence, conn);

                modificarUsuario.Parameters.AddWithValue("@permiso", empVO.permiso);
                modificarUsuario.Parameters.AddWithValue("@id", empVO.id);
                modificarUsuario.Parameters.AddWithValue("@user", empVO.user);
                modificarUsuario.Parameters.AddWithValue("@pass", HashPass(empVO.pass));
                modificarUsuario.Parameters.AddWithValue("@nombre", empVO.nombre);
                modificarUsuario.Parameters.AddWithValue("@apellido", empVO.apellido);
                modificarUsuario.Parameters.AddWithValue("@telefono", empVO.telefono);
                modificarUsuario.Parameters.AddWithValue("@direccion", empVO.direccion);
                modificarUsuario.Parameters.AddWithValue("@puesto", empVO.puesto);
                modificarUsuario.Parameters.AddWithValue("@estado", empVO.estado);

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

        public (bool, int, int) ComprobarCredenciales(EmpleadoVO empVO)
        {

            // Comprueba la contrasena del usuario.
            MySqlConnection conn = null;

            try
            {
                conn = Conexion.obtenerConexion();

                string MySQLSentence = "SELECT * FROM empleados WHERE usuario = @user AND contrasena = @pass";
                MySqlCommand verificarUsuario = new MySqlCommand(MySQLSentence, conn);

                verificarUsuario.Parameters.AddWithValue("@user", empVO.user);
                verificarUsuario.Parameters.AddWithValue("@pass", HashPass(empVO.pass));

                MySqlDataReader reader = verificarUsuario.ExecuteReader();
                if (reader.HasRows)
                {
                    if (reader.Read())
                    {
                        bool estado = true;
                        int idPermiso = Convert.ToInt32(reader["id_permiso"]);
                        int idUsuario = Convert.ToInt32(reader["id_empleado"]);

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
