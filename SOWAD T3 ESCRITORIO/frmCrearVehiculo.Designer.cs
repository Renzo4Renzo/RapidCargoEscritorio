namespace SOWAD_T3_ESCRITORIO
{
    partial class frmCrearVehiculo
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
            this.vehiculos_cb_tipoVehiculo = new System.Windows.Forms.ComboBox();
            this.vehiculos_bt_crearNuevoVehiculo = new System.Windows.Forms.Button();
            this.vehiculos_tb_numeroPlaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vehiculos_tb_capacidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // vehiculos_cb_tipoVehiculo
            // 
            this.vehiculos_cb_tipoVehiculo.FormattingEnabled = true;
            this.vehiculos_cb_tipoVehiculo.Location = new System.Drawing.Point(146, 168);
            this.vehiculos_cb_tipoVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_cb_tipoVehiculo.Name = "vehiculos_cb_tipoVehiculo";
            this.vehiculos_cb_tipoVehiculo.Size = new System.Drawing.Size(197, 21);
            this.vehiculos_cb_tipoVehiculo.TabIndex = 21;
            this.vehiculos_cb_tipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.vehiculos_cb_tipoVehiculo_SelectedIndexChanged);
            // 
            // vehiculos_bt_crearNuevoVehiculo
            // 
            this.vehiculos_bt_crearNuevoVehiculo.Location = new System.Drawing.Point(135, 227);
            this.vehiculos_bt_crearNuevoVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_bt_crearNuevoVehiculo.Name = "vehiculos_bt_crearNuevoVehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.Size = new System.Drawing.Size(104, 29);
            this.vehiculos_bt_crearNuevoVehiculo.TabIndex = 17;
            this.vehiculos_bt_crearNuevoVehiculo.Text = "Agregar vehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.UseVisualStyleBackColor = true;
            this.vehiculos_bt_crearNuevoVehiculo.Click += new System.EventHandler(this.vehiculos_bt_crearNuevoVehiculo_Click);
            // 
            // vehiculos_tb_numeroPlaca
            // 
            this.vehiculos_tb_numeroPlaca.Location = new System.Drawing.Point(146, 69);
            this.vehiculos_tb_numeroPlaca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_tb_numeroPlaca.Name = "vehiculos_tb_numeroPlaca";
            this.vehiculos_tb_numeroPlaca.Size = new System.Drawing.Size(197, 20);
            this.vehiculos_tb_numeroPlaca.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo de vehiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero de placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "NUEVO VEHICULO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // vehiculos_tb_capacidad
            // 
            this.vehiculos_tb_capacidad.Location = new System.Drawing.Point(146, 119);
            this.vehiculos_tb_capacidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.vehiculos_tb_capacidad.Name = "vehiculos_tb_capacidad";
            this.vehiculos_tb_capacidad.Size = new System.Drawing.Size(197, 20);
            this.vehiculos_tb_capacidad.TabIndex = 22;
            this.vehiculos_tb_capacidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vehiculos_tb_capacidad_KeyPress);
            // 
            // frmCrearVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 285);
            this.Controls.Add(this.vehiculos_tb_capacidad);
            this.Controls.Add(this.vehiculos_cb_tipoVehiculo);
            this.Controls.Add(this.vehiculos_bt_crearNuevoVehiculo);
            this.Controls.Add(this.vehiculos_tb_numeroPlaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCrearVehiculo";
            this.Text = "Crear vehiculo";
            this.Load += new System.EventHandler(this.frmCrearVehiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vehiculos_cb_tipoVehiculo;
        private System.Windows.Forms.Button vehiculos_bt_crearNuevoVehiculo;
        private System.Windows.Forms.TextBox vehiculos_tb_numeroPlaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vehiculos_tb_capacidad;
    }
}