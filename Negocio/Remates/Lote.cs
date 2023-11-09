using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Personas;
using Datos.Remates;
using Datos.Repositorios.Articulos;
using Datos.Repositorios.Remates;
using Microsoft.AspNet.Identity;
using Negocio.Articulos;
using Negocio.Personas;

namespace Negocio.Remates
{
    public class Lote
    {
        public int id;
        public string categoria;
        public int precio_base;
        public int cantidad;
        public int id_rematador;
        public int id_remate;
        public int id_empleado;
        public int precio_final;
        public bool venta;

        public ArrayList loteAnimal = new ArrayList();
        public ArrayList loteMaquina = new ArrayList();


        private static RepositorioLotes repoLotes = new RepositorioLotes();

        public Lote()
        {

        }

        public Lote(int id)
        {
            this.id = id;
        }

        public Lote(int id, int precio_final, string categoria, int id_rematador)
        {
            this.id = id;
            this.precio_final = precio_final;
            this.categoria = categoria;
            this.id_rematador = id_rematador;
        }

        public Lote(int id, string categoria, int precio_base, int cantidad, int id_empleado)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_empleado = id_empleado;
        }

        public Lote(int id, string categoria, int precio_base, int precio_final)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.precio_final = precio_final;
        }


        public Lote(int id, string categoria, int precio_base, int cantidad, int id_empleado, bool venta)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_empleado = id_empleado;
            this.venta = venta;
        }

        public Lote(string categoria, int precio_base, int cantidad, int id_empleado, bool venta)
        {
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_empleado = id_empleado;
            this.venta = venta;
        }

        public Lote(int id, string categoria, int precio_base, int cantidad, int id_rematador, int id_remate, int id_empleado, bool venta)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_rematador = id_rematador;
            this.id_remate = id_remate;
            this.id_empleado = id_empleado;
            this.venta = venta;
        }


        public Lote(int id, string categoria, int precio_base, int cantidad, int id_rematador, int id_remate, int id_empleado)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_rematador = id_rematador;
            this.id_remate = id_remate;
            this.id_empleado= id_empleado;
        }

        public static ArrayList obtenerLotesDisponibles()
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLoteSinRemate())
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }

        public static ArrayList obtenerLotesDisponiblesSinRemate()
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLoteDisponible())
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }


        public static ArrayList obtenerLoteConRemate(int id)
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLoteConRemate(id))
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }

        public static ArrayList obtenerLotesAnimal()
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLotesAnimal())
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }

        public static ArrayList obtenerLotes()
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLotes())
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }


        public int crearLote(Lote lote)
        {
            return repoLotes.crearLote(lote.toLoteVO());
        }

        public void agregarAnimalLote(Animal ani)
        {
            this.loteAnimal.Add(ani);
        }

        public void modificarBase(Lote lote)
        {
            repoLotes.modificarBase(lote.toLoteVO());
        }

        public bool grabarAnimal()
        {
           
            repoLotes.quitarAnimales(this.id);


            RepoAnimal repoAnimal = new RepoAnimal();
            foreach (Animal ani in this.loteAnimal)
            {
                repoAnimal.asignarAnimalALote(this.id, ani.id);
            }
            return true;
        }

        public static ArrayList obtenerLoteSinRemate()
        {
            ArrayList lotes = new ArrayList();

            foreach (LoteVO loteVO in repoLotes.obtenerLoteSinRemate())
            {
                lotes.Add(new Lote(
                                                loteVO.id,
                                                loteVO.categoria,
                                                loteVO.precio_base,
                                                loteVO.cantidad,
                                                loteVO.id_rematadorVO,
                                                loteVO.id_remateVO,
                                                loteVO.id_empleadoVO));
            }

            return lotes;
        }

        public void agregarMaquinaLote(Maquinaria maq)
        {
            this.loteMaquina.Add(maq);
        }

        public bool grabarMaquina()
        {

            repoLotes.quitarMaquinas(this.id);


            RepoMaquina repoMaquina = new RepoMaquina();
            foreach (Maquinaria maq in this.loteMaquina)
            {
                repoMaquina.asignarMaquinaALote(this.id, maq.id);
            }
            return true;
        }

        public void grabarVenta(Lote lote)
        {

            RepoAnimal repoAnimal = new RepoAnimal();
            RepoMaquina repoMaquina = new RepoMaquina();

            repoLotes.grabarVenta(lote.toLoteVO());

            if (lote.categoria == "Animal")
            {
                repoAnimal.animalVendido(lote.id);
            }
            else
            {
                repoMaquina.maquinaVendida(lote.id);

            }
            
        }

        public LoteVO toLoteVO()
        {
            return new LoteVO(id, categoria, precio_base, cantidad, id_rematador, id_remate, id_empleado, precio_final);
        }

        // CONVERTIR EMPLEADO VALUE OBJECT A EMPLEADO
        public Lote fromLoteVOtoLote(LoteVO loteVO)
        {
            return new Lote(loteVO.id, loteVO.categoria, loteVO.precio_base, loteVO.cantidad, loteVO.id_rematadorVO, loteVO.id_remateVO, loteVO.id_empleadoVO);
        }


        public override string ToString()
        {
            return (id+" | "+categoria+" | "+ precio_base +" | "+ cantidad+" | ");
        }

        public bool borrarLote(Lote lote)
        {
           return repoLotes.borrarLote(lote.toLoteVO());
        }
    }
}
