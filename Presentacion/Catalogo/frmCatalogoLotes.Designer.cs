namespace Programacion_Login.Catalogo
{
    partial class frmCatalogoLotes
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
            data_grid_lotes = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Base = new DataGridViewTextBoxColumn();
            Precio_final = new DataGridViewTextBoxColumn();
            Vendido = new DataGridViewTextBoxColumn();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid_lotes).BeginInit();
            SuspendLayout();
            // 
            // data_grid_lotes
            // 
            data_grid_lotes.AllowUserToAddRows = false;
            data_grid_lotes.AllowUserToDeleteRows = false;
            data_grid_lotes.AllowUserToResizeColumns = false;
            data_grid_lotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_lotes.Columns.AddRange(new DataGridViewColumn[] { ID, Categoria, Base, Precio_final, Vendido });
            data_grid_lotes.Location = new Point(1, 0);
            data_grid_lotes.MultiSelect = false;
            data_grid_lotes.Name = "data_grid_lotes";
            data_grid_lotes.ReadOnly = true;
            data_grid_lotes.RowTemplate.Height = 25;
            data_grid_lotes.Size = new Size(525, 582);
            data_grid_lotes.TabIndex = 1;
            data_grid_lotes.CellContentClick += data_grid_lotes_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Base
            // 
            Base.HeaderText = "Base";
            Base.Name = "Base";
            Base.ReadOnly = true;
            Base.Width = 80;
            // 
            // Precio_final
            // 
            Precio_final.HeaderText = "Precio final";
            Precio_final.Name = "Precio_final";
            Precio_final.ReadOnly = true;
            // 
            // Vendido
            // 
            Vendido.HeaderText = "Vendido";
            Vendido.Name = "Vendido";
            Vendido.ReadOnly = true;
            // 
            // button1
            // 
            button1.Location = new Point(1, 582);
            button1.Name = "button1";
            button1.Size = new Size(525, 76);
            button1.TabIndex = 2;
            button1.Text = "Ver lote";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCatalogoLotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 657);
            Controls.Add(button1);
            Controls.Add(data_grid_lotes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCatalogoLotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogo";
            Load += frmCatalogoLotes_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_lotes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_grid_lotes;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Base;
        private DataGridViewTextBoxColumn Precio_final;
        private DataGridViewTextBoxColumn Vendido;
        private Button button1;
    }
}