namespace SOWAD_T3_ESCRITORIO
{
    partial class frmModificarVehiculo
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
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.cbxtipo = new System.Windows.Forms.ComboBox();
            this.vehiculos_bt_crearNuevoVehiculo = new System.Windows.Forms.Button();
            this.txtnroplaca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(139, 155);
            this.txtcapacidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(197, 20);
            this.txtcapacidad.TabIndex = 30;
            // 
            // cbxtipo
            // 
            this.cbxtipo.FormattingEnabled = true;
            this.cbxtipo.Items.AddRange(new object[] {
            "Bus",
            "Minivan"});
            this.cbxtipo.Location = new System.Drawing.Point(139, 204);
            this.cbxtipo.Margin = new System.Windows.Forms.Padding(2);
            this.cbxtipo.Name = "cbxtipo";
            this.cbxtipo.Size = new System.Drawing.Size(197, 21);
            this.cbxtipo.TabIndex = 29;
            // 
            // vehiculos_bt_crearNuevoVehiculo
            // 
            this.vehiculos_bt_crearNuevoVehiculo.Location = new System.Drawing.Point(129, 272);
            this.vehiculos_bt_crearNuevoVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.vehiculos_bt_crearNuevoVehiculo.Name = "vehiculos_bt_crearNuevoVehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.Size = new System.Drawing.Size(104, 29);
            this.vehiculos_bt_crearNuevoVehiculo.TabIndex = 28;
            this.vehiculos_bt_crearNuevoVehiculo.Text = "Modificar vehiculo";
            this.vehiculos_bt_crearNuevoVehiculo.UseVisualStyleBackColor = true;
            this.vehiculos_bt_crearNuevoVehiculo.Click += new System.EventHandler(this.vehiculos_bt_crearNuevoVehiculo_Click);
            // 
            // txtnroplaca
            // 
            this.txtnroplaca.Location = new System.Drawing.Point(139, 105);
            this.txtnroplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtnroplaca.Name = "txtnroplaca";
            this.txtnroplaca.Size = new System.Drawing.Size(197, 20);
            this.txtnroplaca.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tipo de vehiculo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Capacidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Numero de placa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "MODIFICAR VEHICULO";
            // 
            // frmModificarVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 337);
            this.Controls.Add(this.txtcapacidad);
            this.Controls.Add(this.cbxtipo);
            this.Controls.Add(this.vehiculos_bt_crearNuevoVehiculo);
            this.Controls.Add(this.txtnroplaca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmModificarVehiculo";
            this.Text = "Modificar Vehículo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.ComboBox cbxtipo;
        private System.Windows.Forms.Button vehiculos_bt_crearNuevoVehiculo;
        private System.Windows.Forms.TextBox txtnroplaca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}