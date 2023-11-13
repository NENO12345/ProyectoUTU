using java.awt;
using java.awt.image;
using Negocio.Articulos;
using Negocio.Personas;
using NPOI.Util;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Programacion_Login.Administrar_inventario
{
    public partial class frmAdministrarMaquinaria : Form
    {
        public frmAdministrarMaquinaria()
        {
            InitializeComponent();
        }

        public int IdProveedor { get; set; }

        private void cargoGrilla()
        {
            this.data_grid_maquinaria.Rows.Clear();
            foreach (Maquinaria maq in Maquinaria.obtenerMaquinariaConProv(IdProveedor))
            {
                this.data_grid_maquinaria.Rows.Add(maq.id, maq.marca, maq.modelo, maq.kilometraje, maq.tipo, maq.imagen, maq.disponibilidad);
            }
        }

        private void frmAdministrarMaquinaria_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void lbl_modelo_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_agregar_imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "formato de imagen (*.png; *.jpg; *.jpeg)| *.png;*.jpg;*.jpeg";


            if (imagen.ShowDialog() == DialogResult.OK)
            {
                pib_imagen.Image = System.Drawing.Image.FromFile(imagen.FileName);
                pib_imagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            if (verificar_campos()) // Comprueba que las casillas no esten vacias
            {
                // Convierto la imagen en un array de bytes
                byte[] imagen = Convertir_Imagen_Bytes(pib_imagen.Image);

                //Creo el objeto con los atributos
                Maquinaria maq = new Maquinaria(Convert.ToInt32(txt_kilometraje.Text), Convert.ToString(cmb_tipo.SelectedItem), txt_marca.Text, txt_modelo.Text, imagen, false, true, IdProveedor);
                bool confirma = maq.agregarMaquina(maq);
                if (confirma)
                {
                    MessageBox.Show("Maquina agregada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al agregar maquina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargoGrilla();
            }
        }

        public static byte[] Convertir_Imagen_Bytes(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }



        private bool verificar_campos()
        {
            if ((txt_marca.Text != "") && (txt_modelo.Text != "") && (txt_kilometraje.Text != "") && (pib_imagen.Image != null))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Image StringToImage(string inputString)
        {
            byte[] imageBytes = Convert.FromBase64String(inputString);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (verificar_campos())
            {
                // Convierto la imagen en un array de bytes
                byte[] imagen = Convertir_Imagen_Bytes(pib_imagen.Image);

                //Creo el objeto con los atributos
                Maquinaria maq = new Maquinaria(Convert.ToInt32(txt_id.Text), Convert.ToInt32(txt_kilometraje.Text), Convert.ToString(cmb_tipo.SelectedItem), txt_marca.Text, txt_modelo.Text, imagen, false, true, 0);
                bool confirma = maq.modificarMaquina(maq);
                if (confirma)
                {
                    MessageBox.Show("Maquina modificada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al modificar maquina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargoGrilla();
            }
        }

        public Image ByteArrayToImage(byte[] imagen)
        {
            MemoryStream ms = new MemoryStream(imagen);
            // Añade esta línea
            ms.Position = 0;
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void data_grid_maquinaria_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (verificar_campos())
            {
                DialogResult dialogResult = MessageBox.Show("Confirme eliminación de la maquina", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Maquinaria maq = new Maquinaria(Convert.ToInt32(txt_id.Text));
                    bool confirma = maq.borrarMaquina(maq);
                    if (confirma)
                    {
                        MessageBox.Show("Maquina borrada con éxito", "Borrado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó la maquina seleccionada", "Error al borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cargoGrilla();
                }

            }


        }

        private void limpiarCampos()
        {
            txt_id.Clear();
            txt_kilometraje.Clear();
            txt_marca.Clear();
            txt_medida_kilometraje.Clear();
            txt_modelo.Clear();
            cmb_tipo.SelectedIndex = -1;
            pib_imagen.Image = null;
        }
    }
}
