using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Datos.Personas;
using Datos.Repositorios.Usuarios;

namespace Negocio.Personas
{
    public class Cliente : Usuario
    {
        public string correo;

        private static RepoClientes RepoClte = new RepoClientes();


        public Cliente(int permiso, int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, bool estado)
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

        public Cliente(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, bool estado)
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

        public Cliente(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo)
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

        public Cliente(string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }

        public Cliente(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Cliente(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public Cliente(int id)
        {
            this.id = id;
        }

        public (bool, int, int) passCorrecta(Cliente clte)
        {
            return RepoClte.ComprobarCredenciales(clte.toUserVO());
        }
        public static ArrayList obtenerUsuariosExistentes()
        {

            ArrayList UsuariosObtenidos = new ArrayList();
            RepoClientes RepoClte = new RepoClientes();

            foreach (ClienteVO clteVO in RepoClte.BuscarTodos())
            {
                UsuariosObtenidos.Add(new Cliente(
                                                  clteVO.id,
                                                  clteVO.user,
                                                  clteVO.pass,
                                                  clteVO.nombre,
                                                  clteVO.apellido,
                                                  clteVO.direccion,
                                                  Convert.ToInt32(clteVO.telefono),
                                                  clteVO.correo,
                                                  clteVO.estado
                                                  ));
            }
            return UsuariosObtenidos;
        }
        public bool borrarUsuario(Cliente clte)
        {
            return RepoClte.borrarUsuario(clte.toUserVO());
        }

        public bool agregarUsuario(Cliente clte)
        {

            return RepoClte.agregarUsuario(clte.toUserVO());

        }

        public bool modificarUsuario(Cliente clte)
        {
            return RepoClte.modificarUsuario(clte.toUserVO());
        }

        // CONVERTIR CLIENTE A VALUE OBJECT
        public ClienteVO toUserVO()
        {
            return new ClienteVO(permiso, id, user, pass, nombre, apellido, direccion, telefono, correo, estado);
        }



        // CONVERTIR CLIENTE VALUE OBJECT A CLIENTE
        public Cliente fromVoToUser(ClienteVO clteVO)
        {
            return new Cliente(clteVO.id, clteVO.user, clteVO.pass, clteVO.nombre, clteVO.apellido, clteVO.direccion, Convert.ToInt32(clteVO.telefono), clteVO.correo);
        }


        
    }
}
