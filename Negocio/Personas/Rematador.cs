using Datos;
using Datos.PersonasVO;
using Datos.Repositorios.Usuarios;
using System;

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Negocio.Personas
{
    public class Rematador : Usuario
    {
        private static RepoRem RepoRematador = new RepoRem();


        public override string ToString()
        {
            string formato = id + " | " + nombre + " " + apellido + " | " + telefono + " |";
            return (formato);
        }

        public Rematador(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion,  bool estado)
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

        public Rematador(int id)
        {
            this.id = id;
        }

        public Rematador(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, bool estado)
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

        public Rematador(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Rematador(string user, string pass, string nombre, string apellido, string direccion, int telefono)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public Rematador(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Rematador(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public (bool, int, int) passCorrecta(Rematador rem)
        {
            return RepoRematador.ComprobarCredenciales(rem.toUserVO());
        }
        public static ArrayList obtenerUsuariosExistentes()
        {

            ArrayList UsuariosObtenidos = new ArrayList();
            RepoRem RepoRematador = new RepoRem();

            foreach (RematadorVO remVO in RepoRematador.BuscarTodos())
            {
                UsuariosObtenidos.Add(new Rematador(
                                                  remVO.permiso,
                                                  remVO.id,
                                                  remVO.user,
                                                  remVO.pass,
                                                  remVO.nombre,
                                                  remVO.apellido,
                                                  Convert.ToInt32(remVO.telefono),
                                                  remVO.direccion,
                                                  remVO.estado
                                                  ));
            }
            return UsuariosObtenidos;
        }

        public bool borrarUsuario(Rematador rem)
        {
            return RepoRematador.borrarUsuario(rem.toUserVO());
        }

        public bool agregarUsuario(Rematador rem)
        {

            return RepoRematador.agregarUsuario(rem.toUserVO());

        }

        public bool modificarUsuario(Rematador rem)
        {
            return RepoRematador.modificarUsuario(rem.toUserVO());
        }


        // CONVERTIR REMATADOR A VALUE OBJECT
        public RematadorVO toUserVO()
        {
            return new RematadorVO(permiso, id, user, pass, nombre, apellido, telefono, direccion, estado);
        }


        // CONVERTIR REMATADOR VALUE OBJECT A REMATADOR
        public Rematador fromVoToUser(RematadorVO remVO)
        {
            return new Rematador(remVO.permiso, remVO.id, remVO.user, remVO.pass, remVO.nombre, remVO.apellido, remVO.telefono, remVO.direccion, remVO.estado);
        }

    }
}
