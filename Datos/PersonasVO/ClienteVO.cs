using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Personas
{
    public class ClienteVO
    {
        public int permiso;
        public int id;
        public string user;
        public string pass;
        public string nombre;
        public string apellido;
        public string direccion;
        public int telefono;
        public string correo;
        public bool estado;

        public ClienteVO(int permiso, int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, bool estado)
        {
            this.permiso = permiso;
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.estado = estado;
        }

        public ClienteVO(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, bool estado)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.estado = estado;
        }


        public ClienteVO(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public ClienteVO(string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public ClienteVO(int id, string user, string pass, string tipo)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }


        public ClienteVO(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

    }
}
