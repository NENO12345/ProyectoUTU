using Negocio.Articulos;
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
using Image = System.Drawing.Image;

namespace Programacion_Login.Administrar_inventario
{
    public partial class frnAdministrarAnimal : Form
    {
        public frnAdministrarAnimal()
        {
            InitializeComponent();
        }

        private void cargoGrilla()
        {
            this.data_grid_animal.Rows.Clear();
            foreach (Animal ani in Animal.obtenerAnimalConProv(IdProveedor))
            {
                this.data_grid_animal.Rows.Add(ani.id, ani.peso_promedio, ani.categoria, ani.descripcion, ani.imagen, ani.disponibilidad);
            }
        }

        private void data_grid_animal_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (verificar_campos()) // Comprueba que las casillas no esten vacias
                {
                    // Convierto la imagen en un array de bytes
                    byte[] imagen = Convertir_Imagen_Bytes(pib_imagen.Image);



                    //Creo el objeto con los atributos
                    Animal ani = new Animal(Convert.ToInt32(txt_pesoPromedio.Text), Convert.ToString(cmb_categoria.SelectedItem), txt_descripcion.Text, imagen, false, true, IdProveedor);
                    bool confirma = ani.agregarAnimal(ani);
                    if (confirma)
                    {
                        MessageBox.Show("Animal agregado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cargoGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel
            }
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            /*try
            {*/

            if (verificar_campos())
            {
                // Convierto la imagen en un array de bytes
                byte[] imagen = Convertir_Imagen_Bytes(pib_imagen.Image);

                //Creo el objeto con los atributos
                Animal ani = new Animal(Convert.ToInt32(txt_id.Text), Convert.ToInt32(txt_pesoPromedio.Text), Convert.ToString(cmb_categoria.SelectedItem), txt_descripcion.Text, imagen, false, true, 0);
                bool confirma = ani.modificarAnimal(ani);
                if (confirma)
                {
                    MessageBox.Show("Animal modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al modificar animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                cargoGrilla();
            }
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar animal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel

            }*/
        }

        public static byte[] Convertir_Imagen_Bytes(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        public int IdProveedor { get; set; }

        private bool verificar_campos()
        {
            if ((txt_pesoPromedio.Text != "") && (txt_descripcion.Text != "") && (cmb_categoria.SelectedItem != "") && (pib_imagen.Image != null))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void frnAdministrarAnimal_Load(object sender, EventArgs e)
        {
            cargoGrilla();
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

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (verificar_campos())
            {
                DialogResult dialogResult = MessageBox.Show("Confirme eliminación del animal", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Animal ani = new Animal(Convert.ToInt32(txt_id.Text));
                    bool confirma = ani.borrarAnimal(ani);
                    if (confirma)
                    {
                        MessageBox.Show("Animal borrado con éxito", "Borrado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se eliminó el animal seleccionado", "Error al borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cargoGrilla();
                }

            }
        }
    }
}
