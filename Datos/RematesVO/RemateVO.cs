using Datos.PersonasVO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Remates
{
    public class RemateVO
    {
        public int id;
        public DateTime fecha;
        public int idRem;
        public bool finalizado;

        public RemateVO(int id, DateTime fecha, int idRem)
        {
            this.id = id;
            this.fecha = fecha;
            this.idRem = idRem;
        }

        public RemateVO(int id, DateTime fecha, int idRem, bool finalizado)
        {
            this.id = id;
            this.fecha = fecha;
            this.idRem = idRem;
            this.finalizado = finalizado;
        }

    }
}
