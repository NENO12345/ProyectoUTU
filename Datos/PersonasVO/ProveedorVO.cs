using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.PersonasVO
{
    public class ProveedorVO
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
        public string empresa;
        public bool estado;


        public ProveedorVO(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string empresa, bool estado)
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
            this.empresa = empresa;
            this.estado = estado;
        }

        public ProveedorVO(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string empresa, bool estado)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.empresa = empresa;
            this.estado = estado;
        }

        public ProveedorVO(int id, int id1, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, string empresa)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.empresa = empresa;
        }

        public ProveedorVO(string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, string empresa)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
            this.empresa = empresa;
        }

        public ProveedorVO(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public ProveedorVO(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }
    }
}
