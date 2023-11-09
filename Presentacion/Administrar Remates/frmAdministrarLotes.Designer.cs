namespace Programacion_Login.Administrar_remates
{
    partial class frmAdministrarLotes
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
            data_grid_lotesAnimal = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Base = new DataGridViewTextBoxColumn();
            Precio_final = new DataGridViewTextBoxColumn();
            Vendido = new DataGridViewTextBoxColumn();
            list_loteAnimal = new ListBox();
            list_animales = new ListBox();
            btn_agregar = new Button();
            btn_sacar = new Button();
            btn_guardar_loteAnimal = new Button();
            btn_eliminarLoteAnimal = new Button();
            lbl_loteAnimal = new Label();
            lbl_animalesDisponibles = new Label();
            lbl_agregar = new Label();
            lbl_sacar = new Label();
            lbl_idLoteAnimal = new Label();
            txt_idLoteAnimal = new TextBox();
            txt_baseAnimal = new TextBox();
            lbl_baseAnimal = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btn_modificar_animal = new Button();
            tabPage2 = new TabPage();
            btn_modificarLoteMaquina = new Button();
            lbl_maquinasDisponibles = new Label();
            btn_eliminarLoteMaquina = new Button();
            txt_baseMaquina = new TextBox();
            list_maquinas = new ListBox();
            lbl_baseMaquina = new Label();
            list_loteMaquina = new ListBox();
            txt_IDloteMaquinas = new TextBox();
            lbl_LoteMaquina = new Label();
            lbl_agregarMaquina = new Label();
            lbl_SacarMaquina = new Label();
            lbl_maquinaLote = new Label();
            btn_guardar_loteMaquina = new Button();
            btn_sacarMaquina = new Button();
            btn_agregarMaquina = new Button();
            data_grid_lotesMaquina = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)data_grid_lotesAnimal).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid_lotesMaquina).BeginInit();
            SuspendLayout();
            // 
            // data_grid_lotesAnimal
            // 
            data_grid_lotesAnimal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_lotesAnimal.Columns.AddRange(new DataGridViewColumn[] { ID, Categoria, Base, Precio_final, Vendido });
            data_grid_lotesAnimal.Location = new Point(-4, 0);
            data_grid_lotesAnimal.Name = "data_grid_lotesAnimal";
            data_grid_lotesAnimal.RowTemplate.Height = 25;
            data_grid_lotesAnimal.Size = new Size(442, 635);
            data_grid_lotesAnimal.TabIndex = 0;
            data_grid_lotesAnimal.CellContentClick += data_grid_lotes_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 50;
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
            Base.Width = 50;
            // 
            // Precio_final
            // 
            Precio_final.HeaderText = "Precio final";
            Precio_final.Name = "Precio_final";
            // 
            // Vendido
            // 
            Vendido.HeaderText = "Vendido";
            Vendido.Name = "Vendido";
            // 
            // list_loteAnimal
            // 
            list_loteAnimal.FormattingEnabled = true;
            list_loteAnimal.ItemHeight = 15;
            list_loteAnimal.Location = new Point(465, 254);
            list_loteAnimal.Name = "list_loteAnimal";
            list_loteAnimal.Size = new Size(190, 274);
            list_loteAnimal.TabIndex = 1;
            // 
            // list_animales
            // 
            list_animales.FormattingEnabled = true;
            list_animales.ItemHeight = 15;
            list_animales.Location = new Point(861, 254);
            list_animales.Name = "list_animales";
            list_animales.Size = new Size(190, 274);
            list_animales.TabIndex = 2;
            // 
            // btn_agregar
            // 
            btn_agregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_agregar.Location = new Point(716, 339);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(93, 31);
            btn_agregar.TabIndex = 3;
            btn_agregar.Text = "<<<<";
            btn_agregar.UseVisualStyleBackColor = true;
            btn_agregar.Click += button1_Click;
            // 
            // btn_sacar
            // 
            btn_sacar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sacar.Location = new Point(716, 445);
            btn_sacar.Name = "btn_sacar";
            btn_sacar.Size = new Size(93, 31);
            btn_sacar.TabIndex = 4;
            btn_sacar.Text = ">>>>";
            btn_sacar.UseVisualStyleBackColor = true;
            btn_sacar.Click += button2_Click;
            // 
            // btn_guardar_loteAnimal
            // 
            btn_guardar_loteAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar_loteAnimal.Location = new Point(505, 554);
            btn_guardar_loteAnimal.Name = "btn_guardar_loteAnimal";
            btn_guardar_loteAnimal.Size = new Size(109, 40);
            btn_guardar_loteAnimal.TabIndex = 6;
            btn_guardar_loteAnimal.Text = "Crear";
            btn_guardar_loteAnimal.UseVisualStyleBackColor = true;
            btn_guardar_loteAnimal.Click += btn_crear_Click;
            // 
            // btn_eliminarLoteAnimal
            // 
            btn_eliminarLoteAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminarLoteAnimal.Location = new Point(903, 554);
            btn_eliminarLoteAnimal.Name = "btn_eliminarLoteAnimal";
            btn_eliminarLoteAnimal.Size = new Size(109, 40);
            btn_eliminarLoteAnimal.TabIndex = 8;
            btn_eliminarLoteAnimal.Text = "Eliminar";
            btn_eliminarLoteAnimal.UseVisualStyleBackColor = true;
            btn_eliminarLoteAnimal.Click += btn_eliminarLoteAnimal_Click;
            // 
            // lbl_loteAnimal
            // 
            lbl_loteAnimal.AutoSize = true;
            lbl_loteAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loteAnimal.Location = new Point(534, 226);
            lbl_loteAnimal.Name = "lbl_loteAnimal";
            lbl_loteAnimal.Size = new Size(48, 25);
            lbl_loteAnimal.TabIndex = 9;
            lbl_loteAnimal.Text = "Lote";
            // 
            // lbl_animalesDisponibles
            // 
            lbl_animalesDisponibles.AutoSize = true;
            lbl_animalesDisponibles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_animalesDisponibles.Location = new Point(861, 225);
            lbl_animalesDisponibles.Name = "lbl_animalesDisponibles";
            lbl_animalesDisponibles.Size = new Size(190, 25);
            lbl_animalesDisponibles.TabIndex = 10;
            lbl_animalesDisponibles.Text = "Animales disponibles";
            // 
            // lbl_agregar
            // 
            lbl_agregar.AutoSize = true;
            lbl_agregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_agregar.Location = new Point(729, 315);
            lbl_agregar.Name = "lbl_agregar";
            lbl_agregar.Size = new Size(66, 21);
            lbl_agregar.TabIndex = 11;
            lbl_agregar.Text = "Agregar";
            // 
            // lbl_sacar
            // 
            lbl_sacar.AutoSize = true;
            lbl_sacar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sacar.Location = new Point(738, 421);
            lbl_sacar.Name = "lbl_sacar";
            lbl_sacar.Size = new Size(48, 21);
            lbl_sacar.TabIndex = 12;
            lbl_sacar.Text = "Sacar";
            // 
            // lbl_idLoteAnimal
            // 
            lbl_idLoteAnimal.AutoSize = true;
            lbl_idLoteAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_idLoteAnimal.Location = new Point(522, 140);
            lbl_idLoteAnimal.Name = "lbl_idLoteAnimal";
            lbl_idLoteAnimal.Size = new Size(71, 25);
            lbl_idLoteAnimal.TabIndex = 14;
            lbl_idLoteAnimal.Text = "ID Lote";
            // 
            // txt_idLoteAnimal
            // 
            txt_idLoteAnimal.Enabled = false;
            txt_idLoteAnimal.Location = new Point(525, 168);
            txt_idLoteAnimal.Name = "txt_idLoteAnimal";
            txt_idLoteAnimal.Size = new Size(68, 23);
            txt_idLoteAnimal.TabIndex = 15;
            // 
            // txt_baseAnimal
            // 
            txt_baseAnimal.Location = new Point(864, 167);
            txt_baseAnimal.Name = "txt_baseAnimal";
            txt_baseAnimal.Size = new Size(187, 23);
            txt_baseAnimal.TabIndex = 16;
            // 
            // lbl_baseAnimal
            // 
            lbl_baseAnimal.AutoSize = true;
            lbl_baseAnimal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_baseAnimal.Location = new Point(932, 139);
            lbl_baseAnimal.Name = "lbl_baseAnimal";
            lbl_baseAnimal.Size = new Size(51, 25);
            lbl_baseAnimal.TabIndex = 17;
            lbl_baseAnimal.Text = "Base";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1090, 659);
            tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btn_modificar_animal);
            tabPage1.Controls.Add(data_grid_lotesAnimal);
            tabPage1.Controls.Add(lbl_animalesDisponibles);
            tabPage1.Controls.Add(btn_eliminarLoteAnimal);
            tabPage1.Controls.Add(txt_baseAnimal);
            tabPage1.Controls.Add(list_animales);
            tabPage1.Controls.Add(lbl_baseAnimal);
            tabPage1.Controls.Add(list_loteAnimal);
            tabPage1.Controls.Add(txt_idLoteAnimal);
            tabPage1.Controls.Add(lbl_idLoteAnimal);
            tabPage1.Controls.Add(lbl_agregar);
            tabPage1.Controls.Add(lbl_sacar);
            tabPage1.Controls.Add(lbl_loteAnimal);
            tabPage1.Controls.Add(btn_guardar_loteAnimal);
            tabPage1.Controls.Add(btn_sacar);
            tabPage1.Controls.Add(btn_agregar);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1082, 631);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lote animal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_modificar_animal
            // 
            btn_modificar_animal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificar_animal.Location = new Point(700, 554);
            btn_modificar_animal.Name = "btn_modificar_animal";
            btn_modificar_animal.Size = new Size(109, 40);
            btn_modificar_animal.TabIndex = 18;
            btn_modificar_animal.Text = "Modificar";
            btn_modificar_animal.UseVisualStyleBackColor = true;
            btn_modificar_animal.Click += btn_modificar_animal_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btn_modificarLoteMaquina);
            tabPage2.Controls.Add(lbl_maquinasDisponibles);
            tabPage2.Controls.Add(btn_eliminarLoteMaquina);
            tabPage2.Controls.Add(txt_baseMaquina);
            tabPage2.Controls.Add(list_maquinas);
            tabPage2.Controls.Add(lbl_baseMaquina);
            tabPage2.Controls.Add(list_loteMaquina);
            tabPage2.Controls.Add(txt_IDloteMaquinas);
            tabPage2.Controls.Add(lbl_LoteMaquina);
            tabPage2.Controls.Add(lbl_agregarMaquina);
            tabPage2.Controls.Add(lbl_SacarMaquina);
            tabPage2.Controls.Add(lbl_maquinaLote);
            tabPage2.Controls.Add(btn_guardar_loteMaquina);
            tabPage2.Controls.Add(btn_sacarMaquina);
            tabPage2.Controls.Add(btn_agregarMaquina);
            tabPage2.Controls.Add(data_grid_lotesMaquina);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1082, 631);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lote maquina";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_modificarLoteMaquina
            // 
            btn_modificarLoteMaquina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_modificarLoteMaquina.Location = new Point(701, 555);
            btn_modificarLoteMaquina.Name = "btn_modificarLoteMaquina";
            btn_modificarLoteMaquina.Size = new Size(109, 40);
            btn_modificarLoteMaquina.TabIndex = 32;
            btn_modificarLoteMaquina.Text = "Modificar";
            btn_modificarLoteMaquina.UseVisualStyleBackColor = true;
            btn_modificarLoteMaquina.Click += btn_modificarLoteMaquina_Click;
            // 
            // lbl_maquinasDisponibles
            // 
            lbl_maquinasDisponibles.AutoSize = true;
            lbl_maquinasDisponibles.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_maquinasDisponibles.Location = new Point(862, 227);
            lbl_maquinasDisponibles.Name = "lbl_maquinasDisponibles";
            lbl_maquinasDisponibles.Size = new Size(196, 25);
            lbl_maquinasDisponibles.TabIndex = 31;
            lbl_maquinasDisponibles.Text = "Maquinas disponibles";
            // 
            // btn_eliminarLoteMaquina
            // 
            btn_eliminarLoteMaquina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_eliminarLoteMaquina.Location = new Point(904, 555);
            btn_eliminarLoteMaquina.Name = "btn_eliminarLoteMaquina";
            btn_eliminarLoteMaquina.Size = new Size(109, 40);
            btn_eliminarLoteMaquina.TabIndex = 23;
            btn_eliminarLoteMaquina.Text = "Eliminar";
            btn_eliminarLoteMaquina.UseVisualStyleBackColor = true;
            btn_eliminarLoteMaquina.Click += btn_eliminarLoteMaquina_Click;
            // 
            // txt_baseMaquina
            // 
            txt_baseMaquina.Location = new Point(865, 168);
            txt_baseMaquina.Name = "txt_baseMaquina";
            txt_baseMaquina.Size = new Size(187, 23);
            txt_baseMaquina.TabIndex = 29;
            // 
            // list_maquinas
            // 
            list_maquinas.FormattingEnabled = true;
            list_maquinas.ItemHeight = 15;
            list_maquinas.Location = new Point(862, 255);
            list_maquinas.Name = "list_maquinas";
            list_maquinas.Size = new Size(190, 274);
            list_maquinas.TabIndex = 19;
            // 
            // lbl_baseMaquina
            // 
            lbl_baseMaquina.AutoSize = true;
            lbl_baseMaquina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_baseMaquina.Location = new Point(933, 140);
            lbl_baseMaquina.Name = "lbl_baseMaquina";
            lbl_baseMaquina.Size = new Size(51, 25);
            lbl_baseMaquina.TabIndex = 30;
            lbl_baseMaquina.Text = "Base";
            // 
            // list_loteMaquina
            // 
            list_loteMaquina.FormattingEnabled = true;
            list_loteMaquina.ItemHeight = 15;
            list_loteMaquina.Location = new Point(466, 255);
            list_loteMaquina.Name = "list_loteMaquina";
            list_loteMaquina.Size = new Size(190, 274);
            list_loteMaquina.TabIndex = 18;
            // 
            // txt_IDloteMaquinas
            // 
            txt_IDloteMaquinas.Enabled = false;
            txt_IDloteMaquinas.Location = new Point(526, 169);
            txt_IDloteMaquinas.Name = "txt_IDloteMaquinas";
            txt_IDloteMaquinas.Size = new Size(68, 23);
            txt_IDloteMaquinas.TabIndex = 28;
            // 
            // lbl_LoteMaquina
            // 
            lbl_LoteMaquina.AutoSize = true;
            lbl_LoteMaquina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_LoteMaquina.Location = new Point(523, 141);
            lbl_LoteMaquina.Name = "lbl_LoteMaquina";
            lbl_LoteMaquina.Size = new Size(71, 25);
            lbl_LoteMaquina.TabIndex = 27;
            lbl_LoteMaquina.Text = "ID Lote";
            // 
            // lbl_agregarMaquina
            // 
            lbl_agregarMaquina.AutoSize = true;
            lbl_agregarMaquina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_agregarMaquina.Location = new Point(730, 316);
            lbl_agregarMaquina.Name = "lbl_agregarMaquina";
            lbl_agregarMaquina.Size = new Size(66, 21);
            lbl_agregarMaquina.TabIndex = 25;
            lbl_agregarMaquina.Text = "Agregar";
            // 
            // lbl_SacarMaquina
            // 
            lbl_SacarMaquina.AutoSize = true;
            lbl_SacarMaquina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SacarMaquina.Location = new Point(739, 422);
            lbl_SacarMaquina.Name = "lbl_SacarMaquina";
            lbl_SacarMaquina.Size = new Size(48, 21);
            lbl_SacarMaquina.TabIndex = 26;
            lbl_SacarMaquina.Text = "Sacar";
            // 
            // lbl_maquinaLote
            // 
            lbl_maquinaLote.AutoSize = true;
            lbl_maquinaLote.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_maquinaLote.Location = new Point(535, 227);
            lbl_maquinaLote.Name = "lbl_maquinaLote";
            lbl_maquinaLote.Size = new Size(48, 25);
            lbl_maquinaLote.TabIndex = 24;
            lbl_maquinaLote.Text = "Lote";
            // 
            // btn_guardar_loteMaquina
            // 
            btn_guardar_loteMaquina.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guardar_loteMaquina.Location = new Point(506, 555);
            btn_guardar_loteMaquina.Name = "btn_guardar_loteMaquina";
            btn_guardar_loteMaquina.Size = new Size(109, 40);
            btn_guardar_loteMaquina.TabIndex = 22;
            btn_guardar_loteMaquina.Text = "Crear";
            btn_guardar_loteMaquina.UseVisualStyleBackColor = true;
            btn_guardar_loteMaquina.Click += btn_guardar_loteMaquina_Click;
            // 
            // btn_sacarMaquina
            // 
            btn_sacarMaquina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sacarMaquina.Location = new Point(717, 446);
            btn_sacarMaquina.Name = "btn_sacarMaquina";
            btn_sacarMaquina.Size = new Size(93, 31);
            btn_sacarMaquina.TabIndex = 21;
            btn_sacarMaquina.Text = ">>>>";
            btn_sacarMaquina.UseVisualStyleBackColor = true;
            btn_sacarMaquina.Click += btn_sacarMaquina_Click;
            // 
            // btn_agregarMaquina
            // 
            btn_agregarMaquina.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_agregarMaquina.Location = new Point(717, 340);
            btn_agregarMaquina.Name = "btn_agregarMaquina";
            btn_agregarMaquina.Size = new Size(93, 31);
            btn_agregarMaquina.TabIndex = 20;
            btn_agregarMaquina.Text = "<<<<";
            btn_agregarMaquina.UseVisualStyleBackColor = true;
            btn_agregarMaquina.Click += btn_agregarMaquina_Click;
            // 
            // data_grid_lotesMaquina
            // 
            data_grid_lotesMaquina.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid_lotesMaquina.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            data_grid_lotesMaquina.Location = new Point(-4, 0);
            data_grid_lotesMaquina.Name = "data_grid_lotesMaquina";
            data_grid_lotesMaquina.RowTemplate.Height = 25;
            data_grid_lotesMaquina.Size = new Size(442, 635);
            data_grid_lotesMaquina.TabIndex = 1;
            data_grid_lotesMaquina.CellContentClick += data_grid_lotesMaquina_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Base";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 50;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Precio final";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Vendido";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmAdministrarLotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "frmAdministrarLotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdministrarLotes";
            Load += frmAdministrarLotes_Load;
            ((System.ComponentModel.ISupportInitialize)data_grid_lotesAnimal).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid_lotesMaquina).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView data_grid_lotesAnimal;
        private ListBox list_loteAnimal;
        private ListBox list_animales;
        private ListBox list_articulos;
        private Button btn_agregar;
        private Button btn_sacar;
        private ComboBox cmb_categoria;
        private Button btn_guardar_loteAnimal;
        private Button btn_modificar;
        private Button btn_eliminarLoteAnimal;
        private Label lbl_loteAnimal;
        private Label lbl_animalesDisponibles;
        private Label lbl_agregar;
        private Label lbl_sacar;
        private Label lbl_categoria;
        private Label lbl_idLoteAnimal;
        private TextBox txt_idLoteAnimal;
        private TextBox txt_baseAnimal;
        private Label lbl_baseAnimal;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView data_grid_lotesMaquina;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button btn_eliminarLoteMaquina;
        private TextBox txt_baseMaquina;
        private ListBox list_maquinas;
        private Label lbl_baseMaquina;
        private ListBox list_loteMaquina;
        private TextBox txt_IDloteMaquinas;
        private Label lbl_LoteMaquina;
        private Label lbl_agregarMaquina;
        private Label lbl_SacarMaquina;
        private Label lbl_maquinaLote;
        private Button btn_guardar_loteMaquina;
        private Button btn_sacarMaquina;
        private Button btn_agregarMaquina;
        private Label lbl_maquinasDisponibles;
        private Button btn_modificar_animal;
        private Button btn_modificarLoteMaquina;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Base;
        private DataGridViewTextBoxColumn Precio_final;
        private DataGridViewTextBoxColumn Vendido;
    }
}