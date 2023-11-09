using Logica.Pagos;
using Negocio.Articulos;
using Negocio.Personas;
using Negocio.Remates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Login.Administrar_pagos
{
    public partial class frmAdministrarPagoProveedor : Form
    {
        public frmAdministrarPagoProveedor()
        {
            InitializeComponent();
        }
        public int idEmpleado { get; set; }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAdministrarPagoProveedor_Load(object sender, EventArgs e)
        {
            cargoGrilla();
            tabControl1.TabPages[0].Enabled = true;

            foreach (Proveedor prov in Proveedor.obtenerUsuariosExistentes())
            {
                this.cmb_proveedor.Items.Add(prov);
            }

        }

        public void cargoGrilla()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Pago pago in Pago.obtenerPagosExistentes())
            {
                this.dataGridView1.Rows.Add(pago.id, pago.monto, pago.tipoPago, pago.infoPago, pago.estadoPago, pago.id_proveedor, pago.fecha);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            try
            {
                // URL de Google.
                string url = "https://www.paypal.com";

                // Abre el navegador web predeterminado con la URL especificada.
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la página web");
            }
        }

        private void btn_paypal_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor prov = (Proveedor)cmb_proveedor.SelectedItem;
                Pago pago = new Pago(prov.id, idEmpleado, Convert.ToInt32(txt_paypal_monto.Text), "Paypal", txt_correo.Text, false, dateTimePicker1_paypal.Value);

                bool confirma = pago.agregarPago(pago);

                if (confirma)
                {
                    MessageBox.Show("Pago ingresado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al ingresar pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un proveedor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            this.txt_paypal_idd.Text = row.Cells[0].Value.ToString();
            this.txt_paypal_monto.Text = row.Cells[1].Value.ToString();
            this.txt_correo.Text = row.Cells[3].Value.ToString();


        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirme la eliminacion del pago", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Pago pago = new Pago(Convert.ToInt32(txt_paypal_idd.Text));
                    pago.eliminarPago(pago);
                    MessageBox.Show("Se elimino el pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Se cancelo la eliminacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void lbl_marcar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResul = MessageBox.Show("Confirmar realizacion de pago", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogResul == DialogResult.Yes)
                {
                    Pago pago = new Pago(Convert.ToInt32(txt_paypal_idd.Text));

                    pago.marcarPago(pago);
                    MessageBox.Show("Pago realizado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cargoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
