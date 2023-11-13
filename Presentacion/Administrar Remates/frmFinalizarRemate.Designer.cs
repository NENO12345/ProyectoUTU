namespace Programacion_Login.Administrar_Remates
{
    partial class frmFinalizarRemate
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
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Base = new DataGridViewTextBoxColumn();
            Precio_final = new DataGridViewTextBoxColumn();
            txt_id = new TextBox();
            lbl_id = new Label();
            btn_vendido = new Button();
            txt_preciofinal = new TextBox();
            lbl_precio = new Label();
            btn_guardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Categoria, Base, Precio_final });
            dataGridView1.Location = new Point(0, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(416, 655);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Base
            // 
            Base.HeaderText = "Base";
            Base.Name = "Base";
            // 
            // Precio_final
            // 
            Precio_final.HeaderText = "Precio final";
            Precio_final.Name = "Precio_final";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(469, 102);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(100, 23);
            txt_id.TabIndex = 1;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(484, 74);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(71, 25);
            lbl_id.TabIndex = 2;
            lbl_id.Text = "ID Lote";
            // 
            // btn_vendido
            // 
            btn_vendido.Location = new Point(480, 274);
            btn_vendido.Name = "btn_vendido";
            btn_vendido.Size = new Size(75, 49);
            btn_vendido.TabIndex = 3;
            btn_vendido.Text = "Vendido";
            btn_vendido.UseVisualStyleBackColor = true;
            btn_vendido.Click += btn_vendido_Click;
            // 
            // txt_preciofinal
            // 
            txt_preciofinal.Location = new Point(469, 197);
            txt_preciofinal.Name = "txt_preciofinal";
            txt_preciofinal.Size = new Size(100, 23);
            txt_preciofinal.TabIndex = 4;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_precio.Location = new Point(469, 169);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(132, 25);
            lbl_precio.TabIndex = 5;
            lbl_precio.Text = "Precio final     ";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(480, 598);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(75, 47);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // frmFinalizarRemate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 657);
            Controls.Add(btn_guardar);
            Controls.Add(lbl_precio);
            Controls.Add(txt_preciofinal);
            Controls.Add(btn_vendido);
            Controls.Add(lbl_id);
            Controls.Add(txt_id);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmFinalizarRemate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFinalizarRemate";
            Load += frmFinalizarRemate_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txt_id;
        private Label lbl_id;
        private Button btn_vendido;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Base;
        private DataGridViewTextBoxColumn Precio_final;
        private TextBox txt_preciofinal;
        private Label lbl_precio;
        private Button btn_guardar;
    }
}