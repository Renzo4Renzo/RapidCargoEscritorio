namespace SOWAD_T3_ESCRITORIO
{
    partial class frmCrearPersonal
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
            this.personal_tb_nombres = new System.Windows.Forms.TextBox();
            this.crearPersonal_bt_crearPersonal = new System.Windows.Forms.Button();
            this.personal_tb_DNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.personal_tb_direccion = new System.Windows.Forms.TextBox();
            this.personal_tb_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.personal_tb_apellidos = new System.Windows.Forms.TextBox();
            this.personal_tb_correoCorporativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.crearPersonal_rb_masculino = new System.Windows.Forms.RadioButton();
            this.crearPersonal_rb_femenino = new System.Windows.Forms.RadioButton();
            this.crearPersonal_tb_contrasena = new System.Windows.Forms.TextBox();
            this.crearPersonal_tb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.crearPersonal_cb_tipoUsuario = new System.Windows.Forms.ComboBox();
            this.crearPersonal_cb_sucursal = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // personal_tb_nombres
            // 
            this.personal_tb_nombres.Location = new System.Drawing.Point(200, 157);
            this.personal_tb_nombres.Name = "personal_tb_nombres";
            this.personal_tb_nombres.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_nombres.TabIndex = 30;
            // 
            // crearPersonal_bt_crearPersonal
            // 
            this.crearPersonal_bt_crearPersonal.Location = new System.Drawing.Point(657, 403);
            this.crearPersonal_bt_crearPersonal.Name = "crearPersonal_bt_crearPersonal";
            this.crearPersonal_bt_crearPersonal.Size = new System.Drawing.Size(139, 36);
            this.crearPersonal_bt_crearPersonal.TabIndex = 28;
            this.crearPersonal_bt_crearPersonal.Text = "Agregar personal";
            this.crearPersonal_bt_crearPersonal.UseVisualStyleBackColor = true;
            this.crearPersonal_bt_crearPersonal.Click += new System.EventHandler(this.crearPersonal_bt_crearPersonal_Click);
            // 
            // personal_tb_DNI
            // 
            this.personal_tb_DNI.Location = new System.Drawing.Point(200, 95);
            this.personal_tb_DNI.MaxLength = 8;
            this.personal_tb_DNI.Name = "personal_tb_DNI";
            this.personal_tb_DNI.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_DNI.TabIndex = 27;
            this.personal_tb_DNI.TextChanged += new System.EventHandler(this.personal_tb_DNI_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "NUEVO PERSONAL";
            // 
            // personal_tb_direccion
            // 
            this.personal_tb_direccion.Location = new System.Drawing.Point(200, 344);
            this.personal_tb_direccion.Name = "personal_tb_direccion";
            this.personal_tb_direccion.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_direccion.TabIndex = 34;
            // 
            // personal_tb_telefono
            // 
            this.personal_tb_telefono.Location = new System.Drawing.Point(200, 282);
            this.personal_tb_telefono.Name = "personal_tb_telefono";
            this.personal_tb_telefono.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_telefono.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Direccion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Telefono:";
            // 
            // personal_tb_apellidos
            // 
            this.personal_tb_apellidos.Location = new System.Drawing.Point(200, 217);
            this.personal_tb_apellidos.Name = "personal_tb_apellidos";
            this.personal_tb_apellidos.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_apellidos.TabIndex = 38;
            // 
            // personal_tb_correoCorporativo
            // 
            this.personal_tb_correoCorporativo.Location = new System.Drawing.Point(644, 342);
            this.personal_tb_correoCorporativo.Name = "personal_tb_correoCorporativo";
            this.personal_tb_correoCorporativo.Size = new System.Drawing.Size(261, 22);
            this.personal_tb_correoCorporativo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Correo corporativo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Genero:";
            // 
            // crearPersonal_rb_masculino
            // 
            this.crearPersonal_rb_masculino.AutoSize = true;
            this.crearPersonal_rb_masculino.Location = new System.Drawing.Point(200, 411);
            this.crearPersonal_rb_masculino.Name = "crearPersonal_rb_masculino";
            this.crearPersonal_rb_masculino.Size = new System.Drawing.Size(109, 21);
            this.crearPersonal_rb_masculino.TabIndex = 40;
            this.crearPersonal_rb_masculino.TabStop = true;
            this.crearPersonal_rb_masculino.Text = "MASCULINO";
            this.crearPersonal_rb_masculino.UseVisualStyleBackColor = true;
            // 
            // crearPersonal_rb_femenino
            // 
            this.crearPersonal_rb_femenino.AutoSize = true;
            this.crearPersonal_rb_femenino.Location = new System.Drawing.Point(354, 411);
            this.crearPersonal_rb_femenino.Name = "crearPersonal_rb_femenino";
            this.crearPersonal_rb_femenino.Size = new System.Drawing.Size(100, 21);
            this.crearPersonal_rb_femenino.TabIndex = 41;
            this.crearPersonal_rb_femenino.TabStop = true;
            this.crearPersonal_rb_femenino.Text = "FEMENINO";
            this.crearPersonal_rb_femenino.UseVisualStyleBackColor = true;
            // 
            // crearPersonal_tb_contrasena
            // 
            this.crearPersonal_tb_contrasena.Location = new System.Drawing.Point(644, 155);
            this.crearPersonal_tb_contrasena.Name = "crearPersonal_tb_contrasena";
            this.crearPersonal_tb_contrasena.Size = new System.Drawing.Size(261, 22);
            this.crearPersonal_tb_contrasena.TabIndex = 46;
            // 
            // crearPersonal_tb_nombreUsuario
            // 
            this.crearPersonal_tb_nombreUsuario.Location = new System.Drawing.Point(644, 93);
            this.crearPersonal_tb_nombreUsuario.Name = "crearPersonal_tb_nombreUsuario";
            this.crearPersonal_tb_nombreUsuario.Size = new System.Drawing.Size(261, 22);
            this.crearPersonal_tb_nombreUsuario.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(503, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Tipo Usuario:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 43;
            this.label11.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(503, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Nombre de usuario:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(503, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "Sucursal:";
            // 
            // crearPersonal_cb_tipoUsuario
            // 
            this.crearPersonal_cb_tipoUsuario.FormattingEnabled = true;
            this.crearPersonal_cb_tipoUsuario.Location = new System.Drawing.Point(644, 215);
            this.crearPersonal_cb_tipoUsuario.Name = "crearPersonal_cb_tipoUsuario";
            this.crearPersonal_cb_tipoUsuario.Size = new System.Drawing.Size(261, 24);
            this.crearPersonal_cb_tipoUsuario.TabIndex = 48;
            // 
            // crearPersonal_cb_sucursal
            // 
            this.crearPersonal_cb_sucursal.FormattingEnabled = true;
            this.crearPersonal_cb_sucursal.Location = new System.Drawing.Point(644, 280);
            this.crearPersonal_cb_sucursal.Name = "crearPersonal_cb_sucursal";
            this.crearPersonal_cb_sucursal.Size = new System.Drawing.Size(261, 24);
            this.crearPersonal_cb_sucursal.TabIndex = 49;
            // 
            // frmCrearPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 487);
            this.Controls.Add(this.crearPersonal_cb_sucursal);
            this.Controls.Add(this.crearPersonal_cb_tipoUsuario);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.crearPersonal_tb_contrasena);
            this.Controls.Add(this.crearPersonal_tb_nombreUsuario);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.crearPersonal_rb_femenino);
            this.Controls.Add(this.crearPersonal_rb_masculino);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.personal_tb_apellidos);
            this.Controls.Add(this.personal_tb_correoCorporativo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.personal_tb_direccion);
            this.Controls.Add(this.personal_tb_telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.personal_tb_nombres);
            this.Controls.Add(this.crearPersonal_bt_crearPersonal);
            this.Controls.Add(this.personal_tb_DNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearPersonal";
            this.Text = "Crear personal";
            this.Load += new System.EventHandler(this.frmCrearPersonal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox personal_tb_nombres;
        private System.Windows.Forms.Button crearPersonal_bt_crearPersonal;
        private System.Windows.Forms.TextBox personal_tb_DNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox personal_tb_direccion;
        private System.Windows.Forms.TextBox personal_tb_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox personal_tb_apellidos;
        private System.Windows.Forms.TextBox personal_tb_correoCorporativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton crearPersonal_rb_masculino;
        private System.Windows.Forms.RadioButton crearPersonal_rb_femenino;
        private System.Windows.Forms.TextBox crearPersonal_tb_contrasena;
        private System.Windows.Forms.TextBox crearPersonal_tb_nombreUsuario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox crearPersonal_cb_tipoUsuario;
        private System.Windows.Forms.ComboBox crearPersonal_cb_sucursal;
    }
}