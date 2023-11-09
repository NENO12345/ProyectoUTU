using Logica.Pagos;
using Negocio.Personas;
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
    public partial class frmAdministrarPagosRematador : Form
    {
        public frmAdministrarPagosRematador()
        {
            InitializeComponent();
        }

        public int idEmpleado { get; set; }

        private void frmAdministrarPagosRematador_Load(object sender, EventArgs e)
        {
            cargoGrilla();
            tabControl1.TabPages[0].Enabled = true;

            foreach (Rematador rem in Rematador.obtenerUsuariosExistentes())
            {
                this.cmb_rematador.Items.Add(rem);
            }
        }

        public void cargoGrilla()
        {
            this.dataGridView1.Rows.Clear();
            foreach (Abono abono in Abono.obtenerPagosExistentes())
            {
                this.dataGridView1.Rows.Add(abono.id, abono.monto, abono.tipoPago, abono.infoPago, abono.estadoPago, abono.id_rematador, abono.fecha);
            }
        }

        private void btn_paypal_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Rematador rem = (Rematador)cmb_rematador.SelectedItem;
                Abono abono = new Abono(rem.id, idEmpleado, Convert.ToInt32(txt_paypal_monto.Text), "Paypal", txt_correo.Text, false, dateTimePicker1_paypal.Value);

                bool confirma = abono.agregarPago(abono);

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
                MessageBox.Show("Primero debe seleccionar un rematador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
                    Abono abono = new Abono(Convert.ToInt32(txt_paypal_idd.Text));
                    abono.eliminarPago(abono);
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
                    Abono abono = new Abono(Convert.ToInt32(txt_paypal_idd.Text));

                    abono.marcarPago(abono);
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
