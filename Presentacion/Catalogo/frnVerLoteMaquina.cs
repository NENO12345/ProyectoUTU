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
    public partial class frnVerLoteMaquina : Form
    {
        public frnVerLoteMaquina()
        {
            InitializeComponent();
        }

        public int idLote { get; set; }


        private void frnVerLoteMaquina_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void cargoGrilla()
        {
            this.data_grid_maquinaria.Rows.Clear();
            foreach (Maquinaria maq in Maquinaria.obtenerMaquinaConLote(idLote))
            {
                this.data_grid_maquinaria.Rows.Add(maq.id, maq.marca, maq.modelo, maq.kilometraje, maq.tipo, maq.imagen, maq.disponibilidad);
            }
        }

        private void data_grid_maquinaria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_maquinaria.Rows[e.RowIndex];
            this.txt_id.Text = row.Cells[0].Value.ToString();
            this.txt_marca.Text = row.Cells[1].Value.ToString();
            this.txt_modelo.Text = row.Cells[2].Value.ToString();
            this.txt_kilometraje.Text = row.Cells[3].Value.ToString();
            this.cmb_tipo.SelectedItem = row.Cells[4].Value.ToString();

            byte[] bytes = (byte[])row.Cells[5].Value;
            ImageConverter converter = new ImageConverter();
            Image image = (Image)converter.ConvertFrom(bytes);


            this.pib_imagen.Image = image;
            this.pib_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
