namespace Programacion_Login
{
    partial class frmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnl_menu = new Panel();
            pnl_submenu_ayuda = new Panel();
            pnl_submenu_herramientas = new Panel();
            pnl_sub_submenu_gestionar_remates = new Panel();
            btn_gestionar_remates_remates = new FontAwesome.Sharp.IconButton();
            btn_gestionar_remates_lotes = new FontAwesome.Sharp.IconButton();
            btn_gestionar_remates = new FontAwesome.Sharp.IconButton();
            pnl_sub_submenu_gestionar_inventario = new Panel();
            btn_gestionar_inventario_animales = new FontAwesome.Sharp.IconButton();
            btn_gestionar_inventario_maquinas = new FontAwesome.Sharp.IconButton();
            btn_gestionar_inventario = new FontAwesome.Sharp.IconButton();
            pnl_sub_submenu_Administrar = new Panel();
            btn_administrar_clientes = new FontAwesome.Sharp.IconButton();
            btn_administrar_rematadores = new FontAwesome.Sharp.IconButton();
            btn_administrar_proveedores = new FontAwesome.Sharp.IconButton();
            btn_administrar_empleados = new FontAwesome.Sharp.IconButton();
            btn_administrar = new FontAwesome.Sharp.IconButton();
            btn_herramientas = new FontAwesome.Sharp.IconButton();
            pnl_submenu_usuario = new Panel();
            btn_CerrarSesion = new FontAwesome.Sharp.IconButton();
            btn_login = new FontAwesome.Sharp.IconButton();
            btn_usuario = new FontAwesome.Sharp.IconButton();
            pnl_logo = new Panel();
            panel1 = new Panel();
            pnl_Fondo = new Panel();
            btn_catalogo = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            btn_pagos = new FontAwesome.Sharp.IconButton();
            pnl_pago = new Panel();
            btn_pagoRematador = new FontAwesome.Sharp.IconButton();
            btn_pagoProveedor = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            lbl_Hora = new Label();
            lbl_Fecha = new Label();
            horafecha = new System.Windows.Forms.Timer(components);
            pnl_menu.SuspendLayout();
            pnl_submenu_herramientas.SuspendLayout();
            pnl_sub_submenu_gestionar_remates.SuspendLayout();
            pnl_sub_submenu_gestionar_inventario.SuspendLayout();
            pnl_sub_submenu_Administrar.SuspendLayout();
            pnl_submenu_usuario.SuspendLayout();
            panel1.SuspendLayout();
            pnl_Fondo.SuspendLayout();
            pnl_pago.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_menu
            // 
            pnl_menu.BackColor = Color.FromArgb(0, 62, 23);
            pnl_menu.Controls.Add(pnl_submenu_ayuda);
            pnl_menu.Controls.Add(pnl_submenu_herramientas);
            pnl_menu.Controls.Add(btn_herramientas);
            pnl_menu.Controls.Add(pnl_submenu_usuario);
            pnl_menu.Controls.Add(btn_usuario);
            pnl_menu.Controls.Add(pnl_logo);
            pnl_menu.Dock = DockStyle.Left;
            pnl_menu.Location = new Point(0, 0);
            pnl_menu.Name = "pnl_menu";
            pnl_menu.Size = new Size(250, 745);
            pnl_menu.TabIndex = 0;
            // 
            // pnl_submenu_ayuda
            // 
            pnl_submenu_ayuda.BackColor = Color.FromArgb(64, 64, 64);
            pnl_submenu_ayuda.Dock = DockStyle.Top;
            pnl_submenu_ayuda.Location = new Point(0, 697);
            pnl_submenu_ayuda.Name = "pnl_submenu_ayuda";
            pnl_submenu_ayuda.Size = new Size(250, 46);
            pnl_submenu_ayuda.TabIndex = 6;
            // 
            // pnl_submenu_herramientas
            // 
            pnl_submenu_herramientas.AutoScroll = true;
            pnl_submenu_herramientas.BackColor = Color.FromArgb(64, 64, 64);
            pnl_submenu_herramientas.Controls.Add(pnl_sub_submenu_gestionar_remates);
            pnl_submenu_herramientas.Controls.Add(btn_gestionar_remates);
            pnl_submenu_herramientas.Controls.Add(pnl_sub_submenu_gestionar_inventario);
            pnl_submenu_herramientas.Controls.Add(btn_gestionar_inventario);
            pnl_submenu_herramientas.Controls.Add(pnl_sub_submenu_Administrar);
            pnl_submenu_herramientas.Controls.Add(btn_administrar);
            pnl_submenu_herramientas.Dock = DockStyle.Top;
            pnl_submenu_herramientas.Location = new Point(0, 277);
            pnl_submenu_herramientas.Name = "pnl_submenu_herramientas";
            pnl_submenu_herramientas.Size = new Size(250, 420);
            pnl_submenu_herramientas.TabIndex = 4;
            pnl_submenu_herramientas.Paint += panel1_Paint;
            // 
            // pnl_sub_submenu_gestionar_remates
            // 
            pnl_sub_submenu_gestionar_remates.Controls.Add(btn_gestionar_remates_remates);
            pnl_sub_submenu_gestionar_remates.Controls.Add(btn_gestionar_remates_lotes);
            pnl_sub_submenu_gestionar_remates.Dock = DockStyle.Top;
            pnl_sub_submenu_gestionar_remates.Location = new Point(0, 410);
            pnl_sub_submenu_gestionar_remates.Name = "pnl_sub_submenu_gestionar_remates";
            pnl_sub_submenu_gestionar_remates.Size = new Size(233, 93);
            pnl_sub_submenu_gestionar_remates.TabIndex = 7;
            // 
            // btn_gestionar_remates_remates
            // 
            btn_gestionar_remates_remates.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_remates_remates.Dock = DockStyle.Top;
            btn_gestionar_remates_remates.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_remates_remates.FlatAppearance.BorderSize = 0;
            btn_gestionar_remates_remates.FlatStyle = FlatStyle.Flat;
            btn_gestionar_remates_remates.ForeColor = Color.Snow;
            btn_gestionar_remates_remates.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_gestionar_remates_remates.IconColor = Color.Black;
            btn_gestionar_remates_remates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_remates_remates.Location = new Point(0, 46);
            btn_gestionar_remates_remates.Name = "btn_gestionar_remates_remates";
            btn_gestionar_remates_remates.Padding = new Padding(70, 0, 0, 0);
            btn_gestionar_remates_remates.Size = new Size(233, 46);
            btn_gestionar_remates_remates.TabIndex = 2;
            btn_gestionar_remates_remates.Text = "Remates";
            btn_gestionar_remates_remates.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_remates_remates.UseVisualStyleBackColor = false;
            btn_gestionar_remates_remates.Click += btn_gestionar_remates_remates_Click;
            // 
            // btn_gestionar_remates_lotes
            // 
            btn_gestionar_remates_lotes.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_remates_lotes.Dock = DockStyle.Top;
            btn_gestionar_remates_lotes.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_remates_lotes.FlatAppearance.BorderSize = 0;
            btn_gestionar_remates_lotes.FlatStyle = FlatStyle.Flat;
            btn_gestionar_remates_lotes.ForeColor = Color.Snow;
            btn_gestionar_remates_lotes.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_gestionar_remates_lotes.IconColor = Color.Black;
            btn_gestionar_remates_lotes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_remates_lotes.Location = new Point(0, 0);
            btn_gestionar_remates_lotes.Name = "btn_gestionar_remates_lotes";
            btn_gestionar_remates_lotes.Padding = new Padding(70, 0, 0, 0);
            btn_gestionar_remates_lotes.Size = new Size(233, 46);
            btn_gestionar_remates_lotes.TabIndex = 1;
            btn_gestionar_remates_lotes.Text = "Lotes";
            btn_gestionar_remates_lotes.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_remates_lotes.UseVisualStyleBackColor = false;
            btn_gestionar_remates_lotes.Click += btn_gestionar_remates_lotes_Click;
            // 
            // btn_gestionar_remates
            // 
            btn_gestionar_remates.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_remates.Dock = DockStyle.Top;
            btn_gestionar_remates.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_remates.FlatAppearance.BorderSize = 0;
            btn_gestionar_remates.FlatStyle = FlatStyle.Flat;
            btn_gestionar_remates.ForeColor = Color.White;
            btn_gestionar_remates.IconChar = FontAwesome.Sharp.IconChar.Legal;
            btn_gestionar_remates.IconColor = Color.White;
            btn_gestionar_remates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_remates.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_remates.Location = new Point(0, 363);
            btn_gestionar_remates.Name = "btn_gestionar_remates";
            btn_gestionar_remates.Padding = new Padding(15, 0, 15, 0);
            btn_gestionar_remates.RightToLeft = RightToLeft.No;
            btn_gestionar_remates.Size = new Size(233, 47);
            btn_gestionar_remates.TabIndex = 7;
            btn_gestionar_remates.Text = "Gestionar remates";
            btn_gestionar_remates.UseVisualStyleBackColor = false;
            btn_gestionar_remates.Click += btn_gestionar_remates_Click;
            // 
            // pnl_sub_submenu_gestionar_inventario
            // 
            pnl_sub_submenu_gestionar_inventario.Controls.Add(btn_gestionar_inventario_animales);
            pnl_sub_submenu_gestionar_inventario.Controls.Add(btn_gestionar_inventario_maquinas);
            pnl_sub_submenu_gestionar_inventario.Dock = DockStyle.Top;
            pnl_sub_submenu_gestionar_inventario.Location = new Point(0, 275);
            pnl_sub_submenu_gestionar_inventario.Name = "pnl_sub_submenu_gestionar_inventario";
            pnl_sub_submenu_gestionar_inventario.Size = new Size(233, 88);
            pnl_sub_submenu_gestionar_inventario.TabIndex = 6;
            // 
            // btn_gestionar_inventario_animales
            // 
            btn_gestionar_inventario_animales.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_inventario_animales.Dock = DockStyle.Top;
            btn_gestionar_inventario_animales.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_inventario_animales.FlatAppearance.BorderSize = 0;
            btn_gestionar_inventario_animales.FlatStyle = FlatStyle.Flat;
            btn_gestionar_inventario_animales.ForeColor = Color.Snow;
            btn_gestionar_inventario_animales.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_gestionar_inventario_animales.IconColor = Color.Black;
            btn_gestionar_inventario_animales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_inventario_animales.Location = new Point(0, 46);
            btn_gestionar_inventario_animales.Name = "btn_gestionar_inventario_animales";
            btn_gestionar_inventario_animales.Padding = new Padding(70, 0, 0, 0);
            btn_gestionar_inventario_animales.Size = new Size(233, 46);
            btn_gestionar_inventario_animales.TabIndex = 1;
            btn_gestionar_inventario_animales.Text = "Animales";
            btn_gestionar_inventario_animales.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_inventario_animales.UseVisualStyleBackColor = false;
            btn_gestionar_inventario_animales.Click += btn_gestionar_inventario_animales_Click;
            // 
            // btn_gestionar_inventario_maquinas
            // 
            btn_gestionar_inventario_maquinas.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_inventario_maquinas.Dock = DockStyle.Top;
            btn_gestionar_inventario_maquinas.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_inventario_maquinas.FlatAppearance.BorderSize = 0;
            btn_gestionar_inventario_maquinas.FlatStyle = FlatStyle.Flat;
            btn_gestionar_inventario_maquinas.ForeColor = Color.Snow;
            btn_gestionar_inventario_maquinas.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_gestionar_inventario_maquinas.IconColor = Color.Black;
            btn_gestionar_inventario_maquinas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_inventario_maquinas.Location = new Point(0, 0);
            btn_gestionar_inventario_maquinas.Name = "btn_gestionar_inventario_maquinas";
            btn_gestionar_inventario_maquinas.Padding = new Padding(70, 0, 0, 0);
            btn_gestionar_inventario_maquinas.Size = new Size(233, 46);
            btn_gestionar_inventario_maquinas.TabIndex = 2;
            btn_gestionar_inventario_maquinas.Text = "Maquinas";
            btn_gestionar_inventario_maquinas.TextAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_inventario_maquinas.UseVisualStyleBackColor = false;
            btn_gestionar_inventario_maquinas.Click += btn_gestionar_inventario_maquinas_Click;
            // 
            // btn_gestionar_inventario
            // 
            btn_gestionar_inventario.BackColor = Color.FromArgb(15, 93, 44);
            btn_gestionar_inventario.Dock = DockStyle.Top;
            btn_gestionar_inventario.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_gestionar_inventario.FlatAppearance.BorderSize = 0;
            btn_gestionar_inventario.FlatStyle = FlatStyle.Flat;
            btn_gestionar_inventario.ForeColor = Color.White;
            btn_gestionar_inventario.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            btn_gestionar_inventario.IconColor = Color.White;
            btn_gestionar_inventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_gestionar_inventario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_gestionar_inventario.Location = new Point(0, 228);
            btn_gestionar_inventario.Name = "btn_gestionar_inventario";
            btn_gestionar_inventario.Padding = new Padding(15, 0, 15, 0);
            btn_gestionar_inventario.RightToLeft = RightToLeft.No;
            btn_gestionar_inventario.Size = new Size(233, 47);
            btn_gestionar_inventario.TabIndex = 6;
            btn_gestionar_inventario.Text = "Gestionar inventario";
            btn_gestionar_inventario.UseVisualStyleBackColor = false;
            btn_gestionar_inventario.Click += btn_gestionar_inventario_Click;
            // 
            // pnl_sub_submenu_Administrar
            // 
            pnl_sub_submenu_Administrar.Controls.Add(btn_administrar_clientes);
            pnl_sub_submenu_Administrar.Controls.Add(btn_administrar_rematadores);
            pnl_sub_submenu_Administrar.Controls.Add(btn_administrar_proveedores);
            pnl_sub_submenu_Administrar.Controls.Add(btn_administrar_empleados);
            pnl_sub_submenu_Administrar.Dock = DockStyle.Top;
            pnl_sub_submenu_Administrar.Location = new Point(0, 46);
            pnl_sub_submenu_Administrar.Name = "pnl_sub_submenu_Administrar";
            pnl_sub_submenu_Administrar.Size = new Size(233, 182);
            pnl_sub_submenu_Administrar.TabIndex = 5;
            pnl_sub_submenu_Administrar.Paint += pnl_sub_submenu_Administrar_Paint;
            // 
            // btn_administrar_clientes
            // 
            btn_administrar_clientes.BackColor = Color.FromArgb(15, 93, 44);
            btn_administrar_clientes.Dock = DockStyle.Top;
            btn_administrar_clientes.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_administrar_clientes.FlatAppearance.BorderSize = 0;
            btn_administrar_clientes.FlatStyle = FlatStyle.Flat;
            btn_administrar_clientes.ForeColor = Color.Snow;
            btn_administrar_clientes.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_administrar_clientes.IconColor = Color.Black;
            btn_administrar_clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_administrar_clientes.Location = new Point(0, 136);
            btn_administrar_clientes.Name = "btn_administrar_clientes";
            btn_administrar_clientes.Padding = new Padding(70, 0, 0, 0);
            btn_administrar_clientes.Size = new Size(233, 46);
            btn_administrar_clientes.TabIndex = 0;
            btn_administrar_clientes.Text = "Clientes";
            btn_administrar_clientes.TextAlign = ContentAlignment.MiddleLeft;
            btn_administrar_clientes.UseVisualStyleBackColor = false;
            btn_administrar_clientes.Click += btn_herramienta1_Click;
            // 
            // btn_administrar_rematadores
            // 
            btn_administrar_rematadores.BackColor = Color.FromArgb(15, 93, 44);
            btn_administrar_rematadores.Dock = DockStyle.Top;
            btn_administrar_rematadores.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_administrar_rematadores.FlatAppearance.BorderSize = 0;
            btn_administrar_rematadores.FlatStyle = FlatStyle.Flat;
            btn_administrar_rematadores.ForeColor = Color.Snow;
            btn_administrar_rematadores.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_administrar_rematadores.IconColor = Color.Black;
            btn_administrar_rematadores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_administrar_rematadores.Location = new Point(0, 91);
            btn_administrar_rematadores.Name = "btn_administrar_rematadores";
            btn_administrar_rematadores.Padding = new Padding(70, 0, 0, 0);
            btn_administrar_rematadores.Size = new Size(233, 45);
            btn_administrar_rematadores.TabIndex = 3;
            btn_administrar_rematadores.Text = "Rematadores";
            btn_administrar_rematadores.TextAlign = ContentAlignment.MiddleLeft;
            btn_administrar_rematadores.UseVisualStyleBackColor = false;
            btn_administrar_rematadores.Click += btn_administrar_rematadores_Click;
            // 
            // btn_administrar_proveedores
            // 
            btn_administrar_proveedores.BackColor = Color.FromArgb(15, 93, 44);
            btn_administrar_proveedores.Dock = DockStyle.Top;
            btn_administrar_proveedores.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_administrar_proveedores.FlatAppearance.BorderSize = 0;
            btn_administrar_proveedores.FlatStyle = FlatStyle.Flat;
            btn_administrar_proveedores.ForeColor = Color.Snow;
            btn_administrar_proveedores.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_administrar_proveedores.IconColor = Color.Black;
            btn_administrar_proveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_administrar_proveedores.Location = new Point(0, 46);
            btn_administrar_proveedores.Name = "btn_administrar_proveedores";
            btn_administrar_proveedores.Padding = new Padding(70, 0, 0, 0);
            btn_administrar_proveedores.Size = new Size(233, 45);
            btn_administrar_proveedores.TabIndex = 2;
            btn_administrar_proveedores.Text = "Proveedores";
            btn_administrar_proveedores.TextAlign = ContentAlignment.MiddleLeft;
            btn_administrar_proveedores.UseVisualStyleBackColor = false;
            btn_administrar_proveedores.Click += iconButton1_Click;
            // 
            // btn_administrar_empleados
            // 
            btn_administrar_empleados.BackColor = Color.FromArgb(15, 93, 44);
            btn_administrar_empleados.Dock = DockStyle.Top;
            btn_administrar_empleados.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_administrar_empleados.FlatAppearance.BorderSize = 0;
            btn_administrar_empleados.FlatStyle = FlatStyle.Flat;
            btn_administrar_empleados.ForeColor = Color.Snow;
            btn_administrar_empleados.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_administrar_empleados.IconColor = Color.Black;
            btn_administrar_empleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_administrar_empleados.Location = new Point(0, 0);
            btn_administrar_empleados.Name = "btn_administrar_empleados";
            btn_administrar_empleados.Padding = new Padding(70, 0, 0, 0);
            btn_administrar_empleados.Size = new Size(233, 46);
            btn_administrar_empleados.TabIndex = 1;
            btn_administrar_empleados.Text = "Empleados";
            btn_administrar_empleados.TextAlign = ContentAlignment.MiddleLeft;
            btn_administrar_empleados.UseVisualStyleBackColor = false;
            btn_administrar_empleados.Click += btn_administrar_empleados_Click;
            // 
            // btn_administrar
            // 
            btn_administrar.BackColor = Color.FromArgb(15, 93, 44);
            btn_administrar.Dock = DockStyle.Top;
            btn_administrar.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_administrar.FlatAppearance.BorderSize = 0;
            btn_administrar.FlatStyle = FlatStyle.Flat;
            btn_administrar.ForeColor = Color.White;
            btn_administrar.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            btn_administrar.IconColor = Color.White;
            btn_administrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_administrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_administrar.Location = new Point(0, 0);
            btn_administrar.Name = "btn_administrar";
            btn_administrar.Padding = new Padding(16, 0, 10, 0);
            btn_administrar.RightToLeft = RightToLeft.No;
            btn_administrar.Size = new Size(233, 46);
            btn_administrar.TabIndex = 4;
            btn_administrar.Text = "Administrar usuarios";
            btn_administrar.UseVisualStyleBackColor = false;
            btn_administrar.Click += iconButton1_Click_1;
            // 
            // btn_herramientas
            // 
            btn_herramientas.BackColor = Color.FromArgb(77, 154, 106);
            btn_herramientas.Dock = DockStyle.Top;
            btn_herramientas.FlatAppearance.BorderSize = 0;
            btn_herramientas.FlatAppearance.MouseOverBackColor = Color.ForestGreen;
            btn_herramientas.FlatStyle = FlatStyle.Flat;
            btn_herramientas.ForeColor = Color.Snow;
            btn_herramientas.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            btn_herramientas.IconColor = Color.White;
            btn_herramientas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_herramientas.IconSize = 40;
            btn_herramientas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_herramientas.Location = new Point(0, 232);
            btn_herramientas.Name = "btn_herramientas";
            btn_herramientas.Size = new Size(250, 45);
            btn_herramientas.TabIndex = 3;
            btn_herramientas.Text = "Herramientas";
            btn_herramientas.UseVisualStyleBackColor = false;
            btn_herramientas.Click += iconButton3_Click;
            // 
            // pnl_submenu_usuario
            // 
            pnl_submenu_usuario.BackColor = Color.FromArgb(64, 64, 64);
            pnl_submenu_usuario.Controls.Add(btn_CerrarSesion);
            pnl_submenu_usuario.Controls.Add(btn_login);
            pnl_submenu_usuario.Dock = DockStyle.Top;
            pnl_submenu_usuario.Location = new Point(0, 145);
            pnl_submenu_usuario.Name = "pnl_submenu_usuario";
            pnl_submenu_usuario.Size = new Size(250, 87);
            pnl_submenu_usuario.TabIndex = 2;
            // 
            // btn_CerrarSesion
            // 
            btn_CerrarSesion.BackColor = Color.FromArgb(15, 93, 44);
            btn_CerrarSesion.Dock = DockStyle.Top;
            btn_CerrarSesion.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            btn_CerrarSesion.FlatStyle = FlatStyle.Flat;
            btn_CerrarSesion.ForeColor = Color.Snow;
            btn_CerrarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_CerrarSesion.IconColor = Color.Black;
            btn_CerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_CerrarSesion.Location = new Point(0, 45);
            btn_CerrarSesion.Name = "btn_CerrarSesion";
            btn_CerrarSesion.Padding = new Padding(35, 0, 0, 0);
            btn_CerrarSesion.Size = new Size(250, 42);
            btn_CerrarSesion.TabIndex = 1;
            btn_CerrarSesion.Text = "Cerrar sesión";
            btn_CerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btn_CerrarSesion.UseVisualStyleBackColor = false;
            btn_CerrarSesion.Click += btn_CerrarSesion_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(15, 93, 44);
            btn_login.Dock = DockStyle.Top;
            btn_login.FlatAppearance.BorderColor = Color.DarkGreen;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.Snow;
            btn_login.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_login.IconColor = Color.Black;
            btn_login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_login.Location = new Point(0, 0);
            btn_login.Name = "btn_login";
            btn_login.Padding = new Padding(35, 0, 0, 0);
            btn_login.Size = new Size(250, 45);
            btn_login.TabIndex = 0;
            btn_login.Text = "Iniciar sesión";
            btn_login.TextAlign = ContentAlignment.MiddleLeft;
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click_1;
            // 
            // btn_usuario
            // 
            btn_usuario.BackColor = Color.FromArgb(77, 154, 106);
            btn_usuario.Dock = DockStyle.Top;
            btn_usuario.FlatAppearance.BorderSize = 0;
            btn_usuario.FlatAppearance.MouseOverBackColor = Color.DarkGreen;
            btn_usuario.FlatStyle = FlatStyle.Flat;
            btn_usuario.ForeColor = Color.White;
            btn_usuario.IconChar = FontAwesome.Sharp.IconChar.HomeUser;
            btn_usuario.IconColor = Color.White;
            btn_usuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_usuario.IconSize = 40;
            btn_usuario.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usuario.Location = new Point(0, 100);
            btn_usuario.Name = "btn_usuario";
            btn_usuario.Size = new Size(250, 45);
            btn_usuario.TabIndex = 1;
            btn_usuario.Text = "Usuario";
            btn_usuario.UseVisualStyleBackColor = false;
            btn_usuario.Click += btn_usuario_Click_1;
            // 
            // pnl_logo
            // 
            pnl_logo.BackColor = Color.FromArgb(0, 62, 23);
            pnl_logo.BackgroundImage = Properties.Resources.Revacuno_logo__2_;
            pnl_logo.Dock = DockStyle.Top;
            pnl_logo.Location = new Point(0, 0);
            pnl_logo.Name = "pnl_logo";
            pnl_logo.Size = new Size(250, 100);
            pnl_logo.TabIndex = 0;
            pnl_logo.Paint += pnl_logo_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pnl_Fondo);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(835, 745);
            panel1.TabIndex = 1;
            // 
            // pnl_Fondo
            // 
            pnl_Fondo.BackColor = Color.White;
            pnl_Fondo.BackgroundImage = Properties.Resources.cow_7200409_1280;
            pnl_Fondo.Controls.Add(btn_catalogo);
            pnl_Fondo.Controls.Add(label1);
            pnl_Fondo.Controls.Add(btn_pagos);
            pnl_Fondo.Controls.Add(pnl_pago);
            pnl_Fondo.Controls.Add(panel2);
            pnl_Fondo.Dock = DockStyle.Fill;
            pnl_Fondo.Location = new Point(0, 0);
            pnl_Fondo.Name = "pnl_Fondo";
            pnl_Fondo.Size = new Size(835, 745);
            pnl_Fondo.TabIndex = 1;
            pnl_Fondo.Paint += pnl_Fondo_Paint;
            // 
            // btn_catalogo
            // 
            btn_catalogo.BackColor = Color.FromArgb(15, 93, 44);
            btn_catalogo.FlatAppearance.BorderSize = 0;
            btn_catalogo.FlatStyle = FlatStyle.Flat;
            btn_catalogo.ForeColor = Color.White;
            btn_catalogo.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            btn_catalogo.IconColor = Color.White;
            btn_catalogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_catalogo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_catalogo.Location = new Point(41, 593);
            btn_catalogo.Name = "btn_catalogo";
            btn_catalogo.Padding = new Padding(15, 0, 15, 0);
            btn_catalogo.Size = new Size(233, 47);
            btn_catalogo.TabIndex = 7;
            btn_catalogo.Text = "Catalogo";
            btn_catalogo.UseVisualStyleBackColor = false;
            btn_catalogo.Click += iconButton1_Click_3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(102, 113, 112);
            label1.Location = new Point(370, 242);
            label1.Name = "label1";
            label1.Size = new Size(97, 42);
            label1.TabIndex = 6;
            label1.Text = "Powered by\r\n-| CodeExe |-";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_pagos
            // 
            btn_pagos.BackColor = Color.FromArgb(15, 93, 44);
            btn_pagos.FlatAppearance.BorderSize = 0;
            btn_pagos.FlatStyle = FlatStyle.Flat;
            btn_pagos.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            btn_pagos.IconColor = Color.White;
            btn_pagos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_pagos.Location = new Point(768, 596);
            btn_pagos.Name = "btn_pagos";
            btn_pagos.Size = new Size(55, 44);
            btn_pagos.TabIndex = 4;
            btn_pagos.UseVisualStyleBackColor = false;
            btn_pagos.Click += btn_pagos_Click;
            // 
            // pnl_pago
            // 
            pnl_pago.BackColor = Color.FromArgb(15, 93, 44);
            pnl_pago.Controls.Add(btn_pagoRematador);
            pnl_pago.Controls.Add(btn_pagoProveedor);
            pnl_pago.Location = new Point(768, 505);
            pnl_pago.Name = "pnl_pago";
            pnl_pago.Size = new Size(55, 91);
            pnl_pago.TabIndex = 5;
            // 
            // btn_pagoRematador
            // 
            btn_pagoRematador.BackColor = Color.FromArgb(15, 93, 44);
            btn_pagoRematador.FlatAppearance.BorderSize = 0;
            btn_pagoRematador.FlatStyle = FlatStyle.Flat;
            btn_pagoRematador.IconChar = FontAwesome.Sharp.IconChar.Legal;
            btn_pagoRematador.IconColor = Color.White;
            btn_pagoRematador.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_pagoRematador.Location = new Point(0, 47);
            btn_pagoRematador.Name = "btn_pagoRematador";
            btn_pagoRematador.Size = new Size(55, 44);
            btn_pagoRematador.TabIndex = 6;
            btn_pagoRematador.UseVisualStyleBackColor = false;
            btn_pagoRematador.Click += iconButton1_Click_2;
            // 
            // btn_pagoProveedor
            // 
            btn_pagoProveedor.BackColor = Color.FromArgb(15, 93, 44);
            btn_pagoProveedor.FlatAppearance.BorderSize = 0;
            btn_pagoProveedor.FlatStyle = FlatStyle.Flat;
            btn_pagoProveedor.IconChar = FontAwesome.Sharp.IconChar.Tractor;
            btn_pagoProveedor.IconColor = Color.White;
            btn_pagoProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_pagoProveedor.Location = new Point(0, 2);
            btn_pagoProveedor.Name = "btn_pagoProveedor";
            btn_pagoProveedor.Size = new Size(55, 44);
            btn_pagoProveedor.TabIndex = 7;
            btn_pagoProveedor.UseVisualStyleBackColor = false;
            btn_pagoProveedor.Click += iconButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lbl_Hora);
            panel2.Controls.Add(lbl_Fecha);
            panel2.Location = new Point(282, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(275, 135);
            panel2.TabIndex = 2;
            // 
            // lbl_Hora
            // 
            lbl_Hora.AutoSize = true;
            lbl_Hora.BackColor = Color.Transparent;
            lbl_Hora.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Hora.ForeColor = Color.White;
            lbl_Hora.Location = new Point(0, 0);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(275, 86);
            lbl_Hora.TabIndex = 0;
            lbl_Hora.Text = "00:00:00";
            lbl_Hora.Click += lbl_Hora_Click;
            // 
            // lbl_Fecha
            // 
            lbl_Fecha.AutoSize = true;
            lbl_Fecha.BackColor = Color.Transparent;
            lbl_Fecha.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Fecha.ForeColor = Color.White;
            lbl_Fecha.Location = new Point(35, 85);
            lbl_Fecha.Name = "lbl_Fecha";
            lbl_Fecha.Size = new Size(210, 50);
            lbl_Fecha.TabIndex = 1;
            lbl_Fecha.Text = "00/00/0000";
            lbl_Fecha.TextAlign = ContentAlignment.MiddleCenter;
            lbl_Fecha.Click += lbl_Fecha_Click;
            // 
            // horafecha
            // 
            horafecha.Enabled = true;
            horafecha.Tick += horafecha_Tick;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(1085, 745);
            Controls.Add(panel1);
            Controls.Add(pnl_menu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Revacunos";
            Load += Form1_Load;
            pnl_menu.ResumeLayout(false);
            pnl_submenu_herramientas.ResumeLayout(false);
            pnl_sub_submenu_gestionar_remates.ResumeLayout(false);
            pnl_sub_submenu_gestionar_inventario.ResumeLayout(false);
            pnl_sub_submenu_Administrar.ResumeLayout(false);
            pnl_submenu_usuario.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnl_Fondo.ResumeLayout(false);
            pnl_Fondo.PerformLayout();
            pnl_pago.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_menu;
        private Panel pnl_logo;
        private FontAwesome.Sharp.IconButton btn_usuario;
        private Panel pnl_submenu_herramientas;
        private FontAwesome.Sharp.IconButton btn_administrar_clientes;
        private FontAwesome.Sharp.IconButton btn_herramientas;
        private Panel pnl_submenu_usuario;
        private FontAwesome.Sharp.IconButton btn_login;
        private Panel pnl_submenu_ayuda;
        private Panel panel1;
        private Panel pnl_Fondo;
        private System.Windows.Forms.Timer horafecha;
        private FontAwesome.Sharp.IconButton btn_CerrarSesion;
        private Label lbl_Hora;
        private Label lbl_Fecha;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btn_administrar_empleados;
        private FontAwesome.Sharp.IconButton btn_administrar_rematadores;
        private FontAwesome.Sharp.IconButton btn_administrar_proveedores;
        private FontAwesome.Sharp.IconButton btn_administrar;
        private Panel pnl_sub_submenu_Administrar;
        private FontAwesome.Sharp.IconButton btn_gestionar_inventario;
        private Panel pnl_sub_submenu_gestionar_inventario;
        private FontAwesome.Sharp.IconButton btn_gestionar_inventario_animales;
        private FontAwesome.Sharp.IconButton btn_gestionar_inventario_maquinas;
        private FontAwesome.Sharp.IconButton btn_gestionar_remates;
        private Panel pnl_sub_submenu_gestionar_remates;
        private FontAwesome.Sharp.IconButton btn_gestionar_remates_remates;
        private FontAwesome.Sharp.IconButton btn_gestionar_remates_lotes;
        private FontAwesome.Sharp.IconButton btn_pagos;
        private FontAwesome.Sharp.IconButton btn_pagoRematador;
        private Panel pnl_pago;
        private FontAwesome.Sharp.IconButton btn_pagoProveedor;
        private Label label1;
        private FontAwesome.Sharp.IconButton btn_catalogo;
    }
}