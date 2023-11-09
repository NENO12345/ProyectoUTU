using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Personas
{
    public class Usuario
    {
        public int permiso;
        public int id;
        public string user;
        public string pass;
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public bool estado;


        // Constructor vacio
        public Usuario() 
        {
            
        }

        public Usuario(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }





    }




}
