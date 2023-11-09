using Datos.Personas;
using Datos.Remates;
using Datos.Repositorios.Usuarios;
using Negocio.Personas;
using Persistencia.PagosVO;
using Persistencia.Repositorios.Pago;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Pagos
{
    public class Pago
    {
        public int id;
        public int id_proveedor;
        public int id_empleado;
        public int monto;
        public string tipoPago;
        public string infoPago;
        public bool estadoPago;
        public DateTime fecha;


        public Pago(int id, int id_proveedor, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id = id;
            this.id_proveedor = id_proveedor;
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public Pago(int id_proveedor, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_proveedor = id_proveedor;
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public Pago(int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public Pago(int id)
        {
            this.id = id;
        }

        public bool agregarPago(Pago pago)
        {
            return RepoPago.agregarPago(pago.toPagoVO());
        }

        public void eliminarPago(Pago pago)
        {
            RepoPago.eliminarPago(pago.toPagoVO());
        }

        public void marcarPago(Pago pago)
        {
            RepoPago.marcarPago(pago.toPagoVO());
        }

        public static ArrayList obtenerPagosExistentes()
        {

            ArrayList PagosObtenidos = new ArrayList();
            RepoPago repoPago = new RepoPago();

            foreach (PagoVO pagoVO in repoPago.obtenerPagos())
            {
                PagosObtenidos.Add(new Pago(    pagoVO.id,
                                                pagoVO.id_proveedor,
                                                pagoVO.id_empleado,
                                                pagoVO.monto,
                                                pagoVO.tipoPago,
                                                pagoVO.infoPago,
                                                pagoVO.estadoPago,
                                                pagoVO.fecha
                                                  ));
            }
            return PagosObtenidos;
        }

        public PagoVO toPagoVO()
        {
            return new PagoVO(id, id_proveedor, id_empleado, monto, tipoPago, infoPago, estadoPago, fecha);
        }

        public Pago fromVoToPago(PagoVO pagoVO)
        {
            return new Pago(id, id_proveedor, id_empleado, monto, tipoPago, infoPago,estadoPago, fecha);
        }


    }
}
