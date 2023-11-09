namespace Programacion_Login
{
    partial class frmLogin
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
            lbl_user = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            lbl_pass = new Label();
            button1 = new Button();
            btn_Ocultar = new FontAwesome.Sharp.IconButton();
            btn_Mostrar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // lbl_user
            // 
            lbl_user.AutoSize = true;
            lbl_user.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_user.ForeColor = Color.White;
            lbl_user.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_user.Location = new Point(43, 45);
            lbl_user.Name = "lbl_user";
            lbl_user.Size = new Size(116, 32);
            lbl_user.TabIndex = 0;
            lbl_user.Text = "Usuario";
            lbl_user.TextAlign = ContentAlignment.MiddleCenter;
            lbl_user.Click += lbl_user_Click;
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.FromArgb(0, 62, 23);
            txt_user.BorderStyle = BorderStyle.None;
            txt_user.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = Color.White;
            txt_user.Location = new Point(46, 80);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(343, 33);
            txt_user.TabIndex = 1;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(0, 62, 23);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = Color.White;
            txt_pass.Location = new Point(43, 185);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new Size(310, 33);
            txt_pass.TabIndex = 3;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pass.ForeColor = Color.White;
            lbl_pass.ImageAlign = ContentAlignment.TopLeft;
            lbl_pass.Location = new Point(43, 150);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new Size(168, 32);
            lbl_pass.TabIndex = 2;
            lbl_pass.Text = "Contraseña";
            lbl_pass.TextAlign = ContentAlignment.MiddleCenter;
            lbl_pass.Click += lbl_pass_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(77, 154, 106);
            button1.DialogResult = DialogResult.OK;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(43, 301);
            button1.Name = "button1";
            button1.Size = new Size(346, 56);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_Ocultar
            // 
            btn_Ocultar.BackColor = Color.FromArgb(0, 62, 23);
            btn_Ocultar.FlatAppearance.BorderSize = 0;
            btn_Ocultar.FlatStyle = FlatStyle.Flat;
            btn_Ocultar.IconChar = FontAwesome.Sharp.IconChar.Eye;
            btn_Ocultar.IconColor = Color.White;
            btn_Ocultar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Ocultar.IconSize = 35;
            btn_Ocultar.Location = new Point(352, 185);
            btn_Ocultar.Name = "btn_Ocultar";
            btn_Ocultar.Size = new Size(37, 33);
            btn_Ocultar.TabIndex = 5;
            btn_Ocultar.UseVisualStyleBackColor = false;
            btn_Ocultar.Click += btn_Ocultar_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.FromArgb(0, 62, 23);
            btn_Mostrar.FlatAppearance.BorderSize = 0;
            btn_Mostrar.FlatStyle = FlatStyle.Flat;
            btn_Mostrar.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            btn_Mostrar.IconColor = Color.White;
            btn_Mostrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_Mostrar.IconSize = 35;
            btn_Mostrar.Location = new Point(352, 185);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(37, 33);
            btn_Mostrar.TabIndex = 6;
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 93, 44);
            ClientSize = new Size(435, 407);
            Controls.Add(btn_Mostrar);
            Controls.Add(btn_Ocultar);
            Controls.Add(button1);
            Controls.Add(txt_pass);
            Controls.Add(lbl_pass);
            Controls.Add(txt_user);
            Controls.Add(lbl_user);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_user;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Label lbl_pass;
        private Button button1;
        private FontAwesome.Sharp.IconButton btn_Ocultar;
        private FontAwesome.Sharp.IconButton btn_Mostrar;
    }
}