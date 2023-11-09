using Programacion_Login.Administrar_inventario;
using Programacion_Login.Administrar_pagos;
using Programacion_Login.Administrar_Personas;
using Programacion_Login.Administrar_remates;
using Programacion_Login.Administrar_Remates;
using Programacion_Login.Catalogo;
using Programacion_Login.presentacion;

namespace Programacion_Login
{
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            pnl_submenu_usuario.Visible = false;
            pnl_submenu_ayuda.Visible = false;
            pnl_submenu_herramientas.Visible = false;
            pnl_sub_submenu_Administrar.Visible = false;
            pnl_sub_submenu_gestionar_inventario.Visible = false;
            pnl_sub_submenu_gestionar_remates.Visible = false;
            pnl_pago.Visible = false;
        }

        private const int Invitado = 0;
        private const int Proveedor = 2;
        private const int GestorRemates = 3;
        private const int Encargado = 4;
        private const int Administrador = 5;
        private const int Rematador = 6;


        private void esconderSubMenu()
        {
            if (pnl_submenu_usuario.Visible == true)
            {
                _ = pnl_submenu_usuario.Visible == false;
            }
            if (pnl_submenu_herramientas.Visible == true)
            {
                _ = pnl_submenu_herramientas.Visible == false;
            }
            if (pnl_submenu_ayuda.Visible == true)
            {
                _ = pnl_submenu_ayuda.Visible == false;
            }

        }

        private void esconder_Sub_SubMenu_herramientas()
        {
            if (pnl_submenu_usuario.Visible == true)
            {
                _ = pnl_submenu_usuario.Visible == false;
            }
            if (pnl_sub_submenu_Administrar.Visible == true)
            {
                _ = pnl_sub_submenu_Administrar.Visible == false;
            }
            if (pnl_submenu_ayuda.Visible == true)
            {
                _ = pnl_submenu_ayuda.Visible == false;
            }

        }
        private void mostarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                esconderSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public bool EstadoLogin { get; set; }
        public int idPermiso { get; set; }
        public int idUsuario { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1105, 696);
            EstadoLogin = false;
        }



        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            mostarSubMenu(pnl_submenu_herramientas);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_usuario_Click_1(object sender, EventArgs e)
        {
            mostarSubMenu(pnl_submenu_usuario);

        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {
            mostarSubMenu(pnl_submenu_ayuda);
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            if (idPermiso == Invitado)
            {
                frmLogin form2 = new frmLogin();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    EstadoLogin = form2.VerificarLogin;
                }
            }
            else
            {
                MessageBox.Show("Ya hay una sesion iniciada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btn_administrar_Click(object sender, EventArgs e)
        {
        }

        private void btn_herramienta1_Click(object sender, EventArgs e)
        {
            frmAdministrarClientes form3 = new frmAdministrarClientes();
            form3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
            lbl_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {

        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            if (idPermiso == Invitado)
            {
                MessageBox.Show("No ha iniciado ninguna sesion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Se ha cerrado la sesion correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                idPermiso = Invitado;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            idPermiso = 1;
        }



        private void lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void btn_administrar_empleados_Click(object sender, EventArgs e)
        {
            if (idPermiso == Administrador)
            {
                frmAdministrarEmpleados form = new frmAdministrarEmpleados();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmAdministrarProveedores form = new frmAdministrarProveedores();
            form.ShowDialog();

        }

        private void btn_administrar_rematadores_Click(object sender, EventArgs e)
        {
            frmAdministrarRematadores form = new frmAdministrarRematadores();
            form.ShowDialog();
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (idPermiso == Encargado || idPermiso == Administrador)
            {
                mostarSubMenu(pnl_sub_submenu_Administrar);
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnl_sub_submenu_Administrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_ayuda1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(idPermiso) + "|" + Convert.ToString(idUsuario));
        }

        private void btn_gestionar_inventario_Click(object sender, EventArgs e)
        {
            if (idPermiso == Proveedor)
            {
                mostarSubMenu(pnl_sub_submenu_gestionar_inventario);
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_gestionar_inventario_maquinas_Click(object sender, EventArgs e)
        {
            frmAdministrarMaquinaria form = new frmAdministrarMaquinaria();
            form.IdProveedor = idUsuario;
            form.ShowDialog();
        }

        private void btn_gestionar_inventario_animales_Click(object sender, EventArgs e)
        {
            frnAdministrarAnimal form = new frnAdministrarAnimal();
            form.IdProveedor = idUsuario;
            form.ShowDialog();
        }

        private void btn_gestionar_remates_lotes_Click(object sender, EventArgs e)
        {
            if (idPermiso != Invitado)
            {
                frmAdministrarLotes form = new frmAdministrarLotes();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe iniciar sesion para acceder", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_gestionar_remates_remates_Click(object sender, EventArgs e)
        {
            if (!EstadoLogin)
            {
                frmAdministrarRemates form = new frmAdministrarRemates();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Primero debe iniciar sesion para acceder", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void CargarDatos(bool estado_Login, int usuario, int permiso)
        {
            this.EstadoLogin = estado_Login;
            this.idPermiso = usuario;
            this.idUsuario = permiso;
        }

        private void btn_gestionar_remates_Click(object sender, EventArgs e)
        {
            if (idPermiso == GestorRemates)
            {
                mostarSubMenu(pnl_sub_submenu_gestionar_remates);
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pnl_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_pagos_Click(object sender, EventArgs e)
        {
            if (idPermiso == Administrador || idPermiso == Encargado)
            {
                mostarSubMenu(pnl_pago);
            }
            else
            {
                MessageBox.Show("Acceso denegado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            frmAdministrarPagoProveedor form = new frmAdministrarPagoProveedor();
            form.idEmpleado = idUsuario;
            form.ShowDialog();
        }

        private void iconButton1_Click_2(object sender, EventArgs e)
        {
            frmAdministrarPagosRematador form = new frmAdministrarPagosRematador();
            form.idEmpleado = idUsuario;
            form.ShowDialog();
        }

        private void pnl_Fondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click_3(object sender, EventArgs e)
        {
            frmCatalogoLotes form = new frmCatalogoLotes();
            form.ShowDialog();
        }
    }
}