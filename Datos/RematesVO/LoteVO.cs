using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Articulos;

namespace Datos.Remates
{
    public class LoteVO
    {
        public int id;
        public string categoria;
        public int precio_base;
        public int cantidad;
        public int id_rematadorVO;
        public int id_remateVO;
        public int id_empleadoVO;
        public int precio_final;



        public LoteVO(int id, string categoria, int precio_base, int cantidad, int id_rematadorVO, int id_remateVO, int id_empleadoVO, int precio_final)
        {
            this.id = id;
            this.categoria = categoria;
            this.precio_base = precio_base;
            this.cantidad = cantidad;
            this.id_rematadorVO = id_rematadorVO;
            this.id_remateVO = id_remateVO;
            this.id_empleadoVO = id_empleadoVO;
            this.precio_final = precio_final;
        }
    }
}
