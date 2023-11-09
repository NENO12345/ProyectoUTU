using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Personas
{
    public class EmpleadoVO
    {
        public int permiso;
        public int id;
        public string user;
        public string pass;
        public string nombre;
        public string apellido;
        public int telefono;
        public string direccion;
        public string correo;
        public string puesto;
        public bool estado;


        public EmpleadoVO(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string puesto, bool estado)
        {
            this.permiso = permiso;
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.puesto = puesto;
            this.estado = estado;
        }

        public EmpleadoVO(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string puesto, bool estado)
        {
            this.permiso = permiso;
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.puesto = puesto;
            this.estado = estado;
        }

        public EmpleadoVO(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string puesto, bool estado)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.puesto = puesto;
            this.estado = estado;
        }

        public EmpleadoVO(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string puesto)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.puesto = puesto;
        }

        public EmpleadoVO(string user, string pass, string nombre, string apellido, string direccion, int telefono, string puesto)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.puesto = puesto;
        }

        public EmpleadoVO(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public EmpleadoVO(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
}
