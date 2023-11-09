namespace Programacion_Login.Catalogo
{
    partial class frmVerLote
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
            data_grid_animal = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Peso_Promedio = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Imagen = new DataGridViewTextBoxColumn();
            Disponibilidad = new DataGridViewTextBoxColumn();
            pnl_informacion = new Panel();
            lbl_descripcion = new Label();
            txt_descripcion = new RichTextBox();
            cmb_categoria = new ComboBox();
            textBox1 = new TextBox();
            pnl_foto_animal = new Panel();
            pib_imagen = new PictureBox();
            lbl_categoria = new Label();
            lbl_pesoPromedio = new Label();
            txt_pesoPromedio = new TextBox();
            txt_id = new TextBox();
            lbl_id = new Label();
            ((System.ComponentModel.ISupportInitialize)data_grid_animal).BeginInit();
            pnl_informacion.SuspendLayout();
            pnl_foto_animal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pib_imagen).BeginInit();
            SuspendLayout();
            // 
            // data_grid_animal
            // 
            data_grid_animal.AllowUserToAddRows = false;
            data_grid_animal.AllowUserToDeleteRows = false;
            data_grid_animal.AllowUserToResizeColumns = false;
            data_grid_animal.AllowUserToResizeRows = false;
            data_grid_animal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_animal.Columns.AddRange(new DataGridViewColumn[] { ID, Peso_Promedio, Categoria, Descripcion, Imagen, Disponibilidad });
            data_grid_animal.Location = new Point(-4, 0);
            data_grid_animal.Name = "data_grid_animal";
            data_grid_animal.RowTemplate.Height = 25;
            data_grid_animal.ShowCellErrors = false;
            data_grid_animal.ShowRowErrors = false;
            data_grid_animal.Size = new Size(403, 659);
            data_grid_animal.TabIndex = 2;
            data_grid_animal.CellContentClick += data_grid_animal_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Peso_Promedio
            // 
            Peso_Promedio.HeaderText = "Peso promedio";
            Peso_Promedio.Name = "Peso_Promedio";
            Peso_Promedio.Width = 110;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.Name = "Descripcion";
            // 
            // Imagen
            // 
            Imagen.HeaderText = "Imagen";
            Imagen.Name = "Imagen";
            Imagen.Visible = false;
            // 
            // Disponibilidad
            // 
            Disponibilidad.HeaderText = "Disponibilidad";
            Disponibilidad.Name = "Disponibilidad";
            // 
            // pnl_informacion
            // 
            pnl_informacion.Controls.Add(lbl_descripcion);
            pnl_informacion.Controls.Add(txt_descripcion);
            pnl_informacion.Controls.Add(cmb_categoria);
            pnl_informacion.Controls.Add(textBox1);
            pnl_informacion.Controls.Add(pnl_foto_animal);
            pnl_informacion.Controls.Add(lbl_categoria);
            pnl_informacion.Controls.Add(lbl_pesoPromedio);
            pnl_informacion.Controls.Add(txt_pesoPromedio);
            pnl_informacion.Controls.Add(txt_id);
            pnl_informacion.Controls.Add(lbl_id);
            pnl_informacion.Location = new Point(408, 98);
            pnl_informacion.Name = "pnl_informacion";
            pnl_informacion.Size = new Size(682, 562);
            pnl_informacion.TabIndex = 4;
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_descripcion.Location = new Point(278, 113);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(111, 25);
            lbl_descripcion.TabIndex = 19;
            lbl_descripcion.Text = "Descripcion";
            // 
            // txt_descripcion
            // 
            txt_descripcion.Enabled = false;
            txt_descripcion.Location = new Point(77, 141);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(514, 96);
            txt_descripcion.TabIndex = 18;
            txt_descripcion.Text = "";
            // 
            // cmb_categoria
            // 
            cmb_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_categoria.Enabled = false;
            cmb_categoria.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_categoria.FormattingEnabled = true;
            cmb_categoria.Items.AddRange(new object[] { "Equinos", "Novillitos", "Novillos", "Ovinos", "Terneras", "Terneros", "Toros", "Vacas", "Vaquillonas" });
            cmb_categoria.Location = new Point(420, 55);
            cmb_categoria.Name = "cmb_categoria";
            cmb_categoria.Size = new Size(171, 45);
            cmb_categoria.Sorted = true;
            cmb_categoria.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(254, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(47, 43);
            textBox1.TabIndex = 16;
            textBox1.Text = "KG";
            // 
            // pnl_foto_animal
            // 
            pnl_foto_animal.Controls.Add(pib_imagen);
            pnl_foto_animal.Location = new Point(74, 240);
            pnl_foto_animal.Name = "pnl_foto_animal";
            pnl_foto_animal.Size = new Size(520, 199);
            pnl_foto_animal.TabIndex = 12;
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
            // lbl_categoria
            // 
            lbl_categoria.AutoSize = true;
            lbl_categoria.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_categoria.Location = new Point(459, 27);
            lbl_categoria.Name = "lbl_categoria";
            lbl_categoria.Size = new Size(94, 25);
            lbl_categoria.TabIndex = 10;
            lbl_categoria.Text = "Categoria";
            // 
            // lbl_pesoPromedio
            // 
            lbl_pesoPromedio.AutoSize = true;
            lbl_pesoPromedio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pesoPromedio.Location = new Point(99, 27);
            lbl_pesoPromedio.Name = "lbl_pesoPromedio";
            lbl_pesoPromedio.Size = new Size(138, 25);
            lbl_pesoPromedio.TabIndex = 4;
            lbl_pesoPromedio.Text = "Peso promedio";
            // 
            // txt_pesoPromedio
            // 
            txt_pesoPromedio.Enabled = false;
            txt_pesoPromedio.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pesoPromedio.Location = new Point(77, 55);
            txt_pesoPromedio.Name = "txt_pesoPromedio";
            txt_pesoPromedio.Size = new Size(171, 43);
            txt_pesoPromedio.TabIndex = 3;
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(42, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(27, 23);
            txt_id.TabIndex = 2;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(42, -2);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(30, 25);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "ID";
            // 
            // frmVerLote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(pnl_informacion);
            Controls.Add(data_grid_animal);
            MaximizeBox = false;
            Name = "frmVerLote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVerLote";
            Load += frmVerLote_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_animal).EndInit();
            pnl_informacion.ResumeLayout(false);
            pnl_informacion.PerformLayout();
            pnl_foto_animal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pib_imagen).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_grid_animal;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Peso_Promedio;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Imagen;
        private DataGridViewTextBoxColumn Disponibilidad;
        private Panel pnl_informacion;
        private Label lbl_descripcion;
        private RichTextBox txt_descripcion;
        private ComboBox cmb_categoria;
        private TextBox textBox1;
        private Panel pnl_foto_animal;
        private PictureBox pib_imagen;
        private Label lbl_categoria;
        private Label lbl_pesoPromedio;
        private TextBox txt_pesoPromedio;
        private TextBox txt_id;
        private Label lbl_id;
    }
}