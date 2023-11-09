namespace Programacion_Login.Administrar_Personas
{
    partial class frmAdministrarRematadores
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
            data_grid_rematadores = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Contraseña = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            pnl_informacion = new Panel();
            lbl_id = new Label();
            lbl_telefono = new Label();
            btn_agregar = new Button();
            lbl_user = new Label();
            btn_modificar = new Button();
            lbl_direccion = new Label();
            btn_borrar = new Button();
            txt_id = new TextBox();
            lbl_apellido = new Label();
            txt_user = new TextBox();
            lbl_nombre = new Label();
            txt_pass = new TextBox();
            txt_repassword = new TextBox();
            lbl_repass = new Label();
            txt_telefono = new TextBox();
            lbl_pass = new Label();
            txt_nombre = new TextBox();
            lbl_cl_id = new Label();
            txt_apellido = new TextBox();
            txt_direccion = new TextBox();
            lbl_tituloform = new Label();
            ((System.ComponentModel.ISupportInitialize)data_grid_rematadores).BeginInit();
            pnl_informacion.SuspendLayout();
            SuspendLayout();
            // 
            // data_grid_rematadores
            // 
            data_grid_rematadores.AllowUserToAddRows = false;
            data_grid_rematadores.AllowUserToDeleteRows = false;
            data_grid_rematadores.AllowUserToResizeColumns = false;
            data_grid_rematadores.AllowUserToResizeRows = false;
            data_grid_rematadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_rematadores.Columns.AddRange(new DataGridViewColumn[] { ID, Usuario, Contraseña, Nombre, Apellido, Direccion, Telefono, Estado });
            data_grid_rematadores.Location = new Point(-2, -1);
            data_grid_rematadores.Margin = new Padding(3, 2, 3, 2);
            data_grid_rematadores.MultiSelect = false;
            data_grid_rematadores.Name = "data_grid_rematadores";
            data_grid_rematadores.ReadOnly = true;
            data_grid_rematadores.RowHeadersWidth = 51;
            data_grid_rematadores.RowTemplate.Height = 29;
            data_grid_rematadores.Size = new Size(549, 658);
            data_grid_rematadores.TabIndex = 2;
            data_grid_rematadores.CellContentClick += data_grid_rematadores_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 125;
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
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // pnl_informacion
            // 
            pnl_informacion.Controls.Add(lbl_id);
            pnl_informacion.Controls.Add(lbl_telefono);
            pnl_informacion.Controls.Add(btn_agregar);
            pnl_informacion.Controls.Add(lbl_user);
            pnl_informacion.Controls.Add(btn_modificar);
            pnl_informacion.Controls.Add(lbl_direccion);
            pnl_informacion.Controls.Add(btn_borrar);
            pnl_informacion.Controls.Add(txt_id);
            pnl_informacion.Controls.Add(lbl_apellido);
            pnl_informacion.Controls.Add(txt_user);
            pnl_informacion.Controls.Add(lbl_nombre);
            pnl_informacion.Controls.Add(txt_pass);
            pnl_informacion.Controls.Add(txt_repassword);
            pnl_informacion.Controls.Add(lbl_repass);
            pnl_informacion.Controls.Add(txt_telefono);
            pnl_informacion.Controls.Add(lbl_pass);
            pnl_informacion.Controls.Add(txt_nombre);
            pnl_informacion.Controls.Add(lbl_cl_id);
            pnl_informacion.Controls.Add(txt_apellido);
            pnl_informacion.Controls.Add(txt_direccion);
            pnl_informacion.Location = new Point(553, 95);
            pnl_informacion.Name = "pnl_informacion";
            pnl_informacion.Size = new Size(543, 562);
            pnl_informacion.TabIndex = 17;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(24, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(30, 25);
            lbl_id.TabIndex = 18;
            lbl_id.Text = "ID";
            // 
            // lbl_telefono
            // 
            lbl_telefono.AutoSize = true;
            lbl_telefono.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefono.Location = new Point(356, 176);
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
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user.Location = new Point(95, 26);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(59, 25);
            lbl_user.TabIndex = 10;
            lbl_user.Text = "Login";
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
            lbl_direccion.Location = new Point(348, 100);
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
            btn_borrar.Click += btn_borrar_Click_1;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(24, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(27, 23);
            txt_id.TabIndex = 0;
            // 
            // lbl_apellido
            // 
            lbl_apellido.AutoSize = true;
            lbl_apellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_apellido.Location = new Point(358, 26);
            lbl_apellido.Name = "lbl_apellido";
            lbl_apellido.Size = new Size(82, 25);
            lbl_apellido.TabIndex = 15;
            lbl_apellido.Text = "Apellido";
            // 
            // txt_user
            // 
            txt_user.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.Location = new Point(24, 54);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(209, 43);
            txt_user.TabIndex = 1;
            txt_user.TextChanged += txt_login_TextChanged_1;
            // 
            // lbl_nombre
            // 
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre.Location = new Point(91, 250);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(81, 25);
            lbl_nombre.TabIndex = 14;
            lbl_nombre.Text = "Nombre";
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.Location = new Point(27, 128);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(209, 43);
            txt_pass.TabIndex = 2;
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
            txt_telefono.Location = new Point(295, 204);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(209, 43);
            txt_telefono.TabIndex = 4;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pass.Location = new Point(76, 100);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(108, 25);
            lbl_pass.TabIndex = 11;
            lbl_pass.Text = "Contraseña";
            // 
            // txt_nombre
            // 
            txt_nombre.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_nombre.Location = new Point(27, 278);
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
            txt_apellido.Location = new Point(295, 54);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(209, 43);
            txt_apellido.TabIndex = 7;
            // 
            // txt_direccion
            // 
            txt_direccion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_direccion.Location = new Point(295, 128);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(209, 43);
            txt_direccion.TabIndex = 8;
            // 
            // lbl_tituloform
            // 
            lbl_tituloform.AutoSize = true;
            lbl_tituloform.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tituloform.Location = new Point(629, 19);
            lbl_tituloform.Name = "lbl_tituloform";
            lbl_tituloform.Size = new Size(430, 50);
            lbl_tituloform.TabIndex = 19;
            lbl_tituloform.Text = "Administrar rematadores";
            // 
            // frmAdministrarRematadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(lbl_tituloform);
            Controls.Add(pnl_informacion);
            Controls.Add(data_grid_rematadores);
            MaximizeBox = false;
            Name = "frmAdministrarRematadores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar rematadores";
            Load += frmAdministrar_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_rematadores).EndInit();
            pnl_informacion.ResumeLayout(false);
            pnl_informacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_grid_rematadores;
        private Panel pnl_informacion;
        private Label lbl_id;
        private Label lbl_telefono;
        private Button btn_agregar;
        private Label lbl_user;
        private Button btn_modificar;
        private Label lbl_direccion;
        private Button btn_borrar;
        private TextBox txt_id;
        private Label lbl_apellido;
        private TextBox txt_user;
        private Label lbl_nombre;
        private TextBox txt_pass;
        private TextBox txt_repassword;
        private Label lbl_repass;
        private TextBox txt_telefono;
        private Label lbl_pass;
        private TextBox txt_nombre;
        private Label lbl_cl_id;
        private TextBox txt_apellido;
        private TextBox txt_direccion;
        private Label lbl_tituloform;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Contraseña;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estado;
    }
}