using Datos.Personas;
using Datos.PersonasVO;
using Datos.Repositorios.Usuarios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Personas
{
    public class Proveedor : Usuario
    {
        public string correo;
        public string empresa;

        private static RepoProv RepoProveedor = new RepoProv();


        public Proveedor(int permiso, int id, string user, string pass, string nombre, string apellido,  int telefono, string direccion, string correo, string empresa, bool estado)
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

        public Proveedor(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string empresa)
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
        }


        public Proveedor(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string correo, string empresa, bool estado)
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


        public Proveedor(int id, string user, string pass, string nombre, string apellido, int v, string direccion, int telefono, string correo, string empresa)
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
        }


        public Proveedor(string user, string pass, string nombre, string apellido, string direccion, int telefono, string correo, string empresa)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
            this.empresa = empresa;
        }

        public Proveedor(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Proveedor(int id, string user, string pass, string text, string text1)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public Proveedor(int id)
        {
            this.id = id;
        }


        public override string ToString()
        {
            string formato = id + " | " + nombre + " " + apellido + " | " + telefono + " |";
            return (formato);
        }

        public (bool, int, int) passCorrecta(Proveedor prov)
        {
            return RepoProveedor.ComprobarCredenciales(prov.toUserVO());
        }
        public static ArrayList obtenerUsuariosExistentes()
        {

            ArrayList UsuariosObtenidos = new ArrayList();
            RepoProv RepoProveedor = new RepoProv();

            foreach (ProveedorVO provVO in RepoProveedor.BuscarTodos())
            {
                UsuariosObtenidos.Add(new Proveedor(
                                                  provVO.permiso,
                                                  provVO.id,
                                                  provVO.user,
                                                  provVO.pass,
                                                  provVO.nombre,
                                                  provVO.apellido,
                                                  provVO.telefono,
                                                  provVO.direccion,
                                                  provVO.correo,
                                                  provVO.empresa,
                                                  provVO.estado
                                                  ));
            }
            return UsuariosObtenidos;
        }

        public static ArrayList obtenerUsuariosExistentess()
        {

            ArrayList UsuariosObtenidos = new ArrayList();
            RepoProv RepoProveedor = new RepoProv();

            foreach (ProveedorVO provVO in RepoProveedor.BuscarTodos())
            {
                UsuariosObtenidos.Add(new Proveedor(
                                                  provVO.permiso,
                                                  provVO.id,
                                                  provVO.user,
                                                  provVO.pass,
                                                  provVO.nombre,
                                                  provVO.apellido,
                                                  provVO.telefono,
                                                  provVO.direccion,
                                                  provVO.correo,
                                                  provVO.empresa,
                                                  provVO.estado
                                                  ));
            }
            return UsuariosObtenidos;
        }

        
        public bool borrarUsuario(Proveedor prov)
        {
            return RepoProveedor.borrarUsuario(prov.toUserVO());
        }

        public bool agregarUsuario(Proveedor prov)
        {

            return RepoProveedor.agregarUsuario(prov.toUserVO());

        }

        public bool modificarUsuario(Proveedor prov)
        {
            return RepoProveedor.modificarUsuario(prov.toUserVO());
        }


        // CONVERTIR PROVEEDOR A VALUE OBJECT
        public ProveedorVO toUserVO()
        {
            return new ProveedorVO(permiso, id, user, pass, nombre, apellido, telefono, direccion, correo, empresa, estado);
        }


        // CONVERTIR PROVEEDOR VALUE OBJECT A PROVEEDOR
        public Proveedor fromVoToUser(ProveedorVO provVO)
        {
            return new Proveedor(provVO.permiso, provVO.id, provVO.user, provVO.pass, provVO.nombre, provVO.apellido, provVO.telefono, provVO.direccion,  provVO.correo, provVO.empresa, provVO.estado);
        }


    }
}
