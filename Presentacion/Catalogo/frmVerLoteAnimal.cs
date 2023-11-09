using Negocio.Articulos;
using Negocio.Personas;
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
    public partial class frmVerLote : Form
    {
        public frmVerLote()
        {
            InitializeComponent();
        }

        public int idLote { get; set; }

        private void frmVerLote_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void cargoGrilla()
        {
            this.data_grid_animal.Rows.Clear();
            foreach (Animal ani in Animal.obtenerAnimalConLote(idLote))
            {
                this.data_grid_animal.Rows.Add(ani.id, ani.peso_promedio, ani.categoria, ani.descripcion, ani.imagen, ani.disponibilidad);
            }
        }

        private void data_grid_animal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.data_grid_animal.Rows[e.RowIndex];
                this.txt_id.Text = row.Cells[0].Value.ToString();
                this.txt_pesoPromedio.Text = row.Cells[1].Value.ToString();
                this.cmb_categoria.SelectedItem = row.Cells[2].Value;
                this.txt_descripcion.Text = (string)row.Cells[3].Value;

                byte[] bytes = (byte[])row.Cells[4].Value;
                ImageConverter converter = new ImageConverter();
                Image image = (Image)converter.ConvertFrom(bytes);

                this.pib_imagen.Image = image;
                this.pib_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Primero debe seleccionar un animal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
