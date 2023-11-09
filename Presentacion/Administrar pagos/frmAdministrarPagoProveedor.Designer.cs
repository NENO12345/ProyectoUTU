namespace Programacion_Login.Administrar_pagos
{
    partial class frmAdministrarPagoProveedor
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
            Monto = new DataGridViewTextBoxColumn();
            Tipo_de_pago = new DataGridViewTextBoxColumn();
            Informacion = new DataGridViewTextBoxColumn();
            Estado_Pago = new DataGridViewTextBoxColumn();
            Prov = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            lbl_marcar = new Button();
            lbl_proveedor = new Label();
            cmb_proveedor = new ComboBox();
            btn_eliminar = new Button();
            btn_paypal_agregar = new Button();
            btn_pagar = new Button();
            lbl_correo = new Label();
            txt_correo = new TextBox();
            label3 = new Label();
            dateTimePicker1_paypal = new DateTimePicker();
            label2 = new Label();
            txt_paypal_monto = new TextBox();
            txt_paypal_id = new Label();
            txt_paypal_idd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Monto, Tipo_de_pago, Informacion, Estado_Pago, Prov, Fecha });
            dataGridView1.Location = new Point(0, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(468, 655);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 40;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto";
            Monto.Name = "Monto";
            Monto.ReadOnly = true;
            // 
            // Tipo_de_pago
            // 
            Tipo_de_pago.HeaderText = "Tipo de pago";
            Tipo_de_pago.Name = "Tipo_de_pago";
            Tipo_de_pago.ReadOnly = true;
            // 
            // Informacion
            // 
            Informacion.HeaderText = "Informacion";
            Informacion.Name = "Informacion";
            Informacion.ReadOnly = true;
            // 
            // Estado_Pago
            // 
            Estado_Pago.HeaderText = "Estado pago";
            Estado_Pago.Name = "Estado_Pago";
            Estado_Pago.ReadOnly = true;
            // 
            // Prov
            // 
            Prov.HeaderText = "Proveedor";
            Prov.Name = "Prov";
            Prov.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(474, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(613, 655);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lbl_marcar);
            tabPage1.Controls.Add(lbl_proveedor);
            tabPage1.Controls.Add(cmb_proveedor);
            tabPage1.Controls.Add(btn_eliminar);
            tabPage1.Controls.Add(btn_paypal_agregar);
            tabPage1.Controls.Add(btn_pagar);
            tabPage1.Controls.Add(lbl_correo);
            tabPage1.Controls.Add(txt_correo);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(dateTimePicker1_paypal);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txt_paypal_monto);
            tabPage1.Controls.Add(txt_paypal_id);
            tabPage1.Controls.Add(txt_paypal_idd);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(605, 627);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Paypal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(448, 295);
            label7.Name = "label7";
            label7.Size = new Size(75, 30);
            label7.TabIndex = 21;
            label7.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(448, 211);
            label6.Name = "label6";
            label6.Size = new Size(75, 30);
            label6.TabIndex = 20;
            label6.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(433, 135);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 19;
            label5.Text = "Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(94, 215);
            label4.Name = "label4";
            label4.Size = new Size(67, 30);
            label4.TabIndex = 18;
            label4.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 139);
            label1.Name = "label1";
            label1.Size = new Size(34, 30);
            label1.TabIndex = 17;
            label1.Text = "ID";
            // 
            // lbl_marcar
            // 
            lbl_marcar.Location = new Point(22, 386);
            lbl_marcar.Name = "lbl_marcar";
            lbl_marcar.Size = new Size(139, 34);
            lbl_marcar.TabIndex = 16;
            lbl_marcar.Text = "Marcar como pago";
            lbl_marcar.UseVisualStyleBackColor = true;
            lbl_marcar.Click += lbl_marcar_Click;
            // 
            // lbl_proveedor
            // 
            lbl_proveedor.AutoSize = true;
            lbl_proveedor.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_proveedor.Location = new Point(433, 135);
            lbl_proveedor.Name = "lbl_proveedor";
            lbl_proveedor.Size = new Size(0, 30);
            lbl_proveedor.TabIndex = 15;
            // 
            // cmb_proveedor
            // 
            cmb_proveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_proveedor.FormattingEnabled = true;
            cmb_proveedor.Location = new Point(386, 168);
            cmb_proveedor.Name = "cmb_proveedor";
            cmb_proveedor.Size = new Size(200, 23);
            cmb_proveedor.TabIndex = 14;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Location = new Point(480, 569);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(106, 39);
            btn_eliminar.TabIndex = 13;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // btn_paypal_agregar
            // 
            btn_paypal_agregar.Location = new Point(22, 569);
            btn_paypal_agregar.Name = "btn_paypal_agregar";
            btn_paypal_agregar.Size = new Size(106, 39);
            btn_paypal_agregar.TabIndex = 11;
            btn_paypal_agregar.Text = "Agregar";
            btn_paypal_agregar.UseVisualStyleBackColor = true;
            btn_paypal_agregar.Click += btn_paypal_agregar_Click;
            // 
            // btn_pagar
            // 
            btn_pagar.Location = new Point(480, 386);
            btn_pagar.Name = "btn_pagar";
            btn_pagar.Size = new Size(106, 34);
            btn_pagar.TabIndex = 10;
            btn_pagar.Text = "Pagar";
            btn_pagar.UseVisualStyleBackColor = true;
            btn_pagar.Click += btn_pagar_Click;
            // 
            // lbl_correo
            // 
            lbl_correo.AutoSize = true;
            lbl_correo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_correo.Location = new Point(398, 295);
            lbl_correo.Name = "lbl_correo";
            lbl_correo.Size = new Size(0, 30);
            lbl_correo.TabIndex = 9;
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(386, 328);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(200, 23);
            txt_correo.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(94, 215);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 7;
            // 
            // dateTimePicker1_paypal
            // 
            dateTimePicker1_paypal.Location = new Point(31, 248);
            dateTimePicker1_paypal.Name = "dateTimePicker1_paypal";
            dateTimePicker1_paypal.Size = new Size(200, 23);
            dateTimePicker1_paypal.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 211);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 4;
            label2.Click += label2_Click;
            // 
            // txt_paypal_monto
            // 
            txt_paypal_monto.Location = new Point(386, 244);
            txt_paypal_monto.Name = "txt_paypal_monto";
            txt_paypal_monto.Size = new Size(200, 23);
            txt_paypal_monto.TabIndex = 2;
            // 
            // txt_paypal_id
            // 
            txt_paypal_id.AutoSize = true;
            txt_paypal_id.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txt_paypal_id.Location = new Point(109, 139);
            txt_paypal_id.Name = "txt_paypal_id";
            txt_paypal_id.Size = new Size(0, 30);
            txt_paypal_id.TabIndex = 1;
            // 
            // txt_paypal_idd
            // 
            txt_paypal_idd.Enabled = false;
            txt_paypal_idd.Location = new Point(31, 172);
            txt_paypal_idd.Name = "txt_paypal_idd";
            txt_paypal_idd.Size = new Size(200, 23);
            txt_paypal_idd.TabIndex = 0;
            txt_paypal_idd.TextAlign = HorizontalAlignment.Center;
            txt_paypal_idd.TextChanged += textBox1_TextChanged;
            // 
            // frmAdministrarPagoProveedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 657);
            Controls.Add(tabControl1);
            Controls.Add(dataGridView1);
            MaximizeBox = false;
            Name = "frmAdministrarPagoProveedor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAdministrarPagoProveedor";
            Load += frmAdministrarPagoProveedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Monto;
        private DataGridViewTextBoxColumn Tipo_de_pago;
        private DataGridViewTextBoxColumn Informacion;
        private DataGridViewTextBoxColumn Estado_Pago;
        private DataGridViewTextBoxColumn Prov;
        private DataGridViewTextBoxColumn Fecha;
        private TabPage tabPage1;
        private Button lbl_marcar;
        private Label lbl_proveedor;
        private ComboBox cmb_proveedor;
        private Button btn_eliminar;
        private Button btn_paypal_agregar;
        private Button btn_pagar;
        private Label lbl_correo;
        private TextBox txt_correo;
        private Label label3;
        private DateTimePicker dateTimePicker1_paypal;
        private Label label2;
        private TextBox txt_paypal_monto;
        private Label txt_paypal_id;
        private TextBox txt_paypal_idd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
    }
}