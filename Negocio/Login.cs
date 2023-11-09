using Datos.Personas;
using Datos.PersonasVO;
using Microsoft.AspNet.Identity;
using Negocio.Personas;

namespace Programacion_Login.negocio
{
    public class Login
    {
       

        public Login()
        {
            
        }

        public (bool, int, int) Verificar(Usuario usr)
        {
            string var = usr.user.Substring(0, 2);
            switch (var)
            {

                // En caso de que el usuario sea un cliente.
                case "CL":
                   return VerificarCliente(usr);
                    break;
                // En caso de que el usuario sea un empleado.
                case "EM":
                    return VerificarEmpleado(usr);
                    break;
                case "PR":
                    return VerificarProveedor(usr);
                    break;
                case "RE":
                    return VerificarRematador(usr);
                    break;
                default:
                    return (false, -1, -1);
                    break;
            }
            

        }

        public (bool, int, int) VerificarCliente(Usuario usr)
        {
            Cliente clte = new Cliente(usr.user, usr.pass);

            ClienteVO clteVO = clte.toUserVO();

            Cliente usuarioRecuperado = clte.fromVoToUser(clteVO);

            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado.passCorrecta(clte);
            }
            else
            {
                return (false, -1 , -1);
            }
        }


        public (bool, int, int) VerificarEmpleado(Usuario usr)
        {
            Empleado emp = new Empleado(usr.user, usr.pass);

            EmpleadoVO empVO = emp.toUserVO();

            Empleado usuarioRecuperado = emp.fromVoToUser(empVO);

            if (usuarioRecuperado != null)
            {
                
                return usuarioRecuperado.passCorrecta(emp);
                
            }
            else
            {
                return (false, -1, -1);
            }
        }

        public (bool, int, int) VerificarProveedor(Usuario usr)
        {
            Proveedor prov = new Proveedor(usr.user, usr.pass);

            ProveedorVO provVO = prov.toUserVO();

            Proveedor usuarioRecuperado = prov.fromVoToUser(provVO);

            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado.passCorrecta(prov);

                return (false, -1, -1);
            }
            else
            {
                return (false, -1, -1);
            }
        }

        public (bool, int, int) VerificarRematador(Usuario usr)
        {
            Rematador rem = new Rematador(usr.user, usr.pass);

            RematadorVO remVO = rem.toUserVO();

            Rematador usuarioRecuperado = rem.fromVoToUser(remVO);

            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado.passCorrecta(rem);
                
            }
            else
            {
                return (false, -1, -1);
            }

        }

        private bool BuscarCliente(string user, string pass)
        {
            Cliente usr = new Cliente(user, pass);
            ClienteVO usrVO = usr.toUserVO();

            Cliente usuarioRecuperado = usr.fromVoToUser(usrVO);

            if (usuarioRecuperado != null)
            {
                if (usuarioRecuperado.passCorrecta(usr).Item1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


    }
}
