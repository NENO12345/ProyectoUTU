using Negocio.Personas;
using System.Text;
using System.Security.Cryptography;

namespace Programacion_Login.presentacion
{
    public partial class frmAdministrarClientes : Form
    {

        public frmAdministrarClientes()
        {
            InitializeComponent();
        }

        private void cargoGrilla()
        {
            this.data_grid_clientes.Rows.Clear();
            foreach (Cliente usr in Cliente.obtenerUsuariosExistentes())
            {
                this.data_grid_clientes.Rows.Add(usr.id, usr.user, usr.pass, usr.nombre, usr.apellido, usr.direccion, usr.telefono, usr.correo, usr.estado);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.data_grid_clientes.Rows[e.RowIndex];
            this.txt_id.Text = row.Cells[0].Value.ToString();
            this.txt_login.Text = row.Cells[1].Value.ToString();
            this.txt_pass.Text = row.Cells[2].Value.ToString();
            this.txt_repassword.Text = row.Cells[2].Value.ToString();
            this.txt_nombre.Text = row.Cells[3].Value.ToString();
            this.txt_apellido.Text = row.Cells[4].Value.ToString();
            this.txt_direccion.Text = row.Cells[5].Value.ToString();
            this.txt_telefono.Text = row.Cells[6].Value.ToString();
            this.txt_correo.Text = row.Cells[7].Value.ToString();
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
            bool verificar = false;
            try
            {
                DialogResult dialogResult = MessageBox.Show("Confirme eliminación del usuario", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    Cliente clte = new Cliente(Convert.ToInt32(txt_id.Text));
                    bool confirma = clte.borrarUsuario(clte);
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
            catch (Exception ex)
            {

            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            try
            {
                bool comprobar = false;         // Coloco ambas variables en falso para luego llamar a los metodos de verificacion
                bool verificar_campos = false;

                if (verificacion(comprobar) == true && verificar_campos_cliente(verificar_campos)) // Comprueba ambos metodos
                {
                    Cliente clte = new Cliente(1, txt_login.Text, txt_pass.Text, txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, Convert.ToInt32(txt_telefono.Text), txt_correo.Text, true);
                    bool confirma = clte.agregarUsuario(clte);
                    cargoGrilla();
                    if (confirma)
                    {
                        MessageBox.Show("Usuario creado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel
            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                bool comprobar = false;
                bool verificar_campos = false;

                if (verificacion(comprobar) == true && verificar_campos_cliente(verificar_campos))
                {
                    Cliente clte = new Cliente(Convert.ToInt32(txt_id.Text), txt_login.Text, txt_pass.Text, txt_nombre.Text, txt_apellido.Text, txt_direccion.Text, Convert.ToInt32(txt_telefono.Text), txt_correo.Text);
                    bool confirma = clte.modificarUsuario(clte);
                    if (confirma)
                    {
                        MessageBox.Show("Cliente modificado con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("Error al modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cargoGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // En caso de ocurrir un error muestra un cartel

            }
        }

        private bool verificacion(bool comprobar)
        {
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

        private void txt_cl_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cl_login_TextChanged(object sender, EventArgs e)
        {
            string prefijo = "CL_";

            string texto = txt_login.Text;

            bool cambiando = false;

            if (cambiando) return;

            // Comprueba si el texto empieza por el prefijo
            if (!texto.StartsWith(prefijo))
            {
                cambiando = true;
                // Si no empieza por el prefijo, lo añade al principio
                texto = prefijo + texto;

                // Actualiza el texto del textbox con el prefijo añadido
                txt_login.Text = texto;

                // Coloca el cursor al final del texto
                txt_login.SelectionStart = texto.Length;
                cambiando = false;
            }
        }

        private bool verificar_campos_cliente(bool verificar_campos)
        {
            if ((txt_login.Text != "") && (txt_pass.Text != "") && (txt_nombre.Text != "") && (txt_apellido.Text != "") && (txt_direccion.Text != "") && (txt_telefono.Text != "") && (txt_correo.Text != ""))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void limpiarCampos()
        {
            txt_login.Clear();
            txt_pass.Clear();
            txt_repassword.Clear();
            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_correo.Clear();
            txt_id.Clear();
            txt_telefono.Clear();
            txt_direccion.Clear();
        }



    }
}
