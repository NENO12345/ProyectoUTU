using com.sun.corba.se.impl.protocol.giopmsgheaders;
using Negocio.Articulos;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace Programacion_Login.Administrar_remates
{
    public partial class frmAdministrarLotes : Form
    {

        Lote loteSeleccionado = new Lote();

        public frmAdministrarLotes()
        {
            InitializeComponent();
        }

        private void cargoGrilla()
        {
            this.data_grid_lotesAnimal.Rows.Clear();
            foreach (Lote lote in Lote.obtenerLotesAnimal()) // CAMBIAR A OBTENER LOTES DE ANIMALES Y DE MAQUINARIA RESPECTIVAMENTE
            {
                this.data_grid_lotesAnimal.Rows.Add(lote.id, lote.categoria, lote.precio_base, lote.id_empleado, lote.venta);
            }

            this.data_grid_lotesMaquina.Rows.Clear();
            foreach (Lote lote in Lote.obtenerLotes())
            {
                this.data_grid_lotesMaquina.Rows.Add(lote.id, lote.categoria, lote.precio_base, lote.id_empleado, lote.venta);
            }
        }

        private void frmAdministrarLotes_Load(object sender, EventArgs e)
        {
            this.list_animales.Items.Clear();
            cargoGrilla();
            foreach (Animal ani in Animal.obtenerAnimalSinLote())
            {
                this.list_animales.Items.Add(ani);
            }

            this.list_maquinas.Items.Clear();
            foreach (Maquinaria maq in Maquinaria.obtenerMaquinariaSinLote())
            {
                this.list_maquinas.Items.Add(maq);
            }
        }

        private void data_grid_lotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_lotesAnimal.Rows[e.RowIndex];
            this.txt_idLoteAnimal.Text = row.Cells[0].Value.ToString();
            this.txt_baseAnimal.Text = row.Cells[2].Value.ToString();


            int id_lote = Convert.ToInt32(txt_idLoteAnimal.Text);
            foreach (Animal ani in Animal.obtenerAnimalConLote(id_lote))
            {
                this.list_loteAnimal.Items.Add(ani);
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.list_animales.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un animal primero");
            }
            else
            {
                Animal animalSeleccionado = (Animal)this.list_animales.Items[this.list_animales.SelectedIndex];

                this.list_loteAnimal.Items.Add(animalSeleccionado);

                this.list_animales.Items.Remove(animalSeleccionado);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.list_loteAnimal.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un animal primero");
            }
            else
            {
                Animal animalSeleccionado = (Animal)this.list_loteAnimal.Items[this.list_loteAnimal.SelectedIndex];

                this.list_animales.Items.Add(animalSeleccionado);

                this.list_loteAnimal.Items.Remove(animalSeleccionado);

            }
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            {
                try
                {


                    ArrayList ArrayLote = new ArrayList();

                    ArrayLote.AddRange(list_loteAnimal.Items);

                    int cantidadLote = ArrayLote.Count;

                    Lote lote = new Lote("Animal", Int32.Parse(this.txt_baseAnimal.Text), cantidadLote, 0, false);


                    int x = lote.crearLote(lote);
                    lote.id = x;

                    foreach (Animal ani in this.list_loteAnimal.Items)
                    {
                        lote.agregarAnimalLote(ani);
                    }

                    //graba el paquete en la base de datos
                    lote.grabarAnimal();

                    MessageBox.Show("Se asignaron los articulos al lote");

                    cargoGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void btn_agregarMaquina_Click(object sender, EventArgs e)
        {
            if (this.list_maquinas.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un animal primero");
            }
            else
            {
                Maquinaria maqSeleccionada = (Maquinaria)this.list_maquinas.Items[this.list_maquinas.SelectedIndex];

                this.list_loteMaquina.Items.Add(maqSeleccionada);

                this.list_maquinas.Items.Remove(maqSeleccionada);
            }
        }

        private void btn_sacarMaquina_Click(object sender, EventArgs e)
        {
            if (this.list_loteMaquina.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un animal primero");
            }
            else
            {
                Maquinaria maqSeleccionada = (Maquinaria)this.list_loteMaquina.Items[this.list_loteMaquina.SelectedIndex];

                this.list_maquinas.Items.Add(maqSeleccionada);

                this.list_loteMaquina.Items.Remove(maqSeleccionada);
            }
        }

        private void btn_guardar_loteMaquina_Click(object sender, EventArgs e)

        {
            {
                try
                {
                    Lote lote = new Lote();

                    ArrayList ArrayLote = new ArrayList();

                    ArrayLote.AddRange(list_loteMaquina.Items);

                    int cantidadLote = ArrayLote.Count;

                    lote = new Lote("Maquina", Int32.Parse(this.txt_baseMaquina.Text), cantidadLote, 0, false);


                    int x = lote.crearLote(lote);
                    lote.id = x;

                    foreach (Maquinaria maq in this.list_loteMaquina.Items)
                    {
                        lote.agregarMaquinaLote(maq);
                    }

                    //graba el paquete en la base de datos
                    lote.grabarMaquina();

                    MessageBox.Show("Se asignaron los articulos al lote");

                    cargoGrilla();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }

        private void btn_modificar_animal_Click(object sender, EventArgs e)
        {
            try
            {
                Lote lote = new Lote();

                ArrayList ArrayLote = new ArrayList();

                ArrayLote.AddRange(list_loteAnimal.Items);

                int cantidadLote = ArrayLote.Count;

                lote = new Lote(Int32.Parse(txt_idLoteAnimal.Text), "Animal", Int32.Parse(this.txt_baseAnimal.Text), cantidadLote, 0);


                foreach (Animal ani in this.list_loteAnimal.Items)
                {
                    lote.agregarAnimalLote(ani);
                }

                //graba el paquete en la base de datos
                lote.grabarAnimal();
                lote.modificarBase(lote);

                MessageBox.Show("Se asignaron los articulos al lote");

                cargoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_modificarLoteMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                Lote lote = new Lote();

                ArrayList ArrayLote = new ArrayList();

                ArrayLote.AddRange(list_loteMaquina.Items);

                int cantidadLote = ArrayLote.Count;

                lote = new Lote(Int32.Parse(txt_IDloteMaquinas.Text), "Maquina", Int32.Parse(this.txt_baseMaquina.Text), cantidadLote, 0);


                foreach (Maquinaria maq in this.list_loteMaquina.Items)
                {
                    lote.agregarMaquinaLote(maq);
                }

                //graba el paquete en la base de datos
                lote.grabarMaquina();
                lote.modificarBase(lote);

                MessageBox.Show("Se asignaron los articulos al lote");

                cargoGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void data_grid_lotesMaquina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_lotesMaquina.Rows[e.RowIndex];
            this.txt_IDloteMaquinas.Text = row.Cells[0].Value.ToString();
            this.txt_baseMaquina.Text = row.Cells[2].Value.ToString();


            int id_lote = Convert.ToInt32(txt_IDloteMaquinas.Text);
            foreach (Maquinaria maq in Maquinaria.obtenerMaquinaConLote(id_lote))
            {
                this.list_loteMaquina.Items.Add(maq);
            }
        }

        private void btn_eliminarLoteAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirme la eliminacion del lote", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Lote lote = new Lote(Int32.Parse(txt_idLoteAnimal.Text));
                    bool confirma = lote.borrarLote(lote);
                    if (confirma)
                    {
                        MessageBox.Show("Lote eliminado con exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_eliminarLoteMaquina_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Confirme la eliminacion del lote", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    Lote lote = new Lote(Int32.Parse(txt_IDloteMaquinas.Text));
                    bool confirma = lote.borrarLote(lote);
                    if (confirma)
                    {
                        MessageBox.Show("Lote eliminado con exito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar lote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
