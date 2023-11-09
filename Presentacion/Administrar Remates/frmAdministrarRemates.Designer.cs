namespace Programacion_Login.Administrar_Remates
{
    partial class frmAdministrarRemates
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
            data_grid_remates = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Finalizado = new DataGridViewTextBoxColumn();
            lbl_fecha = new Label();
            txt_id = new TextBox();
            lbl_id = new Label();
            lbl_sacar = new Label();
            lbl_agregar = new Label();
            lbl_LotesDisponibles = new Label();
            lbl_remate = new Label();
            btn_eliminar = new Button();
            btn_crear = new Button();
            button2 = new Button();
            button1 = new Button();
            list_lotes = new ListBox();
            list_remates = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            cmb_rematador = new ComboBox();
            btn_modificar = new Button();
            btn_finalizar = new Button();
            btn_inventario = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid_remates).BeginInit();
            SuspendLayout();
            // 
            // data_grid_remates
            // 
            data_grid_remates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_remates.Columns.AddRange(new DataGridViewColumn[] { ID, Fecha, Empleado, Finalizado });
            data_grid_remates.Location = new Point(1, -1);
            data_grid_remates.Name = "data_grid_remates";
            data_grid_remates.RowTemplate.Height = 25;
            data_grid_remates.Size = new Size(442, 657);
            data_grid_remates.TabIndex = 1;
            data_grid_remates.CellContentClick += data_grid_remates_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.Name = "Empleado";
            // 
            // Finalizado
            // 
            Finalizado.HeaderText = "Finalizado";
            Finalizado.Name = "Finalizado";
            // 
            // lbl_fecha
            // 
            lbl_fecha.AutoSize = true;
            lbl_fecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_fecha.Location = new Point(896, 175);
            lbl_fecha.Name = "lbl_fecha";
            lbl_fecha.Size = new Size(61, 25);
            lbl_fecha.TabIndex = 34;
            lbl_fecha.Text = "Fecha";
            // 
            // txt_id
            // 
            txt_id.Enabled = false;
            txt_id.Location = new Point(509, 149);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(73, 23);
            txt_id.TabIndex = 32;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_id.Location = new Point(497, 121);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(97, 25);
            lbl_id.TabIndex = 31;
            lbl_id.Text = "ID Remate";
            // 
            // lbl_sacar
            // 
            lbl_sacar.AutoSize = true;
            lbl_sacar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sacar.Location = new Point(733, 483);
            lbl_sacar.Name = "lbl_sacar";
            lbl_sacar.Size = new Size(48, 21);
            lbl_sacar.TabIndex = 29;
            lbl_sacar.Text = "Sacar";
            // 
            // lbl_agregar
            // 
            lbl_agregar.AutoSize = true;
            lbl_agregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_agregar.Location = new Point(724, 343);
            lbl_agregar.Name = "lbl_agregar";
            lbl_agregar.Size = new Size(66, 21);
            lbl_agregar.TabIndex = 28;
            lbl_agregar.Text = "Agregar";
            // 
            // lbl_LotesDisponibles
            // 
            lbl_LotesDisponibles.AutoSize = true;
            lbl_LotesDisponibles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LotesDisponibles.Location = new Point(827, 283);
            lbl_LotesDisponibles.Name = "lbl_LotesDisponibles";
            lbl_LotesDisponibles.Size = new Size(157, 25);
            lbl_LotesDisponibles.TabIndex = 27;
            lbl_LotesDisponibles.Text = "Lotes disponibles";
            // 
            // lbl_remate
            // 
            lbl_remate.AutoSize = true;
            lbl_remate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_remate.Location = new Point(560, 283);
            lbl_remate.Name = "lbl_remate";
            lbl_remate.Size = new Size(74, 25);
            lbl_remate.TabIndex = 26;
            lbl_remate.Text = "Remate";
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminar.Location = new Point(905, 604);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(109, 40);
            btn_eliminar.TabIndex = 25;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_crear
            // 
            btn_crear.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_crear.Location = new Point(505, 604);
            btn_crear.Name = "btn_crear";
            btn_crear.Size = new Size(109, 40);
            btn_crear.TabIndex = 23;
            btn_crear.Text = "Crear";
            btn_crear.UseVisualStyleBackColor = true;
            btn_crear.Click += btn_crear_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(712, 507);
            button2.Name = "button2";
            button2.Size = new Size(93, 31);
            button2.TabIndex = 21;
            button2.Text = ">>>>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(712, 367);
            button1.Name = "button1";
            button1.Size = new Size(93, 31);
            button1.TabIndex = 20;
            button1.Text = "<<<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // list_lotes
            // 
            list_lotes.FormattingEnabled = true;
            list_lotes.ItemHeight = 15;
            list_lotes.Location = new Point(827, 311);
            list_lotes.Name = "list_lotes";
            list_lotes.Size = new Size(190, 274);
            list_lotes.TabIndex = 19;
            // 
            // list_remates
            // 
            list_remates.FormattingEnabled = true;
            list_remates.ItemHeight = 15;
            list_remates.Location = new Point(505, 311);
            list_remates.Name = "list_remates";
            list_remates.Size = new Size(190, 274);
            list_remates.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(827, 203);
            dateTimePicker1.MinDate = new DateTime(2023, 10, 14, 12, 30, 43, 121);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 35;
            dateTimePicker1.Value = new DateTime(2023, 10, 14, 12, 30, 43, 121);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(878, 121);
            label2.Name = "label2";
            label2.Size = new Size(103, 25);
            label2.TabIndex = 37;
            label2.Text = "Rematador";
            // 
            // cmb_rematador
            // 
            cmb_rematador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_rematador.FormattingEnabled = true;
            cmb_rematador.Location = new Point(827, 149);
            cmb_rematador.Name = "cmb_rematador";
            cmb_rematador.Size = new Size(197, 23);
            cmb_rematador.TabIndex = 38;
            cmb_rematador.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btn_modificar
            // 
            btn_modificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar.Location = new Point(712, 605);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(109, 40);
            btn_modificar.TabIndex = 39;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = true;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_finalizar
            // 
            btn_finalizar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_finalizar.Location = new Point(497, 180);
            btn_finalizar.Name = "btn_finalizar";
            btn_finalizar.Size = new Size(97, 69);
            btn_finalizar.TabIndex = 40;
            btn_finalizar.Text = "Finalizar remate";
            btn_finalizar.UseVisualStyleBackColor = true;
            btn_finalizar.Click += btn_finalizar_Click;
            // 
            // btn_inventario
            // 
            btn_inventario.Location = new Point(827, 246);
            btn_inventario.Name = "btn_inventario";
            btn_inventario.Size = new Size(197, 23);
            btn_inventario.TabIndex = 41;
            btn_inventario.Text = "Ver inventario";
            btn_inventario.UseVisualStyleBackColor = true;
            btn_inventario.Click += btn_inventario_Click;
            // 
            // frmAdministrarRemates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(btn_inventario);
            Controls.Add(btn_finalizar);
            Controls.Add(btn_modificar);
            Controls.Add(cmb_rematador);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_fecha);
            Controls.Add(txt_id);
            Controls.Add(lbl_id);
            Controls.Add(lbl_sacar);
            Controls.Add(lbl_agregar);
            Controls.Add(lbl_LotesDisponibles);
            Controls.Add(lbl_remate);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_crear);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(list_lotes);
            Controls.Add(list_remates);
            Controls.Add(data_grid_remates);
            MaximizeBox = false;
            Name = "frmAdministrarRemates";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar remates";
            Load += frmAdministrarRemates_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_remates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView data_grid_remates;
        private Label lbl_fecha;
        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_sacar;
        private Label lbl_agregar;
        private Label lbl_LotesDisponibles;
        private Label lbl_remate;
        private Button btn_eliminar;
        private Button btn_crear;
        private Button button2;
        private Button button1;
        private ListBox list_lotes;
        private ListBox list_remates;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private ComboBox cmb_rematador;
        private Button btn_modificar;
        private Button btn_finalizar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Finalizado;
        private Button btn_inventario;
    }
}