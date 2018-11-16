namespace SOWAD_T3_ESCRITORIO
{
    partial class frmCrearRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rutas_tb_nombreNuevaRuta = new System.Windows.Forms.TextBox();
            this.rutas_bt_crearNuevaRuta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rutas_tb_descripcionRuta = new System.Windows.Forms.TextBox();
            this.rutas_cb_ciudadOrigen = new System.Windows.Forms.ComboBox();
            this.rutas_cb_ciudadDestino = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUEVA RUTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ciudad de origen:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ciudad de destino:";
            // 
            // rutas_tb_nombreNuevaRuta
            // 
            this.rutas_tb_nombreNuevaRuta.Location = new System.Drawing.Point(193, 79);
            this.rutas_tb_nombreNuevaRuta.Name = "rutas_tb_nombreNuevaRuta";
            this.rutas_tb_nombreNuevaRuta.Size = new System.Drawing.Size(261, 22);
            this.rutas_tb_nombreNuevaRuta.TabIndex = 4;
            this.rutas_tb_nombreNuevaRuta.TextChanged += new System.EventHandler(this.rutas_tb_nombreNuevaRuta_TextChanged);
            // 
            // rutas_bt_crearNuevaRuta
            // 
            this.rutas_bt_crearNuevaRuta.Location = new System.Drawing.Point(176, 326);
            this.rutas_bt_crearNuevaRuta.Name = "rutas_bt_crearNuevaRuta";
            this.rutas_bt_crearNuevaRuta.Size = new System.Drawing.Size(139, 36);
            this.rutas_bt_crearNuevaRuta.TabIndex = 7;
            this.rutas_bt_crearNuevaRuta.Text = "Agregar ruta";
            this.rutas_bt_crearNuevaRuta.UseVisualStyleBackColor = true;
            this.rutas_bt_crearNuevaRuta.Click += new System.EventHandler(this.rutas_bt_crearNuevaRuta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descripción:";
            // 
            // rutas_tb_descripcionRuta
            // 
            this.rutas_tb_descripcionRuta.Location = new System.Drawing.Point(193, 265);
            this.rutas_tb_descripcionRuta.Name = "rutas_tb_descripcionRuta";
            this.rutas_tb_descripcionRuta.Size = new System.Drawing.Size(261, 22);
            this.rutas_tb_descripcionRuta.TabIndex = 9;
            // 
            // rutas_cb_ciudadOrigen
            // 
            this.rutas_cb_ciudadOrigen.FormattingEnabled = true;
            this.rutas_cb_ciudadOrigen.Location = new System.Drawing.Point(193, 141);
            this.rutas_cb_ciudadOrigen.Name = "rutas_cb_ciudadOrigen";
            this.rutas_cb_ciudadOrigen.Size = new System.Drawing.Size(261, 24);
            this.rutas_cb_ciudadOrigen.TabIndex = 10;
            this.rutas_cb_ciudadOrigen.SelectedIndexChanged += new System.EventHandler(this.rutas_cb_ciudadOrigen_SelectedIndexChanged);
            // 
            // rutas_cb_ciudadDestino
            // 
            this.rutas_cb_ciudadDestino.FormattingEnabled = true;
            this.rutas_cb_ciudadDestino.Location = new System.Drawing.Point(193, 201);
            this.rutas_cb_ciudadDestino.Name = "rutas_cb_ciudadDestino";
            this.rutas_cb_ciudadDestino.Size = new System.Drawing.Size(261, 24);
            this.rutas_cb_ciudadDestino.TabIndex = 11;
            // 
            // frmCrearRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 391);
            this.Controls.Add(this.rutas_cb_ciudadDestino);
            this.Controls.Add(this.rutas_cb_ciudadOrigen);
            this.Controls.Add(this.rutas_tb_descripcionRuta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rutas_bt_crearNuevaRuta);
            this.Controls.Add(this.rutas_tb_nombreNuevaRuta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCrearRuta";
            this.Text = "Crear Ruta";
            this.Load += new System.EventHandler(this.frmCrearRuta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rutas_tb_nombreNuevaRuta;
        private System.Windows.Forms.Button rutas_bt_crearNuevaRuta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rutas_tb_descripcionRuta;
        private System.Windows.Forms.ComboBox rutas_cb_ciudadOrigen;
        private System.Windows.Forms.ComboBox rutas_cb_ciudadDestino;
    }
}