using Datos.PersonasVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Articulos
{
    public class AnimalVO
    {
        public int id;
        public int peso_promedio;
        public string categoria;
        public string descripcion;
        public byte[] imagen;
        public bool estado_venta;
        public bool disponibilidad;
        public int id_provVO;
        public int id_loteVO;

        public AnimalVO(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO, int id_loteVO)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
            this.id_loteVO = id_loteVO;
        }

        public AnimalVO(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
        }

        public AnimalVO(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public AnimalVO(int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public AnimalVO(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO, int id_loteVO)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
            this.id_loteVO = id_loteVO;
        }

        public AnimalVO(int id, int peso_promedio, string categoria, string descripcion, byte[] imagen, int id_provVO)
        {
            this.id = id;
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.id_provVO = id_provVO;
        }

        public AnimalVO(int peso_promedio, string categoria, string descripcion, byte[] imagen, int id_provVO)
        {
            this.peso_promedio = peso_promedio;
            this.categoria = categoria;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.id_provVO = id_provVO;
        }

    }
}
