using Datos.Personas;
using Datos.Repositorios.Usuarios;
using Programacion_Login.negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Personas
{
    public class Empleado : Usuario
    {
        public string puesto;

        private static RepoEmp RepoEmpleado = new RepoEmp();

        public Empleado()
        {

        }
        public Empleado(int permiso, int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string puesto, bool estado)
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

        public Empleado(int id, string user, string pass, string nombre, string apellido, int telefono, string direccion, string puesto, bool estado)
        {
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

        public Empleado(int id, string user, string pass, string nombre, string apellido, string direccion, int telefono, string puesto)
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

        public Empleado(string user, string pass, string nombre, string apellido, string direccion, int telefono, string puesto)
        {
            this.user = user;
            this.pass = pass;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.puesto = puesto;
        }

        public Empleado(string user, string pass)
        {
            this.user = user;
            this.pass = pass;
        }

        public Empleado(int id, string user, string pass)
        {
            this.id = id;
            this.user = user;
            this.pass = pass;
        }

        public Empleado(int id)
        {
            this.id = id;
        }

        public (bool, int, int) passCorrecta(Empleado emp)
        {
            return RepoEmpleado.ComprobarCredenciales(emp.toUserVO());
        }
        public static ArrayList obtenerUsuariosExistentes()
        {

            ArrayList UsuariosObtenidos = new ArrayList();
            RepoEmp RepoEmpleado = new RepoEmp();

            foreach (EmpleadoVO empVO in RepoEmpleado.BuscarTodos())
            {
                UsuariosObtenidos.Add(new Empleado(
                                                  empVO.id,
                                                  empVO.user,
                                                  empVO.pass,
                                                  empVO.nombre,
                                                  empVO.apellido,
                                                  Convert.ToInt32(empVO.telefono),
                                                  empVO.direccion,
                                                  empVO.puesto,
                                                  empVO.estado
                                                  ));
            }
            return UsuariosObtenidos;
        }
        public bool borrarUsuario(Empleado emp)
        {
            return RepoEmpleado.borrarUsuario(emp.toUserVO());
        }

        public bool agregarUsuario(Empleado emp)
        {

            return RepoEmpleado.agregarUsuario(emp.toUserVO());

        }

        public bool modificarUsuario(Empleado emp)
        {
            return RepoEmpleado.modificarUsuario(emp.toUserVO());
        }

        // CONVERTIR EMPLEADO A VALUE OBJECT
        public EmpleadoVO toUserVO()
        {
            return new EmpleadoVO(permiso, id, user, pass, nombre, apellido, telefono, direccion, puesto, estado);
        }

        // CONVERTIR EMPLEADO VALUE OBJECT A EMPLEADO
        public Empleado fromVoToUser(EmpleadoVO empVO)
        {
            return new Empleado(empVO.permiso, empVO.id, empVO.user, empVO.pass, empVO.nombre, empVO.apellido, Convert.ToInt32(empVO.telefono), empVO.direccion, empVO.puesto, empVO.estado);
        }

    }
}
