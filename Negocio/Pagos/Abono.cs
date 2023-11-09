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
    public class Abono
    {
        public int id;
        public int id_rematador;
        public int id_empleado;
        public int monto;
        public string tipoPago;
        public string infoPago;
        public bool estadoPago;
        public DateTime fecha;


        public Abono(int id, int id_rematador, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
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

        public Abono(int id_rematador, int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_rematador = id_rematador;
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public Abono(int id_empleado, int monto, string tipoPago, string infoPago, bool estadoPago, DateTime fecha)
        {
            this.id_empleado = id_empleado;
            this.monto = monto;
            this.tipoPago = tipoPago;
            this.infoPago = infoPago;
            this.estadoPago = estadoPago;
            this.fecha = fecha;
        }

        public Abono(int id)
        {
            this.id = id;
        }

        public bool agregarPago(Abono abono)
        {
            return RepoAbono.agregarPago(abono.toAbonoVO());
        }

        public void eliminarPago(Abono abono)
        {
            RepoAbono.eliminarPago(abono.toAbonoVO());
        }

        public void marcarPago(Abono abono)
        {
            RepoAbono.marcarPago(abono.toAbonoVO());
        }

        public static ArrayList obtenerPagosExistentes()
        {

            ArrayList PagosObtenidos = new ArrayList();
            RepoAbono repoPago = new RepoAbono();

            foreach (AbonoVO abonoVO in repoPago.obtenerPagos())
            {
                PagosObtenidos.Add(new Abono(abonoVO.id,
                                                abonoVO.id_rematador,
                                                abonoVO.id_empleado,
                                                abonoVO.monto,
                                                abonoVO.tipoPago,
                                                abonoVO.infoPago,
                                                abonoVO.estadoPago,
                                                abonoVO.fecha
                                                  ));
            }
            return PagosObtenidos;
        }

        public AbonoVO toAbonoVO()
        {
            return new AbonoVO(id, id_rematador, id_empleado, monto, tipoPago, infoPago, estadoPago, fecha);
        }

        public Abono fromVoToAbono(AbonoVO abonoVO)
        {
            return new Abono(id, id_rematador, id_empleado, monto, tipoPago, infoPago, estadoPago, fecha);
        }


    }
}
