using Datos.PersonasVO;
using Datos.Repositorios.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Datos.Articulos
{
    public class MaquinariaVO
    {
        public int id;
        public int kilometraje;
        public string tipo;
        public string marca;
        public string modelo;
        public byte[] imagen;
        public bool estado_venta;
        public bool disponibilidad;
        public int id_provVO;
        public int id_loteVO;

        public MaquinariaVO(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO, int id_loteVO)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
            this.id_loteVO = id_loteVO;
        }

        public MaquinariaVO(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO, int id_loteVO)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
            this.id_loteVO = id_loteVO;
        }

        public MaquinariaVO(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
        }

        public MaquinariaVO(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad)
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

        public MaquinariaVO(int id, int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO)
        {
            this.id = id;
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
        }

        public MaquinariaVO(int kilometraje, string tipo, string marca, string modelo, byte[] imagen, bool estado_venta, bool disponibilidad, int id_provVO)
        {
            this.kilometraje = kilometraje;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
            this.imagen = imagen;
            this.estado_venta = estado_venta;
            this.disponibilidad = disponibilidad;
            this.id_provVO = id_provVO;
        }
    }

}
