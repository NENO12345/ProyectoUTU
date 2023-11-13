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

namespace Programacion_Login.Administrar_Personas
{
    public partial class frmAdministrarRematadores : Form
    {
        public frmAdministrarRematadores()
        {
            InitializeComponent();
        }

        private void cargoGrilla()
        {
            this.data_grid_rematadores.Rows.Clear();
            foreach (Rematador rem in Rematador.obtenerUsuariosExistentes())
            {
                this.data_grid_rematadores.Rows.Add(rem.id, rem.user, rem.pass, rem.nombre, rem.apellido, rem.direccion, rem.telefono, rem.estado);
            }
        }

        private void frmAdministrar_Load(object sender, EventArgs e)
        {
            cargoGrilla();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirme eliminación del usuario", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Rematador rem = new Rematador(Convert.ToInt32(txt_id.Text));
                bool confirma = rem.borrarUsuario(rem);
                if (confirma)
                {
                    MessageBox.Show("Usuario borrado con éxito", "Borrado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se eliminó el usuario", "Error al borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargoGrilla();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private bool verificacion(bool comprobar)
        {
            //Comprueba que ambos campos de contraseña sean iguales.
            if (txt_pass.Text == txt_repassword.Text)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool verificar_campos_cliente(bool verificar_campos)
        {
            // Comprueba que los campos no esten vacios.
            if ((txt_user.Text != "") && (txt_pass.Text != "") && (txt_nombre.Text != "") && (txt_apellido.Text != "") && (txt_direccion.Text != "") && (txt_telefono.Text != ""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void txt_login_TextChanged_1(object sender, EventArgs e)
        {
            // Se establece el prefijo
            string prefijo = "RE_";

            string texto = txt_user.Text;

            bool cambiando = false;

            if (cambiando) return;

            // Comprueba si el texto empieza por el prefijo
            if (!texto.StartsWith(prefijo))
            {
                cambiando = true;
                // Si no empieza por el prefijo, lo añade al principio
                texto = prefijo + texto;

                // Actualiza el texto del textbox con el prefijo añadido
                txt_user.Text = texto;

                // Coloca el cursor al final del texto
                txt_user.SelectionStart = texto.Length;
                cambiando = false;
            }
        }

        private void btn_agregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool comprobar = false;         // Coloco ambas variables en falso para luego llamar a los metodos de verificacion
                bool verificar_campos = false;

                if (verificacion(comprobar) == true && verificar_campos_cliente(verificar_campos)) // Comprueba ambos metodos
                {
                    Rematador rem = new Rematador(6, txt_user.Text, txt_pass.Text, txt_nombre.Text, txt_apellido.Text, Convert.ToInt32(txt_telefono.Text), txt_direccion.Text, true);
                    bool confirma = rem.agregarUsuario(rem);
                    cargoGrilla();
                    MessageBox.Show("Usuario creado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel
            }
        }

        private void data_grid_rematadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_rematadores.Rows[e.RowIndex];
            this.txt_id.Text = row.Cells[0].Value.ToString();
            this.txt_user.Text = row.Cells[1].Value.ToString();
            this.txt_pass.Text = row.Cells[2].Value.ToString();
            this.txt_repassword.Text = row.Cells[2].Value.ToString();
            this.txt_nombre.Text = row.Cells[3].Value.ToString();
            this.txt_apellido.Text = row.Cells[4].Value.ToString();
            this.txt_direccion.Text = row.Cells[5].Value.ToString();
            this.txt_telefono.Text = row.Cells[6].Value.ToString();
        }

        private void btn_modificar_Click_1(object sender, EventArgs e)
        {
            bool comprobar = false;
            bool verificar_campos = false;

            if (verificacion(comprobar) == true && verificar_campos_cliente(verificar_campos))
            {
                Rematador rem = new Rematador(Convert.ToInt32(txt_id.Text), txt_user.Text, txt_pass.Text, txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, Convert.ToInt32(txt_telefono.Text));
                bool confirma = rem.modificarUsuario(rem);
                cargoGrilla();
                limpiarCampos();
                MessageBox.Show("Usuario modificado con éxito", "Modificado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_borrar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Confirme eliminación del usuario", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Rematador rem = new Rematador(Convert.ToInt32(txt_id.Text));
                bool confirma = rem.borrarUsuario(rem);
                if (confirma)
                {
                    MessageBox.Show("Usuario borrado con éxito", "Borrado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se eliminó el usuario", "Error al borrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cargoGrilla();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void limpiarCampos()
        {
            txt_user.Clear();
            txt_pass.Clear();
            txt_repassword.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_id.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
        }
    }
}
