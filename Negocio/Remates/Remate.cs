using Datos.PersonasVO;
using Datos.Remates;
using Datos.Repositorios.Articulos;
using Datos.Repositorios.Remates;
using Datos.Repositorios.Usuarios;
using Negocio.Articulos;
using Negocio.Personas;
using Persistencia.Repositorios.Remates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Remates
{
    public class Remate
    {
        public int id;
        public DateTime fecha;
        public int idRem;
        public bool finalizado;


        public ArrayList RemateLote = new ArrayList();

        private static RepositorioRemates repoRemate = new RepositorioRemates();

        public Remate(int id, DateTime fecha, int idRem, bool finalizado)
        {
            this.id = id;
            this.fecha = fecha;
            this.idRem = idRem;
            this.finalizado = finalizado;
        }

        public Remate(int id)
        {
            this.id = id;
        }

        public Remate(DateTime fecha, int idRem, bool finalizado)
        {
            this.fecha = fecha;
            this.idRem = idRem;
            this.finalizado = finalizado;
        }

        public static ArrayList obtenerLotesDisponibles()
        {
            ArrayList remates = new ArrayList();

            foreach (RematadorVO remVO in repoRemate.obtenerRemates())
            {
                remates.Add(new Remate(
                                                remVO.id,
                                                remVO.fecha,
                                                remVO.idRem,
                                                remVO.finalizado
                                                ));

            }

            return remates;
        }


        public static ArrayList obtenerRemates()
        {
            ArrayList remates = new ArrayList();

            foreach (RemateVO remVO in repoRemate.obtenerRemates())
            {
                remates.Add(new Remate(
                                                remVO.id,
                                                remVO.fecha,
                                                remVO.idRem,
                                                remVO.finalizado
                                                ));
            }

            return remates;
        }


        public int crearRemate(Remate rem)
        {
            return repoRemate.crearRemate(rem.toRemateVO());
        }

        public void agregarLoteARemate(Lote lote)
        {
            this.RemateLote.Add(lote);
        }

        public void modificarRemate(Remate remate)
        {
            repoRemate.modificarRemate(remate.toRemateVO());
        }

        public bool grabarRemate()
        {
            repoRemate.quitarArticulos(this.id);

            RepositorioLotes repoLote = new RepositorioLotes();
            foreach (Lote lote in this.RemateLote)
            {
                repoLote.asignarRemateALote(this.id, lote.id);
            }
            return true;

        }

        public static ArrayList obtenerRemateDisponible()
        {
            ArrayList remates = new ArrayList();

            foreach (RemateVO remVO in repoRemate.obtenerLoteSinRemate())
            {
                remates.Add(new Remate(
                                                remVO.id,
                                                remVO.fecha,
                                                remVO.idRem,
                                                remVO.finalizado));
            }

            return remates;
        }

        public void agregarMaquinaLote(Maquinaria maq)
        {
            this.RemateLote.Add(maq);
        }

        public bool grabarMaquina()
        {

            repoRemate.quitarArticulos(this.id);


            RepoMaquina repoMaquina = new RepoMaquina();
            foreach (Maquinaria maq in this.RemateLote)
            {
                repoMaquina.asignarMaquinaALote(this.id, maq.id);
            }
            return true;
        }

        public int obtenerID()
        {
            return repoRemate.obtenerID();
        }

        public void finalizar(Remate remate)
        {
            repoRemate.finalizar(remate.toRemateVO());
        }

        public RemateVO toRemateVO()
        {
            return new RemateVO(id, fecha, idRem, finalizado);
        }

        // CONVERTIR EMPLEADO VALUE OBJECT A EMPLEADO
        public RemateVO fromRemateVOtoRemate(RemateVO rematadorVO)
        {
            return new RemateVO(rematadorVO.id, rematadorVO.fecha, rematadorVO.idRem, rematadorVO.finalizado);
        }

        public bool borrarRemate(Remate rem)
        {
            return repoRemate.borrarRemate(rem.toRemateVO());
        }
    }
}
