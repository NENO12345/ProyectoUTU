using Negocio.Articulos;
using Negocio.Personas;
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
    public partial class frmAdministrarRemates : Form
    {

        Lote loteSeleccionado = new Lote();
        private bool finalizado = false;

        public frmAdministrarRemates()
        {
            InitializeComponent();
        }

        private void cargoGrilla()
        {
            this.data_grid_remates.Rows.Clear();
            foreach (Remate remate in Remate.obtenerRemates()) // CAMBIAR A OBTENER LOTES DE ANIMALES Y DE MAQUINARIA RESPECTIVAMENTE
            {
                this.data_grid_remates.Rows.Add(remate.id, remate.fecha, remate.idRem, remate.finalizado);
            }
        }
        private void frmAdministrarRemates_Load(object sender, EventArgs e)
        {
            cargoGrilla();
            this.list_lotes.Items.Clear();
            foreach (Lote lote in Lote.obtenerLoteSinRemate())
            {
                this.list_lotes.Items.Add(lote);
            }

            foreach (Rematador rem in Rematador.obtenerUsuariosExistentes())
            {
                this.cmb_rematador.Items.Add(rem);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // agregar lote al remate
        {
            if (this.list_lotes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lote primero");
            }
            else
            {
                Lote loteSeleccionado = (Lote)this.list_lotes.Items[this.list_lotes.SelectedIndex];

                this.list_remates.Items.Add(loteSeleccionado);

                this.list_lotes.Items.Remove(loteSeleccionado);

            }
        }

        private void button2_Click_1(object sender, EventArgs e) // sacar lote del remate
        {
            if (this.list_remates.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un lote primero");
            }
            else
            {
                Lote loteSeleccionado = (Lote)this.list_remates.Items[this.list_remates.SelectedIndex];

                this.list_lotes.Items.Add(loteSeleccionado);

                this.list_remates.Items.Remove(loteSeleccionado);

            }
        }

        private void data_grid_remates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list_remates.Items.Clear();
            DataGridViewRow row = this.data_grid_remates.Rows[e.RowIndex];

            this.txt_id.Text = row.Cells[0].Value.ToString();

            int id_remate = Convert.ToInt32(txt_id.Text);
            foreach (Lote lote in Lote.obtenerLoteConRemate(id_remate))
            {
                this.list_remates.Items.Add(lote);
            }
            string auxiliar = row.Cells[3].Value.ToString();

            this.finalizado = Convert.ToBoolean(auxiliar);


            if (finalizado)
            {
                btn_crear.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_finalizar.Enabled = false;
                btn_modificar.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                btn_crear.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_finalizar.Enabled = true;
                btn_modificar.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
            }

        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            try
            {


                // Convierte el ID a un entero si es necesario
                Rematador rem = (Rematador)cmb_rematador.SelectedItem;
                Remate remate = new Remate(dateTimePicker1.Value, rem.id, false);

                ArrayList ArrayRemate = new ArrayList();

                int x = remate.crearRemate(remate);
                remate.id = x;

                foreach (Lote lote in this.list_remates.Items)
                {
                    remate.agregarLoteARemate(lote);
                }

                //graba el lote en la base de datos
                remate.grabarRemate();

                MessageBox.Show("Se asignaron los articulos al lote");

                cargoGrilla();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Rematador rem = (Rematador)cmb_rematador.SelectedItem;
                Remate remate = new Remate(Convert.ToInt32(txt_id.Text), dateTimePicker1.Value, rem.id, false);

                foreach (Lote lote in this.list_remates.Items)
                {
                    remate.agregarLoteARemate(lote);
                }

                remate.grabarRemate();
                remate.modificarRemate(remate);

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_id.Text != "")
                {
                    Rematador rem = (Rematador)cmb_rematador.SelectedItem;

                    frmFinalizarRemate form = new frmFinalizarRemate();
                    form.idRemate = Convert.ToInt32(txt_id.Text);
                    form.idRematador = rem.id;
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Primero debe seleccionar un remate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un rematador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_inventario_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "")
            {
                Rematador rem = (Rematador)cmb_rematador.SelectedItem;

                frmHistorialRemates form = new frmHistorialRemates();
                form.idRemate = Convert.ToInt32(txt_id.Text);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe seleccionar un remate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirme la eliminacion del remate", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Remate rem = new Remate(Int32.Parse(txt_id.Text));
                    bool confirma = rem.borrarRemate(rem);
                    if (confirma)
                    {
                        MessageBox.Show("Remate eliminado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar Remate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
