using Datos.Articulos;
using Datos.Repositorios.Articulos;
using Negocio.Personas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio.Articulos
{
    public class Animal
    {

        public int id;
        public int peso_promedio;
        public string categoria;
        public string descripcion;
        public byte[] imagen;
        public bool estado_venta;
        public bool disponibilidad;
        public int id_prov;
        public int id_lote;

        private static RepoAnimal RepoAni = new RepoAnimal();

        public Animal(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov, int id_lote)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
            this.id_lote = id_lote;
        }

        public Animal(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
        }


        public Animal(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
        }

        public Animal(int id)
        {
            this.id = id;
        }

        public Animal(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public Animal(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public Animal(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_prov, int id_lote)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_prov = id_prov;
            this.id_lote = id_lote;
        }

        public Animal(int id, int peso_promedio, string categoria,string descripcion,  byte[] imagen, int id_prov)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.id_prov = id_prov;
        }

        public Animal(int peso_promedio, string categoria, string descripcion, byte[] imagen, int id_prov)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.id_prov = id_prov;
        }


        public static ArrayList obtenerAnimalExistente()
        {

            ArrayList AnimalObtenido = new ArrayList();
            RepoAnimal RepoAni = new RepoAnimal();

            foreach (AnimalVO aniVO in RepoAni.BuscarTodos())
            {
                AnimalObtenido.Add(new Animal(
                                                  aniVO.id,
                                                  aniVO.peso_promedio,
                                                  aniVO.categoria,
                                                  aniVO.descripcion,
                                                  aniVO.imagen,
                                                  aniVO.estado_venta,
                                                  aniVO.disponibilidad,
                                                  aniVO.id_provVO,
                                                  aniVO.id_loteVO
                                                  ));
            }
            return AnimalObtenido;
        }

        public static ArrayList obtenerAnimalConProv(int prov)
        {

            ArrayList AnimalObtenido = new ArrayList();
            RepoAnimal RepoAni = new RepoAnimal();

            foreach (AnimalVO aniVO in RepoAni.BuscarProv(prov))
            {
                AnimalObtenido.Add(new Animal(
                                                  aniVO.id,
                                                  aniVO.peso_promedio,
                                                  aniVO.categoria,
                                                  aniVO.descripcion,
                                                  aniVO.imagen,
                                                  aniVO.estado_venta,
                                                  aniVO.disponibilidad,
                                                  aniVO.id_provVO,
                                                  aniVO.id_loteVO
                                                  ));
            }
            return AnimalObtenido;
        }

        public static ArrayList obtenerAnimalSinLote()
        {
            ArrayList AnimalesObtenidos = new ArrayList();

            RepoAnimal RepoAni = new RepoAnimal();

            foreach (AnimalVO aniVO in RepoAni.obtenerAnimalSinLote())
            {
                AnimalesObtenidos.Add(new Animal(
                                                  aniVO.id,
                                                  aniVO.peso_promedio,
                                                  aniVO.categoria,
                                                  aniVO.descripcion,
                                                  aniVO.imagen,
                                                  aniVO.estado_venta,
                                                  aniVO.disponibilidad,
                                                  aniVO.id_provVO,
                                                  aniVO.id_loteVO
                                                  ));
            }

            return AnimalesObtenidos;
        }

        public static ArrayList obtenerAnimalConLote(int id_lote)
        {
            ArrayList AnimalesObtenidos = new ArrayList();

            RepoAnimal RepoAni = new RepoAnimal();

            foreach (AnimalVO aniVO in RepoAni.obtenerAnimalConLote(id_lote))
            {
                AnimalesObtenidos.Add(new Animal(
                                                  aniVO.id,
                                                  aniVO.peso_promedio,
                                                  aniVO.categoria,
                                                  aniVO.descripcion,
                                                  aniVO.imagen,
                                                  aniVO.estado_venta,
                                                  aniVO.disponibilidad,
                                                  aniVO.id_provVO,
                                                  aniVO.id_loteVO
                                                  ));
            }

            return AnimalesObtenidos;
        }

        public override string ToString()
        {
            string formato = id+" | "+categoria + " | " + peso_promedio + "KG |";
            return (formato);
        }


        // INGRESAR ANIMAL AL SISTEMA
        public bool agregarAnimal(Animal ani)
        {
            return RepoAni.agregarAnimal(ani.toUserVO());
        }

        public bool modificarAnimal(Animal ani)
        {
            return RepoAni.modificarAnimal(ani.toUserVO());
        }


        // CONVERTIR ANIMAL A VALUE OBJECT
        public AnimalVO toUserVO()
        {
            return new AnimalVO(id, peso_promedio , categoria, descripcion, imagen, estado_venta, disponibilidad, id_prov, id_lote);
        }


        // CONVERTIR ANIMAL VALUE OBJECT A ANIMAL
        public Animal fromVoToUser(AnimalVO aniVO)
        {
            return new Animal(aniVO.id, aniVO.peso_promedio, aniVO.categoria, aniVO.descripcion, aniVO.imagen, aniVO.estado_venta, aniVO.disponibilidad, aniVO.id_provVO, aniVO.id_loteVO);
        }

        public bool borrarAnimal(Animal ani)
        {
            return RepoAni.borrarAnimal(ani.toUserVO());
        }
    }
}
