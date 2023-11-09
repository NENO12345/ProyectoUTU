using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    // CLASE ENCARGADA DE LA CONEXION CON LA BASE DE DATOS
    internal class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            try
            {
                MySqlConnection conn;
                string myConnectionString;

                myConnectionString = "server=localhost;uid=root;pwd=;database=revacunosdatabase";
                conn = new MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                return conn;
            }
            catch (MySqlException)
            {
                Console.WriteLine("Error al conectarse a la base de datos");
                return null;
            }
        }
    }
}
