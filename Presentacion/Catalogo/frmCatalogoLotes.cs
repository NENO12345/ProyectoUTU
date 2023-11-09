using Negocio.Remates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Login.Catalogo
{
    public partial class frmCatalogoLotes : Form
    {
        public frmCatalogoLotes()
        {
            InitializeComponent();
        }

        private int idLote = -1;
        private string tipoLote = "";

        private void frmCatalogoLotes_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void cargoGrilla()
        {
            this.data_grid_lotes.Rows.Clear();

            foreach (Lote lote in Lote.obtenerLotesDisponiblesSinRemate())
            {
                this.data_grid_lotes.Rows.Add(lote.id, lote.categoria, lote.precio_base, lote.id_empleado, lote.venta);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipoLote == "Animal")
                {
                    frmVerLote form = new frmVerLote();
                    form.idLote = idLote;
                    form.ShowDialog();
                }
                else if (tipoLote == "Maquina")
                {
                    frnVerLoteMaquina form = new frnVerLoteMaquina();
                    form.idLote = idLote;
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar un lote", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un lote", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void data_grid_lotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_lotes.Rows[e.RowIndex];
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Obten el valor de la celda en la que el usuario hizo clic
                object valorCelda = data_grid_lotes.Rows[e.RowIndex].Cells[1].Value;

                if (valorCelda != null)
                {
                    // Convierte el valor de la celda a una cadena y úsalo como necesites
                    string valorComoTexto = valorCelda.ToString();

                    tipoLote = valorComoTexto;

                    idLote = Convert.ToInt32(row.Cells[0].Value.ToString());
                }

            }
        }
    }
}
