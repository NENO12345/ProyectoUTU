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

namespace Programacion_Login.Administrar_Remates
{
    public partial class frmHistorialRemates : Form
    {
        public frmHistorialRemates()
        {
            InitializeComponent();
        }

        public int idRemate { get; set; }
        public int idRematador { get; set; }
        private void frmHistorialRemates_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void cargoGrilla()
        {
            this.dataGridView1.Rows.Clear();

            foreach (Lote lote in Lote.obtenerLoteConRemate(idRemate)) // CAMBIAR A OBTENER LOTES DE ANIMALES Y DE MAQUINARIA RESPECTIVAMENTE
            {
                this.dataGridView1.Rows.Add(lote.id, lote.categoria, lote.precio_base, lote.precio_final);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
