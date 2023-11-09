using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.PersonasVO
{
    public class RematadorVO
    {
        public int permiso;
        public int id;
        public string user;
        public string pass;
        public string nombre;
        public string apellido;
        public int telefono;
        public string direccion;
        public bool estado;
        public bool estado_venta;
        public int idRem;
        public DateTime fecha;
        public bool finalizado;

        public RematadorVO(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, bool estado)
        {
            this.permiso = permiso;
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.estado = estado;
        }

        public RematadorVO(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, bool estado)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.estado = estado;
        }


        public RematadorVO(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public RematadorVO(string user, string pass, string nombre, string apellido, int telefono, string direccion)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public RematadorVO(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public RematadorVO(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

    }


}
