namespace Programacion_Login.Administrar_Personas
{
    partial class frmAdministrarProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            data_grid_proveedores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Login = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Empresa = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            pnl_informacion = new Panel();
            lbl_empresa = new Label();
            txt_empresa = new TextBox();
            lbl_id = new Label();
            lbl_telefono = new Label();
            btn_agregar = new Button();
            lbl_login = new Label();
            btn_modificar = new Button();
            lbl_direccion = new Label();
            btn_borrar = new Button();
            txt_id = new TextBox();
            lbl_apellido = new Label();
            txt_user = new TextBox();
            lbl_nombre = new Label();
            txt_pass = new TextBox();
            lbl_correo = new Label();
            txt_repassword = new TextBox();
            lbl_repass = new Label();
            txt_telefono = new TextBox();
            lbl_pass = new Label();
            txt_correo = new TextBox();
            txt_nombre = new TextBox();
            lbl_cl_id = new Label();
            txt_apellido = new TextBox();
            txt_direccion = new TextBox();
            lbl_tituloform = new Label();
            ((System.ComponentModel.ISupportInitialize)data_grid_proveedores).BeginInit();
            pnl_informacion.SuspendLayout();
            SuspendLayout();
            // 
            // data_grid_proveedores
            // 
            data_grid_proveedores.AllowUserToAddRows = false;
            data_grid_proveedores.AllowUserToDeleteRows = false;
            data_grid_proveedores.AllowUserToResizeColumns = false;
            data_grid_proveedores.AllowUserToResizeRows = false;
            data_grid_proveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_proveedores.Columns.AddRange(new DataGridViewColumn[] { ID, Login, Contraseña, Nombre, Apellido, Direccion, Telefono, Correo, Empresa, Estado });
            data_grid_proveedores.Location = new Point(-1, -1);
            data_grid_proveedores.Margin = new Padding(3, 2, 3, 2);
            data_grid_proveedores.MultiSelect = false;
            data_grid_proveedores.Name = "data_grid_proveedores";
            data_grid_proveedores.RowHeadersWidth = 51;
            data_grid_proveedores.RowTemplate.Height = 29;
            data_grid_proveedores.ShowEditingIcon = false;
            data_grid_proveedores.Size = new Size(549, 658);
            data_grid_proveedores.TabIndex = 1;
            data_grid_proveedores.CellContentClick += data_grid_proveedores_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Login
            // 
            Login.HeaderText = "Login";
            Login.MinimumWidth = 6;
            Login.Name = "Login";
            Login.ReadOnly = true;
            Login.Width = 125;
            // 
            // Contraseña
            // 
            Contraseña.HeaderText = "Contraseña";
            Contraseña.Name = "Contraseña";
            Contraseña.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            // 
            // Empresa
            // 
            Empresa.HeaderText = "Empresa";
            Empresa.Name = "Empresa";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // pnl_informacion
            // 
            pnl_informacion.Controls.Add(lbl_empresa);
            pnl_informacion.Controls.Add(txt_empresa);
            pnl_informacion.Controls.Add(lbl_id);
            pnl_informacion.Controls.Add(lbl_telefono);
            pnl_informacion.Controls.Add(btn_agregar);
            pnl_informacion.Controls.Add(lbl_login);
            pnl_informacion.Controls.Add(btn_modificar);
            pnl_informacion.Controls.Add(lbl_direccion);
            pnl_informacion.Controls.Add(btn_borrar);
            pnl_informacion.Controls.Add(txt_id);
            pnl_informacion.Controls.Add(lbl_apellido);
            pnl_informacion.Controls.Add(txt_user);
            pnl_informacion.Controls.Add(lbl_nombre);
            pnl_informacion.Controls.Add(txt_pass);
            pnl_informacion.Controls.Add(lbl_correo);
            pnl_informacion.Controls.Add(txt_repassword);
            pnl_informacion.Controls.Add(lbl_repass);
            pnl_informacion.Controls.Add(txt_telefono);
            pnl_informacion.Controls.Add(lbl_pass);
            pnl_informacion.Controls.Add(txt_correo);
            pnl_informacion.Controls.Add(txt_nombre);
            pnl_informacion.Controls.Add(lbl_cl_id);
            pnl_informacion.Controls.Add(txt_apellido);
            pnl_informacion.Controls.Add(txt_direccion);
            pnl_informacion.Location = new Point(554, 95);
            pnl_informacion.Name = "pnl_informacion";
            pnl_informacion.Size = new Size(543, 562);
            pnl_informacion.TabIndex = 16;
            // 
            // lbl_empresa
            // 
            lbl_empresa.AutoSize = true;
            lbl_empresa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_empresa.Location = new Point(359, 327);
            lbl_empresa.Name = "lbl_empresa";
            lbl_empresa.Size = new Size(84, 25);
            lbl_empresa.TabIndex = 20;
            lbl_empresa.Text = "Empresa";
            // 
            // txt_empresa
            // 
            txt_empresa.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_empresa.Location = new Point(298, 355);
            txt_empresa.Name = "txt_empresa";
            txt_empresa.Size = new Size(209, 43);
            txt_empresa.TabIndex = 19;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(27, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(30, 25);
            lbl_id.TabIndex = 18;
            lbl_id.Text = "ID";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(362, 250);
            lbl_telefono.Name = "lbl_telefono";
            lbl_telefono.Size = new Size(84, 25);
            lbl_telefono.TabIndex = 17;
            lbl_telefono.Text = "Telefono";
            // 
            // btn_agregar
            // 
            btn_agregar.Location = new Point(96, 489);
            btn_agregar.Margin = new Padding(3, 2, 3, 2);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(88, 38);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Agregar";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += btn_agregar_Click_1;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_login.Location = new Point(98, 28);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(59, 25);
            lbl_login.TabIndex = 10;
            lbl_login.Text = "Login";
            // 
            // btn_modificar
            // 
            btn_modificar.Location = new Point(224, 489);
            btn_modificar.Margin = new Padding(3, 2, 3, 2);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(88, 38);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click_1;
            // 
            // lbl_direccion
            // 
            lbl_direccion.AutoSize = true;
            lbl_direccion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_direccion.Location = new Point(351, 176);
            lbl_direccion.Name = "lbl_direccion";
            lbl_direccion.Size = new Size(92, 25);
            lbl_direccion.TabIndex = 16;
            lbl_direccion.Text = "Direccion";
            // 
            // btn_borrar
            // 
            btn_borrar.Location = new Point(353, 489);
            btn_borrar.Margin = new Padding(3, 2, 3, 2);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(88, 38);
            btn_borrar.TabIndex = 3;
            btn_borrar.Text = "Borrar";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(27, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(27, 23);
            txt_id.TabIndex = 0;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_apellido.Location = new Point(359, 102);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(82, 25);
            lbl_apellido.TabIndex = 15;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(27, 56);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(209, 43);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_user_TextChanged_1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(362, 28);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(81, 25);
            lbl_nombre.TabIndex = 14;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(25, 130);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(209, 43);
            txt_pass.TabIndex = 2;
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_correo.Location = new Point(101, 250);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(70, 25);
            lbl_correo.TabIndex = 13;
            lbl_correo.Text = "Correo";
            // 
            // txt_repassword
            // 
            txt_repassword.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_repassword.Location = new Point(27, 204);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.PasswordChar = '*';
            txt_repassword.Size = new Size(209, 43);
            txt_repassword.TabIndex = 3;
            // 
            // lbl_repass
            // 
            lbl_repass.AutoSize = true;
            lbl_repass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_repass.Location = new Point(41, 176);
            lbl_repass.Name = "lbl_repass";
            lbl_repass.Size = new Size(195, 25);
            lbl_repass.TabIndex = 12;
            lbl_repass.Text = "Confirmar contraseña";
            // 
            // txt_telefono
            // 
            txt_telefono.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefono.Location = new Point(301, 278);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(209, 43);
            txt_telefono.TabIndex = 4;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pass.Location = new Point(74, 102);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(108, 25);
            lbl_pass.TabIndex = 11;
            lbl_pass.Text = "Contraseña";
            // 
            // txt_correo
            // 
            txt_correo.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correo.Location = new Point(30, 278);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(209, 43);
            txt_correo.TabIndex = 5;
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(298, 56);
            txt_nombre.Name = "txt_nombre";
            txt_nombre.Size = new Size(209, 43);
            txt_nombre.TabIndex = 6;
            // 
            // lbl_cl_id
            // 
            lbl_cl_id.AutoSize = true;
            lbl_cl_id.Location = new Point(-30, -24);
            lbl_cl_id.Name = "lbl_cl_id";
            lbl_cl_id.Size = new Size(58, 15);
            lbl_cl_id.TabIndex = 9;
            lbl_cl_id.Text = "ID Cliente";
            lbl_cl_id.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_apellido
            // 
            txt_apellido.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_apellido.Location = new Point(296, 130);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(209, 43);
            txt_apellido.TabIndex = 7;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(298, 204);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(209, 43);
            txt_direccion.TabIndex = 8;
            // 
            // lbl_tituloform
            // 
            lbl_tituloform.AutoSize = true;
            lbl_tituloform.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tituloform.Location = new Point(607, 21);
            lbl_tituloform.Name = "lbl_tituloform";
            lbl_tituloform.Size = new Size(428, 50);
            lbl_tituloform.TabIndex = 17;
            lbl_tituloform.Text = "Administrar proveedores";
            // 
            // frmAdministrarProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(lbl_tituloform);
            Controls.Add(pnl_informacion);
            Controls.Add(data_grid_proveedores);
            MaximizeBox = false;
            Name = "frmAdministrarProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar proveedores";
            Load += frmAdministrarProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_proveedores).EndInit();
            pnl_informacion.ResumeLayout(false);
            pnl_informacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_grid_proveedores;
        private Panel pnl_informacion;
        private Label lbl_id;
        private Label lbl_telefono;
        private Button btn_agregar;
        private Label lbl_login;
        private Button btn_modificar;
        private Label lbl_direccion;
        private Button btn_borrar;
        private TextBox txt_id;
        private Label lbl_apellido;
        private TextBox txt_user;
        private Label lbl_nombre;
        private TextBox txt_pass;
        private Label lbl_correo;
        private TextBox txt_repassword;
        private Label lbl_repass;
        private TextBox txt_telefono;
        private Label lbl_pass;
        private TextBox txt_correo;
        private TextBox txt_nombre;
        private Label lbl_cl_id;
        private TextBox txt_apellido;
        private TextBox txt_direccion;
        private Label lbl_empresa;
        private TextBox txt_empresa;
        private Label lbl_tituloform;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Login;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Empresa;
        private DataGridViewTextBoxColumn Estado;
    }
}