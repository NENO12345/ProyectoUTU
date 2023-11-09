using Negocio.Remates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Login.Administrar_Remates
{
    public partial class frmFinalizarRemate : Form
    {
        ArrayList lotesVendidos = new ArrayList();
        ArrayList lotes = new ArrayList();

        public frmFinalizarRemate()
        {
            InitializeComponent();
        }

        public int idRemate { get; set; }
        public int idRematador { get; set; }

        private string categoria = "";

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            this.txt_id.Text = row.Cells[0].Value.ToString();
            this.categoria = row.Cells[1].Value.ToString();
        }


        private void frmFinalizarRemate_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();

            foreach (Lote lote in Lote.obtenerLoteConRemate(idRemate)) // CAMBIAR A OBTENER LOTES DE ANIMALES Y DE MAQUINARIA RESPECTIVAMENTE
            {
                this.dataGridView1.Rows.Add(lote.id, lote.categoria, lote.precio_base, lote.precio_final);
            }
        }

        private void btn_vendido_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                if (txt_preciofinal.Text != "")
                {

                    Lote lote = new Lote(Convert.ToInt32(txt_id.Text), (Convert.ToInt32(txt_preciofinal.Text)), categoria, idRematador);
                    lotesVendidos.Add(lote);
                    MessageBox.Show("Lote almacenado como vendido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Debe colocarle un precio final", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            foreach (Lote lote in lotesVendidos)
            {
                lote.grabarVenta(lote);
            }

            Remate remate = new Remate(idRemate);

            remate.finalizar(remate);

            MessageBox.Show("Cambios realizados con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
