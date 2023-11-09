using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.PagosVO
{
    public class AbonoVO
    {
        public int id;
        public int id_rematador;
        public int id_empleado;
        public int monto;
        public string tipoPago;
        public string infoPago;
        public bool estadoPago;
        public DateTime fecha;


        public AbonoVO(int id, int id_rematador, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id = id;
            this.id_rematador = id_rematador;
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public AbonoVO(int id_rematador, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_rematador = id_rematador;
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public AbonoVO(int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public AbonoVO(int id)
        {
            this.id = id;
        }

    }
}
