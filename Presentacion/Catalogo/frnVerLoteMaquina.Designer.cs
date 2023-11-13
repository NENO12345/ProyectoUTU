namespace Programacion_Login.Catalogo
{
    partial class frnVerLoteMaquina
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
            data_grid_maquinaria = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Modelo = new DataGridViewTextBoxColumn();
            Kilometraje = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            pnl_informacion = new Panel();
            pnl_foto_maquinaria = new Panel();
            pib_imagen = new PictureBox();
            txt_medida_kilometraje = new TextBox();
            lbl_kilometraje = new Label();
            txt_kilometraje = new TextBox();
            cmb_tipo = new ComboBox();
            lbl_tipo = new Label();
            lbl_modelo = new Label();
            txt_modelo = new TextBox();
            lbl_marca = new Label();
            txt_marca = new TextBox();
            txt_id = new TextBox();
            lbl_id = new Label();
            ((System.ComponentModel.ISupportInitialize)data_grid_maquinaria).BeginInit();
            pnl_informacion.SuspendLayout();
            pnl_foto_maquinaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pib_imagen).BeginInit();
            SuspendLayout();
            // 
            // data_grid_maquinaria
            // 
            data_grid_maquinaria.AllowUserToAddRows = false;
            data_grid_maquinaria.AllowUserToDeleteRows = false;
            data_grid_maquinaria.AllowUserToResizeColumns = false;
            data_grid_maquinaria.AllowUserToResizeRows = false;
            data_grid_maquinaria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_maquinaria.Columns.AddRange(new DataGridViewColumn[] { ID, Marca, Modelo, Kilometraje, Tipo, Imagen, Disponible });
            data_grid_maquinaria.Location = new Point(-1, 0);
            data_grid_maquinaria.Margin = new Padding(3, 2, 3, 2);
            data_grid_maquinaria.MultiSelect = false;
            data_grid_maquinaria.Name = "data_grid_maquinaria";
            data_grid_maquinaria.ReadOnly = true;
            data_grid_maquinaria.RowHeadersWidth = 51;
            data_grid_maquinaria.RowTemplate.Height = 29;
            data_grid_maquinaria.ShowCellErrors = false;
            data_grid_maquinaria.Size = new Size(500, 658);
            data_grid_maquinaria.TabIndex = 17;
            data_grid_maquinaria.CellContentClick += data_grid_maquinaria_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // Marca
            // 
            Marca.HeaderText = "Marca";
            Marca.MinimumWidth = 6;
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            Marca.Width = 125;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.Name = "Modelo";
            Modelo.ReadOnly = true;
            // 
            // Kilometraje
            // 
            Kilometraje.HeaderText = "Kilometraje";
            Kilometraje.Name = "Kilometraje";
            Kilometraje.ReadOnly = true;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.ReadOnly = true;
            Imagen.Visible = false;
            // 
            // Disponible
            // 
            Disponible.HeaderText = "Disponible";
            Disponible.Name = "Disponible";
            Disponible.ReadOnly = true;
            // 
            // pnl_informacion
            // 
            pnl_informacion.Controls.Add(pnl_foto_maquinaria);
            pnl_informacion.Controls.Add(txt_medida_kilometraje);
            pnl_informacion.Controls.Add(lbl_kilometraje);
            pnl_informacion.Controls.Add(txt_kilometraje);
            pnl_informacion.Controls.Add(cmb_tipo);
            pnl_informacion.Controls.Add(lbl_tipo);
            pnl_informacion.Controls.Add(lbl_modelo);
            pnl_informacion.Controls.Add(txt_modelo);
            pnl_informacion.Controls.Add(lbl_marca);
            pnl_informacion.Controls.Add(txt_marca);
            pnl_informacion.Controls.Add(txt_id);
            pnl_informacion.Controls.Add(lbl_id);
            pnl_informacion.Location = new Point(499, 96);
            pnl_informacion.Name = "pnl_informacion";
            pnl_informacion.Size = new Size(593, 562);
            pnl_informacion.TabIndex = 18;
            // 
            // pnl_foto_maquinaria
            // 
            pnl_foto_maquinaria.Controls.Add(pib_imagen);
            pnl_foto_maquinaria.Location = new Point(33, 238);
            pnl_foto_maquinaria.Name = "pnl_foto_maquinaria";
            pnl_foto_maquinaria.Size = new Size(520, 199);
            pnl_foto_maquinaria.TabIndex = 12;
            // 
            // pib_imagen
            // 
            pib_imagen.BackColor = Color.Gray;
            pib_imagen.Location = new Point(3, 3);
            pib_imagen.Name = "pib_imagen";
            pib_imagen.Size = new Size(514, 194);
            pib_imagen.TabIndex = 1;
            pib_imagen.TabStop = false;
            // 
            // txt_medida_kilometraje
            // 
            txt_medida_kilometraje.Enabled = false;
            txt_medida_kilometraje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_medida_kilometraje.Location = new Point(506, 71);
            txt_medida_kilometraje.Name = "txt_medida_kilometraje";
            txt_medida_kilometraje.Size = new Size(47, 29);
            txt_medida_kilometraje.TabIndex = 11;
            txt_medida_kilometraje.Text = "KM";
            // 
            // lbl_kilometraje
            // 
            lbl_kilometraje.AutoSize = true;
            lbl_kilometraje.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_kilometraje.Location = new Point(397, 43);
            lbl_kilometraje.Name = "lbl_kilometraje";
            lbl_kilometraje.Size = new Size(108, 25);
            lbl_kilometraje.TabIndex = 10;
            lbl_kilometraje.Text = "Kilometraje";
            // 
            // txt_kilometraje
            // 
            txt_kilometraje.Enabled = false;
            txt_kilometraje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kilometraje.Location = new Point(344, 71);
            txt_kilometraje.Name = "txt_kilometraje";
            txt_kilometraje.Size = new Size(161, 29);
            txt_kilometraje.TabIndex = 9;
            // 
            // cmb_tipo
            // 
            cmb_tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_tipo.Enabled = false;
            cmb_tipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_tipo.FormattingEnabled = true;
            cmb_tipo.ItemHeight = 21;
            cmb_tipo.Items.AddRange(new object[] { "Cabezal", "Cargador de caña", "Cargadora frontal", "Cosechadora", "Cosechadora de caña", "Desmalezadoras", "Equipo de forraje", "Labranza", "Picadora de forraje", "Pulverizadora", "Sembradora", "Tolva", "Tractor" });
            cmb_tipo.Location = new Point(263, 152);
            cmb_tipo.Name = "cmb_tipo";
            cmb_tipo.Size = new Size(289, 29);
            cmb_tipo.Sorted = true;
            cmb_tipo.TabIndex = 8;
            // 
            // lbl_tipo
            // 
            lbl_tipo.AutoSize = true;
            lbl_tipo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tipo.Location = new Point(313, 126);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(176, 25);
            lbl_tipo.TabIndex = 7;
            lbl_tipo.Text = "Tipo de maquinaria";
            // 
            // lbl_modelo
            // 
            lbl_modelo.AutoSize = true;
            lbl_modelo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_modelo.Location = new Point(100, 126);
            lbl_modelo.Name = "lbl_modelo";
            lbl_modelo.Size = new Size(77, 25);
            lbl_modelo.TabIndex = 6;
            lbl_modelo.Text = "Modelo";
            // 
            // txt_modelo
            // 
            txt_modelo.Enabled = false;
            txt_modelo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_modelo.Location = new Point(33, 154);
            txt_modelo.Name = "txt_modelo";
            txt_modelo.Size = new Size(209, 29);
            txt_modelo.TabIndex = 5;
            // 
            // lbl_marca
            // 
            lbl_marca.AutoSize = true;
            lbl_marca.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_marca.Location = new Point(100, 43);
            lbl_marca.Name = "lbl_marca";
            lbl_marca.Size = new Size(65, 25);
            lbl_marca.TabIndex = 4;
            lbl_marca.Text = "Marca";
            // 
            // txt_marca
            // 
            txt_marca.Enabled = false;
            txt_marca.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_marca.Location = new Point(33, 71);
            txt_marca.Name = "txt_marca";
            txt_marca.Size = new Size(209, 29);
            txt_marca.TabIndex = 3;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(33, 28);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(27, 23);
            txt_id.TabIndex = 2;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(30, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(30, 25);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "ID";
            // 
            // frnVerLoteMaquina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(pnl_informacion);
            Controls.Add(data_grid_maquinaria);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frnVerLoteMaquina";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lote maquina";
            Load += frnVerLoteMaquina_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_maquinaria).EndInit();
            pnl_informacion.ResumeLayout(false);
            pnl_informacion.PerformLayout();
            pnl_foto_maquinaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pib_imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_grid_maquinaria;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Kilometraje;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Imagen;
        private DataGridViewTextBoxColumn Disponible;
        private Panel pnl_informacion;
        private Panel pnl_foto_maquinaria;
        private PictureBox pib_imagen;
        private TextBox txt_medida_kilometraje;
        private Label lbl_kilometraje;
        private TextBox txt_kilometraje;
        private ComboBox cmb_tipo;
        private Label lbl_tipo;
        private Label lbl_modelo;
        private TextBox txt_modelo;
        private Label lbl_marca;
        private TextBox txt_marca;
        private TextBox txt_id;
        private Label lbl_id;
    }
}