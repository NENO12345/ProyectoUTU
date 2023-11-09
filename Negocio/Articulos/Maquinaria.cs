using Datos.Articulos;
using Datos.Personas;
using Datos.PersonasVO;
using Datos.Repositorios;
using Datos.Repositorios.Articulos;
using Microsoft.AspNet.Identity;
using Negocio.Personas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio.Articulos
{
    public class Maquinaria
    {
        public int id;
        public int kilometraje;
        public string tipo;
        public string marca;
        public string modelo;
        public byte[] imagen;
        public bool estado_venta;
        public bool disponibilidad;
        public int id_prov;
        public int id_lote;

        private static RepoMaquina RepoMaq = new RepoMaquina();

        public Maquinaria(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov, int id_lote)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
            this.id_lote = id_lote;
        }

        public Maquinaria(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov, int id_lote)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
            this.id_lote = id_lote;
        }

        public Maquinaria(int id)
        {
            this.id = id;
        }
        public Maquinaria(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public Maquinaria(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public Maquinaria(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
        }

        public Maquinaria(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
        }

        public override string ToString()
        {
            string formato = id+" | "+marca + " | " + modelo + " | " + tipo + " |";
            return (formato);
        }

        public bool Equalss(Maquinaria maq)
        {
            // Si el objeto es nulo, devuelve falso
            if (maq == null) return false;

            // Si el objeto no es del mismo tipo, devuelve falso
            if (maq.GetType() != this.GetType()) return false;

            // Convierte el objeto a Maquinaria
            Maquinaria other = (Maquinaria)maq;

            // Compara los campos o propiedades que quieras
            // Puedes usar el operador == o el método Equals, según convenga
            return this.id == other.id &&
                   this.marca == other.marca &&
                   this.modelo.Equals(other.modelo);
        }

        public static ArrayList obtenerMaquinariaExistente()
        {

            ArrayList MaquinariaObtenida = new ArrayList();
            RepoMaquina RepoMaq = new RepoMaquina();

            foreach (MaquinariaVO maqVO in RepoMaq.BuscarTodos())
            {
                MaquinariaObtenida.Add(new Maquinaria(
                                                  maqVO.id,
                                                  maqVO.kilometraje,
                                                  maqVO.tipo,
                                                  maqVO.marca,
                                                  maqVO.modelo,
                                                  maqVO.imagen,
                                                  maqVO.estado_venta,
                                                  maqVO.disponibilidad,
                                                  maqVO.id_provVO,
                                                  maqVO.id_loteVO
                                                  ));
            }
            return MaquinariaObtenida;
        }

        public static ArrayList obtenerMaquinariaConProv(int prov)
        {

            ArrayList MaquinariaObtenida = new ArrayList();
            RepoMaquina RepoMaq = new RepoMaquina();

            foreach (MaquinariaVO maqVO in RepoMaq.BuscarConProv(prov))
            {
                MaquinariaObtenida.Add(new Maquinaria(
                                                  maqVO.id,
                                                  maqVO.kilometraje,
                                                  maqVO.tipo,
                                                  maqVO.marca,
                                                  maqVO.modelo,
                                                  maqVO.imagen,
                                                  maqVO.estado_venta,
                                                  maqVO.disponibilidad,
                                                  maqVO.id_provVO,
                                                  maqVO.id_loteVO
                                                  ));
            }
            return MaquinariaObtenida;
        }

        public static ArrayList obtenerMaquinaConLote(int id_lote)
        {
            ArrayList MaquinasObtenidos = new ArrayList();

            RepoMaquina RepoMaq = new RepoMaquina();

            foreach (MaquinariaVO maqVO in RepoMaq.obtenerMaquinaConLote(id_lote))
            {
                MaquinasObtenidos.Add(new Maquinaria(
                                                  maqVO.id,
                                                  maqVO.kilometraje,
                                                  maqVO.tipo,
                                                  maqVO.marca,
                                                  maqVO.modelo,
                                                  maqVO.imagen,
                                                  maqVO.estado_venta,
                                                  maqVO.disponibilidad,
                                                  maqVO.id_provVO,
                                                  maqVO.id_loteVO
                                                  ));
            }

            return MaquinasObtenidos;
        }

        public static ArrayList obtenerMaquinariaSinLote()
        {
            ArrayList MaquinariaObtenida = new ArrayList();

            RepoMaquina repoMaquinas = new RepoMaquina();

            foreach (MaquinariaVO maqVO in repoMaquinas.obtenerMaquinariaSinLote())
            {
                MaquinariaObtenida.Add(new Maquinaria(
                                                maqVO.id,
                                                maqVO.kilometraje,
                                                maqVO.tipo,
                                                maqVO.marca,
                                                maqVO.modelo,
                                                maqVO.imagen,
                                                maqVO.estado_venta,
                                                maqVO.disponibilidad,
                                                maqVO.id_provVO,
                                                maqVO.id_loteVO));
            }

            return MaquinariaObtenida;
        }


        // INGRESAR MAQUINARIA AL SISTEMA
        public bool agregarMaquina(Maquinaria maq)
        {
            return RepoMaq.agregarMaquina(maq.toUserVO());
        }

        public bool modificarMaquina(Maquinaria maq)
        {
            return RepoMaq.modificarMaquina(maq.toUserVO());
        }

        public bool borrarMaquina(Maquinaria maq)
        {
            return RepoMaq.borrarMaquina(maq.toUserVO());
        }

        public static byte[] buscarImagen()
        {
            return null;
        }


        // CONVERTIR MAQUINARIA A VALUE OBJECT
        public MaquinariaVO toUserVO()
        {
            return new MaquinariaVO(id, kilometraje, tipo, marca, modelo, imagen, estado_venta, disponibilidad, id_prov, id_lote);
        }


        // CONVERTIR MAQUINARIA VALUE OBJECT A MAQUINARIA
        public Maquinaria fromVoToUser(MaquinariaVO maqVO)
        {
            return new Maquinaria(maqVO.id, maqVO.kilometraje, maqVO.tipo, maqVO.marca, maqVO.modelo, maqVO.imagen, maqVO.estado_venta, maqVO.disponibilidad, maqVO.id_provVO, maqVO.id_loteVO);
        }

    }
}
